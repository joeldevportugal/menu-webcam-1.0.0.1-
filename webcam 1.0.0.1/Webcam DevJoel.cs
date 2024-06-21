using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace webcam_1._0._0._1
{
    public partial class FreWebcam1 : Form
    {
        private bool imagemSalva = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public FreWebcam1()
        {
            InitializeComponent();
            LoadDevicesToComboBox();
        }

        private void LoadDevicesToComboBox()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                CmbDevice.Items.Add(device.Name);
            }

            if (CmbDevice.Items.Count > 0)
            {
                CmbDevice.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No video sources found");
            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.Stop();
            }

            videoSource = new VideoCaptureDevice(videoDevices[CmbDevice.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            picimagem.Image = bitmap;
        }

        private void BtnCapturar_Click(object sender, EventArgs e)
        {
            if (picimagem.Image != null)
            {
                Bitmap snapshot = new Bitmap(picimagem.Image);
                picCopia.Image = snapshot;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (picCopia.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPEG Image|*.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    picCopia.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagemSalva = true;
                    MessageBox.Show("Imagem Guardada Com sucesso !", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Imagem não Guardada devido a Cancelamento pelo Utilizador.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma imagem para salvar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (picCopia.Image != null)
            {
                picCopia.Image = null;
                MessageBox.Show("Captura Limpa Com sucesso!", "Captura",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma imagem para limpar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                EncerrarWebcam();
            }
            Fechar();

        }

        private void Fechar()
        {
            
            if (MessageBox.Show("Deseja Sair do programa ? sim/nao", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)return;
            this.Close();
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            EncerrarWebcam();
            base.OnFormClosing(e);
        }

        private void BtnEncerrar_Click(object sender, EventArgs e)
        {
            EncerrarWebcam();
        }

        private void EncerrarWebcam()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
            MessageBox.Show("Webcam Encerrada com sucesso  !", "Webcam",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
