using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B29 RID: 19241
	[Token(Token = "0x2004B29")]
	public class HomeSecretarySkinChangeState : HomeReplaceableState, IValueMsgReceiver
	{
		// Token: 0x0601CF8D RID: 118669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF8D")]
		[Address(RVA = "0x16762E0", Offset = "0x1674EE0", VA = "0x1816762E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CF8E RID: 118670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF8E")]
		[Address(RVA = "0x16771B0", Offset = "0x1675DB0", VA = "0x1816771B0")]
		private void _StartPreviewMode()
		{
		}

		// Token: 0x0601CF8F RID: 118671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF8F")]
		[Address(RVA = "0x1675970", Offset = "0x1674570", VA = "0x181675970")]
		private void _ExitPreviewMode()
		{
		}

		// Token: 0x0601CF90 RID: 118672 RVA: 0x000A9E78 File Offset: 0x000A8078
		[Token(Token = "0x601CF90")]
		[Address(RVA = "0x1676560", Offset = "0x1675160", VA = "0x181676560")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601CF91 RID: 118673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF91")]
		[Address(RVA = "0x1676620", Offset = "0x1675220", VA = "0x181676620")]
		private void _ModifyIllustViewConfig(bool show)
		{
		}

		// Token: 0x0601CF92 RID: 118674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF92")]
		[Address(RVA = "0x16772A0", Offset = "0x1675EA0", VA = "0x1816772A0")]
		private void _SyncIllustView()
		{
		}

		// Token: 0x0601CF93 RID: 118675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF93")]
		[Address(RVA = "0x1677310", Offset = "0x1675F10", VA = "0x181677310")]
		private void _UpdateIllustView(bool show)
		{
		}

		// Token: 0x0601CF94 RID: 118676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF94")]
		[Address(RVA = "0x16758F0", Offset = "0x16744F0", VA = "0x1816758F0")]
		private void _DisposeIllustConfig()
		{
		}

		// Token: 0x0601CF95 RID: 118677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF95")]
		[Address(RVA = "0x16744D0", Offset = "0x16730D0", VA = "0x1816744D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CF96 RID: 118678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF96")]
		[Address(RVA = "0x16746C0", Offset = "0x16732C0", VA = "0x1816746C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CF97 RID: 118679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF97")]
		[Address(RVA = "0x1675060", Offset = "0x1673C60", VA = "0x181675060", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601CF98 RID: 118680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF98")]
		[Address(RVA = "0x16748F0", Offset = "0x16734F0", VA = "0x1816748F0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601CF99 RID: 118681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF99")]
		[Address(RVA = "0x1674650", Offset = "0x1673250", VA = "0x181674650")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0601CF9A RID: 118682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF9A")]
		[Address(RVA = "0x1675240", Offset = "0x1673E40", VA = "0x181675240", Slot = "29")]
		protected override IEnumerator ShowEffect(HomeReplaceableState extractState)
		{
			return null;
		}

		// Token: 0x0601CF9B RID: 118683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF9B")]
		[Address(RVA = "0x1674530", Offset = "0x1673130", VA = "0x181674530", Slot = "30")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x0601CF9C RID: 118684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF9C")]
		[Address(RVA = "0x1675310", Offset = "0x1673F10", VA = "0x181675310", Slot = "31")]
		protected override void ShowFastMode()
		{
		}

		// Token: 0x0601CF9D RID: 118685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF9D")]
		[Address(RVA = "0x16745E0", Offset = "0x16731E0", VA = "0x1816745E0", Slot = "32")]
		protected override void HideFastMode()
		{
		}

		// Token: 0x0601CF9E RID: 118686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF9E")]
		[Address(RVA = "0x16750D0", Offset = "0x1673CD0", VA = "0x1816750D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CF9F RID: 118687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF9F")]
		[Address(RVA = "0x1674960", Offset = "0x1673560", VA = "0x181674960", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601CFA0 RID: 118688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFA0")]
		[Address(RVA = "0x1676980", Offset = "0x1675580", VA = "0x181676980")]
		private void _OnSkinItemClicked(string skinTag)
		{
		}

		// Token: 0x0601CFA1 RID: 118689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFA1")]
		[Address(RVA = "0x16767A0", Offset = "0x16753A0", VA = "0x1816767A0")]
		private void _OnCancel()
		{
		}

		// Token: 0x0601CFA2 RID: 118690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFA2")]
		[Address(RVA = "0x1676D00", Offset = "0x1675900", VA = "0x181676D00")]
		private void _SavePresetSlots()
		{
		}

		// Token: 0x0601CFA3 RID: 118691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFA3")]
		[Address(RVA = "0x1675820", Offset = "0x1674420", VA = "0x181675820")]
		private void _CleanAllSelect()
		{
		}

		// Token: 0x0601CFA4 RID: 118692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFA4")]
		[Address(RVA = "0x1676B50", Offset = "0x1675750", VA = "0x181676B50")]
		private void _OpenSelectCharState()
		{
		}

		// Token: 0x0601CFA5 RID: 118693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFA5")]
		[Address(RVA = "0x1676AB0", Offset = "0x16756B0", VA = "0x181676AB0")]
		private void _OpenIllustEditState()
		{
		}

		// Token: 0x0601CFA6 RID: 118694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFA6")]
		[Address(RVA = "0x1676830", Offset = "0x1675430", VA = "0x181676830")]
		private void _OnFilterClicked(object objVal)
		{
		}

		// Token: 0x0601CFA7 RID: 118695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFA7")]
		[Address(RVA = "0x1675A90", Offset = "0x1674690", VA = "0x181675A90")]
		private void _GenerateNewRotationListIfNeed(string instId, CharUISkinStruct secretarySkin)
		{
		}

		// Token: 0x0601CFA8 RID: 118696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CFA8")]
		[Address(RVA = "0x1675F60", Offset = "0x1674B60", VA = "0x181675F60")]
		private static List<string> _GetSkinTagListFromPlayerPreset(string instId)
		{
			return null;
		}

		// Token: 0x0601CFA9 RID: 118697 RVA: 0x000A9E90 File Offset: 0x000A8090
		[Token(Token = "0x601CFA9")]
		[Address(RVA = "0x1675550", Offset = "0x1674150", VA = "0x181675550")]
		private bool _CheckIfMatchWithPlayerData(string playerPresetInstId, List<CharRotationUpdatePresetRequest.Slot> savedPresetSlots)
		{
			return default(bool);
		}

		// Token: 0x0601CFAA RID: 118698 RVA: 0x000A9EA8 File Offset: 0x000A80A8
		[Token(Token = "0x601CFAA")]
		[Address(RVA = "0x1675C20", Offset = "0x1674820", VA = "0x181675C20")]
		private static bool _GetNewSecretarySkin(List<CharRotationUpdatePresetRequest.Slot> newSlots, CharUISkinStruct prevSecretarySkin, out CharUISkinStruct newSecretarySkin)
		{
			return default(bool);
		}

		// Token: 0x0601CFAB RID: 118699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFAB")]
		[Address(RVA = "0x1677530", Offset = "0x1676130", VA = "0x181677530")]
		public HomeSecretarySkinChangeState()
		{
		}

		// Token: 0x0601CFAF RID: 118703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFAF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CFB0 RID: 118704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFB0")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601CFB1 RID: 118705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFB1")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601CFB2 RID: 118706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CFB2")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402600F RID: 155663
		[Token(Token = "0x402600F")]
		[NonSerialized]
		public const int ON_SKIN_ITEM_CLICKED = 0;

		// Token: 0x04026010 RID: 155664
		[Token(Token = "0x4026010")]
		[NonSerialized]
		public const int ON_CONFIRM_CLICKED = 1;

		// Token: 0x04026011 RID: 155665
		[Token(Token = "0x4026011")]
		[NonSerialized]
		public const int ON_CANCEL_CLICKED = 2;

		// Token: 0x04026012 RID: 155666
		[Token(Token = "0x4026012")]
		[NonSerialized]
		public const int ON_CLEAN_ALL_CLICKED = 3;

		// Token: 0x04026013 RID: 155667
		[Token(Token = "0x4026013")]
		[NonSerialized]
		public const int OPEN_SELECT_CHAR_STATE = 4;

		// Token: 0x04026014 RID: 155668
		[Token(Token = "0x4026014")]
		[NonSerialized]
		public const int ON_ILLUST_EDIT_CLICKED = 5;

		// Token: 0x04026015 RID: 155669
		[Token(Token = "0x4026015")]
		[NonSerialized]
		public const int ON_FILTER_CLICKED = 6;

		// Token: 0x04026016 RID: 155670
		[Token(Token = "0x4026016")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _alphaFadePart;

		// Token: 0x04026017 RID: 155671
		[Token(Token = "0x4026017")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _alphaNormPart1;

		// Token: 0x04026018 RID: 155672
		[Token(Token = "0x4026018")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _alphaNormPart2;

		// Token: 0x04026019 RID: 155673
		[Token(Token = "0x4026019")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x0402601A RID: 155674
		[Token(Token = "0x402601A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HomeSecretarySkinChangeView _view;

		// Token: 0x0402601B RID: 155675
		[Token(Token = "0x402601B")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0402601C RID: 155676
		[Token(Token = "0x402601C")]
		[FieldOffset(Offset = "0x8C")]
		private int m_instId;

		// Token: 0x0402601D RID: 155677
		[Token(Token = "0x402601D")]
		[FieldOffset(Offset = "0x90")]
		private HomeSecretaryChangeSkinStateBean m_stateBean;

		// Token: 0x0402601E RID: 155678
		[Token(Token = "0x402601E")]
		[FieldOffset(Offset = "0x98")]
		private HomeSecretaryChangeStateBean.InputParams m_toCharChangeParams;

		// Token: 0x0402601F RID: 155679
		[Token(Token = "0x402601F")]
		[FieldOffset(Offset = "0xA8")]
		private HomeReplaceableState.SwitchTween m_tweenFadePart;

		// Token: 0x04026020 RID: 155680
		[Token(Token = "0x4026020")]
		[FieldOffset(Offset = "0xB0")]
		private HomeReplaceableState.SwitchTween m_tweenNormPart1;

		// Token: 0x04026021 RID: 155681
		[Token(Token = "0x4026021")]
		[FieldOffset(Offset = "0xB8")]
		private HomeReplaceableState.SwitchTween m_tweenNormPart2;

		// Token: 0x04026022 RID: 155682
		[Token(Token = "0x4026022")]
		[FieldOffset(Offset = "0xC0")]
		private HomeIllustView m_illustView;

		// Token: 0x04026023 RID: 155683
		[Token(Token = "0x4026023")]
		[FieldOffset(Offset = "0xC8")]
		private HomeIllustView.DisplayHandler m_IllustDisplayHandler;

		// Token: 0x04026024 RID: 155684
		[Token(Token = "0x4026024")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026025 RID: 155685
		[Token(Token = "0x4026025")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__StartPreviewMode;

		// Token: 0x04026026 RID: 155686
		[Token(Token = "0x4026026")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExitPreviewMode;

		// Token: 0x04026027 RID: 155687
		[Token(Token = "0x4026027")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x04026028 RID: 155688
		[Token(Token = "0x4026028")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ModifyIllustViewConfig;

		// Token: 0x04026029 RID: 155689
		[Token(Token = "0x4026029")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SyncIllustView;

		// Token: 0x0402602A RID: 155690
		[Token(Token = "0x402602A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateIllustView;

		// Token: 0x0402602B RID: 155691
		[Token(Token = "0x402602B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DisposeIllustConfig;

		// Token: 0x0402602C RID: 155692
		[Token(Token = "0x402602C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402602D RID: 155693
		[Token(Token = "0x402602D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402602E RID: 155694
		[Token(Token = "0x402602E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402602F RID: 155695
		[Token(Token = "0x402602F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04026030 RID: 155696
		[Token(Token = "0x4026030")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04026031 RID: 155697
		[Token(Token = "0x4026031")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x04026032 RID: 155698
		[Token(Token = "0x4026032")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x04026033 RID: 155699
		[Token(Token = "0x4026033")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ShowFastMode;

		// Token: 0x04026034 RID: 155700
		[Token(Token = "0x4026034")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HideFastMode;

		// Token: 0x04026035 RID: 155701
		[Token(Token = "0x4026035")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04026036 RID: 155702
		[Token(Token = "0x4026036")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04026037 RID: 155703
		[Token(Token = "0x4026037")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnSkinItemClicked;

		// Token: 0x04026038 RID: 155704
		[Token(Token = "0x4026038")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x04026039 RID: 155705
		[Token(Token = "0x4026039")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SavePresetSlots;

		// Token: 0x0402603A RID: 155706
		[Token(Token = "0x402603A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CleanAllSelect;

		// Token: 0x0402603B RID: 155707
		[Token(Token = "0x402603B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OpenSelectCharState;

		// Token: 0x0402603C RID: 155708
		[Token(Token = "0x402603C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OpenIllustEditState;

		// Token: 0x0402603D RID: 155709
		[Token(Token = "0x402603D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnFilterClicked;

		// Token: 0x0402603E RID: 155710
		[Token(Token = "0x402603E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GenerateNewRotationListIfNeed;

		// Token: 0x0402603F RID: 155711
		[Token(Token = "0x402603F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetSkinTagListFromPlayerPreset;

		// Token: 0x04026040 RID: 155712
		[Token(Token = "0x4026040")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckIfMatchWithPlayerData;

		// Token: 0x04026041 RID: 155713
		[Token(Token = "0x4026041")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetNewSecretarySkin;

		// Token: 0x04026042 RID: 155714
		[Token(Token = "0x4026042")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
