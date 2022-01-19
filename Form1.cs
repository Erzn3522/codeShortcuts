using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;


namespace List_n_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int add = 777;
        List<int> arrayList = new List<int>();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            createList(arrayList, 20);

            
            for (int Index = 0; Index < arrayList.Count; Index++)
            {
                

                Parallel.Invoke(
                   ()=> basicTextWrite(arrayList, Index),
                   () => writeFunc(Index),
                   () => deleteFunc(Index)

                   );
                //textBox1.Text += arrayList[Index].ToString() + "\r\n";

            }


        }
        private void writeFunc(int Index)
        {                        
            
            if (Index % 3==0 && Index!=0)
            {
                arrayList.Insert(Index, add);
            }
            
        }
        private void deleteFunc(int Index)
        {
            
            if (Index % 6 == 0 && Index != 0)
            {
                arrayList.RemoveAt(Index);
            }
            
        }
        private void basicTextWrite(List<int> list, int Index)
        {   
            textBox1.Text += list[Index].ToString() + "\r\n";
        }
        private void createList(List <int> list,int length)
        {
            for (int i = 0; i < length; i++)
            {
                list.Add(i);
            }
        }
        



    }
}
