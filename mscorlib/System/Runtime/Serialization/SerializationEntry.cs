using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003EF RID: 1007
	[Token(Token = "0x20003EF")]
	public readonly struct SerializationEntry
	{
		// Token: 0x06001F79 RID: 8057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x17F8010", Offset = "0x17F6C10", VA = "0x1817F8010")]
		internal SerializationEntry(string entryName, object entryValue, System.Type entryType)
		{
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700041C")]
		public object Value
		{
			[Token(Token = "0x6001F7A")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700041D")]
		public string Name
		{
			[Token(Token = "0x6001F7B")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400109D RID: 4253
		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _name;

		// Token: 0x0400109E RID: 4254
		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x8")]
		private readonly object _value;

		// Token: 0x0400109F RID: 4255
		[Token(Token = "0x400109F")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.Type _type;
	}
}
