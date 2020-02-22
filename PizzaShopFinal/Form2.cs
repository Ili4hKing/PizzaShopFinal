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
                    int id = comboBox1.SelectedIndex + 1;

                    int co = Convert.ToInt32(pl.id);

                    
                   
                        if (co ==id )
                        {
                            label5.Text = pl.Cost;



                        }


                    


                }
                
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            


            using (IDbConnection connection = new SqlConnection())
            {
            }
            using (PizzaShopEntities db = new PizzaShopEntities())
            {
                var ShoppingBaskets = db.ShoppingBasket;
                foreach (ShoppingBasket pl in ShoppingBaskets)
                {
                    //int i = pl.id;

                    //pl.id = i;
                    //pl.Pizza = comboBox1.Text;
                    //pl.Size = comboBox2.Text;
                    //pl.Dough = comboBox3.Text;
                    //pl.Cost = label5.Text;

                    //db.SaveChanges();
                    

                }


                

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

                    int co = Convert.ToInt32(pl.id);



                    if (co == id)
                    {
                        label5.Text = pl.Cost;



                    }





                }
            }

             
            }
        }
    }

