using System.Collections.Generic;


namespace CSharp.Tricks.OfficeExcel
{
  public class OfficeExcelDemo
  {

    public static void Run()
    {
      // Create a list of accounts.
      var bankAccounts = new List<Account> 
            {
                new Account { 
                              ID = 345678,
                              Balance = 541.27
                            },
                new Account {
                              ID = 1230221,
                              Balance = -127.44
                            }
            };

      // Display the list in an Excel spreadsheet.
      DisplayInExcel(bankAccounts);

    }

    static void DisplayInExcel(IEnumerable<Account> accounts)
    {
    /*  var excelApp = new Excel.Application();
      // Make the object visible.
     //excelApp.Visible = true;

      // Create a new, empty workbook and add it to the collection returned 
      // by property Workbooks. The new workbook becomes the active workbook.
      // Add has an optional parameter for specifying a praticular template. 
      // Because no argument is sent in this example, Add creates a new workbook. 
      excelApp.Workbooks.Add();

      // This example uses a single workSheet. 
      Excel._Worksheet workSheet = excelApp.ActiveSheet;

      // Earlier versions of C# require explicit casting.
      //Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

      // Establish column headings in cells A1 and B1.
      workSheet.Cells[1, "A"] = "ID Number";
      workSheet.Cells[1, "B"] = "Current Balance";

      var row = 1;
      foreach (var acct in accounts)
      {
        row++;
        workSheet.Cells[row, "A"] = acct.ID;
        workSheet.Cells[row, "B"] = acct.Balance;
      }

      workSheet.Columns[1].AutoFit();
      workSheet.Columns[2].AutoFit();

      // Call to AutoFormat in Visual C# 2010. This statement replaces the 
      // two calls to AutoFit.
      workSheet.Range["A1", "B3"].AutoFormat(
          Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);

      // Put the spreadsheet contents on the clipboard. The Copy method has one
      // optional parameter for specifying a destination. Because no argument  
      // is sent, the destination is the Clipboard.
      workSheet.Range["A1:B3"].Copy();
      */
      //excelApp.ActiveWorkbook.SaveAs(@"M:\Book1.xlsx");
    }
  }

  public class Account
  {
    public int ID { get; set; }
    public double Balance { get; set; }
  }
}
