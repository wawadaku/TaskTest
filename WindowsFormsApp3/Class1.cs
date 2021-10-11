using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp3
{
	public class Class1
    {
		public List<string> m_suckVulumesListDF = new List<string>();

		public List<string> m_divisionListDF = new List<string>();
		public void ReadFromExcelFileDF(string filePath)
		{
			IWorkbook iWorkBook = null;
			string sExtension = Path.GetExtension(filePath);
			try
			{
				FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				iWorkBook = ((!sExtension.Equals(".xls")) ? ((IWorkbook)new XSSFWorkbook((Stream)fs)) : ((IWorkbook)new HSSFWorkbook(fs)));
				fs.Close();
				ISheet iSheet = iWorkBook.GetSheetAt(0);
				IRow iRow = null;
				bool bSuckVulumes = false;
				bool bDivision = false;
				m_suckVulumesListDF.Clear();
				m_divisionListDF.Clear();
				for (int i = 0; i <= iSheet.LastRowNum; i++)
				{
					iRow = iSheet.GetRow(i);
					if (iRow == null)
					{
						continue;
					}
					List<string> rowData = new List<string>();
					for (int l = 0; l < iRow.LastCellNum; l++)
					{
						ICell iCell = iRow.GetCell(l);
						if (iCell != null)
						{
							string sValue = iCell.ToString().Trim();
							if (iCell.ToString().Trim().Length == 0)
							{
								break;
							}
							if (string.Equals("[SUCK_VOLUMES]", sValue, StringComparison.OrdinalIgnoreCase))
							{
								bSuckVulumes = true;
								bDivision = false;
								break;
							}
							if (string.Equals("[DIVISION]", sValue, StringComparison.OrdinalIgnoreCase))
							{
								bSuckVulumes = false;
								bDivision = true;
								break;
							}
							rowData.Add(sValue);
						}
					}
					if (rowData.Count <= 0)
					{
						continue;
					}
					if (bSuckVulumes && !bDivision)
					{
						for (int k = 0; k < rowData.Count; k++)
						{
							if (IsNumberic(rowData[k]))
							{
								m_suckVulumesListDF.Add(rowData[k]);
							}
						}
					}
					if (!(!bSuckVulumes && bDivision))
					{
						continue;
					}
					for (int j = 0; j < rowData.Count; j++)
					{
						if (IsNumberic(rowData[j]))
						{
							m_divisionListDF.Add(rowData[j]);
						}
					}
					if (rowData[0].Equals("H", StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
				}
				//LogHelper.Log_Remark("读取数据文件[SUCK_VOLUMES]数据为:");
				string writeData = "";
				for (int index2 = 0; index2 < m_suckVulumesListDF.Count; index2++)
				{
					writeData = writeData + m_suckVulumesListDF[index2] + " ";
					if (index2 != 0 && (index2 + 1) % 12 == 0)
					{
						//LogHelper.Log_Remark("{0}", writeData);
						writeData = "";
					}
				}
				writeData = "";
				//LogHelper.Log_Remark("读取数据文件[DIVISION]数据为:");
				for (int index = 0; index < m_divisionListDF.Count; index++)
				{
					writeData = writeData + m_divisionListDF[index] + " ";
					if (index != 0 && (index + 1) % 12 == 0)
					{
						//LogHelper.Log_Remark("{0}", writeData);
						writeData = "";
					}
				}
			}
			catch (Exception)
			{
			}
		}
		private bool IsNumberic(string strText)
		{
			double result = 0.0;
			try
			{
				result = double.Parse(strText);
			}
			catch
			{
				return false;
			}
			return true;
		}
	}
}
