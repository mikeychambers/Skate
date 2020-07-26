namespace Skate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.roadMarking1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.road = new System.Windows.Forms.PictureBox();
            this.roadMarking2 = new System.Windows.Forms.PictureBox();
            this.roadMarking3 = new System.Windows.Forms.PictureBox();
            this.Skater = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.obsticle = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roadMarking1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadMarking2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadMarking3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticle)).BeginInit();
            this.SuspendLayout();
            // 
            // roadMarking1
            // 
            this.roadMarking1.BackColor = System.Drawing.Color.Yellow;
            this.roadMarking1.Location = new System.Drawing.Point(12, 385);
            this.roadMarking1.Name = "roadMarking1";
            this.roadMarking1.Size = new System.Drawing.Size(137, 27);
            this.roadMarking1.TabIndex = 0;
            this.roadMarking1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // road
            // 
            this.road.BackColor = System.Drawing.Color.Black;
            this.road.Location = new System.Drawing.Point(0, 385);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(1268, 104);
            this.road.TabIndex = 2;
            this.road.TabStop = false;
            // 
            // roadMarking2
            // 
            this.roadMarking2.BackColor = System.Drawing.Color.Yellow;
            this.roadMarking2.Location = new System.Drawing.Point(491, 385);
            this.roadMarking2.Name = "roadMarking2";
            this.roadMarking2.Size = new System.Drawing.Size(137, 27);
            this.roadMarking2.TabIndex = 3;
            this.roadMarking2.TabStop = false;
            // 
            // roadMarking3
            // 
            this.roadMarking3.BackColor = System.Drawing.Color.Yellow;
            this.roadMarking3.Location = new System.Drawing.Point(951, 385);
            this.roadMarking3.Name = "roadMarking3";
            this.roadMarking3.Size = new System.Drawing.Size(137, 27);
            this.roadMarking3.TabIndex = 4;
            this.roadMarking3.TabStop = false;
            // 
            // Skater
            // 
            this.Skater.BackColor = System.Drawing.Color.Purple;
            this.Skater.Location = new System.Drawing.Point(183, 143);
            this.Skater.Name = "Skater";
            this.Skater.Size = new System.Drawing.Size(41, 269);
            this.Skater.TabIndex = 5;
            this.Skater.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // obsticle
            // 
            this.obsticle.BackColor = System.Drawing.Color.DarkGreen;
            this.obsticle.Location = new System.Drawing.Point(672, 361);
            this.obsticle.Name = "obsticle";
            this.obsticle.Size = new System.Drawing.Size(100, 51);
            this.obsticle.TabIndex = 6;
            this.obsticle.TabStop = false;
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.Silver;
            this.scorelabel.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.Location = new System.Drawing.Point(1098, 95);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(72, 41);
            this.scorelabel.TabIndex = 7;
            this.scorelabel.Text = "000";
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.BackColor = System.Drawing.Color.Silver;
            this.highscore.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore.Location = new System.Drawing.Point(1098, 26);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(72, 41);
            this.highscore.TabIndex = 8;
            this.highscore.Text = "000";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(923, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "High Score: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(923, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Score:            ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 43);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dont Hate Just Skate";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Impact", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(384, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(486, 268);
            this.textBox1.TabIndex = 12;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Press P to start   \r\nPress D for speed boost  \r\nHold SPACE to Jump Release SPACE " +
    "to Land";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 489);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.obsticle);
            this.Controls.Add(this.Skater);
            this.Controls.Add(this.roadMarking3);
            this.Controls.Add(this.roadMarking2);
            this.Controls.Add(this.roadMarking1);
            this.Controls.Add(this.road);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Skate";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.roadMarking1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadMarking2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadMarking3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox roadMarking1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.PictureBox roadMarking2;
        private System.Windows.Forms.PictureBox roadMarking3;
        private System.Windows.Forms.PictureBox Skater;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox obsticle;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

