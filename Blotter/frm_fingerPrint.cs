using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP.Capture;
using AppSystem.Class;
using DPFP.Processing;
using DPFP;
namespace AppSystem
{
    public partial class frm_fingerPrint : Form, DPFP.Capture.EventHandler
    {
        Capture capture = new Capture();
        Enrollment enroller = new Enrollment();
        void init()
        {
            capture.StartCapture();
            capture.EventHandler = this;
        }
        public frm_fingerPrint()
        {
            InitializeComponent();
        }

        private void frm_fingerPrint_Load(object sender, EventArgs e)
        {
            init();
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            FingerPrintScanner.DrawPicture(pic_left, FingerPrintScanner.ConvertSampleToBitmap(Sample));
            try
            {
                FeatureSet feature = FingerPrintScanner.ExtractFeatures(Sample, DataPurpose.Enrollment);
                enroller.AddFeatures(feature);
                FingerPrintScanner.MakeReport(txtStatus, String.Format("Fingerprint samples needed: {0}", enroller.FeaturesNeeded));
                switch (enroller.TemplateStatus)
                {
                    case Enrollment.Status.Failed:
                        FingerPrintScanner.MakeReport(txtStatus, String.Format("Fingerprint samples needed: {0}", enroller.FeaturesNeeded));
                        break;
                    case Enrollment.Status.Insufficient:
                        break;
                    case Enrollment.Status.Ready:
                        FingerPrintScanner.MakeReport(txtStatus, String.Format("Fingerprint samples needed: {0}", enroller.FeaturesNeeded));
                        capture.StopCapture();
                        FingerPrintScanner.MakeTemplate(enroller.Template, this);
                        break;
                    case Enrollment.Status.Unknown:
                        FingerPrintScanner.MakeReport(txtStatus, String.Format("Fingerprint samples needed: {0}", enroller.FeaturesNeeded));
                        break;
                    default:
                        FingerPrintScanner.MakeReport(txtStatus, String.Format("Fingerprint samples needed: {0}", enroller.FeaturesNeeded));
                        break;
                }
            }
            catch (Exception)
            {
                FingerPrintScanner.MakeReport(txtStatus, String.Format("Fingerprint samples needed: {0}", enroller.FeaturesNeeded));
                capture.StopCapture();
                enroller.Clear();
                capture.StartCapture();
            }
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            FingerPrintScanner.MakeReport(txtStatus, "Finger Remove");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            FingerPrintScanner.MakeReport(txtStatus, "Finger Touch");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            FingerPrintScanner.MakeReport(txtStatus, "Reader Connected");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            FingerPrintScanner.MakeReport(txtStatus, "Reader Disconnected");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            {
                FingerPrintScanner.MakeReport(txtStatus, "The quality of the fingerprint sample is good.");
            }
            else
            {
                FingerPrintScanner.MakeReport(txtStatus, "The quality of the fingerprint sample is poor.");
            }
        }

        private void frm_fingerPrint_FormClosed(object sender, FormClosedEventArgs e)
        {
            capture.StopCapture();
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            capture.StopCapture();
            this.Close();
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            capture.StopCapture();
            this.Close();
        }
    }
}
