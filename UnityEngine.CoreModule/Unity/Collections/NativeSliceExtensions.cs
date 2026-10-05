using System;
using Il2CppDummyDll;

namespace Unity.Collections
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public static class NativeSliceExtensions
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x600003E")]
		public static NativeSlice<T> Slice<T>(this NativeArray<T> thisArray, int start, int length) where T : struct
		{
			return default(NativeSlice<T>);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x600003F")]
		public static NativeSlice<T> Slice<T>(this NativeSlice<T> thisSlice, int start, int length) where T : struct
		{
			return default(NativeSlice<T>);
		}
	}
}
