using System;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public static class NativeSliceUnsafeUtility
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000061")]
		public unsafe static NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length) where T : struct
		{
			return default(NativeSlice<T>);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000062")]
		public unsafe static void* GetUnsafePtr<T>(this NativeSlice<T> nativeSlice) where T : struct
		{
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000063")]
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(this NativeSlice<T> nativeSlice) where T : struct
		{
			return null;
		}
	}
}
