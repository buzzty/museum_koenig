using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.Video;

public class GameLogic : MonoBehaviour
{
    /// Object References


    public GameObject browser;
    public GameObject chatFrontpage;
    public GameObject explorerFrontpage;
    public GameObject newsFrontpage;
    public GameObject instaPicFrontpage;
    public GameObject myTubeVidOne;
    public GameObject myTubeVidTwo;
    public GameObject myTubeVidThree;
    public GameObject myTubeVidFour;
    public GameObject articleOne;
    public GameObject articleTwo;
    public GameObject articleThree;
    public GameObject articleFour;
    public GameObject articleFive;
    public GameObject articleSix;
    public GameObject newsAccessPage;
    public GameObject instaPicAccessPage;
    public GameObject myTubeAccessPage;
    public GameObject quizAccessPage;
    public GameObject quizTaskOne;
    public GameObject quizTaskTwo;
    public GameObject quizTaskThree;
    public GameObject quizTaskFour;
    public GameObject quizEndScreen;
    public GameObject explorerAccessPage;
    public GameObject infoScreenOne;
    public GameObject infoScreenTwo;
    public GameObject infoScreenThree;
    public GameObject infoScreenFour;
    public GameObject infoScreenFive;
    public GameObject infoScreenSix;
    public GameObject infoScreenSeven;
    public GameObject infoScreenEight;
    public GameObject infoScreenOneHandle;
    public GameObject infoScreenTwoHandle;
    public GameObject infoScreenThreeHandle;
    public GameObject infoScreenFourHandle;
    public GameObject infoScreenFiveHandle;
    public GameObject infoScreenSixHandle;
    public GameObject infoScreenSevenHandle;
    public GameObject infoScreenEightHandle;
    public GameObject explorerPicOne;
    public GameObject explorerPicTwo;
    public GameObject explorerPicThree;
    public GameObject explorerPicFour;
    public GameObject explorerPicFive;
    public GameObject explorerPicSix;
    public GameObject explorerPicSeven;
    public GameObject explorerPicEight;
    public GameObject explorerPicNine;
    public GameObject chatAccessPage;
    public GameObject schoolChatAccessPage;
    public GameObject chatKim;
    public GameObject chatProfMisof;
    public GameObject chatMichelle;
    public GameObject chatHippoline;
    public GameObject chatSchoolChat;
    public GameObject chatFussballChat;
    public GameObject calendar;
    public GameObject callScreenOne;
    public GameObject callScreenTwo;
    public GameObject tinderGame;
    public GameObject tinderAnswerScreen;
    public GameObject playVideoOne;
    public GameObject playVideoTwo;
    public GameObject playVideoFour;
    public GameObject pauseVideoOne;
    public GameObject pauseVideoTwo;
    public GameObject pauseVideoFour;
    public GameObject adBlockPage;
    public GameObject quizFourHigher;
    public GameObject thumbnailOne;
    public GameObject thumbnailTwo;
    public GameObject thumbnailFour;
    public GameObject quizOneAnswer;
    public GameObject quizTwoAnswer;
    public GameObject quizThreeAnswer;
    public GameObject quizFourAnswer;
    public GameObject chatBeforeCall;
    public GameObject chatAfterCall;


    public Image newsDotA;
    public Image newsDotB;
    public Image newsDotC;
    public Image sliderOneColor;
    public Image sliderTwoColor;
    public Image sliderThreeColor;
    public Image sliderFourColor;
    public Image laptopLoginButton;
    public Image sliderTaskTwo;
    public Image sliderTaskFour;


    public Slider sliderOne;
    public Slider sliderTwo;
    public Slider sliderThree;
    public Slider sliderFour;
    public Slider sliderQuizTaskTwo;
    public Slider sliderQuizTaskFour;


    public VideoPlayer videoPlayerOne;
    public VideoPlayer videoPlayerTwo;
    public VideoPlayer videoPlayerFour;

    public AudioSource audioPlayer;


    public AudioClip misofCallOne;
    public AudioClip misofCallTwo;


    public TMP_InputField loginOne;
    public TMP_InputField loginTwo;
    public TMP_InputField loginThree;
    public TMP_InputField loginFour;
    public TMP_InputField loginChatOne;
    public TMP_InputField loginChatTwo;
    public TMP_InputField loginChatThree;
    public TMP_InputField loginChatFour;
    public TMP_InputField loginFussballOne;
    public TMP_InputField loginFussballTwo;
    public TMP_InputField loginFussballThree;
    public TMP_InputField loginFussballFour;


    public TextMeshProUGUI percentTextTaskTwo;
    public TextMeshProUGUI percentTextTaskFour;
    public TextMeshProUGUI quizTwoWrong;
    public TextMeshProUGUI quizFourWrong;




    /// Button References



    public Button browserButton;
    public Button chatButton;
    public Button explorerButton;
    public Button newsButtonA;
    public Button newsButtonB;
    public Button newsButtonC;
    public Button captchaAnswerOne;
    public Button captchaAnswerTwo;
    public Button captchaAnswerThree;
    public Button passwordOneUp;
    public Button passwordOneDown;
    public Button passwordTwoUp;
    public Button passwordTwoDown;
    public Button passwordThreeUp;
    public Button passwordThreeDown;
    public Button callMisof;



    /// Variables



