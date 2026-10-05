using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	public struct XDError
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x17000031")]
		public bool hasError
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x5159F0", Offset = "0x5145F0", VA = "0x1805159F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x5159D0", Offset = "0x5145D0", VA = "0x1805159D0")]
		public XDError(ResultCode code, string error)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x5158B0", Offset = "0x5144B0", VA = "0x1805158B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly XDError NULL;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x0")]
		public ResultCode code;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x8")]
		public string error;
	}
}
