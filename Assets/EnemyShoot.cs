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
        //The FireRate is being printed with this code. This allows you to clearly see what the current enemyFireRate is.
        print(_FireRate);
    }

    // this function Creates a timer for the enemy. The enemies dont have to reload. hereby a timer is created. This creates a loop with Start Shoot and stop shoot.
    public void ShootTimer()
    {
        //This stops the enemy shoot function.
        StopAllCoroutines();
        // This restarts the enemy shoot function.
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        //This prints shoot everytime the enemy shoots a bullet.
        print("shoot");

        //his spawns a bullet everytime the enemies shoot script (Component) is activates
        Bullet _Bullet = Instantiate(_BulletPrefab, transform.position, Quaternion.identity).GetComponent<Bullet>();

        // This sets _Bullet._Speed to the variable _Bulletspeed.
        _Bullet._Speed = _BulletSpeed;

        //This sets the _BulletDamage from the Bullet Script to the _Bullet Damage of thhe EnemyShoot script.
        _Bullet._BulletDamage = _BulletDamage;

        //This actiavtes the bullet when the enemy looks at the Target. In this case the Player.
        _Bullet.transform.LookAt(_Target.transform);

        //This is siogned to the Shooting timer also known as  the FireRrate.
        yield return new WaitForSeconds(_FireRate);
        ShootTimer();
        
    }
}
