using UnityEngine;

public class GameProperties : ScriptableObject
{
    public string title;
    public string version;

    public bool mustRoll;

    [Header("Rotation speed")]
    public int rotSpeedMin;
    public int rotSpeedMax;

    [Header("Jeu")]
    public int argentTotal;
    public int mise;
    public int nombreTire;
    public int nombreUser;
}