using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	internal static class ManagedStreamHelpers
	{
		// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x595FBD0", Offset = "0x595E7D0", VA = "0x18595FBD0")]
		internal static void ValidateLoadFromStream(Stream stream)
		{
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x595F950", Offset = "0x595E550", VA = "0x18595F950")]
		[RequiredByNativeCode]
		internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress)
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x595FAA0", Offset = "0x595E6A0", VA = "0x18595FAA0")]
		[RequiredByNativeCode]
		internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress)
		{
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x595F840", Offset = "0x595E440", VA = "0x18595F840")]
		[RequiredByNativeCode]
		internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress)
		{
		}
	}
}
