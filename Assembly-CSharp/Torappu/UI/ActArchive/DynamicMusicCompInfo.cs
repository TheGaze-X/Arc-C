using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BBF RID: 27583
	[Token(Token = "0x2006BBF")]
	public class DynamicMusicCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027647 RID: 161351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027647")]
		[Address(RVA = "0x22A1100", Offset = "0x229FD00", VA = "0x1822A1100")]
		public DynamicMusicCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027648 RID: 161352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027648")]
		[Address(RVA = "0x22A0F50", Offset = "0x229FB50", VA = "0x1822A0F50")]
		public void SetSelectedMusicItem(string musicID, bool isInit)
		{
		}

		// Token: 0x06027649 RID: 161353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027649")]
		[Address(RVA = "0x22A0BD0", Offset = "0x229F7D0", VA = "0x1822A0BD0")]
		public void SetHomeTheme()
		{
		}

		// Token: 0x0602764A RID: 161354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602764A")]
		[Address(RVA = "0x22A06E0", Offset = "0x229F2E0", VA = "0x1822A06E0")]
		public MusicItemModel GetHomeMusicItem()
		{
			return null;
		}

		// Token: 0x0602764B RID: 161355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602764B")]
		[Address(RVA = "0x22A09B0", Offset = "0x229F5B0", VA = "0x1822A09B0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x0602764C RID: 161356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602764C")]
		[Address(RVA = "0x22A04C0", Offset = "0x229F0C0", VA = "0x1822A04C0", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x0602764D RID: 161357 RVA: 0x000CE490 File Offset: 0x000CC690
		[Token(Token = "0x602764D")]
		[Address(RVA = "0x22A0930", Offset = "0x229F530", VA = "0x1822A0930", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0602764E RID: 161358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602764E")]
		[Address(RVA = "0x22A0B20", Offset = "0x229F720", VA = "0x1822A0B20", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0602764F RID: 161359 RVA: 0x000CE4A8 File Offset: 0x000CC6A8
		[Token(Token = "0x602764F")]
		[Address(RVA = "0x22A07D0", Offset = "0x229F3D0", VA = "0x1822A07D0", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027650 RID: 161360 RVA: 0x000CE4C0 File Offset: 0x000CC6C0
		[Token(Token = "0x6027650")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x04037CEC RID: 228588
		[Token(Token = "0x4037CEC")]
		[FieldOffset(Offset = "0x18")]
		public MusicProperty music;

		// Token: 0x04037CED RID: 228589
		[Token(Token = "0x4037CED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037CEE RID: 228590
		[Token(Token = "0x4037CEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedMusicItem;

		// Token: 0x04037CEF RID: 228591
		[Token(Token = "0x4037CEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetHomeTheme;

		// Token: 0x04037CF0 RID: 228592
		[Token(Token = "0x4037CF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetHomeMusicItem;

		// Token: 0x04037CF1 RID: 228593
		[Token(Token = "0x4037CF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037CF2 RID: 228594
		[Token(Token = "0x4037CF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037CF3 RID: 228595
		[Token(Token = "0x4037CF3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037CF4 RID: 228596
		[Token(Token = "0x4037CF4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037CF5 RID: 228597
		[Token(Token = "0x4037CF5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
