using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C42 RID: 27714
	[Token(Token = "0x2006C42")]
	public class TimelineCompInfo : ActArchiveCompInfo
	{
		// Token: 0x060278EA RID: 162026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278EA")]
		[Address(RVA = "0x22CEE10", Offset = "0x22CDA10", VA = "0x1822CEE10")]
		public TimelineCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060278EB RID: 162027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278EB")]
		[Address(RVA = "0x22CEBA0", Offset = "0x22CD7A0", VA = "0x1822CEBA0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x060278EC RID: 162028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278EC")]
		[Address(RVA = "0x22CEAE0", Offset = "0x22CD6E0", VA = "0x1822CEAE0", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x060278ED RID: 162029 RVA: 0x000CEB68 File Offset: 0x000CCD68
		[Token(Token = "0x60278ED")]
		[Address(RVA = "0x22CEB40", Offset = "0x22CD740", VA = "0x1822CEB40", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060278EE RID: 162030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60278EE")]
		[Address(RVA = "0x22CED60", Offset = "0x22CD960", VA = "0x1822CED60", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0403816D RID: 229741
		[Token(Token = "0x403816D")]
		[FieldOffset(Offset = "0x18")]
		public TimelineProperty timeline;

		// Token: 0x0403816E RID: 229742
		[Token(Token = "0x403816E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403816F RID: 229743
		[Token(Token = "0x403816F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038170 RID: 229744
		[Token(Token = "0x4038170")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04038171 RID: 229745
		[Token(Token = "0x4038171")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04038172 RID: 229746
		[Token(Token = "0x4038172")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;
	}
}
