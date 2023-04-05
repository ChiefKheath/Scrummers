using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginPage : MonoBehaviour
{
    [SerializeField] private TMP_InputField emailField;
    [SerializeField] private TMP_InputField passwordField;
    [SerializeField] private TMP_InputField registerEmail;
    [SerializeField] private TMP_InputField registerPassword;
    [SerializeField] private TMP_InputField registerConfPassword;
    [SerializeField] private TMP_InputField registerPhoneNo;
    [SerializeField] private GameObject validateText;
    [SerializeField] private GameObject registerValidateText;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Login")
        {
            validateText.SetActive(false);
            registerValidateText.SetActive(false);
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

    public void LoginScene()
    {
        SceneManager.LoadScene("Login");
    }

    public void Register()
    {
        if(registerEmail.text != "" && registerPassword.text != "" && registerConfPassword.text != "" && registerPhoneNo.text != "")
        {
            PlayerPrefs.SetInt("LoggedIn", 1);
            SceneManager.LoadScene("Product Page");
        }
        else
        {
            registerValidateText.SetActive(true);
        }
    }
}
