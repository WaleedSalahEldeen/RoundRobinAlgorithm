using System.Threading;
using System.Collections;
using System.Globalization;




namespace RoundRobinRunning
{
    public partial class main : Form
    {

        static private int burstTime = 0;
        static private int tQunantum = 0;
        static private int intr = 0;
        static private int allTime = 0;
        static private int tmpInt=0;
        static private int it=0;
        static private object[] arrOfList = new object[3];
        static private object[] arr = new object[3];
        // The sentence to display to the user
        public String Sentence = "A Round Robin Alogorithm Simulation By Waleed for 2nd FCIS of MU.";

        // The current letter position
        public int CurrentPos = 0;


        public main()
        {
            InitializeComponent();
        }
        private void init()
        {
            // Add the head of the list views
            processListView.Columns.Add("Name", 80, HorizontalAlignment.Center);
            processListView.Columns.Add("Arrival", 70, HorizontalAlignment.Center);
            processListView.Columns.Add("Brust", 60, HorizontalAlignment.Center);
            Thread th1 = new Thread(new ThreadStart(writeOnScreen));
            th1.Start();
            Color myColor = Color.FromArgb(46, 51, 73);

            SolidBrush myBrush = new SolidBrush(myColor);

            TimeViewList.DrawColumnHeader += (sender, args) =>
            {
                args.Graphics.FillRectangle(myBrush, args.Bounds);
                TextRenderer.DrawText(args.Graphics, args.Header.Text, args.Font, args.Bounds, Color.White);
            };

            /*
            //data set 1
             string[] row = { "p1", "4", "3" };
            var listViewItem = new ListViewItem(row);
            string[] row1 = { "p2", "3", "2" };
            var listViewItem1 = new ListViewItem(row1);
            string[] row2 = { "p3", "2", "1" };
            var listViewItem2 = new ListViewItem(row2);
            string[] row3 = { "p4", "1", "3" };
            var listViewItem3 = new ListViewItem(row3);
            string[] row4 = { "p5", "0", "5" };
            var listViewItem4 = new ListViewItem(row4);
            processListView.Items.Add(listViewItem);
            processListView.Items.Add(listViewItem1);
            processListView.Items.Add(listViewItem2);
            processListView.Items.Add(listViewItem3);
            processListView.Items.Add(listViewItem4);*/


            // data set 2
            /*
            string[] row = { "P1", "0", "4" };
            var listViewItem = new ListViewItem(row);
            string[] row1 = { "P2", "1", "5" };
            var listViewItem1 = new ListViewItem(row1);
            string[] row2 = { "P3", "2", "2" };
            var listViewItem2 = new ListViewItem(row2);
            string[] row3 = { "P4", "3", "1" };
            var listViewItem3 = new ListViewItem(row3);
            string[] row4 = { "P5", "4", "6" };
            var listViewItem4 = new ListViewItem(row4);
            string[] row5 = { "P6", "6", "3" };
            var listViewItem5 = new ListViewItem(row5);
            processListView.Items.Add(listViewItem);
            processListView.Items.Add(listViewItem1);
            processListView.Items.Add(listViewItem2);
            processListView.Items.Add(listViewItem3);
            processListView.Items.Add(listViewItem4);
           processListView.Items.Add(listViewItem5);
            */

            
            // data set 3
            /*
           string[] row = { "P1", "5", "5" };
            var listViewItem = new ListViewItem(row);
            string[] row1 = { "P2", "4", "6" };
            var listViewItem1 = new ListViewItem(row1);
            string[] row2 = { "P3", "3", "7" };
            var listViewItem2 = new ListViewItem(row2);
            string[] row3 = { "P4", "1", "9" };
            var listViewItem3 = new ListViewItem(row3);
            string[] row4 = { "P5", "2", "2" };
            var listViewItem4 = new ListViewItem(row4);
            string[] row5 = { "P6", "6", "3" };
            var listViewItem5 = new ListViewItem(row5);
            processListView.Items.Add(listViewItem);
            processListView.Items.Add(listViewItem1);
            processListView.Items.Add(listViewItem2);
            processListView.Items.Add(listViewItem3);
            processListView.Items.Add(listViewItem4);
           processListView.Items.Add(listViewItem5);
            */
            // quantum = 3
            // 
            

        }
        private void main_Load(object sender, EventArgs e)
        {

        init();



        }



