using System.Collections;
using System.Collections.Generic;
using BallGame.Managers;
using TMPro;
using UnityEngine;

namespace BallGame.UI
{
    public class BallGameUI : MonoBehaviour
    {
        [Header("UI Elements")]
        public TextMeshProUGUI ScoreText;
        public TextMeshProUGUI MoveNameText;
        public TextMeshProUGUI MovePointsText;
        public TextMeshProUGUI TimerText;
        public TextMeshProUGUI ContestantNameText;
        
        private void OnDisable()
        {
            if (BallScoreManager.Instance != null)
            {
                BallScoreManager.Instance.OnScoreChange.RemoveListener(UpdateScoreText);
            }
        }

        private void Start()
        {
            if (BallScoreManager.Instance != null)
            {
                BallScoreManager.Instance.OnScoreChange.AddListener(UpdateScoreText);
            }
            
            UpdateScoreText(BallScoreManager.Instance.GetScore());
            UpdateMove("", "");
            UpdateContestantName("Practice");
            UpdateTimer(90);
        }

        private void UpdateScoreText(int score)
        {
            if (ScoreText == null)
                return;
            
            ScoreText.text = score.ToString();
        }
        
        private void UpdateMove(string moveName, string points)
        {
            MoveNameText.text = moveName;
            MovePointsText.text = points;
        }

        private void UpdateContestantName(string name)
        {
            ContestantNameText.text = name;
        }
        
        private void UpdateTimer(float time)
        {
            time += 1; // Compensate for delay
            
            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time % 60);
            
            string timeFormatted = string.Format("{0:00}:{1:00}", minutes, seconds);
            
            TimerText.text = timeFormatted.ToString();
        }
    }   
}