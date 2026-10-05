using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006A7 RID: 1703
	[Token(Token = "0x20006A7")]
	public class BuildingUsePresetQueueRequest : BuildingRequest
	{
		// Token: 0x060062E3 RID: 25315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingUsePresetQueueRequest()
		{
		}

		// Token: 0x04002E90 RID: 11920
		[Token(Token = "0x4002E90")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x04002E91 RID: 11921
		[Token(Token = "0x4002E91")]
		[FieldOffset(Offset = "0x18")]
		public int index;
	}
}
