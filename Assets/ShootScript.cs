using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    RaycastHit _Hit;
    public float _Range;
    public int _CurrentAmmo;
    public int _MaxAmmo = 20;
    public int _BackupAmmo=200;
    public int _Damage = 35;
    public GameObject _Crosshair;
    public LayerMask Enemies;
    // Start is called before the first frame update
    void Start()
    {
        Reload();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.transform.position, transform.parent.forward, out _Hit, _Range,Enemies))
            {
                print(_Hit.collider.gameObject);
                if (_Hit.collider.GetComponent<Health>())
                {
                    _Hit.collider.GetComponent<Health>().Takedamage(_Damage);
                    ShowHitMarker();
                }

            }
            _CurrentAmmo--;
        }
        _CurrentAmmo =Mathf.Clamp(_CurrentAmmo, 0, _MaxAmmo);
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(Camera.main.transform.position, transform.parent.forward * _Range);
    }
    void Reload() 
    {
        _CurrentAmmo = _MaxAmmo;
        _BackupAmmo -= _MaxAmmo;
    }

    void ShowHitMarker()
    {
        _Crosshair.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(HitmarkTimer());

    }
    void HideHitmarker()
    {
        _Crosshair.SetActive(false);
    }
    IEnumerator HitmarkTimer()
    {
        yield return new WaitForSeconds(0.2f);
        HideHitmarker();

    }
}
