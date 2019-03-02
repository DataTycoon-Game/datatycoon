using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveDataModel
{

    public static void SaveData (IncrementMoney incrementMoney)
    {

        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/savedata.dt";

        FileStream stream = new FileStream(path, FileMode.Create);

        SaveDataEncrypter data = new SaveDataEncrypter(incrementMoney);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static SaveDataEncrypter LoadData ()
    {

        string path = Application.persistentDataPath + "/savedata.dt";

        if (File.Exists(path))
        {

            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            SaveDataEncrypter data = formatter.Deserialize(stream) as SaveDataEncrypter;

            stream.Close();

            return data;

        }
        else
        {

            Debug.LogError("Save file not found in - " + path);
            return null;

        }

    }

}