    public bool articleActive = false;
    public bool newsAccess = false;
    public bool instaPicAccess = false;
    public bool myTubeAccess = false;
    public bool quizAccess = false;
    public bool quizAccessOpen = false;
    public bool quizOneCorrect = false;
    public bool quizTwoCorrect = false;
    public bool quizThreeCorrect = false;
    public bool quizFourCorrect = false;
    public bool allQuizCorrect = false;
    public bool quizExplorerCorrect = false;
    public bool explorerAccess = false;
    public bool infoScreenActive = false;
    public bool laptopAccess = false;
    public bool chatPasswordCorrect = false;
    public bool schoolChatOpen = false;
    public bool schoolChatAccess = false;
    public bool audioOneStarted = false;
    public bool audioTwoStarted = false;
    public bool videoOneStarted = false;
    public bool videoTwoStarted = false;
    public bool videoFourStarted = false;
    public bool adAccessGranted = false;
    public bool ubongoDone = false;
    public bool fussballChatOpen = false;
    public bool ubongoCorrect = false;


    public int rightCaptchaAnswers = 0;
    public int wrongCaptchaAnswers = 0;
    public int quizOneCorrectAnswers;
    public int quizOneAnswersGiven;
    public int quizThreeCorrectAnswers;
    public int quizThreeAnswersGiven;
    public int quizExplorerCorrectAnswers;
    public int quizExplorerAnswersGiven;
    public int activePasswordOne;
    public int activePasswordTwo;
    public int activePasswordThree;
    public int cardsSwiped = 0;
    public int myTubeAnswersGiven;
    public int myTubeCorrectAnswers;


    public string loginOneInput;
    public string loginTwoInput;
    public string loginThreeInput;
    public string loginFourInput;
    public string loginChatOneInput;
    public string loginChatTwoInput;
    public string loginChatThreeInput;
    public string loginChatFourInput;
    public string loginFussballOneInput;
    public string loginFussballTwoInput;
    public string loginFussballThreeInput;
    public string loginFussballFourInput;




    /// Lists and Arrays



    public Button[] captchaButtons;

    public ButtonColor[] captchaButtonList;

    public GameObject[] passwordAnswersOne;
    public GameObject[] passwordAnswersTwo;
    public GameObject[] passwordAnswersThree;



    /// Methods and Logic



    private void Start()
    {
        newsButtonA.onClick.AddListener(NewsAOnClick);
        newsButtonB.onClick.AddListener(NewsBOnClick);
        newsButtonC.onClick.AddListener(NewsCOnClick);

        passwordOneUp.onClick.AddListener(ChangePasswordOneUp);
        passwordOneDown.onClick.AddListener(ChangePasswordOneDown);
        passwordTwoUp.onClick.AddListener(ChangePasswordTwoUp);
        passwordTwoDown.onClick.AddListener(ChangePasswordTwoDown);
        passwordThreeUp.onClick.AddListener(ChangePasswordThreeUp);
        passwordThreeDown.onClick.AddListener(ChangePasswordThreeDown);

        for (int i = 0; i < passwordAnswersOne.Length; i++)
        {
            passwordAnswersOne[i].SetActive(false);
        }

        activePasswordOne = 0;

        passwordAnswersOne[0].SetActive(true);

        for (int i = 0; i < passwordAnswersTwo.Length; i++)
        {
            passwordAnswersTwo[i].SetActive(false);
        }

        activePasswordTwo = 0;

        passwordAnswersTwo[0].SetActive(true);

        for (int i = 0; i < passwordAnswersThree.Length; i++)
        {
            passwordAnswersThree[i].SetActive(false);
        }

        activePasswordThree = 0;

        passwordAnswersThree[0].SetActive(true);
    }

    private void Update()
    {
        if (ubongoCorrect)
        {
            myTubeCorrectAnswers++;
            StartCoroutine(AdBlockDone());
            ubongoCorrect = false;
        }

        if (quizAccessOpen)
        {
            loginOne.Select();
            quizAccessOpen = false;
        }

        if (schoolChatOpen)
        {
            loginChatOne.Select();
            schoolChatOpen = false;
        }

        loginChatOneInput = loginChatOne.text;
        loginChatTwoInput = loginChatTwo.text;
        loginChatThreeInput = loginChatThree.text;

        loginOneInput = loginOne.text;
        loginTwoInput = loginTwo.text;
        loginThreeInput = loginThree.text;
        loginFourInput = loginFour.text;


        if (!string.IsNullOrEmpty(loginOneInput) && string.IsNullOrEmpty(loginTwoInput) && string.IsNullOrEmpty(loginThreeInput) && string.IsNullOrEmpty(loginFourInput))
        {
            loginTwo.Select();
        }
        if (!string.IsNullOrEmpty(loginTwoInput) && string.IsNullOrEmpty(loginThreeInput) && string.IsNullOrEmpty(loginFourInput))
        {
            loginThree.Select();
        }
        if (!string.IsNullOrEmpty(loginThreeInput) && string.IsNullOrEmpty(loginFourInput))
        {
            loginFour.Select();
        }


        if (!string.IsNullOrEmpty(loginChatOneInput) && string.IsNullOrEmpty(loginChatTwoInput) && string.IsNullOrEmpty(loginChatThreeInput))
        {
            loginChatTwo.Select();
        }
        if (!string.IsNullOrEmpty(loginChatTwoInput) && string.IsNullOrEmpty(loginChatThreeInput))
        {
            loginChatThree.Select();
        }

        percentTextTaskTwo.text = sliderQuizTaskTwo.value + "%";

        percentTextTaskFour.text = sliderQuizTaskFour.value.ToString();

        //Debug.Log(audioPlayer.time);

        if (audioOneStarted)
        {
            if (audioPlayer.isPlaying)
            {
                Debug.Log("Call One Playing");

                if (audioPlayer.time > 18f)
                {
                    Debug.Log("Call One Stopped");
                    audioPlayer.Stop();
                    chatBeforeCall.SetActive(false);
                    chatAfterCall.SetActive(true);
                    callScreenOne.SetActive(false);
                    tinderGame.SetActive(true);
                    audioOneStarted = false;
                }
                else
                {
                    return;
                }
            }
        }

        if (audioTwoStarted)
        {
            if (audioPlayer.isPlaying)
            {
                Debug.Log("Call Two Playing");
            }
            else
            {
                Debug.Log("Call Two Stopped");
                callScreenTwo.SetActive(false);
                tinderGame.SetActive(false);
                audioTwoStarted = false;
                chatProfMisof.SetActive(true);
                callMisof.interactable = false;
            }
        }

        if (cardsSwiped == 8)
        {
            tinderAnswerScreen.SetActive(true);
        }

        if (videoPlayerOne.isPlaying)
        {
            //Debug.Log("Video One Playing");
            playVideoOne.SetActive(false);
            pauseVideoOne.SetActive(true);
        }
        else
        {
            //Debug.Log("Video One Stopped");
            playVideoOne.SetActive(true);
            pauseVideoOne.SetActive(false);
        }

        if (videoPlayerTwo.isPlaying)
        {
            //Debug.Log("Video Two Playing");
            pauseVideoTwo.SetActive(true);
            playVideoTwo.SetActive(false);
        }
        else
        {
            //Debug.Log("Video Two Stopped");
            playVideoTwo.SetActive(true);
            pauseVideoTwo.SetActive(false);
        }

        if (videoPlayerFour.isPlaying)
        {
            //Debug.Log("Video Four Playing");
            playVideoFour.SetActive(false);
            pauseVideoFour.SetActive(true);
        }
        else
        {
            //Debug.Log("Video Four Stopped");
            playVideoFour.SetActive(true);
            pauseVideoFour.SetActive(false);
        }

        if (ubongoDone == true)
        {
            adAccessGranted = true;
        }
    }

