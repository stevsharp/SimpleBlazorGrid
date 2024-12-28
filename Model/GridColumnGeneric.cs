
using System.Linq.Expressions;
public class GridColumn<T>
{
    public string Title { get; set; }
    public Expression<Func<T, object>> Property { get; set; }

    public GridColumn(string title, Expression<Func<T, object>> property)
    {
        Title = title;
        Property = property;
    }

    public Func<T, object> GetCompiledProperty()
    {
        return Property.Compile();
    }
}