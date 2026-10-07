using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.XR;

public class PlayerHeadCollider : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] float pushBackStrength;
    [SerializeField] private Detector _detector;

    // checks to see if the players head has hit anything by using a raycast against the mask of an obj
    private List<RaycastHit> PreformDetection
        (Vector3 Position, float distance, LayerMask mask)
    {
        List<RaycastHit> allHits = new();

        List<Vector3> directions 
        = new() {transform.forward, transform.right, -transform.right};

        RaycastHit hit;
        foreach (var dir in directions)
        {
            if(Physics.Raycast(Position, dir, out hit, distance, mask))
            {
                allHits.Add(hit);
            }
        }
    }

    //Checks to see if the player had hit any colliders, if the player gets pushed back calls CaculatePushBackDirection()
    private void update()
    {
        if (_detector.DetectedColliderHits.count <= 0)
        return;

        Vector3 pushBackDir = CalculatePushBackDirection();

        _characterController.Move(pushBackDir.normalized * pushBackStrength * Time.deltaTime);
    }
    // Pushes the player's head back on collision with a wall
    private Vector3 CaculatePushBackDirection()
    {
        Vector3 combinedNormal = Vector3.Zero;
        foreach (var hitpoint in _detector.DetectedColliderHits)
        {
            combinedNormal += new Vector3(hitpoint.normal.x, 0, hitpoint.normal.z);
        }
        return combinedNormal;
    }
}
