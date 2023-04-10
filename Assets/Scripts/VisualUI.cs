using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VisualUI : MonoBehaviour
{
    //Singleton
    static VisualUI instance;
    public static VisualUI Get()
    {
        return instance;
    }

    private void Awake()
    {
        instance = this;
    }

    [SerializeField]
    private TextMeshProUGUI modeText;

    [SerializeField]
    private TextMeshProUGUI eggText;

    [SerializeField]
    private TextMeshProUGUI enemyCountText;
    [SerializeField]
    private TextMeshProUGUI enemyDestroyedText;
    [SerializeField]
    private TextMeshProUGUI collisionsText;

    public void setMode(bool usingMouse)
    {
        string text = "Hero Mode: ";

        if (usingMouse) {
            text += "Mouse";
        } else
        {
            text += "Keyboard";
        }

        modeText.text = text;
    }

    int eggCount;
    public void increaseEgg()
    {
        eggCount++;
        updateEggText();
    }
    public void decreaseEgg()
    {
        eggCount--;
        updateEggText();
    }

    int enemyCount;
    int enemyDestroyed;
    int collisions;

    public void onCollision()
    {
        collisions++;
    }
    public void OnDestroyEnemy()
    {
        enemyCount--;
        enemyDestroyed++;
        updateEnemyText();
    }
    public void OnSpawnEnemy()
    {
        enemyCount++;
        updateEnemyText();
    }

    void updateEnemyText()
    {
        enemyCountText.text = "Enemy Count: " + enemyCount;
        enemyDestroyedText.text = "Enemies Destroyed: " + enemyDestroyed;
        collisionsText.text = "Collisions: " + collisions;
    }
    void updateEggText()
    {
        string text = "Egg Amount: ";
        text += eggCount;
        eggText.text = text;
    }
    // Start is called before the first frame update
    void Start()
    {
        updateEggText();
        updateEnemyText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
