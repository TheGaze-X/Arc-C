using System;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	internal class PointerSpec : ModifierSpec
	{
		// Token: 0x060010BF RID: 4287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BF")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		internal PointerSpec(int pointer_level)
		{
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x4D58660", Offset = "0x4D57260", VA = "0x184D58660", Slot = "4")]
		public System.Type Resolve(System.Type type)
		{
			return null;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x4D58630", Offset = "0x4D57230", VA = "0x184D58630", Slot = "5")]
		public System.Text.StringBuilder Append(System.Text.StringBuilder sb)
		{
			return null;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010C2")]
		[Address(RVA = "0x4D586D0", Offset = "0x4D572D0", VA = "0x184D586D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x10")]
		private int pointer_level;
	}
}
