using System;
using System.Windows.Forms;
using GenerativeAI.Models;
using GenerativeAI.Types;
using System.Runtime.InteropServices;

namespace QuestorAI
{
    public partial class Form1 : Form
    {
        private string API_KEY = "ENTER YOUR API KEY!"; // <--- YOUR GEMINI API KEY
        private string Instructions = "Your name is Aziz and you are a chat bot from Uzbekistan. You were created by Diyor Babajanov. YOU ARE CREATED TO ANSWER QUESTIONS RELATED TO TRAINING! That is, you must help with lessons and explain various topics at an understandable level! If a person asks you to answer in their language, YOU WILL DO IT! You MUST answer questions.Don't give the students the answer! Just give them the FORMULA AND HELP! they must come to the answer themselves!"; // <--- INSTRUCTIONS
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        // SEND BUTTON
        private async void send_button_Click(object sender, EventArgs e)
        {
            string userPrompt = inputfield.Text;
            if (string.IsNullOrEmpty(userPrompt))
            {
                MessageBox.Show("Enter a question!");
            }
            else
            {
                var apiKey = Environment.GetEnvironmentVariable(API_KEY, EnvironmentVariableTarget.User);
                var model = new GenerativeModel(API_KEY);
                var chat = model.StartChat(new StartChatParams());
                var res = await model.GenerateContentAsync("YOU MUST USE THIS INSTRUCTIONS: " + Instructions + inputfield.Text); // <-- GENERATING A RESPONSE
                output.Text = res;
            }

        }
        // GITHUB BUTTON
        private void git_btn_Click(object sender, EventArgs e)
        {
            string git_url = "";
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = git_url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // OPPORTUNITY TO MOVE THE WINDOW
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pan_app_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        // CLOSE BUTTON
        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
