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
        textBox1.Text = "Enter part name or ID";
        textBox2.Text = "Enter product name or ID";
        dataGridView1.AutoGenerateColumns = true;
        dataGridView2.AutoGenerateColumns = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.DataSource = parts;
        dataGridView2.DataSource = products;
    }
    private void button1_Click(object sender, EventArgs e)
    {
        //// functionality to display search results for parts
        string searchTerm = textBox1.Text;
        void reset()
        {
            textBox1.Text = "Please enter a part name or ID";
            dataGridView1.DataSource = parts;
        }
        ;
        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
        {
            row.Selected = false;
        }
        bool found = false;
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (Int32.TryParse(searchTerm, out _))
            {
                if(row.Cells[0].Value.ToString() == searchTerm.ToString())
                {
                    row.Selected = true;
                    found = true;
                    reset();
                }
                ;
            } else
            {
                if (row.Cells[1].Value.ToString().ToLower() == searchTerm.ToString().ToLower())
                {
                    row.Selected = true;
                    found = true;
                    reset();
                }
            }
        }
        if (found == false)
        {
            MessageBox.Show("No parts found!");
            }
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
        //// functionality to display search results for products
        string searchTerm = textBox2.Text;
        void reset()
        {
            textBox2.Text = "Please enter a product name or ID";
            dataGridView2.DataSource = products;
        }
        ;
        foreach (DataGridViewRow row in dataGridView2.SelectedRows)
        {
            row.Selected = false;
        }
        bool found = false;
        foreach (DataGridViewRow row in dataGridView2.Rows)
        {
            if (Int32.TryParse(searchTerm, out _))
            {
                if (row.Cells[0].Value.ToString() == searchTerm.ToString())
                {
                    row.Selected = true;
                    found = true;
                    reset();
                }
                ;
            }
            else
            {
                if (row.Cells[1].Value.ToString().ToLower() == searchTerm.ToString().ToLower())
                {
                    row.Selected = true;
                    found = true;
                    reset();
                }
            }
        }
        if (found == false)
        {
            MessageBox.Show("No products found!");
        }
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
