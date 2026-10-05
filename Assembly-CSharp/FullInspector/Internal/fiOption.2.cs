using System;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007C9E RID: 31902
	[Token(Token = "0x2007C9E")]
	public struct fiOption<T>
	{
		// Token: 0x0602C8D8 RID: 182488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C8D8")]
		public fiOption(T value)
		{
		}

		// Token: 0x1700684D RID: 26701
		// (get) Token: 0x0602C8D9 RID: 182489 RVA: 0x000E0B80 File Offset: 0x000DED80
		[Token(Token = "0x1700684D")]
		public bool HasValue
		{
			[Token(Token = "0x602C8D9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700684E RID: 26702
		// (get) Token: 0x0602C8DA RID: 182490 RVA: 0x000E0B98 File Offset: 0x000DED98
		[Token(Token = "0x1700684E")]
		public bool IsEmpty
		{
			[Token(Token = "0x602C8DA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700684F RID: 26703
		// (get) Token: 0x0602C8DB RID: 182491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700684F")]
		public T Value
		{
			[Token(Token = "0x602C8DB")]
			get
			{
				return null;
			}
		}

		// Token: 0x04040399 RID: 263065
		[Token(Token = "0x4040399")]
		[FieldOffset(Offset = "0x0")]
		private bool _hasValue;

		// Token: 0x0404039A RID: 263066
		[Token(Token = "0x404039A")]
		[FieldOffset(Offset = "0x0")]
		private T _value;

		// Token: 0x0404039B RID: 263067
		[Token(Token = "0x404039B")]
		[FieldOffset(Offset = "0x0")]
		public static fiOption<T> Empty;
	}
}
