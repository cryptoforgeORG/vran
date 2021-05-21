using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using VRAN;

public class VRANClient : MonoBehaviour {

	public string ad_key = "7Ox5Wz1CeIQEnQ7VZP2i1xwgmMaLDk8g";
	public string app_key = "c1f8ee1b3fe2bfec4f61f88bb87e267c7602307f6a517c1f86c1fc2b412ad0768951af346c72001c";
	public string developer_key = "6f24855cf2a091bb13d377241559b2feb760ec287ef450252f2455d44e40ae0453d18aada4fab9b6";

	void Awake() {
		#region BEGIN SDK TEST
		gameObject.AddComponent<SDK>();
		gameObject.GetComponent<SDK>().Connect(developer_key, app_key, ad_key);
		gameObject.GetComponent<SDK>().Configure(Vector3.zero, Quaternion.identity, true);
		#endregion

		GameObject.Find("Timer").GetComponent<Text>().text = gameObject.GetComponent<SDK>().start.ToString();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find("Timer").GetComponent<Text>().text = (gameObject.GetComponent<SDK>().stop - gameObject.GetComponent<SDK>().start).ToString();
	}
}
