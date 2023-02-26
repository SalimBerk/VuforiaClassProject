using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Firebase.Database;
using Firebase.Extensions;
using Unity.VisualScripting;
using JetBrains.Annotations;
using System.Linq;
using Mono.Data.Sqlite;
using Mono.Data;
using System.Data;

public class TextScript2 : MonoBehaviour
{
    public Material[] material; //renk materyalleri
    int x;
    
    Renderer rend;
    public TMPro.TextMeshProUGUI text_two;
    public TMPro.TextMeshProUGUI text_one;


    // Start is called before the first frame update
    void Start()
    {
        string conn = "URI=file:" + "C:\\Users\\salim\\classProject\\Assets\\Plugins" + "\\" + "Class.db";
        Debug.Log("db_connection_string" + conn);
        IDbCommand dbcmd;
        IDataReader reader;
        IDbConnection dbcon = new SqliteConnection(conn);
        dbcon.Open();
        dbcmd = dbcon.CreateCommand();
        string q_createTable = "SELECT * FROM Classinfo where Id=2";
        dbcmd.CommandText = q_createTable;
        reader = dbcmd.ExecuteReader();


        int day = System.DateTime.UtcNow.Day;
        int month = System.DateTime.UtcNow.Month;
        int year = System.DateTime.UtcNow.Year;
        System.DateTime date = new System.DateTime(year, month, day);

        x = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[x];



        string[] a = System.DayOfWeek.GetNames(typeof(System.DayOfWeek));
        int hour = System.DateTime.UtcNow.ToLocalTime().Hour;
        int minute = System.DateTime.UtcNow.ToLocalTime().Minute;
        string newTime = hour.ToString() + ":" + minute.ToString();



            if (date.DayOfWeek.ToString() == a[2].ToString())
            {
                if (((hour == 09 && minute >= 00) || (hour == 11 && minute <= 50)) || (hour > 09 && hour < 11))
                {
                x = x + 1;
                while (reader.Read())
                {
                    text_two.text = reader[1].ToString();
                    text_one.text = reader[2].ToString();
                    rend.sharedMaterial = material[x];


                }
                dbcon.Close();

                }
                else
                {
                    x = x + 2;
                    text_two.text = "Ogretmen Atanmadı";
                    text_one.text = "Yanlis Saat";
                    rend.sharedMaterial = material[x];
                }


            }
            else if (date.DayOfWeek.ToString() == a[4].ToString())
            {
                if (((hour == 15 && minute >= 00) || (hour == 17 && minute <= 50)) || (hour > 15 && hour < 17))
                {
                    x = x + 1;
                    text_two.text = reader.GetString(1);
                    text_one.text= reader.GetString(2);
                    rend.sharedMaterial = material[x];
                }
                else
                {
                    x = x + 2;
                    text_two.text = "Ogretmen Atanmadı";
                    text_one.text = "Yanlis Saat";
                    rend.sharedMaterial = material[x];
                }

            }
            else
            {

                x = x + 2;
                text_two.text = "Ders Bulunamadı";
                rend.sharedMaterial = material[x];
                text_one.text = " ";



            }


        }




        
      

           
       
        
        
       
       
        
    }

    // Update is called once per frame


