using System;
namespace _012_phone
{
  public class Nokia : Phone, IRingable
  {
    public Nokia(
      string versionNumber,
      int batteryPercentage,
      string carrier,
      string ringTone)
        : base(
          versionNumber,
          batteryPercentage,
          carrier,
          ringTone)
    { }
    public override void DisplayInfo()
    {
      Console.WriteLine($"$$$$$$$$$$$$$$$$$$$\nNokia {versionNumber}\nBattery Percentage: {batteryPercentage}\nCarrier: {carrier}\nRing Tone: {ringTone}\n$$$$$$$$$$$$$$$$$$$\n");
    }
  }
}

