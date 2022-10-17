namespace Accounting;

public partial class DeviceOrientationService
{
    public partial DeviceOrientation GetOrientation();
}

public enum DeviceOrientation
{
    Undefined,
    Landscape,
    Portrait
}