using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[Preserve]
	internal class EnumValue<T> where T : struct
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B4")]
		public string Name
		{
			[Token(Token = "0x60003B3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B5")]
		public T Value
		{
			[Token(Token = "0x60003B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B5")]
		public EnumValue(string name, T value)
		{
		}

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _name;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x0")]
		private readonly T _value;
	}
}
