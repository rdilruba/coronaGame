using UnityEngine;
using UnityEngine.Advertisements;

public class AddController : MonoBehaviour { 

    string gameId = "3969555";
    bool testMode = false;

    void Start () {
        // Initialize the Ads service:
        Advertisement.Initialize(gameId, testMode);
    }

    public void ShowInterstitialAd() {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady()) {
            Advertisement.Show();
        } 
        else {
            Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
        }
    }
}