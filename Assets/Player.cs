using System;
using System.IO;
using UnityEngine;
using unityutilities;
using VelNet;

public class Player : NetworkSerializedObjectStream
{
	public Rig rig;
	public Transform head;
	public Transform leftHand;
	public Transform rightHand;

	private void Start()
	{
		if (IsMine)
		{
			rig = FindObjectOfType<Rig>();
		}
	}

	// Update is called once per frame
	private void Update()
	{
		if (networkObject.IsMine)
		{
			head.position = rig.head.position;
			head.rotation = rig.head.rotation;
			leftHand.position = rig.leftHand.position;
			rightHand.position = rig.rightHand.position;
		}
	}

	protected override void SendState(BinaryWriter binaryWriter)
	{
	}

	protected override void ReceiveState(BinaryReader binaryReader)
	{
	}
}