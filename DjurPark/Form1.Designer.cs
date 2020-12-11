
namespace DjurPark
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
            this.cmbDjur = new System.Windows.Forms.ComboBox();
            this.NewAnimal = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lbxAllAnimals = new System.Windows.Forms.ListBox();
            this.tbxItemView = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbDjur
            // 
            this.cmbDjur.FormattingEnabled = true;
            this.cmbDjur.Location = new System.Drawing.Point(68, 49);
            this.cmbDjur.Name = "cmbDjur";
            this.cmbDjur.Size = new System.Drawing.Size(176, 21);
            this.cmbDjur.TabIndex = 0;
            // 
            // NewAnimal
            // 
            this.NewAnimal.Location = new System.Drawing.Point(272, 97);
            this.NewAnimal.Name = "NewAnimal";
            this.NewAnimal.Size = new System.Drawing.Size(146, 51);
            this.NewAnimal.TabIndex = 1;
            this.NewAnimal.Text = "Add";
            this.NewAnimal.UseVisualStyleBackColor = true;
            this.NewAnimal.Click += new System.EventHandler(this.NewAnimal_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(83, 164);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(131, 20);
            this.tbxName.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(83, 224);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(175, 20);
            this.datePicker.TabIndex = 3;
            // 
            // lbxAllAnimals
            // 
            this.lbxAllAnimals.FormattingEnabled = true;
            this.lbxAllAnimals.Location = new System.Drawing.Point(505, 49);
            this.lbxAllAnimals.Name = "lbxAllAnimals";
            this.lbxAllAnimals.Size = new System.Drawing.Size(345, 290);
            this.lbxAllAnimals.TabIndex = 5;
            this.lbxAllAnimals.SelectedIndexChanged += new System.EventHandler(this.lbxAllAnimals_SelectedIndexChanged);
            this.lbxAllAnimals.DoubleClick += new System.EventHandler(this.lbxAllAnimals_DoubleClick);
            // 
            // tbxItemView
            // 
            this.tbxItemView.Location = new System.Drawing.Point(193, 401);
            this.tbxItemView.Multiline = true;
            this.tbxItemView.Name = "tbxItemView";
            this.tbxItemView.Size = new System.Drawing.Size(598, 111);
            this.tbxItemView.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 532);
            this.Controls.Add(this.tbxItemView);
            this.Controls.Add(this.lbxAllAnimals);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.NewAnimal);
            this.Controls.Add(this.cmbDjur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDjur;
        private System.Windows.Forms.Button NewAnimal;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListBox lbxAllAnimals;
        private System.Windows.Forms.TextBox tbxItemView;
    }
}

