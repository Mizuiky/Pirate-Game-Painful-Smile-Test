using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsPanel : MonoBehaviour
{
    [HideInInspector]
    public float gameSessionTime;

    [HideInInspector]
    public float enemySpawnTime;

    [SerializeField]
    private OptionsSlider[] _sliders;

    public void OnEnablePanel(bool enable)
    {

        if (!enable)
        {
            SetGameSessionTime();
            SetEnemySpawnTime();

        }

        gameObject.SetActive(enable);
    }

    public void Init()
    {
        foreach(OptionsSlider slider in _sliders)
        {
            slider.Init();

            SetGameSessionTime();
            SetEnemySpawnTime();
        }
    }

    private void SetGameSessionTime()
    {
        gameSessionTime = _sliders[0]._currentTime;
    }

    private void SetEnemySpawnTime()
    {
        enemySpawnTime = _sliders[1]._currentTime;
    }
}
