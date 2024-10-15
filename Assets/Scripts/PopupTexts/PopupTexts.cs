using UnityEngine;

public class PopupTexts : ScriptableObject
{
    [Header("Numéro Plein")]
    [Header("Gagné")]
    public string NPGtitle;
    public string NPGcontent;
    [Header("Perdu")]
    public string NPPtitle;
    public string NPPcontent;

    [Space(50)]
    [Header("Chance Simple")]
    [Header("Gagné")]
    public string CSGtitle;
    public string CSGcontent;
    [Header("Perdu")]
    public string CSPtitle;
    public string CSPcontent;
    [Header("Perdu cause 0")]
    public string CSOtitle;
    public string CSOcontent;

    [Space(50)]
    [Header("Erreur mise nulle")]
    public string EMNtitle;
    public string EMNcontent;
    [Header("Erreur pas assez d'argent")]
    public string EPAtitle;
    public string EPAcontent;

}