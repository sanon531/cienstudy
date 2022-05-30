using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public List<Transform> _patrolList = new List<Transform>();
    public Transform _currentTarget ;
    public Rigidbody _rigidbody;
    public int _patrolNum = 0;

    public float _cycletime = 1;
    public float _lastCycletime = -1;
    public float _speed = 1f;

    private void Update()
    {
        if (Vector3.Distance(_patrolList[_patrolNum].position, transform.position) < 0.25f 
            || (Time.time -_lastCycletime) > _cycletime) 
        {
            _lastCycletime = Time.time;
            _patrolNum ++ ;
            if (_patrolList.Count < (_patrolNum +1))
                _patrolNum = 0; 
            _currentTarget = _patrolList[_patrolNum];


        }
        transform.position = Vector3.MoveTowards(transform.position, _patrolList[_patrolNum].position, _speed * Time.deltaTime);
    }

}
