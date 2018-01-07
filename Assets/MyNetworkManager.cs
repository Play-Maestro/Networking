using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	public void MyStartHost () {
		StartHost();
		Debug.Log (Time.timeSinceLevelLoad + " Starting Host");
	}

	public override void OnStartHost () {
		Debug.Log (Time.timeSinceLevelLoad + " Started Host");
	}

	public override void OnStartClient (NetworkClient myClient) {
		Debug.Log (Time.timeSinceLevelLoad + " " + myClient + " trying to log in.");
	}

	public override void OnClientConnect (NetworkConnection myConnection) {
		Debug.Log (Time.timeSinceLevelLoad + " Client Connected to IP: " + myConnection.address);
	}
}
