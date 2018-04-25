using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPointCalculator : MonoBehaviour {

    public GameObject Camera;
    float startingY; 
    public GameObject Sphere; 
    public List<GameObject> Pawns;
    public List<Vector3> PawnLocations; 

	// Use this for initialization
	void Start () {
        startingY = Camera.transform.position.y; 


    }
	
	// Update is called once per frame
	void Update () {

        GetPawnLocations();
        Sphere.transform.position = FindCenter(PawnLocations);

        Camera.transform.position = Sphere.transform.position;
        Vector3 location = Camera.transform.position;
        location.y = startingY;
        Camera.transform.position = location; 
    }

    public void GetPawnLocations()
    {
        PawnLocations.Clear();
        foreach (GameObject p in Pawns)
        {
            PawnLocations.Add(p.transform.position); 
        }
    }

    public Vector3 FindCenter(List<Vector3> PawnLocations)
    {
        Vector3 result = Vector3.zero;
        // Start Small for the Max. Start Large for the Min
        Vector3 MaxExtent = new Vector3(float.MinValue, float.MinValue, float.MinValue); 
        Vector3 MinExtent = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);

        foreach (Vector3 place in PawnLocations)
        {
            MaxExtent = Vector3.Max(place, MaxExtent);
            MinExtent = Vector3.Min(place, MinExtent);
        }
        Vector3 Extent = MaxExtent - MinExtent;
        Extent = Extent * .5f; // Divide  
        result = MinExtent + Extent; 

        return result;
    }
}
