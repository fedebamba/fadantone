using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour {
    public GameObject template;

    private LinkedList<GameObject> drops = new LinkedList<GameObject>();

    void Start () {
        drops = new LinkedList<GameObject>();
    }
	
	void Update () {
	}

    public void addDrop(Vector3 droppos) {
        GameObject newobj = Instantiate(template, droppos, Quaternion.identity);

        if (drops.Last != null) {
            MovementDrop md = drops.Last.Value.GetComponent<MovementDrop>();
            md.nextHop = newobj;
        }
        drops.AddLast(newobj);

    }
        


}
