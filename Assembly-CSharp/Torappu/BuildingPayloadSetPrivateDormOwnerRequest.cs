using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000697 RID: 1687
	[Token(Token = "0x2000697")]
	public class BuildingPayloadSetPrivateDormOwnerRequest : BuildingRequest
	{
		// Token: 0x060062D3 RID: 25299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingPayloadSetPrivateDormOwnerRequest()
		{
		}

		// Token: 0x04002E84 RID: 11908
		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x04002E85 RID: 11909
		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x18")]
		public int charInsId;
	}
}
