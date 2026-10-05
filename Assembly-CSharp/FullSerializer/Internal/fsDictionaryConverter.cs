using System;
using System.Collections;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B86 RID: 31622
	[Token(Token = "0x2007B86")]
	public class fsDictionaryConverter : fsConverter
	{
		// Token: 0x0602C43A RID: 181306 RVA: 0x000DEF60 File Offset: 0x000DD160
		[Token(Token = "0x602C43A")]
		[Address(RVA = "0x2825D40", Offset = "0x2824940", VA = "0x182825D40", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		// Token: 0x0602C43B RID: 181307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C43B")]
		[Address(RVA = "0x2825DE0", Offset = "0x28249E0", VA = "0x182825DE0", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		// Token: 0x0602C43C RID: 181308 RVA: 0x000DEF78 File Offset: 0x000DD178
		[Token(Token = "0x602C43C")]
		[Address(RVA = "0x2825FD0", Offset = "0x2824BD0", VA = "0x182825FD0", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C43D RID: 181309 RVA: 0x000DEF90 File Offset: 0x000DD190
		[Token(Token = "0x602C43D")]
		[Address(RVA = "0x28273B0", Offset = "0x2825FB0", VA = "0x1828273B0", Slot = "7")]
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		// Token: 0x0602C43E RID: 181310 RVA: 0x000DEFA8 File Offset: 0x000DD1A8
		[Token(Token = "0x602C43E")]
		[Address(RVA = "0x2825890", Offset = "0x2824490", VA = "0x182825890")]
		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value)
		{
			return default(fsResult);
		}

		// Token: 0x0602C43F RID: 181311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C43F")]
		[Address(RVA = "0x2825E60", Offset = "0x2824A60", VA = "0x182825E60")]
		private static void GetKeyValueTypes(Type dictionaryType, out Type keyStorageType, out Type valueStorageType)
		{
		}

		// Token: 0x0602C440 RID: 181312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C440")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fsDictionaryConverter()
		{
		}
	}
}
