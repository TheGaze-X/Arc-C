using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020005FA RID: 1530
	[Token(Token = "0x20005FA")]
	public struct ServiceAlertStruct
	{
		// Token: 0x06006202 RID: 25090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006202")]
		[Address(RVA = "0x1DF4120", Offset = "0x1DF2D20", VA = "0x181DF4120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002C27 RID: 11303
		[Token(Token = "0x4002C27")]
		[FieldOffset(Offset = "0x0")]
		public string text;

		// Token: 0x04002C28 RID: 11304
		[Token(Token = "0x4002C28")]
		[FieldOffset(Offset = "0x8")]
		public string[] param;
	}
}
