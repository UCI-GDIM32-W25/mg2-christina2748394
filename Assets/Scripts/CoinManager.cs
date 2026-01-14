using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private TextMeshProUGUI coinText;
    private Vector3 position = new Vector3(15, 14, -0.1f);
    private float waitTime;
    private float Timer = 0f;
    public int coinCount = 0;

    void Start()
    {
        waitTime = Random.Range(0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        SpawnCoin();

    }

    void SpawnCoin()
    {
        if (Timer >= waitTime)
        {
            Instantiate(coinPrefab, position, Quaternion.identity);
            Timer = 0f;
            waitTime = Random.Range(0.5f, 2f);
        }
    }

    public void AddCoin()
    {
        coinCount++;
        coinText.text = coinCount.ToString();
    }


}
