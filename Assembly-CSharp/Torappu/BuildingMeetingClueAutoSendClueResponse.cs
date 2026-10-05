using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000675 RID: 1653
	[Token(Token = "0x2000675")]
	public class BuildingMeetingClueAutoSendClueResponse : PlayerDeltaResponse
	{
		// Token: 0x060062A3 RID: 25251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A3")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingMeetingClueAutoSendClueResponse()
		{
		}

		// Token: 0x04002E2F RID: 11823
		[Token(Token = "0x4002E2F")]
		[FieldOffset(Offset = "0x28")]
		public int count;

		// Token: 0x04002E30 RID: 11824
		[Token(Token = "0x4002E30")]
		[FieldOffset(Offset = "0x2C")]
		public int soptAdd;
	}
}
