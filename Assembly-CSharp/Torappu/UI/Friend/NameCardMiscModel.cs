using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D84 RID: 19844
	[Token(Token = "0x2004D84")]
	public class NameCardMiscModel : IHotfixable
	{
		// Token: 0x0601DB1B RID: 121627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB1B")]
		[Address(RVA = "0x17435C0", Offset = "0x17421C0", VA = "0x1817435C0")]
		public void CopyFrom(NameCardMiscModel other, NameCardV2ViewModel.MiscFlag flag)
		{
		}

		// Token: 0x0601DB1C RID: 121628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB1C")]
		[Address(RVA = "0x1743690", Offset = "0x1742290", VA = "0x181743690")]
		public NameCardMiscModel()
		{
		}

		// Token: 0x040273D0 RID: 160720
		[Token(Token = "0x40273D0")]
		[FieldOffset(Offset = "0x10")]
		public bool showDetail;

		// Token: 0x040273D1 RID: 160721
		[Token(Token = "0x40273D1")]
		[FieldOffset(Offset = "0x11")]
		public bool showBirth;

		// Token: 0x040273D2 RID: 160722
		[Token(Token = "0x40273D2")]
		[FieldOffset(Offset = "0x12")]
		public bool birthEnabled;

		// Token: 0x040273D3 RID: 160723
		[Token(Token = "0x40273D3")]
		[FieldOffset(Offset = "0x13")]
		public bool birthSet;

		// Token: 0x040273D4 RID: 160724
		[Token(Token = "0x40273D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CopyFrom;

		// Token: 0x040273D5 RID: 160725
		[Token(Token = "0x40273D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
