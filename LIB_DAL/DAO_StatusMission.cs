﻿using LIB_BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class DAO_StatusMission
    {
        public static List<DB_StatusMission> getStatusMissionList()
        {
            var statusMissions = new List<DB_StatusMission>();

            try
            {
                string sql = "SELECT * FROM status_mission;";
                MySqlCommand cmd = new MySqlCommand(sql, BDD_Connect.cnx);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DB_StatusMission statusMission = new DB_StatusMission(dr.GetInt32(0), dr.GetString(1));
                    //Console.Write(typePayload);
                    statusMissions.Add(statusMission);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur durant la requête SQL : " + ex.ToString());
            }
            return statusMissions;
        }
    }
}
