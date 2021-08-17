using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
    public string Generator(int len)
    {
        string res = string.Empty;
        for (int i = 0; i < len; i++)
        {
            int maxroll = chars.Length;
            char random = chars[Random.Range(0, maxroll)];
            res += random.ToString();
            
        }
        return res;
    }
}
