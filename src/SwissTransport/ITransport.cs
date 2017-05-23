using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id, DateTime dtDate, DateTime dtTime);
        Connections GetConnections(string fromStation, string toStattion, DateTime dtDate, DateTime dtTime);
    }
}