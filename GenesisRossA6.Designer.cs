namespace GenesisRossA6
{
    partial class GenesisRossA6
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
            exportJSONBTN = new Button();
            chooseFileBTN = new Button();
            SuspendLayout();
            // 
            
            // 
            // exportJSONBTN
            // 
            exportJSONBTN.Location = new Point(153, 340);
            exportJSONBTN.Name = "exportJSONBTN";
            exportJSONBTN.Size = new Size(140, 48);
            exportJSONBTN.TabIndex = 2;
            exportJSONBTN.Text = "Export JSON File";
            exportJSONBTN.UseVisualStyleBackColor = true;
            // 
            // chooseFileBTN
            // 
            chooseFileBTN.Location = new Point(153, 129);
            chooseFileBTN.Name = "chooseFileBTN";
            chooseFileBTN.Size = new Size(140, 48);
            chooseFileBTN.TabIndex = 3;
            chooseFileBTN.Text = "Choose File";
            chooseFileBTN.UseVisualStyleBackColor = true;
            // 
            // GenesisRossA6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(chooseFileBTN);
            Controls.Add(exportJSONBTN);
            Name = "GenesisRossA6";
            Text = "GenesisRossA6";
            ResumeLayout(false);
        }

        #endregion

        private Button exportJSONBTN;
        private Button chooseFileBTN;
    }
}
