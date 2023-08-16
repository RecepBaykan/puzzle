using System.IO;
using UnityEngine;

public  static class kaydetCan
{



    public static string klasor = "/kayitBigisi/";
    public static string dosya = "can.txt";

    public static void kayit(canBilgisi can)
    {
        string yol = Application.persistentDataPath + klasor;
        if (!Directory.Exists(yol))
        {
            Directory.CreateDirectory(yol);
        }

        string json = JsonUtility.ToJson(can);
        File.WriteAllText(yol + dosya, json);
    }

    public static canBilgisi yukle()
    {
        canBilgisi can = new canBilgisi();
        string tamYol = Application.persistentDataPath + klasor + dosya;
        if (File.Exists(tamYol))
        {
            string json = File.ReadAllText(tamYol);
            can = JsonUtility.FromJson<canBilgisi>(json);
        }


        return can;

    }




}
