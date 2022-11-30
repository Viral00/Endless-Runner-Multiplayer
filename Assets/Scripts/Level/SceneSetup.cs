using UnityEngine;

[ExecuteInEditMode]
public class SceneSetup : MonoBehaviour
{
    public GameObject palnePrefab;
    [SerializeField]private bool execute;
    [SerializeField] private float sizeX, sizeZ;

    private GameObject parent;

    private void Update()
    {
        if (execute)
        {
            SetupScene();
            execute = false;
        }
    }
    private void SetupScene()
    {
        if(parent != null)
        {
            DestroyImmediate(gameObject);
        }

        parent = new GameObject("Parent");

        for(int i= 0; i < sizeX; i++)
        {
            for(int j=0; j<sizeZ; j++)
            {
                GameObject go = Instantiate(palnePrefab, new Vector3(i * 10, 0, j * 10), Quaternion.identity);
                go.transform.parent = parent.transform;
                go.name = string.Format("Ground(0,1):", i, j);
            }
        }
    }

}
