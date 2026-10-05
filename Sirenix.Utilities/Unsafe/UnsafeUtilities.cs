using System;
using Il2CppDummyDll;

namespace Sirenix.Utilities.Unsafe
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public static class UnsafeUtilities
	{
		// Token: 0x060003C2 RID: 962 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003C2")]
		public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength) where T : struct
		{
			return null;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003C3")]
		public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength, int byteOffset) where T : struct
		{
			return null;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003C4")]
		public static byte[] StructArrayToBytes<T>(T[] array) where T : struct
		{
			return null;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003C5")]
		public static byte[] StructArrayToBytes<T>(T[] array, ref byte[] bytes, int byteOffset) where T : struct
		{
			return null;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x4E39FA0", Offset = "0x4E38BA0", VA = "0x184E39FA0")]
		public static string StringFromBytes(byte[] buffer, int charLength, bool needs16BitSupport)
		{
			return null;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x4E3A460", Offset = "0x4E39060", VA = "0x184E3A460")]
		public static int StringToBytes(byte[] buffer, string value, bool needs16BitSupport)
		{
			return 0;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x4E39D40", Offset = "0x4E38940", VA = "0x184E39D40")]
		public static void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset)
		{
		}
	}
}
