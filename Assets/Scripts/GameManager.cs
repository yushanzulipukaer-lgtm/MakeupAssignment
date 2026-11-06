using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private FruitFactory fruitFactory;
    private void Start()
    {
        SpawnFruit();
    }
    public void SpawnFruit()
    {
        Fruit fruit = fruitFactory.SpawnFruit();
    }
}