        private void insert_Click(object sender, EventArgs e)
        {
            // check for empty fields
            if (pNameText.Text.Trim()==""||pArrivalText.Text.Trim()==""|| pBurstText.Text.Trim() == "")
            {
                MessageBox.Show("some required fields are empty, add all fields and try again.","Empty Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // try if the time is integer or not
            try
            {
                Int32.Parse(pBurstText.Text);
                Int32.Parse(pArrivalText.Text);
                string[] row = { pNameText.Text, pArrivalText.Text, pBurstText.Text };
                var listViewItem = new ListViewItem(row);
                processListView.Items.Add(listViewItem);
                pBurstText.Text = "";
                pArrivalText.Text = "";


            }
            catch
            {   
                MessageBox.Show("In Time Fields, Expected number. found String!!", "Unexpected Data Type!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (processListView.Items.Count == 0)
            {
                MessageBox.Show("Stop Playing with the App and Enter Some Processes", "NO PROCESSES!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else if (tQuantumText.Text == "")
            {
                MessageBox.Show("Enter the Quantum Time!", "NO Quantum!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                allTime = 0;
                it = 0;
                Array.Clear(arrOfList, 0, arrOfList.Length);

                sortMe();
                // timer1.Interval = tQunantum;
                //timer1.Start();
         
                Array.Resize(ref arrOfList, processListView.Items.Count);

                cpuLabel.Text = processListView.Items[0].SubItems[0].Text;
                tQunantum = Int32.Parse(tQuantumText.Text);
                for (int k = 0; k < int.Parse(processListView.Items[0].SubItems[1].Text); k++)
                    allTime += 1;
                timer2.Interval = 1000;
                timer2.Start();
              

            }
        }


        private void sortMe() //sort the ListView By Arrival Time
        {
           
            Array.Clear(arr, 0, arr.Length);
            Array.Resize(ref arr, processListView.Items.Count);

            for (int i = 0; i < processListView.Items.Count; i++)
            {
                arr[i] = processListView.Items[i].Clone();

            }
            Array.Sort(arr, delegate (object x, object y) { return ((ListViewItem)x).SubItems[1].Text.CompareTo(((ListViewItem)y).SubItems[1].Text); });
            for (int i = 0; i < processListView.Items.Count; i++)
            {
                //Put the Sorted Values to their Right Place
                processListView.Items[i].SubItems[0].Text = ((ListViewItem)arr[i]).SubItems[0].Text;
                processListView.Items[i].SubItems[1].Text = ((ListViewItem)arr[i]).SubItems[1].Text;
                processListView.Items[i].SubItems[2].Text = ((ListViewItem)arr[i]).SubItems[2].Text;

            }


        }
        private void toCpu() //Returnnin time in seconds and move the process to cpu label also delete it from the viewList
        {
            burstTime = int.Parse(processListView.Items[0].SubItems[2].Text.Trim());
            cpuLabel.Text = processListView.Items[0].Text;
        }
        private void timer1_Tick(object sender, EventArgs e) // timer explodes when the start button got clicked
        {



        }
        private void writeOnScreen() //usless func to write my name on screen using thread //In Case was askedto show a thread implementaion
        {
            int b = 0;
            try
            {
                while (true)
                    if (CurrentPos < Sentence.Length)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.label7.Text += Sentence[CurrentPos];
                        });
                        Thread.Sleep(150);
                        CurrentPos += 1;
                    }
                    else
                    {
                        if (b == 3)
                            break;
                        CurrentPos = 0;
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.label7.Text = "";
                        });

                        b++;

                    }
            }catch { };
        }

        private void addToReady()
        {
                     
                string[] rowReady = { processListView.Items[0].SubItems[0].Text };
                var readyViewItem = new ListViewItem(rowReady);
            //readyListView.Items.Insert(0,readyViewItem);
            readyListView.Columns.Add(processListView.Items[0].SubItems[0].Text,80, HorizontalAlignment.Center);

            if (readyListView.Columns.Count >1)
            {
                //if (readyListView.Items[0].Text == readyListView.Items[1].Text)
                if (readyListView.Columns[readyListView.Columns.Count - 1].Text == readyListView.Columns[readyListView.Columns.Count - 2].Text)
                {
                    readyListView.Columns.RemoveAt(readyListView.Columns.Count-1);
                    //readyListView.Items.RemoveAt(0);
                } else
                {
                    TimeViewList.Columns.Add(allTime.ToString(),80, HorizontalAlignment.Left);
                    TimeViewList.Width += 80;
                    TimeViewList.Height = 25;
                  
                }
            }
        }

        private void calcAverage()
        {
            int turnTmp = 0;
            string turnStr = "Average Turnaround time ( ";
            for(int i = 0; i < resultListView.Items.Count; i++)
            {
                turnTmp += Convert.ToInt32((resultListView.Items[i].SubItems[2].Text.Trim().Split("="))[1]);
               turnStr+= resultListView.Items[i].SubItems[2].Text.Trim().Split("=")[1];
            turnStr += " +";
            }
            turnStr = turnStr.Remove(turnStr.Length - 1) + ") / " + resultListView.Items.Count + " = " + turnTmp + " / " + resultListView.Items.Count + " = " + Math.Round(Convert.ToDouble(turnTmp) / resultListView.Items.Count,2) + " unit";

            int waitTmp = 0;
            string waitStr = "Average Waiting time ( ";
            for (int i = 0; i < resultListView.Items.Count; i++)
            {
                waitTmp += Convert.ToInt32((resultListView.Items[i].SubItems[3].Text.Trim().Split("="))[1]);
                waitStr += resultListView.Items[i].SubItems[3].Text.Trim().Split("=")[1];
                waitStr += " +";
            }
            waitStr = waitStr.Remove(waitStr.Length - 1) + ") / " + resultListView.Items.Count + " = " + waitTmp + " / " + resultListView.Items.Count + " = " + Math.Round(Convert.ToDouble(waitTmp) / resultListView.Items.Count,2) + " unit";
            turnaroundcalc.Text = turnStr;
            waitcalc.Text = waitStr;
            //MessageBox.Show($"{turnStr}\n{waitStr}");
        }
        private void timer2_Tick(object sender, EventArgs e) //The most important func
        {
            addToReady();
            if (processListView.Items.Count == 1 && processListView.Items[0].SubItems[2].Text=="1")//stop if there is one last element 
                timer2.Stop();
            
            tmpInt = int.Parse(processListView.Items[0].SubItems[2].Text.Trim()); // get current burst time
            processListView.Items[0].SubItems[2].Text = (tmpInt-1).ToString(); //set new burst time in the ListView
            if (tmpInt - 1 == 0) //if the burst time is 0
            {
                //set exit time and more
                for (int i = 0; i < arr.Length; i++)
                {
                    if (((ListViewItem)arr[i]).SubItems[0].Text == processListView.Items[0].SubItems[0].Text)
                    {
                        string[] row = { ((ListViewItem)arr[i]).SubItems[0].Text,
                            (allTime+1).ToString(),
                            $"{allTime+1} - {((ListViewItem)arr[i]).SubItems[1].Text} = {allTime+1 - Convert.ToInt32(((ListViewItem)arr[i]).SubItems[1].Text) }",
                            $"{allTime+1 - Convert.ToInt32(((ListViewItem)arr[i]).SubItems[1].Text)} - {((ListViewItem)arr[i]).SubItems[2].Text} = {(allTime+1 - Convert.ToInt32(((ListViewItem)arr[i]).SubItems[1].Text)) - Convert.ToInt32(((ListViewItem)arr[i]).SubItems[2].Text) }"
                        };
                        var listViewItem = new ListViewItem(row);
                        resultListView.Items.Add(listViewItem);

                    }
                }

                processListView.Items.RemoveAt(0);

                if (processListView.Items.Count > 0)
                { //add the new process to cpu
                    cpuLabel.Text = processListView.Items[0].SubItems[0].Text;
                    
                }
                intr = -1;
            }
           
            intr++;//the count timer for tQuantum
            allTime++;//all time passed
            if(intr == tQunantum)//if tQuantum is finished 
            {
                intr = 0;
                if (processListView.Items.Count>0)
                {
                    if (allTime >= int.Parse(processListView.Items[1].SubItems[1].Text))//if next element has already arrived
                    {
                        
                        string[] row = { processListView.Items[0].SubItems[0].Text, processListView.Items[0].SubItems[1].Text, processListView.Items[0].SubItems[2].Text };
                        var listViewItem = new ListViewItem(row);
                        processListView.Items.RemoveAt(0);
                        for (int i = 0; i < processListView.Items.Count; i++)
                        {
                            if (int.Parse(processListView.Items[i].SubItems[1].Text) == 0 && listViewItem.SubItems[0].Text=="0")
                            {
                              
                                processListView.Items.Add(listViewItem);
                                processListView.Items[processListView.Items.Count - 1].SubItems[1].Text = "0";
                                break;
                            }
                          
                            if (allTime < int.Parse(processListView.Items[i].SubItems[1].Text))
                            {
                                
                                processListView.Items.Insert(i, listViewItem);
                                processListView.Items[i].SubItems[1].Text = "0";
                                break;
                            }
                            if (i == processListView.Items.Count - 1 || (int.Parse(processListView.Items[i].SubItems[1].Text) == 0 && int.Parse(processListView.Items[0].SubItems[1].Text) == 0))
                            {
                                
                                processListView.Items.Add(listViewItem);
                                processListView.Items[processListView.Items.Count-1].SubItems[1].Text = "0";
                                break;
                            }


                        }
                        
                        cpuLabel.Text = processListView.Items[0].Text;
                        
                    }
                }

                
            }

             if(tmpInt - 1 == 0)
                intr = 0;



            if (processListView.Items.Count == 0)
            {
                TimeViewList.Columns.Add(allTime.ToString(), 80, HorizontalAlignment.Left);
                TimeViewList.Width += 80;
                TimeViewList.Height = 25;
                calcAverage();
            }
        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}