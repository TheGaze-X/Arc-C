using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BFA RID: 27642
	[Token(Token = "0x2006BFA")]
	public class ArchiveQuestGroupModel : IHotfixable
	{
		// Token: 0x17005D28 RID: 23848
		// (get) Token: 0x06027793 RID: 161683 RVA: 0x000CE760 File Offset: 0x000CC960
		[Token(Token = "0x17005D28")]
		public bool hasNewMark
		{
			[Token(Token = "0x6027793")]
			[Address(RVA = "0x22A9230", Offset = "0x22A7E30", VA = "0x1822A9230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005D29 RID: 23849
		// (get) Token: 0x06027794 RID: 161684 RVA: 0x000CE778 File Offset: 0x000CC978
		[Token(Token = "0x17005D29")]
		public bool isLocked
		{
			[Token(Token = "0x6027794")]
			[Address(RVA = "0x22A9310", Offset = "0x22A7F10", VA = "0x1822A9310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027795 RID: 161685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027795")]
		[Address(RVA = "0x22A91D0", Offset = "0x22A7DD0", VA = "0x1822A91D0")]
		public ArchiveQuestGroupModel()
		{
		}

		// Token: 0x04037F12 RID: 229138
		[Token(Token = "0x4037F12")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2ArchiveQuestType questType;

		// Token: 0x04037F13 RID: 229139
		[Token(Token = "0x4037F13")]
		[FieldOffset(Offset = "0x18")]
		public string groupName;

		// Token: 0x04037F14 RID: 229140
		[Token(Token = "0x4037F14")]
		[FieldOffset(Offset = "0x20")]
		public List<ArchiveQuestItemModel> itemList;

		// Token: 0x04037F15 RID: 229141
		[Token(Token = "0x4037F15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasNewMark;

		// Token: 0x04037F16 RID: 229142
		[Token(Token = "0x4037F16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x04037F17 RID: 229143
		[Token(Token = "0x4037F17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
