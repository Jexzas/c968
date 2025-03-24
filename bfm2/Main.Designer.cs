namespace bfm2;

partial class Main
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
        label1 = new Label();
        button1 = new Button();
        textBox1 = new TextBox();
        label2 = new Label();
        label3 = new Label();
        dataGridView1 = new DataGridView();
        dataGridView2 = new DataGridView();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        textBox2 = new TextBox();
        button8 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(271, 25);
        label1.TabIndex = 0;
        label1.Text = "Inventory Management System";
        label1.Click += this.label1_Click;
        // 
        // button1
        // 
        button1.Location = new Point(271, 68);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "Search";
        button1.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(371, 69);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(235, 23);
        textBox1.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(37, 114);
        label2.Name = "label2";
        label2.Size = new Size(44, 21);
        label2.TabIndex = 3;
        label2.Text = "Parts";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(638, 114);
        label3.Name = "label3";
        label3.Size = new Size(71, 21);
        label3.TabIndex = 4;
        label3.Text = "Products";
        label3.Click += this.label3_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(37, 156);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(569, 321);
        dataGridView1.TabIndex = 5;
        dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
        // 
        // dataGridView2
        // 
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new Point(638, 156);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.Size = new Size(569, 321);
        dataGridView2.TabIndex = 6;
        // 
        // button2
        // 
        button2.Location = new Point(369, 495);
        button2.Name = "button2";
        button2.Size = new Size(75, 23);
        button2.TabIndex = 7;
        button2.Text = "Add";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(450, 495);
        button3.Name = "button3";
        button3.Size = new Size(75, 23);
        button3.TabIndex = 8;
        button3.Text = "Modify";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(531, 495);
        button4.Name = "button4";
        button4.Size = new Size(75, 23);
        button4.TabIndex = 9;
        button4.Text = "Delete";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new Point(1132, 495);
        button5.Name = "button5";
        button5.Size = new Size(75, 23);
        button5.TabIndex = 12;
        button5.Text = "Delete";
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new Point(1051, 495);
        button6.Name = "button6";
        button6.Size = new Size(75, 23);
        button6.TabIndex = 11;
        button6.Text = "Modify";
        button6.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        button7.Location = new Point(970, 495);
        button7.Name = "button7";
        button7.Size = new Size(75, 23);
        button7.TabIndex = 10;
        button7.Text = "Add";
        button7.UseVisualStyleBackColor = true;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(972, 69);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(235, 23);
        textBox2.TabIndex = 14;
        // 
        // button8
        // 
        button8.Location = new Point(872, 68);
        button8.Name = "button8";
        button8.Size = new Size(75, 23);
        button8.TabIndex = 13;
        button8.Text = "Search";
        button8.UseVisualStyleBackColor = true;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1238, 591);
        Controls.Add(textBox2);
        Controls.Add(button8);
        Controls.Add(button5);
        Controls.Add(button6);
        Controls.Add(button7);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(dataGridView2);
        Controls.Add(dataGridView1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "Main";
        Text = "Form1";
        Load += this.Main_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button button1;
    private TextBox textBox1;
    private Label label2;
    private Label label3;
    private DataGridView dataGridView1;
    private DataGridView dataGridView2;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private TextBox textBox2;
    private Button button8;
}
