using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class HeadCollisionDetector : MonoBehaviour
{
    [SerializeField, Range(0, 0.5f)] private float _detectionDelay = 0.05f;
    [SerializeField] private float _detectionDistance = 0.2f;
    [SerializeField] private LayerMask _detectionLayers;

    public List<RaycastHit> DetectedColliderHits {get; private set;}

    [SerializeField] private float _currentTime = 0f;

    //Gets the direction of the mask that was hit by the players head collider
    private List<RaycastHit> PreformDetection(Vector3 position, float distance, LayerMask mask)
    {
        List<RaycastHit> detectedHits = new();

        List<Vector3> directions = new() {transform.forward, transform.right, -transform.right};

        RaycastHit; foreach(var dir in directions)
        {
            if(Physics.Raycast(position, dir, out detectedHits, distance, mask))
            {
                detectedHits.Add(hit);
            }
        }
        return detectedHits;
    }
}
