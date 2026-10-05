using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Racing
{
	// Token: 0x02002977 RID: 10615
	[Token(Token = "0x2002977")]
	public class RacingInput : IHotfixable
	{
		// Token: 0x06011907 RID: 71943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011907")]
		[Address(RVA = "0x95DBB0", Offset = "0x95C7B0", VA = "0x18095DBB0")]
		public RacingInput()
		{
		}

		// Token: 0x04013A10 RID: 80400
		[Token(Token = "0x4013A10")]
		[FieldOffset(Offset = "0x10")]
		public string sandboxTopicId;

		// Token: 0x04013A11 RID: 80401
		[Token(Token = "0x4013A11")]
		[FieldOffset(Offset = "0x18")]
		public string nodeId;

		// Token: 0x04013A12 RID: 80402
		[Token(Token = "0x4013A12")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x04013A13 RID: 80403
		[Token(Token = "0x4013A13")]
		[FieldOffset(Offset = "0x28")]
		public List<RacingEnemyData> enemyDataList;

		// Token: 0x04013A14 RID: 80404
		[Token(Token = "0x4013A14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
