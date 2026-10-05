using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001101 RID: 4353
	[Token(Token = "0x2001101")]
	[Serializable]
	public class MissionArchiveData
	{
		// Token: 0x06006EC2 RID: 28354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MissionArchiveData()
		{
		}

		// Token: 0x04005D49 RID: 23881
		[Token(Token = "0x4005D49")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04005D4A RID: 23882
		[Token(Token = "0x4005D4A")]
		[FieldOffset(Offset = "0x18")]
		public List<string> zones;

		// Token: 0x04005D4B RID: 23883
		[Token(Token = "0x4005D4B")]
		[FieldOffset(Offset = "0x20")]
		public List<MissionArchiveNodeData> nodes;

		// Token: 0x04005D4C RID: 23884
		[Token(Token = "0x4005D4C")]
		[FieldOffset(Offset = "0x28")]
		public List<MissionArchiveVoiceClipData> hiddenClips;

		// Token: 0x04005D4D RID: 23885
		[Token(Token = "0x4005D4D")]
		[FieldOffset(Offset = "0x30")]
		public string unlockDesc;
	}
}
