using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003F3 RID: 1011
	[Token(Token = "0x20003F3")]
	public class FormatterConverter : IFormatterConverter
	{
		// Token: 0x06001F88 RID: 8072 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F88")]
		[Address(RVA = "0x4B9A510", Offset = "0x4B99110", VA = "0x184B9A510", Slot = "4")]
		public object Convert(object value, System.Type type)
		{
			return null;
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x000130E0 File Offset: 0x000112E0
		[Token(Token = "0x6001F89")]
		[Address(RVA = "0x4B9A610", Offset = "0x4B99210", VA = "0x184B9A610", Slot = "5")]
		public bool ToBoolean(object value)
		{
			return default(bool);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x000130F8 File Offset: 0x000112F8
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0x4B9A6A0", Offset = "0x4B992A0", VA = "0x184B9A6A0", Slot = "6")]
		public int ToInt32(object value)
		{
			return 0;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00013110 File Offset: 0x00011310
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x4B9A730", Offset = "0x4B99330", VA = "0x184B9A730", Slot = "7")]
		public long ToInt64(object value)
		{
			return 0L;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00013128 File Offset: 0x00011328
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0x4B9A7C0", Offset = "0x4B993C0", VA = "0x184B9A7C0", Slot = "8")]
		public float ToSingle(object value)
		{
			return 0f;
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x4B9A850", Offset = "0x4B99450", VA = "0x184B9A850", Slot = "9")]
		public string ToString(object value)
		{
			return null;
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x4B9A5B0", Offset = "0x4B991B0", VA = "0x184B9A5B0")]
		[MethodImpl(8)]
		private static void ThrowValueNullException()
		{
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FormatterConverter()
		{
		}
	}
}
