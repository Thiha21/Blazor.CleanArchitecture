using MudBlazor;

namespace Blazor.CleanArchitecture.Web.Pages.Dashboard
{
    public partial class Index
    {
        private int _lineChartIndex = -1; //default value cannot be 0 -> first selectedindex is 0.
        private int _donutChartIndex = -1; //default value cannot be 0 -> first selectedindex is 0.

        public List<ChartSeries> Series = new List<ChartSeries>()
        {
            new ChartSeries() { Name = "United States", Data = new double[] { 40, 20, 25, 27, 46, 60, 48, 80, 15 } },
            new ChartSeries() { Name = "Germany", Data = new double[] { 19, 24, 35, 13, 28, 15, 13, 16, 31 } },
            new ChartSeries() { Name = "Sweden", Data = new double[] { 8, 6, 11, 13, 4, 16, 10, 16, 18 } },
        };
        public string[] XAxisLabels = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" };

        int dataSize = 4;
        public double[] data = { 50, 25, 20, 5 };
        public string[] labels = { "Fossil", "Nuclear", "Solar", "Wind", "Oil", "Coal", "Gas", "Biomass",
                                "Hydro", "Geothermal", "Nuclear Fusion", "Pumped Storage", "Solar", "Wind", "Oil",
                                "Coal", "Gas", "Biomass", "Hydro", "Geothermal" };

        Random random = new Random();

        void RandomizeData()
        {
            var new_data = new double[dataSize];
            for (int i = 0; i < new_data.Length; i++)
                new_data[i] = random.NextDouble() * 100;
            data = new_data;
            StateHasChanged();
        }

        void AddDataSize()
        {
            if (dataSize < 20)
            {
                dataSize = dataSize + 1;
                RandomizeData();
            }
        }
        void RemoveDataSize()
        {
            if (dataSize > 0)
            {
                dataSize = dataSize - 1;
                RandomizeData();
            }
        }
    }
}
