using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject _Target;
    public float _FireRate;
    public GameObject _BulletPrefab;
    public float _BulletSpeed;
    public int _BulletDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(_FireRate);
    }

    public void ShootTimer()
    {
        StopAllCoroutines();
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {

        print("shoot");
        Bullet _Bullet = Instantiate(_BulletPrefab, transform.position, Quaternion.identity).GetComponent <Bullet>();
        _Bullet._Speed = _BulletSpeed;
        _Bullet._BulletDamage = _BulletDamage;
        _Bullet.transform.LookAt(_Target.transform);
        yield return new WaitForSeconds(_FireRate);
        ShootTimer();
        
    }
}
