using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TView
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        private int index_search = 0;

        public Form1()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.List_View.ListViewItemSorter = lvwColumnSorter;
         
        }

       

        private void List_View_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.List_View.Sort();

        }

        public class ListViewColumnSorter : IComparer
        {
            private int ColumnToSort;
            private SortOrder OrderOfSort;
            private CaseInsensitiveComparer ObjectCompare;

            
            public ListViewColumnSorter()
            {
                ColumnToSort = 0;
                OrderOfSort = SortOrder.None;
                ObjectCompare = new CaseInsensitiveComparer();
            }

            
            public int Compare(object x, object y)
            {
                int compareResult;
                ListViewItem listviewX, listviewY;

                listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;

                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);

                if (OrderOfSort == SortOrder.Ascending)
                {
                    return compareResult;
                }
                else if (OrderOfSort == SortOrder.Descending)
                {
                    return (-compareResult);
                }
                else
                {
                    return 0;
                }
            }

            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }
            }

            public SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (List_View.Items.Count == 0)
                return;

            if (index_search == List_View.Items.Count)
            {
                MessageBox.Show("Nie znaleziono więcej");
                index_search = 0;
            }

            ListViewItem foundItem = List_View.FindItemWithText(textBox1.Text, true, index_search, true);

            if (foundItem != null)
            {
                List_View.TopItem = foundItem;
                foundItem.Selected = true;
                List_View.Select();
                index_search = foundItem.Index + 1;
            }
            else
            {
                if (index_search.Equals(0))
                    MessageBox.Show("Nie znaleziono");
                else
                    MessageBox.Show("Nie znaleziono więcej");
                
            }
            
        }
    }
}
