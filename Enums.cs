namespace Lab02.Data.Entities;

public enum LocationType
{
    River,
    Forest
}

public enum PointPurpose
{
    Sensor,
    Sampling,
    CameraTrap
}

public enum InstrumentType
{
    Multiparameter,
    SoilSensor,
    Logger,
    CameraTrap,
    Thermohygrometer
}

public enum InstrumentStatus
{
    Active,
    InRepair,
    Retired
}

public enum ParticipantRole
{
    Researcher,
    Student,
    Volunteer
}

public enum MeasurementStatus
{
    Valid,
    Suspicious
}