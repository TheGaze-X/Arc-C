using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E45 RID: 3653
	[Token(Token = "0x2000E45")]
	public class ActMultiV3MapData
	{
		// Token: 0x06006B13 RID: 27411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B13")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3MapData()
		{
		}

		// Token: 0x04004C16 RID: 19478
		[Token(Token = "0x4004C16")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004C17 RID: 19479
		[Token(Token = "0x4004C17")]
		[FieldOffset(Offset = "0x18")]
		public string modeId;

		// Token: 0x04004C18 RID: 19480
		[Token(Token = "0x4004C18")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04004C19 RID: 19481
		[Token(Token = "0x4004C19")]
		[FieldOffset(Offset = "0x28")]
		public List<string> missionIdList;

		// Token: 0x04004C1A RID: 19482
		[Token(Token = "0x4004C1A")]
		[FieldOffset(Offset = "0x30")]
		public List<string> displayEnemyIdList;

		// Token: 0x04004C1B RID: 19483
		[Token(Token = "0x4004C1B")]
		[FieldOffset(Offset = "0x38")]
		public string previewIconId;
	}
}
