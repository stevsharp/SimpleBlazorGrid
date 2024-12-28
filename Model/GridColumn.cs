
public class GridColumn
{
    public string Title { get; set; }
    public int ColumnIndex { get; set; }

    public GridColumn(string title, int columnIndex)
    {
        Title = title;
        ColumnIndex = columnIndex;
    }
}
