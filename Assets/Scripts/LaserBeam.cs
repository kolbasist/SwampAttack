using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam : MonoBehaviour
{
    [SerializeField] private int _defaultDamage;
    [SerializeField] private float _speed;
    [SerializeField] private int _maxStrickenCount;
    [SerializeField] private float _lifeTime = 3f;
 
    private int _strickenCount = 0;
    private float _chargeValue;

    private int _damage => _defaultDamage + (int)_chargeValue;

    private void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
            _strickenCount++;
            if (_strickenCount >= _maxStrickenCount)
                Destroy(gameObject);
        }       
    }

    public void SetCharge (float charge)
    {
        _chargeValue = charge;
        Debug.Log("Damage: " + _damage);
    }
}
