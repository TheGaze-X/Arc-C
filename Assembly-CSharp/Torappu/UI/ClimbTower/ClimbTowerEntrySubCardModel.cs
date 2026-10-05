using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DB8 RID: 23992
	[Token(Token = "0x2005DB8")]
	public class ClimbTowerEntrySubCardModel : IHotfixable
	{
		// Token: 0x06022C73 RID: 142451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022C73")]
		[Address(RVA = "0x1D54F40", Offset = "0x1D53B40", VA = "0x181D54F40")]
		public static ClimbTowerEntrySubCardModel LoadData(string subCardId)
		{
			return null;
		}

		// Token: 0x06022C74 RID: 142452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C74")]
		[Address(RVA = "0x1D55200", Offset = "0x1D53E00", VA = "0x181D55200")]
		public ClimbTowerEntrySubCardModel()
		{
		}

		// Token: 0x0402FD33 RID: 195891
		[Token(Token = "0x402FD33")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0402FD34 RID: 195892
		[Token(Token = "0x402FD34")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0402FD35 RID: 195893
		[Token(Token = "0x402FD35")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x0402FD36 RID: 195894
		[Token(Token = "0x402FD36")]
		[FieldOffset(Offset = "0x28")]
		public bool isUsed;

		// Token: 0x0402FD37 RID: 195895
		[Token(Token = "0x402FD37")]
		[FieldOffset(Offset = "0x2C")]
		public int sortId;

		// Token: 0x0402FD38 RID: 195896
		[Token(Token = "0x402FD38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FD39 RID: 195897
		[Token(Token = "0x402FD39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
