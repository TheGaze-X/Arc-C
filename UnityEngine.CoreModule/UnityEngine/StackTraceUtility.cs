using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public static class StackTraceUtility
	{
		// Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x596F320", Offset = "0x596DF20", VA = "0x18596F320")]
		[RequiredByNativeCode]
		internal static void SetProjectFolder(string folder)
		{
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x596EDB0", Offset = "0x596D9B0", VA = "0x18596EDB0")]
		[RequiredByNativeCode]
		public static string ExtractStackTrace()
		{
			return null;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x596EF00", Offset = "0x596DB00", VA = "0x18596EF00")]
		[RequiredByNativeCode]
		internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace)
		{
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x596E6F0", Offset = "0x596D2F0", VA = "0x18596E6F0")]
		internal static string ExtractFormattedStackTrace(StackTrace stackTrace)
		{
			return null;
		}

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x0")]
		private static string projectFolder;
	}
}
