using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003F6 RID: 1014
	[Token(Token = "0x20003F6")]
	[System.Serializable]
	internal sealed class MemberHolder
	{
		// Token: 0x06001F93 RID: 8083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F93")]
		[Address(RVA = "0x44483A0", Offset = "0x4446FA0", VA = "0x1844483A0")]
		internal MemberHolder(System.Type type, StreamingContext ctx)
		{
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00013140 File Offset: 0x00011340
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00013158 File Offset: 0x00011358
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x4B9DB20", Offset = "0x4B9C720", VA = "0x184B9DB20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x040010A6 RID: 4262
		[Token(Token = "0x40010A6")]
		[FieldOffset(Offset = "0x10")]
		internal readonly System.Type _memberType;

		// Token: 0x040010A7 RID: 4263
		[Token(Token = "0x40010A7")]
		[FieldOffset(Offset = "0x18")]
		internal readonly StreamingContext _context;
	}
}
