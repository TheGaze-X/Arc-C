using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B01 RID: 27393
	[Token(Token = "0x2006B01")]
	public class ArchiveActivityEntryCompInfo : ActArchiveCompInfo
	{
		// Token: 0x060272AE RID: 160430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272AE")]
		[Address(RVA = "0x2252570", Offset = "0x2251170", VA = "0x182252570")]
		public ArchiveActivityEntryCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060272AF RID: 160431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272AF")]
		[Address(RVA = "0x2252340", Offset = "0x2250F40", VA = "0x182252340", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x060272B0 RID: 160432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272B0")]
		[Address(RVA = "0x2252280", Offset = "0x2250E80", VA = "0x182252280", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x060272B1 RID: 160433 RVA: 0x000CD920 File Offset: 0x000CBB20
		[Token(Token = "0x60272B1")]
		[Address(RVA = "0x22522E0", Offset = "0x2250EE0", VA = "0x1822522E0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060272B2 RID: 160434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272B2")]
		[Address(RVA = "0x22524C0", Offset = "0x22510C0", VA = "0x1822524C0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0403767B RID: 226939
		[Token(Token = "0x403767B")]
		[FieldOffset(Offset = "0x18")]
		public ArchiveActivityEntryProperty property;

		// Token: 0x0403767C RID: 226940
		[Token(Token = "0x403767C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403767D RID: 226941
		[Token(Token = "0x403767D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403767E RID: 226942
		[Token(Token = "0x403767E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x0403767F RID: 226943
		[Token(Token = "0x403767F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037680 RID: 226944
		[Token(Token = "0x4037680")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;
	}
}
