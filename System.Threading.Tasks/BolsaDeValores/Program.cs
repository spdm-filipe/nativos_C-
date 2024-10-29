
Console.WriteLine("---");
var stock = new  StockMonitor("filipe");
var stock2 = new  StockMonitor("augusto");
stock.StartMonitoring();
stock2.StartMonitoring();
await Task.Delay(5000);
stock.StopMonitoring();
stock2.StopMonitoring();
public class StockMonitor
{
    private readonly string stockSymbol;
    private bool stopMonitoring;

    public StockMonitor(string symbol)
    {
        stockSymbol = symbol;
    }

    public void StartMonitoring()
    {
        stopMonitoring = false;
        Thread monitoringThread = new Thread(MonitorStock);
        monitoringThread.Start();
    }

    public void StopMonitoring()
    {
        stopMonitoring = true;
    }

    private void MonitorStock()
    {
        while (!stopMonitoring)
        {
            // Simulate retrieving live stock data
            decimal stockPrice = GetStockPrice(stockSymbol);
            Console.WriteLine($"{stockSymbol}: {stockPrice}");
            Thread.Sleep(1000); // Wait for 1 second before the next update
        }
    }

    private decimal GetStockPrice(string symbol)
    {
        // Simulate getting live stock price
        return new Random().Next(100, 500);
    }
}

