using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplorerIcons : MonoBehaviour
{
    public GameLogic gameLogic;
    public int id;

    public void OpenInfoScreen()
    {
        if (id == 1)
        {
            gameLogic.infoScreenOne.SetActive(true);
            gameLogic.infoScreenTwo.SetActive(false);
            gameLogic.infoScreenThree.SetActive(false);
            gameLogic.infoScreenFour.SetActive(false);
            gameLogic.infoScreenFive.SetActive(false);
            gameLogic.infoScreenSix.SetActive(false);
            gameLogic.infoScreenSeven.SetActive(false);
            gameLogic.infoScreenEight.SetActive(false);
            gameLogic.infoScreenOneHandle.SetActive(false);
            gameLogic.infoScreenActive = true;
        }
        else if (id == 2)
        {
            gameLogic.infoScreenOne.SetActive(false);
            gameLogic.infoScreenTwo.SetActive(true);
            gameLogic.infoScreenThree.SetActive(false);
            gameLogic.infoScreenFour.SetActive(false);
            gameLogic.infoScreenFive.SetActive(false);
            gameLogic.infoScreenSix.SetActive(false);
            gameLogic.infoScreenSeven.SetActive(false);
            gameLogic.infoScreenEight.SetActive(false);
            gameLogic.infoScreenTwoHandle.SetActive(false);
            gameLogic.infoScreenActive = true;
        }
        else if (id == 3)
        {
            gameLogic.infoScreenOne.SetActive(false);
            gameLogic.infoScreenTwo.SetActive(false);
            gameLogic.infoScreenThree.SetActive(true);
            gameLogic.infoScreenFour.SetActive(false);
            gameLogic.infoScreenFive.SetActive(false);
            gameLogic.infoScreenSix.SetActive(false);
            gameLogic.infoScreenSeven.SetActive(false);
            gameLogic.infoScreenEight.SetActive(false);
            gameLogic.infoScreenThreeHandle.SetActive(false);
            gameLogic.infoScreenActive = true;
        }
        else if (id == 4)
        {
            gameLogic.infoScreenOne.SetActive(false);
            gameLogic.infoScreenTwo.SetActive(false);
            gameLogic.infoScreenThree.SetActive(false);
            gameLogic.infoScreenFour.SetActive(true);
            gameLogic.infoScreenFive.SetActive(false);
            gameLogic.infoScreenSix.SetActive(false);
            gameLogic.infoScreenSeven.SetActive(false);
            gameLogic.infoScreenEight.SetActive(false);
            gameLogic.infoScreenFourHandle.SetActive(false);
            gameLogic.infoScreenActive = true;
        }
        else if (id == 5)
        {
            gameLogic.infoScreenOne.SetActive(false);
            gameLogic.infoScreenTwo.SetActive(false);
            gameLogic.infoScreenThree.SetActive(false);
            gameLogic.infoScreenFour.SetActive(false);
            gameLogic.infoScreenFive.SetActive(true);
            gameLogic.infoScreenSix.SetActive(false);
            gameLogic.infoScreenSeven.SetActive(false);
            gameLogic.infoScreenEight.SetActive(false);
            gameLogic.infoScreenFiveHandle.SetActive(false);
            gameLogic.infoScreenActive = true;
        }
        else if (id == 6)
        {
            gameLogic.infoScreenOne.SetActive(false);
            gameLogic.infoScreenTwo.SetActive(false);
            gameLogic.infoScreenThree.SetActive(false);
            gameLogic.infoScreenFour.SetActive(false);
            gameLogic.infoScreenFive.SetActive(false);
            gameLogic.infoScreenSix.SetActive(true);
            gameLogic.infoScreenSeven.SetActive(false);
            gameLogic.infoScreenEight.SetActive(false);
            gameLogic.infoScreenSixHandle.SetActive(false);
            gameLogic.infoScreenActive = true;
        }
        else if (id == 7)
        {
            gameLogic.infoScreenOne.SetActive(false);
            gameLogic.infoScreenTwo.SetActive(false);
            gameLogic.infoScreenThree.SetActive(false);
            gameLogic.infoScreenFour.SetActive(false);
            gameLogic.infoScreenFive.SetActive(false);
            gameLogic.infoScreenSix.SetActive(false);
            gameLogic.infoScreenSeven.SetActive(true);
            gameLogic.infoScreenEight.SetActive(false);
            gameLogic.infoScreenSevenHandle.SetActive(false);
            gameLogic.infoScreenActive = true;
        }
        else if (id == 8)
        {
            gameLogic.infoScreenOne.SetActive(false);
            gameLogic.infoScreenTwo.SetActive(false);
            gameLogic.infoScreenThree.SetActive(false);
            gameLogic.infoScreenFour.SetActive(false);
            gameLogic.infoScreenFive.SetActive(false);
            gameLogic.infoScreenSix.SetActive(false);
            gameLogic.infoScreenSeven.SetActive(false);
            gameLogic.infoScreenEight.SetActive(true);
            gameLogic.infoScreenEightHandle.SetActive(false);
            gameLogic.infoScreenActive = true;
        }
    }

    public void CloseInfoScreen()
    {
        if (gameLogic.infoScreenActive)
        {
            if (id == 1)
            {
                gameLogic.infoScreenOne.SetActive(false);
                gameLogic.infoScreenTwo.SetActive(false);
                gameLogic.infoScreenThree.SetActive(false);
                gameLogic.infoScreenFour.SetActive(false);
                gameLogic.infoScreenFive.SetActive(false);
                gameLogic.infoScreenSix.SetActive(false);
                gameLogic.infoScreenSeven.SetActive(false);
                gameLogic.infoScreenEight.SetActive(false);
                gameLogic.infoScreenOneHandle.SetActive(true);
                gameLogic.infoScreenActive = false;
            }
            else if (id == 2)
            {
                gameLogic.infoScreenOne.SetActive(false);
                gameLogic.infoScreenTwo.SetActive(false);
                gameLogic.infoScreenThree.SetActive(false);
                gameLogic.infoScreenFour.SetActive(false);
                gameLogic.infoScreenFive.SetActive(false);
                gameLogic.infoScreenSix.SetActive(false);
                gameLogic.infoScreenSeven.SetActive(false);
                gameLogic.infoScreenEight.SetActive(false);
                gameLogic.infoScreenTwoHandle.SetActive(true);
                gameLogic.infoScreenActive = false;
            }
            else if (id == 3)
            {
                gameLogic.infoScreenOne.SetActive(false);
                gameLogic.infoScreenTwo.SetActive(false);
                gameLogic.infoScreenThree.SetActive(false);
                gameLogic.infoScreenFour.SetActive(false);
                gameLogic.infoScreenFive.SetActive(false);
                gameLogic.infoScreenSix.SetActive(false);
                gameLogic.infoScreenSeven.SetActive(false);
                gameLogic.infoScreenEight.SetActive(false);
                gameLogic.infoScreenThreeHandle.SetActive(true);
                gameLogic.infoScreenActive = false;
            }
            else if (id == 4)
            {
                gameLogic.infoScreenOne.SetActive(false);
                gameLogic.infoScreenTwo.SetActive(false);
                gameLogic.infoScreenThree.SetActive(false);
                gameLogic.infoScreenFour.SetActive(false);
                gameLogic.infoScreenFive.SetActive(false);
                gameLogic.infoScreenSix.SetActive(false);
                gameLogic.infoScreenSeven.SetActive(false);
                gameLogic.infoScreenEight.SetActive(false);
                gameLogic.infoScreenFourHandle.SetActive(true);
                gameLogic.infoScreenActive = false;
            }
            else if (id == 5)
            {
                gameLogic.infoScreenOne.SetActive(false);
                gameLogic.infoScreenTwo.SetActive(false);
                gameLogic.infoScreenThree.SetActive(false);
                gameLogic.infoScreenFour.SetActive(false);
                gameLogic.infoScreenFive.SetActive(false);
                gameLogic.infoScreenSix.SetActive(false);
                gameLogic.infoScreenSeven.SetActive(false);
                gameLogic.infoScreenEight.SetActive(false);
                gameLogic.infoScreenFiveHandle.SetActive(true);
                gameLogic.infoScreenActive = false;
            }
            else if (id == 6)
            {
                gameLogic.infoScreenOne.SetActive(false);
                gameLogic.infoScreenTwo.SetActive(false);
                gameLogic.infoScreenThree.SetActive(false);
                gameLogic.infoScreenFour.SetActive(false);
                gameLogic.infoScreenFive.SetActive(false);
                gameLogic.infoScreenSix.SetActive(false);
                gameLogic.infoScreenSeven.SetActive(false);
                gameLogic.infoScreenEight.SetActive(false);
                gameLogic.infoScreenSixHandle.SetActive(true);
                gameLogic.infoScreenActive = false;
            }
            else if (id == 7)
            {
                gameLogic.infoScreenOne.SetActive(false);
                gameLogic.infoScreenTwo.SetActive(false);
                gameLogic.infoScreenThree.SetActive(false);
                gameLogic.infoScreenFour.SetActive(false);
                gameLogic.infoScreenFive.SetActive(false);
                gameLogic.infoScreenSix.SetActive(false);
                gameLogic.infoScreenSeven.SetActive(false);
                gameLogic.infoScreenEight.SetActive(false);
                gameLogic.infoScreenSevenHandle.SetActive(true);
                gameLogic.infoScreenActive = false;
            }
            else if (id == 8)
            {
                gameLogic.infoScreenOne.SetActive(false);
                gameLogic.infoScreenTwo.SetActive(false);
                gameLogic.infoScreenThree.SetActive(false);
                gameLogic.infoScreenFour.SetActive(false);
                gameLogic.infoScreenFive.SetActive(false);
                gameLogic.infoScreenSix.SetActive(false);
                gameLogic.infoScreenSeven.SetActive(false);
                gameLogic.infoScreenEight.SetActive(false);
                gameLogic.infoScreenEightHandle.SetActive(true);
                gameLogic.infoScreenActive = false;
            }
        }
    }
}