    public void CloseWindow()
    {
        videoPlayerOne.Stop();
        videoPlayerTwo.Stop();
        videoPlayerFour.Stop();
        browser.SetActive(false);
        chatFrontpage.SetActive(false);
        chatAccessPage.SetActive(false);
        explorerFrontpage.SetActive(false);
        explorerAccessPage.SetActive(false);
        newsFrontpage.SetActive(false);
        newsAccessPage.SetActive(false);
        instaPicFrontpage.SetActive(false);
        instaPicAccessPage.SetActive(false);
        myTubeAccessPage.SetActive(false);
        quizTaskOne.SetActive(false);
        quizTaskTwo.SetActive(false);
        quizTaskThree.SetActive(false);
        quizTaskFour.SetActive(false);
        quizAccessPage.SetActive(false);
        quizEndScreen.SetActive(false);
        videoPlayerOne.Stop();
        myTubeVidOne.SetActive(false);
        myTubeVidTwo.SetActive(false);
        myTubeVidThree.SetActive(false);
        myTubeVidFour.SetActive(false);
        chatKim.SetActive(false);
        chatSchoolChat.SetActive(false);
        calendar.SetActive(false);
        adBlockPage.SetActive(false);
        myTubeAccessPage.SetActive(false);
        tinderGame.SetActive(false);
        tinderAnswerScreen.SetActive(false);

        articleOne.SetActive(false);
        articleTwo.SetActive(false);
        articleThree.SetActive(false);
        articleFour.SetActive(false);
        articleFive.SetActive(false);
        articleSix.SetActive(false);

        browserButton.interactable = true;
        chatButton.interactable = true;
        explorerButton.interactable = true;

        audioPlayer.Stop();

        if (!quizOneCorrect)
        {
            quizOneCorrectAnswers = 0;
            quizOneAnswersGiven = 0;
        }

        if (!quizThreeCorrect)
        {
            quizThreeCorrectAnswers = 0;
            quizThreeAnswersGiven = 0;
        }
    }

    public void ArticleBackButton()
    {
        if (articleActive)
        {
            articleOne.SetActive(false);
            articleTwo.SetActive(false);
            articleThree.SetActive(false);
            articleFour.SetActive(false);
            articleFive.SetActive(false);
            articleSix.SetActive(false);
            newsFrontpage.SetActive(true);

            articleActive = false;
        }
    }

    public void OpenBrowser()
    {
        browser.SetActive(true);
        browserButton.interactable = false;
        chatButton.interactable = false;
        explorerButton.interactable = false;
    }

    public void OpenChat()
    {
        chatFrontpage.SetActive(true);
        chatProfMisof.SetActive(true);
        browserButton.interactable = false;
        chatButton.interactable = false;
        explorerButton.interactable = false;
    }


    public void ChatBackButton()
    {
        if (chatAccessPage.activeSelf)
        {
            chatAccessPage.SetActive(false);
            browserButton.interactable = true;
            chatButton.interactable = true;
            explorerButton.interactable = true;
        }
        else if (chatFrontpage.activeSelf)
        {
            chatFrontpage.SetActive(false);
            browserButton.interactable = true;
            chatButton.interactable = true;
            explorerButton.interactable = true;
        }
    }

    public void OpenExplorer()
    {
        if (explorerAccess == false)
        {
            explorerAccessPage.SetActive(true);
            browserButton.interactable = false;
            chatButton.interactable = false;
            explorerButton.interactable = false;
        }
        else
        {
            if (explorerFrontpage.activeSelf == false)
            {
                explorerFrontpage.SetActive(true);
                browser.SetActive(false);
                browserButton.interactable = false;
                chatButton.interactable = false;
                explorerButton.interactable = false;
            }
        }
    }

    public void ExplorerBackButton()
    {
        if (explorerFrontpage.activeSelf)
        {
            explorerFrontpage.SetActive(false);
            browserButton.interactable = true;
            chatButton.interactable = true;
            explorerButton.interactable = true;
        }

        if (explorerAccessPage.activeSelf)
        {
            explorerAccessPage.SetActive(false);
            browserButton.interactable = true;
            chatButton.interactable = true;
            explorerButton.interactable = true;
        }
    }

