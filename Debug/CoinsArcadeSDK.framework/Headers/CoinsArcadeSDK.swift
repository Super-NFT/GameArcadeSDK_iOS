//
//  CoinsArcadeSDK.swift
//  CoinsArcadeSDK
//
//  Created by Taran on 2023/4/19.
//

import UIKit

@objcMembers
public class CoinsArcadeSDK: NSObject {
    
    // If this parameter validation succeeds, it will return access_token, otherwise return failed reason desc.
    // Please keep the access_token well, all subsequent operations need it.
    /// -Parameters:
    ///  -secretKey: apply for Coins
    ///  -clientKey: apply for Coins
    ///  -completion: if success return access_token, otherwise return error.
    public static func initSDK(secretKey: String,
                               clientKey: String,
                               completion: Result<String, Error>?) {
        
    }
    
    /// -Parameters:
    ///  -address: paired with coins arcade in your system
    ///  -uuid: user unique id in your system, for one-to-one unique identification in coins
    ///  -accessToken: initSDK returned
    ///  -completion: return success or error, if previously binded, will  also return success
    public static func bindWithCoins(address: String,
                                     uuid: String,
                                     accessToken: String,
                                     completion: Result<String, Error>?) {
        
    }
    
    public static func canHandleURL(with url: URL) -> Bool {
        return false
    }

    public static func handleURL(with url: URL) {
        
    }
}

extension CoinsArcadeSDK {
    public static func isBindWithCoins(address: String,
                                       uuid: String,
                                       accessToken: String) -> Bool {
        return false
    }
    
    public static func isCoinsAppInstalled() -> Bool {
        return true
    }
}

extension CoinsArcadeSDK {
    /// -Parameters
    ///   -accessToken: initSDK returned
    ///   -tokenID: token you want to deposit
    ///   -chainID: token chain
    ///   -amount: value you want to deposit
    ///   -completion: return deposit from coins arcade result: success or failed code and reason
    public static func depositFromCoinsWallet(accessToken: String,
                                              tokenID: Int,
                                              chainID: Int,
                                              amount: Float,
                                              completion: Result<String, Error>?) {
        
    }
}
