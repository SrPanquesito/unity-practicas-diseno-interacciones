using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prac5 : MonoBehaviour
{
    int[] nums1 = new int[] {12,345,2,6,7896,23};
    int[] nums2 = new int[] {1,2,4,2,1};

    // Start is called before the first frame update
    void Start()
    {
        int prob1 = elementosNumParDigitos(nums1);
        Debug.Log("Elementos que contienen un número par de digitos: " + prob1);

        int prob2 = elementoUnico(nums2);
        Debug.Log("Elemento único en el arreglo: " + prob2);
    }

    public int elementosNumParDigitos(int[] nums)
    {
        int cElems = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            string elem = nums[i].ToString();
            int par = elem.Length % 2;
            if (par == 0) cElems++;
        }

        return cElems;
    }

    // Regresa -1 si no hay elemento unico
    public int elementoUnico(int[] nums)
    {
        int elem = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            elem = nums[i];
            for (int c = 0; c < nums.Length; c++)
            {
                if (elem == nums[c]) count++;
                if (count == 2) {
                    count = 0;
                    break;
                }
            }
            if (count == 1) break;
        }

        if (count == 0) return -1;

        return elem;
    }
}
