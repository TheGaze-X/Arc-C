using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056FB RID: 22267
	[Token(Token = "0x20056FB")]
	public class RL04TempNodeUpgradeItemModel : RL04NodeUpgradeItemModel
	{
		// Token: 0x17004C9C RID: 19612
		// (get) Token: 0x06020A9F RID: 133791 RVA: 0x000B6BF8 File Offset: 0x000B4DF8
		// (set) Token: 0x06020AA0 RID: 133792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C9C")]
		public int sortId
		{
			[Token(Token = "0x6020A9F")]
			[Address(RVA = "0x1ACF050", Offset = "0x1ACDC50", VA = "0x181ACF050")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020AA0")]
			[Address(RVA = "0x1ACF0B0", Offset = "0x1ACDCB0", VA = "0x181ACF0B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C9D RID: 19613
		// (get) Token: 0x06020AA1 RID: 133793 RVA: 0x000B6C10 File Offset: 0x000B4E10
		[Token(Token = "0x17004C9D")]
		public override bool isTemp
		{
			[Token(Token = "0x6020AA1")]
			[Address(RVA = "0x1ACEFF0", Offset = "0x1ACDBF0", VA = "0x181ACEFF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020AA2 RID: 133794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AA2")]
		[Address(RVA = "0x1ACEE40", Offset = "0x1ACDA40", VA = "0x181ACEE40")]
		public void LoadData(RoguelikeTempNodeUpgradeItemData tempItemData)
		{
		}

		// Token: 0x06020AA3 RID: 133795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AA3")]
		[Address(RVA = "0x1ACEF50", Offset = "0x1ACDB50", VA = "0x181ACEF50")]
		public RL04TempNodeUpgradeItemModel()
		{
		}

		// Token: 0x0402C513 RID: 181523
		[Token(Token = "0x402C513")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0402C514 RID: 181524
		[Token(Token = "0x402C514")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x0402C515 RID: 181525
		[Token(Token = "0x402C515")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isTemp;

		// Token: 0x0402C516 RID: 181526
		[Token(Token = "0x402C516")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C517 RID: 181527
		[Token(Token = "0x402C517")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
