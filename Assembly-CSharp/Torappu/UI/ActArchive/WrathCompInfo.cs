using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C68 RID: 27752
	[Token(Token = "0x2006C68")]
	public class WrathCompInfo : ActArchiveCompInfo, IHotfixable
	{
		// Token: 0x060279B7 RID: 162231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279B7")]
		[Address(RVA = "0x22D3A50", Offset = "0x22D2650", VA = "0x1822D3A50")]
		public WrathCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060279B8 RID: 162232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279B8")]
		[Address(RVA = "0x22D38D0", Offset = "0x22D24D0", VA = "0x1822D38D0")]
		public void SetSelectedWrathId(string wrathTypeId)
		{
		}

		// Token: 0x060279B9 RID: 162233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279B9")]
		[Address(RVA = "0x22D3350", Offset = "0x22D1F50", VA = "0x1822D3350", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x060279BA RID: 162234 RVA: 0x000CED90 File Offset: 0x000CCF90
		[Token(Token = "0x60279BA")]
		[Address(RVA = "0x22D3600", Offset = "0x22D2200", VA = "0x1822D3600", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060279BB RID: 162235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279BB")]
		[Address(RVA = "0x22D3680", Offset = "0x22D2280", VA = "0x1822D3680", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x060279BC RID: 162236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279BC")]
		[Address(RVA = "0x22D3820", Offset = "0x22D2420", VA = "0x1822D3820", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x060279BD RID: 162237 RVA: 0x000CEDA8 File Offset: 0x000CCFA8
		[Token(Token = "0x60279BD")]
		[Address(RVA = "0x22D3550", Offset = "0x22D2150", VA = "0x1822D3550", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x060279BE RID: 162238 RVA: 0x000CEDC0 File Offset: 0x000CCFC0
		[Token(Token = "0x60279BE")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x040382E0 RID: 230112
		[Token(Token = "0x40382E0")]
		[FieldOffset(Offset = "0x18")]
		public WrathProperty wrath;

		// Token: 0x040382E1 RID: 230113
		[Token(Token = "0x40382E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040382E2 RID: 230114
		[Token(Token = "0x40382E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedWrathId;

		// Token: 0x040382E3 RID: 230115
		[Token(Token = "0x40382E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x040382E4 RID: 230116
		[Token(Token = "0x40382E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x040382E5 RID: 230117
		[Token(Token = "0x40382E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040382E6 RID: 230118
		[Token(Token = "0x40382E6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x040382E7 RID: 230119
		[Token(Token = "0x40382E7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
