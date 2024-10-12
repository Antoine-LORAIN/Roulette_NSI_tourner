using UnityEngine;

[CreateAssetMenu(fileName = "Game Properties", menuName = "Game Properties")]
public class GameProperties : ScriptableObject
{
    public string title;
    public string version;

    public bool mustRoll;

    public int argentTotal;

    [Header("Rotation speed")]
    public int rotSpeedMin;
    public int rotSpeedMax;
}