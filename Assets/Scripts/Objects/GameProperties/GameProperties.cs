using UnityEngine;

public class GameProperties : ScriptableObject
{
    public string title;
    public string version;

    public bool mustRoll;
    public bool canRoll;

    [Header("Rotation speed")]
    public int rotSpeedMin;
    public int rotSpeedMax;

    [Header("Jeu")]
    public int argentTotal;
    public int mise;
    [Header("Numéro Plein")]
    public int nombreTire;

    [Header("Chance Simple")]
    public string isPair;
}