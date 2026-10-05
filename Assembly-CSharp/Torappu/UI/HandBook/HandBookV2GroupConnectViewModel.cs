using System;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006729 RID: 26409
	[Token(Token = "0x2006729")]
	public class HandBookV2GroupConnectViewModel
	{
		// Token: 0x170059B8 RID: 22968
		// (get) Token: 0x06025E11 RID: 155153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059B8")]
		public string targetForceId
		{
			[Token(Token = "0x6025E11")]
			[Address(RVA = "0x20DE420", Offset = "0x20DD020", VA = "0x1820DE420")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025E12 RID: 155154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E12")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2GroupConnectViewModel()
		{
		}

		// Token: 0x04035480 RID: 218240
		[Token(Token = "0x4035480")]
		[FieldOffset(Offset = "0x10")]
		public HandBookV2GroupPosData.Connection connection;

		// Token: 0x04035481 RID: 218241
		[Token(Token = "0x4035481")]
		[FieldOffset(Offset = "0x18")]
		public HandBookV2GroupCharViewModel targetChar;

		// Token: 0x04035482 RID: 218242
		[Token(Token = "0x4035482")]
		[FieldOffset(Offset = "0x20")]
		public string forceId;
	}
}