    public void OpenNewsFrontpage()
    {
        if (newsAccess == false)
        {
            newsAccessPage.SetActive(true);
            browserButton.interactable = false;
            chatButton.interactable = false;
            explorerButton.interactable = false;
        }
        else
        {
            if (newsFrontpage.activeSelf == false)
            {
                newsFrontpage.SetActive(true);
                browserButton.interactable = false;
                chatButton.interactable = false;
                explorerButton.interactable = false;
            }
        }
    }

    public void NewsBackButton()
    {
        newsAccessPage.SetActive(false);
        newsFrontpage.SetActive(false);
        browser.SetActive(true);
    }

    private void NewsAOnClick()
    {
        Debug.Log("ButtonA");
        newsDotA.transform.DOShakePosition(1f, 10f, 10, 20f, true, true);
    }

    private void NewsBOnClick()
    {
        StartCoroutine(NewsAccessGranted());
    }

    private void NewsCOnClick()
    {
        Debug.Log("ButtonC");
        newsDotC.transform.DOShakePosition(1f, 10f, 10, 20f, true, true);
    }

    public void OpenInstaPicFrontpage()
    {
        if (instaPicAccess == false)
        {
            instaPicAccessPage.SetActive(true);
            browser.SetActive(false);
        }
        else
        {
            if (instaPicFrontpage.activeSelf == false)
            {
                instaPicFrontpage.SetActive(true);
                browser.SetActive(false);
                browserButton.interactable = false;
                chatButton.interactable = false;
                explorerButton.interactable = false;
            }
        }
    }

    public void InstaPicAccessBackButton()
    {
        instaPicAccessPage.SetActive(false);
        browser.SetActive(true);
    }

    public void InstaPicBackButton()
    {
        instaPicFrontpage.SetActive(false);
        browser.SetActive(true);
    }

    public void OpenMyTubeFrontpage()
    {
        if (myTubeAccess == false)
        {
            myTubeAccessPage.SetActive(true);
            browser.SetActive(false);
        }
        else
        {
            if (myTubeVidOne.activeSelf == false)
            {
                myTubeVidOne.SetActive(true);
                browser.SetActive(false);
                browserButton.interactable = false;
                chatButton.interactable = false;
                explorerButton.interactable = false;
            }
        }
    }

    public void OpenMyTube()
    {
        myTubeAccess = true;
        myTubeAccessPage.SetActive(false);
        myTubeVidOne.SetActive(true);
    }

    public void MyTubeAccessPageBackButton()
    {
        myTubeAccessPage.SetActive(false);
        browser.SetActive(true);
    }

    public void PlayMyTubeVideoOne()
    {
        audioPlayer.volume = 0.1f;
        videoPlayerOne.GameObject().SetActive(true);
        videoPlayerOne.Play();
        videoOneStarted = true;
        thumbnailOne.SetActive(false);
    }

    public void PlayMyTubeVideoTwo()
    {
        audioPlayer.volume = 0.2f;
        videoPlayerTwo.GameObject().SetActive(true);
        videoPlayerTwo.Play();
        videoTwoStarted = true;
        thumbnailTwo.SetActive(false);
    }

    public void PlayMyTubeVideoFour()
    {
        audioPlayer.volume = 0.2f;
        videoPlayerFour.GameObject().SetActive(true);
        videoPlayerFour.Play();
        videoFourStarted = true;
        thumbnailFour.SetActive(false);
    }

    public void PauseMyTubeVideoOne()
    {
        videoPlayerOne.Pause();
        videoOneStarted = false;
    }

    public void PauseMyTubeVideoTwo()
    {
        videoPlayerTwo.Pause();
        videoTwoStarted = false;
    }

    public void PauseMyTubeVideoFour()
    {
        videoPlayerFour.Pause();
        videoFourStarted = false;
    }

    public void MyTubeBackButton()
    {
        videoPlayerOne.Stop();
        videoPlayerTwo.Stop();
        videoPlayerFour.Stop();

        myTubeAccessPage.SetActive(false);

        myTubeVidOne.SetActive(false);
        myTubeVidTwo.SetActive(false);
        myTubeVidThree.SetActive(false);
        myTubeVidFour.SetActive(false);

        adBlockPage.SetActive(false);

        browser.SetActive(true);
    }

    public void LoadVideoHotel()
    {
        videoPlayerOne.Stop();
        videoPlayerTwo.Stop();
        videoPlayerFour.Stop();
        videoPlayerTwo.GameObject().SetActive(false);
        videoPlayerFour.GameObject().SetActive(false);
        myTubeVidOne.SetActive(true);
        myTubeVidTwo.SetActive(false);
        myTubeVidThree.SetActive(false);
        myTubeVidFour.SetActive(false);
        thumbnailOne.SetActive(true);
    }

    public void LoadVideoSumm()
    {
        videoPlayerOne.Stop();
        videoPlayerTwo.Stop();
        videoPlayerFour.Stop();

        if (!adAccessGranted)
        {
            myTubeVidOne.SetActive(false);
            myTubeVidThree.SetActive(false);
            myTubeVidFour.SetActive(false);
            adBlockPage.SetActive(true);
        }
        else
        {
            myTubeVidOne.SetActive(false);
            myTubeVidThree.SetActive(false);
            myTubeVidFour.SetActive(false);
            videoPlayerOne.GameObject().SetActive(false);
            videoPlayerFour.GameObject().SetActive(false);
            myTubeVidTwo.SetActive(true);
            thumbnailTwo.SetActive(true);
        }
    }

