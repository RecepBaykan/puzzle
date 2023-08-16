using System.IO;
using UnityEngine;

public  static class kaydet
{



    public static string klasor = "/kayitBigisi/";
    public static string dosya = "bilgi.txt";

    public static void kayit(kayitBilgileri kb)
    {
        string yol = Application.persistentDataPath + klasor;
        if (!Directory.Exists(yol))
        {
            Directory.CreateDirectory(yol);
        }

        string json = JsonUtility.ToJson(kb);
        File.WriteAllText(yol + dosya, json);
    }

    public static kayitBilgileri yukle()
    {
        kayitBilgileri kb = new kayitBilgileri();
        string tamYol = Application.persistentDataPath + klasor + dosya;
        if (File.Exists(tamYol))
        {
            string json = File.ReadAllText(tamYol);
            kb = JsonUtility.FromJson<kayitBilgileri>(json);
        }


        return kb;

    }




}
