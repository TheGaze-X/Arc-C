using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060D5 RID: 24789
	[Token(Token = "0x20060D5")]
	public class CampaignPage : StateEnginePage, IMobileTouchPage, IHotfixable
	{
		// Token: 0x1700549D RID: 21661
		// (get) Token: 0x06023D38 RID: 146744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700549D")]
		public CampaignWorldViewProperty worldProperty
		{
			[Token(Token = "0x6023D38")]
			[Address(RVA = "0x1E771B0", Offset = "0x1E75DB0", VA = "0x181E771B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700549E RID: 21662
		// (get) Token: 0x06023D39 RID: 146745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700549E")]
		public CampaignWorldHomeBriefViewProperty homeBriefProperty
		{
			[Token(Token = "0x6023D39")]
			[Address(RVA = "0x1E76FA0", Offset = "0x1E75BA0", VA = "0x181E76FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700549F RID: 21663
		// (get) Token: 0x06023D3A RID: 146746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700549F")]
		public CampaignFeeViewProperty feeProperty
		{
			[Token(Token = "0x6023D3A")]
			[Address(RVA = "0x1E76F40", Offset = "0x1E75B40", VA = "0x181E76F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054A0 RID: 21664
		// (get) Token: 0x06023D3B RID: 146747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054A0")]
		public CampaignWorldViewModel worldModel
		{
			[Token(Token = "0x6023D3B")]
			[Address(RVA = "0x1E77130", Offset = "0x1E75D30", VA = "0x181E77130")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054A1 RID: 21665
		// (get) Token: 0x06023D3C RID: 146748 RVA: 0x000C22B0 File Offset: 0x000C04B0
		// (set) Token: 0x06023D3D RID: 146749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054A1")]
		public bool isToZonePage
		{
			[Token(Token = "0x6023D3C")]
			[Address(RVA = "0x1E77000", Offset = "0x1E75C00", VA = "0x181E77000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6023D3D")]
			[Address(RVA = "0x1E772E0", Offset = "0x1E75EE0", VA = "0x181E772E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170054A2 RID: 21666
		// (get) Token: 0x06023D3E RID: 146750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054A2")]
		private string zoneIdOnOpen
		{
			[Token(Token = "0x6023D3E")]
			[Address(RVA = "0x1E77210", Offset = "0x1E75E10", VA = "0x181E77210")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054A3 RID: 21667
		// (get) Token: 0x06023D3F RID: 146751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054A3")]
		private string stageIdOnOpen
		{
			[Token(Token = "0x6023D3F")]
			[Address(RVA = "0x1E77060", Offset = "0x1E75C60", VA = "0x181E77060")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023D40 RID: 146752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D40")]
		[Address(RVA = "0x1E74080", Offset = "0x1E72C80", VA = "0x181E74080", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06023D41 RID: 146753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D41")]
		[Address(RVA = "0x1E74320", Offset = "0x1E72F20", VA = "0x181E74320", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06023D42 RID: 146754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D42")]
		[Address(RVA = "0x1E74560", Offset = "0x1E73160", VA = "0x181E74560", Slot = "14")]
		protected override void OnStop()
		{
		}

		// Token: 0x06023D43 RID: 146755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D43")]
		[Address(RVA = "0x1E73DE0", Offset = "0x1E729E0", VA = "0x181E73DE0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06023D44 RID: 146756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D44")]
		[Address(RVA = "0x1E73CA0", Offset = "0x1E728A0", VA = "0x181E73CA0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06023D45 RID: 146757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D45")]
		[Address(RVA = "0x1E73BC0", Offset = "0x1E727C0", VA = "0x181E73BC0", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x06023D46 RID: 146758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D46")]
		[Address(RVA = "0x1E75BE0", Offset = "0x1E747E0", VA = "0x181E75BE0")]
		private void _EventOnWorldViewInited()
		{
		}

		// Token: 0x06023D47 RID: 146759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D47")]
		[Address(RVA = "0x1E75CE0", Offset = "0x1E748E0", VA = "0x181E75CE0")]
		private void _EventOnZoneClicked(CampaignWorldZoneViewModel zoneModel)
		{
		}

		// Token: 0x06023D48 RID: 146760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D48")]
		[Address(RVA = "0x1E73D60", Offset = "0x1E72960", VA = "0x181E73D60", Slot = "29")]
		public void EnableMobileTouch(bool enable)
		{
		}

		// Token: 0x06023D49 RID: 146761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D49")]
		[Address(RVA = "0x1E73930", Offset = "0x1E72530", VA = "0x181E73930")]
		public void CameraLock(CampaignWorldCameraController.LockSource lockSource, bool isLock)
		{
		}

		// Token: 0x06023D4A RID: 146762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D4A")]
		[Address(RVA = "0x1E734F0", Offset = "0x1E720F0", VA = "0x181E734F0")]
		public void CameraFocusStage(string stageId, [Optional] CampaignWorldCameraController.FocusParam param)
		{
		}

		// Token: 0x06023D4B RID: 146763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D4B")]
		[Address(RVA = "0x1E73710", Offset = "0x1E72310", VA = "0x181E73710")]
		public void CameraFocusZone(string zoneId, [Optional] CampaignWorldCameraController.FocusParam param)
		{
		}

		// Token: 0x06023D4C RID: 146764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D4C")]
		[Address(RVA = "0x1E739E0", Offset = "0x1E725E0", VA = "0x181E739E0")]
		public void CameraResetFocus([Optional] Action onFinished)
		{
		}

		// Token: 0x06023D4D RID: 146765 RVA: 0x000C22C8 File Offset: 0x000C04C8
		[Token(Token = "0x6023D4D")]
		[Address(RVA = "0x1E73E90", Offset = "0x1E72A90", VA = "0x181E73E90")]
		public bool IsShowResetFocus()
		{
			return default(bool);
		}

		// Token: 0x06023D4E RID: 146766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D4E")]
		[Address(RVA = "0x1E75210", Offset = "0x1E73E10", VA = "0x181E75210")]
		public void UpdateZoneArrow(List<CampaignWorldSwitchTweenObj> arrows, RectTransform arrowContainer)
		{
		}

		// Token: 0x06023D4F RID: 146767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D4F")]
		[Address(RVA = "0x1E74610", Offset = "0x1E73210", VA = "0x181E74610")]
		public void PlayRegionFogDisappear()
		{
		}

		// Token: 0x06023D50 RID: 146768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D50")]
		[Address(RVA = "0x1E73FF0", Offset = "0x1E72BF0", VA = "0x181E73FF0")]
		public void JumpToZonePageOnZoneClicked(string zoneId)
		{
		}

		// Token: 0x06023D51 RID: 146769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D51")]
		[Address(RVA = "0x1E73F30", Offset = "0x1E72B30", VA = "0x181E73F30")]
		public void JumpToZonePageFromMission(string stageId, bool isToBreakingDetail)
		{
		}

		// Token: 0x06023D52 RID: 146770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D52")]
		[Address(RVA = "0x1E74CD0", Offset = "0x1E738D0", VA = "0x181E74CD0")]
		public void SetShowFadeFloatPanel(bool isShow, float duration = 0.23f)
		{
		}

		// Token: 0x06023D53 RID: 146771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D53")]
		[Address(RVA = "0x1E74C30", Offset = "0x1E73830", VA = "0x181E74C30")]
		public void SetPageRaycastBlock(bool flag)
		{
		}

		// Token: 0x06023D54 RID: 146772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D54")]
		[Address(RVA = "0x1E74730", Offset = "0x1E73330", VA = "0x181E74730")]
		public void RegisterZoneButtonForAVG(string zoneId)
		{
		}

		// Token: 0x06023D55 RID: 146773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D55")]
		[Address(RVA = "0x1E75090", Offset = "0x1E73C90", VA = "0x181E75090")]
		public void UpdateCachedRotateStageId()
		{
		}

		// Token: 0x06023D56 RID: 146774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D56")]
		[Address(RVA = "0x1E74F10", Offset = "0x1E73B10", VA = "0x181E74F10")]
		public void UpdateCachedBriefId()
		{
		}

		// Token: 0x06023D57 RID: 146775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D57")]
		[Address(RVA = "0x1E76C50", Offset = "0x1E75850", VA = "0x181E76C50")]
		private IEnumerator _RouteToHomeCoroutine(bool fastMode)
		{
			return null;
		}

		// Token: 0x06023D58 RID: 146776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D58")]
		[Address(RVA = "0x1E76D20", Offset = "0x1E75920", VA = "0x181E76D20")]
		private IEnumerator _RouteToZonePageCoroutine()
		{
			return null;
		}

		// Token: 0x06023D59 RID: 146777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D59")]
		[Address(RVA = "0x1E76B30", Offset = "0x1E75730", VA = "0x181E76B30")]
		private IEnumerator _JumpToZonePageCoroutine(string zoneId, [Optional] string stageId, bool isToBreakingDetail = false, bool fastMode = false)
		{
			return null;
		}

		// Token: 0x06023D5A RID: 146778 RVA: 0x000C22E0 File Offset: 0x000C04E0
		[Token(Token = "0x6023D5A")]
		[Address(RVA = "0x1E75FE0", Offset = "0x1E74BE0", VA = "0x181E75FE0")]
		private bool _IsStageInCameraBounds(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06023D5B RID: 146779 RVA: 0x000C22F8 File Offset: 0x000C04F8
		[Token(Token = "0x6023D5B")]
		[Address(RVA = "0x1E76300", Offset = "0x1E74F00", VA = "0x181E76300")]
		private bool _IsZoneInCameraBounds(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06023D5C RID: 146780 RVA: 0x000C2310 File Offset: 0x000C0510
		[Token(Token = "0x6023D5C")]
		[Address(RVA = "0x1E75E20", Offset = "0x1E74A20", VA = "0x181E75E20")]
		private Vector3 _GetZoneWorldPosition(string zoneId)
		{
			return default(Vector3);
		}

		// Token: 0x06023D5D RID: 146781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D5D")]
		[Address(RVA = "0x1E73AD0", Offset = "0x1E726D0", VA = "0x181E73AD0")]
		public static DataBundle DataBundleToCampaignZone(string zoneId, string stageId)
		{
			return null;
		}

		// Token: 0x06023D5E RID: 146782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D5E")]
		[Address(RVA = "0x1E748E0", Offset = "0x1E734E0", VA = "0x181E748E0")]
		public static UIPageControllerParam SceneParamToCampaign(DataBundle bundleToJumpBack)
		{
			return null;
		}

		// Token: 0x06023D5F RID: 146783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D5F")]
		[Address(RVA = "0x1E76DD0", Offset = "0x1E759D0", VA = "0x181E76DD0")]
		public CampaignPage()
		{
		}

		// Token: 0x06023D61 RID: 146785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D61")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06023D62 RID: 146786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D62")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06023D63 RID: 146787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D63")]
		[Address(RVA = "0x12C3F80", Offset = "0x12C2B80", VA = "0x1812C3F80")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x06023D64 RID: 146788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D64")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x06023D65 RID: 146789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D65")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x06023D66 RID: 146790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023D66")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x04031B04 RID: 203524
		[Token(Token = "0x4031B04")]
		private const string ANIM_WORLD_ENTER = "anim_world_enter";

		// Token: 0x04031B05 RID: 203525
		[Token(Token = "0x4031B05")]
		private const string ANIM_WORLD_FORWARD_TO_ZONE = "anim_world_forward_to_zone";

		// Token: 0x04031B06 RID: 203526
		[Token(Token = "0x4031B06")]
		private const string ANIM_WORLD_BACK_FROM_ZONE = "anim_world_back_from_zone";

		// Token: 0x04031B07 RID: 203527
		[Token(Token = "0x4031B07")]
		private const float ANIM_WORLD_ENTER_TIME = 0.33f;

		// Token: 0x04031B08 RID: 203528
		[Token(Token = "0x4031B08")]
		private const float ANIM_FORWARD_TO_TIME = 0.2f;

		// Token: 0x04031B09 RID: 203529
		[Token(Token = "0x4031B09")]
		private const float ANIM_BACK_FROM_TIME = 0.5f;

		// Token: 0x04031B0A RID: 203530
		[Token(Token = "0x4031B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CampaignWorldView _worldViewPrefab;

		// Token: 0x04031B0B RID: 203531
		[Token(Token = "0x4031B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _worldViewContainer;

		// Token: 0x04031B0C RID: 203532
		[Token(Token = "0x4031B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CampaignWorldCameraController _cameraController;

		// Token: 0x04031B0D RID: 203533
		[Token(Token = "0x4031B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Camera _cameraFront;

		// Token: 0x04031B0E RID: 203534
		[Token(Token = "0x4031B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04031B0F RID: 203535
		[Token(Token = "0x4031B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private UIFullScreenImage _panelRaycastBlock;

		// Token: 0x04031B10 RID: 203536
		[Token(Token = "0x4031B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private CanvasGroup _fadeFloatPanel;

		// Token: 0x04031B11 RID: 203537
		[Token(Token = "0x4031B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private CampaignWorldViewProperty m_worldProperty;

		// Token: 0x04031B12 RID: 203538
		[Token(Token = "0x4031B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private CampaignWorldHomeBriefViewProperty m_homeBriefProperty;

		// Token: 0x04031B13 RID: 203539
		[Token(Token = "0x4031B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private CampaignFeeViewProperty m_feeProperty;

		// Token: 0x04031B14 RID: 203540
		[Token(Token = "0x4031B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private CampaignWorldView m_worldView;

		// Token: 0x04031B15 RID: 203541
		[Token(Token = "0x4031B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool m_isPaused;

		// Token: 0x04031B16 RID: 203542
		[Token(Token = "0x4031B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Tween m_fadeFloatTweener;

		// Token: 0x04031B17 RID: 203543
		[Token(Token = "0x4031B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private DataBundle m_savedInst;

		// Token: 0x04031B19 RID: 203545
		[Token(Token = "0x4031B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_worldProperty;

		// Token: 0x04031B1A RID: 203546
		[Token(Token = "0x4031B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeBriefProperty;

		// Token: 0x04031B1B RID: 203547
		[Token(Token = "0x4031B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_feeProperty;

		// Token: 0x04031B1C RID: 203548
		[Token(Token = "0x4031B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_worldModel;

		// Token: 0x04031B1D RID: 203549
		[Token(Token = "0x4031B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isToZonePage;

		// Token: 0x04031B1E RID: 203550
		[Token(Token = "0x4031B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isToZonePage;

		// Token: 0x04031B1F RID: 203551
		[Token(Token = "0x4031B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_zoneIdOnOpen;

		// Token: 0x04031B20 RID: 203552
		[Token(Token = "0x4031B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_stageIdOnOpen;

		// Token: 0x04031B21 RID: 203553
		[Token(Token = "0x4031B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04031B22 RID: 203554
		[Token(Token = "0x4031B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04031B23 RID: 203555
		[Token(Token = "0x4031B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x04031B24 RID: 203556
		[Token(Token = "0x4031B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04031B25 RID: 203557
		[Token(Token = "0x4031B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x04031B26 RID: 203558
		[Token(Token = "0x4031B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04031B27 RID: 203559
		[Token(Token = "0x4031B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnWorldViewInited;

		// Token: 0x04031B28 RID: 203560
		[Token(Token = "0x4031B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnZoneClicked;

		// Token: 0x04031B29 RID: 203561
		[Token(Token = "0x4031B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EnableMobileTouch;

		// Token: 0x04031B2A RID: 203562
		[Token(Token = "0x4031B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CameraLock;

		// Token: 0x04031B2B RID: 203563
		[Token(Token = "0x4031B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CameraFocusStage;

		// Token: 0x04031B2C RID: 203564
		[Token(Token = "0x4031B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CameraFocusZone;

		// Token: 0x04031B2D RID: 203565
		[Token(Token = "0x4031B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CameraResetFocus;

		// Token: 0x04031B2E RID: 203566
		[Token(Token = "0x4031B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IsShowResetFocus;

		// Token: 0x04031B2F RID: 203567
		[Token(Token = "0x4031B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_UpdateZoneArrow;

		// Token: 0x04031B30 RID: 203568
		[Token(Token = "0x4031B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_PlayRegionFogDisappear;

		// Token: 0x04031B31 RID: 203569
		[Token(Token = "0x4031B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_JumpToZonePageOnZoneClicked;

		// Token: 0x04031B32 RID: 203570
		[Token(Token = "0x4031B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_JumpToZonePageFromMission;

		// Token: 0x04031B33 RID: 203571
		[Token(Token = "0x4031B33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SetShowFadeFloatPanel;

		// Token: 0x04031B34 RID: 203572
		[Token(Token = "0x4031B34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SetPageRaycastBlock;

		// Token: 0x04031B35 RID: 203573
		[Token(Token = "0x4031B35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RegisterZoneButtonForAVG;

		// Token: 0x04031B36 RID: 203574
		[Token(Token = "0x4031B36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_UpdateCachedRotateStageId;

		// Token: 0x04031B37 RID: 203575
		[Token(Token = "0x4031B37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_UpdateCachedBriefId;

		// Token: 0x04031B38 RID: 203576
		[Token(Token = "0x4031B38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RouteToHomeCoroutine;

		// Token: 0x04031B39 RID: 203577
		[Token(Token = "0x4031B39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__RouteToZonePageCoroutine;

		// Token: 0x04031B3A RID: 203578
		[Token(Token = "0x4031B3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__JumpToZonePageCoroutine;

		// Token: 0x04031B3B RID: 203579
		[Token(Token = "0x4031B3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__IsStageInCameraBounds;

		// Token: 0x04031B3C RID: 203580
		[Token(Token = "0x4031B3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__IsZoneInCameraBounds;

		// Token: 0x04031B3D RID: 203581
		[Token(Token = "0x4031B3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__GetZoneWorldPosition;

		// Token: 0x04031B3E RID: 203582
		[Token(Token = "0x4031B3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_DataBundleToCampaignZone;

		// Token: 0x04031B3F RID: 203583
		[Token(Token = "0x4031B3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_SceneParamToCampaign;

		// Token: 0x04031B40 RID: 203584
		[Token(Token = "0x4031B40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020060D6 RID: 24790
		[Token(Token = "0x20060D6")]
		public class Params
		{
			// Token: 0x06023D67 RID: 146791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023D67")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04031B41 RID: 203585
			[Token(Token = "0x4031B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04031B42 RID: 203586
			[Token(Token = "0x4031B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string stageId;
		}
	}
}
