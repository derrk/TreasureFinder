namespace Prog4_Alexia_Derrik
{
    partial class FindTheIslandGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindTheIslandGame));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userGuessRows = new System.Windows.Forms.NumericUpDown();
            this.userGuessColumns = new System.Windows.Forms.NumericUpDown();
            this.enterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mapBox = new System.Windows.Forms.GroupBox();
            this.MapTextBox = new System.Windows.Forms.RichTextBox();
            this.GameMap = new System.Windows.Forms.BindingSource(this.components);
            this.createMap = new System.Windows.Forms.Button();
            this.mapSizeRows = new System.Windows.Forms.NumericUpDown();
            this.mapSizeColumns = new System.Windows.Forms.NumericUpDown();
            this.mapRows = new System.Windows.Forms.Label();
            this.mapColumns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGuessRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGuessColumns)).BeginInit();
            this.mapBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.GrayText;
            this.numericUpDown1.Location = new System.Drawing.Point(34, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.GrayText;
            this.numericUpDown2.Location = new System.Drawing.Point(47, 82);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 0;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.GrayText;
            this.numericUpDown3.Location = new System.Drawing.Point(230, 82);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Latitude";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // userGuessRows
            // 
            this.userGuessRows.AccessibleName = "latVal";
            this.userGuessRows.BackColor = System.Drawing.SystemColors.GrayText;
            this.userGuessRows.Location = new System.Drawing.Point(30, 91);
            this.userGuessRows.Name = "userGuessRows";
            this.userGuessRows.Size = new System.Drawing.Size(120, 23);
            this.userGuessRows.TabIndex = 0;
            this.userGuessRows.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // userGuessColumns
            // 
            this.userGuessColumns.AccessibleName = "longVal";
            this.userGuessColumns.BackColor = System.Drawing.SystemColors.GrayText;
            this.userGuessColumns.Location = new System.Drawing.Point(181, 91);
            this.userGuessColumns.Name = "userGuessColumns";
            this.userGuessColumns.Size = new System.Drawing.Size(120, 23);
            this.userGuessColumns.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enterButton.Location = new System.Drawing.Point(337, 89);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.checkValues);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Latitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Longitude";
            // 
            // mapBox
            // 
            this.mapBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.mapBox.Controls.Add(this.MapTextBox);
            this.mapBox.Location = new System.Drawing.Point(30, 138);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(278, 184);
            this.mapBox.TabIndex = 5;
            this.mapBox.TabStop = false;
            this.mapBox.Text = "Map";
            // 
            // MapTextBox
            // 
            this.MapTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MapTextBox.Location = new System.Drawing.Point(6, 22);
            this.MapTextBox.Name = "MapTextBox";
            this.MapTextBox.Size = new System.Drawing.Size(265, 156);
            this.MapTextBox.TabIndex = 0;
            this.MapTextBox.Text = "";
            // 
            // createMap
            // 
            this.createMap.Location = new System.Drawing.Point(337, 38);
            this.createMap.Name = "createMap";
            this.createMap.Size = new System.Drawing.Size(133, 23);
            this.createMap.TabIndex = 6;
            this.createMap.Text = "Create Map";
            this.createMap.UseVisualStyleBackColor = true;
            this.createMap.Click += new System.EventHandler(this.createMap_Click);
            // 
            // mapSizeRows
            // 
            this.mapSizeRows.Location = new System.Drawing.Point(30, 38);
            this.mapSizeRows.Name = "mapSizeRows";
            this.mapSizeRows.Size = new System.Drawing.Size(120, 23);
            this.mapSizeRows.TabIndex = 7;
            // 
            // mapSizeColumns
            // 
            this.mapSizeColumns.Location = new System.Drawing.Point(181, 38);
            this.mapSizeColumns.Name = "mapSizeColumns";
            this.mapSizeColumns.Size = new System.Drawing.Size(120, 23);
            this.mapSizeColumns.TabIndex = 8;
            // 
            // mapRows
            // 
            this.mapRows.AutoSize = true;
            this.mapRows.Location = new System.Drawing.Point(30, 20);
            this.mapRows.Name = "mapRows";
            this.mapRows.Size = new System.Drawing.Size(62, 15);
            this.mapRows.TabIndex = 9;
            this.mapRows.Text = "# of Rows ";
            // 
            // mapColumns
            // 
            this.mapColumns.AutoSize = true;
            this.mapColumns.Location = new System.Drawing.Point(181, 20);
            this.mapColumns.Name = "mapColumns";
            this.mapColumns.Size = new System.Drawing.Size(79, 15);
            this.mapColumns.TabIndex = 10;
            this.mapColumns.Text = "# of Columns";
            // 
            // FindTheIslandGame
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(741, 490);
            this.Controls.Add(this.mapColumns);
            this.Controls.Add(this.mapRows);
            this.Controls.Add(this.mapSizeColumns);
            this.Controls.Add(this.mapSizeRows);
            this.Controls.Add(this.createMap);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.userGuessColumns);
            this.Controls.Add(this.userGuessRows);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindTheIslandGame";
            this.Text = "Find The Island Game";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGuessRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGuessColumns)).EndInit();
            this.mapBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSizeColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown userGuessRows;
        private System.Windows.Forms.NumericUpDown userGuessColumns;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox mapBox;
        private System.Windows.Forms.BindingSource GameMap;
        private System.Windows.Forms.Button createMap;
        private System.Windows.Forms.NumericUpDown mapSizeRows;
        private System.Windows.Forms.NumericUpDown mapSizeColumns;
        private System.Windows.Forms.Label mapRows;
        private System.Windows.Forms.Label mapColumns;
        public System.Windows.Forms.RichTextBox MapTextBox;
    }
}
