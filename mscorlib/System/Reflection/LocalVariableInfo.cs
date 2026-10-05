using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000530 RID: 1328
	[Token(Token = "0x2000530")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[StructLayout(0)]
	public class LocalVariableInfo
	{
		// Token: 0x0600266D RID: 9837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected LocalVariableInfo()
		{
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x4C1DC40", Offset = "0x4C1C840", VA = "0x184C1DC40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal System.Type type;

		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal bool is_pinned;

		// Token: 0x040015FE RID: 5630
		[Token(Token = "0x40015FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		internal ushort position;
	}
}
