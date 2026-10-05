using System;
using Il2CppDummyDll;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070DB RID: 28891
	[Token(Token = "0x20070DB")]
	public class ActAutoChessInitMeta
	{
		// Token: 0x0602910D RID: 168205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602910D")]
		[Address(RVA = "0x2470080", Offset = "0x246EC80", VA = "0x182470080")]
		public static ActAutoChessInitMeta Deserialize(string str)
		{
			return null;
		}

		// Token: 0x0602910E RID: 168206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602910E")]
		[Address(RVA = "0x24701D0", Offset = "0x246EDD0", VA = "0x1824701D0")]
		public ActAutoChessInitMeta()
		{
		}

		// Token: 0x0403A9CC RID: 240076
		[Token(Token = "0x403A9CC")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x0403A9CD RID: 240077
		[Token(Token = "0x403A9CD")]
		[FieldOffset(Offset = "0x18")]
		public bool isBackFromPause;
	}
}
