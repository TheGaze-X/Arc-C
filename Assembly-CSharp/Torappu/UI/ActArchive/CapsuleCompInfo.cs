using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B27 RID: 27431
	[Token(Token = "0x2006B27")]
	public class CapsuleCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027362 RID: 160610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027362")]
		[Address(RVA = "0x2275750", Offset = "0x2274350", VA = "0x182275750")]
		public CapsuleCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027363 RID: 160611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027363")]
		[Address(RVA = "0x2275270", Offset = "0x2273E70", VA = "0x182275270", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027364 RID: 160612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027364")]
		[Address(RVA = "0x22754D0", Offset = "0x22740D0", VA = "0x1822754D0")]
		public void SetSelectedCapsuleItem(string capsuleId)
		{
		}

		// Token: 0x06027365 RID: 160613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027365")]
		[Address(RVA = "0x2274FF0", Offset = "0x2273BF0", VA = "0x182274FF0", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027366 RID: 160614 RVA: 0x000CDB00 File Offset: 0x000CBD00
		[Token(Token = "0x6027366")]
		[Address(RVA = "0x22751F0", Offset = "0x2273DF0", VA = "0x1822751F0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027367 RID: 160615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027367")]
		[Address(RVA = "0x2275420", Offset = "0x2274020", VA = "0x182275420", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x06027368 RID: 160616 RVA: 0x000CDB18 File Offset: 0x000CBD18
		[Token(Token = "0x6027368")]
		[Address(RVA = "0x2275090", Offset = "0x2273C90", VA = "0x182275090", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027369 RID: 160617 RVA: 0x000CDB30 File Offset: 0x000CBD30
		[Token(Token = "0x6027369")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x040377AD RID: 227245
		[Token(Token = "0x40377AD")]
		[FieldOffset(Offset = "0x18")]
		public CapsuleProperty capsule;

		// Token: 0x040377AE RID: 227246
		[Token(Token = "0x40377AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040377AF RID: 227247
		[Token(Token = "0x40377AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040377B0 RID: 227248
		[Token(Token = "0x40377B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedCapsuleItem;

		// Token: 0x040377B1 RID: 227249
		[Token(Token = "0x40377B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x040377B2 RID: 227250
		[Token(Token = "0x40377B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x040377B3 RID: 227251
		[Token(Token = "0x40377B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x040377B4 RID: 227252
		[Token(Token = "0x40377B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
