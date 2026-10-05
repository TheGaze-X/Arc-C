using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DataFromServer
{
	// Token: 0x020016F5 RID: 5877
	[Token(Token = "0x20016F5")]
	public struct ServerDataValidStatus : IHotfixable
	{
		// Token: 0x060094C2 RID: 38082 RVA: 0x00039FA8 File Offset: 0x000381A8
		[Token(Token = "0x60094C2")]
		[Address(RVA = "0x3113E30", Offset = "0x3112A30", VA = "0x183113E30")]
		public bool IsDataValid()
		{
			return default(bool);
		}

		// Token: 0x04008ACE RID: 35534
		[Token(Token = "0x4008ACE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ServerDataValidStatus NO_DATA;

		// Token: 0x04008ACF RID: 35535
		[Token(Token = "0x4008ACF")]
		[FieldOffset(Offset = "0x0")]
		public bool hasData;

		// Token: 0x04008AD0 RID: 35536
		[Token(Token = "0x4008AD0")]
		[FieldOffset(Offset = "0x1")]
		public bool needCrossDay;

		// Token: 0x04008AD1 RID: 35537
		[Token(Token = "0x4008AD1")]
		[FieldOffset(Offset = "0x2")]
		public bool validInCustomRules;

		// Token: 0x04008AD2 RID: 35538
		[Token(Token = "0x4008AD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsDataValid;
	}
}
