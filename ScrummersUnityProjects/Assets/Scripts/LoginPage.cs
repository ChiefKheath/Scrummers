using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginPage : MonoBehaviour
{
    [SerializeField] private TMP_InputField emailField;
    [SerializeField] private TMP_InputField passwordField;
    [SerializeField] private GameObject validateText;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Login")
        {
            validateText.SetActive(false);
        }
    }

    public void Login()
    {
        CheckFields();
    }

    private void CheckFields()
    {
        if(emailField.text != "" && passwordField.text != "")
        {
            PlayerPrefs.SetInt("LoggedIn", 1);

            SceneManager.LoadScene("Product Page");
        }
        else
        {
            validateText.SetActive(true);
        }
    }

    public void Logout()
    {
        PlayerPrefs.SetInt("LoggedIn", 0);
        SceneManager.LoadScene("Login");
    }

    public void StaffScene()
    {
        SceneManager.LoadScene("Staff Portal");
    }
}
