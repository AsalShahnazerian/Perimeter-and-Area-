using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shape.Shape;
using Shape.Side_Shape;
namespace FormMasahtMohit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        ///    مساحت مربع , محیط مربع
        /// </summary>

        private void Btn_Squer_MH_Click(object sender, EventArgs e)
        {
            Shape_M_M.squer squer = new Shape_M_M.squer();
            squer.Length = Convert.ToDouble(T_Squer.Text);
            var ssquer = squer.GetArea();
            Result.Text = "محیط مربع:" + ssquer.ToString();
        }

        private void Btn_Squer_MS_Click(object sender, EventArgs e)
        {

           Shape_M_M.squer squer=new Shape_M_M.squer();
            squer.Length= Convert.ToDouble(T_Squer.Text);
            var ssquer = squer.Getperimater();
             Result.Text = "مساحت مربع:"+ssquer.ToString(); 

        }
        /// <summary>
        /// محیط مستطیل ,مساحت مستطیل
        /// </summary>

        private void Btn_Rectangle_MH_Click(object sender, EventArgs e)
        {
            Shape_M_M.Rectangle rectangle = new Shape_M_M.Rectangle();
            rectangle.Length = Convert.ToDouble(T_Rectanglel.Text);
            rectangle.Width = Convert.ToDouble(T_Rectanglew.Text);
            var rectanglee = rectangle.GetArea();
            Result.Text = "محیط مستطیل:" + rectanglee.ToString();
        }
     
        private void Btn_Rectangle_MS_Click(object sender, EventArgs e)
        {
            Shape_M_M.Rectangle rectangle = new Shape_M_M.Rectangle();
            rectangle.Length = Convert.ToDouble(T_Rectanglel.Text);
            rectangle.Width = Convert.ToDouble(T_Rectanglew.Text);
            var rectanglee = rectangle.Getperimater();
            Result.Text = "مساحت مستطیل:" + rectanglee.ToString();
        }
        /// <summary>
        /// محیط مثلث ,مساحت مثلث
        /// </summary>
        private void Btn_triangle_MS_Click(object sender, EventArgs e)
        {
            Shape_M_M.triangle triangle  = new Shape_M_M.triangle();
            triangle.Base = Convert.ToDouble(T_triangleg.Text);
            triangle.Height = Convert.ToDouble(T_triangleh.Text);
            var trianglee = triangle.Getperimater();
            Result.Text = "مساحت مثلث:" + trianglee.ToString();
        }

        private void Btn_triangle_MH_Click(object sender, EventArgs e)
        {
            Shape_M_M.triangle triangle = new Shape_M_M.triangle();
            triangle.Base = Convert.ToDouble(T_triangleg.Text);
            triangle.Height = Convert.ToDouble(T_triangleh.Text);
            triangle.Side = Convert.ToDouble(T_trianglev.Text);

            var trianglee = triangle.GetArea();
            Result.Text = "محیط مثلث:" + trianglee.ToString();
        }
        private void Btn_Circle_MS_Click(object sender, EventArgs e)
        {
            Shape_M_M.Circle circle = new Shape_M_M.Circle();
            circle.Radius = Convert.ToDouble(T_Circler.Text);
            var circlee = circle.Getperimater();
            Result.Text = "مساحت دایره:" + circlee.ToString();
        }
        private void Btn_Circle_MH_Click(object sender, EventArgs e)
        {
            Shape_M_M.Circle circle = new Shape_M_M.Circle();
            circle.Radius= Convert.ToDouble(T_Circler.Text);
     
            var circlee = circle.GetArea();
            Result.Text = "محیط دایره:" + circlee.ToString();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                  "فرمول مساحت و محیط اشکال"+
                  "      "
                  +
                  "مربع:"+
                   "         " +
                  " مساحت مـــربع = یـــک ضلع × خـــودش" + 
                  "محیــط مـــربــــع = یک ضلع × ۴"
                  +"        "
                  + "مستطیل"+
                  "         "+
                  " مساحت مسـتطیـــــــل = طـول × عـرض"+
                  "محیط مستطیل = ( طول + عرض) × ۲"
                  +
                  "            "
                  + "مثلث"
                  + " مساحت مثلث = ( قاعده × ارتــــــفاع ) ÷ ۲"
                  + "محیط مثلث = مجموع سه ضلع"
                  +
                   "            "
                  + "دایره"
                  + " p*(مساحت دایره= ( شعاع یه توان 2 "
                  + "وضرب بر 2pمحیط دایره= شعاع ضرب بر عدد "

                  ,

                  "A Message",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.RtlReading
                  ) ;
        }

        private void T_triangleg_TextChanged(object sender, EventArgs e)
        {

        }

       


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 842;//842 
           

        }

        private void standardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Width = 842;//842 

          
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1200;//842 
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confrim if you want to exit", "Area and perimater ", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(exitCal == DialogResult.Yes)
            {
             Application.Exit();

            }
        }
    }
}
