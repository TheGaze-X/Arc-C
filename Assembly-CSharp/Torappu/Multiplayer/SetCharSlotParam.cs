using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer
{
	// Token: 0x0200154C RID: 5452
	[Token(Token = "0x200154C")]
	public class SetCharSlotParam
	{
		// Token: 0x06007CB0 RID: 31920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SetCharSlotParam()
		{
		}

		// Token: 0x04007D37 RID: 32055
		[Token(Token = "0x4007D37")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04007D38 RID: 32056
		[Token(Token = "0x4007D38")]
		[FieldOffset(Offset = "0x14")]
		public bool inSquad;
	}
}
