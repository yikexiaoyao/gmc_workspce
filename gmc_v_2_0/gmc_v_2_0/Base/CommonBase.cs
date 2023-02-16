using System.Data;
using System.Windows.Controls;

namespace gmc_v_2_0.Base
{
    public class CommonBase
    {
        public DataTable DataGridToTable(DataGrid dg)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < dg.Items.Count; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    dr[dg.Columns[j].Header.ToString()] =
                        (dg.Columns[j].GetCellContent(dg.Items[i]) as TextBlock).Text;
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}