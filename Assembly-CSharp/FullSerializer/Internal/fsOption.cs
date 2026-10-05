using System;
using Il2CppDummyDll;

namespace FullSerializer.Internal
{
	// Token: 0x02007B95 RID: 31637
	[Token(Token = "0x2007B95")]
	public struct fsOption<T>
	{
		// Token: 0x170067AC RID: 26540
		// (get) Token: 0x0602C49F RID: 181407 RVA: 0x000DF530 File Offset: 0x000DD730
		[Token(Token = "0x170067AC")]
		public bool HasValue
		{
			[Token(Token = "0x602C49F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170067AD RID: 26541
		// (get) Token: 0x0602C4A0 RID: 181408 RVA: 0x000DF548 File Offset: 0x000DD748
		[Token(Token = "0x170067AD")]
		public bool IsEmpty
		{
			[Token(Token = "0x602C4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170067AE RID: 26542
		// (get) Token: 0x0602C4A1 RID: 181409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067AE")]
		public T Value
		{
			[Token(Token = "0x602C4A1")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C4A2 RID: 181410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C4A2")]
		public fsOption(T value)
		{
		}

		// Token: 0x040401DD RID: 262621
		[Token(Token = "0x40401DD")]
		[FieldOffset(Offset = "0x0")]
		private bool _hasValue;

		// Token: 0x040401DE RID: 262622
		[Token(Token = "0x40401DE")]
		[FieldOffset(Offset = "0x0")]
		private T _value;

		// Token: 0x040401DF RID: 262623
		[Token(Token = "0x40401DF")]
		[FieldOffset(Offset = "0x0")]
		public static fsOption<T> Empty;
	}
}
