using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadAssetBundles : MonoBehaviour
{
    AssetBundle asset;
  // public  string path;
    public string bundleObject;
    // Start is called before the first frame update
    void Start()
    {
        var path = "C:/Users/Gopalakrishnareddy/RandomText/Assets/AssetBundles";
        LoadAssetBundle(path);
        //GetObjectFromBundle(bundleObject);
    }

    private void LoadAssetBundle(string pathName)
    {
        asset = AssetBundle.LoadFromFile(pathName);
        Debug.Log(asset==null ? "Failed" : "Loaded");
    }
    private void GetObjectFromBundle(string objectName)
    {
        var assetPrefab=asset.LoadAsset(objectName);
        Instantiate(assetPrefab);
    }
    
}
