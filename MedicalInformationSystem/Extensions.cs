using MedicalCorporation.Core.Models.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MedicalInformationSystem
{
    public static class Extensions
    {
        public static void FillTableWithCollection<T>(this DataGridView dataGridView, IEnumerable<T> collection)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            PropertyInfo[] properties = CreateAndFillColumns();
            CreateAndFillRows();

            PropertyInfo[] CreateAndFillColumns()
            {
                var type = typeof(T);
                var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                var columnInfos = props.Select(prop =>
                {
                    (string PropertyName, string DisplayedName) propInfo =
                    (
                        prop.Name,
                        prop.GetCustomAttributes<DTOPropertyInfoAttribute>().FirstOrDefault()?.DisplayedName ?? prop.Name
                    );
                    return propInfo;
                });

                foreach (var colInfo in columnInfos)
                    dataGridView.Columns.Add(colInfo.PropertyName, colInfo.DisplayedName);

                return props;
            }

            void CreateAndFillRows()
            {
                foreach (var item in collection)
                {
                    if (item == null)
                        continue;

                    var valuesList = new string[properties.Length];
                    for (int i = 0; i < properties.Length; i++)
                        valuesList[i] = properties[i]?.GetValue(item)?.ToString();

                    dataGridView.Rows.Add(valuesList);
                }
            }
        }
    }
}
