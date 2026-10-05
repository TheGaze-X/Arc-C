using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.CrisisV2;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069A4 RID: 27044
	[Token(Token = "0x20069A4")]
	public class StageZoneHomeMainGroupPanel : StageZoneGroupPanel, IHotfixable
	{
		// Token: 0x06026B1C RID: 158492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B1C")]
		[Address(RVA = "0x21C19A0", Offset = "0x21C05A0", VA = "0x1821C19A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026B1D RID: 158493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B1D")]
		[Address(RVA = "0x21C12B0", Offset = "0x21BFEB0", VA = "0x1821C12B0", Slot = "8")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026B1E RID: 158494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B1E")]
		[Address(RVA = "0x21C1200", Offset = "0x21BFE00", VA = "0x1821C1200", Slot = "9")]
		protected override void OnDataUpdated(ZoneGroupViewProperty prop)
		{
		}

		// Token: 0x06026B1F RID: 158495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026B1F")]
		[Address(RVA = "0x21C0F80", Offset = "0x21BFB80", VA = "0x1821C0F80", Slot = "10")]
		protected override IEnumerator EnterYieldInstruction()
		{
			return null;
		}

		// Token: 0x06026B20 RID: 158496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B20")]
		[Address(RVA = "0x21C0EB0", Offset = "0x21BFAB0", VA = "0x1821C0EB0", Slot = "12")]
		protected override void CancelEnter()
		{
		}

		// Token: 0x06026B21 RID: 158497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026B21")]
		[Address(RVA = "0x21C1030", Offset = "0x21BFC30", VA = "0x1821C1030", Slot = "11")]
		protected override IEnumerator ExitYieldInstruction()
		{
			return null;
		}

		// Token: 0x06026B22 RID: 158498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B22")]
		[Address(RVA = "0x21C0F10", Offset = "0x21BFB10", VA = "0x1821C0F10", Slot = "13")]
		protected override void CancelExit()
		{
		}

		// Token: 0x06026B23 RID: 158499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B23")]
		[Address(RVA = "0x21C1440", Offset = "0x21C0040", VA = "0x1821C1440")]
		private void Update()
		{
		}

		// Token: 0x06026B24 RID: 158500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B24")]
		[Address(RVA = "0x21C3AF0", Offset = "0x21C26F0", VA = "0x1821C3AF0")]
		private void _OnScalerChanged(CanvasScaler scaler)
		{
		}

		// Token: 0x06026B25 RID: 158501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B25")]
		[Address(RVA = "0x21C3490", Offset = "0x21C2090", VA = "0x1821C3490")]
		private void _OnEntryClicked(ZoneHomeEntryItemModel entryModel)
		{
		}

		// Token: 0x06026B26 RID: 158502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B26")]
		[Address(RVA = "0x21C3C80", Offset = "0x21C2880", VA = "0x1821C3C80")]
		private void _OnToDoClicked(ZoneHomeToDoItemModel todoModel)
		{
		}

		// Token: 0x06026B27 RID: 158503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B27")]
		[Address(RVA = "0x21C39E0", Offset = "0x21C25E0", VA = "0x1821C39E0")]
		private void _OnRecentViewClicked()
		{
		}

		// Token: 0x06026B28 RID: 158504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B28")]
		[Address(RVA = "0x21C2A60", Offset = "0x21C1660", VA = "0x1821C2A60")]
		private void _JumpToRecentDefault(string stageId)
		{
		}

		// Token: 0x06026B29 RID: 158505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B29")]
		[Address(RVA = "0x21C33C0", Offset = "0x21C1FC0", VA = "0x1821C33C0")]
		private void _OnCrisisDataFetched()
		{
		}

		// Token: 0x06026B2A RID: 158506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B2A")]
		[Address(RVA = "0x21C44A0", Offset = "0x21C30A0", VA = "0x1821C44A0")]
		private void _UpdateData()
		{
		}

		// Token: 0x06026B2B RID: 158507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B2B")]
		[Address(RVA = "0x21C16D0", Offset = "0x21C02D0", VA = "0x1821C16D0")]
		private void _CancelExitTween()
		{
		}

		// Token: 0x06026B2C RID: 158508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B2C")]
		[Address(RVA = "0x21C15A0", Offset = "0x21C01A0", VA = "0x1821C15A0")]
		private void _CancelEnterTweens()
		{
		}

		// Token: 0x06026B2D RID: 158509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B2D")]
		[Address(RVA = "0x21C4400", Offset = "0x21C3000", VA = "0x1821C4400")]
		private void _StartRequestForCrisisData()
		{
		}

		// Token: 0x06026B2E RID: 158510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026B2E")]
		[Address(RVA = "0x21C18F0", Offset = "0x21C04F0", VA = "0x1821C18F0")]
		private CrisisV2ServerDataWrapper _GetValidCrisisData()
		{
			return null;
		}

		// Token: 0x06026B2F RID: 158511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026B2F")]
		[Address(RVA = "0x21C48A0", Offset = "0x21C34A0", VA = "0x1821C48A0")]
		private IEnumerator _UpdateLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x06026B30 RID: 158512 RVA: 0x000CC0A8 File Offset: 0x000CA2A8
		[Token(Token = "0x6026B30")]
		[Address(RVA = "0x21C1770", Offset = "0x21C0370", VA = "0x1821C1770")]
		private static bool _CheckIfEntryLocked(ZoneHomeEntryItemModel model)
		{
			return default(bool);
		}

		// Token: 0x06026B31 RID: 158513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B31")]
		[Address(RVA = "0x21C2710", Offset = "0x21C1310", VA = "0x1821C2710")]
		private void _JumpToMainlineZone(ZoneHomeEntryItemModel entryModel)
		{
		}

		// Token: 0x06026B32 RID: 158514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B32")]
		[Address(RVA = "0x21C2D50", Offset = "0x21C1950", VA = "0x1821C2D50")]
		private void _JumpToRoguelike(ZoneHomeEntryItemModel entryModel)
		{
		}

		// Token: 0x06026B33 RID: 158515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B33")]
		[Address(RVA = "0x21C2E30", Offset = "0x21C1A30", VA = "0x1821C2E30")]
		private void _JumpToRoguelike(ZoneHomeToDoItemModel todoModel)
		{
		}

		// Token: 0x06026B34 RID: 158516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B34")]
		[Address(RVA = "0x21C2CA0", Offset = "0x21C18A0", VA = "0x1821C2CA0")]
		private void _JumpToRoguelikeByTopicId(string topicId)
		{
		}

		// Token: 0x06026B35 RID: 158517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B35")]
		[Address(RVA = "0x21C3000", Offset = "0x21C1C00", VA = "0x1821C3000")]
		private void _JumpToSandboxPerm(ZoneHomeEntryItemModel itemModel)
		{
		}

		// Token: 0x06026B36 RID: 158518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B36")]
		[Address(RVA = "0x21C30E0", Offset = "0x21C1CE0", VA = "0x1821C30E0")]
		private void _JumpToSandboxPerm(ZoneHomeToDoItemModel todoModel)
		{
		}

		// Token: 0x06026B37 RID: 158519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B37")]
		[Address(RVA = "0x21C32B0", Offset = "0x21C1EB0", VA = "0x1821C32B0")]
		private void _JumpToVecBreakV2Defense(ZoneHomeToDoItemModel todoModel)
		{
		}

		// Token: 0x06026B38 RID: 158520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B38")]
		[Address(RVA = "0x21C2F40", Offset = "0x21C1B40", VA = "0x1821C2F40")]
		private void _JumpToSandboxPermByTopicId(string topicId)
		{
		}

		// Token: 0x06026B39 RID: 158521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B39")]
		[Address(RVA = "0x21C2110", Offset = "0x21C0D10", VA = "0x1821C2110")]
		private void _JumpToCampaignWeekly(ZoneHomeToDoItemModel itemModel)
		{
		}

		// Token: 0x06026B3A RID: 158522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B3A")]
		[Address(RVA = "0x21C1FD0", Offset = "0x21C0BD0", VA = "0x1821C1FD0")]
		private void _JumpToCampaignStage(string stageId)
		{
		}

		// Token: 0x06026B3B RID: 158523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B3B")]
		[Address(RVA = "0x21C2290", Offset = "0x21C0E90", VA = "0x1821C2290")]
		private void _JumpToClimbTowerStage(ZoneHomeToDoItemModel todoModel)
		{
		}

		// Token: 0x06026B3C RID: 158524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B3C")]
		[Address(RVA = "0x21C2410", Offset = "0x21C1010", VA = "0x1821C2410")]
		private void _JumpToCrisisV2Stage(ZoneHomeToDoItemModel todoModel)
		{
		}

		// Token: 0x06026B3D RID: 158525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B3D")]
		[Address(RVA = "0x21C2590", Offset = "0x21C1190", VA = "0x1821C2590")]
		private void _JumpToCrisisV2Stage(ZoneHomeEntryItemModel entryModel)
		{
		}

		// Token: 0x06026B3E RID: 158526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B3E")]
		[Address(RVA = "0x21C1DD0", Offset = "0x21C09D0", VA = "0x1821C1DD0")]
		private void _JumpToActivity(ZoneHomeEntryItemModel entryModel)
		{
		}

		// Token: 0x06026B3F RID: 158527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B3F")]
		[Address(RVA = "0x21C31D0", Offset = "0x21C1DD0", VA = "0x1821C31D0")]
		private void _JumpToStageActivity(string actId)
		{
		}

		// Token: 0x06026B40 RID: 158528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B40")]
		[Address(RVA = "0x21C2830", Offset = "0x21C1430", VA = "0x1821C2830")]
		private void _JumpToPageEntryActivity(string actId)
		{
		}

		// Token: 0x06026B41 RID: 158529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026B41")]
		[Address(RVA = "0x21C1840", Offset = "0x21C0440", VA = "0x1821C1840")]
		private IEnumerator _ExitYieldToActivity()
		{
			return null;
		}

		// Token: 0x06026B42 RID: 158530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B42")]
		[Address(RVA = "0x21C4950", Offset = "0x21C3550", VA = "0x1821C4950")]
		public StageZoneHomeMainGroupPanel()
		{
		}

		// Token: 0x06026B43 RID: 158531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B43")]
		[Address(RVA = "0x21BDE90", Offset = "0x21BCA90", VA = "0x1821BDE90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026B44 RID: 158532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B44")]
		[Address(RVA = "0x21BDE30", Offset = "0x21BCA30", VA = "0x1821BDE30")]
		private void <>xLuaBaseProxy_OnDataUpdated(ZoneGroupViewProperty P0)
		{
		}

		// Token: 0x06026B45 RID: 158533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026B45")]
		[Address(RVA = "0x21C1380", Offset = "0x21BFF80", VA = "0x1821C1380")]
		private IEnumerator <>xLuaBaseProxy_EnterYieldInstruction()
		{
			return null;
		}

		// Token: 0x06026B46 RID: 158534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B46")]
		[Address(RVA = "0x21C1360", Offset = "0x21BFF60", VA = "0x1821C1360")]
		private void <>xLuaBaseProxy_CancelEnter()
		{
		}

		// Token: 0x06026B47 RID: 158535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026B47")]
		[Address(RVA = "0x21C1430", Offset = "0x21C0030", VA = "0x1821C1430")]
		private IEnumerator <>xLuaBaseProxy_ExitYieldInstruction()
		{
			return null;
		}

		// Token: 0x06026B48 RID: 158536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B48")]
		[Address(RVA = "0x21C1370", Offset = "0x21BFF70", VA = "0x1821C1370")]
		private void <>xLuaBaseProxy_CancelExit()
		{
		}

		// Token: 0x040369F7 RID: 223735
		[Token(Token = "0x40369F7")]
		private const float FADE_DUR_TO_ACT = 0.16f;

		// Token: 0x040369F8 RID: 223736
		[Token(Token = "0x40369F8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StageZoneHomeEntryBinder _entryBinder;

		// Token: 0x040369F9 RID: 223737
		[Token(Token = "0x40369F9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private StageZoneHomeToDoBinder _todoBinder;

		// Token: 0x040369FA RID: 223738
		[Token(Token = "0x40369FA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _recentViewHolder;

		// Token: 0x040369FB RID: 223739
		[Token(Token = "0x40369FB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private StageZoneHomeRecentView _recentViewPrefab;

		// Token: 0x040369FC RID: 223740
		[Token(Token = "0x40369FC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private StageZoneHomeThemeView _themeView;

		// Token: 0x040369FD RID: 223741
		[Token(Token = "0x40369FD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("EnterTween")]
		private CanvasGroup _alphaBkg;

		// Token: 0x040369FE RID: 223742
		[Token(Token = "0x40369FE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("EnterTween")]
		private CanvasGroup _alphaContent;

		// Token: 0x040369FF RID: 223743
		[Token(Token = "0x40369FF")]
		[FieldOffset(Offset = "0x98")]
		private ZoneHomeEntryGroupProp m_entryProp;

		// Token: 0x04036A00 RID: 223744
		[Token(Token = "0x4036A00")]
		[FieldOffset(Offset = "0xA0")]
		private ZoneHomeToDoGroupProp m_todoProp;

		// Token: 0x04036A01 RID: 223745
		[Token(Token = "0x4036A01")]
		[FieldOffset(Offset = "0xA8")]
		private ZoneHomeRecentViewProp m_recentProp;

		// Token: 0x04036A02 RID: 223746
		[Token(Token = "0x4036A02")]
		[FieldOffset(Offset = "0xB0")]
		private ZoneHomeThemeViewProp m_themeProp;

		// Token: 0x04036A03 RID: 223747
		[Token(Token = "0x4036A03")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x04036A04 RID: 223748
		[Token(Token = "0x4036A04")]
		[FieldOffset(Offset = "0xC0")]
		private StageZoneHomeRecentView m_recentBinder;

		// Token: 0x04036A05 RID: 223749
		[Token(Token = "0x4036A05")]
		[FieldOffset(Offset = "0xC8")]
		private CrisisV2DataFromServer m_crisisData;

		// Token: 0x04036A06 RID: 223750
		[Token(Token = "0x4036A06")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_requestingCrisisData;

		// Token: 0x04036A07 RID: 223751
		[Token(Token = "0x4036A07")]
		[FieldOffset(Offset = "0xD8")]
		private List<Tween> m_enterTweens;

		// Token: 0x04036A08 RID: 223752
		[Token(Token = "0x4036A08")]
		[FieldOffset(Offset = "0xE0")]
		private Tween m_exitTween;

		// Token: 0x04036A09 RID: 223753
		[Token(Token = "0x4036A09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036A0A RID: 223754
		[Token(Token = "0x4036A0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036A0B RID: 223755
		[Token(Token = "0x4036A0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04036A0C RID: 223756
		[Token(Token = "0x4036A0C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EnterYieldInstruction;

		// Token: 0x04036A0D RID: 223757
		[Token(Token = "0x4036A0D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CancelEnter;

		// Token: 0x04036A0E RID: 223758
		[Token(Token = "0x4036A0E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ExitYieldInstruction;

		// Token: 0x04036A0F RID: 223759
		[Token(Token = "0x4036A0F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CancelExit;

		// Token: 0x04036A10 RID: 223760
		[Token(Token = "0x4036A10")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04036A11 RID: 223761
		[Token(Token = "0x4036A11")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnScalerChanged;

		// Token: 0x04036A12 RID: 223762
		[Token(Token = "0x4036A12")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnEntryClicked;

		// Token: 0x04036A13 RID: 223763
		[Token(Token = "0x4036A13")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnToDoClicked;

		// Token: 0x04036A14 RID: 223764
		[Token(Token = "0x4036A14")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnRecentViewClicked;

		// Token: 0x04036A15 RID: 223765
		[Token(Token = "0x4036A15")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__JumpToRecentDefault;

		// Token: 0x04036A16 RID: 223766
		[Token(Token = "0x4036A16")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnCrisisDataFetched;

		// Token: 0x04036A17 RID: 223767
		[Token(Token = "0x4036A17")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04036A18 RID: 223768
		[Token(Token = "0x4036A18")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CancelExitTween;

		// Token: 0x04036A19 RID: 223769
		[Token(Token = "0x4036A19")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CancelEnterTweens;

		// Token: 0x04036A1A RID: 223770
		[Token(Token = "0x4036A1A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__StartRequestForCrisisData;

		// Token: 0x04036A1B RID: 223771
		[Token(Token = "0x4036A1B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetValidCrisisData;

		// Token: 0x04036A1C RID: 223772
		[Token(Token = "0x4036A1C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdateLayoutCoroutine;

		// Token: 0x04036A1D RID: 223773
		[Token(Token = "0x4036A1D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckIfEntryLocked;

		// Token: 0x04036A1E RID: 223774
		[Token(Token = "0x4036A1E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__JumpToMainlineZone;

		// Token: 0x04036A1F RID: 223775
		[Token(Token = "0x4036A1F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__JumpToRoguelike;

		// Token: 0x04036A20 RID: 223776
		[Token(Token = "0x4036A20")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix1__JumpToRoguelike;

		// Token: 0x04036A21 RID: 223777
		[Token(Token = "0x4036A21")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__JumpToRoguelikeByTopicId;

		// Token: 0x04036A22 RID: 223778
		[Token(Token = "0x4036A22")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__JumpToSandboxPerm;

		// Token: 0x04036A23 RID: 223779
		[Token(Token = "0x4036A23")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix1__JumpToSandboxPerm;

		// Token: 0x04036A24 RID: 223780
		[Token(Token = "0x4036A24")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__JumpToVecBreakV2Defense;

		// Token: 0x04036A25 RID: 223781
		[Token(Token = "0x4036A25")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__JumpToSandboxPermByTopicId;

		// Token: 0x04036A26 RID: 223782
		[Token(Token = "0x4036A26")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__JumpToCampaignWeekly;

		// Token: 0x04036A27 RID: 223783
		[Token(Token = "0x4036A27")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__JumpToCampaignStage;

		// Token: 0x04036A28 RID: 223784
		[Token(Token = "0x4036A28")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__JumpToClimbTowerStage;

		// Token: 0x04036A29 RID: 223785
		[Token(Token = "0x4036A29")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__JumpToCrisisV2Stage;

		// Token: 0x04036A2A RID: 223786
		[Token(Token = "0x4036A2A")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix1__JumpToCrisisV2Stage;

		// Token: 0x04036A2B RID: 223787
		[Token(Token = "0x4036A2B")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__JumpToActivity;

		// Token: 0x04036A2C RID: 223788
		[Token(Token = "0x4036A2C")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__JumpToStageActivity;

		// Token: 0x04036A2D RID: 223789
		[Token(Token = "0x4036A2D")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__JumpToPageEntryActivity;

		// Token: 0x04036A2E RID: 223790
		[Token(Token = "0x4036A2E")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__ExitYieldToActivity;

		// Token: 0x04036A2F RID: 223791
		[Token(Token = "0x4036A2F")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
