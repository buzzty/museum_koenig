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
            gameLogic.infoScreenTwoHandle.SetActive(true);
            gameLogic.infoScreenThreeHandle.SetActive(true);
            gameLogic.infoScreenFourHandle.SetActive(true);
            gameLogic.infoScreenFiveHandle.SetActive(true);
            gameLogic.infoScreenSixHandle.SetActive(true);
            gameLogic.infoScreenSevenHandle.SetActive(true);
            gameLogic.infoScreenEightHandle.SetActive(true);
            gameLogic.infoIconOne.SetActive(false);
            gameLogic.infoIconTwo.SetActive(true);
            gameLogic.infoIconThree.SetActive(true);
            gameLogic.infoIconFour.SetActive(true);
            gameLogic.infoIconFive.SetActive(true);
            gameLogic.infoIconSix.SetActive(true);
            gameLogic.infoIconSeven.SetActive(true);
            gameLogic.infoIconEight.SetActive(true);
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
            gameLogic.infoScreenOneHandle.SetActive(true);
            gameLogic.infoScreenTwoHandle.SetActive(false);
            gameLogic.infoScreenThreeHandle.SetActive(true);
            gameLogic.infoScreenFourHandle.SetActive(true);
            gameLogic.infoScreenFiveHandle.SetActive(true);
            gameLogic.infoScreenSixHandle.SetActive(true);
            gameLogic.infoScreenSevenHandle.SetActive(true);
            gameLogic.infoScreenEightHandle.SetActive(true);
            gameLogic.infoIconOne.SetActive(true);
            gameLogic.infoIconTwo.SetActive(false);
            gameLogic.infoIconThree.SetActive(true);
            gameLogic.infoIconFour.SetActive(true);
            gameLogic.infoIconFive.SetActive(true);
            gameLogic.infoIconSix.SetActive(true);
            gameLogic.infoIconSeven.SetActive(true);
            gameLogic.infoIconEight.SetActive(true);
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
            gameLogic.infoScreenOneHandle.SetActive(true);
            gameLogic.infoScreenTwoHandle.SetActive(true);
            gameLogic.infoScreenThreeHandle.SetActive(false);
            gameLogic.infoScreenFourHandle.SetActive(true);
            gameLogic.infoScreenFiveHandle.SetActive(true);
            gameLogic.infoScreenSixHandle.SetActive(true);
            gameLogic.infoScreenSevenHandle.SetActive(true);
            gameLogic.infoScreenEightHandle.SetActive(true);
            gameLogic.infoIconOne.SetActive(true);
            gameLogic.infoIconTwo.SetActive(true);
            gameLogic.infoIconThree.SetActive(false);
            gameLogic.infoIconFour.SetActive(true);
            gameLogic.infoIconFive.SetActive(true);
            gameLogic.infoIconSix.SetActive(true);
            gameLogic.infoIconSeven.SetActive(true);
            gameLogic.infoIconEight.SetActive(true);
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
            gameLogic.infoScreenOneHandle.SetActive(true);
            gameLogic.infoScreenTwoHandle.SetActive(true);
            gameLogic.infoScreenThreeHandle.SetActive(true);
            gameLogic.infoScreenFourHandle.SetActive(false);
            gameLogic.infoScreenFiveHandle.SetActive(true);
            gameLogic.infoScreenSixHandle.SetActive(true);
            gameLogic.infoScreenSevenHandle.SetActive(true);
            gameLogic.infoScreenEightHandle.SetActive(true);
            gameLogic.infoIconOne.SetActive(true);
            gameLogic.infoIconTwo.SetActive(true);
            gameLogic.infoIconThree.SetActive(true);
            gameLogic.infoIconFour.SetActive(false);
            gameLogic.infoIconFive.SetActive(true);
            gameLogic.infoIconSix.SetActive(true);
            gameLogic.infoIconSeven.SetActive(true);
            gameLogic.infoIconEight.SetActive(true);
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
            gameLogic.infoScreenOneHandle.SetActive(true);
            gameLogic.infoScreenTwoHandle.SetActive(true);
            gameLogic.infoScreenThreeHandle.SetActive(true);
            gameLogic.infoScreenFourHandle.SetActive(true);
            gameLogic.infoScreenFiveHandle.SetActive(false);
            gameLogic.infoScreenSixHandle.SetActive(true);
            gameLogic.infoScreenSevenHandle.SetActive(true);
            gameLogic.infoScreenEightHandle.SetActive(true);
            gameLogic.infoIconOne.SetActive(true);
            gameLogic.infoIconTwo.SetActive(true);
            gameLogic.infoIconThree.SetActive(true);
            gameLogic.infoIconFour.SetActive(true);
            gameLogic.infoIconFive.SetActive(false);
            gameLogic.infoIconSix.SetActive(true);
            gameLogic.infoIconSeven.SetActive(true);
            gameLogic.infoIconEight.SetActive(true);
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
            gameLogic.infoScreenOneHandle.SetActive(true);
            gameLogic.infoScreenTwoHandle.SetActive(true);
            gameLogic.infoScreenThreeHandle.SetActive(true);
            gameLogic.infoScreenFourHandle.SetActive(true);
            gameLogic.infoScreenFiveHandle.SetActive(true);
            gameLogic.infoScreenSixHandle.SetActive(false);
            gameLogic.infoScreenSevenHandle.SetActive(true);
            gameLogic.infoScreenEightHandle.SetActive(true);
            gameLogic.infoIconOne.SetActive(true);
            gameLogic.infoIconTwo.SetActive(true);
            gameLogic.infoIconThree.SetActive(true);
            gameLogic.infoIconFour.SetActive(true);
            gameLogic.infoIconFive.SetActive(true);
            gameLogic.infoIconSix.SetActive(false);
            gameLogic.infoIconSeven.SetActive(true);
            gameLogic.infoIconEight.SetActive(true);
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
            gameLogic.infoScreenOneHandle.SetActive(true);
            gameLogic.infoScreenTwoHandle.SetActive(true);
            gameLogic.infoScreenThreeHandle.SetActive(true);
            gameLogic.infoScreenFourHandle.SetActive(true);
            gameLogic.infoScreenFiveHandle.SetActive(true);
            gameLogic.infoScreenSixHandle.SetActive(true);
            gameLogic.infoScreenSevenHandle.SetActive(false);
            gameLogic.infoScreenEightHandle.SetActive(true);
            gameLogic.infoIconOne.SetActive(true);
            gameLogic.infoIconTwo.SetActive(true);
            gameLogic.infoIconThree.SetActive(true);
            gameLogic.infoIconFour.SetActive(true);
            gameLogic.infoIconFive.SetActive(true);
            gameLogic.infoIconSix.SetActive(true);
            gameLogic.infoIconSeven.SetActive(false);
            gameLogic.infoIconEight.SetActive(true);
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
            gameLogic.infoScreenOneHandle.SetActive(true);
            gameLogic.infoScreenTwoHandle.SetActive(true);
            gameLogic.infoScreenThreeHandle.SetActive(true);
            gameLogic.infoScreenFourHandle.SetActive(true);
            gameLogic.infoScreenFiveHandle.SetActive(true);
            gameLogic.infoScreenSixHandle.SetActive(true);
            gameLogic.infoScreenSevenHandle.SetActive(true);
            gameLogic.infoScreenEightHandle.SetActive(false);
            gameLogic.infoIconOne.SetActive(true);
            gameLogic.infoIconTwo.SetActive(true);
            gameLogic.infoIconThree.SetActive(true);
            gameLogic.infoIconFour.SetActive(true);
            gameLogic.infoIconFive.SetActive(true);
            gameLogic.infoIconSix.SetActive(true);
            gameLogic.infoIconSeven.SetActive(true);
            gameLogic.infoIconEight.SetActive(false);
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
                gameLogic.infoIconOne.SetActive(true);
                gameLogic.infoIconTwo.SetActive(true);
                gameLogic.infoIconThree.SetActive(true);
                gameLogic.infoIconFour.SetActive(true);
                gameLogic.infoIconFive.SetActive(true);
                gameLogic.infoIconSix.SetActive(true);
                gameLogic.infoIconSeven.SetActive(true);
                gameLogic.infoIconEight.SetActive(true);
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
                gameLogic.infoIconOne.SetActive(true);
                gameLogic.infoIconTwo.SetActive(true);
                gameLogic.infoIconThree.SetActive(true);
                gameLogic.infoIconFour.SetActive(true);
                gameLogic.infoIconFive.SetActive(true);
                gameLogic.infoIconSix.SetActive(true);
                gameLogic.infoIconSeven.SetActive(true);
                gameLogic.infoIconEight.SetActive(true);
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
                gameLogic.infoIconOne.SetActive(true);
                gameLogic.infoIconTwo.SetActive(true);
                gameLogic.infoIconThree.SetActive(true);
                gameLogic.infoIconFour.SetActive(true);
                gameLogic.infoIconFive.SetActive(true);
                gameLogic.infoIconSix.SetActive(true);
                gameLogic.infoIconSeven.SetActive(true);
                gameLogic.infoIconEight.SetActive(true);
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
                gameLogic.infoIconOne.SetActive(true);
                gameLogic.infoIconTwo.SetActive(true);
                gameLogic.infoIconThree.SetActive(true);
                gameLogic.infoIconFour.SetActive(true);
                gameLogic.infoIconFive.SetActive(true);
                gameLogic.infoIconSix.SetActive(true);
                gameLogic.infoIconSeven.SetActive(true);
                gameLogic.infoIconEight.SetActive(true);
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
                gameLogic.infoIconOne.SetActive(true);
                gameLogic.infoIconTwo.SetActive(true);
                gameLogic.infoIconThree.SetActive(true);
                gameLogic.infoIconFour.SetActive(true);
                gameLogic.infoIconFive.SetActive(true);
                gameLogic.infoIconSix.SetActive(true);
                gameLogic.infoIconSeven.SetActive(true);
                gameLogic.infoIconEight.SetActive(true);
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
                gameLogic.infoIconOne.SetActive(true);
                gameLogic.infoIconTwo.SetActive(true);
                gameLogic.infoIconThree.SetActive(true);
                gameLogic.infoIconFour.SetActive(true);
                gameLogic.infoIconFive.SetActive(true);
                gameLogic.infoIconSix.SetActive(true);
                gameLogic.infoIconSeven.SetActive(true);
                gameLogic.infoIconEight.SetActive(true);
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
                gameLogic.infoIconOne.SetActive(true);
                gameLogic.infoIconTwo.SetActive(true);
                gameLogic.infoIconThree.SetActive(true);
                gameLogic.infoIconFour.SetActive(true);
                gameLogic.infoIconFive.SetActive(true);
                gameLogic.infoIconSix.SetActive(true);
                gameLogic.infoIconSeven.SetActive(true);
                gameLogic.infoIconEight.SetActive(true);
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
                gameLogic.infoIconOne.SetActive(true);
                gameLogic.infoIconTwo.SetActive(true);
                gameLogic.infoIconThree.SetActive(true);
                gameLogic.infoIconFour.SetActive(true);
                gameLogic.infoIconFive.SetActive(true);
                gameLogic.infoIconSix.SetActive(true);
                gameLogic.infoIconSeven.SetActive(true);
                gameLogic.infoIconEight.SetActive(true);
                gameLogic.infoScreenActive = false;
            }
        }
    }
}
