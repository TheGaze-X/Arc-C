using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	public class MethodWrap
	{
		// Token: 0x06003730 RID: 14128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x3446810", Offset = "0x3445410", VA = "0x183446810")]
		public MethodWrap(string methodName, List<OverloadMethodWrap> overloads, bool forceCheck)
		{
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00016620 File Offset: 0x00014820
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x34465C0", Offset = "0x34451C0", VA = "0x1834465C0")]
		public int Call(IntPtr L)
		{
			return 0;
		}

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x10")]
		private string methodName;

		// Token: 0x04000D3E RID: 3390
		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x18")]
		private List<OverloadMethodWrap> overloads;

		// Token: 0x04000D3F RID: 3391
		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x20")]
		private bool forceCheck;
	}
}
