﻿using UnityEngine;
using System.Collections;

public class nano : MonoBehaviour {
	public GameController gameControler;
	GameObject parent;

	// Use this for initialization
	void Start () {
		parent = gameObject.transform.parent.gameObject;
	}


}
