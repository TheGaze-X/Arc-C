using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005655 RID: 22101
	[Token(Token = "0x2005655")]
	public class RL04AlchemySlotListViewModel : IHotfixable
	{
		// Token: 0x17004BDB RID: 19419
		// (get) Token: 0x060206B9 RID: 132793 RVA: 0x000B5C98 File Offset: 0x000B3E98
		// (set) Token: 0x060206BA RID: 132794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BDB")]
		public RL04AlchemySlotListViewModel.SlotListStatus listStatus
		{
			[Token(Token = "0x60206B9")]
			[Address(RVA = "0x1AA0150", Offset = "0x1A9ED50", VA = "0x181AA0150")]
			[CompilerGenerated]
			get
			{
				return (RL04AlchemySlotListViewModel.SlotListStatus)0;
			}
			[Token(Token = "0x60206BA")]
			[Address(RVA = "0x1AA0210", Offset = "0x1A9EE10", VA = "0x181AA0210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BDC RID: 19420
		// (get) Token: 0x060206BB RID: 132795 RVA: 0x000B5CB0 File Offset: 0x000B3EB0
		// (set) Token: 0x060206BC RID: 132796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BDC")]
		public int slotMaxCount
		{
			[Token(Token = "0x60206BB")]
			[Address(RVA = "0x1AA01B0", Offset = "0x1A9EDB0", VA = "0x181AA01B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60206BC")]
			[Address(RVA = "0x1AA0280", Offset = "0x1A9EE80", VA = "0x181AA0280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060206BD RID: 132797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206BD")]
		[Address(RVA = "0x1AA00A0", Offset = "0x1A9ECA0", VA = "0x181AA00A0")]
		public RL04AlchemySlotListViewModel()
		{
		}

		// Token: 0x0402BE60 RID: 179808
		[Token(Token = "0x402BE60")]
		[FieldOffset(Offset = "0x18")]
		public List<RL04AlchemySlotItemViewModel> slotItemViewModels;

		// Token: 0x0402BE61 RID: 179809
		[Token(Token = "0x402BE61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_listStatus;

		// Token: 0x0402BE62 RID: 179810
		[Token(Token = "0x402BE62")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_listStatus;

		// Token: 0x0402BE63 RID: 179811
		[Token(Token = "0x402BE63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_slotMaxCount;

		// Token: 0x0402BE64 RID: 179812
		[Token(Token = "0x402BE64")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_slotMaxCount;

		// Token: 0x0402BE65 RID: 179813
		[Token(Token = "0x402BE65")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005656 RID: 22102
		[Token(Token = "0x2005656")]
		[Flags]
		public enum SlotListStatus
		{
			// Token: 0x0402BE67 RID: 179815
			[Token(Token = "0x402BE67")]
			NONE = 1,
			// Token: 0x0402BE68 RID: 179816
			[Token(Token = "0x402BE68")]
			FULL = 2,
			// Token: 0x0402BE69 RID: 179817
			[Token(Token = "0x402BE69")]
			EMPTY = 4,
			// Token: 0x0402BE6A RID: 179818
			[Token(Token = "0x402BE6A")]
			NEITHER_FULL_NOR_EMPTY = -7
		}
	}
}
