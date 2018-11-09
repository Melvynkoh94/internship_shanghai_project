using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace VerificationVentureForm
{
    public partial class Form1 : Form
    {
        int totalQnty = 0;
        List<String> PartNumScanned = new List<string>();
        int numChecked = 0;
        DataTable newDataTable = new DataTable();
        string path = string.Empty;
        string result_path = string.Empty;
        string fileExt = string.Empty;

        string combinedFirst = string.Empty;    //"TABLE1 - HEAD1 CM402 5 L"

        public Form1()
        {
            InitializeComponent();
            this.Text = "Verification";
        }

        private void textFirstScan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSecondScan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSecondScan_KeyDown(object sender, KeyEventArgs e)
        {       
            if (e.KeyCode == Keys.Return)
            {
                btnSearchAfterScan_Click(sender, e);
                textSecondScan = null;
                textFirstScan = null;
            }
        }

        private void btnSearchAfterScan_Click(object sender, EventArgs e)
        {
            searchAfterScan();
            /*
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string table = dataGridView1.Rows[row.Index].Cells["Table No."].Value.ToString();
                string reel = dataGridView1.Rows[row.Index].Cells["Reel"].Value.ToString();
                string side = dataGridView1.Rows[row.Index].Cells["Side"].Value.ToString();

                //REMOVE ALL SPACES BETWEEN CHARACTERS
                string fixedTable = Regex.Replace(table, @"\s", String.Empty);
                string fixedReel = Regex.Replace(reel, @"\s", String.Empty);
                string fixedSide = Regex.Replace(side, @"\s", String.Empty);
                combinedFirst = fixedTable + fixedReel + fixedSide;

                //THIS IS FROM USER INPUT
                string fixedFirstScan = Regex.Replace(textFirstScan.Text, @"\s", String.Empty);
                //MessageBox.Show("From user input "+fixedFirstScan);

                //THIS IS FROM TABLE READING
                string fixedCombinedFirst = Regex.Replace(combinedFirst, @"\s", String.Empty);
                //MessageBox.Show("From Table "+fixedCombinedFirst);


                //string fixedFirstScanText = Regex.Replace(textFirstScan.Text, @"\s", String.Empty);
                // MessageBox.Show(fixedFirstScanText);

                //bool isEqual = String.Equals(combinedFirst, fixedFirstScanText, StringComparison.OrdinalIgnoreCase);

                //MessageBox.Show(combinedFirst);


                string partNo = dataGridView1.Rows[row.Index].Cells["Part No."].Value.ToString();

                //if (isEqual == true)
                if ((fixedFirstScan == fixedCombinedFirst) && (textSecondScan.Text == partNo))
                {
                    datetime = DateTime.Now.ToString();
                    numChecked++;
                    dataGridView1.Rows[row.Index].Cells["Checked?"].Value = "Yes (" + datetime + ")";

                    dataGridView1 = colourRowCells(dataGridView1);

                    //*****
                    dataGridView1.Sort(dataGridView1.Columns["Checked?"], ListSortDirection.Descending);
                    colourRowCells(dataGridView1);
                    dataGridView1.Update();
                    dataGridView1.Refresh();

                    labQnty.Text = "Quantity Check: " + numChecked + " / " + totalQnty;

                    return;
                }

                else
                {
                    continue;
                }

                
                if (row.Cells["Part No."].Value.ToString() == textPartNo.Text)
                {
                    datetime = DateTime.Now.ToString();
                    dataGridView1.Rows[row.Index].Cells["Checked?"].Value = "Yes (" + datetime + ")";
                    PartNumScanned.Add(textPartNo.Text);
                    numChecked++;
                }
                
            }

            MessageBox.Show("SORRY NOT MATCHED!", "Error");
            */
            
        }

        string datetime = string.Empty;
        private void searchAfterScan()
        {                  
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string table = dataGridView1.Rows[row.Index].Cells["Table No."].Value.ToString();
                string reel  = dataGridView1.Rows[row.Index].Cells["Reel"].Value.ToString();
                string side = dataGridView1.Rows[row.Index].Cells["Side"].Value.ToString();                          
        
                //REMOVE ALL SPACES BETWEEN CHARACTERS
                string fixedTable = Regex.Replace(table, @"\s", String.Empty);
                string fixedReel = Regex.Replace(reel, @"\s", String.Empty);
                string fixedSide = Regex.Replace(side, @"\s", String.Empty);
                combinedFirst = fixedTable + fixedReel + fixedSide;

                //THIS IS FROM USER INPUT
                string fixedFirstScan = Regex.Replace(textFirstScan.Text, @"\s", String.Empty);

                //THIS IS FROM TABLE READING
                string fixedCombinedFirst = Regex.Replace(combinedFirst, @"\s", String.Empty);


                string partNo = dataGridView1.Rows[row.Index].Cells["Part No."].Value.ToString();

                /*
                if (( fixedFirstScan.Equals(fixedCombinedFirst, StringComparison.InvariantCultureIgnoreCase)) 
                    && (textSecondScan.Text.Equals(partNo, StringComparison.InvariantCultureIgnoreCase)))
                */

                // InvariantCultureIgnoreCase VS OrdinalIgnoreCase
                    //InvariantCultureIgnoreCase uses comparison rules based on english
                    // OrdinalIgnoreCase compares the character codes without cultural aspects. This is good for exact comparisons, like login names
                        //, but not for sorting strings with unusual characters like é or ö.


                if ((fixedFirstScan.Equals(fixedCombinedFirst, StringComparison.OrdinalIgnoreCase))
                    && (textSecondScan.Text.Equals(partNo, StringComparison.OrdinalIgnoreCase)))
                {
                    datetime = DateTime.Now.ToString();
                    numChecked++;
                    dataGridView1.Rows[row.Index].Cells["Checked?"].Value = "Yes (" + datetime + ")";

                    dataGridView1 = colourRowCells(dataGridView1);

                    //*****
                    dataGridView1.Sort(dataGridView1.Columns["Checked?"], ListSortDirection.Descending);
                    colourRowCells(dataGridView1);
                    dataGridView1.Update();
                    dataGridView1.Refresh();

                    labQnty.Text = "Quantity Check: " + numChecked + " / " + totalQnty;

                    return;
                }

                else
                {
                    continue;
                }          

                /*
                if (row.Cells["Part No."].Value.ToString() == textPartNo.Text)
                {
                    datetime = DateTime.Now.ToString();
                    dataGridView1.Rows[row.Index].Cells["Checked?"].Value = "Yes (" + datetime + ")";
                    PartNumScanned.Add(textPartNo.Text);
                    numChecked++;
                }
                */
            }

            MessageBox.Show("SORRY NOT MATCHED!", "Error");
        }

        private void btnUploadFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Please choose .xls or .xlsx files ONLY";
            fbd.Description = "只能选 .xls 或 .xlsx 的文件";

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
                //MessageBox.Show("Folder Uploaded", path);
                MessageBox.Show("上载成功");
            }

            //This is to fill the list for my textModelNo drop-down suggestion feature
            var listofModels = new AutoCompleteStringCollection();
            //int x = 0;
            try
            {
                foreach (string filename in Directory.GetFiles(path))
                {
                    //listofModels.Add("[00"+x+"] "+Path.GetFileNameWithoutExtension(filename));
                    listofModels.Add(Path.GetFileNameWithoutExtension(filename));

                }
                textModelNo.AutoCompleteCustomSource = listofModels;
                textModelNo.AutoCompleteMode = AutoCompleteMode.Suggest;
                textModelNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose a file in order to proceed");
            }
        }

        private void textModelNo_TextChanged(object sender, EventArgs e)
        {

        }



        private DataTable filterCells(DataGridView dtgv)  //this is to ignore EMPTY cells in dtExcel (DataTable type) 
        {
            DataTable newDataGridView = new DataTable();

            newDataGridView.Columns.Add("Table No.", typeof(string));
            newDataGridView.Columns.Add("Reel", typeof(string));
            newDataGridView.Columns.Add("Side", typeof(string));
            newDataGridView.Columns.Add("Part No.", typeof(string));
            newDataGridView.Columns.Add("Per", typeof(string));
            newDataGridView.Columns.Add("Checked?", typeof(string));

            int x = dtgv.ColumnCount;   // x = 5         

            string str = string.Empty;
            string machineModel = string.Empty;

            //MessageBox.Show("x: "+x);

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                //iterate column by column since x is number of columns
                for (int i = 0; i < x; i++)
                {
                    if (row.Cells[i].Value == null)
                        continue;

                    if (row.Cells[i].Value.ToString().Contains("MACHINE:"))
                    {
                        str = row.Cells[i].Value.ToString();
                        string[] tokens = str.Split(':');
                        int tokenCount = tokens.Count();
                        machineModel = tokens[tokenCount - 1];
                    }

                    if (row.Cells[i].Value.ToString().Contains("TABLE") && row.Cells[i].Value.ToString().Contains("HEAD"))
                    {
                        string tablenum = row.Cells[i].Value.ToString() + " " + machineModel;
                        PartClassVerify newPart = new PartClassVerify();

                        int nextRow = row.Index + 1;

                        //*****
                        /*
                        bool checkcell4 = String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[4].Value.ToString());
                        bool checkcell5 = String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[5].Value.ToString());

                        bool checkcell4n5 = checkcell4 | checkcell5;
                        */
                        //MessageBox.Show(checkcell4n5.ToString());
                        //*****                       

                        bool checkcellx2 = String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[x - 2].Value.ToString());
                        bool checkcellx3 = String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[x - 3].Value.ToString());

                        bool checkcellx23 = checkcellx2 | checkcellx3;

                        string tempReel = string.Empty;//this is to make sure track the empty REEL, give the empty with the previous
                        /*
                        while (!String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[4].Value.ToString())
                            && !dtgv.Rows[nextRow].Cells[0].Value.ToString().StartsWith("T")
                            && !dtgv.Rows[nextRow].Cells[0].Value.ToString().StartsWith("P"))
                        */
                        while (!(String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[4].Value.ToString())) || !(String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[5].Value.ToString()))
                            && !dtgv.Rows[nextRow].Cells[0].Value.ToString().StartsWith("T")
                            && !dtgv.Rows[nextRow].Cells[0].Value.ToString().StartsWith("P"))
                        //this is to ignore the next row that contains TABLE or is empty                    
                        {
                            //bool checkcell1 = String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[1].Value.ToString());

                            if (String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[0].Value.ToString()))
                            {
                                newPart._reel = tempReel;
                            }

                            if (!String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[0].Value.ToString()))
                            {
                                tempReel = dtgv.Rows[nextRow].Cells[0].Value.ToString();
                                newPart._reel = dtgv.Rows[nextRow].Cells[0].Value.ToString();
                            }

                            if (!String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[1].Value.ToString()))
                            {
                                newPart._table = tablenum;
                                newPart._side = dtgv.Rows[nextRow].Cells[1].Value.ToString();
                                newPart._partno = dtgv.Rows[nextRow].Cells[2].Value.ToString();
                                newPart._per = dtgv.Rows[nextRow].Cells[4].Value.ToString();
                                newPart.check = "-";

                                totalQnty++;

                                string[] tempRow = new string[] { newPart._table, newPart._reel, newPart._side, newPart._partno, newPart._per, newPart.check.ToString() };
                                newDataGridView.Rows.Add(tempRow);
                            }

                            nextRow++;  //move on to the next row
                        }
                    }

                    else
                    {
                        continue;
                    }
                }
            }

            //ERROR**** 
            //program never returns any newDataGridView!!
            return newDataGridView;
        }





        /*
        private DataTable filterCells(DataGridView dtgv)  //this is to ignore EMPTY cells in dtExcel (DataTable type) 
        {
            DataTable newDataGridView = new DataTable();

            newDataGridView.Columns.Add("Table No.", typeof(string));
            newDataGridView.Columns.Add("Reel", typeof(string));
            newDataGridView.Columns.Add("Side", typeof(string));
            newDataGridView.Columns.Add("Part No.", typeof(string));
            newDataGridView.Columns.Add("Per", typeof(string));
            newDataGridView.Columns.Add("Checked?", typeof(string));

            int x = dtgv.ColumnCount;   // x = 5
            //MessageBox.Show("There are "+x+" columns");

            string str = string.Empty; //token for machineModel
            string machineModel = string.Empty;

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                for (int i = 0; i < x; i++)
                {
                    if (row.Cells[i].Value == null)
                        continue;

                    if (row.Cells[i].Value.ToString().Contains("MACHINE:"))
                    {
                        str = row.Cells[i].Value.ToString();
                        string[] tokens = str.Split(':');
                        machineModel = tokens[1];
                        //MessageBox.Show(machineModel);
                    }

                    if (row.Cells[i].Value.ToString().Contains("TABLE") && row.Cells[i].Value.ToString().Contains("HEAD"))
                    {
                        //MessageBox.Show(machineModel);
                        string tablenum = row.Cells[i].Value.ToString() + " " +  machineModel;
                        PartClassVerify newPart = new PartClassVerify();

                        int nextRow = row.Index + 1;
                        int nRow = row.Index;

                        //*****
                        string tempReel = string.Empty;//this is to make sure track the empty REEL, give the empty with the previous
                        while (!String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[1].Value.ToString())
                            && !dtgv.Rows[nextRow].Cells[0].Value.ToString().StartsWith("T")
                            && !dtgv.Rows[nextRow].Cells[0].Value.ToString().StartsWith("P"))
                        //this is to ignore the next row that contains TABLE or is empty                    
                        {
                            nRow += 1;

                            if (String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[0].Value.ToString()))
                            {
                                newPart._reel = tempReel;   //if Reel is empty, give this the previous Reel value
                            }

                            if (!String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[0].Value.ToString()))
                            {
                                tempReel = dtgv.Rows[nextRow].Cells[0].Value.ToString();
                                newPart._reel = dtgv.Rows[nextRow].Cells[0].Value.ToString();
                            }

                            newPart._table = tablenum;
                            newPart._side = dtgv.Rows[nextRow].Cells[1].Value.ToString();
                            newPart._partno = dtgv.Rows[nextRow].Cells[2].Value.ToString();
                            newPart._per = dtgv.Rows[nextRow].Cells[4].Value.ToString();
                            newPart.check = "-";

                            totalQnty++;

                            //******************
                            string[] tempRow = new string[] { newPart._table, newPart._reel, newPart._side, newPart._partno, newPart._per, newPart.check.ToString() };
                            newDataGridView.Rows.Add(tempRow);
                            //******************

                            //TESTING*************** 
                            //MessageBox.Show("I entered here!"+ " I found "+tablenum+", Row: "+ nextRow+" k="+totalQnty); //should appear TWICE since there are 2 tables in this sheet
                            //TESTING***************  

                            nextRow++;  //move on to the next row
                        }
                    }

                    else
                    {
                        continue;
                    }
                }
            }

            //ERROR**** 
            //program never returns any newDataGridView!!
            return newDataGridView;
        }
        */




        //display on textboxes as you click on the cells
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.LightYellow;

            //textTable.Text = dataGridView1.SelectedRows[0].Cells["Table No."].Value.ToString();
            //textReel.Text = dataGridView1.SelectedRows[0].Cells["Reel"].Value.ToString();
            //textSide.Text = dataGridView1.SelectedRows[0].Cells["Side"].Value.ToString();
            //textPartNo.Text = dataGridView1.SelectedRows[0].Cells["Part No."].Value.ToString();
            //textPer.Text = dataGridView1.SelectedRows[0].Cells["Per"].Value.ToString();

            colourRowCells(dataGridView1);
        }

        public DataTable ReadExcel(string fileName, string fileExt) //read in Excel cells and store content into a temp Database (dtexcel)
        {
            //******************************
            //MessageBox.Show("filename is " + fileName + " fileExt is " + fileExt);
            string conn = string.Empty; //conn is the connection string 
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007 etc .XLS
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  .XLSX
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    con.Open();

                    DataTable dt = new DataTable(); // dt is just to store a list of sheet names from an Excel file
                    dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    List<string> sheetNameList = new List<string>();
                    foreach (DataRow item in dt.Rows)
                    {
                        string sheetName = item["TABLE_NAME"].ToString();   //sheetname == CM402-1$ e.g   

                        //ignores ÇM402-1'$Print_Area and ÇM402-2'$Print_Area**************
                        if (!sheetName.EndsWith("$") && !sheetName.EndsWith("$'"))
                            continue;
                        //MessageBox.Show(item["TABLE_NAME"].ToString());
                        sheetNameList.Add(sheetName);

                        var message = string.Join(Environment.NewLine, sheetNameList);
                        int count = sheetNameList.Count;    //should be count = 4

                        //MessageBox.Show(message+count);
                        //should print 'ÇM402-1$','ÇM402-2$', DT401$, Sheet1$   4
                        //with or without the '' doesnt matter 
                    }

                    //var worksheet = xlWorkBook.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;
                    //string sql = "SELECT * from ["+worksheet+"$]";
                    foreach (string str in sheetNameList)
                    {
                        string sql = "SELECT * from [" + str + "]";

                        OleDbDataAdapter oleAdpt = new OleDbDataAdapter(sql, con); //here we read data from sheet1
                        DataTable tempDT = new DataTable();
                        dtexcel.Merge(tempDT);
                        oleAdpt.Fill(dtexcel); //fill excel data into dataTable  

                    }
                    result_path = Path.GetFileNameWithoutExtension(fileName);
                    labelModel.Text = "Model Number: " + result_path;


                }
                catch
                {
                    //MessageBox.Show("There is an error reading the .xls or .xlsx file. Check for any discrepancies or any inconsistencies in the file.", "ERROR");
                    MessageBox.Show("你选的 Excel 文件有问题。 \nPlease check with the administrator.", "ERROR");

                }
            }
            return dtexcel;
        }

        private DataGridView colourRowCells(DataGridView dgvr)
        {
            //different colours for Check=1 and Check=0
            foreach (DataGridViewRow row in dgvr.Rows)
            {
                if (row.Cells[5].Value.ToString() == "-")
                {
                    dgvr.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else //if "YES"
                    dgvr.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            return dgvr;
            //dgvr.Refresh();
            //dgvr.Update();
        }


        string fileDirectory = string.Empty; //path of the file found with the Model No. name
        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (string filename in Directory.GetFiles(path))
            {
                var temp = path + @"\" + textModelNo.Text + ".xls";
                //filename is actually the directory to the file 
                //for instance, C:\Users\user\Desktop\VENTURE\VentureWindowsForm

                //The @' marks the string as a verbatim string literal
                //anything in the string that would normally be interpreted as an escape sequence ('\') is ignored.

                if (filename.CompareTo(temp) == 0)
                {
                    fileDirectory = filename;
                    DataTable dtExcel = new DataTable();

                    dtExcel = ReadExcel(filename, ".xls"); //read excel file  

                    dataGridView1.Visible = true;  //make the datatable invisible first
                                                   //dataGridView1.Visible = true; //TAKE NOTE: don't show the data yet, requires mapping

                    dataGridView1.DataSource = dtExcel; //SHOW THE DATA CELLS ON dataGridView1            

                    newDataTable = filterCells(dataGridView1);  //filtered out unneccessary cells
                                                                //mapping cells to (DataTable)newDataTable

                    dataGridView1.DataSource = newDataTable;
                    dataGridView1.Visible = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1 = colourRowCells(dataGridView1);
                    //MessageBox.Show("FOUND!", textModelNo.Text);
                    labQnty.Text = "Quantity Check: " + numChecked + " / " + totalQnty;
                    break;
                }
            }
            if (totalQnty == 0)
            {
                //MessageBox.Show("File not found or File is Empty!");
                MessageBox.Show("找不到文件！");
            }
            result_path = Path.GetFileNameWithoutExtension(fileDirectory);
            labelModel.Text = "Model Number: " + result_path;
        }

        private void textModelNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void labQnty_Click(object sender, EventArgs e)
        {

        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            //dummyExcel();
            totalQnty = 0;
            numChecked = 0;
            labQnty.Text = "Quantity Check: " + numChecked + " / " + totalQnty;
            labQnty.Refresh();

            DataTable newDataGridView = new DataTable();

            newDataGridView.Columns.Add("Table No.", typeof(string));
            newDataGridView.Columns.Add("Reel", typeof(string));
            newDataGridView.Columns.Add("Side", typeof(string));
            newDataGridView.Columns.Add("Part No.", typeof(string));
            newDataGridView.Columns.Add("Per", typeof(string));
            newDataGridView.Columns.Add("Checked?", typeof(string));
            dataGridView1.DataSource = newDataGridView;
            dataGridView1.Visible = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

            labelModel.Text = "Model Number: ";
        }



        private void dummyExcel()
        {
            DataTable dummyDataTable = new DataTable();
            //dummyDataTable = ReadExcel(@"C:\Users\hc\Desktop\Venture\VentureWindowsForm\dummy.xls", ".xls");
            dummyDataTable = ReadExcel(@"C:\Users\user\Desktop\VENTURE\VentureWindowsForm\dummy.xls", ".xls");
            dataGridView1.DataSource = dummyDataTable; //SHOW THE DATA CELLS ON dataGridView1            
            newDataTable = filterCells(dataGridView1);  //filtered out unneccessary cells
                                                        //mapping cells to (DataTable)newDataTable
            dataGridView1.DataSource = newDataTable;
        }

        //THIS IS A VERY POWERFUL 'DEBUG' BUTTON!!
        //What it does is to upload an .xls file e.g 'T8-E-201950-R-BOT' that works seamlessly
        //with the program
        //and then clear the datagridview, and preserve the format
        //lastly, it automatically uploads the file again that experienced the problem

        private void btnDebugError_Click_1(object sender, EventArgs e)
        {
            dummyExcel();
            btnClearTable_Click(sender, e);

            DataTable dtExcel = new DataTable();
            dtExcel = ReadExcel(fileDirectory, ".xls");
            dataGridView1.Visible = true;
            dataGridView1.DataSource = dtExcel;
            newDataTable = filterCells(dataGridView1);
            dataGridView1.DataSource = newDataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Visible = true;
            dataGridView1 = colourRowCells(dataGridView1);
            labQnty.Text = "Quantity Check: " + numChecked + " / " + totalQnty;
            /*
             * For the following codes here, program will RE-UPLOAD the file name again
             * Call ReadExcel + filterCells + btnChooseFile_Click
             */
        }

        private void labelModel_Click(object sender, EventArgs e)
        {
            //do nth when clicked
        }

       
    }
}
