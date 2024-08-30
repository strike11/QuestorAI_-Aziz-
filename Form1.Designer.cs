namespace QuestorAI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bg_pan = new System.Windows.Forms.Panel();
            output = new System.Windows.Forms.RichTextBox();
            send_button = new System.Windows.Forms.Button();
            enter_prompt_text = new System.Windows.Forms.Label();
            inputfield = new System.Windows.Forms.TextBox();
            name_pan = new System.Windows.Forms.Panel();
            git_btn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            pan_app = new System.Windows.Forms.Panel();
            button_close = new System.Windows.Forms.Button();
            bg_pan.SuspendLayout();
            name_pan.SuspendLayout();
            pan_app.SuspendLayout();
            SuspendLayout();
            // 
            // bg_pan
            // 
            bg_pan.BackColor = System.Drawing.Color.FromArgb(51, 53, 64);
            bg_pan.Controls.Add(output);
            bg_pan.Controls.Add(send_button);
            bg_pan.Controls.Add(enter_prompt_text);
            bg_pan.Controls.Add(inputfield);
            bg_pan.Controls.Add(name_pan);
            bg_pan.Controls.Add(pan_app);
            bg_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            bg_pan.Location = new System.Drawing.Point(0, 0);
            bg_pan.Name = "bg_pan";
            bg_pan.Size = new System.Drawing.Size(439, 661);
            bg_pan.TabIndex = 0;
            // 
            // output
            // 
            output.BackColor = System.Drawing.Color.FromArgb(38, 39, 51);
            output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            output.Dock = System.Windows.Forms.DockStyle.Bottom;
            output.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            output.ForeColor = System.Drawing.Color.White;
            output.Location = new System.Drawing.Point(0, 272);
            output.Name = "output";
            output.Size = new System.Drawing.Size(439, 389);
            output.TabIndex = 5;
            output.Text = "THE ANSWER TO YOUR QUESTION WILL BE HERE!";
            // 
            // send_button
            // 
            send_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            send_button.BackColor = System.Drawing.Color.FromArgb(39, 40, 56);
            send_button.FlatAppearance.BorderSize = 0;
            send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            send_button.Font = new System.Drawing.Font("Rubik", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            send_button.ForeColor = System.Drawing.Color.White;
            send_button.Location = new System.Drawing.Point(251, 232);
            send_button.Name = "send_button";
            send_button.Size = new System.Drawing.Size(116, 34);
            send_button.TabIndex = 4;
            send_button.Text = "Send";
            send_button.UseVisualStyleBackColor = false;
            send_button.Click += send_button_Click;
            // 
            // enter_prompt_text
            // 
            enter_prompt_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            enter_prompt_text.AutoSize = true;
            enter_prompt_text.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            enter_prompt_text.ForeColor = System.Drawing.Color.White;
            enter_prompt_text.Location = new System.Drawing.Point(124, 174);
            enter_prompt_text.Name = "enter_prompt_text";
            enter_prompt_text.Size = new System.Drawing.Size(188, 23);
            enter_prompt_text.TabIndex = 3;
            enter_prompt_text.Text = "Enter your question";
            // 
            // inputfield
            // 
            inputfield.Anchor = System.Windows.Forms.AnchorStyles.Top;
            inputfield.BackColor = System.Drawing.Color.FromArgb(90, 91, 99);
            inputfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            inputfield.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            inputfield.ForeColor = System.Drawing.Color.White;
            inputfield.Location = new System.Drawing.Point(69, 200);
            inputfield.Name = "inputfield";
            inputfield.Size = new System.Drawing.Size(298, 26);
            inputfield.TabIndex = 2;
            // 
            // name_pan
            // 
            name_pan.BackColor = System.Drawing.Color.FromArgb(56, 59, 69);
            name_pan.Controls.Add(git_btn);
            name_pan.Controls.Add(label1);
            name_pan.Dock = System.Windows.Forms.DockStyle.Top;
            name_pan.Location = new System.Drawing.Point(0, 34);
            name_pan.Name = "name_pan";
            name_pan.Size = new System.Drawing.Size(439, 66);
            name_pan.TabIndex = 1;
            // 
            // git_btn
            // 
            git_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            git_btn.BackColor = System.Drawing.Color.FromArgb(44, 45, 51);
            git_btn.FlatAppearance.BorderSize = 0;
            git_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            git_btn.Font = new System.Drawing.Font("Rubik", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            git_btn.ForeColor = System.Drawing.Color.White;
            git_btn.Location = new System.Drawing.Point(319, 11);
            git_btn.Name = "git_btn";
            git_btn.Size = new System.Drawing.Size(108, 45);
            git_btn.TabIndex = 1;
            git_btn.Text = "GitHub";
            git_btn.UseVisualStyleBackColor = false;
            git_btn.Click += git_btn_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Rubik", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(25, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "Questor";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_app
            // 
            pan_app.BackColor = System.Drawing.Color.FromArgb(73, 77, 92);
            pan_app.Controls.Add(button_close);
            pan_app.Dock = System.Windows.Forms.DockStyle.Top;
            pan_app.Location = new System.Drawing.Point(0, 0);
            pan_app.Name = "pan_app";
            pan_app.Size = new System.Drawing.Size(439, 34);
            pan_app.TabIndex = 0;
            pan_app.MouseDown += pan_app_MouseDown;
            // 
            // button_close
            // 
            button_close.BackColor = System.Drawing.Color.Transparent;
            button_close.FlatAppearance.BorderSize = 0;
            button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_close.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button_close.ForeColor = System.Drawing.Color.Red;
            button_close.Location = new System.Drawing.Point(405, -9);
            button_close.Name = "button_close";
            button_close.Size = new System.Drawing.Size(34, 48);
            button_close.TabIndex = 0;
            button_close.Text = "⭕";
            button_close.UseVisualStyleBackColor = false;
            button_close.Click += button_close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(439, 661);
            Controls.Add(bg_pan);
            Name = "Form1";
            Text = "Form1";
            bg_pan.ResumeLayout(false);
            bg_pan.PerformLayout();
            name_pan.ResumeLayout(false);
            name_pan.PerformLayout();
            pan_app.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel bg_pan;
        private System.Windows.Forms.Panel name_pan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_app;
        private System.Windows.Forms.Label enter_prompt_text;
        private System.Windows.Forms.TextBox inputfield;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button git_btn;
        private System.Windows.Forms.Button button_close;
    }
}
