
public class GridRow
{
    public string[] Columns { get; }

    public GridRow(params string[] columns)
    {
        Columns = columns;
    }
}