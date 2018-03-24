using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour {
    public GameObject template;

    private LinkedList<Drop> drops;

    void Start () {
        drops = new LinkedList<Drop>();
    }
	
	void Update () {
	}

    void addDrop(Vector3 droppos) {
        GameObject newobj = Instantiate(template, droppos);

        MovementDrop md = drops.Last.Value as MovementDrop;
        md.nextHop = 

    }
        


}
