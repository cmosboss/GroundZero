using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {
    private int kills = 0;
    private int attacks = 0;
    private int gold = 0;
    private int hits = 0;
    private int casts = 0;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
	
	}
    public void onKill() {
        kills++;
    }
    public void onHit() {
        hits++;
    }
    public void onAttack() {
        attacks++;
    }
    public void onCast() {
        casts++;
    }
    public void roundEnd() {
    }
    public void SaveAllToDisk() {
        SaveAll();
        PlayerPrefs.Save();
    }
    public void SaveAll() {
        PlayerPrefs.SetInt("Total Kills", PlayerPrefs.GetInt("Total Kills") + kills);
        PlayerPrefs.SetInt("Total Gold", PlayerPrefs.GetInt("Total Gold") + gold);
        PlayerPrefs.SetInt("Total Attacks", PlayerPrefs.GetInt("Total Kills") + attacks);
        PlayerPrefs.SetInt("Total Hits", PlayerPrefs.GetInt("Total Kills") + hits);
        PlayerPrefs.SetInt("Total Casts", PlayerPrefs.GetInt("Total Kills") + casts);
        PlayerPrefs.SetFloat("Total Time", PlayerPrefs.GetFloat("Total Time") + Time.timeSinceLevelLoad);

    }
}
