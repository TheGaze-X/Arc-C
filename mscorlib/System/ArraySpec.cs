using System;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	internal class ArraySpec : ModifierSpec
	{
		// Token: 0x060010BB RID: 4283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0xA279F0", Offset = "0xA265F0", VA = "0x180A279F0")]
		internal ArraySpec(int dimensions, bool bound)
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x4D47EF0", Offset = "0x4D46AF0", VA = "0x184D47EF0", Slot = "4")]
		public System.Type Resolve(System.Type type)
		{
			return null;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x4D47E50", Offset = "0x4D46A50", VA = "0x184D47E50", Slot = "5")]
		public System.Text.StringBuilder Append(System.Text.StringBuilder sb)
		{
			return null;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x4D47FD0", Offset = "0x4D46BD0", VA = "0x184D47FD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x10")]
		private int dimensions;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x14")]
		private bool bound;
	}
}