    public void LoadVideoMassnahmen()
    {
        videoPlayerOne.Stop();
        videoPlayerTwo.Stop();
        videoPlayerFour.Stop();
        myTubeVidOne.SetActive(false);
        myTubeVidTwo.SetActive(false);
        myTubeVidFour.SetActive(false);
        myTubeVidThree.SetActive(true);
    }

    public void LoadVideoLecker()
    {
        videoPlayerOne.Stop();
        videoPlayerTwo.Stop();
        videoPlayerFour.Stop();
        videoPlayerOne.GameObject().SetActive(false);
        videoPlayerTwo.GameObject().SetActive(false);
        myTubeVidOne.SetActive(false);
        myTubeVidTwo.SetActive(false);
        myTubeVidThree.SetActive(false);
        myTubeVidFour.SetActive(true);
        thumbnailFour.SetActive(true);
    }

    public void OpenQuizTaskOne()
    {
        if (quizAccess == true)
        {
            if (!quizOneCorrect && !quizTwoCorrect && !quizThreeCorrect && !quizFourCorrect)
            {
                if (quizTaskOne.activeSelf == false)
                {
                    quizTaskOne.SetActive(true);
                    browser.SetActive(false);
                    browserButton.interactable = false;
                    chatButton.interactable = false;
                    explorerButton.interactable = false;
                }
            }
            else if (quizOneCorrect && !quizTwoCorrect && !quizThreeCorrect && !quizFourCorrect)
            {
                if (quizTaskTwo.activeSelf == false)
                {
                    quizTaskTwo.SetActive(true);
                    browser.SetActive(false);
                    browserButton.interactable = false;
                    chatButton.interactable = false;
                    explorerButton.interactable = false;
                }
            }
            else if (quizOneCorrect && quizTwoCorrect && !quizThreeCorrect && !quizFourCorrect)
            {
                if (quizTaskThree.activeSelf == false)
                {
                    quizTaskThree.SetActive(true);
                    browser.SetActive(false);
                    browserButton.interactable = false;
                    chatButton.interactable = false;
                    explorerButton.interactable = false;
                }
            }
            else if (quizOneCorrect && quizTwoCorrect && quizThreeCorrect && !quizFourCorrect)
            {
                if (quizTaskFour.activeSelf == false)
                {
                    quizTaskFour.SetActive(true);
                    browser.SetActive(false);
                    browserButton.interactable = false;
                    chatButton.interactable = false;
                    explorerButton.interactable = false;
                }
            }
            else if (quizOneCorrect && quizTwoCorrect && quizThreeCorrect && quizFourCorrect)
            {
                if (quizEndScreen.activeSelf == false)
                {
                    quizEndScreen.SetActive(true);
                    browser.SetActive(false);
                    browserButton.interactable = false;
                    chatButton.interactable = false;
                    explorerButton.interactable = false;
                }
            }
            else if (allQuizCorrect)
            {
                browser.SetActive(false);
                quizEndScreen.SetActive(true);
            }
        }
        else
        {
            browser.SetActive(false);
            quizAccessOpen = true;
            quizAccessPage.SetActive(true);
        }
    }

    public void QuizBackButton()
    {
        if (quizTaskOne.activeSelf)
        {
            quizTaskOne.SetActive(false);
            browser.SetActive(true);
        }
        else if (quizTaskTwo.activeSelf)
        {
            quizTaskTwo.SetActive(false);
            browser.SetActive(true);
        }
        else if (quizTaskThree.activeSelf)
        {
            quizTaskThree.SetActive(false);
            browser.SetActive(true);
        }
        else if (quizTaskFour.activeSelf)
        {
            quizTaskFour.SetActive(false);
            browser.SetActive(true);
        }
        else if (quizAccessPage.activeSelf)
        {
            quizAccessPage.SetActive(false);
            browser.SetActive(true);
        }
        else if (quizEndScreen.activeSelf)
        {
            quizEndScreen.SetActive(false);
            browser.SetActive(true);
        }
    }

    public void OpenArticleOne()
    {
        newsFrontpage.SetActive(false);
        articleOne.SetActive(true);

        articleActive = true;
    }

    public void OpenArticleTwo()
    {
        newsFrontpage.SetActive(false);
        articleTwo.SetActive(true);

        articleActive = true;
    }

    public void OpenArticleThree()
    {
        newsFrontpage.SetActive(false);
        articleThree.SetActive(true);

        articleActive = true;
    }

    public void OpenArticleFour()
    {
        newsFrontpage.SetActive(false);
        articleFour.SetActive(true);

        articleActive = true;
    }

    public void OpenArticleFive()
    {
        newsFrontpage.SetActive(false);
        articleFive.SetActive(true);

        articleActive = true;
    }

    public void OpenArticleSix()
    {
        newsFrontpage.SetActive(false);
        articleSix.SetActive(true);

        articleActive = true;
    }

    public void CaptchaAnswerRight()
    {
        rightCaptchaAnswers ++;
    }

    public void CaptchaAnswerWrong()
    {
        wrongCaptchaAnswers ++;
    }

    public void CaptchaLogic()
    {
        if (rightCaptchaAnswers == 3 && wrongCaptchaAnswers == 0)
        {
            StartCoroutine(CaptchaAccessGranted());
        }
        else
        {
            foreach (var i in captchaButtonList)
            {
                i.gameObject.GetComponent<ButtonColor>().isPressed = false;
            }

            StartCoroutine(CaptchaAccessDenied());
        }
    }

    public void QuizAccessCheck()
    {
        if (loginOneInput == "1" && loginTwoInput == "9" && loginThreeInput == "1" && loginFourInput == "2")
        {
            Debug.Log("Pin correct!");
            quizAccessPage.SetActive(false);
            quizAccess = true;
            quizTaskOne.SetActive(true);
        }
        else
        {
            loginOne.text = null;
            loginTwo.text = null;
            loginThree.text = null;
            loginFour.text = null;
            loginOne.Select();
            Debug.Log("Pin incorrect, try again!");
        }
    }

