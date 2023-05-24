using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBike : MonoBehaviour
{
    public GameObject[] bikeSelected;
    public Transform spawnPoint;

    void Start()
    {
        int selectedBike = PlayerPrefs.GetInt("SelectedBike");// get chosen integer
        Debug.Log("selected Character: " + selectedBike);
        GameObject prefab = bikeSelected[selectedBike];//set it to the corresponding bike
        //GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);//clone it (should remove)
        //use for loop to identify which bike in an array is chosen
        //only hide the ones that arent chosen
        for (int i = 0; i < bikeSelected.Length; i++)
        {
            if (i != selectedBike)
            {
                bikeSelected[i].SetActive(false);//hide the not chosen bikes
            }
        }
























        /*
        //----------- ADD COMPONENTS HERE---------------
        //clone.AddComponent<ScriptName>();

        //---------- add rigidbody ---------------
        Rigidbody rb = clone.AddComponent<Rigidbody>();
        rb.mass = 100f;
        //rb.useGravity = true;
        rb.angularDrag = 0.05f;
        rb.collisionDetectionMode = CollisionDetectionMode.Discrete;
        /*
        //---------- add hover script -------------
        Hover HoverComp = clone.AddComponent<Hover>();
        HoverComp.minimumHeight = 192f;
        HoverComp.hoverHeight = 1f;
        HoverComp.hoverForce = 20000f;
        HoverComp.hoverDamp = 0.5f;
        

        //---------- add Bike Controls script ---------------
        BikeControls bikeControlsComp = clone.AddComponent<BikeControls>();
        bikeControlsComp.speed = 10f;
        bikeControlsComp.turnSpeed = 5f;




        //add mission controller
        clone.AddComponent<MissionController>();
        */
    }
}
