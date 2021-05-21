using UnityEngine;
using UnityEditor;
using System;

public class CreateAssetBundles
{
	[MenuItem ("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles () {
		AssetBundleBuild[] build = new AssetBundleBuild[1];
		build[0] = new AssetBundleBuild();
		build[0].assetBundleName = "vran";
		build[0].assetNames = new string[1] { "Assets/Cylinder.prefab" };
		BuildPipeline.BuildAssetBundles("Assets/", build);
	}
	[MenuItem ("Assets/Build AssetBundles for IOS")]
	static void BuildAllAssetBundlesForIOS () { 
		Debug.Log("Build AssetBundles for IOS"); 
		AssetBundleBuild[] build = new AssetBundleBuild[1];
		build[0] = new AssetBundleBuild();
		build[0].assetBundleName = "vran-ios";
		build[0].assetNames = new string[1] { "Assets/Cylinder.prefab" };
		BuildPipeline.BuildAssetBundles("Assets/", build, BuildAssetBundleOptions.None, BuildTarget.iOS);
	}
}
public class GetAssetBundleNames
{
	[MenuItem ("Assets/Get AssetBundle names")]
	static void GetNames ()
	{
		var names = AssetDatabase.GetAllAssetBundleNames();
		foreach (var name in names) {
			Debug.Log ("AssetBundle: " + name);
		}
	}
}