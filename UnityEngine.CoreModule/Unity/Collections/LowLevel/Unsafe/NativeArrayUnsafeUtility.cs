using System;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public static class NativeArrayUnsafeUtility
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x600005D")]
		public unsafe static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) where T : struct
		{
			return default(NativeArray<T>);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600005E")]
		public unsafe static void* GetUnsafePtr<T>(this NativeArray<T> nativeArray) where T : struct
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600005F")]
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeArray<T> nativeArray) where T : struct
		{
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000060")]
		public unsafe static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) where T : struct
		{
			return null;
		}
	}
}
