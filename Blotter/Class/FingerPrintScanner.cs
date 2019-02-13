using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP.Capture;
using DPFP;
using DPFP.Processing;
using System.IO;
using DPFP.Verification;
namespace AppSystem.Class
{
    class FingerPrintScanner
    {
        public static byte[] FingerprintTemplate;

        public static void MakeTemplate(Template template, Control ctrl)
        {
            MemoryStream ms = new MemoryStream();

            try
            {
                ctrl.Invoke(new Action(() =>
                {
                    template.Serialize(ms);
                    FingerprintTemplate = ms.ToArray();
                }));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void MakeReport(Control ctrl, string status)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new Action(() =>
                {
                    ((TextBox)ctrl).Text += status + Environment.NewLine;
                    ((TextBox)ctrl).SelectionLength = ((TextBox)ctrl).TextLength;
                    ((TextBox)ctrl).ScrollToCaret();
                }));
            }
        }
        public static void DrawPicture(PictureBox pct, Bitmap bmp)
        {
            if (pct.InvokeRequired)
            {
                pct.Invoke(new Action(() =>
                {
                    pct.Image = bmp;

                }));
            }
        }
        public static Bitmap ConvertSampleToBitmap(Sample sample)
        {
            SampleConversion convertor = new SampleConversion();
            Bitmap bmp = null;
            convertor.ConvertToPicture(sample, ref bmp);
            return bmp;
        }
        public static FeatureSet ExtractFeatures(Sample sample, DataPurpose datapurpose)
        {
            FeatureExtraction extractor = new FeatureExtraction();
            CaptureFeedback feedback = CaptureFeedback.None;
            FeatureSet feature = new FeatureSet();
            extractor.CreateFeatureSet(sample, datapurpose, ref feedback, ref feature);
            if (feedback == CaptureFeedback.Good)
            {
                return feature;
            }
            else
            {
                return null;
            }
        }

        public static Verification.Result VerificationResult(Sample sample, Verification verificator, byte[] fingerprint)
        {
            Verification.Result res = new Verification.Result();
            try
            {
                Template template = new Template(new MemoryStream(fingerprint));
                FeatureSet features = ExtractFeatures(sample, DataPurpose.Verification);
                verificator.Verify(features, template, ref res);
            }
            catch (Exception)
            {
            }
         
            return res;
        }
    }
}
