using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{

    bool _isAlive = true;

    [SerializeField]
    UI_Manager _uimanager;

    public SceneChanger _changeScene;

    [SerializeField]
    float _health = 100f;
    [SerializeField]
    float _stemina = 100f;
    float _maxStemina = 100f;

    [SerializeField]
    float _time = 0f;


    // Start is called before the first frame update
    void Start()
    {
        _uimanager.SetMaxHealth(_health+10);
        _uimanager.SetHealth(_health);
        _uimanager.SetMaxStemina(_maxStemina);
        _uimanager.SetStemina(_stemina);
        _uimanager.SetTime(_time);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
            _stemina -= Time.deltaTime*5;
        else if (_stemina < _maxStemina)
            _stemina += Time.deltaTime * 5;

        _uimanager.SetStemina(_stemina);

        _time += Time.deltaTime;
        _uimanager.SetTime(_time);

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "Fire")
        {
            if (_health > 0)
                _health -= 1;
            else
            {
                _isAlive = false;
                Debug.Log("Game Over");
                Destroy(gameObject);
                _changeScene.ChangeSceneByName_asdf("MainMenuScene");
            }
            _uimanager.SetHealth(_health);

        }


    }


}
