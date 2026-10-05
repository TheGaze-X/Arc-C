using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000692 RID: 1682
	[Token(Token = "0x2000692")]
	public class BuildingPayloadGetOthersMessageBoardContentRequest : BuildingRequest
	{
		// Token: 0x060062CB RID: 25291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingPayloadGetOthersMessageBoardContentRequest()
		{
		}

		// Token: 0x04002E74 RID: 11892
		[Token(Token = "0x4002E74")]
		[FieldOffset(Offset = "0x10")]
		public string uid;
	}
}
