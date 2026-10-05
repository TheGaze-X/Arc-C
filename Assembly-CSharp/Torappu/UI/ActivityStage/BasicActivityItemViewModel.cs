using System;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CDB RID: 27867
	[Token(Token = "0x2006CDB")]
	public class BasicActivityItemViewModel
	{
		// Token: 0x17005DD7 RID: 24023
		// (get) Token: 0x06027BEF RID: 162799 RVA: 0x000CF360 File Offset: 0x000CD560
		[Token(Token = "0x17005DD7")]
		public bool isReplicate
		{
			[Token(Token = "0x6027BEF")]
			[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027BF0 RID: 162800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BF0")]
		[Address(RVA = "0x22F7180", Offset = "0x22F5D80", VA = "0x1822F7180")]
		public BasicActivityItemViewModel(string actId, ItemBundle normalItem)
		{
		}

		// Token: 0x06027BF1 RID: 162801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BF1")]
		[Address(RVA = "0x22F7280", Offset = "0x22F5E80", VA = "0x1822F7280")]
		public BasicActivityItemViewModel(string actId, string itemId, int count, ItemType itemType)
		{
		}

		// Token: 0x040385E7 RID: 230887
		[Token(Token = "0x40385E7")]
		[FieldOffset(Offset = "0x10")]
		public ItemBundle commonItemBundle;

		// Token: 0x040385E8 RID: 230888
		[Token(Token = "0x40385E8")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle replicateItemBundle;
	}
}
