using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001102 RID: 4354
	[Token(Token = "0x2001102")]
	[Serializable]
	public class MissionArchiveNodeData
	{
		// Token: 0x06006EC3 RID: 28355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MissionArchiveNodeData()
		{
		}

		// Token: 0x04005D4E RID: 23886
		[Token(Token = "0x4005D4E")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04005D4F RID: 23887
		[Token(Token = "0x4005D4F")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04005D50 RID: 23888
		[Token(Token = "0x4005D50")]
		[FieldOffset(Offset = "0x20")]
		public string unlockDesc;

		// Token: 0x04005D51 RID: 23889
		[Token(Token = "0x4005D51")]
		[FieldOffset(Offset = "0x28")]
		public List<MissionArchiveVoiceClipData> clips;
	}
}
