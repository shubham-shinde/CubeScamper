using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;

public class AdsManagerScriptGame : MonoBehaviour
{
    // Start is called before the first frame update

    private BannerView bannerView;

    [SerializeField] private string appID = "ca-app-pub-5154068463181892~3487072269";
    [SerializeField] private string bannerID = "ca-app-pub-5154068463181892/6751954888";
    [SerializeField] private string regularID = "ca-app-pub-5154068463181892/1272397493";

    void Awake()
    {
        MobileAds.Initialize(appID);
        this.RequestBannerAds();
    }

    public void showInterstitialAd()
    {
        //this.RequestRegularAd();
    }

    private void RequestRegularAd()
    {
        InterstitialAd AD = new InterstitialAd(regularID);

        AdRequest request = new AdRequest.Builder().Build();

        AD.LoadAd(request);
    }

    private void RequestBannerAds()
    {
        bannerView = new BannerView(bannerID, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }
}
