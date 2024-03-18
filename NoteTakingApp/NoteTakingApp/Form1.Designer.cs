namespace NoteTakingApp
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
            textBox1 = new TextBox();
            add = new Button();
            dataGridView1 = new DataGridView();
            view = new Button();
            delete = new Button();
            textBox2 = new TextBox();
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 0;
            // 
            // add
            // 
            add.Location = new Point(275, 115);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 1;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(172, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(299, 174);
            dataGridView1.TabIndex = 2;
            // 
            // view
            // 
            view.Location = new Point(170, 349);
            view.Name = "view";
            view.Size = new Size(75, 23);
            view.TabIndex = 3;
            view.Text = "view";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // delete
            // 
            delete.Location = new Point(409, 349);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 4;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 23);
            textBox2.TabIndex = 5;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(298, 396);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(0, 15);
            dateLabel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateLabel);
            Controls.Add(textBox2);
            Controls.Add(delete);
            Controls.Add(view);
            Controls.Add(dataGridView1);
            Controls.Add(add);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button add;
        private DataGridView dataGridView1;
        private Button view;
        private Button delete;
        private TextBox textBox2;
        private Label dateLabel;
    }
}