    public void QuizTaskTwoCheck()
    {
        if (sliderQuizTaskTwo.value is <= -59 and >= -79)
        {
            StartCoroutine(QuizTaskTwoCorrect());
        }

        if (sliderQuizTaskTwo.value > -59)
        {
            Debug.Log("lower");
            StartCoroutine(QuizTwoAnswerWrong());
        }

        if (sliderQuizTaskTwo.value < -79)
        {
            Debug.Log("higher");
            StartCoroutine(QuizTwoAnswerWrong());
        }
    }

    public void QuizTaskFourCheck()
    {
        if (sliderQuizTaskFour.value is <= 1050000 and >= 950000)
        {
            StartCoroutine(QuizTaskFourCorrect());
        }

        if (sliderQuizTaskFour.value < 950000)
        {
            StartCoroutine(QuizFourAnswerWrong());
        }

        if (sliderQuizTaskFour.value > 1050000)
        {
            StartCoroutine(QuizFourAnswerWrong());
        }
    }

    public void QuizContinueButton()
    {
        if (quizOneAnswer.activeSelf)
        {
            quizOneAnswer.SetActive(false);
            quizTaskTwo.SetActive(true);
        }

        if (quizTwoAnswer.activeSelf)
        {
            quizTwoAnswer.SetActive(false);
            quizTaskThree.SetActive(true);
        }

        if (quizThreeAnswer.activeSelf)
        {
            quizThreeAnswer.SetActive(false);
            quizTaskFour.SetActive(true);
        }

        if (quizFourAnswer.activeSelf)
        {
            quizFourAnswer.SetActive(false);
            quizEndScreen.SetActive(true);
        }
    }

    public void OpenExplorerPicOne()
    {
        explorerPicOne.SetActive(true);
    }

    public void OpenExplorerPicTwo()
    {
        explorerPicTwo.SetActive(true);
    }

    public void OpenExplorerPicThree()
    {
        explorerPicThree.SetActive(true);
    }

    public void OpenExplorerPicFour()
    {
        explorerPicFour.SetActive(true);
    }

    public void OpenExplorerPicFive()
    {
        explorerPicFive.SetActive(true);
    }

    public void OpenExplorerPicSix()
    {
        explorerPicSix.SetActive(true);
    }

    public void OpenExplorerPicSeven()
    {
        explorerPicSeven.SetActive(true);
    }

    public void OpenExplorerPicEight()
    {
        explorerPicEight.SetActive(true);
    }

    public void OpenExplorerPicNine()
    {
        explorerPicNine.SetActive(true);
    }

    public void CloseExplorerPicOne()
    {
        explorerPicOne.SetActive(false);
    }

    public void CloseExplorerPicTwo()
    {
        explorerPicTwo.SetActive(false);
    }

    public void CloseExplorerPicThree()
    {
        explorerPicThree.SetActive(false);
    }

    public void CloseExplorerPicFour()
    {
        explorerPicFour.SetActive(false);
    }

    public void CloseExplorerPicFive()
    {
        explorerPicFive.SetActive(false);
    }

    public void CloseExplorerPicSix()
    {
        explorerPicSix.SetActive(false);
    }

    public void CloseExplorerPicSeven()
    {
        explorerPicSeven.SetActive(false);
    }

    public void CloseExplorerPicEight()
    {
        explorerPicEight.SetActive(false);
    }

    public void CloseExplorerPicNine()
    {
        explorerPicNine.SetActive(false);
    }

    public void ChangePasswordOneUp()
    {
        if (activePasswordOne < passwordAnswersOne.Length -1)
        {
            passwordAnswersOne[activePasswordOne].SetActive(false);
            activePasswordOne++;
            passwordAnswersOne[activePasswordOne].SetActive(true);
        }
        else if (passwordAnswersOne[2].activeSelf)
        {
            passwordAnswersOne[activePasswordOne].SetActive(false);
            activePasswordOne = 0;
            passwordAnswersOne[activePasswordOne].SetActive(true);
        }
    }

    public void ChangePasswordOneDown()
    {
        if (activePasswordOne <= passwordAnswersOne.Length -1 && activePasswordOne > 0)
        {
            passwordAnswersOne[activePasswordOne].SetActive(false);
            activePasswordOne--;
            passwordAnswersOne[activePasswordOne].SetActive(true);
        }
        else if (passwordAnswersOne[0].activeSelf)
        {
            passwordAnswersOne[activePasswordOne].SetActive(false);
            activePasswordOne = 2;
            passwordAnswersOne[activePasswordOne].SetActive(true);
        }
    }

    public void ChangePasswordTwoUp()
    {
        if (activePasswordTwo < passwordAnswersTwo.Length -1)
        {
            passwordAnswersTwo[activePasswordTwo].SetActive(false);
            activePasswordTwo++;
            passwordAnswersTwo[activePasswordTwo].SetActive(true);
        }
        else if (passwordAnswersOne[2].activeSelf)
        {
            passwordAnswersTwo[activePasswordTwo].SetActive(false);
            activePasswordTwo = 0;
            passwordAnswersTwo[activePasswordTwo].SetActive(true);
        }
    }

    public void ChangePasswordTwoDown()
    {
        if (activePasswordTwo <= passwordAnswersTwo.Length -1 && activePasswordTwo > 0)
        {
            passwordAnswersTwo[activePasswordTwo].SetActive(false);
            activePasswordTwo--;
            passwordAnswersTwo[activePasswordTwo].SetActive(true);
        }
        else if (passwordAnswersTwo[0].activeSelf)
        {
            passwordAnswersTwo[activePasswordTwo].SetActive(false);
            activePasswordTwo = 2;
            passwordAnswersTwo[activePasswordTwo].SetActive(true);
        }
    }

