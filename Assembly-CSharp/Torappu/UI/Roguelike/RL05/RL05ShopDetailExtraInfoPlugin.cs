using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005617 RID: 22039
	[Token(Token = "0x2005617")]
	public class RL05ShopDetailExtraInfoPlugin : RoguelikeShopDetailExtraInfoPlugin
	{
		// Token: 0x06020552 RID: 132434 RVA: 0x000B5710 File Offset: 0x000B3910
		[Token(Token = "0x6020552")]
		[Address(RVA = "0x1A7F060", Offset = "0x1A7DC60", VA = "0x181A7F060", Slot = "4")]
		public override RoguelikeShopDetailExtraInfo GetExtraInfo(RoguelikeGoodsViewModel viewModel)
		{
			return default(RoguelikeShopDetailExtraInfo);
		}

		// Token: 0x06020553 RID: 132435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020553")]
		[Address(RVA = "0x1A7F1C0", Offset = "0x1A7DDC0", VA = "0x181A7F1C0")]
		public RL05ShopDetailExtraInfoPlugin()
		{
		}

		// Token: 0x0402BC36 RID: 179254
		[Token(Token = "0x402BC36")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _copperInfoTextColor;

		// Token: 0x0402BC37 RID: 179255
		[Token(Token = "0x402BC37")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _copperInfoBkgColor;

		// Token: 0x0402BC38 RID: 179256
		[Token(Token = "0x402BC38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExtraInfo;

		// Token: 0x0402BC39 RID: 179257
		[Token(Token = "0x402BC39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
