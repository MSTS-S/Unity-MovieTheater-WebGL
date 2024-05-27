# Unity-MovieTheater-WebGL
In this Unity3D project, a movie theater is created. webGL is selected as the build target.
<br><br>
![MovieTheaterのスクリーンショット](Document/MovieTheater.png)
<br><br>



## 概要
本Unity ProjectはWebGLをbuild targetとした映画館です．もともとVR空間における映画館であったものをWebブラウザ上でも楽しめるようにスクリプト改変等を行いました．自作の映像さえ用意できれば，オリジナル映像を放映する映画館を誰でも作ることができます．
<br><br>



## 操作方法




## 片目（左目）でのみ描画される問題
[Unity Documentation](https://docs.unity3d.com/ja/2022.3/Manual/SinglePassStereoRendering.html)によると，Unity XRでは次の2つのStereo Rendering Modeが提供されています．




## 全天球シェーダー（両眼対応 Sphereモデル）
片目（左目）でのみ描画される問題は作成されたシェーダーがインスタンス化に対応していないことが原因であるため，インスタンス化に対応するようなシェーダーに変更することでこの問題は解決されます．
具体的な両眼対応の全天球シェーダーは次の手順により作成することができます．なお，以下に示す解決手法は[2018.4 Unity Documentation - Single Pass Instanced rendering](https://docs.unity3d.com/2018.4/Documentation/Manual/SinglePassInstancing.html)を参考にしたものです．

1. struct appdata{}に次の一文を追記．
   - UNITY_VERTEX_INPUT_INSTANCE_ID
2. struct v2f{}の中に次の一文を追記．
   - UNITY_VERTEX_OUTPUT_STEREO
3. v2f vert(appdata v){}の中に次の三文を追記（なお追記箇所は v2f o;の直後）.
   - UNITY_SETUP_INSTANCE_ID(v);
   - UNITY_INITIALIZE_OUTPUT(v2f, o);
   - UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);





## Unity Projectの利用について
本リポジトリのUnityProject/BinocularPanoramicSphereShaderに含まれるUnity ProjectはOculus Integration (Deprecated)が含まれていません．そのためQuest利用時はUnity Projectを起動した後，[こちらのページ](https://assetstore.unity.com/packages/tools/integration/oculus-integration-deprecated-82022)からOculus Integrationをダウンロードをした後にご利用をお願い致します．なお，本ページに記載されているUnity ProjectのEditor Versionは2022.3.28f1です．

また，MainSceneはWorkSpace > Sceneの階層にあります．
<br><br>



## 参考文献
1. <a name="Quest2"></a>[Meta Quest 2: Immersive All-In-One VR Headset — Meta Store](https://www.meta.com/jp/quest/products/quest-2/)
2. <a name="StereoRendering"></a>[Unity - Manual: Stereo rendering](https://docs.unity3d.com/ja/2022.3/Manual/SinglePassStereoRendering.html)
3. <a name="PerformanceRec"></a>[Performance recommendations for Unity - Mixed Reality | Microsoft Learn](https://learn.microsoft.com/en-us/windows/mixed-reality/develop/unity/performance-recommendations-for-unity?tabs=openxr)
4. <a name="Solution"></a>[【Unity】Quest2ビルド時に右目しか描画されない不具合の修正](https://zenn.dev/dami/articles/8f436e67cbf882)
5. <a name="UniDoc"></a>[Unity - Manual:  Single Pass Instanced rendering](https://docs.unity3d.com/ja/2018.4/Manual/SinglePassInstancing.html)
6. <a name="OculusIntegration"></a>[Oculus Integration (Deprecated) | Integration | Unity Asset Store](https://assetstore.unity.com/packages/tools/integration/oculus-integration-deprecated-82022)
