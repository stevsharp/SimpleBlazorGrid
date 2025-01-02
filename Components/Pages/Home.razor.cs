

namespace BlazorSimpleGrid.Components.Pages;
public partial class Home
{
    private List<GridRow> Rows { get; set; } = new();
    private List<GridColumn> Columns { get; set; } = new();

    private Grid? MyGrid { get; set; }

    private List<Customer> customers;


    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int OrdersCount { get; set; }
    }

    protected override void OnInitialized()
    {
        customers =
        [
            new Customer { Id = 1, Name = "Amy Mayer_1", DateOfBirth = new DateTime(1960, 2, 22), OrdersCount = 2 },
            new Customer { Id = 2, Name = "Julie Shelton_2", DateOfBirth = new DateTime(2000, 6, 29), OrdersCount = 4 },
            new Customer { Id = 3, Name = "Stephanie Clarke_3", DateOfBirth = new DateTime(2000, 8, 2), OrdersCount = 6 },
            new Customer { Id = 4, Name = "Michael King_4", DateOfBirth = new DateTime(1999, 8, 4), OrdersCount = 10 },
            new Customer { Id = 5, Name = "Michael Hopkins_5", DateOfBirth = new DateTime(1959, 8, 4), OrdersCount = 3 },
            new Customer { Id = 6, Name = "Amy Mayer_6", DateOfBirth = new DateTime(1960, 2, 22), OrdersCount = 2 },
            new Customer { Id = 7, Name = "Julie Shelton_7", DateOfBirth = new DateTime(2000, 6, 29), OrdersCount = 4 },
            new Customer { Id = 8, Name = "Stephanie Clarke_8", DateOfBirth = new DateTime(2000, 8, 2), OrdersCount = 6 },
            new Customer { Id = 9, Name = "Michael King_9", DateOfBirth = new DateTime(1999, 8, 4), OrdersCount = 10 },
            new Customer { Id = 10, Name = "Michael Hopkins_10", DateOfBirth = new DateTime(1959, 8, 4), OrdersCount = 3 },
        ];

        Columns =
        [
            new GridColumn("Nr", 0),
            new GridColumn("Symbol", 1),
            new GridColumn("Name", 2),
            new GridColumn("Position", 3),
            new GridColumn("Molar Mass", 4)
        ];

        Rows =
        [
            new GridRow("1", "H", "Hydrogen", "1", "1.008"),
            new GridRow("2", "He", "Helium", "18", "4.0026"),
            new GridRow("3", "Li", "Lithium", "1", "6.94"),
            new GridRow("4", "Be", "Beryllium", "2", "9.0122"),
            new GridRow("5", "B", "Boron", "13", "10.81"),
            new GridRow("6", "C", "Carbon", "14", "12.011"),
            new GridRow("7", "N", "Nitrogen", "15", "14.007"),
            new GridRow("8", "O", "Oxygen", "16", "15.999"),
            new GridRow("9", "F", "Fluorine", "17", "18.998"),
            new GridRow("10", "Ne", "Neon", "18", "20.180"),
            new GridRow("11", "Na", "Sodium", "1", "22.990"),
            new GridRow("12", "Mg", "Magnesium", "2", "24.305"),
            new GridRow("13", "Al", "Aluminium", "13", "26.982"),
            new GridRow("14", "Si", "Silicon", "14", "28.085"),
            new GridRow("15", "P", "Phosphorus", "15", "30.974"),
            new GridRow("16", "S", "Sulfur", "16", "32.06"),
            new GridRow("17", "Cl", "Chlorine", "17", "35.45"),
            new GridRow("18", "Ar", "Argon", "18", "39.948"),
            new GridRow("19", "K", "Potassium", "1", "39.098"),
            new GridRow("20", "Ca", "Calcium", "2", "40.078"),
            new GridRow("21", "Sc", "Scandium", "3", "44.956"),
            new GridRow("22", "Ti", "Titanium", "4", "47.867"),
            new GridRow("23", "V", "Vanadium", "5", "50.941"),
            new GridRow("24", "Cr", "Chromium", "6", "51.996"),
            new GridRow("25", "Mn", "Manganese", "7", "54.938"),
            new GridRow("26", "Fe", "Iron", "8", "55.845"),
            new GridRow("27", "Co", "Cobalt", "9", "58.933"),
            new GridRow("28", "Ni", "Nickel", "10", "58.693"),
            new GridRow("29", "Cu", "Copper", "11", "63.546"),
            new GridRow("30", "Zn", "Zinc", "12", "65.38"),
            new GridRow("31", "Ga", "Gallium", "13", "69.723"),
            new GridRow("32", "Ge", "Germanium", "14", "72.63"),
            new GridRow("33", "As", "Arsenic", "15", "74.922"),
            new GridRow("34", "Se", "Selenium", "16", "78.96"),
            new GridRow("35", "Br", "Bromine", "17", "79.904"),
            new GridRow("36", "Kr", "Krypton", "18", "83.798")
        ];

        MyGrid = new Grid
        {
            Rows= Rows
        };
    }
}
