using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C12 RID: 27666
	[Token(Token = "0x2006C12")]
	public class RelicCompInfo : ActArchiveCompInfo
	{
		// Token: 0x060277FF RID: 161791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277FF")]
		[Address(RVA = "0x22BADD0", Offset = "0x22B99D0", VA = "0x1822BADD0")]
		public RelicCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027800 RID: 161792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027800")]
		[Address(RVA = "0x22BA9B0", Offset = "0x22B95B0", VA = "0x1822BA9B0")]
		public void SetSelectedRelicItem(string relicId)
		{
		}

		// Token: 0x06027801 RID: 161793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027801")]
		[Address(RVA = "0x22BA8E0", Offset = "0x22B94E0", VA = "0x1822BA8E0")]
		public void SetFilterMethod(FilterRule rule)
		{
		}

		// Token: 0x06027802 RID: 161794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027802")]
		[Address(RVA = "0x22BAC00", Offset = "0x22B9800", VA = "0x1822BAC00")]
		public void SwitchDifficulty(int toward)
		{
		}

		// Token: 0x06027803 RID: 161795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027803")]
		[Address(RVA = "0x22BA510", Offset = "0x22B9110", VA = "0x1822BA510", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027804 RID: 161796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027804")]
		[Address(RVA = "0x22BA330", Offset = "0x22B8F30", VA = "0x1822BA330", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027805 RID: 161797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027805")]
		[Address(RVA = "0x22BA830", Offset = "0x22B9430", VA = "0x1822BA830", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x06027806 RID: 161798 RVA: 0x000CE8F8 File Offset: 0x000CCAF8
		[Token(Token = "0x6027806")]
		[Address(RVA = "0x22BA490", Offset = "0x22B9090", VA = "0x1822BA490", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027807 RID: 161799 RVA: 0x000CE910 File Offset: 0x000CCB10
		[Token(Token = "0x6027807")]
		[Address(RVA = "0x22BA3D0", Offset = "0x22B8FD0", VA = "0x1822BA3D0", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x06027808 RID: 161800 RVA: 0x000CE928 File Offset: 0x000CCB28
		[Token(Token = "0x6027808")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x04038005 RID: 229381
		[Token(Token = "0x4038005")]
		[FieldOffset(Offset = "0x18")]
		public RelicProperty relic;

		// Token: 0x04038006 RID: 229382
		[Token(Token = "0x4038006")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04038007 RID: 229383
		[Token(Token = "0x4038007")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedRelicItem;

		// Token: 0x04038008 RID: 229384
		[Token(Token = "0x4038008")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetFilterMethod;

		// Token: 0x04038009 RID: 229385
		[Token(Token = "0x4038009")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SwitchDifficulty;

		// Token: 0x0403800A RID: 229386
		[Token(Token = "0x403800A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403800B RID: 229387
		[Token(Token = "0x403800B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x0403800C RID: 229388
		[Token(Token = "0x403800C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x0403800D RID: 229389
		[Token(Token = "0x403800D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0403800E RID: 229390
		[Token(Token = "0x403800E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
