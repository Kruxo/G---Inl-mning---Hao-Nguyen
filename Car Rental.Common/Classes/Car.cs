﻿using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;


namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    public string RegNo { get; set; }
    public string CarMake { get; set; }
    public int OdoMeter { get; set; }
    public int CostKm { get; set; }
    public VehicleTypes VType { get; set; }
    public int CostDay { get; set; }
    public VehicleStatuses VStatus { get; set; }

    public Car(string regNo, string carMake, int odoMeter, int costKm, VehicleTypes vType, int costDay, VehicleStatuses vStatus)
    {
        RegNo = regNo;
        CarMake = carMake;
        OdoMeter = odoMeter;
        CostKm = costKm;
        VType = vType;
        CostDay = costDay;
        VStatus = vStatus;
    }
}
