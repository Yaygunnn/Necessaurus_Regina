using System;
using UnityEngine;

namespace SideScroller.Components.Jump
{
    public class AirComp : MonoBehaviour
    {
        private Action _jumpEnd;
        private Action _tick;
        private float _speedCurrent;
        [Header("GrondCheck")]
        [SerializeField] private LayerMask _groundLayers;
        [SerializeField] private Transform _groundCheckPosition;
        [SerializeField] private float _groundCheckRayLength;
        [Header("Ascent")]
        [SerializeField] private float _speedAtJumpStart;
        [SerializeField] private float _accelerationAscent;
        [SerializeField] private float _ascentEndSpeed;
        [Header("Peak")]
        [SerializeField] private float _accelerationPeak;
        [SerializeField] private float _peakEndSpeed;
        [Header("Descent")]
        [SerializeField] private float _accelerationDescent;
        [SerializeField] private float _DescentMinSpeed;
        public void StartJump(Action jumpEnd)
        {
            _jumpEnd = jumpEnd;
            if (IsGrounded())
            {
                _speedCurrent = _speedAtJumpStart;
                _tick = AscentTick;
            }
            else
            {
                _speedCurrent = 0;
                StartDescentTick();
            }
        }

        public void JumpTick()
        {
            _tick();
        }

        public void JumpEnd()
        {
            _jumpEnd();
        }

        private void AscentTick()
        {
            JumpMovement(_accelerationAscent);
            if(_speedCurrent <= _ascentEndSpeed)
            {
                _speedCurrent = _ascentEndSpeed;
                StartPeakTick();
            }
        }

        private void StartPeakTick()
        {
            _tick = PeakTick;
        }
        private void PeakTick()
        {
            JumpMovement(_accelerationPeak);
            if (_speedCurrent <= _peakEndSpeed)
            {
                _speedCurrent = _peakEndSpeed;
                StartDescentTick();
            }
        }

        private void StartDescentTick()
        {
            _tick = DescentTick;
        }
        private void DescentTick()
        {
            JumpMovement(_accelerationDescent);
            if(IsGrounded())
                JumpEnd();
            if(_speedCurrent < _DescentMinSpeed)
                _speedCurrent = _DescentMinSpeed;
        }
        private void JumpMovement(float acceleration)
        {
            Vector3 pos = transform.position;
            pos.y += _speedCurrent * Time.deltaTime;
            transform.position = pos;
            _speedCurrent += acceleration * Time.deltaTime;
        }
        public bool IsGrounded()
        {
            if(Physics2D.Raycast(_groundCheckPosition.position, Vector2.down, _groundCheckRayLength, _groundLayers))
                return true;
            return false;
        }
    }
}
