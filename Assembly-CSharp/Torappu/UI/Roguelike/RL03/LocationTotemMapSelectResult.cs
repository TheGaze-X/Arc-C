using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005864 RID: 22628
	[Token(Token = "0x2005864")]
	public class LocationTotemMapSelectResult : IHotfixable
	{
		// Token: 0x17004D89 RID: 19849
		// (get) Token: 0x060210CC RID: 135372 RVA: 0x000B8560 File Offset: 0x000B6760
		[Token(Token = "0x17004D89")]
		public bool haveSelectableNode
		{
			[Token(Token = "0x60210CC")]
			[Address(RVA = "0x1B5C4C0", Offset = "0x1B5B0C0", VA = "0x181B5C4C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060210CD RID: 135373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210CD")]
		[Address(RVA = "0x1B5C410", Offset = "0x1B5B010", VA = "0x181B5C410")]
		public LocationTotemMapSelectResult()
		{
		}

		// Token: 0x0402CF90 RID: 184208
		[Token(Token = "0x402CF90")]
		[FieldOffset(Offset = "0x10")]
		public HashSet<string> selectableNodeSet;

		// Token: 0x0402CF91 RID: 184209
		[Token(Token = "0x402CF91")]
		[FieldOffset(Offset = "0x18")]
		public TotemMapNodeSelectType selectType;

		// Token: 0x0402CF92 RID: 184210
		[Token(Token = "0x402CF92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_haveSelectableNode;

		// Token: 0x0402CF93 RID: 184211
		[Token(Token = "0x402CF93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
