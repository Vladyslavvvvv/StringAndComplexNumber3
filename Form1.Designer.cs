namespace StringAndComplexNumber3
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.labelEquals = new System.Windows.Forms.Label();
            this.labelAddition = new System.Windows.Forms.Label();
            this.labelMultiplication = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelAdded = new System.Windows.Forms.Label();
            this.listBoxElements = new System.Windows.Forms.ListBox();
            this.labelDIsplayInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(640, 60);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(77, 39);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "First complex number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second complex number";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirst.Location = new System.Drawing.Point(330, 10);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(200, 34);
            this.textBoxFirst.TabIndex = 3;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecond.Location = new System.Drawing.Point(330, 110);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(200, 34);
            this.textBoxSecond.TabIndex = 4;
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquals.Location = new System.Drawing.Point(10, 210);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(106, 29);
            this.labelEquals.TabIndex = 5;
            this.labelEquals.Text = "Equals?";
            // 
            // labelAddition
            // 
            this.labelAddition.AutoSize = true;
            this.labelAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddition.Location = new System.Drawing.Point(10, 310);
            this.labelAddition.Name = "labelAddition";
            this.labelAddition.Size = new System.Drawing.Size(109, 29);
            this.labelAddition.TabIndex = 6;
            this.labelAddition.Text = "Addition";
            // 
            // labelMultiplication
            // 
            this.labelMultiplication.AutoSize = true;
            this.labelMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMultiplication.Location = new System.Drawing.Point(10, 410);
            this.labelMultiplication.Name = "labelMultiplication";
            this.labelMultiplication.Size = new System.Drawing.Size(168, 29);
            this.labelMultiplication.TabIndex = 7;
            this.labelMultiplication.Text = "Multiplication";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdd.Location = new System.Drawing.Point(440, 210);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(100, 27);
            this.textBoxAdd.TabIndex = 8;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.AutoSize = true;
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNew.Location = new System.Drawing.Point(330, 210);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(90, 30);
            this.buttonAddNew.TabIndex = 9;
            this.buttonAddNew.Text = "Add new";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // labelAdded
            // 
            this.labelAdded.AutoSize = true;
            this.labelAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdded.Location = new System.Drawing.Point(546, 217);
            this.labelAdded.Name = "labelAdded";
            this.labelAdded.Size = new System.Drawing.Size(71, 20);
            this.labelAdded.TabIndex = 10;
            this.labelAdded.Text = "Added?";
            // 
            // listBoxElements
            // 
            this.listBoxElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxElements.FormattingEnabled = true;
            this.listBoxElements.ItemHeight = 20;
            this.listBoxElements.Location = new System.Drawing.Point(330, 290);
            this.listBoxElements.Name = "listBoxElements";
            this.listBoxElements.Size = new System.Drawing.Size(160, 144);
            this.listBoxElements.TabIndex = 11;
            this.listBoxElements.SelectedIndexChanged += new System.EventHandler(this.listBoxElements_SelectedIndexChanged);
            // 
            // labelDIsplayInfo
            // 
            this.labelDIsplayInfo.AutoSize = true;
            this.labelDIsplayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDIsplayInfo.Location = new System.Drawing.Point(330, 260);
            this.labelDIsplayInfo.Name = "labelDIsplayInfo";
            this.labelDIsplayInfo.Size = new System.Drawing.Size(40, 20);
            this.labelDIsplayInfo.TabIndex = 13;
            this.labelDIsplayInfo.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.labelDIsplayInfo);
            this.Controls.Add(this.listBoxElements);
            this.Controls.Add(this.labelAdded);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.labelMultiplication);
            this.Controls.Add(this.labelAddition);
            this.Controls.Add(this.labelEquals);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.Label labelAddition;
        private System.Windows.Forms.Label labelMultiplication;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label labelAdded;
        private System.Windows.Forms.ListBox listBoxElements;
        private System.Windows.Forms.Label labelDIsplayInfo;
    }
}