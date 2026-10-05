using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Mono/Coroutine.h")]
	[StructLayout(0)]
	public sealed class Coroutine : YieldInstruction
	{
		// Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private Coroutine()
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x5959DB0", Offset = "0x59589B0", VA = "0x185959DB0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000951 RID: 2385
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x5959E30", Offset = "0x5958A30", VA = "0x185959E30")]
		[FreeFunction("Coroutine::CleanupCoroutineGC", true)]
		[MethodImpl(4096)]
		private static extern void ReleaseCoroutine(IntPtr ptr);

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
