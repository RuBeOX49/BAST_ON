using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    #region parameters
    [SerializeField]
    private float _speedMovement = 1f;
    #endregion

    #region properties
    private Vector3 _movementDirection = Vector3.zero;
    private Transform _myTransform;
    #endregion

    #region methods
    public void SetMovementDirection(float direction)
    {
        _movementDirection.x = direction;
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        _myTransform.Translate(_movementDirection * _speedMovement * Time.deltaTime);
        _movementDirection = Vector3.zero;
    }
}
