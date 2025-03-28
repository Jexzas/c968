using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace bfm2;

public partial class Main : Form
{
    public Inventory inventory = new Inventory();

    public BindingList<Part> parts;
    public BindingList<Product> products;

    public Main()
    {
        InitializeComponent();

        this.parts = this.inventory.AllParts;
        this.products = this.inventory.Products;
    }
    
    private void Main_Shown(object sender, EventArgs e)
    {
        dataGridView1.AutoGenerateColumns = true;
        dataGridView2.AutoGenerateColumns = true;
        dataGridView1.DataSource = parts;
        dataGridView2.DataSource = products;
    }
    private void button1_Click(object sender, EventArgs e)
    {
        // functionality to display search results
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        // set a variable equal to the text in the box
    }

    private void button2_Click(object sender, EventArgs e)
    {
        // Add a part
        AddPart addPart = new AddPart();
        addPart.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        // Modify a part
        ModifyPart modifyPart = new ModifyPart();
        modifyPart.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        // Delete a part

    }

    private void button8_Click(object sender, EventArgs e)
    {
        // Search for a product
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        // Set variable equal to textbox for product
    }

    private void button7_Click(object sender, EventArgs e)
    {
        // Add a product
        AddProduct addProduct = new AddProduct();
        addProduct.ShowDialog();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        // Modify a product
        ModifyProduct modifyProduct = new ModifyProduct();
        modifyProduct.ShowDialog();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        // Delete a product
    }

    
}
