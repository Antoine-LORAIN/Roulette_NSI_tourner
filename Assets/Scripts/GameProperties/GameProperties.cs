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
    public string typeJeu;
    [Header("Numéro Plein")]
    public int nombreTire;
    public int nombreUser;

    [Header("Chance Simple")]
    public string isPair;
}