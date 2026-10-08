using UnityEngine;
using TMPro;

public class GoalArea : MonoBehaviour
{
    public GameObject clearTextUI; // インスペクターでUIをアタッチ
    public AudioSource audioSource;
    public GameObject DestroyPlayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("すり抜けた");
            if (clearTextUI != null)
            {
                clearTextUI.SetActive(true); // ゴールしたらUIを表示
            }
            Destroy(DestroyPlayer);
        }
    }
}
