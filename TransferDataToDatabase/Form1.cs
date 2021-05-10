using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransferDataToDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            ///string strDBName = "smart_market";
            string strDBName = txtDBName.Text;
            string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog="+strDBName+";Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("", conn);
            DataTable tbl = new DataTable();
            if (rdoCategories.Checked)
                ///cmd.CommandText = "select distinct case  when Part='أرز ومكرونات' then 1 when Part='الرشيدي الميزان' then 2 when Part='أندومي' then 3 when Part='ألبان' then 4 when Part='البوادي' then 5 when Part='شيبسي' then 6 when Part='بقوليات' then 7 when Part='جبن' then 8 when Part='مخللات وجبن' then 9 when Part='فاين' then 10 when Part='كولا وبيبسي' then 11 when Part='مولتو' then 12 when Part='أيس كريم' then 13 when Part='سجاير' then 14 when Part='الشيكولاتة' then 15 when Part='الهانم' then 16 when Part='مشروبات' then 17 when Part='نسلا' then 18 when Part='هاينز' then 19 when Part='تونة' then 20 when Part='المنظفات' then 21 when Part='مربى وعسل' then 22 when Part='مصنعات' then 23 when Part='مجمدات' then 24 when Part='لنشون' then 25 when Part='بسكويت' then 26 when Part='عصاير' then 27 when Part='كريستال' then 28 when Part='دريم' then 29 when Part='كروت شحن' then 30 else 31 end as 'CategoryValue', RTrim(part) from categories";
                //cmd.CommandText = "select * from categeories";
                cmd.CommandText = "select * from category";

            else if (rdoProduct.Checked)
                cmd.CommandText = "select Prod_name,Barcode,Prod_cost,Prod_price,Cat_Id from Product order by Prod_price desc";
                ///cmd.CommandText = "SELECT RTrim(cat_name),RTrim(Part),price,stock_cost,cat_id FROM categories ";
                ///cmd.CommandText = "select Prod_name,Barcode,Prod_cost,Prod_price,Cat_Id from product";
                //cmd.CommandText = "select pro_id,pro_name,buy_price,sale_price,cat_id from product";
                //cmd.CommandText = "select pro_id,pro_name,buy_price,sale_price,p.cat_id,cat_name from product p ,category c where p.cat_id=c.cat_id order by pro_id";
            conn.Open();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            dgv.DataSource = tbl;
            lblCountRows.Text= "Result : "+dgv.RowCount+" Row(s)";
        }

        private void btnDataWillTransfer_Click(object sender, EventArgs e)
        {
            string strDBName = "smart_market";
            string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=" + strDBName + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("", conn);
            DataTable tbl = new DataTable();
            cmd.CommandText = "select RTrim(cat_name), case  when Part='أرز ومكرونات' then 1 when Part='الرشيدي الميزان' then 2 when Part='أندومي' then 3 when Part='ألبان' then 4 when Part='البوادي' then 5 when Part='شيبسي' then 6 when Part='بقوليات' then 7 when Part='جبن' then 8 when Part='مخللات وجبن' then 9 when Part='فاين' then 10 when Part='كولا وبيبسي' then 11 when Part='مولتو' then 12 when Part='أيس كريم' then 13 when Part='سجاير' then 14 when Part='الشيكولاتة' then 15 when Part='الهانم' then 16 when Part='مشروبات' then 17 when Part='نسلا' then 18 when Part='هاينز' then 19 when Part='تونة' then 20 when Part='المنظفات' then 21 when Part='مربى وعسل' then 22 when Part='مصنعات' then 23 when Part='مجمدات' then 24 when Part='لنشون' then 25 when Part='بسكويت' then 26 when Part='عصاير' then 27 when Part='كريستال' then 28 when Part='دريم' then 29 when Part='كروت شحن' then 30 else 31 end as 'CategoryValue',price,stock_cost,RTrim(cat_id) from categories";
            conn.Open();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            dgv.DataSource = tbl;
            lblCountRows.Text = "Result : " + dgv.RowCount + " Row(s)";
        }

        private void btnTransferData_Click(object sender, EventArgs e)
        {
            ///string strDBName = "sales_pro";
            ///string strDBName = "salespro_max";
            //string strDBName = "sales_super";
            string strDBName = "sales_demo";
            string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=" + strDBName + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("", conn);
            int num = 1;
            conn.Open();
            string ProName;
            //for (int x = 0; x < dgv.Rows.Count; x++)
            //{
            //    ////Category
            //    //cmd.CommandText = "insert into product values (" + num + ",N'" + dgv.Rows[x].Cells[0].Value + "',N'" + dgv.Rows[x].Cells[4].Value + "',200,0," + dgv.Rows[x].Cells[3].Value + "," + dgv.Rows[x].Cells[2].Value + ",5," + dgv.Rows[x].Cells[1].Value + ",0)";
            //    cmd.CommandText = "insert into category values (" + dgv.Rows[x].Cells[0].Value + ",N'" + dgv.Rows[x].Cells[1].Value + "')";
            //    cmd.ExecuteNonQuery();
            //    /// num += 1;
            //}
            for (int x = 0; x < dgv2.Rows.Count; x++)
            {
                ////Category
                //cmd.CommandText = "insert into product values (" + num + ",N'" + dgv.Rows[x].Cells[0].Value + "',N'" + dgv.Rows[x].Cells[4].Value + "',200,0," + dgv.Rows[x].Cells[3].Value + "," + dgv.Rows[x].Cells[2].Value + ",5," + dgv.Rows[x].Cells[1].Value + ",0)";
                cmd.CommandText = "insert into category values (" + dgv2.Rows[x].Cells[0].Value + ",N'" + dgv2.Rows[x].Cells[1].Value + "')";
                cmd.ExecuteNonQuery();
                /// num += 1;
            }
            for (int x = 0; x < dgv.Rows.Count; x++)
            {                
                //ProName = dgv.Rows[x].Cells[1].Value.ToString();
                ////product For Sales{ Demo,Junior,Super}
                cmd.CommandText = "insert into product values (" + num + ",N'" + dgv.Rows[x].Cells[0].Value + "',N'" + dgv.Rows[x].Cells[1].Value + "',200,0," + dgv.Rows[x].Cells[2].Value + "," + dgv.Rows[x].Cells[3].Value + ",5," + dgv.Rows[x].Cells[4].Value + ",0)";                
                ///cmd.CommandText = "insert into product values (" + num + ",N'" + dgv.Rows[x].Cells[0].Value + "',N'" + dgv.Rows[x].Cells[4].Value + "',200,0," + dgv.Rows[x].Cells[3].Value + "," + dgv.Rows[x].Cells[2].Value + ",5," + dgv.Rows[x].Cells[1].Value + ",0)";                
                ///cmd.CommandText = "insert into product values (" + dgv.Rows[x].Cells[0].Value + ",N'" + ProName + "',100,0," + dgv.Rows[x].Cells[2].Value + "," + dgv.Rows[x].Cells[3].Value + ",5," + dgv.Rows[x].Cells[4].Value + ",0,1,1,1)";
                cmd.ExecuteNonQuery();
                num += 1;
            }
            //for (int x = 0; x < dgv.Rows.Count; x++)
            //{
            //    ProName = dgv.Rows[x].Cells[1].Value.ToString();
            //    //cmd.CommandText = "insert into product values (" + num + ",N'" + dgv.Rows[x].Cells[0].Value + "',N'" + dgv.Rows[x].Cells[4].Value + "',200,0," + dgv.Rows[x].Cells[3].Value + "," + dgv.Rows[x].Cells[2].Value + ",5," + dgv.Rows[x].Cells[1].Value + ",0)";                
            //    cmd.CommandText = "insert into product values (" + dgv.Rows[x].Cells[0].Value + ",N'" + ProName + "',100,0," + dgv.Rows[x].Cells[2].Value + "," + dgv.Rows[x].Cells[3].Value + ",5," + dgv.Rows[x].Cells[4].Value + ",0,1,1,1)";
            //    cmd.ExecuteNonQuery();
            //    //num += 1;
            //}
            //for (int x = 0; x < dgv.Rows.Count; x++)
            //{
            //    //cmd.CommandText = "insert into product values (" + num + ",N'" + dgv.Rows[x].Cells[0].Value + "',N'" + dgv.Rows[x].Cells[4].Value + "',200,0," + dgv.Rows[x].Cells[3].Value + "," + dgv.Rows[x].Cells[2].Value + ",5," + dgv.Rows[x].Cells[1].Value + ",0)";
            //    cmd.CommandText = "insert into product_unit values (" + dgv.Rows[x].Cells[0].Value + ",1,1," + dgv.Rows[x].Cells[3].Value + ")";
            //    cmd.ExecuteNonQuery();
            //    ///num += 1;
            //}

            //for (int x = 0; x < dgv2.Rows.Count; x++)
            //{
            //    //cmd.CommandText = "insert into product values (" + num + ",N'" + dgv.Rows[x].Cells[0].Value + "',N'" + dgv.Rows[x].Cells[4].Value + "',200,0," + dgv.Rows[x].Cells[3].Value + "," + dgv.Rows[x].Cells[2].Value + ",5," + dgv.Rows[x].Cells[1].Value + ",0)";
            //    cmd.CommandText = "insert into product_barcode values (" + dgv2.Rows[x].Cells[0].Value + ",N'" + dgv2.Rows[x].Cells[1].Value + "',1)";
            //    cmd.ExecuteNonQuery();
            //    ///num += 1;
            //}
            conn.Close();
            MessageBox.Show("Successed");
        }

        private void btnFillDGV2_Click(object sender, EventArgs e)
        {
            //string strDBName = "sales_pro";
            string strDBName = txtDBName2.Text;
            string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=" + strDBName + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("", conn);
            DataTable tbl = new DataTable();
            if (rdoCategory2.Checked)
                cmd.CommandText = "select * from categeories";
            else if (rdoPoduct2.Checked)
                cmd.CommandText = "select pro_id,barcode from product order by pro_id";
            conn.Open();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            dgv2.DataSource = tbl;
            lblCountRows2.Text = "Result : " + dgv2.RowCount + " Row(s)";
        }
    }
}
