using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005653 RID: 22099
	[Token(Token = "0x2005653")]
	public class RL04AlchemySlotItemViewModel : IHotfixable
	{
		// Token: 0x17004BD7 RID: 19415
		// (get) Token: 0x060206B0 RID: 132784 RVA: 0x000B5C68 File Offset: 0x000B3E68
		// (set) Token: 0x060206B1 RID: 132785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BD7")]
		public int index
		{
			[Token(Token = "0x60206B0")]
			[Address(RVA = "0x1A9F5D0", Offset = "0x1A9E1D0", VA = "0x181A9F5D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60206B1")]
			[Address(RVA = "0x1A9F790", Offset = "0x1A9E390", VA = "0x181A9F790")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BD8 RID: 19416
		// (get) Token: 0x060206B2 RID: 132786 RVA: 0x000B5C80 File Offset: 0x000B3E80
		// (set) Token: 0x060206B3 RID: 132787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BD8")]
		public RL04AlchemySlotItemViewModel.SlotItemStatus status
		{
			[Token(Token = "0x60206B2")]
			[Address(RVA = "0x1A9F630", Offset = "0x1A9E230", VA = "0x181A9F630")]
			[CompilerGenerated]
			get
			{
				return RL04AlchemySlotItemViewModel.SlotItemStatus.EMPTY;
			}
			[Token(Token = "0x60206B3")]
			[Address(RVA = "0x1A9F800", Offset = "0x1A9E400", VA = "0x181A9F800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BD9 RID: 19417
		// (get) Token: 0x060206B4 RID: 132788 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060206B5 RID: 132789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BD9")]
		public string fragmentInstId
		{
			[Token(Token = "0x60206B4")]
			[Address(RVA = "0x1A9F510", Offset = "0x1A9E110", VA = "0x181A9F510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60206B5")]
			[Address(RVA = "0x1A9F690", Offset = "0x1A9E290", VA = "0x181A9F690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BDA RID: 19418
		// (get) Token: 0x060206B6 RID: 132790 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060206B7 RID: 132791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BDA")]
		public RL04AlchemyFragmentItemViewModel fragmentItemViewModel
		{
			[Token(Token = "0x60206B6")]
			[Address(RVA = "0x1A9F570", Offset = "0x1A9E170", VA = "0x181A9F570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60206B7")]
			[Address(RVA = "0x1A9F710", Offset = "0x1A9E310", VA = "0x181A9F710")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060206B8 RID: 132792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206B8")]
		[Address(RVA = "0x1A9F4B0", Offset = "0x1A9E0B0", VA = "0x181A9F4B0")]
		public RL04AlchemySlotItemViewModel()
		{
		}

		// Token: 0x0402BE52 RID: 179794
		[Token(Token = "0x402BE52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x0402BE53 RID: 179795
		[Token(Token = "0x402BE53")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x0402BE54 RID: 179796
		[Token(Token = "0x402BE54")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x0402BE55 RID: 179797
		[Token(Token = "0x402BE55")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_status;

		// Token: 0x0402BE56 RID: 179798
		[Token(Token = "0x402BE56")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_fragmentInstId;

		// Token: 0x0402BE57 RID: 179799
		[Token(Token = "0x402BE57")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_fragmentInstId;

		// Token: 0x0402BE58 RID: 179800
		[Token(Token = "0x402BE58")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_fragmentItemViewModel;

		// Token: 0x0402BE59 RID: 179801
		[Token(Token = "0x402BE59")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_fragmentItemViewModel;

		// Token: 0x0402BE5A RID: 179802
		[Token(Token = "0x402BE5A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005654 RID: 22100
		[Token(Token = "0x2005654")]
		public enum SlotItemStatus
		{
			// Token: 0x0402BE5C RID: 179804
			[Token(Token = "0x402BE5C")]
			EMPTY,
			// Token: 0x0402BE5D RID: 179805
			[Token(Token = "0x402BE5D")]
			FILLED
		}
	}
}
