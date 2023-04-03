namespace DiceRoller
{
    partial class FormDiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiceRoller));
            this.label = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picDice = new System.Windows.Forms.PictureBox();
            this.buttonRoll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(129, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(561, 36);
            this.label.TabIndex = 0;
            this.label.Text = "Welcome to Dice Roller";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(823, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picDice
            // 
            this.picDice.Image = ((System.Drawing.Image)(resources.GetObject("picDice.Image")));
            this.picDice.Location = new System.Drawing.Point(181, 130);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(247, 227);
            this.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDice.TabIndex = 2;
            this.picDice.TabStop = false;
            // 
            // buttonRoll
            // 
            this.buttonRoll.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoll.ForeColor = System.Drawing.Color.White;
            this.buttonRoll.Location = new System.Drawing.Point(555, 201);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(135, 57);
            this.buttonRoll.TabIndex = 3;
            this.buttonRoll.Text = "ROLL";
            this.buttonRoll.UseVisualStyleBackColor = false;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // FormDiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 444);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.picDice);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiceRoller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.Button buttonRoll;
    }
}

