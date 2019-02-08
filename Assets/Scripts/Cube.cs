using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.Events;public class Cube : MonoBehaviour {    public UnityEvent fx;    public UnityEvent movement;	// Use this for initialization	void Start () {
        //fx.AddListener(Learn);
    }		// Update is called once per frame	void Update () {        if (Input.GetKeyDown("space"))
        {
            fx.Invoke();
        }	}    void Learn()
    {
        print("action");
    }    public void Over()    {        GetComponent<MeshRenderer>().material.color = Color.cyan;
        movement.Invoke();
    }    public void Exit()    {        GetComponent<MeshRenderer>().material.color = Color.white;
        fx.Invoke();    }}