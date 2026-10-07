using UnityEngine;

public class PlayerHeadCollider : MonoBehaviour
{
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

    private void update()
    {
        if (_detector.DetectedColliderHits.count <= 0)
        return;

        Vector3 pushBackDir = CalculatePushBackDirection();

        _characterController.Move(pushBackDir.normalized * pushBackStrength * Time.deltaTime);
    }

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
