using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005B7 RID: 1463
	[Token(Token = "0x20005B7")]
	[System.Serializable]
	public struct DictionaryEntry
	{
		// Token: 0x06002B87 RID: 11143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B87")]
		[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
		public DictionaryEntry(object key, object value)
		{
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006B2")]
		public object Key
		{
			[Token(Token = "0x6002B88")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006B3")]
		public object Value
		{
			[Token(Token = "0x6002B89")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001975 RID: 6517
		[Token(Token = "0x4001975")]
		[FieldOffset(Offset = "0x0")]
		private object _key;

		// Token: 0x04001976 RID: 6518
		[Token(Token = "0x4001976")]
		[FieldOffset(Offset = "0x8")]
		private object _value;
	}
}
