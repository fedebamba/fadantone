using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour {
    public float sightRadius = 1.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Collider[] drops = Physics.OverlapSphere(this.transform.position, sightRadius);
        foreach (Collider dropcoll in drops) {

            Drop drop = dropcoll.GetComponentInParent<Drop>();
            Debug.DrawLine(this.transform.position, dropcoll.transform.position);
            if (drop != null) {
                drop.getInstruction(this);
            }
        }
        		
	}
}
