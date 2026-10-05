using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200631A RID: 25370
	[Token(Token = "0x200631A")]
	public class AutoChessShopCharChessBondModel : IComparable<AutoChessShopCharChessBondModel>, IHotfixable
	{
		// Token: 0x06024923 RID: 149795 RVA: 0x000C4BD8 File Offset: 0x000C2DD8
		[Token(Token = "0x6024923")]
		[Address(RVA = "0x1F67B20", Offset = "0x1F66720", VA = "0x181F67B20", Slot = "4")]
		public int CompareTo(AutoChessShopCharChessBondModel other)
		{
			return 0;
		}

		// Token: 0x06024924 RID: 149796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024924")]
		[Address(RVA = "0x1F67BC0", Offset = "0x1F667C0", VA = "0x181F67BC0")]
		public AutoChessShopCharChessBondModel()
		{
		}

		// Token: 0x04033063 RID: 208995
		[Token(Token = "0x4033063")]
		[FieldOffset(Offset = "0x10")]
		public string bondId;

		// Token: 0x04033064 RID: 208996
		[Token(Token = "0x4033064")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04033065 RID: 208997
		[Token(Token = "0x4033065")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04033066 RID: 208998
		[Token(Token = "0x4033066")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04033067 RID: 208999
		[Token(Token = "0x4033067")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x04033068 RID: 209000
		[Token(Token = "0x4033068")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04033069 RID: 209001
		[Token(Token = "0x4033069")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
