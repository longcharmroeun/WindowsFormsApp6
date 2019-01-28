namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Process_id = new System.Windows.Forms.Label();
            this.Process_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Paren_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Parent_location = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 407);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tittle);
            this.panel1.Controls.Add(this.Parent_location);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Paren_id);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Location);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Process_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Process_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(249, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 407);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process ID";
            // 
            // Process_id
            // 
            this.Process_id.AutoSize = true;
            this.Process_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process_id.Location = new System.Drawing.Point(196, 95);
            this.Process_id.Name = "Process_id";
            this.Process_id.Size = new System.Drawing.Size(59, 25);
            this.Process_id.TabIndex = 1;
            this.Process_id.Text = "None";
            // 
            // Process_name
            // 
            this.Process_name.AutoSize = true;
            this.Process_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process_name.Location = new System.Drawing.Point(196, 155);
            this.Process_name.Name = "Process_name";
            this.Process_name.Size = new System.Drawing.Size(59, 25);
            this.Process_name.TabIndex = 3;
            this.Process_name.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Process Name";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.Location = new System.Drawing.Point(196, 219);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(59, 25);
            this.Location.TabIndex = 5;
            this.Location.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location";
            // 
            // Paren_id
            // 
            this.Paren_id.AutoSize = true;
            this.Paren_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paren_id.Location = new System.Drawing.Point(196, 285);
            this.Paren_id.Name = "Paren_id";
            this.Paren_id.Size = new System.Drawing.Size(59, 25);
            this.Paren_id.TabIndex = 7;
            this.Paren_id.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Parent_ID";
            // 
            // Parent_location
            // 
            this.Parent_location.AutoSize = true;
            this.Parent_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parent_location.Location = new System.Drawing.Point(211, 355);
            this.Parent_location.Name = "Parent_location";
            this.Parent_location.Size = new System.Drawing.Size(59, 25);
            this.Parent_location.TabIndex = 9;
            this.Parent_location.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Parent_Location";
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.Location = new System.Drawing.Point(24, 25);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(83, 31);
            this.Tittle.TabIndex = 10;
            this.Tittle.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Parent_location;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Paren_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Process_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Process_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tittle;
    }
}

