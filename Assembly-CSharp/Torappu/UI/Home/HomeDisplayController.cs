using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Torappu.Gyro;
using Torappu.UI.Home.Theme;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B36 RID: 19254
	[Token(Token = "0x2004B36")]
	public class HomeDisplayController : PageSingleComponent
	{
		// Token: 0x1700443C RID: 17468
		// (get) Token: 0x0601D006 RID: 118790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700443C")]
		private HomeDisplayController.MultiFormProviderSet tmProviderSet
		{
			[Token(Token = "0x601D006")]
			[Address(RVA = "0x166F680", Offset = "0x166E280", VA = "0x18166F680")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700443D RID: 17469
		// (get) Token: 0x0601D007 RID: 118791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700443D")]
		private HomeDisplayController.MultiFormProviderSet bgProviderSet
		{
			[Token(Token = "0x601D007")]
			[Address(RVA = "0x166F420", Offset = "0x166E020", VA = "0x18166F420")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700443E RID: 17470
		// (get) Token: 0x0601D008 RID: 118792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700443E")]
		public JObject defaultHomeThemeJData
		{
			[Token(Token = "0x601D008")]
			[Address(RVA = "0x166F5C0", Offset = "0x166E1C0", VA = "0x18166F5C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D009 RID: 118793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D009")]
		[Address(RVA = "0x166EEA0", Offset = "0x166DAA0", VA = "0x18166EEA0")]
		private void _TryLoadDefaultHomeThemeJData()
		{
		}

		// Token: 0x1700443F RID: 17471
		// (get) Token: 0x0601D00A RID: 118794 RVA: 0x000A9FE0 File Offset: 0x000A81E0
		// (set) Token: 0x0601D00B RID: 118795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700443F")]
		public bool isUIShowing
		{
			[Token(Token = "0x601D00A")]
			[Address(RVA = "0x166F620", Offset = "0x166E220", VA = "0x18166F620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D00B")]
			[Address(RVA = "0x166F7D0", Offset = "0x166E3D0", VA = "0x18166F7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601D00C RID: 118796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D00C")]
		[Address(RVA = "0x166D090", Offset = "0x166BC90", VA = "0x18166D090")]
		public void SetIllustAvail(bool flag)
		{
		}

		// Token: 0x0601D00D RID: 118797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D00D")]
		[Address(RVA = "0x166C460", Offset = "0x166B060", VA = "0x18166C460")]
		public void LoadHomeBackground(string bgId)
		{
		}

		// Token: 0x0601D00E RID: 118798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D00E")]
		[Address(RVA = "0x166C360", Offset = "0x166AF60", VA = "0x18166C360")]
		public void LoadHomeBackgroundInEditMode(string bgId, string overrideFormId, bool fastMode)
		{
		}

		// Token: 0x0601D00F RID: 118799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D00F")]
		[Address(RVA = "0x166E1D0", Offset = "0x166CDD0", VA = "0x18166E1D0")]
		private void _LoadHomeBackgroundImpl(string bgId)
		{
		}

		// Token: 0x0601D010 RID: 118800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D010")]
		[Address(RVA = "0x166D400", Offset = "0x166C000", VA = "0x18166D400")]
		private void _CreateEffectView(Transform holder, GameObject prefab, string bgId)
		{
		}

		// Token: 0x0601D011 RID: 118801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D011")]
		private T _LoadAsset<T>(string resPath) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0601D012 RID: 118802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D012")]
		[Address(RVA = "0x166F010", Offset = "0x166DC10", VA = "0x18166F010")]
		private void _UnloadHomeBackgroundAssets()
		{
		}

		// Token: 0x0601D013 RID: 118803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D013")]
		private void _UnloadAsset<T>(T asset) where T : UnityEngine.Object
		{
		}

		// Token: 0x0601D014 RID: 118804 RVA: 0x000A9FF8 File Offset: 0x000A81F8
		[Token(Token = "0x601D014")]
		[Address(RVA = "0x166DD30", Offset = "0x166C930", VA = "0x18166DD30")]
		private int _GetAssetGroup()
		{
			return 0;
		}

		// Token: 0x0601D015 RID: 118805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D015")]
		[Address(RVA = "0x166D7C0", Offset = "0x166C3C0", VA = "0x18166D7C0")]
		private void _DisposeSelf()
		{
		}

		// Token: 0x0601D016 RID: 118806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D016")]
		[Address(RVA = "0x166C650", Offset = "0x166B250", VA = "0x18166C650")]
		public void LoadHomeTheme(string themeId)
		{
		}

		// Token: 0x0601D017 RID: 118807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D017")]
		[Address(RVA = "0x166C550", Offset = "0x166B150", VA = "0x18166C550")]
		public void LoadHomeThemeInEditMode(string themeId, string overrideFormId, bool fastMode)
		{
		}

		// Token: 0x0601D018 RID: 118808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D018")]
		[Address(RVA = "0x166E480", Offset = "0x166D080", VA = "0x18166E480")]
		private void _LoadHomeThemeImpl(string themeId)
		{
		}

		// Token: 0x0601D019 RID: 118809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D019")]
		[Address(RVA = "0x166F220", Offset = "0x166DE20", VA = "0x18166F220")]
		private void _UnloadHomeThemeAssets()
		{
		}

		// Token: 0x0601D01A RID: 118810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D01A")]
		[Address(RVA = "0x166C880", Offset = "0x166B480", VA = "0x18166C880")]
		public void NotifyEditBegin()
		{
		}

		// Token: 0x0601D01B RID: 118811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D01B")]
		[Address(RVA = "0x166C750", Offset = "0x166B350", VA = "0x18166C750")]
		public void NotifyActivateDisplay()
		{
		}

		// Token: 0x0601D01C RID: 118812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D01C")]
		[Address(RVA = "0x166C130", Offset = "0x166AD30", VA = "0x18166C130")]
		public string GetActiveMultiformId(MultiFormLoadParam param)
		{
			return null;
		}

		// Token: 0x0601D01D RID: 118813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D01D")]
		[Address(RVA = "0x166EC60", Offset = "0x166D860", VA = "0x18166EC60")]
		private void _SetProviderImpl(HomeDisplayMultiFormProvider provider, HomeDisplayController.MultiFormProviderSet providerSet, bool isEdit)
		{
		}

		// Token: 0x0601D01E RID: 118814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D01E")]
		[Address(RVA = "0x166BDB0", Offset = "0x166A9B0", VA = "0x18166BDB0")]
		public void BindToThemeProvider(IMultiFormHandler handler)
		{
		}

		// Token: 0x0601D01F RID: 118815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D01F")]
		[Address(RVA = "0x166BC20", Offset = "0x166A820", VA = "0x18166BC20")]
		public void BindToBackgroundProvider(IMultiFormHandler handler)
		{
		}

		// Token: 0x0601D020 RID: 118816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D020")]
		[Address(RVA = "0x166BD00", Offset = "0x166A900", VA = "0x18166BD00")]
		public void BindToThemeHandler(string name, Animator animator)
		{
		}

		// Token: 0x0601D021 RID: 118817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D021")]
		[Address(RVA = "0x166BB70", Offset = "0x166A770", VA = "0x18166BB70")]
		public void BindToBackgroundHandler(string name, Animator animator)
		{
		}

		// Token: 0x0601D022 RID: 118818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D022")]
		[Address(RVA = "0x166C8F0", Offset = "0x166B4F0", VA = "0x18166C8F0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601D023 RID: 118819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D023")]
		[Address(RVA = "0x166CF70", Offset = "0x166BB70", VA = "0x18166CF70")]
		public void RequestStartPreviewMode(int requestId, bool fastMode = false, HomeDisplayController.PreviewElemFlag flag = HomeDisplayController.PreviewElemFlag.ALL_PANELS)
		{
		}

		// Token: 0x0601D024 RID: 118820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D024")]
		[Address(RVA = "0x166CE50", Offset = "0x166BA50", VA = "0x18166CE50")]
		public void RequestExitPreviewMode(int requestId, bool fastMode = false, HomeDisplayController.PreviewElemFlag flag = HomeDisplayController.PreviewElemFlag.ALL_PANELS)
		{
		}

		// Token: 0x0601D025 RID: 118821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D025")]
		[Address(RVA = "0x166EA60", Offset = "0x166D660", VA = "0x18166EA60")]
		private void _RequestStartPreviewModeInternal(HomeDisplayController.PreviewElemFlag checkFlag, int requestId, HomeDisplayController.PreviewElemFlag flag, bool fastMode)
		{
		}

		// Token: 0x0601D026 RID: 118822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D026")]
		[Address(RVA = "0x166E850", Offset = "0x166D450", VA = "0x18166E850")]
		private void _RequestExitPreviewModeInternal(HomeDisplayController.PreviewElemFlag checkFlag, int requestId, HomeDisplayController.PreviewElemFlag flag, bool fastMode)
		{
		}

		// Token: 0x0601D027 RID: 118823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D027")]
		[Address(RVA = "0x166DD90", Offset = "0x166C990", VA = "0x18166DD90")]
		private FadeSwitchTween _GetTweenByFlag(HomeDisplayController.PreviewElemFlag flag)
		{
			return null;
		}

		// Token: 0x0601D028 RID: 118824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D028")]
		[Address(RVA = "0x166E0B0", Offset = "0x166CCB0", VA = "0x18166E0B0")]
		private void _InitPreviewTweenIfNot()
		{
		}

		// Token: 0x0601D029 RID: 118825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D029")]
		[Address(RVA = "0x166DBB0", Offset = "0x166C7B0", VA = "0x18166DBB0")]
		private FadeSwitchTween _GenerateSwitchTween(CanvasGroup cg)
		{
			return null;
		}

		// Token: 0x0601D02A RID: 118826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D02A")]
		[Address(RVA = "0x166DF80", Offset = "0x166CB80", VA = "0x18166DF80")]
		private void _InitHomeShowAnim()
		{
		}

		// Token: 0x0601D02B RID: 118827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D02B")]
		[Address(RVA = "0x166CB90", Offset = "0x166B790", VA = "0x18166CB90")]
		public IEnumerator PlayHomeShowAnim()
		{
			return null;
		}

		// Token: 0x0601D02C RID: 118828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D02C")]
		[Address(RVA = "0x166C200", Offset = "0x166AE00", VA = "0x18166C200")]
		public void HideForegroundCameras(bool hide)
		{
		}

		// Token: 0x0601D02D RID: 118829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D02D")]
		[Address(RVA = "0x166CA60", Offset = "0x166B660", VA = "0x18166CA60", Slot = "8")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0601D02E RID: 118830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D02E")]
		[Address(RVA = "0x166BE90", Offset = "0x166AA90", VA = "0x18166BE90")]
		public void DisableLeftRightUpdate()
		{
		}

		// Token: 0x0601D02F RID: 118831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D02F")]
		[Address(RVA = "0x166BFE0", Offset = "0x166ABE0", VA = "0x18166BFE0")]
		public void EnableLeftRightUpdate()
		{
		}

		// Token: 0x0601D030 RID: 118832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D030")]
		[Address(RVA = "0x166D170", Offset = "0x166BD70", VA = "0x18166D170")]
		public void TweenCamerasToOriginalPositions([Optional] Action tweenFinishCb)
		{
		}

		// Token: 0x0601D031 RID: 118833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D031")]
		[Address(RVA = "0x166CC40", Offset = "0x166B840", VA = "0x18166CC40")]
		public void RecontrolCameras()
		{
		}

		// Token: 0x0601D032 RID: 118834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D032")]
		[Address(RVA = "0x166D5F0", Offset = "0x166C1F0", VA = "0x18166D5F0")]
		private void _DisableAll()
		{
		}

		// Token: 0x0601D033 RID: 118835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D033")]
		[Address(RVA = "0x166D8F0", Offset = "0x166C4F0", VA = "0x18166D8F0")]
		private void _EnableAll()
		{
		}

		// Token: 0x0601D034 RID: 118836 RVA: 0x000AA010 File Offset: 0x000A8210
		[Token(Token = "0x601D034")]
		[Address(RVA = "0x166D3A0", Offset = "0x166BFA0", VA = "0x18166D3A0")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x0601D035 RID: 118837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D035")]
		[Address(RVA = "0x166DB00", Offset = "0x166C700", VA = "0x18166DB00")]
		private IEnumerator _EnableComponentsDelayed()
		{
			return null;
		}

		// Token: 0x0601D036 RID: 118838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D036")]
		[Address(RVA = "0x166F310", Offset = "0x166DF10", VA = "0x18166F310")]
		public HomeDisplayController()
		{
		}

		// Token: 0x0601D037 RID: 118839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D037")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0601D038 RID: 118840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D038")]
		[Address(RVA = "0x166D390", Offset = "0x166BF90", VA = "0x18166D390")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x0402609A RID: 155802
		[Token(Token = "0x402609A")]
		private const string DEFAULT_THEME_ID = "tm_rhodes_day";

		// Token: 0x0402609B RID: 155803
		[Token(Token = "0x402609B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Preview Mode")]
		private CanvasGroup _panelLeft;

		// Token: 0x0402609C RID: 155804
		[Token(Token = "0x402609C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Preview Mode")]
		private CanvasGroup _panelRight;

		// Token: 0x0402609D RID: 155805
		[Token(Token = "0x402609D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Preview Mode")]
		private CanvasGroup _panelFront;

		// Token: 0x0402609E RID: 155806
		[Token(Token = "0x402609E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Preview Mode")]
		private CanvasGroup _charWordCanvas;

		// Token: 0x0402609F RID: 155807
		[Token(Token = "0x402609F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Preview Mode")]
		private CanvasGroup _backgroundBtnCanvas;

		// Token: 0x040260A0 RID: 155808
		[Token(Token = "0x40260A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Theme")]
		private UIStyleProvider _themeProvider;

		// Token: 0x040260A1 RID: 155809
		[Token(Token = "0x40260A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Background")]
		private Transform _transHomePlayerContainer;

		// Token: 0x040260A2 RID: 155810
		[Token(Token = "0x40260A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Background")]
		private Transform _transEffectBgContainer;

		// Token: 0x040260A3 RID: 155811
		[Token(Token = "0x40260A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Background")]
		private Transform _transEffectFrontContainer;

		// Token: 0x040260A4 RID: 155812
		[Token(Token = "0x40260A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Background")]
		private Transform _transEffectCameraContainer;

		// Token: 0x040260A5 RID: 155813
		[Token(Token = "0x40260A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Gyro")]
		private CameraGyroController _frontController;

		// Token: 0x040260A6 RID: 155814
		[Token(Token = "0x40260A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Gyro")]
		private CameraGyroController _leftController;

		// Token: 0x040260A7 RID: 155815
		[Token(Token = "0x40260A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Gyro")]
		private CameraGyroController _rightController;

		// Token: 0x040260A8 RID: 155816
		[Token(Token = "0x40260A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Gyro")]
		private float _tweenDuration;

		// Token: 0x040260A9 RID: 155817
		[Token(Token = "0x40260A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Multiform")]
		private HomeDisplayMultiFormTimelineHandler _tmTimelineHandler;

		// Token: 0x040260AA RID: 155818
		[Token(Token = "0x40260AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Multiform")]
		private HomeDisplayMultiFormTimelineHandler _bgTimelineHandler;

		// Token: 0x040260AB RID: 155819
		[Token(Token = "0x40260AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Multiform")]
		private HomeBackgroundMultiFormImageHandler _bgImageHandler;

		// Token: 0x040260AC RID: 155820
		[Token(Token = "0x40260AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x040260AD RID: 155821
		[Token(Token = "0x40260AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private List<Camera> _foregroundCameras;

		// Token: 0x040260AE RID: 155822
		[Token(Token = "0x40260AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool m_gyroInitialized;

		// Token: 0x040260AF RID: 155823
		[Token(Token = "0x40260AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private HomeTheme m_theme;

		// Token: 0x040260B0 RID: 155824
		[Token(Token = "0x40260B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private HomeDisplayController.MultiFormProviderSet m_tmProviderSet;

		// Token: 0x040260B1 RID: 155825
		[Token(Token = "0x40260B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private HomeDisplayController.MultiFormProviderSet m_bgProviderSet;

		// Token: 0x040260B2 RID: 155826
		[Token(Token = "0x40260B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private MultiFormEditRef m_editRef;

		// Token: 0x040260B3 RID: 155827
		[Token(Token = "0x40260B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private JObject m_defaultHomeThemeJData;

		// Token: 0x040260B4 RID: 155828
		[Token(Token = "0x40260B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string m_cachedHomeBgId;

		// Token: 0x040260B5 RID: 155829
		[Token(Token = "0x40260B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HomeBackgroundAssetsWrapper m_cachedBgAssets;

		// Token: 0x040260B6 RID: 155830
		[Token(Token = "0x40260B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private BackgroundFormAssetWrapper m_cachedBgFormAssets;

		// Token: 0x040260B7 RID: 155831
		[Token(Token = "0x40260B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private HomeDisplayController.ShowSwitchTween m_showSwitchTween;

		// Token: 0x040260B9 RID: 155833
		[Token(Token = "0x40260B9")]
		private const float UI_FADE_TIME = 0.16f;

		// Token: 0x040260BA RID: 155834
		[Token(Token = "0x40260BA")]
		private const float SHOW_DURATION = 1.28f;

		// Token: 0x040260BB RID: 155835
		[Token(Token = "0x40260BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Dictionary<string, ListSet<int>> m_requesetedPreviewModeDict;

		// Token: 0x040260BC RID: 155836
		[Token(Token = "0x40260BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private FadeSwitchTween m_leftPanelTween;

		// Token: 0x040260BD RID: 155837
		[Token(Token = "0x40260BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private FadeSwitchTween m_rightPanelTween;

		// Token: 0x040260BE RID: 155838
		[Token(Token = "0x40260BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private FadeSwitchTween m_frontPanelTween;

		// Token: 0x040260BF RID: 155839
		[Token(Token = "0x40260BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private FadeSwitchTween m_charWordTween;

		// Token: 0x040260C0 RID: 155840
		[Token(Token = "0x40260C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private FadeSwitchTween m_backgroundBtnTween;

		// Token: 0x040260C1 RID: 155841
		[Token(Token = "0x40260C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool m_hasPreviewTweenInited;

		// Token: 0x040260C2 RID: 155842
		[Token(Token = "0x40260C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tmProviderSet;

		// Token: 0x040260C3 RID: 155843
		[Token(Token = "0x40260C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_bgProviderSet;

		// Token: 0x040260C4 RID: 155844
		[Token(Token = "0x40260C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_defaultHomeThemeJData;

		// Token: 0x040260C5 RID: 155845
		[Token(Token = "0x40260C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryLoadDefaultHomeThemeJData;

		// Token: 0x040260C6 RID: 155846
		[Token(Token = "0x40260C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isUIShowing;

		// Token: 0x040260C7 RID: 155847
		[Token(Token = "0x40260C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isUIShowing;

		// Token: 0x040260C8 RID: 155848
		[Token(Token = "0x40260C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetIllustAvail;

		// Token: 0x040260C9 RID: 155849
		[Token(Token = "0x40260C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadHomeBackground;

		// Token: 0x040260CA RID: 155850
		[Token(Token = "0x40260CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadHomeBackgroundInEditMode;

		// Token: 0x040260CB RID: 155851
		[Token(Token = "0x40260CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadHomeBackgroundImpl;

		// Token: 0x040260CC RID: 155852
		[Token(Token = "0x40260CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CreateEffectView;

		// Token: 0x040260CD RID: 155853
		[Token(Token = "0x40260CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadAsset;

		// Token: 0x040260CE RID: 155854
		[Token(Token = "0x40260CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UnloadHomeBackgroundAssets;

		// Token: 0x040260CF RID: 155855
		[Token(Token = "0x40260CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UnloadAsset;

		// Token: 0x040260D0 RID: 155856
		[Token(Token = "0x40260D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetAssetGroup;

		// Token: 0x040260D1 RID: 155857
		[Token(Token = "0x40260D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DisposeSelf;

		// Token: 0x040260D2 RID: 155858
		[Token(Token = "0x40260D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadHomeTheme;

		// Token: 0x040260D3 RID: 155859
		[Token(Token = "0x40260D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadHomeThemeInEditMode;

		// Token: 0x040260D4 RID: 155860
		[Token(Token = "0x40260D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadHomeThemeImpl;

		// Token: 0x040260D5 RID: 155861
		[Token(Token = "0x40260D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UnloadHomeThemeAssets;

		// Token: 0x040260D6 RID: 155862
		[Token(Token = "0x40260D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_NotifyEditBegin;

		// Token: 0x040260D7 RID: 155863
		[Token(Token = "0x40260D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_NotifyActivateDisplay;

		// Token: 0x040260D8 RID: 155864
		[Token(Token = "0x40260D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetActiveMultiformId;

		// Token: 0x040260D9 RID: 155865
		[Token(Token = "0x40260D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SetProviderImpl;

		// Token: 0x040260DA RID: 155866
		[Token(Token = "0x40260DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_BindToThemeProvider;

		// Token: 0x040260DB RID: 155867
		[Token(Token = "0x40260DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_BindToBackgroundProvider;

		// Token: 0x040260DC RID: 155868
		[Token(Token = "0x40260DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_BindToThemeHandler;

		// Token: 0x040260DD RID: 155869
		[Token(Token = "0x40260DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_BindToBackgroundHandler;

		// Token: 0x040260DE RID: 155870
		[Token(Token = "0x40260DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040260DF RID: 155871
		[Token(Token = "0x40260DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_RequestStartPreviewMode;

		// Token: 0x040260E0 RID: 155872
		[Token(Token = "0x40260E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_RequestExitPreviewMode;

		// Token: 0x040260E1 RID: 155873
		[Token(Token = "0x40260E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RequestStartPreviewModeInternal;

		// Token: 0x040260E2 RID: 155874
		[Token(Token = "0x40260E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__RequestExitPreviewModeInternal;

		// Token: 0x040260E3 RID: 155875
		[Token(Token = "0x40260E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GetTweenByFlag;

		// Token: 0x040260E4 RID: 155876
		[Token(Token = "0x40260E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__InitPreviewTweenIfNot;

		// Token: 0x040260E5 RID: 155877
		[Token(Token = "0x40260E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GenerateSwitchTween;

		// Token: 0x040260E6 RID: 155878
		[Token(Token = "0x40260E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__InitHomeShowAnim;

		// Token: 0x040260E7 RID: 155879
		[Token(Token = "0x40260E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_PlayHomeShowAnim;

		// Token: 0x040260E8 RID: 155880
		[Token(Token = "0x40260E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_HideForegroundCameras;

		// Token: 0x040260E9 RID: 155881
		[Token(Token = "0x40260E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x040260EA RID: 155882
		[Token(Token = "0x40260EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_DisableLeftRightUpdate;

		// Token: 0x040260EB RID: 155883
		[Token(Token = "0x40260EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_EnableLeftRightUpdate;

		// Token: 0x040260EC RID: 155884
		[Token(Token = "0x40260EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_TweenCamerasToOriginalPositions;

		// Token: 0x040260ED RID: 155885
		[Token(Token = "0x40260ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_RecontrolCameras;

		// Token: 0x040260EE RID: 155886
		[Token(Token = "0x40260EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__DisableAll;

		// Token: 0x040260EF RID: 155887
		[Token(Token = "0x40260EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__EnableAll;

		// Token: 0x040260F0 RID: 155888
		[Token(Token = "0x40260F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x040260F1 RID: 155889
		[Token(Token = "0x40260F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__EnableComponentsDelayed;

		// Token: 0x040260F2 RID: 155890
		[Token(Token = "0x40260F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B37 RID: 19255
		[Token(Token = "0x2004B37")]
		[Obsolete("Use FadeSwitchTween.Builder.ControlRaycastAndKeepActive instead.")]
		private class SwitchTween : FadeSwitchTween
		{
			// Token: 0x0601D039 RID: 118841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D039")]
			[Address(RVA = "0x167AE80", Offset = "0x1679A80", VA = "0x18167AE80")]
			public SwitchTween(CanvasGroup alphaHandler, bool ignoreTimeScale)
			{
			}

			// Token: 0x0601D03A RID: 118842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D03A")]
			[Address(RVA = "0x167AE30", Offset = "0x1679A30", VA = "0x18167AE30", Slot = "20")]
			protected override void SetObjectActive(CanvasGroup alphaHandler, bool isActive)
			{
			}
		}

		// Token: 0x02004B38 RID: 19256
		[Token(Token = "0x2004B38")]
		private class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x0601D03B RID: 118843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D03B")]
			[Address(RVA = "0x167ACB0", Offset = "0x16798B0", VA = "0x18167ACB0")]
			public ShowSwitchTween(HomeDisplayController closure)
			{
			}

			// Token: 0x0601D03C RID: 118844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D03C")]
			[Address(RVA = "0x167A8F0", Offset = "0x16794F0", VA = "0x18167A8F0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601D03D RID: 118845 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D03D")]
			[Address(RVA = "0x167AA70", Offset = "0x1679670", VA = "0x18167AA70", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601D03E RID: 118846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D03E")]
			[Address(RVA = "0x167ABF0", Offset = "0x16797F0", VA = "0x18167ABF0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601D03F RID: 118847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D03F")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040260F3 RID: 155891
			[Token(Token = "0x40260F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private HomeDisplayController m_closure;

			// Token: 0x040260F4 RID: 155892
			[Token(Token = "0x40260F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040260F5 RID: 155893
			[Token(Token = "0x40260F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040260F6 RID: 155894
			[Token(Token = "0x40260F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040260F7 RID: 155895
			[Token(Token = "0x40260F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02004B39 RID: 19257
		[Token(Token = "0x2004B39")]
		public enum PreviewElemFlag
		{
			// Token: 0x040260F9 RID: 155897
			[Token(Token = "0x40260F9")]
			LEFT_PANEL = 1,
			// Token: 0x040260FA RID: 155898
			[Token(Token = "0x40260FA")]
			RIGHT_PANEL,
			// Token: 0x040260FB RID: 155899
			[Token(Token = "0x40260FB")]
			FRONT_PANEL = 4,
			// Token: 0x040260FC RID: 155900
			[Token(Token = "0x40260FC")]
			ALL_PANELS = 7,
			// Token: 0x040260FD RID: 155901
			[Token(Token = "0x40260FD")]
			CHAR_WORD,
			// Token: 0x040260FE RID: 155902
			[Token(Token = "0x40260FE")]
			BACKGROUND_BTN = 16
		}

		// Token: 0x02004B3A RID: 19258
		[Token(Token = "0x2004B3A")]
		public class MultiFormProviderSet : IMultiFormHandler, IHotfixable
		{
			// Token: 0x0601D040 RID: 118848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D040")]
			[Address(RVA = "0x167A6A0", Offset = "0x16792A0", VA = "0x18167A6A0")]
			public MultiFormProviderSet(HomeDisplayController closure, IMultiFormHandler[] handlers)
			{
			}

			// Token: 0x17004440 RID: 17472
			// (get) Token: 0x0601D041 RID: 118849 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601D042 RID: 118850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004440")]
			public HomeDisplayMultiFormProvider activeProvider
			{
				[Token(Token = "0x601D041")]
				[Address(RVA = "0x167A740", Offset = "0x1679340", VA = "0x18167A740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601D042")]
				[Address(RVA = "0x167A7A0", Offset = "0x16793A0", VA = "0x18167A7A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601D043 RID: 118851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D043")]
			[Address(RVA = "0x167A130", Offset = "0x1678D30", VA = "0x18167A130")]
			public void SetProvider(HomeDisplayMultiFormProvider provider, bool isEdit)
			{
			}

			// Token: 0x0601D044 RID: 118852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D044")]
			[Address(RVA = "0x1679FD0", Offset = "0x1678BD0", VA = "0x181679FD0")]
			public void SetLoadParam(MultiFormLoadParam loadParam)
			{
			}

			// Token: 0x0601D045 RID: 118853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D045")]
			[Address(RVA = "0x1679CD0", Offset = "0x16788D0", VA = "0x181679CD0", Slot = "4")]
			public void OnMultiFormChanged(HomeDisplayMultiFormItemModel formModel, bool shouldReset)
			{
			}

			// Token: 0x0601D046 RID: 118854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D046")]
			[Address(RVA = "0x1679C70", Offset = "0x1678870", VA = "0x181679C70")]
			public void NotifyActivateDisplay()
			{
			}

			// Token: 0x0601D047 RID: 118855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D047")]
			[Address(RVA = "0x167A470", Offset = "0x1679070", VA = "0x18167A470")]
			private void _NotifyHandlers()
			{
			}

			// Token: 0x0601D048 RID: 118856 RVA: 0x000AA028 File Offset: 0x000A8228
			[Token(Token = "0x601D048")]
			[Address(RVA = "0x167A2F0", Offset = "0x1678EF0", VA = "0x18167A2F0")]
			private bool _IsDisplayVisible()
			{
				return default(bool);
			}

			// Token: 0x0601D049 RID: 118857 RVA: 0x000AA040 File Offset: 0x000A8240
			[Token(Token = "0x601D049")]
			[Address(RVA = "0x167A580", Offset = "0x1679180", VA = "0x18167A580")]
			private bool _ShouldForceNotify()
			{
				return default(bool);
			}

			// Token: 0x040260FF RID: 155903
			[Token(Token = "0x40260FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private HomeDisplayController m_closure;

			// Token: 0x04026100 RID: 155904
			[Token(Token = "0x4026100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private IMultiFormHandler[] m_handlers;

			// Token: 0x04026101 RID: 155905
			[Token(Token = "0x4026101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool m_isEdit;

			// Token: 0x04026102 RID: 155906
			[Token(Token = "0x4026102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private HomeDisplayMultiFormItemModel m_pendingModel;

			// Token: 0x04026103 RID: 155907
			[Token(Token = "0x4026103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool m_pendingReset;

			// Token: 0x04026105 RID: 155909
			[Token(Token = "0x4026105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026106 RID: 155910
			[Token(Token = "0x4026106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_activeProvider;

			// Token: 0x04026107 RID: 155911
			[Token(Token = "0x4026107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_activeProvider;

			// Token: 0x04026108 RID: 155912
			[Token(Token = "0x4026108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetProvider;

			// Token: 0x04026109 RID: 155913
			[Token(Token = "0x4026109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_SetLoadParam;

			// Token: 0x0402610A RID: 155914
			[Token(Token = "0x402610A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnMultiFormChanged;

			// Token: 0x0402610B RID: 155915
			[Token(Token = "0x402610B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_NotifyActivateDisplay;

			// Token: 0x0402610C RID: 155916
			[Token(Token = "0x402610C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__NotifyHandlers;

			// Token: 0x0402610D RID: 155917
			[Token(Token = "0x402610D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__IsDisplayVisible;

			// Token: 0x0402610E RID: 155918
			[Token(Token = "0x402610E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__ShouldForceNotify;
		}
	}
}
