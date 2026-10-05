using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[StructLayout(0)]
	public class ExceptionHandlingClause
	{
		// Token: 0x0600266B RID: 9835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ExceptionHandlingClause()
		{
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x4C1CD10", Offset = "0x4C1B910", VA = "0x184C1CD10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040015F5 RID: 5621
		[Token(Token = "0x40015F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal System.Type catch_type;

		// Token: 0x040015F6 RID: 5622
		[Token(Token = "0x40015F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int filter_offset;

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal ExceptionHandlingClauseOptions flags;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int try_offset;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int try_length;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int handler_offset;

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int handler_length;
	}
}
