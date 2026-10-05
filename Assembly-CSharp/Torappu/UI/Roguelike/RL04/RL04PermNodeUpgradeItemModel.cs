using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056FA RID: 22266
	[Token(Token = "0x20056FA")]
	public class RL04PermNodeUpgradeItemModel : RL04NodeUpgradeItemModel
	{
		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x06020A98 RID: 133784 RVA: 0x000B6BC8 File Offset: 0x000B4DC8
		// (set) Token: 0x06020A99 RID: 133785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C99")]
		public int nodeLevel
		{
			[Token(Token = "0x6020A98")]
			[Address(RVA = "0x1ACDE80", Offset = "0x1ACCA80", VA = "0x181ACDE80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020A99")]
			[Address(RVA = "0x1ACDF40", Offset = "0x1ACCB40", VA = "0x181ACDF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x06020A9A RID: 133786 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020A9B RID: 133787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C9A")]
		public string nodeName
		{
			[Token(Token = "0x6020A9A")]
			[Address(RVA = "0x1ACDEE0", Offset = "0x1ACCAE0", VA = "0x181ACDEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020A9B")]
			[Address(RVA = "0x1ACDFB0", Offset = "0x1ACCBB0", VA = "0x181ACDFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C9B RID: 19611
		// (get) Token: 0x06020A9C RID: 133788 RVA: 0x000B6BE0 File Offset: 0x000B4DE0
		[Token(Token = "0x17004C9B")]
		public override bool isTemp
		{
			[Token(Token = "0x6020A9C")]
			[Address(RVA = "0x1ACDE20", Offset = "0x1ACCA20", VA = "0x181ACDE20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020A9D RID: 133789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A9D")]
		[Address(RVA = "0x1ACDC30", Offset = "0x1ACC830", VA = "0x181ACDC30")]
		public void LoadData(RoguelikePermNodeUpgradeItemData permItemData)
		{
		}

		// Token: 0x06020A9E RID: 133790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A9E")]
		[Address(RVA = "0x1ACDD80", Offset = "0x1ACC980", VA = "0x181ACDD80")]
		public RL04PermNodeUpgradeItemModel()
		{
		}

		// Token: 0x0402C50B RID: 181515
		[Token(Token = "0x402C50B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeLevel;

		// Token: 0x0402C50C RID: 181516
		[Token(Token = "0x402C50C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_nodeLevel;

		// Token: 0x0402C50D RID: 181517
		[Token(Token = "0x402C50D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_nodeName;

		// Token: 0x0402C50E RID: 181518
		[Token(Token = "0x402C50E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_nodeName;

		// Token: 0x0402C50F RID: 181519
		[Token(Token = "0x402C50F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isTemp;

		// Token: 0x0402C510 RID: 181520
		[Token(Token = "0x402C510")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C511 RID: 181521
		[Token(Token = "0x402C511")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
