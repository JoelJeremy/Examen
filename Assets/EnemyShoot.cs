using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    GameObject _Target;
    public float _FireRate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShootTimer()
    {
        StopAllCoroutines();
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {

        print("shoot");
        yield return new WaitForSeconds(_FireRate);
        ShootTimer();
        
    }
}
