using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Text Puan;
    public float yatayCarpani = 2;
    public float dikeySisme = 3;
    public int Skor;

    private void Start()
    {
        Skor = PlayerPrefs.GetInt("Skor");
        Puan.text = Skor.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Elmas"))
        {
            other.gameObject.SetActive(false);
            Skor = Skor + 10;
            Puan.text = Skor.ToString();

            PlayerPrefs.SetInt("Skor", Skor);
            PlayerPrefs.Save();
        }


        if (other.gameObject.CompareTag("Uzat"))
        {
            other.gameObject.SetActive(false);
            transform.localScale = new Vector3(
                transform.localScale.x,
                transform.localScale.y + dikeySisme,
                transform.localScale.z);
        }

        if (other.gameObject.CompareTag("Genislet"))
        {
            other.gameObject.SetActive(false);
            transform.localScale = new Vector3(
                transform.localScale.x + yatayCarpani,
                transform.localScale.y,
                transform.localScale.z + yatayCarpani);
        }

        if (other.gameObject.CompareTag("Kisalt"))
        {
            other.gameObject.SetActive(false);
            transform.localScale = new Vector3(
                transform.localScale.x,
                transform.localScale.y - dikeySisme,
                transform.localScale.z);
        }

        if (other.gameObject.CompareTag("Daralt"))
        {
            other.gameObject.SetActive(false);
            transform.localScale = new Vector3(
                transform.localScale.x - yatayCarpani,
                transform.localScale.y,
                transform.localScale.z - yatayCarpani);
        }
    }
}