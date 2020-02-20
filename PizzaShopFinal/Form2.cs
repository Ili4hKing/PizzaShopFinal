using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PizzaShopFinal
{

    

    

  

    public partial class Form2 : Form
    {

        //[Table("ShoppingBasket")]
        //public class ShoppingBasket
        //{
        //    [Key]
        //    public int id { get; set; }
        //    [ForeignKey("Pizza")]
        //    public string Pizza { get; set; }
        //    [ForeignKey("Size")]
        //    public int Size { get; set; }
        //    [ForeignKey("Dough")]
        //    public string typeDough { get; set; }
        //    public int Cost { get; set; }


        //}

        //public class ShoppingBasketContext : DbContext
        //{
        //    public ShoppingBasketContext() : base("DBConnection")
        //    { }
        //    public DbSet<ShoppingBasket> shoppingBaskets { get; set; }

        //}

        public class Player
        {
            public int Id { get; set; } //Свойство с именем Id или PlayerId автоматически будет использоваться как primary key
            public string Nickname { get; set; }
            public int Rank { get; set; }
        }
        public class PlayerContext : DbContext //Вся необходимая логика наследуется из DbContext
        {
            public PlayerContext()
                : base("DBConnection") //При инстанцировании объекты этого класса будут получать connectionString с названием DBConnection из файла конфигурации
            { }

            public DbSet<Player> Players { get; set; } //Таблица Players
        }
        public Form2()
        {
            InitializeComponent();

            using (IDbConnection connection = new SqlConnection())
            {
            }
            using (PizzaShopEntities db = new PizzaShopEntities())
            {
                var MenuPizzas = db.MenuPizza;
                //var SizePizzas = db.SizePizza;
                //var TypeDoughPizzas = db.typeDoughPizza;
                
                foreach (MenuPizza pl in MenuPizzas)
                {

                    this.comboBox1.Items.Add(pl.Pizza);
                    //this.comboBox4.Items.Add(pl.Cost)

                }
                //foreach (SizePizza pl in SizePizzas)
                //{

                //    this.comboBox2.Items.Add(pl.Size);

                    

                //}
                //foreach (typeDoughPizza pl in TypeDoughPizzas)
                //{

                //    this.comboBox3.Items.Add(pl.Dough);
                    
                //}


            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label5.Text = comboBox1.Text;
            //SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-7M3OBV0\MUTSY; Initial catalog = PizzaShop; Integrated Security = SSPI");
            //connection.Open();
            //SqlCommand SqlReg = new SqlCommand("insert into dbo.ShoppingBasket ( Pizza, Size, Dough, Cost) values " + "("  + comboBox1.Text + "," + Convert.ToInt32(comboBox2.Text) + "," + comboBox3.Text + "," + comboBox4.Text + ")", connection);
            //SqlDataReader SqlReader = null;
            //SqlReader = SqlReg.ExecuteReader();

            using (IDbConnection connection = new SqlConnection())
            {
            }
            using (PizzaShopEntities db = new PizzaShopEntities())
            {
                var ShoppingBaskets = db.ShoppingBasket;
                foreach(ShoppingBasket pl in ShoppingBaskets)
                {
                    
                    comboBox1.Text = pl.Pizza;
                    comboBox2.Text = pl.Size;
                    comboBox3.Text = pl.Dough;
                    comboBox4.Text = pl.Cost;

                }


                //PizzaShopContext ShoppingBaskets = new PizzaShopContext() {db.ShoppingBasket.Add };
                //db.shoppingBaskets.Add(ShoppingBaskets);
                //db.SaveChanges();

            }

        }
    }
}
