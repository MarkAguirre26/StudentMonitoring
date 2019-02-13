using Camera_NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camera_NET;
using DirectShowLib;


namespace AppSystem
{
    public partial class frm_camera : Form
    {

       
      
        public frm_camera()
        {
            InitializeComponent();
        }


        private void frm_camera_Load(object sender, EventArgs e)
        {
             CameraChoice _CameraChoice = new CameraChoice();

            // Get List of devices (cameras)
            _CameraChoice.UpdateDeviceList();

            // To get an example of camera and resolution change look at other code samples 
            if (_CameraChoice.Devices.Count > 0)
            {
                // Device moniker. It's like device id or handle.
                // Run first camera if we have one
                var camera_moniker = _CameraChoice.Devices[0].Mon;

                // Set selected camera to camera control with default resolution
                imgVideo.SetCamera(camera_moniker, null);
            }


        }
           

        private void frm_camera_FormClosing(object sender, FormClosingEventArgs e)
        {
                 imgVideo.CloseCamera(); 
        }

       

        private void cmd_capture_Click(object sender, EventArgs e)
        {
            
            if (!imgVideo.CameraCreated)
                return;

            Bitmap bitmap = imgVideo.SnapshotOutputImage();

            if (bitmap == null)
                return;

            imgCapture.Image = bitmap;
            imgCapture.Update();


          //  imgCapture.Image = imgVideo
            imgVideo.Visible = false;
            imgCapture.Visible = true;
            cmd_reset.Enabled = true; cmd_save.Enabled = true; cmd_capture.Enabled = false;
        }

        private void cmd_reset_Click(object sender, EventArgs e)
        {
            try
            {

                imgCapture.Image = null;
                imgVideo.Visible = true;
                imgCapture.Visible = false;
                cmd_reset.Enabled = false; cmd_save.Enabled = false; cmd_capture.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     

        private void cmd_save_Click(object sender, EventArgs e)
        {
            var f = (Application.OpenForms["frm_user"] as frm_user);
            //.Image = imgCapture.Image;      
            if (f.wizard1.SelectedTab == f.tabPage3)
            {
                f.pbUser.Image = imgCapture.Image;
            }
            else
            {
                f.pbStudent.Image = imgCapture.Image;
            }
          
            this.Close();
        }

    }
}
