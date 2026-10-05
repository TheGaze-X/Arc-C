using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005877 RID: 22647
	[Token(Token = "0x2005877")]
	public class RL03TotemListTitleViewModel : IRL03TotemListViewModel, IHotfixable
	{
		// Token: 0x06021123 RID: 135459 RVA: 0x000B8728 File Offset: 0x000B6928
		[Token(Token = "0x6021123")]
		[Address(RVA = "0x1B6B900", Offset = "0x1B6A500", VA = "0x181B6B900", Slot = "4")]
		public RL03TotemListViewType GetViewType()
		{
			return RL03TotemListViewType.NORMAL_ITEM;
		}

		// Token: 0x06021124 RID: 135460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021124")]
		[Address(RVA = "0x1B6B960", Offset = "0x1B6A560", VA = "0x181B6B960")]
		public RL03TotemListTitleViewModel()
		{
		}

		// Token: 0x0402D041 RID: 184385
		[Token(Token = "0x402D041")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTotemPosType posType;

		// Token: 0x0402D042 RID: 184386
		[Token(Token = "0x402D042")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402D043 RID: 184387
		[Token(Token = "0x402D043")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
