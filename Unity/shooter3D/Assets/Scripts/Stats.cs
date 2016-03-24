﻿using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{
    public GameSession GameSession;
    public DatabaseController dbController;

    public int ShotsFired
    {
        get;
        set;
    }

    public int ShotsHit
    {
        get;
        set;
    }

    public int Kills
    {
        get;
        set;
    }

    public int Deaths
    {
        get;
        set;
    }
       
    // Use this for initialization
	void Start()
    {
        ShotsFired = 0;
        ShotsHit = 0;
        Kills = 0;
        Deaths = 0;
        GameSession = gameObject.AddComponent<GameSession>() as GameSession;
        dbController = gameObject.AddComponent<DatabaseController>() as DatabaseController;
        GameSession.SetUserID(1008);
	}

    void OnApplicationQuit()
    {
        GameSession.Stop();
        SaveStats();
    }

    void SaveStats()
    {
        dbController.SaveStats(GameSession, this);
    }
}