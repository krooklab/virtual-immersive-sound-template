﻿using UnityEngine;
using System.Collections;

public class SendPositionOnUpdate : MonoBehaviour {

	public OSC osc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	  OscMessage message = new OscMessage();

        message.address = "/UpdateXYZ";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/UpdateX";
        message.values.Add(transform.position.x);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/UpdateY";
        message.values.Add(transform.position.y);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/UpdateZ";
        message.values.Add(transform.position.z);
        osc.Send(message);


    }
	public void sendMsg()
	{
		OscMessage message = new OscMessage();

		message.address = "/UpdateXYZ";
		//Debug.Log (myCollider.transform.position.x);
		//message.values.Add(myCollider.transform.position.x);
		//message.values.Add(myCollider.transform.position.y);
		//message.values.Add(myCollider.transform.position.z);
		message.values.Add(3);
		message.values.Add(4);
		message.values.Add(5);
		osc.Send(message);
	}
}
