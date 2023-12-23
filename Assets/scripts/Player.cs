using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    [SerializeField] public int _health;
    [SerializeField] public int _dirt;
    [SerializeField] public ParticleSystem dirtParticles;
    [SerializeField] public ParticleSystem washParticles;
    [SerializeField] public ParticleSystem deathParticles;
    [SerializeField] public ParticleSystem foodParticles;
    [SerializeField] public GameObject imageObject1;
    [SerializeField] public GameObject imageObject2;
    [SerializeField] public GameObject imageObject3;
    public float _timer = 0f;
    public float _interval = 1f;
    public void Start()
    {
        _health = 100;
        _dirt = 100;
    }
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _interval)
        {
            _health--;
            _dirt--;
            _timer = 0f;
            if (_health<=30)
            {
                imageObject1.SetActive(true);
            }
            if (_dirt <= 30)
            {
                Dirt();
                imageObject2.SetActive(true);
            }
            if (_health <= 0 || _dirt <= 0)
            {
                Destroy();
                imageObject3.SetActive(true);
            }
        }
    }
    public void TakeFood(int heal)
    {
        if (_health + heal <= 115)
        {
            _health += heal;
        }
        else { _health = 115; }
        Foods();
    }
    public void TakeWash(int wash)
    {
        if (_dirt + wash <= 115)
        {
            _dirt += wash;
        }
        else { _dirt = 115; }
        Washs();
    }
    public void Destroy()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(imageObject1);
        Destroy(imageObject2);

    }
    public void Foods()
    {
        Instantiate(foodParticles, transform.position, Quaternion.identity);
    }
    public void Dirt()
    {
        Instantiate(dirtParticles, transform.position, Quaternion.identity);
    }
    public void Washs()
    {
        Instantiate(washParticles, transform.position, Quaternion.identity);
    }
}
