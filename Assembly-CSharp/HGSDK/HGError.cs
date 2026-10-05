using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	public struct HGError
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x1700004C")]
		public bool hasError
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x5159F0", Offset = "0x5145F0", VA = "0x1805159F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x5159D0", Offset = "0x5145D0", VA = "0x1805159D0")]
		public HGError(ResultCode code, string error)
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1028620", Offset = "0x1027220", VA = "0x181028620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HGError NULL;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x0")]
		public ResultCode code;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x8")]
		public string error;
	}
}
