using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B45 RID: 27461
	[Token(Token = "0x2006B45")]
	public class ArchiveChatModel : IHotfixable
	{
		// Token: 0x06027404 RID: 160772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027404")]
		[Address(RVA = "0x226CE40", Offset = "0x226BA40", VA = "0x18226CE40")]
		public string GetDefaultItemId(string archiveId)
		{
			return null;
		}

		// Token: 0x06027405 RID: 160773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027405")]
		[Address(RVA = "0x226CFF0", Offset = "0x226BBF0", VA = "0x18226CFF0")]
		public void LoadData(string archiveId, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027406 RID: 160774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027406")]
		[Address(RVA = "0x226DB00", Offset = "0x226C700", VA = "0x18226DB00")]
		public ArchiveChatModel()
		{
		}

		// Token: 0x040378CF RID: 227535
		[Token(Token = "0x40378CF")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, ChatItemModel> chatItems;

		// Token: 0x040378D0 RID: 227536
		[Token(Token = "0x40378D0")]
		[FieldOffset(Offset = "0x18")]
		public string selectedChatId;

		// Token: 0x040378D1 RID: 227537
		[Token(Token = "0x40378D1")]
		[FieldOffset(Offset = "0x20")]
		public int selectedChatIndex;

		// Token: 0x040378D2 RID: 227538
		[Token(Token = "0x40378D2")]
		[FieldOffset(Offset = "0x24")]
		public bool isInit;

		// Token: 0x040378D3 RID: 227539
		[Token(Token = "0x40378D3")]
		[FieldOffset(Offset = "0x28")]
		public ArchiveChatListDataBinder.ChatSwitchDirection directionMoveTo;

		// Token: 0x040378D4 RID: 227540
		[Token(Token = "0x40378D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDefaultItemId;

		// Token: 0x040378D5 RID: 227541
		[Token(Token = "0x40378D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040378D6 RID: 227542
		[Token(Token = "0x40378D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
