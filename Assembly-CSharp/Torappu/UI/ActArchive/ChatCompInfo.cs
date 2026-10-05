using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B48 RID: 27464
	[Token(Token = "0x2006B48")]
	public class ChatCompInfo : ActArchiveCompInfo
	{
		// Token: 0x0602740B RID: 160779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602740B")]
		[Address(RVA = "0x2277850", Offset = "0x2276450", VA = "0x182277850")]
		public ChatCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602740C RID: 160780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602740C")]
		[Address(RVA = "0x2277190", Offset = "0x2275D90", VA = "0x182277190", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x0602740D RID: 160781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602740D")]
		[Address(RVA = "0x22773E0", Offset = "0x2275FE0", VA = "0x1822773E0")]
		public void SetSelectedChatItem(string chatId, bool isInit, ArchiveChatListDataBinder.ChatSwitchDirection directionMoveTo)
		{
		}

		// Token: 0x0602740E RID: 160782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602740E")]
		[Address(RVA = "0x2276F00", Offset = "0x2275B00", VA = "0x182276F00", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x0602740F RID: 160783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602740F")]
		[Address(RVA = "0x2277330", Offset = "0x2275F30", VA = "0x182277330", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x06027410 RID: 160784 RVA: 0x000CDD10 File Offset: 0x000CBF10
		[Token(Token = "0x6027410")]
		[Address(RVA = "0x2277110", Offset = "0x2275D10", VA = "0x182277110", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027411 RID: 160785 RVA: 0x000CDD28 File Offset: 0x000CBF28
		[Token(Token = "0x6027411")]
		[Address(RVA = "0x2276FB0", Offset = "0x2275BB0", VA = "0x182276FB0", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027412 RID: 160786 RVA: 0x000CDD40 File Offset: 0x000CBF40
		[Token(Token = "0x6027412")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x040378D9 RID: 227545
		[Token(Token = "0x40378D9")]
		[FieldOffset(Offset = "0x18")]
		public ChatProperty chat;

		// Token: 0x040378DA RID: 227546
		[Token(Token = "0x40378DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040378DB RID: 227547
		[Token(Token = "0x40378DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040378DC RID: 227548
		[Token(Token = "0x40378DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedChatItem;

		// Token: 0x040378DD RID: 227549
		[Token(Token = "0x40378DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x040378DE RID: 227550
		[Token(Token = "0x40378DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x040378DF RID: 227551
		[Token(Token = "0x40378DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x040378E0 RID: 227552
		[Token(Token = "0x40378E0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
