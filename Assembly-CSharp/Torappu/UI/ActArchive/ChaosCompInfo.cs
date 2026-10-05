using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B3B RID: 27451
	[Token(Token = "0x2006B3B")]
	public class ChaosCompInfo : ActArchiveCompInfo
	{
		// Token: 0x060273D9 RID: 160729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273D9")]
		[Address(RVA = "0x2276D10", Offset = "0x2275910", VA = "0x182276D10")]
		public ChaosCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060273DA RID: 160730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273DA")]
		[Address(RVA = "0x2276C30", Offset = "0x2275830", VA = "0x182276C30")]
		public void SetSelectedChaosId(string chaosId)
		{
		}

		// Token: 0x060273DB RID: 160731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273DB")]
		[Address(RVA = "0x22769D0", Offset = "0x22755D0", VA = "0x1822769D0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x060273DC RID: 160732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273DC")]
		[Address(RVA = "0x2276740", Offset = "0x2275340", VA = "0x182276740", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x060273DD RID: 160733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273DD")]
		[Address(RVA = "0x2276B80", Offset = "0x2275780", VA = "0x182276B80", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x060273DE RID: 160734 RVA: 0x000CDC98 File Offset: 0x000CBE98
		[Token(Token = "0x60273DE")]
		[Address(RVA = "0x2276950", Offset = "0x2275550", VA = "0x182276950", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060273DF RID: 160735 RVA: 0x000CDCB0 File Offset: 0x000CBEB0
		[Token(Token = "0x60273DF")]
		[Address(RVA = "0x2276890", Offset = "0x2275490", VA = "0x182276890", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x060273E0 RID: 160736 RVA: 0x000CDCC8 File Offset: 0x000CBEC8
		[Token(Token = "0x60273E0")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x04037860 RID: 227424
		[Token(Token = "0x4037860")]
		[FieldOffset(Offset = "0x18")]
		public ChaosProperty chaos;

		// Token: 0x04037861 RID: 227425
		[Token(Token = "0x4037861")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037862 RID: 227426
		[Token(Token = "0x4037862")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedChaosId;

		// Token: 0x04037863 RID: 227427
		[Token(Token = "0x4037863")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037864 RID: 227428
		[Token(Token = "0x4037864")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037865 RID: 227429
		[Token(Token = "0x4037865")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037866 RID: 227430
		[Token(Token = "0x4037866")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037867 RID: 227431
		[Token(Token = "0x4037867")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
