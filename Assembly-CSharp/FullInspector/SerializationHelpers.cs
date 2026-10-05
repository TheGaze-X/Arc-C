using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BD2 RID: 31698
	[Token(Token = "0x2007BD2")]
	public static class SerializationHelpers
	{
		// Token: 0x0602C5D8 RID: 181720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5D8")]
		public static T DeserializeFromContent<T, TSerializer>(string content) where TSerializer : BaseSerializer
		{
			return null;
		}

		// Token: 0x0602C5D9 RID: 181721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5D9")]
		public static object DeserializeFromContent<TSerializer>(Type storageType, string content) where TSerializer : BaseSerializer
		{
			return null;
		}

		// Token: 0x0602C5DA RID: 181722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5DA")]
		public static string SerializeToContent<T, TSerializer>(T value) where TSerializer : BaseSerializer
		{
			return null;
		}

		// Token: 0x0602C5DB RID: 181723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5DB")]
		public static string SerializeToContent<TSerializer>(Type storageType, object value) where TSerializer : BaseSerializer
		{
			return null;
		}

		// Token: 0x0602C5DC RID: 181724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5DC")]
		public static T Clone<T, TSerializer>(T obj) where TSerializer : BaseSerializer
		{
			return null;
		}

		// Token: 0x0602C5DD RID: 181725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5DD")]
		public static object Clone<TSerializer>(Type storageType, object obj) where TSerializer : BaseSerializer
		{
			return null;
		}
	}
}
