using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBull.Cores
{
    public class PersistentObject : MonoBehaviour
    {
        [SerializeField] GameObject persistentPrefab;

        static bool _isPersistentObjectCreated = true;
        private void Start()
        {
            if (_isPersistentObjectCreated)
            {
                SpawnPersistentObjects();
                _isPersistentObjectCreated = false;
            }
        }

        private void SpawnPersistentObjects()
        {
            GameObject newPersistentObject = Instantiate(persistentPrefab);
            DontDestroyOnLoad(newPersistentObject);
        }
    }

}
