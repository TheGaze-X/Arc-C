using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC2 RID: 27330
	[Token(Token = "0x2006AC2")]
	public class ChatProxy : ActArchiveCompProxy<ArchiveChatController>
	{
		// Token: 0x17005C65 RID: 23653
		// (get) Token: 0x06027185 RID: 160133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C65")]
		protected override string compType
		{
			[Token(Token = "0x6027185")]
			[Address(RVA = "0x2238420", Offset = "0x2237020", VA = "0x182238420", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027186 RID: 160134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027186")]
		[Address(RVA = "0x2237DF0", Offset = "0x22369F0", VA = "0x182237DF0", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x06027187 RID: 160135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027187")]
		[Address(RVA = "0x2237EC0", Offset = "0x2236AC0", VA = "0x182237EC0", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x06027188 RID: 160136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027188")]
		[Address(RVA = "0x2238240", Offset = "0x2236E40", VA = "0x182238240")]
		private void _OnChatItemClicked(ActArchiveType type, string chatId, ArchiveChatListDataBinder.ChatSwitchDirection directionMoveTo)
		{
		}

		// Token: 0x06027189 RID: 160137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027189")]
		[Address(RVA = "0x22383B0", Offset = "0x2236FB0", VA = "0x1822383B0")]
		public ChatProxy()
		{
		}

		// Token: 0x040374F3 RID: 226547
		[Token(Token = "0x40374F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x040374F4 RID: 226548
		[Token(Token = "0x40374F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x040374F5 RID: 226549
		[Token(Token = "0x40374F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x040374F6 RID: 226550
		[Token(Token = "0x40374F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnChatItemClicked;

		// Token: 0x040374F7 RID: 226551
		[Token(Token = "0x40374F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
