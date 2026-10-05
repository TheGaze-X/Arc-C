using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CBE RID: 19646
	[Token(Token = "0x2004CBE")]
	public class GroceryHomeShopModel : IComparable, IHotfixable
	{
		// Token: 0x0601D6FB RID: 120571 RVA: 0x000AB6D8 File Offset: 0x000A98D8
		[Token(Token = "0x601D6FB")]
		[Address(RVA = "0x16F6280", Offset = "0x16F4E80", VA = "0x1816F6280", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0601D6FC RID: 120572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6FC")]
		[Address(RVA = "0x16F6380", Offset = "0x16F4F80", VA = "0x1816F6380")]
		public GroceryHomeShopModel()
		{
		}

		// Token: 0x04026CA5 RID: 158885
		[Token(Token = "0x4026CA5")]
		[FieldOffset(Offset = "0x10")]
		public string shopId;

		// Token: 0x04026CA6 RID: 158886
		[Token(Token = "0x4026CA6")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04026CA7 RID: 158887
		[Token(Token = "0x4026CA7")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04026CA8 RID: 158888
		[Token(Token = "0x4026CA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04026CA9 RID: 158889
		[Token(Token = "0x4026CA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
