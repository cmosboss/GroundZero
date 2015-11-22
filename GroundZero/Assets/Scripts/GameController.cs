#pragma warning disable 0168 // variable declared but not used.
#pragma warning disable 0219 // variable assigned but not used.
#pragma warning disable 0414 // private field assigned but not used.

using UnityEngine;
using System.Collections;
public enum GameMode {
    Waves, OnSlaught, Hero
}
public class GameController : MonoBehaviour {
    public GameMode current;
    //Use this is a controller for any game, load the wave system, or the arcade system whatever you need. THIS IS THE HIGHEST LEVEL, eventually menus and credits will load from here
    // Use this for initialization
    void Start () {
        switch (current) {
            case (GameMode.Waves):
                gameObject.AddComponent<WaveSystem>();
                break;
            case (GameMode.OnSlaught):
                //add component for onslaught
                break;
            case (GameMode.Hero):
                //add component for hero mode
                break;

        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
