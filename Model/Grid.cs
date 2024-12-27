
public class Grid
{
    public List<GridRow> Rows { get; private set; } = new();
    public Func<GridRow, bool>? Filter { get; set; }
    public Func<GridRow, object>? SortBy { get; set; }
    public bool IsSortDescending { get; set; }

    public IEnumerable<GridRow> GetFilteredAndSortedRows()
    {
        var query = Rows.AsEnumerable();

        if (Filter != null)
        {
            query = query.Where(Filter);
        }

        if (SortBy != null)
        {
            query = IsSortDescending
                ? query.OrderByDescending(SortBy)
                : query.OrderBy(SortBy);
        }

        return query;
    }

    public void Add(GridRow row)
    {
        Rows.Add(row);
    }
}