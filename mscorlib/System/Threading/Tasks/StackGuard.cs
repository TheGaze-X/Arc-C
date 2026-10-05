using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	internal class StackGuard
	{
		// Token: 0x060014AF RID: 5295 RVA: 0x0000F660 File Offset: 0x0000D860
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x4AE1360", Offset = "0x4ADFF60", VA = "0x184AE1360")]
		internal bool TryBeginInliningScope()
		{
			return default(bool);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x2873F00", Offset = "0x2872B00", VA = "0x182873F00")]
		internal void EndInliningScope()
		{
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StackGuard()
		{
		}

		// Token: 0x04000B96 RID: 2966
		[Token(Token = "0x4000B96")]
		[FieldOffset(Offset = "0x10")]
		private int m_inliningDepth;

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4000B97")]
		private const int MAX_UNCHECKED_INLINING_DEPTH = 20;
	}
}
