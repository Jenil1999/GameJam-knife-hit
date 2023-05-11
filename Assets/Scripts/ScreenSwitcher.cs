using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSwitcher : MonoBehaviour
{
     public float timer;

    [SerializeField] public Canvas splashScreen = default;
    [SerializeField] public Canvas homeScreen = default;
    [SerializeField] public Canvas playingScreen = default;

    private void Start()
    {
        switchScreens(splashScreen);

        StartCoroutine(wait_loading());
    }

    private void ShowsplashScreen()
    {
        switchScreens(splashScreen);
    }

    public void ShowhomeScreen()
    {
        switchScreens(homeScreen);
    }

    public void ShowplayingScreen()
    {
        switchScreens(playingScreen);
    }

    public void switchScreens(Canvas sSwitch)
    {
        homeScreen.enabled = false;
        splashScreen.enabled = false;
        playingScreen.enabled = false;

        sSwitch.enabled = true;
    }

    IEnumerator wait_loading()
    {
        yield return new WaitForSeconds(timer);

        ShowhomeScreen();
    }

}
