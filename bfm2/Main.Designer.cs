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
        label1.Location = new Point(14, 12);
        label1.Name = "label1";
        label1.Size = new Size(348, 32);
        label1.TabIndex = 0;
        label1.Text = "Inventory Management System";
        // 
        // button1
        // 
        button1.Location = new Point(310, 91);
        button1.Margin = new Padding(3, 4, 3, 4);
        button1.Name = "button1";
        button1.Size = new Size(86, 31);
        button1.TabIndex = 1;
        button1.Text = "Search";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(424, 92);
        textBox1.Margin = new Padding(3, 4, 3, 4);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(268, 27);
        textBox1.TabIndex = 2;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(42, 152);
        label2.Name = "label2";
        label2.Size = new Size(54, 28);
        label2.TabIndex = 3;
        label2.Text = "Parts";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(729, 152);
        label3.Name = "label3";
        label3.Size = new Size(89, 28);
        label3.TabIndex = 4;
        label3.Text = "Products";
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(42, 208);
        dataGridView1.Margin = new Padding(3, 4, 3, 4);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(650, 428);
        dataGridView1.TabIndex = 5;
        // 
        // dataGridView2
        // 
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new Point(729, 208);
        dataGridView2.Margin = new Padding(3, 4, 3, 4);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.RowHeadersWidth = 51;
        dataGridView2.Size = new Size(650, 428);
        dataGridView2.TabIndex = 6;
        // 
        // button2
        // 
        button2.Location = new Point(422, 660);
        button2.Margin = new Padding(3, 4, 3, 4);
        button2.Name = "button2";
        button2.Size = new Size(86, 31);
        button2.TabIndex = 7;
        button2.Text = "Add";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(514, 660);
        button3.Margin = new Padding(3, 4, 3, 4);
        button3.Name = "button3";
        button3.Size = new Size(86, 31);
        button3.TabIndex = 8;
        button3.Text = "Modify";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(607, 660);
        button4.Margin = new Padding(3, 4, 3, 4);
        button4.Name = "button4";
        button4.Size = new Size(86, 31);
        button4.TabIndex = 9;
        button4.Text = "Delete";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new Point(1294, 660);
        button5.Margin = new Padding(3, 4, 3, 4);
        button5.Name = "button5";
        button5.Size = new Size(86, 31);
        button5.TabIndex = 12;
        button5.Text = "Delete";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Location = new Point(1201, 660);
        button6.Margin = new Padding(3, 4, 3, 4);
        button6.Name = "button6";
        button6.Size = new Size(86, 31);
        button6.TabIndex = 11;
        button6.Text = "Modify";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button7
        // 
        button7.Location = new Point(1109, 660);
        button7.Margin = new Padding(3, 4, 3, 4);
        button7.Name = "button7";
        button7.Size = new Size(86, 31);
        button7.TabIndex = 10;
        button7.Text = "Add";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(1111, 92);
        textBox2.Margin = new Padding(3, 4, 3, 4);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(268, 27);
        textBox2.TabIndex = 14;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // button8
        // 
        button8.Location = new Point(997, 91);
        button8.Margin = new Padding(3, 4, 3, 4);
        button8.Name = "button8";
        button8.Size = new Size(86, 31);
        button8.TabIndex = 13;
        button8.Text = "Search";
        button8.UseVisualStyleBackColor = true;
        button8.Click += button8_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1415, 788);
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
        Margin = new Padding(3, 4, 3, 4);
        Name = "Main";
        Text = "Form1";
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
