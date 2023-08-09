using System.Collections;

namespace CSet_BitArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblIsSubset.Text = null;
            lblSetA.Text = null;
            lblSetB.Text = null;
            lblSetC.Text = null;
            btnAddSetA.Enabled = false;
            btnAddSetB.Enabled = false;
            btnAddSetC.Enabled = false;
            btnClrSetA.Enabled = false;
            btnClrSetB.Enabled = false;
            btnClrSetC.Enabled = false;
            btnCLrReA.Enabled = false;
            btnClrReB.Enabled = false;
            btnClrReC.Enabled = false;
            btnRemoveA.Enabled = false;
            btnRemoveB.Enabled = false;
            btnRemoveC.Enabled = false;
            radiobtnSetA.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class CSet
        {
            private Hashtable data;

            public CSet()
            {
                data = new Hashtable();
            }

            public void Add(object item)
            {
                if (!(data.ContainsValue(item)))
                    data.Add(Hash(item), item);
            }

            private string Hash(object item)
            {
                int hashValue = 0;
                char[] chars;
                string s = item.ToString();
                chars = s.ToCharArray();
                for (int i = 0; i <= chars.GetUpperBound(0); i++)
                    hashValue += chars[i];
                return hashValue.ToString();
            }

            public void Remove(object item)
            {
                data.Remove(Hash(item));
            }

            public int Size()
            {
                return data.Count;
            }

            public CSet Union(CSet aSet)
            {
                CSet tempSet = new CSet();
                foreach (object hashObject in data.Keys)
                    tempSet.Add(data[hashObject]);
                foreach (object hashObject in aSet.data.Keys)
                    if (!(this.data.ContainsKey(hashObject)))
                        tempSet.Add(aSet.data[hashObject]);
                return tempSet;
            }

            public CSet Intersection(CSet aSet)
            {
                CSet tempSet = new CSet();
                foreach (Object hashObject in data.Keys)
                    if (aSet.data.Contains(hashObject))
                        tempSet.Add(data[hashObject]);
                return tempSet;
            }

            public bool Subset(CSet aSet)
            {
                if (this.Size() > aSet.Size())
                    return false;
                else
                {
                    foreach (object key in this.data.Keys)
                        if (!(aSet.data.Contains(key)))
                            return false;
                    return true;
                }
            }

            public CSet Difference(CSet aSet)
            {
                CSet tempSet = new CSet();
                foreach (object hashObject in data.Keys)
                    if (!(aSet.data.Contains(hashObject)))
                        tempSet.Add(data[hashObject]);
                return tempSet;
            }

            public override string ToString()
            {
                string s = "";
                foreach (object key in data.Keys)
                    s += data[key] + "; ";
                return s;
            }
        }
        CSet setA = new CSet();
        CSet setB = new CSet();
        CSet setC = new CSet();
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSetA_Click(object sender, EventArgs e)
        {

            setA.Add(txtAddSetA.Text);
            lblSetA.Text = "";
            lblSetA.Text = "{" + setA.ToString() + "}";

        }

        private void txtAddSetA_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddSetA.Text))
            {
                btnAddSetA.Enabled = false;
                btnClrSetA.Enabled = false;
            }
            else
            {
                btnAddSetA.Enabled = true;
                btnClrSetA.Enabled = true;
            }


        }

        private void txtAddSetB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddSetB.Text))
            {
                btnAddSetB.Enabled = false;
                btnClrSetB.Enabled = false;
            }
            else
            {
                btnAddSetB.Enabled = true;
                btnClrSetB.Enabled = true;
            }
        }

        private void txtAddSetC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddSetC.Text))
            {
                btnAddSetC.Enabled = false;
                btnClrSetC.Enabled = false;
            }
            else
            {
                btnAddSetC.Enabled = true;
                btnClrSetC.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAddSetA.Clear();
            txtAddSetA.Focus();
        }

        private void btnClrSetB_Click(object sender, EventArgs e)
        {
            txtAddSetB.Clear();
            txtAddSetB.Focus();
        }

        private void btnClrSetC_Click(object sender, EventArgs e)
        {
            txtAddSetC.Clear();
            txtAddSetC.Focus();
        }

        private void txtMaxSetValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (radiobtnUnion.Checked)
            {
                if (radiobtnSetA.Checked)
                {
                    setA = setB.Union(setC);
                    lblSetA.Text = "{" + setA.ToString() + "}";
                }
                else if (radiobtnSetB.Checked)
                {
                    setB = setA.Union(setC);
                    lblSetB.Text = "{" + setB.ToString() + "}";
                }
                else
                {
                    setC = setA.Union(setB);
                    lblSetC.Text = "{" + setC.ToString() + "}";
                }
            }
            if (radiobtnIntersection.Checked)
            {
                if (radiobtnSetA.Checked)
                {
                    setA = setB.Intersection(setC);
                    lblSetA.Text = "{" + setA.ToString() + "}";
                }
                else if (radiobtnSetB.Checked)
                {
                    setB = setA.Intersection(setC);
                    lblSetB.Text = "{" + setB.ToString() + "}";
                }
                else
                {
                    setC = setA.Intersection(setB);
                    lblSetC.Text = "{" + setC.ToString() + "}";
                }
            }
            if (radiobtnDifference.Checked)
            {
                if (radiobtnSetA.Checked)
                {
                    setA = setB.Difference(setC);
                    lblSetA.Text = "{" + setA.ToString() + "}";
                }
                else if (radiobtnSetB.Checked)
                {
                    setB = setA.Difference(setC);
                    lblSetB.Text = "{" + setB.ToString() + "}";
                }
                else
                {
                    setC = setA.Difference(setB);
                    lblSetC.Text = "{" + setC.ToString() + "}";
                }
            }


        }

        private void radiobtnSetA_CheckedChanged(object sender, EventArgs e)
        {
            radiobtnUnion.Text = "SetB Union SetC";
            radiobtnDifference.Text = "SetB Difference SetC";
            radiobtnIntersection.Text = "SetB InterSection SetC";
        }

        private void radiobtnSetB_CheckedChanged(object sender, EventArgs e)
        {
            radiobtnUnion.Text = "SetA Union SetC";
            radiobtnDifference.Text = "SetA Difference SetC";
            radiobtnIntersection.Text = "SetA InterSection SetC";
        }

        private void radiobtnSetC_CheckedChanged(object sender, EventArgs e)
        {
            radiobtnUnion.Text = "SetA Union SetB";
            radiobtnDifference.Text = "SetA Difference SetB";
            radiobtnIntersection.Text = "SetA InterSection SetB";
        }

        private void btnAddSetB_Click(object sender, EventArgs e)
        {
            setB.Add(txtAddSetB.Text);
            lblSetB.Text = "";
            lblSetB.Text = "{" + setB.ToString() + "}";

        }

        private void btnAddSetC_Click(object sender, EventArgs e)
        {

            setC.Add(txtAddSetC.Text);
            lblSetC.Text = "";
            lblSetC.Text = "{" + setC.ToString() + "}";

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            string subset = setA.Subset(setB) ? "A is a subset of B" : "A is not a subset of B";
            lblIsSubset.Text = subset;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string subset = setA.Subset(setC) ? "A is a subset of C" : "A is not a subset of C";
            lblIsSubset.Text = subset;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string subset = setB.Subset(setC) ? "B is a subset of C" : "B is not a subset of C";
            lblIsSubset.Text = subset;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string subset = setB.Subset(setA) ? "B is a subset of A" : "B is not a subset of A";
            lblIsSubset.Text = subset;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string subset = setC.Subset(setA) ? "C is a subset of A" : "C is not a subset of A";
            lblIsSubset.Text = subset;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string subset = setC.Subset(setB) ? "C is a subset of B" : "C is not a subset of B";
            lblIsSubset.Text = subset;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radiobtnUnion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            txtRemoveA.Clear();
            txtRemoveA.Focus();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            txtRemoveB.Clear();
            txtRemoveB.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            txtRemoveC.Clear();
            txtRemoveC.Focus();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            setA.Remove(txtRemoveA.Text);
            lblSetA.Text = "{" + setA.ToString() + "}";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            setB.Remove(txtRemoveB.Text);
            lblSetB.Text = "{" + setB.ToString() + "}";

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            setC.Remove(txtRemoveC.Text);
            lblSetC.Text = "{" + setC.ToString() + "}";

        }

        private void txtRemoveA_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRemoveA.Text))
            {
                btnRemoveA.Enabled = false;
                btnCLrReA.Enabled = false;
            }
            else
            {
                btnRemoveA.Enabled = true;
                btnCLrReA.Enabled = true;
            }
        }

        private void txtRemoveB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRemoveB.Text))
            {
                btnRemoveB.Enabled = false;
                btnClrReB.Enabled = false;
            }
            else
            {

                btnRemoveB.Enabled = true;
                btnClrReB.Enabled = true;
            }

        }

        private void txtRemoveC_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtRemoveC.Text))
            {
                btnRemoveC.Enabled = false;
                btnClrReC.Enabled = false;
            }
            else
            {

                btnRemoveC.Enabled = true;
                btnClrReC.Enabled = true;
            }
        }

        private void txtAddSetA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAddSetB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAddSetC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRemoveA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRemoveB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRemoveC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}