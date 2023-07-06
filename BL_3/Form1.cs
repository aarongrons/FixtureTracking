using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL_3
{

    public partial class TestForm : Form
    {
        List<string> displayCart = new List<string>();
        List<string> AllParts = new List<string>();
        List<string> BC2PN = new List<string>();
        List<Barcode> longBarcodes = new List<Barcode>();
        List<Barcode> trimBarcodes = new List<Barcode>();
        BindingSource bsCart = new BindingSource();
        BindingSource bsAll = new BindingSource();
        string filepath = @"C:\Users\aaron.gronsman\BL_3\data.txt";
        string partFile = @"C:\Users\aaron.gronsman\BL_3\LightningCodes.txt";
        string fixPart;
        string undo;

        public TestForm()
        {
            InitializeComponent();


            AllParts = File.ReadAllLines(filepath).ToList();
            bsCart.DataSource = displayCart;
            bsAll.DataSource = AllParts;
            LB_CheckedOut.DataSource = bsAll;
            bsAll.ResetBindings(false);

            BC2PN = File.ReadAllLines(partFile).ToList();

            foreach (string line in BC2PN)
            {
                const char del = '\t';
           
                string[] newline = line.Split(del);
               
                Barcode bar = new Barcode();
                bar.blueLight = newline[0];
                bar.partNum = newline[1]; 
                //string check = bar.partNum;
                //check = check.Remove(7, 4);       
                //Console.WriteLine(check);
                //bar.partNum = check;
                longBarcodes.Add(bar);
            }
            for (int i = 0; i < longBarcodes.Count; ++i)
            {
                if (i == 0)
                {
                    trimBarcodes.Add(longBarcodes[i]);
                }
                else
                {
                    if (longBarcodes[i].blueLight == longBarcodes[i - 1].blueLight)
                    {
                        trimBarcodes[trimBarcodes.Count - 1].partNum = trimBarcodes[trimBarcodes.Count - 1].partNum + " / " + longBarcodes[i].partNum;
                        longBarcodes.RemoveAt(i);
                        i -= 1;
                    }
                    else
                    {
                        trimBarcodes.Add(longBarcodes[i]);
                    }
                }
            }
        }
        // ** Export to txt **
        private void button1_Click(object sender, EventArgs e)
        {

            foreach (string a in displayCart)
            {
                AllParts.Add(a);
            }
            File.WriteAllLines(filepath, AllParts);
            displayCart.Clear();
            bsCart.ResetBindings(false);
            LB_CheckedOut.DataSource = bsAll;
            bsAll.ResetBindings(false);

        }

        // **REMOVE PART FROM LIST AND REWRITE FILE**
        private void btn_return_Click(object sender, EventArgs e)
        {

            AllParts = File.ReadAllLines(filepath).ToList();
            for (int a = 0; a < displayCart.Count; ++a)
            {
                for (int b = 0; b < AllParts.Count; ++b)
                {
                    if (AllParts[b] == displayCart[a])
                    {
                        undo = AllParts[b];
                        AllParts.RemoveAt(b);
                    }
                }
            }
            for (int b = 0; b < AllParts.Count; ++b)
            {
                if (AllParts[b] == LB_CheckedOut.Text)
                {
                    undo = AllParts[b];
                    AllParts.RemoveAt(b);

                }
            }
            File.WriteAllLines(filepath, AllParts);
            displayCart.Clear();
            bsCart.ResetBindings(false);
            bsAll.DataSource = AllParts;
            LB_CheckedOut.DataSource = bsAll;
            bsAll.ResetBindings(false);
        }



        private void txt_partNum_TextChanged(object sender, EventArgs e)
        {

            if (txt_partNum.Text.Length == 12)
            {
                string numbers = "Part Number Error";
                if (cb_lines.Text == "")
                {
                    MessageBox.Show("Please Select a Line Number First");
                    txt_partNum.Text = "";
                }
                else
                {
                    foreach (Barcode bar in longBarcodes)
                    {
                        if (txt_partNum.Text == bar.blueLight)
                        {
                            numbers = bar.partNum; break;
                        }
                    }
                    string check;
                    check = cb_lines.Text + "\t" + numbers;
                    displayCart.Add(check);

                    LB_CheckoutData.DataSource = bsCart;
                    bsCart.ResetBindings(false);
                    txt_partNum.Text = "";
                }
            }
        }
        private void LB_CheckoutData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // hide max,min and close button at top right of Window
            // fill the screen
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numbers = "Part Number Error";
            if (cb_lines.Text.Length == 12)
            {
                txt_partNum.Text = cb_lines.Text;
                cb_lines.Text = "";
            }
            if(cb_lines.Text.Length == 4 & txt_partNum.Text.Length == 12) {
                foreach (Barcode bar in longBarcodes)
                {
                    if (txt_partNum.Text == bar.blueLight)
                    {
                        numbers = bar.partNum; break;
                    }
                }
                string check;
                check = cb_lines.Text + "\t" + numbers;
                displayCart.Add(check);

                LB_CheckoutData.DataSource = bsCart;
                bsCart.ResetBindings(false);
                txt_partNum.Text = "";
            }
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            AllParts.Add(undo);
            LB_CheckedOut.DataSource = bsAll;
            bsAll.ResetBindings(false);
        }
    }

}

