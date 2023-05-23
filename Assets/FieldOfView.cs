using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float _Angle = 45;
    public float _Range = 10;
    public LayerMask _TargetLayer;
    public GameObject[] _Targets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("Player").Length; i++)
        {
            _Targets = GameObject.FindGameObjectsWithTag("Player");
        }

        for (int i = 0; i < _Targets.Length; i++)
        {
            GameObject t = _Targets[i];
            RaycastHit _Hit;
            if(Physics.Raycast(transform.position, t.transform.position - transform.position,out _Hit, _Range, _TargetLayer))
            {
                if (Mathf.Abs(Vector3.Angle(t.transform.position - transform.position, transform.forward) - 180) < _Angle)
                {
                    print(" Hit");
                    FollowTarget _Ft = GetComponent<FollowTarget>();
                    _Ft.StartFollowing();
                    _Ft.enabled = true;
                    _Ft._Target = t;
                    GetComponent<WayPoint>().enabled = false;
                    this.enabled = false;
                }
            }
            
            
            
            
        }
        


    }
    private void OnDrawGizmos()
    {
        for (int i = 0; i < _Targets.Length; i++)
        {
            Gizmos.DrawRay(transform.position,Vector3.Normalize( _Targets[i].transform.position - transform.position)*_Range);
        }
        Gizmos.DrawRay(transform.position, Quaternion.AngleAxis (_Angle,-transform.up )*-transform.forward * _Range);
        Gizmos.DrawRay(transform.position, Quaternion.AngleAxis (-_Angle,-transform.up )*-transform.forward * _Range);
        
    }
}
