using System;
using System.Collections.Generic;

namespace UnityEngine.XR.iOS
{
	public class UnityARGeneratePlane : MonoBehaviour
	{
		public GameObject planePrefab;
        public GameObject GameBoard;
        public GameObject startButton;
        private UnityARAnchorManager unityARAnchorManager;
        private RaycastHit hit;
        private bool isFixed = false;

        // Use this for initialization
        void Start () {
            unityARAnchorManager = new UnityARAnchorManager();
            UnityARUtility.InitializePlanePrefab (planePrefab);
        }

        void OnDestroy()
        {
            unityARAnchorManager.Destroy ();
        }

        private void Update()
        {

        }

        void OnGUI()
        {
            if(!isFixed) {
                UpdateGameBoard();
            }
            IEnumerable<ARPlaneAnchorGameObject> arpags = unityARAnchorManager.GetCurrentPlaneAnchors ();
			foreach(var planeAnchor in arpags)
			{
            }
        }

        void UpdateGameBoard()
        {
            //뷰포트에서 수직으로 월드에 ray를 쏘는거래요
            //뷰포트 좌측 하단은 0,0 우측 상단은 1,1 따라서 가운데는 0.5, 0.5
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(ray, out hit))
            {
                GameBoard.SetActive(true);
                GameBoard.transform.position = hit.point;
                //회전값 플레인 노말값에서 추출 필요??
            }
            else
            {
                GameBoard.SetActive(false);
            }
        }

        public void FixGameBoard() {
            isFixed |= startButton.tag == "Active";
        }
    }
}

