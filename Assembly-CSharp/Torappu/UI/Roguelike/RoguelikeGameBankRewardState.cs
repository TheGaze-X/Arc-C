using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054CF RID: 21711
	[Token(Token = "0x20054CF")]
	public class RoguelikeGameBankRewardState : PopupFloatState
	{
		// Token: 0x0601FEFD RID: 130813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FEFD")]
		[Address(RVA = "0x1A0D140", Offset = "0x1A0BD40", VA = "0x181A0D140", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601FEFE RID: 130814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEFE")]
		[Address(RVA = "0x1A0D1A0", Offset = "0x1A0BDA0", VA = "0x181A0D1A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601FEFF RID: 130815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEFF")]
		[Address(RVA = "0x1A0D460", Offset = "0x1A0C060", VA = "0x181A0D460")]
		public RoguelikeGameBankRewardState()
		{
		}

		// Token: 0x0601FF00 RID: 130816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF00")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402B157 RID: 176471
		[Token(Token = "0x402B157")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeTopicBankRewardView _rewardViewPrefab;

		// Token: 0x0402B158 RID: 176472
		[Token(Token = "0x402B158")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _rewardViewParent;

		// Token: 0x0402B159 RID: 176473
		[Token(Token = "0x402B159")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeMenuAdapter m_menuAdapter;

		// Token: 0x0402B15A RID: 176474
		[Token(Token = "0x402B15A")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeTopicBankRewardView m_rewardView;

		// Token: 0x0402B15B RID: 176475
		[Token(Token = "0x402B15B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402B15C RID: 176476
		[Token(Token = "0x402B15C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402B15D RID: 176477
		[Token(Token = "0x402B15D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
