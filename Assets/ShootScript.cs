using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    private RaycastHit _Hit;
    public float _Range; //This sets the range of the players gun.
    public int _CurrentAmmo; //This sets the amount of ammo that the player currently has.
    public int _MaxAmmo = 20; // his sets the amount of max ammo that the plyer can have.
    public int _BackupAmmo = 200; //This sets the amount of backup ammo that the player has
    public int _Damage = 35; //This sets the amount of max damage that the player weapon does.
    public GameObject _Crosshair;
    public LayerMask Enemies;
    private bool _IsReloading = false;
    public Animator _Animator;
    public ParticleSystem _Particle;
    public AudioSource _Source;

    // Start is called before the first frame update
    private void Start()
    {
        Reload();
        Cursor.lockState = CursorLockMode.Locked;
        _Source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!_IsReloading)
        {
            if (Input.GetMouseButtonDown(0) && _CurrentAmmo > 0)
            {
                //This creates a forward Ray from the player camera position forward for a certain _Range.
                if (Physics.Raycast(Camera.main.transform.position, transform.parent.forward, out _Hit, _Range, Enemies))
                {
                    print(_Hit.collider.gameObject);
                    if (_Hit.collider.GetComponent<Health>())
                    {
                        _Hit.collider.GetComponent<Health>().Takedamage(_Damage);
                        ShowHitMarker();
                    }
                }
                _CurrentAmmo--;
                _Particle.Play();
                _Source.Play();
            }
            if (Input.GetKeyDown(KeyCode.R) && _CurrentAmmo < _MaxAmmo && _BackupAmmo > 0)
            {
                _IsReloading = true;
                _Animator.SetTrigger("ReloadTrigger");
            }
        }

        _CurrentAmmo = Mathf.Clamp(_CurrentAmmo, 0, _MaxAmmo);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(Camera.main.transform.position, transform.parent.forward * _Range);
    }

    //When the reload is called, it sets the currentAmmo back to the maxAmmo. The amount of max ammo gets taken off from the backuAmmo
    private void Reload()
    {
        if (_BackupAmmo >= _MaxAmmo)
        {
            _BackupAmmo += -_MaxAmmo + _CurrentAmmo;
            _CurrentAmmo = _MaxAmmo;
        }
        else
        {
            _CurrentAmmo = _BackupAmmo;
            _BackupAmmo = 0;
        }
    }

    public void ReloadEnd()
    {
        _IsReloading = false;
        Reload();
    }

    //This function shows a hitmarker when nthe plaer shoots an hits the Target (Enemy)
    private void ShowHitMarker()
    {
        _Crosshair.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(HitmarkTimer());
    }

    //This deactivates the hitmarker (sets it to false) after a certain amount of time.
    private void HideHitmarker()
    {
        _Crosshair.SetActive(false);
    }

    private IEnumerator HitmarkTimer()
    {
        yield return new WaitForSeconds(0.2f);
        HideHitmarker();
    }
}