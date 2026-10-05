using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C50 RID: 27728
	[Token(Token = "0x2006C50")]
	public class TotemCompInfo : ActArchiveCompInfo
	{
		// Token: 0x0602793C RID: 162108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602793C")]
		[Address(RVA = "0x22D1B10", Offset = "0x22D0710", VA = "0x1822D1B10")]
		public TotemCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x0602793D RID: 162109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602793D")]
		[Address(RVA = "0x22D1A30", Offset = "0x22D0630", VA = "0x1822D1A30")]
		public void SetSelectedTotemId(string totemId)
		{
		}

		// Token: 0x0602793E RID: 162110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602793E")]
		[Address(RVA = "0x22D17D0", Offset = "0x22D03D0", VA = "0x1822D17D0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x0602793F RID: 162111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602793F")]
		[Address(RVA = "0x22D1540", Offset = "0x22D0140", VA = "0x1822D1540", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027940 RID: 162112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027940")]
		[Address(RVA = "0x22D1980", Offset = "0x22D0580", VA = "0x1822D1980", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x06027941 RID: 162113 RVA: 0x000CEC10 File Offset: 0x000CCE10
		[Token(Token = "0x6027941")]
		[Address(RVA = "0x22D1750", Offset = "0x22D0350", VA = "0x1822D1750", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027942 RID: 162114 RVA: 0x000CEC28 File Offset: 0x000CCE28
		[Token(Token = "0x6027942")]
		[Address(RVA = "0x22D1690", Offset = "0x22D0290", VA = "0x1822D1690", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027943 RID: 162115 RVA: 0x000CEC40 File Offset: 0x000CCE40
		[Token(Token = "0x6027943")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x0403820C RID: 229900
		[Token(Token = "0x403820C")]
		[FieldOffset(Offset = "0x18")]
		public TotemProperty totem;

		// Token: 0x0403820D RID: 229901
		[Token(Token = "0x403820D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403820E RID: 229902
		[Token(Token = "0x403820E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedTotemId;

		// Token: 0x0403820F RID: 229903
		[Token(Token = "0x403820F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038210 RID: 229904
		[Token(Token = "0x4038210")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04038211 RID: 229905
		[Token(Token = "0x4038211")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04038212 RID: 229906
		[Token(Token = "0x4038212")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04038213 RID: 229907
		[Token(Token = "0x4038213")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
