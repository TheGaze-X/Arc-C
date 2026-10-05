using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x0200485B RID: 18523
	[Token(Token = "0x200485B")]
	public class MissionArchiveNodeViewModel
	{
		// Token: 0x0601BFA6 RID: 114598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFA6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MissionArchiveNodeViewModel()
		{
		}

		// Token: 0x040247D9 RID: 149465
		[Token(Token = "0x40247D9")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x040247DA RID: 149466
		[Token(Token = "0x40247DA")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x040247DB RID: 149467
		[Token(Token = "0x40247DB")]
		[FieldOffset(Offset = "0x20")]
		public string unlockDesc;

		// Token: 0x040247DC RID: 149468
		[Token(Token = "0x40247DC")]
		[FieldOffset(Offset = "0x28")]
		public List<MissionArchiveVoiceClipViewModel> clips;

		// Token: 0x040247DD RID: 149469
		[Token(Token = "0x40247DD")]
		[FieldOffset(Offset = "0x30")]
		public MissionArchiveNodeState trueState;

		// Token: 0x040247DE RID: 149470
		[Token(Token = "0x40247DE")]
		[FieldOffset(Offset = "0x34")]
		public MissionArchiveNodeState showState;
	}
}
