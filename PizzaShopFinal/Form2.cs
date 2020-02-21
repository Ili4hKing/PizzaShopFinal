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
using System.Text.RegularExpressions;

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
                var SizePizzas = db.SizePizza;
                var TypeDoughPizzas = db.typeDoughPizza;

                foreach (MenuPizza pl in MenuPizzas)
                {

                    this.comboBox1.Items.Add(pl.Pizza + "  " + pl.Cost);

                    //this.comboBox4.Items.Add(pl.Cost)

                }


                foreach (SizePizza tl in SizePizzas)
                {

                    this.comboBox2.Items.Add(tl.Size);



                }
                foreach (typeDoughPizza rl in TypeDoughPizzas)
                {

                    this.comboBox3.Items.Add(rl.Dough);

                }


            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PizzaShopEntities db = new PizzaShopEntities())
            {
                var MenuPizzas = db.MenuPizza;
                foreach (MenuPizza pl in MenuPizzas)
                {
                    //int  index = comboBox1.SelectedIndex + 1; 

                    //    label5.Text = pl.Cost;


                }
                //var MenuPizzass = db.MenuPizza;
                //foreach (MenuPizza pl in MenuPizzass)
                //{
                //    var id = comboBox1.SelectedIndex + 1 == pl.id;
                //    int r = Convert.ToInt32(pl.Cost);
                //    int t = pl.id;
                //    if (r == t )
                //    {
                //        label5.Text = pl.Cost;
                //    }
                //}

                //    customers.FirstOrDefault().CustomerName = "Нузо";

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label5.Text = comboBox1.Text;


            using (IDbConnection connection = new SqlConnection())
            {
            }
            using (PizzaShopEntities db = new PizzaShopEntities())
            {
                var ShoppingBaskets = db.ShoppingBasket;
                foreach (ShoppingBasket pl in ShoppingBaskets)
                {

                    comboBox1.Text = pl.Pizza;
                    comboBox2.Text = pl.Size;
                    comboBox3.Text = pl.Dough;
                    db.SaveChanges();

                }


                //PizzaShopContext ShoppingBaskets = new PizzaShopContext() {db.ShoppingBasket.Add };
                //db.shoppingBaskets.Add(ShoppingBaskets);
                //db.SaveChanges();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (PizzaShopEntities db = new PizzaShopEntities())
            {

                var MenuPizzas = db.MenuPizza;
                foreach (MenuPizza pl in MenuPizzas)
                {
                    int id = comboBox1.SelectedIndex + 1;
                    //    int r = Convert.ToInt32(pl.Cost);
                    //    int t = pl.id;
                    //    if (r == t)
                    //    {
                    //        label5.Text = pl.Cost;
                    //    }
                    int co = Convert.ToInt32(pl.id);

                    IEnumerable<int> scoreQuery =
            from MenuPizza in MenuPizzas
            where MenuPizza.id == id
            select pl.id;


                    // Execute the query.
                    foreach (int i in scoreQuery)
                    {
                        if (i == id)
                        {
                            label5.Text = pl.Cost;


                            //label5.Text = Convert.ToString(i);
                        }


                    }
                }

                //    string tem;
                //tem = comboBox1.Text;
                //string cleanString = Regex.Replace(tem, @"[^0-9]", "");


                ////Convert.ToInt32(cleanString);
                //int c = Convert.ToInt32(cleanString) + 100;
                //label5.Text = Convert.ToString(c);
            }
        }
    }
}