    public void ChangePasswordThreeUp()
    {
        if (activePasswordThree < passwordAnswersThree.Length -1)
        {
            passwordAnswersThree[activePasswordThree].SetActive(false);
            activePasswordThree++;
            passwordAnswersThree[activePasswordThree].SetActive(true);
        }
        else if (passwordAnswersThree[2].activeSelf)
        {
            passwordAnswersThree[activePasswordThree].SetActive(false);
            activePasswordThree = 0;
            passwordAnswersThree[activePasswordThree].SetActive(true);
        }
    }

    public void ChangePasswordThreeDown()
    {
        if (activePasswordThree <= passwordAnswersThree.Length -1 && activePasswordThree > 0)
        {
            passwordAnswersThree[activePasswordThree].SetActive(false);
            activePasswordThree--;
            passwordAnswersThree[activePasswordThree].SetActive(true);
        }
        else if (passwordAnswersThree[0].activeSelf)
        {
            passwordAnswersThree[activePasswordThree].SetActive(false);
            activePasswordThree = 2;
            passwordAnswersThree[activePasswordThree].SetActive(true);
        }
    }

    public void CheckPasswordChat()
    {
        if (activePasswordOne == 2 && activePasswordTwo == 1 && activePasswordThree == 2)
        {
            StartCoroutine(LaptopAccessGranted());
        }
        else
        {
            StartCoroutine(LaptopAccessDenied());
        }
    }

    public void OpenChatKim()
    {
        chatKim.SetActive(true);
        chatProfMisof.SetActive(false);
        chatMichelle.SetActive(false);
        chatHippoline.SetActive(false);
        chatSchoolChat.SetActive(false);
        chatFussballChat.SetActive(false);
    }

    public void OpenChatProfMisof()
    {
        chatKim.SetActive(false);
        chatProfMisof.SetActive(true);
        chatMichelle.SetActive(false);
        chatHippoline.SetActive(false);
        chatSchoolChat.SetActive(false);
        chatFussballChat.SetActive(false);
    }

    public void OpenChatMichelle()
    {
        chatKim.SetActive(false);
        chatProfMisof.SetActive(false);
        chatMichelle.SetActive(true);
        chatHippoline.SetActive(false);
        chatSchoolChat.SetActive(false);
        chatFussballChat.SetActive(false);
    }

    public void OpenChatHippoline()
    {
        chatKim.SetActive(false);
        chatProfMisof.SetActive(false);
        chatMichelle.SetActive(false);
        chatHippoline.SetActive(true);
        chatSchoolChat.SetActive(false);
        chatFussballChat.SetActive(false);
    }

    public void OpenChatSchoolChat()
    {
        if (!schoolChatAccess)
        {
            chatKim.SetActive(false);
            chatProfMisof.SetActive(false);
            chatMichelle.SetActive(false);
            chatHippoline.SetActive(false);
            chatFussballChat.SetActive(false);
            chatSchoolChat.SetActive(true);
            schoolChatAccessPage.SetActive(true);
            schoolChatOpen = true;
        }
        else
        {
            chatKim.SetActive(false);
            chatProfMisof.SetActive(false);
            chatMichelle.SetActive(false);
            chatHippoline.SetActive(false);
            chatSchoolChat.SetActive(true);
            chatFussballChat.SetActive(false);
        }
    }

    public void OpenChatFussballChat()
    {
        chatKim.SetActive(false);
        chatProfMisof.SetActive(false);
        chatMichelle.SetActive(false);
        chatHippoline.SetActive(false);
        chatSchoolChat.SetActive(false);
        chatFussballChat.SetActive(true);
        fussballChatOpen = true;
    }

    public void CheckLoginChat()
    {
        if (loginChatOneInput == "8" && loginChatTwoInput == "0" && loginChatThreeInput == "3")
        {
            Debug.Log("Pin correct!");
            schoolChatAccessPage.SetActive(false);
            chatSchoolChat.SetActive(true);
            schoolChatOpen = true;
            schoolChatAccess = true;
        }
        else
        {
            loginChatOne.text = null;
            loginChatTwo.text = null;
            loginChatThree.text = null;
            loginChatFour.text = null;
            loginChatOne.Select();
            Debug.Log("Pin incorrect, try again!");
        }
    }


    public void CheckLoginChatTwo()
    {
        if (loginChatOneInput != null && loginChatTwoInput != null && loginChatThreeInput != null && loginChatFourInput != null)
        {
            loginFussballOne.text = null;
            loginFussballTwo.text = null;
            loginFussballThree.text = null;
            loginFussballFour.text = null;
            loginFussballOne.Select();
            Debug.Log("Pin incorrect, try again!");
        }
    }

    public void OpenChats()
    {
        chatFrontpage.SetActive(true);
        calendar.SetActive(false);
    }

    public void OpenCalendar()
    {
        chatFrontpage.SetActive(false);
        calendar.SetActive(true);
    }

    public void StartCallOne()
    {
        audioPlayer.volume = 1f;
        chatProfMisof.SetActive(false);
        callScreenOne.SetActive(true);
        audioPlayer.clip = misofCallOne;
        audioOneStarted = true;
        audioPlayer.Play();
    }

    public void StartCallTwo()
    {
        audioPlayer.volume = 1f;
        tinderAnswerScreen.SetActive(false);
        chatProfMisof.SetActive(false);
        callScreenTwo.SetActive(true);
        audioPlayer.clip = misofCallTwo;
        audioTwoStarted = true;
        audioPlayer.Play();
    }

