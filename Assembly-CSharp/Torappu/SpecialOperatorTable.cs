using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001347 RID: 4935
	[Token(Token = "0x2001347")]
	public class SpecialOperatorTable
	{
		// Token: 0x06007304 RID: 29444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007304")]
		[Address(RVA = "0x2213720", Offset = "0x2212320", VA = "0x182213720")]
		public SpecialOperatorTable()
		{
		}

		// Token: 0x04006D5A RID: 27994
		[Token(Token = "0x4006D5A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, SpecialOperatorBasicData> operatorBasicData;

		// Token: 0x04006D5B RID: 27995
		[Token(Token = "0x4006D5B")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, SpecialOperatorDetailData> operatorDetailData;

		// Token: 0x04006D5C RID: 27996
		[Token(Token = "0x4006D5C")]
		[FieldOffset(Offset = "0x20")]
		public List<SpecialOperatorModeData> modeData;

		// Token: 0x04006D5D RID: 27997
		[Token(Token = "0x4006D5D")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, MissionData> nodeUnlockMissionData;

		// Token: 0x04006D5E RID: 27998
		[Token(Token = "0x4006D5E")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, MissionGroup> nodeUnlockMissionGroup;

		// Token: 0x04006D5F RID: 27999
		[Token(Token = "0x4006D5F")]
		[FieldOffset(Offset = "0x38")]
		public SpecialOperatorConstData constData;
	}
}
