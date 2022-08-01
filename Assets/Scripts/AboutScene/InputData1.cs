using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class InputData1 : MonoBehaviour
{
    string filename = "";

    public InputField InputText_Name;
    public InputField InputText_Age;
    public InputField InputText_Stage;

    // public void WriteCSV()
    // {
       
    //     TextWriter tw = new StreamWriter(filename, false);

    //     tw.WriteLine("Name, Age, Height, Weight");
    //     tw.Close();

    //     tw = new StreamWriter(filename, true);
    //     tw.WriteLine(InputText_Name.text + "," + InputText_Age.text);
    //     tw.Close();

    //     Debug.Log("asdfsadfsdaf");
    // }

    // Update is called once per frame
    void Update()
    {
        // filename = Application.dataPath + "/" + InputText_Name.text + "_" + InputText_Age.text + "_" +"file.csv";
        filename = Application.dataPath + "/" +"file.csv";
    }

}
