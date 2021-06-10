namespace _012_phone
{
  public abstract class Phone
  {
    private string VersionNumber;
    private int BatteryPercentage;
    private string Carrier;
    private string RingTone;

    public string versionNumber
    {
      get { return VersionNumber; }
    }
    public int batteryPercentage
    {
      get { return BatteryPercentage; }
    }
    public string carrier
    {
      get { return Carrier; }
    }
    public string ringTone
    {
      get { return RingTone; }
    }
    public string Ring()
    {
      return ringTone;
    }
    public string Unlock()
    {
      return $"{versionNumber} unlocked with passcode.";
    }
    public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
    {
      VersionNumber = versionNumber;
      BatteryPercentage = batteryPercentage;
      Carrier = carrier;
      RingTone = ringTone;
    }
    public abstract void DisplayInfo();

  }
}

