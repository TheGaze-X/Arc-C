using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005850 RID: 22608
	[Token(Token = "0x2005850")]
	public class RL03ShopDetailExtraInfoPlugin : RoguelikeShopDetailExtraInfoPlugin
	{
		// Token: 0x06021065 RID: 135269 RVA: 0x000B8398 File Offset: 0x000B6598
		[Token(Token = "0x6021065")]
		[Address(RVA = "0x1B5DB20", Offset = "0x1B5C720", VA = "0x181B5DB20", Slot = "4")]
		public override RoguelikeShopDetailExtraInfo GetExtraInfo(RoguelikeGoodsViewModel viewModel)
		{
			return default(RoguelikeShopDetailExtraInfo);
		}

		// Token: 0x06021066 RID: 135270 RVA: 0x000B83B0 File Offset: 0x000B65B0
		[Token(Token = "0x6021066")]
		[Address(RVA = "0x1B5DEC0", Offset = "0x1B5CAC0", VA = "0x181B5DEC0")]
		private bool _CheckIfPlayerVisionIsMax(RoguelikeGameItemType itemType)
		{
			return default(bool);
		}

		// Token: 0x06021067 RID: 135271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021067")]
		[Address(RVA = "0x1B5DFA0", Offset = "0x1B5CBA0", VA = "0x181B5DFA0")]
		public RL03ShopDetailExtraInfoPlugin()
		{
		}

		// Token: 0x0402CEB5 RID: 183989
		[Token(Token = "0x402CEB5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Color Style")]
		private Color _colorTotemTips;

		// Token: 0x0402CEB6 RID: 183990
		[Token(Token = "0x402CEB6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Color Style")]
		private Color _colorVisionTips;

		// Token: 0x0402CEB7 RID: 183991
		[Token(Token = "0x402CEB7")]
		[FieldOffset(Offset = "0x38")]
		private List<RL03TotemViewModel> m_cachedTotemModels;

		// Token: 0x0402CEB8 RID: 183992
		[Token(Token = "0x402CEB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExtraInfo;

		// Token: 0x0402CEB9 RID: 183993
		[Token(Token = "0x402CEB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckIfPlayerVisionIsMax;

		// Token: 0x0402CEBA RID: 183994
		[Token(Token = "0x402CEBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
