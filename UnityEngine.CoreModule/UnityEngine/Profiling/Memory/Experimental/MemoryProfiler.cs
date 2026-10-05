using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Profiling.Experimental;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	[NativeHeader("Modules/Profiler/Runtime/MemorySnapshotManager.h")]
	public sealed class MemoryProfiler
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x595FE10", Offset = "0x595EA10", VA = "0x18595FE10")]
		[RequiredByNativeCode]
		private static byte[] PrepareMetadata()
		{
			return null;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x5960250", Offset = "0x595EE50", VA = "0x185960250")]
		internal static int WriteIntToByteArray(byte[] array, int offset, int value)
		{
			return 0;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x59602C0", Offset = "0x595EEC0", VA = "0x1859602C0")]
		internal static int WriteStringToByteArray(byte[] array, int offset, string value)
		{
			return 0;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x595FD80", Offset = "0x595E980", VA = "0x18595FD80")]
		[RequiredByNativeCode]
		private static void FinalizeSnapshot(string path, bool result)
		{
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x5960120", Offset = "0x595ED20", VA = "0x185960120")]
		[RequiredByNativeCode]
		private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height)
		{
		}

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<string, bool> m_SnapshotFinished;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x8")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x10")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<MetaData> createMetaData;
	}
}
