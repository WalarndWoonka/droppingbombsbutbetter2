using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Spawner spawner;
    public GameObject title;
    // Start is called before the first frame update
    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Start()
    {
        spawner.active = false;
        title.SetActive(true);
    }
    void Update()
    {
        if (Input.anyKeyDown)
        {
            spawner.active = true;
            title.SetActive(false);
        }
    }
}
