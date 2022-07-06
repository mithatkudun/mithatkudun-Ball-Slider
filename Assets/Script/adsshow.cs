using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class adsshow : MonoBehaviour
{
    public pausemenu pausemenu;
    public BallControl BallControl;
    public Button tryagain;
    public Button Continue;
    string gameId = "3840333";
    string myPlacementId = "rewardedVideo";
    bool testMode = false;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowInterstitialAd()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady())
        {
            Time.timeScale = 1f;
            Advertisement.Show();
            pausemenu.reklamcounter = 0;
        }
        else
        {
            Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
        }
    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {

            Time.timeScale = 1f;
            BallControl.sanssayisi = 4;

        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }
    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
            Time.timeScale = 1f;
            BallControl.sanssayisi = 4;
            pausemenu.reklamcounter = 0;
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }
}

