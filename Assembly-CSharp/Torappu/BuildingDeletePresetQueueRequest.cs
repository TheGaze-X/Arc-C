using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006A3 RID: 1699
	[Token(Token = "0x20006A3")]
	public class BuildingDeletePresetQueueRequest : BuildingRequest
	{
		// Token: 0x060062DF RID: 25311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062DF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingDeletePresetQueueRequest()
		{
		}

		// Token: 0x04002E8B RID: 11915
		[Token(Token = "0x4002E8B")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x04002E8C RID: 11916
		[Token(Token = "0x4002E8C")]
		[FieldOffset(Offset = "0x18")]
		public int index;
	}
}
