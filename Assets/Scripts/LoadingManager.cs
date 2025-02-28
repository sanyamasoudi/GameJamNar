using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;
using DG.Tweening;

namespace Scripts.LevelManager
{
    public class LoadingManager : MonoBehaviour
    {
        public static LoadingManager Instance;


        public Slider progressBar;

        [HideInInspector] public float _target;


        [SerializeField] private GameObject loaderCanvas;

        private void Awake()
        {
            Application.targetFrameRate = 120;
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public async void LoadScene(int sceneIndex)
        {
            #region Before Loading Scene

           // BeforeLoadingScene();
            #endregion

            _target = 0;
            progressBar.value = 0;
            
            var scene = SceneManager.LoadSceneAsync(sceneIndex);

            scene.allowSceneActivation = false;
            loaderCanvas.SetActive(true);
            do
            {
                await Task.Delay(1000);
                _target = scene.progress;
                progressBar.value = _target;
            } while (scene.progress < 0.9f);

            await Task.Delay(10000);
            scene.allowSceneActivation = true;

            #region After Loading Scene

            //AfterLoadingScene();
            #endregion

            await Task.Delay(900);

            #region On End Of Loading Scene

            FinalizeLoading();

            #endregion
        }

     
        private void FinalizeLoading()
        {
            loaderCanvas.SetActive(false);
        }
    }
}