using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

public class ExcelHelper
{

    

    // <summary>
    /// Excel某sheet中内容导入到DataTable中
    /// 区分xsl和xslx分别处理
    /// </summary>
    /// <param name="filePath">Excel文件路径,含文件全名</param>
    /// <param name="sheetName">此Excel中sheet名</param>
    /// <returns></returns>
    public DataTable ExcelSheetImportToDataTable(string filePath, string sheetName)
    {
        if (string.IsNullOrEmpty(sheetName))
        {
            sheetName = "Sheet1";
        }
        IWorkbook hssfworkbook = null;
    DataTable dt = new DataTable();

        if (Path.GetExtension(filePath).ToLower() == ".xls".ToLower())
        {//.xls
            #region .xls文件处理:HSSFWorkbook
            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {

                    hssfworkbook = new HSSFWorkbook(file);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            ISheet sheet = hssfworkbook.GetSheet(sheetName);
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();
            HSSFRow headerRow = (HSSFRow)sheet.GetRow(0);

            //一行最后一个方格的编号 即总的列数
            for (int j = 0; j < (sheet.GetRow(0).LastCellNum); j++)
            {
                //SET EVERY COLUMN NAME
                HSSFCell cell = (HSSFCell)headerRow.GetCell(j);

                dt.Columns.Add(cell.ToString());
            }

            while (rows.MoveNext())
            {
                IRow row = (HSSFRow)rows.Current;
                DataRow dr = dt.NewRow();

                if (row.RowNum == 0) continue;//The firt row is title,no need import

                for (int i = 0; i < row.LastCellNum; i++)
                {
                    if (i >= dt.Columns.Count)//cell count>column count,then break //每条记录的单元格数量不能大于表格栏位数量 20140213
                    {
                        break;
                    }

                    ICell cell = row.GetCell(i);

                    if ((i == 0) && (string.IsNullOrEmpty(cell.ToString()) == true))//每行第一个cell为空,break
                    {
                        break;
                    }

                    if (cell == null)
                    {
                        dr[i] = null;
                    }
                    else
                    {
                        dr[i] = cell.ToString();
                    }
                }

                dt.Rows.Add(dr);
            }
            #endregion
        }
        else
        {//.xlsx
            #region .xlsx文件处理:XSSFWorkbook
            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {

                    hssfworkbook = new XSSFWorkbook(file);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            ISheet sheet = hssfworkbook.GetSheet(sheetName);
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();
            XSSFRow headerRow = (XSSFRow)sheet.GetRow(0);



            //一行最后一个方格的编号 即总的列数
            for (int j = 0; j < (sheet.GetRow(0).LastCellNum); j++)
            {
                //SET EVERY COLUMN NAME
                XSSFCell cell = (XSSFCell)headerRow.GetCell(j);

                dt.Columns.Add(cell.ToString());

            }

            while (rows.MoveNext())
            {
                IRow row = (XSSFRow)rows.Current;
                DataRow dr = dt.NewRow();

                if (row.RowNum == 0) continue;//The firt row is title,no need import

                for (int i = 0; i < row.LastCellNum; i++)
                {
                    if (i >= dt.Columns.Count)//cell count>column count,then break //每条记录的单元格数量不能大于表格栏位数量 20140213
                    {
                        break;
                    }

                    ICell cell = row.GetCell(i);

                    if ((i == 0) && (string.IsNullOrEmpty(cell.ToString()) == true))//每行第一个cell为空,break
                    {
                        break;
                    }

                    if (cell == null)
                    {
                        dr[i] = null;
                    }
                    else
                    {
                        dr[i] = cell.ToString();
                    }
                }
                dt.Rows.Add(dr);
            }
            #endregion
        }
        return dt;
    }
}