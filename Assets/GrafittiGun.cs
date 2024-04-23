using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrafittiGun : MonoBehaviour
{

    public GameObject GrafittiGunPrefab;
    public Camera Camera;
    public GameObject SpawnPos;
    public float GunBulletSpeed = 100;


    // Start is called before the first frame update
    void Start()
    {

    }

    void FireGun()
    {
        GameObject tmp = Instantiate(GrafittiGunPrefab) as GameObject;
        tmp.transform.position = SpawnPos.transform.position;
        tmp.transform.forward = Camera.transform.forward;
        tmp.GetComponent<Rigidbody>().velocity = Camera.transform.forward * GunBulletSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireGun();
        }
    }
}
