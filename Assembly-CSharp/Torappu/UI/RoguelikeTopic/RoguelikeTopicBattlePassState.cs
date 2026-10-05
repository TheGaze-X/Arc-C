using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200449F RID: 17567
	[Token(Token = "0x200449F")]
	public class RoguelikeTopicBattlePassState : PopupFadeState
	{
		// Token: 0x0601AD41 RID: 109889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD41")]
		[Address(RVA = "0x13F9E80", Offset = "0x13F8A80", VA = "0x1813F9E80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601AD42 RID: 109890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD42")]
		[Address(RVA = "0x13FA0B0", Offset = "0x13F8CB0", VA = "0x1813FA0B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601AD43 RID: 109891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD43")]
		[Address(RVA = "0x13FA230", Offset = "0x13F8E30", VA = "0x1813FA230", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601AD44 RID: 109892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD44")]
		[Address(RVA = "0x13FA810", Offset = "0x13F9410", VA = "0x1813FA810")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AD45 RID: 109893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD45")]
		[Address(RVA = "0x13FA760", Offset = "0x13F9360", VA = "0x1813FA760")]
		private IEnumerator _FocusCurrentLv()
		{
			return null;
		}

		// Token: 0x0601AD46 RID: 109894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD46")]
		[Address(RVA = "0x13FBD00", Offset = "0x13FA900", VA = "0x1813FBD00")]
		private IEnumerator _UpdateGreatRewardModelAfterDelay(int step)
		{
			return null;
		}

		// Token: 0x0601AD47 RID: 109895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD47")]
		[Address(RVA = "0x13FB110", Offset = "0x13F9D10", VA = "0x1813FB110")]
		private void _OnGreatRewardSwitch(bool isReverse)
		{
		}

		// Token: 0x0601AD48 RID: 109896 RVA: 0x000A3710 File Offset: 0x000A1910
		[Token(Token = "0x601AD48")]
		[Address(RVA = "0x13FA6F0", Offset = "0x13F92F0", VA = "0x1813FA6F0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601AD49 RID: 109897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD49")]
		[Address(RVA = "0x13FA2B0", Offset = "0x13F8EB0", VA = "0x1813FA2B0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601AD4A RID: 109898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD4A")]
		[Address(RVA = "0x13FA410", Offset = "0x13F9010", VA = "0x1813FA410", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601AD4B RID: 109899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD4B")]
		[Address(RVA = "0x13FB990", Offset = "0x13FA590", VA = "0x1813FB990")]
		private void _OnResumeFromPurchaseConfirmState(IStateBean stateBean)
		{
		}

		// Token: 0x0601AD4C RID: 109900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD4C")]
		[Address(RVA = "0x13FB5B0", Offset = "0x13FA1B0", VA = "0x1813FB5B0")]
		private void _OnJumpToPurchaseState(IStateBean stateBean)
		{
		}

		// Token: 0x0601AD4D RID: 109901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD4D")]
		[Address(RVA = "0x13FB420", Offset = "0x13FA020", VA = "0x1813FB420")]
		private void _OnJumpToDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x0601AD4E RID: 109902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD4E")]
		[Address(RVA = "0x13FB7F0", Offset = "0x13FA3F0", VA = "0x1813FB7F0")]
		private void _OnLeftArrowClick()
		{
		}

		// Token: 0x0601AD4F RID: 109903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD4F")]
		[Address(RVA = "0x13FBCA0", Offset = "0x13FA8A0", VA = "0x1813FBCA0")]
		private void _OnRightArrowClick()
		{
		}

		// Token: 0x0601AD50 RID: 109904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD50")]
		[Address(RVA = "0x13FAD30", Offset = "0x13F9930", VA = "0x1813FAD30")]
		private void _OnGreatRewardDetailClick(RoguelikeTopicBPPrizeViewModel prizeModel)
		{
		}

		// Token: 0x0601AD51 RID: 109905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD51")]
		[Address(RVA = "0x13FB850", Offset = "0x13FA450", VA = "0x1813FB850")]
		private void _OnPurchaseGrandPrizeClick(RoguelikeTopicBPPrizeViewModel prizeModel)
		{
		}

		// Token: 0x0601AD52 RID: 109906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD52")]
		[Address(RVA = "0x13FBA50", Offset = "0x13FA650", VA = "0x1813FBA50")]
		private void _OnRewardClick(List<string> idList)
		{
		}

		// Token: 0x0601AD53 RID: 109907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD53")]
		[Address(RVA = "0x13FA1A0", Offset = "0x13F8DA0", VA = "0x1813FA1A0")]
		public void OnGuideBtnClick()
		{
		}

		// Token: 0x0601AD54 RID: 109908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD54")]
		[Address(RVA = "0x13F9EE0", Offset = "0x13F8AE0", VA = "0x1813F9EE0")]
		public void OnBpPurchaseClick(RoguelikeTopicBPTopViewModel viewModel)
		{
		}

		// Token: 0x0601AD55 RID: 109909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD55")]
		[Address(RVA = "0x13FBDC0", Offset = "0x13FA9C0", VA = "0x1813FBDC0")]
		public RoguelikeTopicBattlePassState()
		{
		}

		// Token: 0x0601AD58 RID: 109912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD58")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601AD59 RID: 109913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD59")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601AD5A RID: 109914 RVA: 0x000A3728 File Offset: 0x000A1928
		[Token(Token = "0x601AD5A")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0601AD5B RID: 109915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD5B")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601AD5C RID: 109916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD5C")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402258A RID: 140682
		[Token(Token = "0x402258A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeTopicBattlePassView _battlePassView;

		// Token: 0x0402258B RID: 140683
		[Token(Token = "0x402258B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeTopicBPGreatRewardView _grandPrizeView;

		// Token: 0x0402258C RID: 140684
		[Token(Token = "0x402258C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _greatRewardSwitchDelay;

		// Token: 0x0402258D RID: 140685
		[Token(Token = "0x402258D")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeTopicBattlePassStateBean m_stateBean;

		// Token: 0x0402258E RID: 140686
		[Token(Token = "0x402258E")]
		[FieldOffset(Offset = "0x90")]
		private string m_topicId;

		// Token: 0x0402258F RID: 140687
		[Token(Token = "0x402258F")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeTopicBattlePassStyle m_topicStyle;

		// Token: 0x04022590 RID: 140688
		[Token(Token = "0x4022590")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04022591 RID: 140689
		[Token(Token = "0x4022591")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_switchAnimActive;

		// Token: 0x04022592 RID: 140690
		[Token(Token = "0x4022592")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022593 RID: 140691
		[Token(Token = "0x4022593")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022594 RID: 140692
		[Token(Token = "0x4022594")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04022595 RID: 140693
		[Token(Token = "0x4022595")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022596 RID: 140694
		[Token(Token = "0x4022596")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FocusCurrentLv;

		// Token: 0x04022597 RID: 140695
		[Token(Token = "0x4022597")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateGreatRewardModelAfterDelay;

		// Token: 0x04022598 RID: 140696
		[Token(Token = "0x4022598")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnGreatRewardSwitch;

		// Token: 0x04022599 RID: 140697
		[Token(Token = "0x4022599")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0402259A RID: 140698
		[Token(Token = "0x402259A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0402259B RID: 140699
		[Token(Token = "0x402259B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402259C RID: 140700
		[Token(Token = "0x402259C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnResumeFromPurchaseConfirmState;

		// Token: 0x0402259D RID: 140701
		[Token(Token = "0x402259D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnJumpToPurchaseState;

		// Token: 0x0402259E RID: 140702
		[Token(Token = "0x402259E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnJumpToDetailState;

		// Token: 0x0402259F RID: 140703
		[Token(Token = "0x402259F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnLeftArrowClick;

		// Token: 0x040225A0 RID: 140704
		[Token(Token = "0x40225A0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnRightArrowClick;

		// Token: 0x040225A1 RID: 140705
		[Token(Token = "0x40225A1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnGreatRewardDetailClick;

		// Token: 0x040225A2 RID: 140706
		[Token(Token = "0x40225A2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnPurchaseGrandPrizeClick;

		// Token: 0x040225A3 RID: 140707
		[Token(Token = "0x40225A3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnRewardClick;

		// Token: 0x040225A4 RID: 140708
		[Token(Token = "0x40225A4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnGuideBtnClick;

		// Token: 0x040225A5 RID: 140709
		[Token(Token = "0x40225A5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnBpPurchaseClick;

		// Token: 0x040225A6 RID: 140710
		[Token(Token = "0x40225A6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
