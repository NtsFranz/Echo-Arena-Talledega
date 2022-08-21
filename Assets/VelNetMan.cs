using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VelNet;

public class VelNetMan : MonoBehaviour
{
	public GameObject playerPrefab;

	private void Awake()
	{
		VelNetManager.OnLoggedIn += () =>
		{
			VelNetManager.Join("room");
		};
		VelNetManager.OnJoinedRoom += _ =>
		{
			VelNetManager.NetworkInstantiate(playerPrefab.name);
		};
	}

	// Update is called once per frame
	void Update()
	{
	}
}