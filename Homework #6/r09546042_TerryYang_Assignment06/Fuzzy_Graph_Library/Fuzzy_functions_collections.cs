using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuzzy_Graph_Library
{
    public class Fuzzy_functions_collections
    {


        #region Data Fields
        protected string[] parameter_Names;
        protected double[] parameter;
        private Fuzzy_display_area fda;
        protected Random rnd = new Random();
        protected TreeNode parent_Node;
        protected Color series_color;
        protected Series fuzzy_series;
        protected double minimum;
        protected double maximum;
        protected double resolution;
        protected double Interval;
        private bool show_series = true;
        private int series_border_width = 2;
        private string name;
        public event EventHandler FFC_Parameter_Changed;

        //public event EventHandler Parameter_Changed;
        [Category("Identification"), Description("Name of the function")]
        public string Name
        {
            get => name;
            set
            {
                if (fuzzy_series != null)
                {
                    if (value != "")
                    {
                        name = value;
                        fuzzy_series.Name = value;
                        if (parent_Node != null)
                        {
                            parent_Node.Text = value;
                        }
                        Parameter_Change();
                    }
                }
            }
        }
        [Category("Series"), Description("Color of the series")]
        public Color Color
        {
            get => fuzzy_series.Color;
            set
            {
                series_color = value;
                fuzzy_series.Color = value;
                Parameter_Change();
            }
        }
        [Category("Series"), Description("Border width of the series")]
        public int Border_width
        {
            get => series_border_width;
            set
            {
                if (value >= 0)
                {
                    series_border_width = value;
                    fuzzy_series.BorderWidth = value;
                    Parameter_Change();
                }
            }
        }

        [Category("Series"), Description("Show seies or not")]
        public bool Show
        {
            get => show_series;
            set
            {
                show_series = value;
                fuzzy_series.Enabled = value;
                Parameter_Change();
            }
        }

        [Browsable(false)]
        public Fuzzy_display_area Fda { get => fda; set => fda = value; }


        public virtual double Max_Degree
        {
            get => 1.0;
        }


        #endregion

        #region Operator Overloaded
        // Unary Operator
        public static Unary_Operated_fuzzy_set operator ~(Fuzzy_functions_collections operand)
        {
            // concentration
            Unary_Operated_fuzzy_set result = null;
            Unary_Opertor op = new Concentration_Operator();
            result = new Unary_Operated_fuzzy_set(op, operand);
            return result;
        }
        public static Unary_Operated_fuzzy_set operator -(double cutvalue, Fuzzy_functions_collections operand)
        {
            // cut
            Unary_Operated_fuzzy_set result = null;
            Unary_Opertor op = new ValueCut_Operator(cutvalue);
            result = new Unary_Operated_fuzzy_set(op, operand);
            return result;
        }
        public static Unary_Operated_fuzzy_set operator *(double scalevalue, Fuzzy_functions_collections operand)
        {
            // cut
            Unary_Operated_fuzzy_set result = null;
            Unary_Opertor op = new ValueScale_Operator(scalevalue);
            result = new Unary_Operated_fuzzy_set(op, operand);
            return result;
        }
        public static Unary_Operated_fuzzy_set operator !(Fuzzy_functions_collections operand)
        {
            // negate
            Unary_Operated_fuzzy_set result = null;
            Unary_Opertor op = new Negate_Operator();
            result = new Unary_Operated_fuzzy_set(op, operand);
            return result;
        }


        // Binary Operator
        public static Binary_Operated_fuzzy_set operator &(Fuzzy_functions_collections operand_01, Fuzzy_functions_collections operand_02)
        {
            // intersection
            Binary_Operated_fuzzy_set result = null;
            Binary_Operaor op = new Intersection_Operator();
            result = new Binary_Operated_fuzzy_set(op, operand_01, operand_02);
            return result;
        }

        public static Binary_Operated_fuzzy_set operator |(Fuzzy_functions_collections operand_01, Fuzzy_functions_collections operand_02)
        {
            Binary_Operated_fuzzy_set result = null;
            Binary_Operaor op = new Union_Operator();
            result = new Binary_Operated_fuzzy_set(op, operand_01, operand_02);
            return result;
        }
        public static Binary_Operated_fuzzy_set operator <(Fuzzy_functions_collections operand_01, Fuzzy_functions_collections operand_02)
        {
            Binary_Operated_fuzzy_set result = null;
            Binary_Operaor op = new AlgebraicSum_Operator();
            result = new Binary_Operated_fuzzy_set(op, operand_01, operand_02);
            return result;
        }
        public static Binary_Operated_fuzzy_set operator >(Fuzzy_functions_collections operand_01, Fuzzy_functions_collections operand_02)
        {
            Binary_Operated_fuzzy_set result = null;
            Binary_Operaor op = new AlgebraicProduct_Operator();
            result = new Binary_Operated_fuzzy_set(op, operand_01, operand_02);
            return result;
        }
        public static Binary_Operated_fuzzy_set operator +(Fuzzy_functions_collections operand_01, Fuzzy_functions_collections operand_02)
        {
            Binary_Operated_fuzzy_set result = null;
            Binary_Operaor op = new DombiTNorm_Operator();
            result = new Binary_Operated_fuzzy_set(op, operand_01, operand_02);
            return result;
        }

        public static Binary_Operated_fuzzy_set operator %(Fuzzy_functions_collections operand_01, Fuzzy_functions_collections operand_02)
        {
            Binary_Operated_fuzzy_set result = null;
            Binary_Operaor op = new BoundedProduct_Operator();
            result = new Binary_Operated_fuzzy_set(op, operand_01, operand_02);
            return result;
        }
        public static Binary_Operated_fuzzy_set operator ^(Fuzzy_functions_collections operand_01, Fuzzy_functions_collections operand_02)
        {
            Binary_Operated_fuzzy_set result = null;
            Binary_Operaor op = new BoundedSum_Operator();
            result = new Binary_Operated_fuzzy_set(op, operand_01, operand_02);
            return result;
        }
        public static Binary_Operated_fuzzy_set operator /(Fuzzy_functions_collections operand_01, Fuzzy_functions_collections operand_02)
        {
            Binary_Operated_fuzzy_set result = null;
            Binary_Operaor op = new Subtraction_Operator();
            result = new Binary_Operated_fuzzy_set(op, operand_01, operand_02);
            return result;
        }
        #endregion

        #region Constructor
        public Fuzzy_functions_collections(Fuzzy_display_area FDA)
        {
            this.fda = FDA;
            fuzzy_series = new Series();
            fuzzy_series.ChartType = SeriesChartType.Line;
            fuzzy_series.BorderWidth = 2;
            fuzzy_series.Legend = fda.Get_Legend().Name;
            maximum = FDA.Maximum;
            minimum = FDA.Minimum;
            resolution = FDA.Resolution;
            FDA.Parameter_Changed += FDA_Parameter_Change;
        }

        #endregion

        public virtual bool Is_Monotonic { get => false; }
        #region Defuzzification
        public virtual double Area
        {
            get
            {
                double area = 0;
                for (double x = minimum; x < maximum; x = x + Interval)
                {
                    double delta_Area = Get_Function_Value(x) * Interval;
                    area += delta_Area;
                }
                return area;
            }
        }
        public virtual double MOM
        {
            // return Max Degree half point
            get
            {
                List<double> max_location = new List<double>();
                Calculate_Max_Degree();
                for (double x = minimum; x < maximum; x = x + Interval)
                {
                    if (Get_Function_Value(x) == Max_Degree)
                    {
                        max_location.Add(x);
                    }
                }
                if (max_location.Count == 0) return double.NaN;
                double[] Max_location = new double[max_location.Count];
                Max_location = max_location.ToArray();
                double mid = Max_location[(Max_location.Length / 2)];
                return mid;
            }
        }
        public virtual double SOM
        {
            // return first Max Degree X value
            get
            {
                double value = double.NaN;
                for (double x = minimum; x < maximum; x = x + Interval)
                {
                    Calculate_Max_Degree();
                    if (Get_Function_Value(x) == Max_Degree)
                    {
                        value = x;
                        break;
                    }
                }
                return value;
            }
        }
        public virtual double LOM
        {
            // return Last Max Degree X value
            get
            {
                double value = double.NaN;
                for (double x = maximum; x > minimum; x = x - Interval)
                {
                    Calculate_Max_Degree();
                    if (Get_Function_Value(x) == Max_Degree)
                    {
                        value = x;
                        break;
                    }
                }
                return value;
            }
        }
        public virtual double BOA
        {

            get
            {
                double half_area = 0;
                double value = double.NaN;
                for (double x = fda.Minimum; x < fda.Maximum; x = x + Interval)
                {
                    double delta_Area = Get_Function_Value(x) * Interval;
                    half_area += delta_Area;
                    if (half_area >= 0.5 * Area)
                    { 
                        value = x;
                        break;
                    }
                }
                return value;
            }
        }
        public virtual double COA
        {

            get
            {
                double area_Distance = 0;
                for (double x = fda.Minimum; x < fda.Maximum; x = x + Interval)
                {
                    double delta_Area = Get_Function_Value(x) * Interval;
                    area_Distance += delta_Area * x;

                }
                if (Area == 0) return Math.Abs(fda.Minimum + fda.Maximum) / 2.0;
                return area_Distance / Area;
            }
        }
        #endregion
        public virtual double Get_Universe_Value_for_a_Degree(double degree)
        {
            if (Is_Monotonic == false) return -1;
            double current_FDA_Value = fda.Minimum;
            double incensement = Math.Abs((minimum - maximum) / resolution);

            if (this.Get_Function_Value(fda.Maximum) >= this.Get_Function_Value(fda.Minimum))
            {
                //increase
                do
                {
                    if (Get_Function_Value( current_FDA_Value) <= degree && Get_Function_Value(current_FDA_Value + incensement) > degree)
                    {
                        return current_FDA_Value;
                    }
                    current_FDA_Value = current_FDA_Value + incensement;
                } while (current_FDA_Value < fda.Maximum);
            }
            else
            {
                //dwindle
                do
                {
                    if (Get_Function_Value(current_FDA_Value) > degree && Get_Function_Value(current_FDA_Value + incensement) <= degree)
                    {
                        return current_FDA_Value;
                    }
                    current_FDA_Value = current_FDA_Value + incensement;
                } while (current_FDA_Value < fda.Maximum);
            }

            return double.NaN;
        }
        #region Functions
        public Series Plot_Graph()
        {
            fuzzy_series.ChartArea = fda.Name;
            return fuzzy_series;
        }
        public void Set_Series(Color c, SeriesChartType t)
        {
            fuzzy_series.Color = c;
            fuzzy_series.ChartType = t;
        }
        protected void FDA_Parameter_Change(object sender, EventArgs e)
        {
            if (fuzzy_series.Name != "")
            {
                Generate_Series();
            }
        }


        public string[] Return_Parameters_Names()
        {
            return parameter_Names;
        }
        public void Set_Tree_Node(TreeNode tn)
        {
            parent_Node = tn;
        }

        protected virtual void Parameter_Change()
        {
            if (fuzzy_series != null)
            {
                //Plot_Graph().ChartArea = FDA.Get_Chart_Area().ToString();
                Generate_Series();
                Plot_Graph();
            }
            if (FFC_Parameter_Changed != null)
                FFC_Parameter_Changed(this, null);
        }
        public virtual void Generate_Series()
        {
            fuzzy_series.Points.Clear();
            minimum = fda.Minimum;
            maximum = fda.Maximum;
            resolution = fda.Resolution;
            Interval = Math.Abs(minimum - maximum) / resolution;
            for (double i = minimum; i < maximum + 1; i = i + Interval)
            {
                double p = Get_Function_Value(i);
                fuzzy_series.Points.AddXY(i, p);
            }
            Calculate_Max_Degree();
        }
        public virtual double Get_Function_Value(double x)
        {
            throw new Exception();
        }

        protected double Calculate_Max_Degree()
        {
            // find maximum degree
            double max = double.MinValue;
            for (double x = minimum; x < maximum; x = x + Interval)
            {
                double md = Get_Function_Value(x);
                if (md > max)
                    max = md;
            }
            return max;
        }

        public override string ToString()
        {
            return name;
        }

        public int Hash_Code_Stored{get; set;}
        public double Random_Value(double v)
        { 
        return (v+3*(rnd.NextDouble()-0.5));
        }
        public virtual void Reconnect_Fuzzy_Set_Reference(List<Fuzzy_functions_collections> existing_Fuzzy_Sets) 
        {
            //foreach (Fuzzy_functions_collections fs in existing_Fuzzy_Sets)
            //{
            //    if (fs.Hash_Code_Stored == )
            //    {

            //    }
            //}
        }
        public virtual void Read_Model(StreamReader sr)
        {
            string str = sr.ReadLine().Trim() ;
            name = str.Substring(str.IndexOf(':') + 1);

            str = sr.ReadLine().Trim();
            Hash_Code_Stored = int.Parse(str.Substring(str.IndexOf(':') + 1));

            str = sr.ReadLine().Trim();
            int number_Of_Parameters = int.Parse( str.Substring(str.IndexOf(':') + 1));

            if (number_Of_Parameters >  0 )
            {
                parameter = new double[number_Of_Parameters];
                for (int i = 0; i < number_Of_Parameters; i++)
                {
                    //double v;
                    str = sr.ReadLine().Trim();
                    parameter[i] = double.Parse(str.Substring(str.IndexOf(':') + 1));
                }
            }             
            str = sr.ReadLine().Trim();
            show_series =  bool.Parse( str.Substring(str.IndexOf(':') + 1));
        }

        public virtual void  Save_Model(StreamWriter sw)
        {
            sw.WriteLine($"Name:{name}");
            sw.WriteLine($"HashCode:{this.GetHashCode()}");
            if (parameter != null)
            {
                sw.WriteLine($"NumberOfParameters:{parameter.Length}");
                foreach (double p in parameter)
                    sw.WriteLine($"ParValue:{p}");                
            }
            else sw.WriteLine($"NumberOfParameters:0");

            sw.WriteLine($"ShowFunction:{show_series}");
        }
        #endregion

    }
}
