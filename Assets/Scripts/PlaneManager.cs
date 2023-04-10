using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneManager : MonoBehaviour
{

    //Singleton
    static PlaneManager instance;

    public bool useMovement = false;
    public static PlaneManager Get()
    {
        return instance;
    }

    private void Awake()
    {
        Debug.Log("set instance");
        instance = this;
    }

    [SerializeField]
    GameObject prefab;

    [SerializeField]
    int startingPlanes;

    public void onPlaneDeath()
    {
        createNewPlane();
    }
    void createNewPlane()
    {
        GameObject planeInstance = GameObject.Instantiate(prefab);
        planeInstance.transform.position = WorldBounds.Get().GetRandomPosition();
    }

    private void Start()
    {
        for (int i = 0; i < startingPlanes; i++)
        {
            createNewPlane();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            useMovement = !useMovement;
        }
    }
}
