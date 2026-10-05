using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CD9 RID: 3289
	[Token(Token = "0x2000CD9")]
	public class QuestStageData
	{
		// Token: 0x060069B7 RID: 27063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QuestStageData()
		{
		}

		// Token: 0x04004334 RID: 17204
		[Token(Token = "0x4004334")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004335 RID: 17205
		[Token(Token = "0x4004335")]
		[FieldOffset(Offset = "0x18")]
		public int stageRank;

		// Token: 0x04004336 RID: 17206
		[Token(Token = "0x4004336")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04004337 RID: 17207
		[Token(Token = "0x4004337")]
		[FieldOffset(Offset = "0x20")]
		public bool isUrgentStage;

		// Token: 0x04004338 RID: 17208
		[Token(Token = "0x4004338")]
		[FieldOffset(Offset = "0x21")]
		public bool isDragonStage;
	}
}
