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
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;


namespace VentureWindowsForm
{
    public partial class Form1 : Form
    {
        int totalQnty = 0;
        List<String> PartNumScanned = new List<string>();
        int numChecked = 0;
        DataTable newDataTable = new DataTable();
        string path = string.Empty;
        string result_path = string.Empty;   

        //this.Load += UserControl_Load; // or form or any control that is parent of the datagridview
        //dataGridView1.VisibleChanged += DataGridView1_VisibleChanged;

        //Excel.Application xlApp;
        //Excel.Workbook xlWorkBook;
        //Excel.Worksheet xlWorkSheet;
        //Excel.Range range;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Venture";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1 = colourRowCells(dataGridView1);
            label3.Text = "Quantity Check: " + numChecked + " / " + totalQnty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textModelNo_TextChanged(object sender, EventArgs e)
        {            
                 
        }

        private void textModelNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSearchModel_Click(sender, e);
            }
        }

        private void textReel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPartNo_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Part No."].Value.ToString() == textPartNo.Text)
                {
                    textTable.Text = dataGridView1.Rows[row.Index].Cells["Table No."].Value.ToString();
                    textReel.Text = dataGridView1.Rows[row.Index].Cells["Reel"].Value.ToString();
                    textSide.Text = dataGridView1.Rows[row.Index].Cells["Side"].Value.ToString();
                    textPer.Text = dataGridView1.Rows[row.Index].Cells["Per"].Value.ToString();
                }
            }
        }

        private void textSide_TextChanged(object sender, EventArgs e)
        {

        }

        private void textQnty_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckListMachine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textSearchPart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {              
                btnConfirm_Click(sender, e);    //clicks 'CONFIRM' automatically
                                                //totalQnty will be incremented too
                textSearchPart.Text = null;

                colourRowCells(dataGridView1);
            }

        }

        private void textSearchPart_TextChanged(object sender, EventArgs e)
        {
            string filterField = "Part No.";
            try
            {
                newDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, textSearchPart.Text);
                //{0} refers to filterField, {1} refers to textSearchPart.Text!!!
                textTable.Text = dataGridView1.SelectedRows[0].Cells["Table No."].Value.ToString();
                textReel.Text = dataGridView1.SelectedRows[0].Cells["Reel"].Value.ToString();
                textSide.Text = dataGridView1.SelectedRows[0].Cells["Side"].Value.ToString();
                textPartNo.Text = dataGridView1.SelectedRows[0].Cells["Part No."].Value.ToString();
                textTable.Text = dataGridView1.SelectedRows[0].Cells["Per"].Value.ToString();

            }
            catch (Exception ex)
            {
                //typing on the search textbox is dynamic
                //searches as you type
                MessageBox.Show("找不到！");
            }
        }

        string filePath = string.Empty;
        string fileExt = string.Empty;
        private void btnChooseFile_Click(object sender, EventArgs e) 
        {

            //string filePath = string.Empty;
            //string fileExt = string.Empty;

            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file chosen by the user  
            {
                filePath = file.FileName; //get the path of the file  
                fileExt = Path.GetExtension(filePath); //get the file extension as String  
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = new DataTable();

                        dtExcel = ReadExcel(filePath, fileExt); //read excel file  

                        dataGridView1.Visible = true;  //make the datatable invisible first
                        //dataGridView1.Visible = true; //TAKE NOTE: don't show the data yet, requires mapping

                        dataGridView1.DataSource = dtExcel; //SHOW THE DATA CELLS ON dataGridView1            

                        newDataTable = filterCells(dataGridView1);  //filtered out unneccessary cells
                                                                    //mapping cells to (DataTable)newDataTable
    
                        //************DOESNT WORK
                        if (newDataTable == null)
                        {
                            throw new NullReferenceException();
                        }  
                                          

                        dataGridView1.DataSource = newDataTable;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.Visible = true;
                        dataGridView1 = colourRowCells(dataGridView1);
                        label3.Text = "Quantity Check: " + numChecked + " / " + totalQnty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    //MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error 
                    MessageBox.Show("只能选 .xls 或 .xlsx 的文件", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error 

                }
            }
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
            //MessageBox.Show("There are "+x+" columns");

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                for (int i = 0; i < x; i++)
                {
                    if (row.Cells[i].Value == null)
                        continue;

                    if (row.Cells[i].Value.ToString().Contains("TABLE") && row.Cells[i].Value.ToString().Contains("HEAD"))
                    {
                        string tablenum = row.Cells[i].Value.ToString();
                        PartClass newPart = new PartClass();

                        int nextRow = row.Index + 1;
                        int nRow = row.Index;

                        while (!String.IsNullOrWhiteSpace(dtgv.Rows[nextRow].Cells[1].Value.ToString())
                            && !dtgv.Rows[nextRow].Cells[0].Value.ToString().StartsWith("T")
                            && !dtgv.Rows[nextRow].Cells[0].Value.ToString().StartsWith("P"))
                        //this is to ignore the next row that contains TABLE or is empty                    
                        {
                            nRow += 1;

                            newPart._table = tablenum;
                            newPart._reel = dtgv.Rows[nextRow].Cells[0].Value.ToString();
                            newPart._side = dtgv.Rows[nextRow].Cells[1].Value.ToString();
                            newPart._partno = dtgv.Rows[nextRow].Cells[2].Value.ToString();
                            newPart._per = dtgv.Rows[nextRow].Cells[4].Value.ToString();              
                            newPart.check = "-";

                            totalQnty++;

                            //******************
                            string[] tempRow = new string[] { newPart._table, newPart._reel, newPart._side, newPart._partno, newPart._per, newPart.check.ToString() };
                            newDataGridView.Rows.Add(tempRow);
                            //******************

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

        //display on textboxes as you click on the cells
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.LightYellow;

            textTable.Text = dataGridView1.SelectedRows[0].Cells["Table No."].Value.ToString();
            textReel.Text = dataGridView1.SelectedRows[0].Cells["Reel"].Value.ToString();
            textSide.Text = dataGridView1.SelectedRows[0].Cells["Side"].Value.ToString();
            textPartNo.Text = dataGridView1.SelectedRows[0].Cells["Part No."].Value.ToString();
            textPer.Text = dataGridView1.SelectedRows[0].Cells["Per"].Value.ToString();

            colourRowCells(dataGridView1);
        }

        private DataGridView colourRowCells(DataGridView dgvr)
        {
            //different colours for Check=1 and Check=0
            foreach (DataGridViewRow row in dgvr.Rows)
            {
                //if (row.Cells[4].Value.ToString() == "-")
                if (row.Cells["5"].Value.ToString() == "-")
                {
                    dgvr.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else //if "YES"
                    dgvr.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            return dgvr;
        }

        //string[] PartNumScanned = new string[totalQnty]; THIS IS NOT ALLOWED
        //to declare an Array, the size must be declared. 
        //if size is known, use LIST



        //**************
        private String[] collectPartNumYes(String partNo)
        {
            return null;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textPartNo.Text))
            {
                //do nth
            }
            else
            {
                if (PartNumScanned.Contains(textPartNo.Text))
                {
                    //MessageBox.Show(textPartNo.Text + " has already been checked!", "Error");
                    MessageBox.Show(textPartNo.Text + " 已经扫过了!", "Error");
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Part No."].Value.ToString() == textPartNo.Text)
                        {
                            dataGridView1.Rows[row.Index].Cells["Checked?"].Value = "Yes";
                            PartNumScanned.Add(textPartNo.Text);
                            numChecked++;
                        }
                    }
                    dataGridView1 = colourRowCells(dataGridView1);
                    label3.Text = "Quantity Check: " + numChecked + " / " + totalQnty;

                    dataGridView1.Sort(dataGridView1.Columns["Checked?"], ListSortDirection.Descending);
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }

            }
        }


        public DataTable ReadExcel(string fileName, string fileExt) //read in Excel cells and store content into a temp Database (dtexcel)
        {
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
        private void btnUploadFile_Click(object sender, EventArgs e)
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
            foreach (string filename in Directory.GetFiles(path))
            {              
                //listofModels.Add("[00"+x+"] "+Path.GetFileNameWithoutExtension(filename));
                listofModels.Add(Path.GetFileNameWithoutExtension(filename));

            }
            textModelNo.AutoCompleteCustomSource = listofModels;
            textModelNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            textModelNo.AutoCompleteSource = AutoCompleteSource.CustomSource;           
        }


        private void btnSearchModel_Click(object sender, EventArgs e)
        {
            string fileDirectory = string.Empty; //path of the file found with the Model No. name

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

                    dataGridView1.Visible = false;
                    //dataGridView1.Visible = true;  //make the datatable invisible first
                                                   //dataGridView1.Visible = true; //TAKE NOTE: don't show the data yet, requires mapping

                    dataGridView1.DataSource = dtExcel; //SHOW THE DATA CELLS ON dataGridView1            

                    newDataTable = filterCells(dataGridView1);  //filtered out unneccessary cells
                                                                //mapping cells to (DataTable)newDataTable

                    dataGridView1.DataSource = newDataTable;
                    dataGridView1.Visible = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1 = colourRowCells(dataGridView1);
                    //MessageBox.Show("FOUND!", textModelNo.Text);
                    label3.Text = "Quantity Check: " + numChecked + " / " + totalQnty;
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //click and do nth
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            //dummyExcel();
            totalQnty = 0;
            numChecked = 0;
            label3.Text = "Quantity Check: " + numChecked + " / " + totalQnty;
            label3.Refresh();

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
            dummyDataTable = ReadExcel(@"C:\Users\user\Desktop\VENTURE\VentureWindowsForm\dummy.xls", ".xls");
            dataGridView1.DataSource = dummyDataTable; //SHOW THE DATA CELLS ON dataGridView1            

            newDataTable = filterCells(dataGridView1);  //filtered out unneccessary cells
                                                        //mapping cells to (DataTable)newDataTable
            dataGridView1.DataSource = newDataTable;
        }

        //THIS IS A VERY POWERFUL 'DEBUG' BUTTON!!
        //What is does is to upload an .xls file e.g 'T8-E-201950-R-BOT' that works seamlessly
        //with the program
        //and then clear the datagridview, and preserve the format
        //lastly, it automatically uploads the file again that experienced the problem
        private void btnDebugError_Click(object sender, EventArgs e)
        {
            dummyExcel();
            btnClearTable_Click(sender, e);

            DataTable dtExcel = new DataTable();
            dtExcel = ReadExcel(filePath, fileExt);
            dataGridView1.Visible = true;
            dataGridView1.DataSource = dtExcel;
            newDataTable = filterCells(dataGridView1);
            dataGridView1.DataSource = newDataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Visible = true;
            dataGridView1 = colourRowCells(dataGridView1);
            label3.Text = "Quantity Check: " + numChecked + " / " + totalQnty;
            /*
             * For the following codes here, program will RE-UPLOAD the file name again
             * Call ReadExcel + filterCells + btnChooseFile_Click
             */
        }

        private void labelModel_Click(object sender, EventArgs e)
        {
            //do nth when clicked
        }


        private void Export_Click(object sender, EventArgs e)
        {
            ExportClass exportclass = new ExportClass();

            //***************** WEIRD
            //CANNOT call ExportToExcel from ExportClass class
            //this ExportToExcel method is called within this form1 class
            string modelName = Path.GetFileNameWithoutExtension(result_path);

            ExportToExcel(dataGridView1, textModelNo.Text);
        }

        private static void ExportToExcel(DataGridView dtgvExport, string modelNumber)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = modelNumber + "_Result";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dtgvExport.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgvExport.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dtgvExport.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dtgvExport.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    //MessageBox.Show("Export Successful");
                    MessageBox.Show("导出 Excel 文件成功");

                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void textPer_TextChanged(object sender, EventArgs e)
        {

        }
    }        
}
