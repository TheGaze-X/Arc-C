using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000ECB RID: 3787
	[Token(Token = "0x2000ECB")]
	public class Act7FunData
	{
		// Token: 0x06006B9B RID: 27547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B9B")]
		[Address(RVA = "0x1FF7A60", Offset = "0x1FF6660", VA = "0x181FF7A60")]
		public Act7FunData()
		{
		}

		// Token: 0x04004FFE RID: 20478
		[Token(Token = "0x4004FFE")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act7FunStageAdditionData> stageAdditionMap;

		// Token: 0x04004FFF RID: 20479
		[Token(Token = "0x4004FFF")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act7FunEasterEggData> easterEggData;

		// Token: 0x04005000 RID: 20480
		[Token(Token = "0x4005000")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act7FunSpineGroupData> spineGroupData;

		// Token: 0x04005001 RID: 20481
		[Token(Token = "0x4005001")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act7FunCharAnimData> charAnimData;

		// Token: 0x04005002 RID: 20482
		[Token(Token = "0x4005002")]
		[FieldOffset(Offset = "0x30")]
		public List<string> stageRewardList;

		// Token: 0x04005003 RID: 20483
		[Token(Token = "0x4005003")]
		[FieldOffset(Offset = "0x38")]
		public Act7FunConstData constData;
	}
}
