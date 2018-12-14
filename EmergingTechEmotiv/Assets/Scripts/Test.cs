using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Test : MonoBehaviour {

    float focus = 0;
    float excitement = 0;
    float interest = 0;
    float engagement = 0;
    float stress = 0;
    float relaxation = 0;
    float prevTime; //Time the metrics were last updated

	void Start () {
        prevTime = Time.time;
        UpdateMetrics();
    }
	
	void FixedUpdate () {
        if (Time.time >= prevTime + 10) //Metric files get updated every 10 seconds
        {
            prevTime = Time.time;
            UpdateMetrics();
        }
    }

    void UpdateMetrics()
    {
        try
        {
            using (StreamReader sr = new StreamReader("Assets/Metrics/focus.txt"))
            {
                focus = float.Parse(sr.ReadToEnd());
            }
        }
        catch
        {
            Debug.Log("File could not be read");
        }
        Debug.Log(focus);
        try
        {
            using (StreamReader sr = new StreamReader("Assets/Metrics/excitement.txt"))
            {
                excitement = float.Parse(sr.ReadToEnd());
            }
        }
        catch
        {
            Debug.Log("File could not be read");
        }
        Debug.Log(excitement);
        try
        {
            using (StreamReader sr = new StreamReader("Assets/Metrics/interest.txt"))
            {
                interest = float.Parse(sr.ReadToEnd());
            }
        }
        catch
        {
            Debug.Log("File could not be read");
        }
        Debug.Log(interest);
        try
        {
            using (StreamReader sr = new StreamReader("Assets/Metrics/engagement.txt"))
            {
                engagement = float.Parse(sr.ReadToEnd());
            }
        }
        catch
        {
            Debug.Log("File could not be read");
        }
        Debug.Log(engagement);
        try
        {
            using (StreamReader sr = new StreamReader("Assets/Metrics/stress.txt"))
            {
                stress = float.Parse(sr.ReadToEnd());
            }
        }
        catch
        {
            Debug.Log("File could not be read");
        }
        Debug.Log(stress);
        try
        {
            using (StreamReader sr = new StreamReader("Assets/Metrics/relaxation.txt"))
            {
                relaxation = float.Parse(sr.ReadToEnd());
            }
        }
        catch
        {
            Debug.Log("File could not be read");
        }
        Debug.Log(relaxation);
    }
}
