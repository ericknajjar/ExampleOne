using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Update()
    {

        var list = new List<int>();
        var toAddNext = new List<int>();

        for (int i = 0; i < 1000; ++i)
        {
            int val = UnityEngine.Random.Range(0, 20000);
            int valNext = UnityEngine.Random.Range(0, 20000);
            toAddNext.Add(valNext);
            list.Add(val);

        }

        int max = ReturnMax(list, toAddNext);

        Debug.LogFormat("Max {0} ", max);
    }


    public int ReturnMax(List<int> list, List<int> next)
    {
        // 1 - Adiciona o novo elemento a coleção
        // 2 - Remove o Maior element da coleção
        // 3 - Retorna o maior elemento presente na coleção ao final
        for (int i = 0; i < next.Count; ++i)
        {
            var toAdd = next[i];
            list.Add(toAdd);
            list.Sort();
            list.RemoveAt(list.Count - 1);
        }

        return list[list.Count - 1];
    }
}
