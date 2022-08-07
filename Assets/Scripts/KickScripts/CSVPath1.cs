using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class CSVPath1 : MonoBehaviour
{
    // InputData1 InputData1;

    public List<float> Timer = new List<float>(); 
    public float Timer1;

    // GameObject StartCanvas;
    // public bool activeSelf;

    string filename = "";

    public static int count = 0;  
    Vector3 Crashposition; 
    Vector3 Crashposition1;

    public List<float> PositionX = new List<float>();
    public List<float> PositionZ = new List<float>();

    public List<float> CollisionPositionX = new List<float>();
    public List<float> CollisionPositionZ = new List<float>();
    public List<float> CollisionPositionY = new List<float>();
    public List<int> CollisionCounting = new List<int>();
    // public List<float> CollisionTime = new List<float>();

    int scene; 
    

    void Start()
    {
        
    }

    void Update()
    {
        
        scene = SceneManager.GetActiveScene().buildIndex;

        filename = Application.dataPath + "/" + DataManager.instance.nowplayer.name + "_" + DataManager.instance.nowplayer.age + "_" + DataManager.instance.nowplayer.height + "_" + DataManager.instance.nowplayer.weight + "_" + scene +"_file.csv";

        Timer1 = Time.time;

        Timer.Add(Timer1);

        Crashposition = this.gameObject.transform.position;

        PositionX.Add(Crashposition.x);
        PositionZ.Add(Crashposition.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            WriteCSV();
            Debug.Log("space2");
        }

    }

    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        count += 1;
        CollisionCounting.Add(count); 
        Debug.Log(count);

        Crashposition1 = this.gameObject.transform.position;

        CollisionPositionX.Add(Crashposition1.x);
        CollisionPositionY.Add(Crashposition1.y);
        CollisionPositionZ.Add(Crashposition1.z);

        Debug.Log("x : " + Crashposition1.x);
        Debug.Log("y : " + Crashposition1.y);
        Debug.Log("z : " + Crashposition1.z);

        //CollisionTime.Add(Time.time);
    }

    public void WriteCSV()
    {
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        
        TextWriter tw = new StreamWriter(filename, false);

        tw.WriteLine("Time, PositionX, PositionZ, PositionY, CollisionCounting");
        tw.Close();

        tw = new StreamWriter(filename, true);
        for (int i = 0; i < PositionX.Count; i++)
        {
            tw.WriteLine(Timer[i] + "," + PositionX[i] + "," + PositionZ[i] + "," +
                "." + "," + "." );

            for (int j = 0; j < CollisionCounting.Count; j++)
            {
                if(PositionX[i] == CollisionPositionX[j] && PositionZ[i] == CollisionPositionZ[j])
                {
                    tw.WriteLine(Timer[i] + "," + PositionX[i] + "," + PositionZ[i] + "," +
                    CollisionPositionY[j] + "," + CollisionCounting[j]);
                }
            }
        }
        
        tw.Close();
    }
}
