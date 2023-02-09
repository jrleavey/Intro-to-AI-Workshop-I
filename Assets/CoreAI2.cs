using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class CoreAI2 : MonoBehaviour
{
    private enum AIState
    {
        Passive,
        Hostile
    }
    private AIState _AIState;

    public LayerMask targetMask;
    public LayerMask obstructionMask;

    public bool _canSeePlayer;
    public bool _isChasingPlayer;
    public bool _IAmWaiting;
    public bool _randomWaitTime;
    public bool _randomWander;
    public bool _alwaysMoving;

    [SerializeField]
    [Range(1, 7)] private int wait_time;

    [SerializeField]
    private float _speed;
    private float _timeSinceSeenPlayer;

    [SerializeField]
    [Range(0, 500)] private float _walkRadius;

    public float _FoVRadius;

    [Range(0, 360)] public float _FoVAngle;

    public float _proximityRadius;

    [Range(0, 360)] public float _proximityAngle;

    [SerializeField]
    private Transform[] _waypoints;

    private int _nextWayPoint = 0;

    [HideInInspector]
    public GameObject _player;

    private Renderer _enemyColor;

    private NavMeshAgent _navMeshAgent;

    private void Start()
    {
        _enemyColor = GetComponent<Renderer>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _player = GameObject.Find("Player");

    }

    void Update()
    {
        
    }
}
