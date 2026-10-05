using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using BitBenderGames;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200416A RID: 16746
	[Token(Token = "0x200416A")]
	public class SandboxV2DungeonCameraController : DataBinder<SandboxV2DungeonProperty>, ISafeAreaListener, IScrollNormalizedPosition
	{
		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x06019D80 RID: 105856 RVA: 0x0009F768 File Offset: 0x0009D968
		// (set) Token: 0x06019D81 RID: 105857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D94")]
		public bool cullingEnabled
		{
			[Token(Token = "0x6019D80")]
			[Address(RVA = "0x12BDFC0", Offset = "0x12BCBC0", VA = "0x1812BDFC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019D81")]
			[Address(RVA = "0x12BE180", Offset = "0x12BCD80", VA = "0x1812BE180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x06019D82 RID: 105858 RVA: 0x0009F780 File Offset: 0x0009D980
		[Token(Token = "0x17003D95")]
		private float tanHalfFov
		{
			[Token(Token = "0x6019D82")]
			[Address(RVA = "0x12BE0F0", Offset = "0x12BCCF0", VA = "0x1812BE0F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x06019D83 RID: 105859 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019D84 RID: 105860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D96")]
		public Action onSelectionCanceled
		{
			[Token(Token = "0x6019D83")]
			[Address(RVA = "0x12BE090", Offset = "0x12BCC90", VA = "0x1812BE090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019D84")]
			[Address(RVA = "0x12BE1F0", Offset = "0x12BCDF0", VA = "0x1812BE1F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x06019D85 RID: 105861 RVA: 0x0009F798 File Offset: 0x0009D998
		[Token(Token = "0x17003D97")]
		public bool interactable
		{
			[Token(Token = "0x6019D85")]
			[Address(RVA = "0x12BE020", Offset = "0x12BCC20", VA = "0x1812BE020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06019D86 RID: 105862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D86")]
		[Address(RVA = "0x12BC7F0", Offset = "0x12BB3F0", VA = "0x1812BC7F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019D87 RID: 105863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D87")]
		[Address(RVA = "0x12B91D0", Offset = "0x12B7DD0", VA = "0x1812B91D0")]
		private void Awake()
		{
		}

		// Token: 0x06019D88 RID: 105864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D88")]
		[Address(RVA = "0x12B9680", Offset = "0x12B8280", VA = "0x1812B9680")]
		private void OnDestroy()
		{
		}

		// Token: 0x06019D89 RID: 105865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D89")]
		[Address(RVA = "0x12BA220", Offset = "0x12B8E20", VA = "0x1812BA220")]
		private void Update()
		{
		}

		// Token: 0x06019D8A RID: 105866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D8A")]
		[Address(RVA = "0x12B95F0", Offset = "0x12B81F0", VA = "0x1812B95F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06019D8B RID: 105867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D8B")]
		[Address(RVA = "0x12B9890", Offset = "0x12B8490", VA = "0x1812B9890", Slot = "8")]
		public void OnSafeRectUpdated(SafeRect rect)
		{
		}

		// Token: 0x06019D8C RID: 105868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D8C")]
		[Address(RVA = "0x12BCDA0", Offset = "0x12BB9A0", VA = "0x1812BCDA0")]
		private void _OnScrollChange(Vector2 vector)
		{
		}

		// Token: 0x06019D8D RID: 105869 RVA: 0x0009F7B0 File Offset: 0x0009D9B0
		[Token(Token = "0x6019D8D")]
		[Address(RVA = "0x12BC210", Offset = "0x12BAE10", VA = "0x1812BC210")]
		private float _GetNormalizedZoom(float zoom)
		{
			return 0f;
		}

		// Token: 0x06019D8E RID: 105870 RVA: 0x0009F7C8 File Offset: 0x0009D9C8
		[Token(Token = "0x6019D8E")]
		[Address(RVA = "0x12BC730", Offset = "0x12BB330", VA = "0x1812BC730")]
		private float _GetZoom(float normalizedZoom)
		{
			return 0f;
		}

		// Token: 0x06019D8F RID: 105871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D8F")]
		[Address(RVA = "0x12BD0B0", Offset = "0x12BBCB0", VA = "0x1812BD0B0")]
		private void _ResetCameraBoundary()
		{
		}

		// Token: 0x06019D90 RID: 105872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D90")]
		[Address(RVA = "0x12BCF20", Offset = "0x12BBB20", VA = "0x1812BCF20")]
		private void _OnZoomUpdate(float prevZoom, float currZoom)
		{
		}

		// Token: 0x06019D91 RID: 105873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D91")]
		[Address(RVA = "0x12BDD80", Offset = "0x12BC980", VA = "0x1812BDD80")]
		private void _UpdateSliderZoom(float normalizedZoomValue)
		{
		}

		// Token: 0x06019D92 RID: 105874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D92")]
		[Address(RVA = "0x12BD970", Offset = "0x12BC570", VA = "0x1812BD970")]
		private void _UpdateCameraZoom(float normalizedZoomValue)
		{
		}

		// Token: 0x06019D93 RID: 105875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D93")]
		[Address(RVA = "0x12BCB30", Offset = "0x12BB730", VA = "0x1812BCB30")]
		private void _OnCameraClicked(Vector2 screenPosition)
		{
		}

		// Token: 0x06019D94 RID: 105876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D94")]
		[Address(RVA = "0x12BD6D0", Offset = "0x12BC2D0", VA = "0x1812BD6D0")]
		private void _SetLock(SandboxV2DungeonCameraController.LockSource lockSource, bool isLock)
		{
		}

		// Token: 0x06019D95 RID: 105877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D95")]
		[Address(RVA = "0x12B9E10", Offset = "0x12B8A10", VA = "0x1812B9E10")]
		public void SetLock(SandboxV2DungeonCameraController.LockSource lockSource, bool isLock)
		{
		}

		// Token: 0x06019D96 RID: 105878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D96")]
		[Address(RVA = "0x12BD7B0", Offset = "0x12BC3B0", VA = "0x1812BD7B0")]
		private void _SetState(SandboxV2DungeonCameraController.State state)
		{
		}

		// Token: 0x06019D97 RID: 105879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D97")]
		[Address(RVA = "0x12BDC20", Offset = "0x12BC820", VA = "0x1812BDC20")]
		private void _UpdateMapConfig(SandboxV2MapConfig config)
		{
		}

		// Token: 0x06019D98 RID: 105880 RVA: 0x0009F7E0 File Offset: 0x0009D9E0
		[Token(Token = "0x6019D98")]
		[Address(RVA = "0x12BB4F0", Offset = "0x12BA0F0", VA = "0x1812BB4F0")]
		private bool _CheckCulling(Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x06019D99 RID: 105881 RVA: 0x0009F7F8 File Offset: 0x0009D9F8
		[Token(Token = "0x6019D99")]
		[Address(RVA = "0x12BB270", Offset = "0x12B9E70", VA = "0x1812BB270")]
		private bool _CheckCulling(ISandboxV2DungeonCullElement element)
		{
			return default(bool);
		}

		// Token: 0x06019D9A RID: 105882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D9A")]
		[Address(RVA = "0x12BDA20", Offset = "0x12BC620", VA = "0x1812BDA20")]
		private void _UpdateCulling()
		{
		}

		// Token: 0x06019D9B RID: 105883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D9B")]
		[Address(RVA = "0x12BA380", Offset = "0x12B8F80", VA = "0x1812BA380")]
		public void Watch(ISandboxV2DungeonCullElement element)
		{
		}

		// Token: 0x06019D9C RID: 105884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D9C")]
		[Address(RVA = "0x12BA150", Offset = "0x12B8D50", VA = "0x1812BA150")]
		public void Unwatch(ISandboxV2DungeonCullElement element)
		{
		}

		// Token: 0x06019D9D RID: 105885 RVA: 0x0009F810 File Offset: 0x0009DA10
		[Token(Token = "0x6019D9D")]
		[Address(RVA = "0x12BC140", Offset = "0x12BAD40", VA = "0x1812BC140")]
		private Vector2 _GetIntersection2d(Ray ray)
		{
			return default(Vector2);
		}

		// Token: 0x06019D9E RID: 105886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019D9E")]
		[Address(RVA = "0x12BA990", Offset = "0x12B9590", VA = "0x1812BA990")]
		private Vector2[] _CalculateFocusOffset(Vector2 screenAnchor)
		{
			return null;
		}

		// Token: 0x06019D9F RID: 105887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019D9F")]
		[Address(RVA = "0x12BA4B0", Offset = "0x12B90B0", VA = "0x1812BA4B0")]
		private Vector2[] _CalculateFocusOffset(Vector2 screenAnchor, float normalizedZoom)
		{
			return null;
		}

		// Token: 0x06019DA0 RID: 105888 RVA: 0x0009F828 File Offset: 0x0009DA28
		[Token(Token = "0x6019DA0")]
		[Address(RVA = "0x12BC2C0", Offset = "0x12BAEC0", VA = "0x1812BC2C0")]
		private Vector2 _GetTargetFocusPos(Vector2 targetPos, Vector2[] focusOffset)
		{
			return default(Vector2);
		}

		// Token: 0x06019DA1 RID: 105889 RVA: 0x0009F840 File Offset: 0x0009DA40
		[Token(Token = "0x6019DA1")]
		[Address(RVA = "0x12BBA50", Offset = "0x12BA650", VA = "0x1812BBA50")]
		private Vector2 _GetCurrFocusPos(Vector2 screenAnchor)
		{
			return default(Vector2);
		}

		// Token: 0x06019DA2 RID: 105890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DA2")]
		[Address(RVA = "0x12BAE30", Offset = "0x12B9A30", VA = "0x1812BAE30")]
		private void _CameraFocusOnPos(Vector2 pos, Vector2 screenAnchor, float zoom)
		{
		}

		// Token: 0x06019DA3 RID: 105891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019DA3")]
		[Address(RVA = "0x12BBE80", Offset = "0x12BAA80", VA = "0x1812BBE80")]
		private Tween _GetFocusOnPosTween(Vector2 targetPos, Vector2 screenAnchor, float duration = 0.6f, Ease easeType = Ease.OutExpo)
		{
			return null;
		}

		// Token: 0x06019DA4 RID: 105892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019DA4")]
		[Address(RVA = "0x12BBB80", Offset = "0x12BA780", VA = "0x1812BBB80")]
		private Tween _GetFocusOnPosAndZoomTween(Vector2 targetPos, Vector2 screenAnchor, float targetNormalizedZoom, float duration = 0.6f, Ease easeType = Ease.OutExpo)
		{
			return null;
		}

		// Token: 0x06019DA5 RID: 105893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019DA5")]
		[Address(RVA = "0x12BC450", Offset = "0x12BB050", VA = "0x1812BC450")]
		private Tween _GetZoomInWithCustomCenterTween(Vector3 zoomCenterScreenPos, float targetNormalizedZoom, float duration = 0.6f, Ease easeType = Ease.OutExpo)
		{
			return null;
		}

		// Token: 0x06019DA6 RID: 105894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DA6")]
		[Address(RVA = "0x12BAFE0", Offset = "0x12B9BE0", VA = "0x1812BAFE0")]
		private void _CameraZoom(Vector2 targetCanvasPos, float targetNormalizedZoom, float duration, Ease easeType)
		{
		}

		// Token: 0x06019DA7 RID: 105895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DA7")]
		[Address(RVA = "0x12BB800", Offset = "0x12BA400", VA = "0x1812BB800")]
		private void _FocusOnPos(Vector2 targetCanvasPos, Vector2 screenAnchor, float duration, Ease easeType)
		{
		}

		// Token: 0x06019DA8 RID: 105896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DA8")]
		[Address(RVA = "0x12BB610", Offset = "0x12BA210", VA = "0x1812BB610")]
		private void _FocusOnPosImmediately(Vector2 targetCanvasPos, Vector2 screenAnchor)
		{
		}

		// Token: 0x06019DA9 RID: 105897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DA9")]
		[Address(RVA = "0x12BB160", Offset = "0x12B9D60", VA = "0x1812BB160")]
		private void _CancelSelectedNode()
		{
		}

		// Token: 0x06019DAA RID: 105898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DAA")]
		[Address(RVA = "0x12B99D0", Offset = "0x12B85D0", VA = "0x1812B99D0", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonProperty property)
		{
		}

		// Token: 0x06019DAB RID: 105899 RVA: 0x0009F858 File Offset: 0x0009DA58
		[Token(Token = "0x6019DAB")]
		[Address(RVA = "0x12B93E0", Offset = "0x12B7FE0", VA = "0x1812B93E0")]
		public static Vector2 GetCenterOffset(float camZoom, float camTilt, float camFov, float aspectRatio, float screenWidth, float screenHeight, Vector2 screenPos)
		{
			return default(Vector2);
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x06019DAC RID: 105900 RVA: 0x0009F870 File Offset: 0x0009DA70
		[Token(Token = "0x17003D98")]
		private Vector2 position
		{
			[Token(Token = "0x6019DAC")]
			[Address(RVA = "0x12B9FA0", Offset = "0x12B8BA0", VA = "0x1812B9FA0", Slot = "9")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06019DAD RID: 105901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DAD")]
		[Address(RVA = "0x12BDE40", Offset = "0x12BCA40", VA = "0x1812BDE40")]
		public SandboxV2DungeonCameraController()
		{
		}

		// Token: 0x0402075C RID: 132956
		[Token(Token = "0x402075C")]
		private const float STANDARD_ASPECT_RATIO = 1.7777778f;

		// Token: 0x0402075D RID: 132957
		[Token(Token = "0x402075D")]
		private const float UI_CANVAS_SCALE = 0.01f;

		// Token: 0x0402075E RID: 132958
		[Token(Token = "0x402075E")]
		private const float UI_SCALING_SCROLL = 0.2f;

		// Token: 0x0402075F RID: 132959
		[Token(Token = "0x402075F")]
		public const float DEFAULT_FOCUS_DURATION = 0.6f;

		// Token: 0x04020760 RID: 132960
		[Token(Token = "0x4020760")]
		public const Ease DEFAULT_FOCUS_EASE_TYPE = Ease.OutExpo;

		// Token: 0x04020761 RID: 132961
		[Token(Token = "0x4020761")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MobileTouchCamera _touchCamera;

		// Token: 0x04020762 RID: 132962
		[Token(Token = "0x4020762")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TorappuTouchInputController _touchInputController;

		// Token: 0x04020763 RID: 132963
		[Token(Token = "0x4020763")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _standardGlobalZoomMin;

		// Token: 0x04020764 RID: 132964
		[Token(Token = "0x4020764")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _standardGlobalContentHeight;

		// Token: 0x04020765 RID: 132965
		[Token(Token = "0x4020765")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _standardGlobalTiltMin;

		// Token: 0x04020766 RID: 132966
		[Token(Token = "0x4020766")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _standardGlobalTiltMax;

		// Token: 0x04020767 RID: 132967
		[Token(Token = "0x4020767")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SandboxV2DungeonCameraSlider _slider;

		// Token: 0x04020768 RID: 132968
		[Token(Token = "0x4020768")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SandboxV2DungeonLodController _lodController;

		// Token: 0x04020769 RID: 132969
		[Token(Token = "0x4020769")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2DungeonCameraClick _cameraClick;

		// Token: 0x0402076A RID: 132970
		[Token(Token = "0x402076A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _cameraMargin;

		// Token: 0x0402076B RID: 132971
		[Token(Token = "0x402076B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float[] _lodThresholds;

		// Token: 0x0402076C RID: 132972
		[Token(Token = "0x402076C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector2[] _focusScreenAnchors;

		// Token: 0x0402076D RID: 132973
		[Token(Token = "0x402076D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("CameraRT")]
		private BlurScreenTexGenerator _blurGenerator;

		// Token: 0x0402076E RID: 132974
		[Token(Token = "0x402076E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("CameraRT")]
		private UIBlendRTHost _blurHost;

		// Token: 0x0402076F RID: 132975
		[Token(Token = "0x402076F")]
		[FieldOffset(Offset = "0x80")]
		private ScrollWheelHandler m_handler;

		// Token: 0x04020770 RID: 132976
		[Token(Token = "0x4020770")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x04020771 RID: 132977
		[Token(Token = "0x4020771")]
		[FieldOffset(Offset = "0x8C")]
		private int m_lock;

		// Token: 0x04020772 RID: 132978
		[Token(Token = "0x4020772")]
		[FieldOffset(Offset = "0x90")]
		private SandboxV2DungeonCameraController.State m_state;

		// Token: 0x04020773 RID: 132979
		[Token(Token = "0x4020773")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_cameraTween;

		// Token: 0x04020774 RID: 132980
		[Token(Token = "0x4020774")]
		[FieldOffset(Offset = "0xA0")]
		private float m_cachedSafeAreaWidth;

		// Token: 0x04020775 RID: 132981
		[Token(Token = "0x4020775")]
		[FieldOffset(Offset = "0xA4")]
		private float m_cachedSafeAreaHeight;

		// Token: 0x04020776 RID: 132982
		[Token(Token = "0x4020776")]
		[FieldOffset(Offset = "0xA8")]
		private float m_cachedScreenWidth;

		// Token: 0x04020777 RID: 132983
		[Token(Token = "0x4020777")]
		[FieldOffset(Offset = "0xAC")]
		private float m_cachedScreenHeight;

		// Token: 0x04020778 RID: 132984
		[Token(Token = "0x4020778")]
		[FieldOffset(Offset = "0xB0")]
		private SafeRect m_cachedSafeRect;

		// Token: 0x04020779 RID: 132985
		[Token(Token = "0x4020779")]
		[FieldOffset(Offset = "0xC0")]
		private Vector2 m_boundaryCenter;

		// Token: 0x0402077A RID: 132986
		[Token(Token = "0x402077A")]
		[FieldOffset(Offset = "0xC8")]
		private Vector2 m_boundarySize;

		// Token: 0x0402077B RID: 132987
		[Token(Token = "0x402077B")]
		[FieldOffset(Offset = "0xD0")]
		private Vector2 m_boundaryMax;

		// Token: 0x0402077C RID: 132988
		[Token(Token = "0x402077C")]
		[FieldOffset(Offset = "0xD8")]
		private Vector2 m_boundaryMin;

		// Token: 0x0402077D RID: 132989
		[Token(Token = "0x402077D")]
		[FieldOffset(Offset = "0xE0")]
		private float m_cameraGlobalZoomMin;

		// Token: 0x0402077E RID: 132990
		[Token(Token = "0x402077E")]
		[FieldOffset(Offset = "0xE4")]
		private float m_cameraGlobalZoomMax;

		// Token: 0x0402077F RID: 132991
		[Token(Token = "0x402077F")]
		[FieldOffset(Offset = "0xE8")]
		private float m_cameraMaxNormalizedZoom;

		// Token: 0x04020780 RID: 132992
		[Token(Token = "0x4020780")]
		[FieldOffset(Offset = "0xF0")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonConstructChecker;

		// Token: 0x04020781 RID: 132993
		[Token(Token = "0x4020781")]
		[FieldOffset(Offset = "0x100")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_nodeFocusChecker;

		// Token: 0x04020782 RID: 132994
		[Token(Token = "0x4020782")]
		[FieldOffset(Offset = "0x110")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020783 RID: 132995
		[Token(Token = "0x4020783")]
		[FieldOffset(Offset = "0x120")]
		private HashSet<ISandboxV2DungeonCullElement> m_cullElements;

		// Token: 0x04020786 RID: 132998
		[Token(Token = "0x4020786")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cullingEnabled;

		// Token: 0x04020787 RID: 132999
		[Token(Token = "0x4020787")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_cullingEnabled;

		// Token: 0x04020788 RID: 133000
		[Token(Token = "0x4020788")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_tanHalfFov;

		// Token: 0x04020789 RID: 133001
		[Token(Token = "0x4020789")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onSelectionCanceled;

		// Token: 0x0402078A RID: 133002
		[Token(Token = "0x402078A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onSelectionCanceled;

		// Token: 0x0402078B RID: 133003
		[Token(Token = "0x402078B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x0402078C RID: 133004
		[Token(Token = "0x402078C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402078D RID: 133005
		[Token(Token = "0x402078D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0402078E RID: 133006
		[Token(Token = "0x402078E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402078F RID: 133007
		[Token(Token = "0x402078F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04020790 RID: 133008
		[Token(Token = "0x4020790")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x04020791 RID: 133009
		[Token(Token = "0x4020791")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnSafeRectUpdated;

		// Token: 0x04020792 RID: 133010
		[Token(Token = "0x4020792")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnScrollChange;

		// Token: 0x04020793 RID: 133011
		[Token(Token = "0x4020793")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetNormalizedZoom;

		// Token: 0x04020794 RID: 133012
		[Token(Token = "0x4020794")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetZoom;

		// Token: 0x04020795 RID: 133013
		[Token(Token = "0x4020795")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResetCameraBoundary;

		// Token: 0x04020796 RID: 133014
		[Token(Token = "0x4020796")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnZoomUpdate;

		// Token: 0x04020797 RID: 133015
		[Token(Token = "0x4020797")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateSliderZoom;

		// Token: 0x04020798 RID: 133016
		[Token(Token = "0x4020798")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateCameraZoom;

		// Token: 0x04020799 RID: 133017
		[Token(Token = "0x4020799")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnCameraClicked;

		// Token: 0x0402079A RID: 133018
		[Token(Token = "0x402079A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SetLock;

		// Token: 0x0402079B RID: 133019
		[Token(Token = "0x402079B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetLock;

		// Token: 0x0402079C RID: 133020
		[Token(Token = "0x402079C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SetState;

		// Token: 0x0402079D RID: 133021
		[Token(Token = "0x402079D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__UpdateMapConfig;

		// Token: 0x0402079E RID: 133022
		[Token(Token = "0x402079E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CheckCulling;

		// Token: 0x0402079F RID: 133023
		[Token(Token = "0x402079F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix1__CheckCulling;

		// Token: 0x040207A0 RID: 133024
		[Token(Token = "0x40207A0")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateCulling;

		// Token: 0x040207A1 RID: 133025
		[Token(Token = "0x40207A1")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_Watch;

		// Token: 0x040207A2 RID: 133026
		[Token(Token = "0x40207A2")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_Unwatch;

		// Token: 0x040207A3 RID: 133027
		[Token(Token = "0x40207A3")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetIntersection2d;

		// Token: 0x040207A4 RID: 133028
		[Token(Token = "0x40207A4")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CalculateFocusOffset;

		// Token: 0x040207A5 RID: 133029
		[Token(Token = "0x40207A5")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix1__CalculateFocusOffset;

		// Token: 0x040207A6 RID: 133030
		[Token(Token = "0x40207A6")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GetTargetFocusPos;

		// Token: 0x040207A7 RID: 133031
		[Token(Token = "0x40207A7")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GetCurrFocusPos;

		// Token: 0x040207A8 RID: 133032
		[Token(Token = "0x40207A8")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__CameraFocusOnPos;

		// Token: 0x040207A9 RID: 133033
		[Token(Token = "0x40207A9")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GetFocusOnPosTween;

		// Token: 0x040207AA RID: 133034
		[Token(Token = "0x40207AA")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__GetFocusOnPosAndZoomTween;

		// Token: 0x040207AB RID: 133035
		[Token(Token = "0x40207AB")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__GetZoomInWithCustomCenterTween;

		// Token: 0x040207AC RID: 133036
		[Token(Token = "0x40207AC")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CameraZoom;

		// Token: 0x040207AD RID: 133037
		[Token(Token = "0x40207AD")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__FocusOnPos;

		// Token: 0x040207AE RID: 133038
		[Token(Token = "0x40207AE")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__FocusOnPosImmediately;

		// Token: 0x040207AF RID: 133039
		[Token(Token = "0x40207AF")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__CancelSelectedNode;

		// Token: 0x040207B0 RID: 133040
		[Token(Token = "0x40207B0")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040207B1 RID: 133041
		[Token(Token = "0x40207B1")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_GetCenterOffset;

		// Token: 0x040207B2 RID: 133042
		[Token(Token = "0x40207B2")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge get_position;

		// Token: 0x040207B3 RID: 133043
		[Token(Token = "0x40207B3")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200416B RID: 16747
		[Token(Token = "0x200416B")]
		private enum State
		{
			// Token: 0x040207B5 RID: 133045
			[Token(Token = "0x40207B5")]
			IDLE,
			// Token: 0x040207B6 RID: 133046
			[Token(Token = "0x40207B6")]
			SLIDING,
			// Token: 0x040207B7 RID: 133047
			[Token(Token = "0x40207B7")]
			PINCHING,
			// Token: 0x040207B8 RID: 133048
			[Token(Token = "0x40207B8")]
			TWEENING
		}

		// Token: 0x0200416C RID: 16748
		[Token(Token = "0x200416C")]
		public enum ZoomType
		{
			// Token: 0x040207BA RID: 133050
			[Token(Token = "0x40207BA")]
			NONE,
			// Token: 0x040207BB RID: 133051
			[Token(Token = "0x40207BB")]
			NEAR,
			// Token: 0x040207BC RID: 133052
			[Token(Token = "0x40207BC")]
			MID,
			// Token: 0x040207BD RID: 133053
			[Token(Token = "0x40207BD")]
			FAR
		}

		// Token: 0x0200416D RID: 16749
		[Token(Token = "0x200416D")]
		public enum LockSource
		{
			// Token: 0x040207BF RID: 133055
			[Token(Token = "0x40207BF")]
			SELF = 1,
			// Token: 0x040207C0 RID: 133056
			[Token(Token = "0x40207C0")]
			PAGE,
			// Token: 0x040207C1 RID: 133057
			[Token(Token = "0x40207C1")]
			STATE = 4
		}
	}
}
