using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B83 RID: 27523
	[Token(Token = "0x2006B83")]
	public class EndbookCompInfo : ActArchiveCompInfo
	{
		// Token: 0x0602751A RID: 161050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602751A")]
		[Address(RVA = "0x2288FF0", Offset = "0x2287BF0", VA = "0x182288FF0")]
		public EndbookCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602751B RID: 161051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602751B")]
		[Address(RVA = "0x2288650", Offset = "0x2287250", VA = "0x182288650", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x0602751C RID: 161052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602751C")]
		[Address(RVA = "0x2288DC0", Offset = "0x22879C0", VA = "0x182288DC0")]
		public void SetSelectedEnd(string endId, bool isInit, bool openDetail)
		{
		}

		// Token: 0x0602751D RID: 161053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602751D")]
		[Address(RVA = "0x2288B90", Offset = "0x2287790", VA = "0x182288B90")]
		public void SetSelectedEnd(string endId)
		{
		}

		// Token: 0x0602751E RID: 161054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602751E")]
		[Address(RVA = "0x2288A10", Offset = "0x2287610", VA = "0x182288A10")]
		public void SetSelectedEndItem(int index)
		{
		}

		// Token: 0x0602751F RID: 161055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602751F")]
		[Address(RVA = "0x2288930", Offset = "0x2287530", VA = "0x182288930")]
		public void SetFocusedIndex(int index)
		{
		}

		// Token: 0x06027520 RID: 161056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027520")]
		[Address(RVA = "0x2288230", Offset = "0x2286E30", VA = "0x182288230", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027521 RID: 161057 RVA: 0x000CE028 File Offset: 0x000CC228
		[Token(Token = "0x6027521")]
		[Address(RVA = "0x22885D0", Offset = "0x22871D0", VA = "0x1822885D0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027522 RID: 161058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027522")]
		[Address(RVA = "0x22887A0", Offset = "0x22873A0", VA = "0x1822887A0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x06027523 RID: 161059 RVA: 0x000CE040 File Offset: 0x000CC240
		[Token(Token = "0x6027523")]
		[Address(RVA = "0x2288310", Offset = "0x2286F10", VA = "0x182288310", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027524 RID: 161060 RVA: 0x000CE058 File Offset: 0x000CC258
		[Token(Token = "0x6027524")]
		[Address(RVA = "0x2288850", Offset = "0x2287450", VA = "0x182288850", Slot = "10")]
		public override bool OnBackBtnPressed()
		{
			return default(bool);
		}

		// Token: 0x06027525 RID: 161061 RVA: 0x000CE070 File Offset: 0x000CC270
		[Token(Token = "0x6027525")]
		[Address(RVA = "0x2288470", Offset = "0x2287070", VA = "0x182288470", Slot = "9")]
		public override bool IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x06027526 RID: 161062 RVA: 0x000CE088 File Offset: 0x000CC288
		[Token(Token = "0x6027526")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027527 RID: 161063 RVA: 0x000CE0A0 File Offset: 0x000CC2A0
		[Token(Token = "0x6027527")]
		[Address(RVA = "0x2288FE0", Offset = "0x2287BE0", VA = "0x182288FE0")]
		private bool <>xLuaBaseProxy_OnBackBtnPressed()
		{
			return default(bool);
		}

		// Token: 0x06027528 RID: 161064 RVA: 0x000CE0B8 File Offset: 0x000CC2B8
		[Token(Token = "0x6027528")]
		[Address(RVA = "0x2274CB0", Offset = "0x22738B0", VA = "0x182274CB0")]
		private bool <>xLuaBaseProxy_IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x04037B1A RID: 228122
		[Token(Token = "0x4037B1A")]
		public const string KEY_ARCHIVE_ENDBOOK_OPEN_DETAIL = "endbook_open_detail";

		// Token: 0x04037B1B RID: 228123
		[Token(Token = "0x4037B1B")]
		[FieldOffset(Offset = "0x18")]
		public EndbookProperty endbook;

		// Token: 0x04037B1C RID: 228124
		[Token(Token = "0x4037B1C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037B1D RID: 228125
		[Token(Token = "0x4037B1D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037B1E RID: 228126
		[Token(Token = "0x4037B1E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedEnd;

		// Token: 0x04037B1F RID: 228127
		[Token(Token = "0x4037B1F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_SetSelectedEnd;

		// Token: 0x04037B20 RID: 228128
		[Token(Token = "0x4037B20")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetSelectedEndItem;

		// Token: 0x04037B21 RID: 228129
		[Token(Token = "0x4037B21")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetFocusedIndex;

		// Token: 0x04037B22 RID: 228130
		[Token(Token = "0x4037B22")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037B23 RID: 228131
		[Token(Token = "0x4037B23")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037B24 RID: 228132
		[Token(Token = "0x4037B24")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037B25 RID: 228133
		[Token(Token = "0x4037B25")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HasNewItem;

		// Token: 0x04037B26 RID: 228134
		[Token(Token = "0x4037B26")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBackBtnPressed;

		// Token: 0x04037B27 RID: 228135
		[Token(Token = "0x4037B27")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsUnlocked;
	}
}
