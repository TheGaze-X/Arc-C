using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	internal static class AsyncTaskCache
	{
		// Token: 0x0600232F RID: 9007 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600232F")]
		[Address(RVA = "0x4BD0720", Offset = "0x4BCF320", VA = "0x184BD0720")]
		private static System.Threading.Tasks.Task<int>[] CreateInt32Tasks()
		{
			return null;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002330")]
		internal static System.Threading.Tasks.Task<TResult> CreateCacheableTask<TResult>(TResult result)
		{
			return null;
		}

		// Token: 0x040013FC RID: 5116
		[Token(Token = "0x40013FC")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly System.Threading.Tasks.Task<bool> TrueTask;

		// Token: 0x040013FD RID: 5117
		[Token(Token = "0x40013FD")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly System.Threading.Tasks.Task<bool> FalseTask;

		// Token: 0x040013FE RID: 5118
		[Token(Token = "0x40013FE")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly System.Threading.Tasks.Task<int>[] Int32Tasks;
	}
}
