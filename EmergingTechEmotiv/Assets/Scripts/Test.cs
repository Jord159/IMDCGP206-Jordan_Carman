using CortexAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Test : MonoBehaviour {
    const string Username = "your_username";
    const string Password = "your_password";
    const string ProfileName = "profileName";

    // Use this for initialization
    void Start () {
        Process p = new Process();
        Thread.Sleep(1000); //wait for querrying user login, query headset
        if (String.IsNullOrEmpty(p.GetUserLogin()))
        {
            p.Login(Username, Password);
            Thread.Sleep(500); //wait for logining
        }
        // Show username login
        Debug.Log("Username :" + p.GetUserLogin());

        if (p.AccessCtr.IsLogin)
        {
            // Send Authorize
            p.Authorize();
            Thread.Sleep(5000); //wait for authorizing
        }
        if (!p.IsHeadsetConnected())
        {
            p.QueryHeadset();
            Thread.Sleep(10000); //wait for querying headset and create session
        }
        if (!p.IsCreateSession)
        {
            p.CreateSession();
            Thread.Sleep(5000);
        }
        if (p.IsCreateSession)
        {
            // Subcribe sys event
            p.SubcribeData("sys");
            Thread.Sleep(5000);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
