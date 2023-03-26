// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System.Diagnostics.Contracts;
using System.Security.AccessControl;

Console.WriteLine("Hello, World!");
using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title.Length < 100);
        Contract.Requires(title != null);
        this.title = title;
        var random = new Random();
        this.id = random.Next(10000, 99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Contract.Requires(playCount <= 10000000);
        try
        {
            int check = checked(this.playCount + playCount);
            this.playCouunt = check;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow Exception: " + enum.Message);
        }
    }
    
    public void printVideoDeetails()
    {
    Console.WriteLine("id: {0:d}\nTitle: {1:s}\nplayCount: {2:d}", id, title, playCount);
    }
}