using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056F7 RID: 22263
	[Token(Token = "0x20056F7")]
	public class RL04NodeUpgradeModel : IHotfixable
	{
		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x06020A74 RID: 133748 RVA: 0x000B6B08 File Offset: 0x000B4D08
		// (set) Token: 0x06020A75 RID: 133749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C8C")]
		public int currPermLevel
		{
			[Token(Token = "0x6020A74")]
			[Address(RVA = "0x1ACB660", Offset = "0x1ACA260", VA = "0x181ACB660")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020A75")]
			[Address(RVA = "0x1ACB8C0", Offset = "0x1ACA4C0", VA = "0x181ACB8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x06020A76 RID: 133750 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020A77 RID: 133751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C8D")]
		public string typeName
		{
			[Token(Token = "0x6020A76")]
			[Address(RVA = "0x1ACB860", Offset = "0x1ACA460", VA = "0x181ACB860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020A77")]
			[Address(RVA = "0x1ACBA10", Offset = "0x1ACA610", VA = "0x181ACBA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x06020A78 RID: 133752 RVA: 0x000B6B20 File Offset: 0x000B4D20
		// (set) Token: 0x06020A79 RID: 133753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C8E")]
		public RoguelikeEventType nodeType
		{
			[Token(Token = "0x6020A78")]
			[Address(RVA = "0x1ACB720", Offset = "0x1ACA320", VA = "0x181ACB720")]
			[CompilerGenerated]
			get
			{
				return RoguelikeEventType.NONE;
			}
			[Token(Token = "0x6020A79")]
			[Address(RVA = "0x1ACB9A0", Offset = "0x1ACA5A0", VA = "0x181ACB9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x06020A7A RID: 133754 RVA: 0x000B6B38 File Offset: 0x000B4D38
		// (set) Token: 0x06020A7B RID: 133755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C8F")]
		public int enterSeqNum
		{
			[Token(Token = "0x6020A7A")]
			[Address(RVA = "0x1ACB6C0", Offset = "0x1ACA2C0", VA = "0x181ACB6C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020A7B")]
			[Address(RVA = "0x1ACB930", Offset = "0x1ACA530", VA = "0x181ACB930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004C90 RID: 19600
		// (get) Token: 0x06020A7C RID: 133756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C90")]
		public List<RL04PermNodeUpgradeItemModel> permItemList
		{
			[Token(Token = "0x6020A7C")]
			[Address(RVA = "0x1ACB780", Offset = "0x1ACA380", VA = "0x181ACB780")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x06020A7D RID: 133757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C91")]
		public RL04TempNodeUpgradeItemModel tempUpgradeModel
		{
			[Token(Token = "0x6020A7D")]
			[Address(RVA = "0x1ACB7E0", Offset = "0x1ACA3E0", VA = "0x181ACB7E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020A7E RID: 133758 RVA: 0x000B6B50 File Offset: 0x000B4D50
		[Token(Token = "0x6020A7E")]
		[Address(RVA = "0x1ACA4B0", Offset = "0x1AC90B0", VA = "0x181ACA4B0")]
		public bool IsAllPermUnlock()
		{
			return default(bool);
		}

		// Token: 0x06020A7F RID: 133759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020A7F")]
		[Address(RVA = "0x1ACA370", Offset = "0x1AC8F70", VA = "0x181ACA370")]
		public RL04NodeUpgradeItemModel GetNextUpgradeModel()
		{
			return null;
		}

		// Token: 0x06020A80 RID: 133760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A80")]
		[Address(RVA = "0x1ACAF60", Offset = "0x1AC9B60", VA = "0x181ACAF60")]
		public void UpdateEnterSeqNum()
		{
		}

		// Token: 0x06020A81 RID: 133761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A81")]
		[Address(RVA = "0x1ACA590", Offset = "0x1AC9190", VA = "0x181ACA590")]
		public void LoadData(string topicId, RoguelikeEventType nodeType)
		{
		}

		// Token: 0x06020A82 RID: 133762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A82")]
		[Address(RVA = "0x1ACB140", Offset = "0x1AC9D40", VA = "0x181ACB140")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x06020A83 RID: 133763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A83")]
		[Address(RVA = "0x1ACB1A0", Offset = "0x1AC9DA0", VA = "0x181ACB1A0")]
		private void _UpdatePlayerData()
		{
		}

		// Token: 0x06020A84 RID: 133764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A84")]
		[Address(RVA = "0x1ACB550", Offset = "0x1ACA150", VA = "0x181ACB550")]
		public RL04NodeUpgradeModel()
		{
		}

		// Token: 0x0402C4D9 RID: 181465
		[Token(Token = "0x402C4D9")]
		[FieldOffset(Offset = "0x10")]
		private List<RL04PermNodeUpgradeItemModel> m_permItemList;

		// Token: 0x0402C4DA RID: 181466
		[Token(Token = "0x402C4DA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, RL04TempNodeUpgradeItemModel> m_tempItemDict;

		// Token: 0x0402C4DB RID: 181467
		[Token(Token = "0x402C4DB")]
		[FieldOffset(Offset = "0x20")]
		private string m_topicId;

		// Token: 0x0402C4DC RID: 181468
		[Token(Token = "0x402C4DC")]
		[FieldOffset(Offset = "0x28")]
		private string m_currTempUpgradeId;

		// Token: 0x0402C4E1 RID: 181473
		[Token(Token = "0x402C4E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currPermLevel;

		// Token: 0x0402C4E2 RID: 181474
		[Token(Token = "0x402C4E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_currPermLevel;

		// Token: 0x0402C4E3 RID: 181475
		[Token(Token = "0x402C4E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_typeName;

		// Token: 0x0402C4E4 RID: 181476
		[Token(Token = "0x402C4E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_typeName;

		// Token: 0x0402C4E5 RID: 181477
		[Token(Token = "0x402C4E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0402C4E6 RID: 181478
		[Token(Token = "0x402C4E6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_nodeType;

		// Token: 0x0402C4E7 RID: 181479
		[Token(Token = "0x402C4E7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_enterSeqNum;

		// Token: 0x0402C4E8 RID: 181480
		[Token(Token = "0x402C4E8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_enterSeqNum;

		// Token: 0x0402C4E9 RID: 181481
		[Token(Token = "0x402C4E9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_permItemList;

		// Token: 0x0402C4EA RID: 181482
		[Token(Token = "0x402C4EA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_tempUpgradeModel;

		// Token: 0x0402C4EB RID: 181483
		[Token(Token = "0x402C4EB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsAllPermUnlock;

		// Token: 0x0402C4EC RID: 181484
		[Token(Token = "0x402C4EC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetNextUpgradeModel;

		// Token: 0x0402C4ED RID: 181485
		[Token(Token = "0x402C4ED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateEnterSeqNum;

		// Token: 0x0402C4EE RID: 181486
		[Token(Token = "0x402C4EE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C4EF RID: 181487
		[Token(Token = "0x402C4EF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0402C4F0 RID: 181488
		[Token(Token = "0x402C4F0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdatePlayerData;

		// Token: 0x0402C4F1 RID: 181489
		[Token(Token = "0x402C4F1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
