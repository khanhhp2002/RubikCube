using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rotate : MonoBehaviour
{
    public Transform[] pieceCube;
    private Transform target = null;
    private Transform[] sideRotation = null;
    private Transform[] changeData = null;
    public Transform[,,] rubikCube;
    public Transform[,,] changeDataAll;
    public static bool rotateAllowed = false;
    private bool allowPressKeys = true;
    private bool reverse = false;
    private bool allowMixed = true;
    public float rotationSpeed = 0.5f;
    private float originalSpeed;
    public int timeScramble = 30;


    private void Start()
    {
        originalSpeed = rotationSpeed;
        DisplayText.content = "Press enter to start !!!";
        DisplayText.textColor = new Color(255, 131, 0, 255);
        rubikCube = new Transform[3, 3, 3];
        for (int x = 0, index = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++, index++)
                {
                    rubikCube[x, y, z] = pieceCube[index];
                }
            }
        }
    }
    private void Update()
    {
        if (!allowPressKeys || !rotateAllowed)
        {
            return;
        }
        if (!reverse)
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate U";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnU(2);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate R";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnR(2);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate L";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnL(0);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate D";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnD(0);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate F";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnF(0);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate B";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnB(2);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate M";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnL(1);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate E";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnD(1);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate S";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnF(1);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate X";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnX(false);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.Y))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate Y";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnY(false);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                allowPressKeys = false;
                DisplayText.content = "Rotate Z";
                DisplayText.textColor = new Color(0, 255, 255, 255);
                turnZ(false);
                Invoke("wait", 0.51f);
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                DisplayText.content = "Rotate Reverse!!!";
                DisplayText.textColor = new Color(255, 0, 0, 255);
                reverse = true;
            }
            /*else if ((Input.GetKey(KeyCode.Mouse0)) && allowMixed)
            {
                rotationSpeed = 0.1f;
                DisplayText.content = "Scrambling!!!";
                DisplayText.textColor = new Color(255, 0, 0, 255);
                allowPressKeys = false;
                allowMixed = false;
                Mix();
            }*/
            else if ((Input.GetKey(KeyCode.Return)))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            else if (Input.GetKey(KeyCode.Escape))
                Application.Quit();
            return;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate U'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnD(2);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate D'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnU(0);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate R'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnL(2);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate L'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnR(0);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate F'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnB(0);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate B'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnF(2);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate M'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnR(1);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate E'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnU(1);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate S'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnB(1);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate X'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnX(true);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate Y'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnY(true);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            allowPressKeys = false;
            DisplayText.content = "Rotate Z'";
            DisplayText.textColor = new Color(0, 255, 255, 255);
            turnZ(true);
            Invoke("wait", 0.51f);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayText.content = "Rotate Reverse!!!";
            DisplayText.textColor = new Color(255, 0, 0, 255);
            reverse = false;
        }
        else if ((Input.GetKey(KeyCode.Mouse0)) && allowMixed)
        {
            DisplayText.content = "Scrambling !!!";
            DisplayText.textColor = new Color(255, 0, 0, 255);
            rotationSpeed = 0.1f;
            allowPressKeys = false;
            allowMixed = false;
            Mix();
        }
        else if ((Input.GetKey(KeyCode.Return)))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        else if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }
    public void Mix()
    {
        int choose = UnityEngine.Random.Range(1, 6);
        int position = UnityEngine.Random.Range(0, 2);
        switch (choose)
        {
            case 1:
                turnU(position);
                Invoke("waitForMix", 0.11f);
                break;
            case 2:
                turnD(position);
                Invoke("waitForMix", 0.11f);
                break;
            case 3:
                turnR(position);
                Invoke("waitForMix", 0.11f);
                break;
            case 4:
                turnL(position);
                Invoke("waitForMix", 0.11f);
                break;
            case 5:
                turnF(position);
                Invoke("waitForMix", 0.11f);
                break;
            case 6:
                turnB(position);
                Invoke("waitForMix", 0.11f);
                break;
        }
    }
    private void turnX(bool reverse)
    {
        target = rubikCube[1, 1, 1];
        changeDataAll = new Transform[3, 3, 3];
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    changeDataAll[x, y, z] = rubikCube[x, y, z];
                }
            }
        }
        if (reverse)
        {
            Invoke("rotateAllDown", rotationSpeed * 0.25f);
            Invoke("rotateAllDown", rotationSpeed * 0.5f);
            Invoke("rotateAllDown", rotationSpeed * 0.75f);
            Invoke("rotateAllDown", rotationSpeed);
            for (int y = 0; y < 3; y++)
            {
                rubikCube[0, y, 0] = changeDataAll[2, y, 0];
                rubikCube[0, y, 1] = changeDataAll[1, y, 0];
                rubikCube[0, y, 2] = changeDataAll[0, y, 0];
                rubikCube[1, y, 0] = changeDataAll[2, y, 1];
                rubikCube[1, y, 2] = changeDataAll[0, y, 1];
                rubikCube[2, y, 0] = changeDataAll[2, y, 2];
                rubikCube[2, y, 1] = changeDataAll[1, y, 2];
                rubikCube[2, y, 2] = changeDataAll[0, y, 2];

            }
            return;
        }
        Invoke("rotateAllUp", rotationSpeed * 0.25f);
        Invoke("rotateAllUp", rotationSpeed * 0.5f);
        Invoke("rotateAllUp", rotationSpeed * 0.75f);
        Invoke("rotateAllUp", rotationSpeed);
        for (int y = 0; y < 3; y++)
        {
            rubikCube[0, y, 0] = changeDataAll[0, y, 2];
            rubikCube[0, y, 1] = changeDataAll[1, y, 2];
            rubikCube[0, y, 2] = changeDataAll[2, y, 2];
            rubikCube[1, y, 0] = changeDataAll[0, y, 1];
            rubikCube[1, y, 2] = changeDataAll[2, y, 1];
            rubikCube[2, y, 0] = changeDataAll[0, y, 0];
            rubikCube[2, y, 1] = changeDataAll[1, y, 0];
            rubikCube[2, y, 2] = changeDataAll[2, y, 0];
        }
    }
    private void turnY(bool reverse)
    {
        target = rubikCube[1, 1, 1];
        changeDataAll = new Transform[3, 3, 3];
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    changeDataAll[x, y, z] = rubikCube[x, y, z];
                }
            }
        }
        if (reverse)
        {
            Invoke("rotateAllLeft", rotationSpeed * 0.25f);
            Invoke("rotateAllLeft", rotationSpeed * 0.5f);
            Invoke("rotateAllLeft", rotationSpeed * 0.75f);
            Invoke("rotateAllLeft", rotationSpeed);
            for (int x = 0; x < 3; x++)
            {
                rubikCube[x, 0, 0] = changeDataAll[x, 0, 2];
                rubikCube[x, 0, 1] = changeDataAll[x, 1, 2];
                rubikCube[x, 0, 2] = changeDataAll[x, 2, 2];
                rubikCube[x, 1, 0] = changeDataAll[x, 0, 1];
                rubikCube[x, 1, 2] = changeDataAll[x, 2, 1];
                rubikCube[x, 2, 0] = changeDataAll[x, 0, 0];
                rubikCube[x, 2, 1] = changeDataAll[x, 1, 0];
                rubikCube[x, 2, 2] = changeDataAll[x, 2, 0];
            }
            return;
        }
        Invoke("rotateAllRight", rotationSpeed * 0.25f);
        Invoke("rotateAllRight", rotationSpeed * 0.5f);
        Invoke("rotateAllRight", rotationSpeed * 0.75f);
        Invoke("rotateAllRight", rotationSpeed);
        for (int x = 0; x < 3; x++)
        {
            rubikCube[x, 0, 0] = changeDataAll[x, 2, 0];
            rubikCube[x, 0, 1] = changeDataAll[x, 1, 0];
            rubikCube[x, 0, 2] = changeDataAll[x, 0, 0];
            rubikCube[x, 1, 0] = changeDataAll[x, 2, 1];
            rubikCube[x, 1, 2] = changeDataAll[x, 0, 1];
            rubikCube[x, 2, 0] = changeDataAll[x, 2, 2];
            rubikCube[x, 2, 1] = changeDataAll[x, 1, 2];
            rubikCube[x, 2, 2] = changeDataAll[x, 0, 2];
        }
    }
    private void turnZ(bool reverse)
    {
        target = rubikCube[1, 1, 1];
        changeDataAll = new Transform[3, 3, 3];
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    changeDataAll[x, y, z] = rubikCube[x, y, z];
                }
            }
        }
        if (reverse)
        {
            Invoke("rotateAllFrontLeft", rotationSpeed * 0.25f);
            Invoke("rotateAllFrontLeft", rotationSpeed * 0.5f);
            Invoke("rotateAllFrontLeft", rotationSpeed * 0.75f);
            Invoke("rotateAllFrontLeft", rotationSpeed);
            for (int z = 0; z < 3; z++)
            {
                rubikCube[0, 0, z] = changeDataAll[2, 0, z];
                rubikCube[0, 1, z] = changeDataAll[1, 0, z];
                rubikCube[0, 2, z] = changeDataAll[0, 0, z];
                rubikCube[1, 0, z] = changeDataAll[2, 1, z];
                rubikCube[1, 2, z] = changeDataAll[0, 1, z];
                rubikCube[2, 0, z] = changeDataAll[2, 2, z];
                rubikCube[2, 1, z] = changeDataAll[1, 2, z];
                rubikCube[2, 2, z] = changeDataAll[0, 2, z];
            }
            return;
        }
        Invoke("rotateAllFrontRight", rotationSpeed * 0.25f);
        Invoke("rotateAllFrontRight", rotationSpeed * 0.5f);
        Invoke("rotateAllFrontRight", rotationSpeed * 0.75f);
        Invoke("rotateAllFrontRight", rotationSpeed);
        for (int z = 0; z < 3; z++)
        {
            rubikCube[0, 0, z] = changeDataAll[0, 2, z];
            rubikCube[0, 1, z] = changeDataAll[1, 2, z];
            rubikCube[0, 2, z] = changeDataAll[2, 2, z];
            rubikCube[1, 0, z] = changeDataAll[0, 1, z];
            rubikCube[1, 2, z] = changeDataAll[2, 1, z];
            rubikCube[2, 0, z] = changeDataAll[0, 0, z];
            rubikCube[2, 1, z] = changeDataAll[1, 0, z];
            rubikCube[2, 2, z] = changeDataAll[2, 0, z];
        }
    }

    private void turnB(int position)
    {
        sideRotation = new Transform[8];
        for (int x = 0, index = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (x == y && x == 1)
                {
                    target = rubikCube[x, y, position];
                    continue;
                }
                sideRotation[index] = rubikCube[x, y, position];
                index++;
            }
        }
        Invoke("rotateFrontLeft", rotationSpeed * 0.25f);
        Invoke("rotateFrontLeft", rotationSpeed * 0.5f);
        Invoke("rotateFrontLeft", rotationSpeed * 0.75f);
        Invoke("rotateFrontLeft", rotationSpeed);
        changeData = new Transform[8] { sideRotation[5], sideRotation[3], sideRotation[0], sideRotation[6], sideRotation[1], sideRotation[7], sideRotation[4], sideRotation[2] };
        for (int x = 0, index = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (x == y && x == 1)
                {
                    rubikCube[x, y, position] = target;
                    continue;
                }
                rubikCube[x, y, position] = changeData[index];
                index++;
            }
        }
    }
    private void turnF(int position)
    {
        sideRotation = new Transform[8];
        for (int x = 0, index = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (x == y && x == 1)
                {
                    target = rubikCube[x, y, position];
                    continue;
                }
                sideRotation[index] = rubikCube[x, y, position];
                index++;
            }
        }
        Invoke("rotateFrontRight", rotationSpeed * 0.25f);
        Invoke("rotateFrontRight", rotationSpeed * 0.5f);
        Invoke("rotateFrontRight", rotationSpeed * 0.75f);
        Invoke("rotateFrontRight", rotationSpeed);
        changeData = new Transform[8] { sideRotation[2], sideRotation[4], sideRotation[7], sideRotation[1], sideRotation[6], sideRotation[0], sideRotation[3], sideRotation[5] };
        for (int x = 0, index = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (x == y && x == 1)
                {
                    rubikCube[x, y, position] = target;
                    continue;
                }
                rubikCube[x, y, position] = changeData[index];
                index++;
            }
        }
    }
    private void turnL(int position)
    {
        sideRotation = new Transform[8];
        for (int x = 0, index = 0; x < 3; x++)
        {
            for (int z = 0; z < 3; z++)
            {
                if (x == z && x == 1)
                {
                    target = rubikCube[x, position, z];
                    continue;
                }
                sideRotation[index] = rubikCube[x, position, z];
                index++;
            }
        }
        Invoke("rotateDown", rotationSpeed * 0.25f);
        Invoke("rotateDown", rotationSpeed * 0.5f);
        Invoke("rotateDown", rotationSpeed * 0.75f);
        Invoke("rotateDown", rotationSpeed);
        changeData = new Transform[8] { sideRotation[5], sideRotation[3], sideRotation[0], sideRotation[6], sideRotation[1], sideRotation[7], sideRotation[4], sideRotation[2] };
        for (int x = 0, index = 0; x < 3; x++)
        {
            for (int z = 0; z < 3; z++)
            {
                if (x == z && x == 1)
                {
                    rubikCube[x, position, z] = target;
                    continue;
                }
                rubikCube[x, position, z] = changeData[index];
                index++;
            }
        }
    }
    private void turnR(int position)
    {
        sideRotation = new Transform[8];
        for (int x = 0, index = 0; x < 3; x++)
        {
            for (int z = 0; z < 3; z++)
            {
                if (x == z && x == 1)
                {
                    target = rubikCube[x, position, z];
                    continue;
                }
                sideRotation[index] = rubikCube[x, position, z];
                index++;
            }
        }
        Debug.Log(target.position);
        Invoke("rotateUp", rotationSpeed * 0.25f);
        Invoke("rotateUp", rotationSpeed * 0.5f);
        Invoke("rotateUp", rotationSpeed * 0.75f);
        Invoke("rotateUp", rotationSpeed);
        changeData = new Transform[8] { sideRotation[2], sideRotation[4], sideRotation[7], sideRotation[1], sideRotation[6], sideRotation[0], sideRotation[3], sideRotation[5] };
        for (int x = 0, index = 0; x < 3; x++)
        {
            for (int z = 0; z < 3; z++)
            {
                if (x == z && x == 1)
                {
                    rubikCube[x, position, z] = target;
                    continue;
                }
                rubikCube[x, position, z] = changeData[index];
                index++;
            }
        }
    }
    private void turnD(int position)
    {
        sideRotation = new Transform[8];
        for (int y = 0, index = 0; y < 3; y++)
        {
            for (int z = 0; z < 3; z++)
            {
                if (y == z && y == 1)
                {
                    target = rubikCube[position, y, z];
                    continue;
                }
                sideRotation[index] = rubikCube[position, y, z];
                index++;
            }
        }
        Invoke("rotateLeft", rotationSpeed * 0.25f);
        Invoke("rotateLeft", rotationSpeed * 0.5f);
        Invoke("rotateLeft", rotationSpeed * 0.75f);
        Invoke("rotateLeft", rotationSpeed);
        changeData = new Transform[8] { sideRotation[2], sideRotation[4], sideRotation[7], sideRotation[1], sideRotation[6], sideRotation[0], sideRotation[3], sideRotation[5] };
        for (int y = 0, index = 0; y < 3; y++)
        {
            for (int z = 0; z < 3; z++)
            {
                if (y == z && y == 1)
                {
                    rubikCube[position, y, z] = target;
                    continue;
                }
                rubikCube[position, y, z] = changeData[index];
                index++;
            }
        }
    }
    private void turnU(int position)
    {
        sideRotation = new Transform[8];
        for (int y = 0, index = 0; y < 3; y++)
        {
            for (int z = 0; z < 3; z++)
            {
                if (y == z && y == 1)
                {
                    target = rubikCube[position, y, z];
                    continue;
                }
                sideRotation[index] = rubikCube[position, y, z];
                index++;
            }
        }
        Invoke("rotateRight", rotationSpeed * 0.25f);
        Invoke("rotateRight", rotationSpeed * 0.5f);
        Invoke("rotateRight", rotationSpeed * 0.75f);
        Invoke("rotateRight", rotationSpeed);
        changeData = new Transform[8] { sideRotation[5], sideRotation[3], sideRotation[0], sideRotation[6], sideRotation[1], sideRotation[7], sideRotation[4], sideRotation[2] };
        for (int y = 0, index = 0; y < 3; y++)
        {
            for (int z = 0; z < 3; z++)
            {
                if (y == z && y == 1)
                {
                    rubikCube[position, y, z] = target;
                    continue;
                }
                rubikCube[position, y, z] = changeData[index];
                index++;
            }
        }
    }
    private void rotateUp()
    {
        foreach (Transform piece in sideRotation)
        {
            piece.RotateAround(target.position, Vector3.right, 22.5f);
        }
    }
    private void rotateRight()
    {
        foreach (Transform piece in sideRotation)
        {
            piece.RotateAround(target.position, Vector3.up, 22.5f);
        }
    }
    private void rotateLeft()
    {
        foreach (Transform piece in sideRotation)
        {
            piece.RotateAround(target.position, Vector3.down, 22.5f);
        }
    }
    private void rotateDown()
    {
        foreach (Transform piece in sideRotation)
        {
            piece.RotateAround(target.position, Vector3.left, 22.5f);
        }
    }
    private void rotateFrontRight()
    {
        foreach (Transform piece in sideRotation)
        {
            piece.RotateAround(target.position, Vector3.back, 22.5f);
        }
    }
    private void rotateFrontLeft()
    {
        foreach (Transform piece in sideRotation)
        {
            piece.RotateAround(target.position, Vector3.forward, 22.5f);
        }
    }
    private void rotateAllFrontRight()
    {
        foreach (Transform piece in rubikCube)
        {
            piece.RotateAround(target.position, Vector3.back, 22.5f);
        }
    }
    private void rotateAllFrontLeft()
    {
        foreach (Transform piece in rubikCube)
        {
            piece.RotateAround(target.position, Vector3.forward, 22.5f);
        }
    }
    private void rotateAllRight()
    {
        foreach (Transform piece in rubikCube)
        {
            piece.RotateAround(target.position, Vector3.up, 22.5f);
        }
    }
    private void rotateAllLeft()
    {
        foreach (Transform piece in rubikCube)
        {
            piece.RotateAround(target.position, Vector3.down, 22.5f);
        }
    }
    private void rotateAllUp()
    {
        foreach (Transform piece in rubikCube)
        {
            piece.RotateAround(target.position, Vector3.right, 22.5f);
        }
    }
    private void rotateAllDown()
    {
        foreach (Transform piece in rubikCube)
        {
            piece.RotateAround(target.position, Vector3.left, 22.5f);
        }
    }
    private void wait()
    {

        allowPressKeys = true;

    }
    private void waitForMix()
    {
        if (timeScramble != 0)
        {
            Mix();
            timeScramble--;
            return;
        }
        allowPressKeys = true;
        allowMixed = true;
        timeScramble = 30;
        rotationSpeed = originalSpeed;
    }

    public bool CheckTwoPiece(Transform _startPiece, Transform _endPiece)
    {
        Vector3Int? _startPiecePos = null;
        Vector3Int? _endPiecePos = null;

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (rubikCube[x, y, z] == _startPiece)
                    {
                        _startPiecePos = new Vector3Int(x, y, z);
                    }
                    if (rubikCube[x, y, z] == _endPiece)
                    {
                        _endPiecePos = new Vector3Int(x, y, z);
                    }
                }
            }
        }
        Tuple<int, int, int> values = new Tuple<int, int, int>(0, 0, 0);
        int pairCount = 0;
        if (_startPiecePos == null || _endPiecePos == null) return false;

        if (_startPiecePos.Value.x == _endPiecePos.Value.x)
            pairCount++;
        else
            values = new Tuple<int, int, int>(_startPiecePos.Value.x, _endPiecePos.Value.x, 0);

        if (_startPiecePos.Value.y == _endPiecePos.Value.y)
            pairCount++;
        else
            values = new Tuple<int, int, int>(_startPiecePos.Value.y, _endPiecePos.Value.y, 1);

        if (_startPiecePos.Value.z == _endPiecePos.Value.z)
            pairCount++;
        else
            values = new Tuple<int, int, int>(_startPiecePos.Value.z, _endPiecePos.Value.z, 2);

        if (pairCount == 2 && Mathf.Abs(values.Item1 - values.Item2) == 1)
        {
            // rotate
            if (values.Item3 == 0) // x cao
            {

            }
            else if (values.Item3 == 1) // y rong
            {
                if (_startPiecePos.Value.z == _startPiecePos.Value.x && _startPiecePos.Value.x == 0)
                {
                    Debug.Log("=D===================================");
                    turnD(_startPiecePos.Value.x);
                    return true;
                }
            }
            else if (values.Item3 == 2) // x sau
            {
                if (values.Item1 == 0)
                    turnB(0);
                else if (values.Item1 == 2)
                    turnF(0);
            }
        }

        return false;
    }
}
