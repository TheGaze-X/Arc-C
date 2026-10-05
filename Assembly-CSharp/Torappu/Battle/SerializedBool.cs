using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020D7 RID: 8407
	[Token(Token = "0x20020D7")]
	[Serializable]
	public class SerializedBool
	{
		// Token: 0x0600CDC3 RID: 52675 RVA: 0x0004A3B8 File Offset: 0x000485B8
		[Token(Token = "0x600CDC3")]
		[Address(RVA = "0x3504930", Offset = "0x3503530", VA = "0x183504930")]
		public static implicit operator bool?(SerializedBool sBool)
		{
			return null;
		}

		// Token: 0x0600CDC4 RID: 52676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDC4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SerializedBool()
		{
		}

		// Token: 0x0400DB2F RID: 56111
		[Token(Token = "0x400DB2F")]
		[FieldOffset(Offset = "0x10")]
		public bool isDefined;

		// Token: 0x0400DB30 RID: 56112
		[Token(Token = "0x400DB30")]
		[FieldOffset(Offset = "0x11")]
		public bool value;
	}
}
