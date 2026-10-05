using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000593 RID: 1427
	[Token(Token = "0x2000593")]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/WallHack Detector")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_wall_hack_detector.html")]
	public class WallHackDetector : ActDetectorBase
	{
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x000154B0 File Offset: 0x000136B0
		// (set) Token: 0x060030DC RID: 12508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070B")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x60030DB")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60030DC")]
			[Address(RVA = "0x543CC70", Offset = "0x543B870", VA = "0x18543CC70")]
			set
			{
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x000154C8 File Offset: 0x000136C8
		// (set) Token: 0x060030DE RID: 12510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070C")]
		public bool CheckController
		{
			[Token(Token = "0x60030DD")]
			[Address(RVA = "0x150B0B0", Offset = "0x1509CB0", VA = "0x18150B0B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60030DE")]
			[Address(RVA = "0x543CB50", Offset = "0x543B750", VA = "0x18543CB50")]
			set
			{
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x000154E0 File Offset: 0x000136E0
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070D")]
		public bool CheckWireframe
		{
			[Token(Token = "0x60030DF")]
			[Address(RVA = "0x50B11D0", Offset = "0x50AFDD0", VA = "0x1850B11D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60030E0")]
			[Address(RVA = "0x543CD00", Offset = "0x543B900", VA = "0x18543CD00")]
			set
			{
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x000154F8 File Offset: 0x000136F8
		// (set) Token: 0x060030E2 RID: 12514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070E")]
		public bool CheckRaycast
		{
			[Token(Token = "0x60030E1")]
			[Address(RVA = "0x543C920", Offset = "0x543B520", VA = "0x18543C920")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60030E2")]
			[Address(RVA = "0x543CBE0", Offset = "0x543B7E0", VA = "0x18543CBE0")]
			set
			{
			}
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E3")]
		[Address(RVA = "0x5438E00", Offset = "0x5437A00", VA = "0x185438E00")]
		public static WallHackDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x543A400", Offset = "0x5439000", VA = "0x18543A400")]
		public static void StartDetection()
		{
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E5")]
		[Address(RVA = "0x543A610", Offset = "0x5439210", VA = "0x18543A610")]
		public static void StartDetection(Action callback)
		{
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E6")]
		[Address(RVA = "0x543A6A0", Offset = "0x54392A0", VA = "0x18543A6A0")]
		public static void StartDetection(Action callback, Vector3 spawnPosition)
		{
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E7")]
		[Address(RVA = "0x543A5A0", Offset = "0x54391A0", VA = "0x18543A5A0")]
		public static void StartDetection(Action callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E8")]
		[Address(RVA = "0x543AD50", Offset = "0x5439950", VA = "0x18543AD50")]
		public static void StopDetection()
		{
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030E9")]
		[Address(RVA = "0x5439250", Offset = "0x5437E50", VA = "0x185439250")]
		public static void Dispose()
		{
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060030EB RID: 12523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070F")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x60030EA")]
			[Address(RVA = "0x543CB10", Offset = "0x543B710", VA = "0x18543CB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030EB")]
			[Address(RVA = "0x543CD90", Offset = "0x543B990", VA = "0x18543CD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000710")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60030EC")]
			[Address(RVA = "0x543C930", Offset = "0x543B530", VA = "0x18543C930")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030ED")]
		[Address(RVA = "0x543C810", Offset = "0x543B410", VA = "0x18543C810")]
		private WallHackDetector()
		{
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030EE")]
		[Address(RVA = "0x5438E10", Offset = "0x5437A10", VA = "0x185438E10")]
		private void Awake()
		{
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030EF")]
		[Address(RVA = "0x5439800", Offset = "0x5438400", VA = "0x185439800", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F0")]
		[Address(RVA = "0x54399B0", Offset = "0x54385B0", VA = "0x1854399B0")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F1")]
		[Address(RVA = "0x54399B0", Offset = "0x54385B0", VA = "0x1854399B0")]
		private void OnLevelLoadedCallback()
		{
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F2")]
		[Address(RVA = "0x5439330", Offset = "0x5437F30", VA = "0x185439330")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F3")]
		[Address(RVA = "0x543C6B0", Offset = "0x543B2B0", VA = "0x18543C6B0")]
		private void Update()
		{
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x543A200", Offset = "0x5438E00", VA = "0x18543A200")]
		private void StartDetectionInternal(Action callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F5")]
		[Address(RVA = "0x543A1C0", Offset = "0x5438DC0", VA = "0x18543A1C0", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F6")]
		[Address(RVA = "0x5439AA0", Offset = "0x54386A0", VA = "0x185439AA0", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x00015510 File Offset: 0x00013710
		[Token(Token = "0x60030F7")]
		[Address(RVA = "0x5439B40", Offset = "0x5438740", VA = "0x185439B40", Slot = "11")]
		protected override bool ResumeDetector()
		{
			return default(bool);
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F8")]
		[Address(RVA = "0x543AD00", Offset = "0x5439900", VA = "0x18543AD00", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030F9")]
		[Address(RVA = "0x5439170", Offset = "0x5437D70", VA = "0x185439170", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FA")]
		[Address(RVA = "0x543B110", Offset = "0x5439D10", VA = "0x18543B110")]
		private void UpdateServiceContainer()
		{
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030FB")]
		[Address(RVA = "0x54395E0", Offset = "0x54381E0", VA = "0x1854395E0")]
		private IEnumerator InitDetector()
		{
			return null;
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FC")]
		[Address(RVA = "0x543A7B0", Offset = "0x54393B0", VA = "0x18543A7B0")]
		private void StartRigidModule()
		{
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FD")]
		[Address(RVA = "0x5439E60", Offset = "0x5438A60", VA = "0x185439E60")]
		private void StartControllerModule()
		{
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FE")]
		[Address(RVA = "0x543ABD0", Offset = "0x54397D0", VA = "0x18543ABD0")]
		private void StartWireframeModule()
		{
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030FF")]
		[Address(RVA = "0x5439DA0", Offset = "0x54389A0", VA = "0x185439DA0")]
		private void ShootWireframeModule()
		{
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003100")]
		[Address(RVA = "0x5438F90", Offset = "0x5437B90", VA = "0x185438F90")]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003101")]
		[Address(RVA = "0x543A720", Offset = "0x5439320", VA = "0x18543A720")]
		private void StartRaycastModule()
		{
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003102")]
		[Address(RVA = "0x5439BB0", Offset = "0x54387B0", VA = "0x185439BB0")]
		private void ShootRaycastModule()
		{
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003103")]
		[Address(RVA = "0x543AE70", Offset = "0x5439A70", VA = "0x18543AE70")]
		private void StopRigidModule()
		{
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003104")]
		[Address(RVA = "0x543AC70", Offset = "0x5439870", VA = "0x18543AC70")]
		private void StopControllerModule()
		{
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003105")]
		[Address(RVA = "0x543AF50", Offset = "0x5439B50", VA = "0x18543AF50")]
		private void StopWireframeModule()
		{
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003106")]
		[Address(RVA = "0x543AE30", Offset = "0x5439A30", VA = "0x18543AE30")]
		private void StopRaycastModule()
		{
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003107")]
		[Address(RVA = "0x5439660", Offset = "0x5438260", VA = "0x185439660")]
		private void InitRigidModule()
		{
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003108")]
		[Address(RVA = "0x5439460", Offset = "0x5438060", VA = "0x185439460")]
		private void InitControllerModule()
		{
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003109")]
		[Address(RVA = "0x543B050", Offset = "0x5439C50", VA = "0x18543B050")]
		private void UninitRigidModule()
		{
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600310A")]
		[Address(RVA = "0x543AF90", Offset = "0x5439B90", VA = "0x18543AF90")]
		private void UninitControllerModule()
		{
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x600310B")]
		[Address(RVA = "0x5439100", Offset = "0x5437D00", VA = "0x185439100")]
		private bool Detect()
		{
			return default(bool);
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x600310C")]
		[Address(RVA = "0x5439410", Offset = "0x5438010", VA = "0x185439410")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x00015558 File Offset: 0x00013758
		[Token(Token = "0x600310D")]
		[Address(RVA = "0x5439010", Offset = "0x5437C10", VA = "0x185439010")]
		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return default(bool);
		}

		// Token: 0x04001ACD RID: 6861
		[Token(Token = "0x4001ACD")]
		internal const string ComponentName = "WallHack Detector";

		// Token: 0x04001ACE RID: 6862
		[Token(Token = "0x4001ACE")]
		internal const string FinalLogPrefix = "[ACTk] WallHack Detector: ";

		// Token: 0x04001ACF RID: 6863
		[Token(Token = "0x4001ACF")]
		private const string ServiceContainerName = "[WH Detector Service]";

		// Token: 0x04001AD0 RID: 6864
		[Token(Token = "0x4001AD0")]
		private const string WireframeShaderName = "Hidden/ACTk/WallHackTexture";

		// Token: 0x04001AD1 RID: 6865
		[Token(Token = "0x4001AD1")]
		private const int ShaderTextureSize = 4;

		// Token: 0x04001AD2 RID: 6866
		[Token(Token = "0x4001AD2")]
		private const int RenderTextureSize = 4;

		// Token: 0x04001AD3 RID: 6867
		[Token(Token = "0x4001AD3")]
		[FieldOffset(Offset = "0x38")]
		private readonly Vector3 rigidPlayerVelocity;

		// Token: 0x04001AD4 RID: 6868
		[Token(Token = "0x4001AD4")]
		[FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		// Token: 0x04001AD5 RID: 6869
		[Token(Token = "0x4001AD5")]
		[FieldOffset(Offset = "0x48")]
		private readonly WaitForEndOfFrame waitForEndOfFrame;

		// Token: 0x04001AD6 RID: 6870
		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Rigidbody hacks?")]
		[SerializeField]
		private bool checkRigidbody;

		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x51")]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Character Controller hacks?")]
		[SerializeField]
		private bool checkController;

		// Token: 0x04001AD8 RID: 6872
		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x52")]
		[Tooltip("Check for the \"see through the walls\" kind of cheats made via shader or driver hacks (wireframe, color alpha, etc.)?")]
		[SerializeField]
		private bool checkWireframe;

		// Token: 0x04001AD9 RID: 6873
		[Token(Token = "0x4001AD9")]
		[FieldOffset(Offset = "0x53")]
		[Tooltip("Check for the \"shoot through the walls\" kind of cheats made via Raycast hacks?")]
		[SerializeField]
		private bool checkRaycast;

		// Token: 0x04001ADA RID: 6874
		[Token(Token = "0x4001ADA")]
		[FieldOffset(Offset = "0x54")]
		[Range(1f, 60f)]
		[Tooltip("Delay between Wireframe module checks, from 1 up to 60 secs.")]
		public int wireframeDelay;

		// Token: 0x04001ADB RID: 6875
		[Token(Token = "0x4001ADB")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Delay between Raycast module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int raycastDelay;

		// Token: 0x04001ADC RID: 6876
		[Token(Token = "0x4001ADC")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("World position of the container for service objects within 3x3x3 cube (drawn as red wire cube in scene).")]
		public Vector3 spawnPosition;

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Maximum false positives in a row for each detection module before registering a wall hack.")]
		public byte maxFalsePositives;

		// Token: 0x04001ADE RID: 6878
		[Token(Token = "0x4001ADE")]
		[FieldOffset(Offset = "0x70")]
		private GameObject serviceContainer;

		// Token: 0x04001ADF RID: 6879
		[Token(Token = "0x4001ADF")]
		[FieldOffset(Offset = "0x78")]
		private GameObject solidWall;

		// Token: 0x04001AE0 RID: 6880
		[Token(Token = "0x4001AE0")]
		[FieldOffset(Offset = "0x80")]
		private GameObject thinWall;

		// Token: 0x04001AE1 RID: 6881
		[Token(Token = "0x4001AE1")]
		[FieldOffset(Offset = "0x88")]
		private Camera wfCamera;

		// Token: 0x04001AE2 RID: 6882
		[Token(Token = "0x4001AE2")]
		[FieldOffset(Offset = "0x90")]
		private MeshRenderer foregroundRenderer;

		// Token: 0x04001AE3 RID: 6883
		[Token(Token = "0x4001AE3")]
		[FieldOffset(Offset = "0x98")]
		private MeshRenderer backgroundRenderer;

		// Token: 0x04001AE4 RID: 6884
		[Token(Token = "0x4001AE4")]
		[FieldOffset(Offset = "0xA0")]
		private Color wfColor1;

		// Token: 0x04001AE5 RID: 6885
		[Token(Token = "0x4001AE5")]
		[FieldOffset(Offset = "0xB0")]
		private Color wfColor2;

		// Token: 0x04001AE6 RID: 6886
		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0xC0")]
		private Shader wfShader;

		// Token: 0x04001AE7 RID: 6887
		[Token(Token = "0x4001AE7")]
		[FieldOffset(Offset = "0xC8")]
		private Material wfMaterial;

		// Token: 0x04001AE8 RID: 6888
		[Token(Token = "0x4001AE8")]
		[FieldOffset(Offset = "0xD0")]
		private Texture2D shaderTexture;

		// Token: 0x04001AE9 RID: 6889
		[Token(Token = "0x4001AE9")]
		[FieldOffset(Offset = "0xD8")]
		private Texture2D targetTexture;

		// Token: 0x04001AEA RID: 6890
		[Token(Token = "0x4001AEA")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTexture renderTexture;

		// Token: 0x04001AEB RID: 6891
		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0xE8")]
		private int whLayer;

		// Token: 0x04001AEC RID: 6892
		[Token(Token = "0x4001AEC")]
		[FieldOffset(Offset = "0xEC")]
		private int raycastMask;

		// Token: 0x04001AED RID: 6893
		[Token(Token = "0x4001AED")]
		[FieldOffset(Offset = "0xF0")]
		private Rigidbody rigidPlayer;

		// Token: 0x04001AEE RID: 6894
		[Token(Token = "0x4001AEE")]
		[FieldOffset(Offset = "0xF8")]
		private CharacterController charControllerPlayer;

		// Token: 0x04001AEF RID: 6895
		[Token(Token = "0x4001AEF")]
		[FieldOffset(Offset = "0x100")]
		private float charControllerVelocity;

		// Token: 0x04001AF0 RID: 6896
		[Token(Token = "0x4001AF0")]
		[FieldOffset(Offset = "0x104")]
		private byte rigidbodyDetections;

		// Token: 0x04001AF1 RID: 6897
		[Token(Token = "0x4001AF1")]
		[FieldOffset(Offset = "0x105")]
		private byte controllerDetections;

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x106")]
		private byte wireframeDetections;

		// Token: 0x04001AF3 RID: 6899
		[Token(Token = "0x4001AF3")]
		[FieldOffset(Offset = "0x107")]
		private byte raycastDetections;

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[FieldOffset(Offset = "0x108")]
		private bool wireframeDetected;

		// Token: 0x04001AF5 RID: 6901
		[Token(Token = "0x4001AF5")]
		[FieldOffset(Offset = "0x110")]
		private readonly RaycastHit[] rayHits;
	}
}
