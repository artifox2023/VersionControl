using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Newtonsoft.Json;
using Hotcakes.Commerce.Catalog;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json.Linq;

namespace HotCakes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetData();
        }

        
        //A termékek és adatinak betöltése a datagridviewba
        public void GetData()
        {
            string url = "http://20.234.113.211:8093/";
            string key = "1-cebeaa9d-f647-4750-9821-26f097f3d6d4";



            Api proxy = new Api(url, key);

            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();

            string json = JsonConvert.SerializeObject(response);

            ApiResponse<List<ProductDTO>> deserializedResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductDTO>>>(json);

            DataTable dt = new DataTable();
            
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Sku", typeof(string));
            dt.Columns.Add("SitePrice", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("CreationDateUtc", typeof(DateTime));
            dt.Columns.Add("Bvin", typeof(string));

            foreach (ProductDTO item in deserializedResponse.Content)
            {
                dt.Rows.Add( item.ProductName, item.Sku, item.SitePrice, item.LongDescription, item.CreationDateUtc, item.Bvin);
            }
            
            TermekekDGV.DataSource = dt;

            

        }

        //Az ár megváltoztatásához függvény
        public void ChangePrice()
        {
            string url = "http://20.234.113.211:8093/";
            string key = "1-cebeaa9d-f647-4750-9821-26f097f3d6d4";



            Api proxy = new Api(url, key);

            //A jelenlegi sor ID-nak meghatározása
            int rowIndex = TermekekDGV.CurrentCell.RowIndex;
            
            var productId = TermekekDGV.Rows[rowIndex].Cells["Bvin"].Value.ToString();

            var product = proxy.ProductsFind(productId).Content;

            //A kiválasztott termék leírásának felülírása
            product.SitePrice = int.Parse(textBoxPrice.Text);
            ApiResponse<ProductDTO> response = proxy.ProductsUpdate(product);
            textBoxPrice.Clear();

            //A végén a frissített adatok betöltése
            GetData();
           
        }

        //A leírás megváltoztatásához függvény
        public void ChangeDescription()
        {
            string url = "http://20.234.113.211:8093/";
            string key = "1-cebeaa9d-f647-4750-9821-26f097f3d6d4";



            Api proxy = new Api(url, key);

            //A jelenlegi sor ID-nak meghatározása
            int rowIndex = TermekekDGV.CurrentCell.RowIndex;

            var productId = TermekekDGV.Rows[rowIndex].Cells["Bvin"].Value.ToString();

            var product = proxy.ProductsFind(productId).Content;

            //A kiválasztott termék leírásának felülírása
            product.LongDescription = textboxDescription.Text;

            ApiResponse<ProductDTO> response = proxy.ProductsUpdate(product);
            textboxDescription.Clear();

            //A végén a frissített adatok betöltése
            GetData();

            
        }

        //Ha a felhasználó az 'ár megváltoztatása' nevű gombra kattint
        private void Szerkesztés_Click(object sender, EventArgs e)
        {

            //Ellenőrzés, hogy nem üres-e az ennek megfelelő textbox (üres értéket nem lehet megadni)
            if (string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Kérjük adjon meg értéket!", "Nem adott meg új árat!");
            }
            else
            {
                //Ellenőrzés, hogy számértéket adott-e meg a felhasználó
                if (!int.TryParse(textBoxPrice.Text, out int price))
                {
                    MessageBox.Show("Kérjük, számértéket adjon meg az árnak!", "Érvénytelen érték!");
                    textBoxPrice.Focus();
                    return;
                }

                //Megerősítés a változtatás véghezvitele előtt
                DialogResult result = MessageBox.Show("Biztos meg akarod változtatni az árat?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ChangePrice();
                    MessageBox.Show("A változtatás sikeres volt!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
        }

        //Ha a felhasználó az 'Leírás szerkesztése' nevű gombra kattint
        private void button1_Click(object sender, EventArgs e)
        {
         
            //Ellenőrzés, hogy nem üres-e az ennek megfelelő textbox (üres értéket nem lehet megadni)
            if (string.IsNullOrEmpty(textboxDescription.Text))
            {
                MessageBox.Show("Kérjük adjon meg termékleírást!", "Nem adott meg új leírást!");
                textboxDescription.Focus();
            }
            else
            {
                //Megerősítés a változtatás véghezvitele előtt
                DialogResult result = MessageBox.Show("Biztos meg akarod változtatni a leírást?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ChangeDescription();
                    MessageBox.Show("A változtatás sikeres volt!", "Sikeres módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        //jelenlegi sor kiemelése
        private void TermekekDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Elmentjük a kattintott sor indexét
            int sorIndex = e.RowIndex;

            // Ellenőrizzük, hogy valóban kattintottak-e sorra
            if (sorIndex >= 0 && sorIndex < TermekekDGV.Rows.Count)
            {
                // Kijelöljük a korábban kattintott sorokat
                foreach (DataGridViewRow sor in TermekekDGV.Rows)
                {
                    sor.Selected = false;
                }

                // Kijelöljük a kattintott sort és megváltoztatjuk a háttérszínét
                DataGridViewRow kattintottSor = TermekekDGV.Rows[sorIndex];
                kattintottSor.Selected = true;
                TermekekDGV.DefaultCellStyle.SelectionBackColor = Color.Green;
            }
        }


        private void TermekekDGV_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