    public void EndCallOne()
    {
        audioPlayer.Stop();
        callScreenOne.SetActive(false);
        chatProfMisof.SetActive(true);
    }

    public void EndCallTwo()
    {
        audioPlayer.Stop();
        callScreenTwo.SetActive(false);
        chatProfMisof.SetActive(true);
    }



    /// Coroutines



    IEnumerator NewsAccessGranted()
    {
        Debug.Log("ButtonB");
        newsDotB.transform.DOScale(3f, 1f);
        newsDotB.DOFade(0f, 1);

        yield return new WaitForSeconds(1f);

        newsAccess = true;
        newsAccessPage.SetActive(false);
        newsFrontpage.SetActive(true);
    }

    IEnumerator CaptchaAccessGranted()
    {
        foreach (var button in captchaButtons)
        {
            button.GetComponent<Image>().color = Color.green;
        }

        yield return new WaitForSeconds(1f);

        instaPicAccess = true;
        instaPicAccessPage.SetActive(false);
        instaPicFrontpage.SetActive(true);
    }

    IEnumerator CaptchaAccessDenied()
    {
        foreach (var button in captchaButtons)
        {
            button.GetComponent<Image>().DOColor(Color.red, 1f);
        }

        yield return new WaitForSeconds(0.2f);

        foreach (var button in captchaButtons)
        {
            button.GetComponent<Image>().DOColor(Color.white, 1f);
        }


        rightCaptchaAnswers = 0;
        wrongCaptchaAnswers = 0;
    }

    IEnumerator MyTubeAccessGranted()
    {
        myTubeAccess = true;

        sliderOne.interactable = false;
        sliderTwo.interactable = false;
        sliderThree.interactable = false;
        sliderFour.interactable = false;

        sliderOneColor.color = Color.green;
        sliderTwoColor.color = Color.green;
        sliderThreeColor.color = Color.green;
        sliderFourColor.color = Color.green;

        Debug.Log("Sliders in right position!");

        yield return new WaitForSeconds(1.5f);

        myTubeAccessPage.SetActive(false);
        myTubeVidOne.SetActive(true);
    }

    IEnumerator QuizTwoAnswerWrong()
    {
        if (sliderQuizTaskTwo.value is >= -100 and <= -80)
        {
            quizTwoWrong.text = "Versuche es etwas höher";
            quizTwoWrong.gameObject.SetActive(true);
            yield return new WaitForSeconds(1.5f);
        }

        if (sliderQuizTaskTwo.value is >= -58 and <= 0)
        {
            quizTwoWrong.text = "Versuche es etwas niedriger";
            quizTwoWrong.gameObject.SetActive(true);
            yield return new WaitForSeconds(1.5f);
        }

        if (sliderQuizTaskTwo.value is >= 1 and <= 100)
        {
            quizTwoWrong.text = "Versuche es deutlich niedriger";
            quizTwoWrong.gameObject.SetActive(true);
            yield return new WaitForSeconds(1.5f);
        }
    }

    IEnumerator QuizFourHigher()
    {
        quizFourHigher.SetActive(true);
        yield return new WaitForSeconds(1f);
        quizFourHigher.SetActive(false);
    }

    IEnumerator LaptopAccessGranted()
    {
        laptopLoginButton.transform.DOScale(1.2f, 0.5f);
        laptopLoginButton.DOFade(1f, 1f);
        yield return new WaitForSeconds(1f);

        Debug.Log("Password correct!");
        laptopAccess = true;
        chatAccessPage.SetActive(false);
        browserButton.interactable = true;
        chatButton.interactable = true;
        explorerButton.interactable = true;
    }

    IEnumerator LaptopAccessDenied()
    {
        Debug.Log("Password wrong!");
        laptopLoginButton.transform.DOShakePosition(1f, 10f, 10, 20f, true, true);
        yield return new WaitForSeconds(0.1f);
    }

    IEnumerator QuizTaskTwoCorrect()
    {
        quizTwoWrong.gameObject.SetActive(false);
        Debug.Log("Correct answer!");
        sliderTaskTwo.color = Color.green;
        yield return new WaitForSeconds(1.5f);
        quizTwoCorrect = true;
        quizTaskTwo.SetActive(false);
        quizTwoAnswer.SetActive(true);
    }

    IEnumerator QuizTaskFourCorrect()
    {
        quizFourWrong.gameObject.SetActive(false);
        Debug.Log("Correct answer!");
        quizFourWrong.text = "Richtige Antwort!";
        sliderTaskFour.color = Color.green;
        yield return new WaitForSeconds(1.5f);
        quizFourCorrect = true;
        quizTaskFour.SetActive(false);
        quizFourAnswer.SetActive(true);
        allQuizCorrect = true;
    }

    IEnumerator QuizFourAnswerWrong()
    {
        if (sliderQuizTaskFour.value is >= 1049999 and <= 1500000)
        {
            quizFourWrong.text = "Versuche es etwas niedriger";
            quizFourWrong.gameObject.SetActive(true);
            yield return new WaitForSeconds(1.5f);
        }

        if (sliderQuizTaskFour.value is >= 500001 and <= 949999)
        {
            quizFourWrong.text = "Versuche es etwas höher";
            quizFourWrong.gameObject.SetActive(true);
            yield return new WaitForSeconds(1.5f);
        }

        if (sliderQuizTaskFour.value is >= 0 and <= 500000)
        {
            quizFourWrong.text = "Versuche es deutlich höher";
            quizFourWrong.gameObject.SetActive(true);
            yield return new WaitForSeconds(1.5f);
        }
    }

    IEnumerator AdBlockDone()
    {
        yield return new WaitForSeconds(1.8f);
        ubongoDone = true;
        adBlockPage.SetActive(false);
        myTubeVidTwo.SetActive(true);
    }
}
