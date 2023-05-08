using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using AOT;

public class CoinsArcadeFunctionsScript : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void initSDK(string secretKey, string clientKey);

    [DllImport("__Internal")]
    private static extern void bindWithCoins(string address, string uuid, string accessToken);

    [DllImport("__Internal")]
    private static extern void depositFromCoinsWallet(string accessToken, int tokenId, int chainId, double amount);


    // Delegates
    public delegate void CoinsArcadeAccessTokenDelegate(string value);
    [DllImport("__Internal")]
    private static extern void setCoinsArcadeDidAccessToken(CoinsArcadeAccessTokenDelegate callBack);

    public delegate void CoinsArcadeBindAddressDelegate(bool result, string reason);
    [DllImport("__Internal")]
    private static extern void setCoinsArcadeDidBindAddress(CoinsArcadeBindAddressDelegate callBack);

    public delegate void CoinsArcadeDepositDelegate(bool result, string reason);
    [DllImport("__Internal")]
    private static extern void setCoinsArcadeDidDeposit(CoinsArcadeDepositDelegate callBack);


    // Handle delegates
    [MonoPInvokeCallback(typeof(CoinsArcadeAccessTokenDelegate))]
    public static void coinsArcadeDidAccessToken(string accessToken)
    {
        Debug.Log("Coins Arcade did access token with" + accessToken);
    }

    [MonoPInvokeCallback(typeof(CoinsArcadeBindAddressDelegate))]
    public static void coinsArcadeDidBindAddress(bool result, string reason)
    {
        if (result) {
            Debug.Log("Coins Arcade did bind address success");
        } else {
            Debug.Log("Coins Arcade did bind address failed with" + reason);
        }
    }

    [MonoPInvokeCallback(typeof(CoinsArcadeDepositDelegate))]
    public static void coinsArcadeDidDeposit(bool result, string reason)
    {
        if (result) {
            Debug.Log("Coins Arcade did deposit success, please check result." );
        } else {
            Debug.Log("Coins Arcade did deposit failed with" + reason);
        }
    }

    // Bind coins arcade protocol callback
    public void bindCoinsArcadeCallback() {
        setCoinsArcadeDidAccessToken(coinsArcadeDidAccessToken);
        setCoinsArcadeDidBindAddress(coinsArcadeDidBindAddress);
        setCoinsArcadeDidDeposit(coinsArcadeDidDeposit);
    }

    // Call coins arcade functions, please bind coins arcade callback first
    public void callCoinsArcadeInitSDK() {
        initSDK("", "");
    }

    public void callCoinsArcadeBindAddress() {
        bindWithCoins("", "", "");
    }

    public void callCoinsArcadeDeposit() {
        depositFromCoinsWallet("", 11111, 111, 0.01);
    }
}
