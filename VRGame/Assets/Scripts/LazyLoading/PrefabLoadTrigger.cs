using UnityEngine;
using UnityEngine.Events;

public class PrefabLoadTrigger : MonoBehaviour
{
    [Header("Prefab Settings")]
    [SerializeField] private GameObject _areaPrefab;
    [SerializeField] private GameObject _previousAreaPrefab;
    [SerializeField] private Transform _prefabSpawnPoint;
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private GameObject _LoadedAreaInstance;

    [Header("Lazy Doors")]
    [SerializeField] private UnityEvent _doorTrigger;

    [Header("Bools")]
    [SerializeField] private bool _isPrefabExisting;

    private void OnButtonPress()
    {
        if(CompareTag(playerTag) && _LoadedAreaInstance == null)
        {
            if(_isPrefabExisting == true)
            {
                return;
            }
            Vector3 position = _prefabSpawnPoint != null ? _prefabSpawnPoint.position : transform.position;
            Quaternion rotation = _prefabSpawnPoint != null ? _prefabSpawnPoint.rotation : Quaternion.identity;

            _LoadedAreaInstance = Instantiate(_areaPrefab, position, rotation);

            _isPrefabExisting = true;
        }
    }

    private void InstantiateChecker()
    {
        
    }

}
