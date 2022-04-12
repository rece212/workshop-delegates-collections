using System;
using System.Windows.Forms;

namespace prjDelegates
{
    public partial class Form1 : Form
    {
        GenericClass<String> Collection = new GenericClass<string>(20);
        public delegate void DelOne(String strName, String strSurname);
        public delegate void ButtonDell(object sender, EventArgs e);
        public ButtonDell Button;
        public Form1()
        {
            InitializeComponent();
            Button = new ButtonDell(btntwo_Click);
        }
        private void btntwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HelloWorld");

        }
        public void setDetails(String str1,String str2)
        {
            lblOutput.Text = str1 + " " + str2+" details";
        }
        public void setData(String str1, String str2)
        {
            lblOutput2.Text = str1 + " " + str2+" data";
        }
        private void btnPress_Click(object sender, EventArgs e)
        {
            DelOne pressme = new DelOne(setDetails);
            pressme += new DelOne(setData);

            pressme.Invoke("Reece", "Wanvig");
            Button.Invoke(sender, e);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ButtonDell Print = new ButtonDell(btnClear_Click);
            Print += new ButtonDell(btnPrint_Click);
            Collection.push(txtName.Text.ToString(), txtSurname.Text.ToString());

            Print.Invoke(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            richOutput.Text=Collection.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            richOutput.Text="";
        }
    }
}
