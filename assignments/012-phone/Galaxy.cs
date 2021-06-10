using System;
namespace _012_phone
{
  public class Galaxy : Phone, IRingable
  {
    public Galaxy(
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
      Console.WriteLine($"####################\nGalaxy {versionNumber}\nBattery Percentage: {batteryPercentage}\nCarrier: {carrier}\nRing Tone: {ringTone}\n####################\n");
    }
  }
}


