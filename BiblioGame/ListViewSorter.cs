using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

public class ListViewSorter : IComparer
{
    private int columnIndex;
    private SortOrder sortOrder;

    public ListViewSorter(int columnIndex, SortOrder sortOrder)
    {
        this.columnIndex = columnIndex;
        this.sortOrder = sortOrder;
    }

    public int Compare(object x, object y)
    {
        ListViewItem itemX = x as ListViewItem;
        ListViewItem itemY = y as ListViewItem;

        // Comparer les valeurs des sous-éléments (les colonnes)
        string valueX = itemX.SubItems[columnIndex].Text;
        string valueY = itemY.SubItems[columnIndex].Text;

        int result = String.Compare(valueX, valueY);

        // Inverser le tri si c'est dans l'ordre décroissant
        if (sortOrder == SortOrder.Descending)
        {
            result = -result;
        }

        return result;
    }
}