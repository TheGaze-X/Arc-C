using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	internal class GlobalJavaObjectRef
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x590BC10", Offset = "0x590A810", VA = "0x18590BC10")]
		public GlobalJavaObjectRef(IntPtr jobject)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x590BBB0", Offset = "0x590A7B0", VA = "0x18590BBB0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3BEA040", Offset = "0x3BE8C40", VA = "0x183BEA040")]
		public static implicit operator IntPtr(GlobalJavaObjectRef obj)
		{
			return 0;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x590BAF0", Offset = "0x590A6F0", VA = "0x18590BAF0")]
		public void Dispose()
		{
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		private bool m_disposed;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		protected IntPtr m_jobject;
	}
}
