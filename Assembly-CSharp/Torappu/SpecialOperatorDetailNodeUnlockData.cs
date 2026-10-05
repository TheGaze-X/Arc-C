using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001338 RID: 4920
	[Token(Token = "0x2001338")]
	public class SpecialOperatorDetailNodeUnlockData
	{
		// Token: 0x060072F5 RID: 29429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialOperatorDetailNodeUnlockData()
		{
		}

		// Token: 0x04006D25 RID: 27941
		[Token(Token = "0x4006D25")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04006D26 RID: 27942
		[Token(Token = "0x4006D26")]
		[FieldOffset(Offset = "0x18")]
		public SpecialOperatorDetailNodeType nodeType;

		// Token: 0x04006D27 RID: 27943
		[Token(Token = "0x4006D27")]
		[FieldOffset(Offset = "0x1C")]
		public bool isInGameMechanics;

		// Token: 0x04006D28 RID: 27944
		[Token(Token = "0x4006D28")]
		[FieldOffset(Offset = "0x20")]
		public EvolvePhase unlockEvolvePhase;

		// Token: 0x04006D29 RID: 27945
		[Token(Token = "0x4006D29")]
		[FieldOffset(Offset = "0x24")]
		public int unlockLevel;

		// Token: 0x04006D2A RID: 27946
		[Token(Token = "0x4006D2A")]
		[FieldOffset(Offset = "0x28")]
		public string unlockTaskId;

		// Token: 0x04006D2B RID: 27947
		[Token(Token = "0x4006D2B")]
		[FieldOffset(Offset = "0x30")]
		public string frontNodeId;

		// Token: 0x04006D2C RID: 27948
		[Token(Token = "0x4006D2C")]
		[FieldOffset(Offset = "0x38")]
		public bool ifAutoUnlock;

		// Token: 0x04006D2D RID: 27949
		[Token(Token = "0x4006D2D")]
		[FieldOffset(Offset = "0x3C")]
		public SpecialOperatorConditionViewType conditionViewType;

		// Token: 0x04006D2E RID: 27950
		[Token(Token = "0x4006D2E")]
		[FieldOffset(Offset = "0x40")]
		public int topoOrder;
	}
}
