using VContainer;
using VContainer.Unity;
using UnityEngine;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] private TriggerEn triggerEn;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private EnemyWay enemyWay;

    protected override void Configure(IContainerBuilder builder)
    {
        // Регистрируем существующие на сцене MonoBehaviour-компоненты
        if (triggerEn != null)
        {
            builder.RegisterComponent(triggerEn);
            Debug.Log("TriggerEn зарегистрирован в контейнере");
        }
        else
        {
            Debug.LogError("triggerEn не назначен в инспекторе!");
        }

        if (playerController != null)
        {
            builder.RegisterComponent(playerController);
            Debug.Log("PlayerController зарегистрирован в контейнере");
        }
        else
        {
            Debug.LogError("playerController не назначен в инспекторе!");
        }

        if (enemyWay != null)
        {
            builder.RegisterComponent(enemyWay);
            Debug.Log("EnemyWay зарегистрирован в контейнере");
        }
        else
        {
            Debug.LogError("enemyWay не назначен в инспекторе!");
        }
    }
}
