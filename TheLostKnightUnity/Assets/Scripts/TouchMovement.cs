﻿using UnityEngine;
using System.Collections;

public class TouchMovement : MonoBehaviour
{
    // Variables
    private PlayerMovement player;
    private PlayerAttack playerAttacking;
    private PauseMenu pauseMenu;
    public int rightTouchCount = 0;
    public int leftTouchCount = 0;

    private bool keepGoing = true;
    public float timer;

    void Start()
    {
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (player == null)
        {
            player = FindObjectOfType<PlayerMovement>();
        }
        if (playerAttacking == null)
        {
            playerAttacking = FindObjectOfType<PlayerAttack>();

        }
        if (pauseMenu == null)
        {
            pauseMenu = FindObjectOfType<PauseMenu>();
        }

        if (timer > 0.75f)
        {
            leftTouchCount = 0;
            rightTouchCount = 0;
            timer = 0f;
        }
    }


    // Button touch events
    public void LeftArrow()
    {
        if (player != null)
        {
            player.moveRight = false;
            player.moveLeft = true;
            leftTouchCount++;
        }

    }

    public void RightArrow()
    {
        if (player != null)
        {
            player.moveRight = true;
            player.moveLeft = false;
            rightTouchCount++;
        }
    }

    public void ReleaseLeftArrow()
    {
        if (player != null)
        {
            player.moveLeft = false;
        }
    }

    public void ReleaseRightArrow()
    {
        if (player != null)
        {
            player.moveRight = false;
        }
    }

    public void UpArrow()
    {
        if (player != null)
        {
            player.jump = true;
        }
    }

    public void ReleaseUpArrow()
    {
        if (player != null)
        {
            player.jump = false;
        }
    }

    public void FireButton()
    {
        if (playerAttacking != null)
        {
            playerAttacking.isFiring = true;

        }
    }

    public void RealeaseFireButton()
    {
        if (playerAttacking != null)
        {
            playerAttacking.isFiring = false;

        }
    }

    public void AttackButton()
    {
        if (playerAttacking != null)
        {
            playerAttacking.isAttacking = true;

        }
    }

    public void ReleaseAttackButton()
    {
        if (playerAttacking != null)
        {
            playerAttacking.isAttacking = false;

        }
    }

    public void PauseButton()
    {
        if (pauseMenu.GameIsPaused == true)
        {
            pauseMenu.GameIsPaused = false;
        }
        else if (pauseMenu.GameIsPaused == false)
        {
            pauseMenu.GameIsPaused = true;
        }
    }

}