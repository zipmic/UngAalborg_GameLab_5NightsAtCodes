using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrafittiBall : MonoBehaviour
{
    public GameObject SplatDecal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject tmp = Instantiate(SplatDecal) as GameObject;
        tmp.transform.position = collision.contacts[0].point + (0.01f * collision.contacts[0].normal);
        tmp.transform.forward = collision.contacts[0].normal * -1;
        tmp.transform.Rotate(0, 0, Random.Range(0, 360));
        tmp.transform.localScale *= Random.Range(0.8f, 1.2f);
        Destroy(gameObject);
    }
}
