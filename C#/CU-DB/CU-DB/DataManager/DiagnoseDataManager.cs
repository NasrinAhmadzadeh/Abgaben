using CU_DB.DataTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CU_DB.DataManager
{
    public class DiagnoseDataManager
    {
        string conStr= System.Configuration.ConfigurationManager.ConnectionStrings["DiagnoseDB"].ConnectionString;
        /// <summary>
        /// Insert Daten in DB
        /// </summary>
        /// <param name="filepath"></param>
        public void InsertDataToDb(List<Diagnose> diagnossesList)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                        "INSERT INTO dbo.Log (StressLevel," +
                        "ID," +
                        "SessionName," +
                        "[User]," +
                        "CitrixReceiverVersion," +
                        "State," +
                        "ConnectTime," +
                        "DisconnectTime," +
                        "IdleTime," +
                        "IdleTimeMin," +
                        "LogonTime," +
                        "Processes," +
                        "LatencyLast," +
                        "BandwidthLast," +
                        "RTT," +
                        "BandwidthAvg," +
                        "BandwidthLimit," +
                        "LatencyAvg," +
                        "ClientIP," +
                        "BranchName," +
                        "ClientName," +
                        "Computer," +
                        "DomainDNS," +
                        "InitialProgram," +
                        "CPU," +
                        "PageFaultsSec," +
                        "IOReadOperationsSec," +
                        "IOWriteOperationSec," +
                        "MemoryPrivateBytes," +
                        "MemoryWorkingSet," +
                        "ViewClientConnectionServerURL," +
                        "ViewClientDomain," +
                        "ViewClientProtocol," +
                        "ViewClientType," +
                        "ViewClientTunnel," +
                        "UserLogonServer," +
                        "GroupPolicyLoadTime," +
                        "ProfileLoadTime," +
                        "logonDurationOther," +
                        "DesktopLoadTime," +
                        "LogonDuration," +
                        "SessionCreateTime," +
                        "UserADDN," +
                        "UserADOU," +
                        "UserFullName," +
                        "AvgAppLoadTime," +
                        "GPUCPUUtilization," +
                        "GPUFrameBufferMemoryUtilization," +
                        "GPUencoderUtilization," +
                        "GPUdecoderUtilization," +
                        "XDSiteName," +
                        "XDSessionCreateTime," +
                        "XDLogonDuration," +
                        "XDPublishedResourceType," +
                        "XDAnonymous," +
                        "XDConnectedViaHostName," +
                        "XDConnectedViaIPAddress," +
                        "XDLaunchedViaHostName," +
                        "XDLaunchedViaIPAddress," +
                        "XDSessionReconnected," +
                        "XDSecureICASession," +
                        "Protocol," +
                        "XDBrokeringDuration," +
                        "XDBrokeringDate," +
                        "XDVMStartDuration," +
                        "XDClientSessionValidateDate," +
                        "XDServerSessionValidateDate," +
                        "XDEstablishmentDate," +
                        "XDHDXConnectionLoadTime," +
                        "XDAuthenticationDuration," +
                        "XDGroupPolicyLoadTime," +
                        "XDLogonScriptsLoadTime," +
                        "XDProfileLoadTime," +
                        "XDInteractiveSessionLoadTime," +
                        "XDUPN," +
                        "XDAppsInUse," +
                        "XDAppsInUseCount," +
                        "XDDisconnectReason," +
                        "XDDisconnectDate," +
                        "XDDeliveryGroup) " +

                        " VALUES (@StressLevel," +
                        "@ID," +
                        "@SessionName," +
                        "@User," +
                        "@CitrixReceiverVersion," +
                        "@State," +
                        "@ConnectTime," +
                        "@DisconnectTime," +
                        "@IdleTime," +
                        "@IdleTimeMin," +
                        "@LogonTime," +
                        "@Processes," +
                        "@LatencyLast," +
                        "@BandwidthLast," +
                        "@RTT," +
                        "@BandwidthAvg," +
                        "@BandwidthLimit," +
                        "@LatencyAvg," +
                        "@ClientIP," +
                        "@BranchName," +
                        "@ClientName," +
                        "@Computer," +
                        "@DomainDNS," +
                        "@InitialProgram," +
                        "@CPU," +
                        "@PageFaultsSec," +
                        "@IOReadOperationsSec," +
                        "@IOWriteOperationSec," +
                        "@MemoryPrivateBytes," +
                        "@MemoryWorkingSet," +
                        "@ViewClientConnectionServerURL," +
                        "@ViewClientDomain," +
                        "@ViewClientProtocol," +
                        "@ViewClientType," +
                        "@ViewClientTunnel," +
                        "@UserLogenServer," +
                        "@GroupPolicyLoadTime," +
                        "@ProfileLoadTime," +
                        "@logonDurationOther," +
                        "@DesktopLoadTime," +
                        "@LogonDuration," +
                        "@SessionCreateTime," +
                        "@UserADDN," +
                        "@UserADOU," +
                        "@UserFullName," +
                        "@AvgAppLoadTime," +
                        "@GPUCPUUtilization," +
                        "@GPUFrameBufferMemryUtilization," +
                        "@GPUencoderUtilization," +
                        "@GPUdecoderUtilization," +
                        "@XDSiteName," +
                        "@XDSessionCreateTime," +
                        "@XDLogonDuration," +
                        "@XDPublishedResourceType," +
                        "@XDAnonymous," +
                        "@XDConnectedViaHostName," +
                        "@XDConnectedViaIPAddress," +
                        "@XDLaunchedViaHostName," +
                        "@XDLaunchedViaIPAddress," +
                        "@XDSessionReconnected," +
                        "@XDSecureICASession," +
                        "@Protocol," +
                        "@XDBrokeringDuration," +
                        "@XDBrokeringDate," +
                        "@XDVMStartDuration," +
                        "@XDClientSessionValidateDate," +
                        "@XDServerSessionValidateDate," +
                        "@XDEstablishmentDate," +
                        "@XDHDXConnectionLoadTime," +
                        "@XDAuthenticationDuration," +
                        "@XDGroupPolicyLoadTime," +
                        "@XDLogonScriptsLoadTime," +
                        "@XDProfileLoadTime," +
                        "@XDInteractiveSessionLoadTime," +
                        "@XDUPN," +
                        "@XDAppsInUse," +
                        "@XDAppsInUseCount," +
                        "@XDDisconnectReason," +
                        "@XDDisconnectDate," +
                        "@XDDeliveryGroup)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@StressLevel", DbType.Decimal);
                cmd.Parameters.Add("@ID", DbType.Decimal);
                cmd.Parameters.Add("@SessionName", DbType.String);
                cmd.Parameters.Add("@User", DbType.String);
                cmd.Parameters.Add("@CitrixReceiverVersion", DbType.String);
                cmd.Parameters.Add("@State", DbType.String);
                cmd.Parameters.Add("@ConnectTime", DbType.DateTime);
                cmd.Parameters.Add("@DisconnectTime", DbType.DateTime);
                cmd.Parameters.Add("@IdleTime", SqlDbType.BigInt);
                cmd.Parameters.Add("@IdleTimeMin", SqlDbType.Decimal);
                cmd.Parameters.Add("@LogonTime", SqlDbType.DateTime);
                cmd.Parameters.Add("@Processes", DbType.Double);
                cmd.Parameters.Add("@LatencyLast", DbType.Double);
                cmd.Parameters.Add("@BandwidthLast", DbType.Double);
                cmd.Parameters.Add("@RTT", DbType.Double);
                cmd.Parameters.Add("@BandwidthAvg", DbType.Double);
                cmd.Parameters.Add("@BandwidthLimit", DbType.Double);
                cmd.Parameters.Add("@LatencyAvg", DbType.Double);
                cmd.Parameters.Add("@ClientIP", DbType.Double);
                cmd.Parameters.Add("@BranchName", DbType.String);
                cmd.Parameters.Add("@ClientName", DbType.String);
                cmd.Parameters.Add("@Computer", DbType.String);
                cmd.Parameters.Add("@DomainDNS", DbType.String);
                cmd.Parameters.Add("@InitialProgram", DbType.String);
                cmd.Parameters.Add("@CPU", DbType.String);
                cmd.Parameters.Add("@PageFaultsSec", DbType.Double);
                cmd.Parameters.Add("@IOReadOperationsSec", DbType.Double);
                cmd.Parameters.Add("@IOWriteOperationSec", DbType.Double);
                cmd.Parameters.Add("@MemoryPrivateBytes", DbType.Double);
                cmd.Parameters.Add("@MemoryWorkingSet", DbType.String);
                cmd.Parameters.Add("@ViewClientConnectionServerURL", DbType.String);
                cmd.Parameters.Add("@ViewClientDomain", DbType.String);
                cmd.Parameters.Add("@ViewClientProtocol", DbType.String);
                cmd.Parameters.Add("@ViewClientType", DbType.String);
                cmd.Parameters.Add("@ViewClientTunnel", DbType.String);
                cmd.Parameters.Add("@UserLogenServer", DbType.String);
                cmd.Parameters.Add("@GroupPolicyLoadTime", DbType.String);
                cmd.Parameters.Add("@ProfileLoadTime", DbType.Double);
                cmd.Parameters.Add("@logonDurationOther", DbType.Double);
                cmd.Parameters.Add("@DesktopLoadTime", DbType.Double);
                cmd.Parameters.Add("@LogonDuration", DbType.Double);
                cmd.Parameters.Add("@SessionCreateTime", DbType.DateTime);
                cmd.Parameters.Add("@UserADDN", DbType.String);
                cmd.Parameters.Add("@UserADOU", DbType.String);
                cmd.Parameters.Add("@UserFullName", DbType.String);
                cmd.Parameters.Add("@AvgAppLoadTime", DbType.Double);
                cmd.Parameters.Add("@GPUCPUUtilization", DbType.String);
                cmd.Parameters.Add("@GPUFrameBufferMemryUtilization", DbType.Double);
                cmd.Parameters.Add("@GPUencoderUtilization", DbType.Double);
                cmd.Parameters.Add("@GPUdecoderUtilization", DbType.Double);
                cmd.Parameters.Add("@XDSiteName", DbType.Double);
                cmd.Parameters.Add("@XDSessionCreateTime", DbType.Double);
                cmd.Parameters.Add("@XDLogonDuration", DbType.String);
                cmd.Parameters.Add("@XDPublishedResourceType", DbType.String);
                cmd.Parameters.Add("@XDAnonymous", DbType.String);
                cmd.Parameters.Add("@XDConnectedViaHostName", DbType.String);
                cmd.Parameters.Add("@XDConnectedViaIPAddress", DbType.String);
                cmd.Parameters.Add("@XDLaunchedViaHostName", DbType.String);
                cmd.Parameters.Add("@XDLaunchedViaIPAddress", DbType.String);
                cmd.Parameters.Add("@XDSessionReconnected", DbType.String);
                cmd.Parameters.Add("@XDSecureICASession", DbType.String);
                cmd.Parameters.Add("@Protocol", DbType.String);
                cmd.Parameters.Add("@XDBrokeringDuration", DbType.String);
                cmd.Parameters.Add("@XDBrokeringDate", DbType.String);
                cmd.Parameters.Add("@XDVMStartDuration", DbType.String);
                cmd.Parameters.Add("@XDClientSessionValidateDate", DbType.String);
                cmd.Parameters.Add("@XDServerSessionValidateDate", DbType.String);
                cmd.Parameters.Add("@XDEstablishmentDate", DbType.String);
                cmd.Parameters.Add("@XDHDXConnectionLoadTime", DbType.String);
                cmd.Parameters.Add("@XDAuthenticationDuration", DbType.String);
                cmd.Parameters.Add("@XDGroupPolicyLoadTime", DbType.String);
                cmd.Parameters.Add("@XDLogonScriptsLoadTime", DbType.String);
                cmd.Parameters.Add("@XDProfileLoadTime", DbType.String);
                cmd.Parameters.Add("@XDInteractiveSessionLoadTime", DbType.String);
                cmd.Parameters.Add("@XDUPN", DbType.String);
                cmd.Parameters.Add("@XDAppsInUse", DbType.String);
                cmd.Parameters.Add("@XDAppsInUseCount", DbType.String);
                cmd.Parameters.Add("@XDDisconnectReason", DbType.String);
                cmd.Parameters.Add("@XDDisconnectDate", DbType.String);
                cmd.Parameters.Add("@XDDeliveryGroup", DbType.String);

                foreach (var diagnose in diagnossesList)
                {
                    cmd.Parameters[0].Value = diagnose.StressLevel.HasValue ? diagnose.StressLevel.Value : (object)DBNull.Value;
                    cmd.Parameters[1].Value = diagnose.ID.HasValue ? diagnose.ID.Value : (object)DBNull.Value;
                    cmd.Parameters[2].Value = diagnose.SessionName;
                    cmd.Parameters[3].Value = diagnose.User;
                    cmd.Parameters[4].Value = diagnose.CitrixReceiverVersion;
                    cmd.Parameters[5].Value = diagnose.State;
                    cmd.Parameters[6].Value = diagnose.ConnectTime.HasValue ? diagnose.ConnectTime.Value : (object)DBNull.Value;
                    cmd.Parameters[7].Value = diagnose.DisconnectTime.HasValue ? diagnose.DisconnectTime.Value : (object)DBNull.Value;
                    cmd.Parameters[8].Value = diagnose.IdleTime.HasValue ? diagnose.IdleTime.Value : (object)DBNull.Value;
                    cmd.Parameters[9].Value = diagnose.IdleTimeMin.HasValue ? diagnose.IdleTimeMin.Value : (object)DBNull.Value;
                    cmd.Parameters[10].Value = diagnose.LogonTime.HasValue ? diagnose.LogonTime.Value : (object)DBNull.Value;
                    cmd.Parameters[11].Value = diagnose.Processes.HasValue ? diagnose.Processes.Value : (object)DBNull.Value;
                    cmd.Parameters[12].Value = diagnose.LatencyLast.HasValue ? diagnose.LatencyLast.Value : (object)DBNull.Value;
                    cmd.Parameters[13].Value = diagnose.BandwidthLast.HasValue ? diagnose.BandwidthLast.Value : (object)DBNull.Value;
                    cmd.Parameters[14].Value = diagnose.RTT.HasValue ? diagnose.RTT.Value : (object)DBNull.Value;
                    cmd.Parameters[15].Value = diagnose.BandwidthAvg.HasValue ? diagnose.BandwidthAvg.Value : (object)DBNull.Value;
                    cmd.Parameters[16].Value = diagnose.BandwidthLimit.HasValue ? diagnose.BandwidthLimit.Value : (object)DBNull.Value;
                    cmd.Parameters[17].Value = diagnose.LatencyAvg.HasValue ? diagnose.LatencyAvg.Value : (object)DBNull.Value;
                    cmd.Parameters[18].Value = diagnose.ClientIP.HasValue ? diagnose.ClientIP.Value : (object)DBNull.Value;
                    cmd.Parameters[19].Value = diagnose.BranchName;
                    cmd.Parameters[20].Value = diagnose.ClientName;
                    cmd.Parameters[21].Value = diagnose.Computer;
                    cmd.Parameters[22].Value = diagnose.DomainDNS;
                    cmd.Parameters[23].Value = diagnose.InitialProgram;
                    cmd.Parameters[24].Value = diagnose.CPU;
                    cmd.Parameters[25].Value = diagnose.PageFaultsSec.HasValue ? diagnose.PageFaultsSec.Value : (object)DBNull.Value;
                    cmd.Parameters[26].Value = diagnose.IOReadOperationsSec.HasValue ? diagnose.IOReadOperationsSec.Value : (object)DBNull.Value;
                    cmd.Parameters[27].Value = diagnose.IOWriteOperationSec.HasValue ? diagnose.IOWriteOperationSec.Value : (object)DBNull.Value;
                    cmd.Parameters[28].Value = diagnose.MemoryPrivateBytes.HasValue ? diagnose.MemoryPrivateBytes.Value : (object)DBNull.Value;
                    cmd.Parameters[29].Value = diagnose.MemoryWorkingSet;
                    cmd.Parameters[30].Value = diagnose.ViewClientConnectionServerURL;
                    cmd.Parameters[31].Value = diagnose.ViewClientDomain;
                    cmd.Parameters[32].Value = diagnose.ViewClientProtocol;
                    cmd.Parameters[33].Value = diagnose.ViewClientType;
                    cmd.Parameters[34].Value = diagnose.ViewClientTunnel;
                    cmd.Parameters[35].Value = diagnose.UserLogenServer;
                    cmd.Parameters[36].Value = diagnose.GroupPolicyLoadTime;
                    cmd.Parameters[37].Value = diagnose.ProfileLoadTime.HasValue ? diagnose.ProfileLoadTime.Value : (object)DBNull.Value;
                    cmd.Parameters[38].Value = diagnose.logonDurationOther.HasValue ? diagnose.logonDurationOther.Value : (object)DBNull.Value;
                    cmd.Parameters[39].Value = diagnose.DesktopLoadTime.HasValue ? diagnose.DesktopLoadTime.Value : (object)DBNull.Value;
                    cmd.Parameters[40].Value = diagnose.XDLogonDuration;
                    cmd.Parameters[41].Value = diagnose.SessionCreateTime.HasValue ? diagnose.SessionCreateTime.Value : (object)DBNull.Value;
                    cmd.Parameters[42].Value = diagnose.UserADDN;
                    cmd.Parameters[43].Value = diagnose.UserADOU;
                    cmd.Parameters[44].Value = diagnose.UserFullName;
                    cmd.Parameters[45].Value = diagnose.AvgAppLoadTime.HasValue ? diagnose.AvgAppLoadTime.Value : (object)DBNull.Value;
                    cmd.Parameters[46].Value = diagnose.GPUCPUUtilization;
                    cmd.Parameters[47].Value = diagnose.GPUFrameBufferMemryUtilization.HasValue ? diagnose.GPUFrameBufferMemryUtilization.Value : (object)DBNull.Value;
                    cmd.Parameters[48].Value = diagnose.GPUencoderUtilization.HasValue ? diagnose.GPUencoderUtilization.Value : (object)DBNull.Value;
                    cmd.Parameters[49].Value = diagnose.GPUdecoderUtilization.HasValue ? diagnose.GPUdecoderUtilization.Value : (object)DBNull.Value;
                    cmd.Parameters[50].Value = diagnose.XDSiteName.HasValue ? diagnose.XDSiteName.Value : (object)DBNull.Value;
                    cmd.Parameters[51].Value = diagnose.XDSessionCreateTime.HasValue ? diagnose.XDSessionCreateTime.Value : (object)DBNull.Value;
                    cmd.Parameters[52].Value = diagnose.XDLogonDuration;
                    cmd.Parameters[53].Value = diagnose.XDPublishedResourceType;
                    cmd.Parameters[54].Value = diagnose.XDAnonymous;
                    cmd.Parameters[55].Value = diagnose.XDConnectedViaHostName;
                    cmd.Parameters[56].Value = diagnose.XDConnectedViaIPAddress;
                    cmd.Parameters[57].Value = diagnose.XDLaunchedViaHostName;
                    cmd.Parameters[58].Value = diagnose.XDLaunchedViaIPAddress;
                    cmd.Parameters[59].Value = diagnose.XDSessionReconnected;
                    cmd.Parameters[60].Value = diagnose.XDSecureICASession;
                    cmd.Parameters[61].Value = diagnose.Protocol;
                    cmd.Parameters[62].Value = diagnose.XDBrokeringDuration;
                    cmd.Parameters[63].Value = diagnose.XDBrokeringDate;
                    cmd.Parameters[64].Value = diagnose.XDVMStartDuration;
                    cmd.Parameters[65].Value = diagnose.XDClientSessionValidateDate;
                    cmd.Parameters[66].Value = diagnose.XDServerSessionValidateDate;
                    cmd.Parameters[67].Value = diagnose.XDEstablishmentDate;
                    cmd.Parameters[68].Value = diagnose.XDHDXConnectionLoadTime;
                    cmd.Parameters[69].Value = diagnose.XDAuthenticationDuration;
                    cmd.Parameters[70].Value = diagnose.XDGroupPolicyLoadTime;
                    cmd.Parameters[71].Value = diagnose.XDLogonScriptsLoadTime;
                    cmd.Parameters[72].Value = diagnose.XDProfileLoadTime;
                    cmd.Parameters[73].Value = diagnose.XDInteractiveSessionLoadTime;
                    cmd.Parameters[74].Value = diagnose.XDUPN;
                    cmd.Parameters[75].Value = diagnose.XDAppsInUse;
                    cmd.Parameters[76].Value = diagnose.XDAppsInUseCount;
                    cmd.Parameters[77].Value = diagnose.XDDisconnectReason;
                    cmd.Parameters[78].Value = diagnose.XDDisconnectDate;
                    cmd.Parameters[79].Value = diagnose.XDDeliveryGroup;

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

    }


}







