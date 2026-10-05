using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BBE RID: 27582
	[Token(Token = "0x2006BBE")]
	public class MusicCompInfo : ActArchiveCompInfo
	{
		// Token: 0x0602763D RID: 161341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602763D")]
		[Address(RVA = "0x22A2F30", Offset = "0x22A1B30", VA = "0x1822A2F30")]
		public MusicCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602763E RID: 161342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602763E")]
		[Address(RVA = "0x22A2510", Offset = "0x22A1110", VA = "0x1822A2510")]
		public MusicItemModel GetMusicItemInfo(string musicId)
		{
			return null;
		}

		// Token: 0x0602763F RID: 161343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602763F")]
		[Address(RVA = "0x22A2D80", Offset = "0x22A1980", VA = "0x1822A2D80")]
		public void SetSelectedMusicItem(string musicID, bool isInit)
		{
		}

		// Token: 0x06027640 RID: 161344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027640")]
		[Address(RVA = "0x22A2A00", Offset = "0x22A1600", VA = "0x1822A2A00")]
		public void SetHomeTheme()
		{
		}

		// Token: 0x06027641 RID: 161345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027641")]
		[Address(RVA = "0x22A27E0", Offset = "0x22A13E0", VA = "0x1822A27E0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027642 RID: 161346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027642")]
		[Address(RVA = "0x22A22F0", Offset = "0x22A0EF0", VA = "0x1822A22F0", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027643 RID: 161347 RVA: 0x000CE448 File Offset: 0x000CC648
		[Token(Token = "0x6027643")]
		[Address(RVA = "0x22A2760", Offset = "0x22A1360", VA = "0x1822A2760", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027644 RID: 161348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027644")]
		[Address(RVA = "0x22A2950", Offset = "0x22A1550", VA = "0x1822A2950", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x06027645 RID: 161349 RVA: 0x000CE460 File Offset: 0x000CC660
		[Token(Token = "0x6027645")]
		[Address(RVA = "0x22A2600", Offset = "0x22A1200", VA = "0x1822A2600", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027646 RID: 161350 RVA: 0x000CE478 File Offset: 0x000CC678
		[Token(Token = "0x6027646")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x04037CE2 RID: 228578
		[Token(Token = "0x4037CE2")]
		[FieldOffset(Offset = "0x18")]
		public MusicProperty music;

		// Token: 0x04037CE3 RID: 228579
		[Token(Token = "0x4037CE3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037CE4 RID: 228580
		[Token(Token = "0x4037CE4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMusicItemInfo;

		// Token: 0x04037CE5 RID: 228581
		[Token(Token = "0x4037CE5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedMusicItem;

		// Token: 0x04037CE6 RID: 228582
		[Token(Token = "0x4037CE6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetHomeTheme;

		// Token: 0x04037CE7 RID: 228583
		[Token(Token = "0x4037CE7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037CE8 RID: 228584
		[Token(Token = "0x4037CE8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037CE9 RID: 228585
		[Token(Token = "0x4037CE9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037CEA RID: 228586
		[Token(Token = "0x4037CEA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037CEB RID: 228587
		[Token(Token = "0x4037CEB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
