using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    private List<GameObject> list = new List<GameObject>();
    private Dictionary<GameObject, Bullet> dict = new Dictionary<GameObject, Bullet>();

    [SerializeField] GameObject prefab;
    [SerializeField] Transform parent;

    public static Pooling instance;

    private void Start()
    {
        instance = this;
    }

    public Bullet Spawn(Vector3 pos, Quaternion rot)
    {
        GameObject go = null;

        for (int i = 0; i < list.Count; i++)
        {
            if (!list[i].activeInHierarchy)
            {
                go = list[i];
                break;
            }
        }

        if (go == null)
        {
            go = GameObject.Instantiate(prefab, parent);
            list.Add(go);
            dict.Add(go, go.GetComponent<Bullet>());
        }

        go.transform.SetPositionAndRotation(pos, rot);
        go.SetActive(true);

        return dict[go];
    }
}
