// using UnityEngine;
// using System.Collections.Generic;
// using System.Collections;

// public class HeadCollisionDetector : MonoBehaviour
// {
//     [SerializeField, Range(0, 0.5f)] private float _detectionDelay = 0.05f;
//     [SerializeField] private float _detectionDistance = 0.2f;
//     [SerializeField] private LayerMask _detectionLayers;

//     public List<RaycastHit> DetectedColliderHits {get; private set;}

//     [SerializeField] private float _currentTime = 0f;

//     //Gets the direction of the mask that was hit by the players head collider
//     private List<RaycastHit> PreformDetection(Vector3 position, float distance, LayerMask mask)
//     {
//         List<RaycastHit> detectedHits = new();

//         List<Vector3> directions = new() {transform.forward, transform.right, -transform.right};

//         RaycastHit; foreach(var dir in directions)
//         {
//             if(Physics.Raycast(position, dir, out detectedHits, distance, mask))
//             {
//                 detectedHits.Add(hit);
//             }
//         }
//         return detectedHits;
//     }

//     //Allows the detection to be made from start
//     private void Start()
//     {
//         DetectedColliderHits = PreformDetectionDetection(transform.position, _detectionDistance, _detectionLayers);
//     }

//     //Adds a delay to the collision and well as reseting the time when a collision is detected
//     void Update()
//     {
//         _currentTime += _currentTime.deltaTime;
//         if(_currentTime > _detectionDelay)
//         {
//             _currentTime = 0;
//             DetectedColliderHits = PreformDetection(transform.position, _detectionDistance, _detectionLayers);
//         }
//     }

//     private void OnDrawGizmos()
//     {
//         if(Application.isPlaying == false)
//         return;

//         Color c = Color.green;
//         c.a = 0.5f;
//         if(DetectedColliderHits.Count > 0)
//         {
//             c = Color.red;
//             c.a = 0.5f;
//         }

//         Gizmos.color = c;
//         Gizmos.DrawWireSphere(transform.position, _detectionDistance);

//         List<Vector3> directions = new() {transform.forward, transform.right, -transform.right};
//         Gizmos.color = Color.magenta;
//         foreach(var dir in directions)
//         {
//             Gizmos.DrawRay(transform.position, dir);
//         }
//     }
// }
