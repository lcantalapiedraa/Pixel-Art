using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject HeroKnight;
    void Update()
    {
        Vector3 position = transform.position;
        position.x = HeroKnight.transform.position.x;
        position.y = HeroKnight.transform.position.y;
        transform.position = position;
    }
}
