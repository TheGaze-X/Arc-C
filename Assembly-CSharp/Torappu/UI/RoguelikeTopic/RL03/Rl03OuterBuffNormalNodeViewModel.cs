using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045F1 RID: 17905
	[Token(Token = "0x20045F1")]
	public class Rl03OuterBuffNormalNodeViewModel : Rl03OuterBuffNodeBaseViewModel
	{
		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x0601B375 RID: 111477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040D3")]
		public override string topicId
		{
			[Token(Token = "0x601B375")]
			[Address(RVA = "0x1467FC0", Offset = "0x1466BC0", VA = "0x181467FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x0601B376 RID: 111478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040D4")]
		public override string buffId
		{
			[Token(Token = "0x601B376")]
			[Address(RVA = "0x1467C00", Offset = "0x1466800", VA = "0x181467C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x0601B377 RID: 111479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040D5")]
		public override string buffName
		{
			[Token(Token = "0x601B377")]
			[Address(RVA = "0x1467C60", Offset = "0x1466860", VA = "0x181467C60", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x0601B378 RID: 111480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040D6")]
		public string buffDesc
		{
			[Token(Token = "0x601B378")]
			[Address(RVA = "0x1467BA0", Offset = "0x14667A0", VA = "0x181467BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x0601B379 RID: 111481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040D7")]
		public override string iconId
		{
			[Token(Token = "0x601B379")]
			[Address(RVA = "0x1467D20", Offset = "0x1466920", VA = "0x181467D20", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x0601B37A RID: 111482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040D8")]
		public override string groupId
		{
			[Token(Token = "0x601B37A")]
			[Address(RVA = "0x1467CC0", Offset = "0x14668C0", VA = "0x181467CC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x0601B37B RID: 111483 RVA: 0x000A4A48 File Offset: 0x000A2C48
		[Token(Token = "0x170040D9")]
		public override RL03DevelopmentNodeType nodeType
		{
			[Token(Token = "0x601B37B")]
			[Address(RVA = "0x1467F00", Offset = "0x1466B00", VA = "0x181467F00", Slot = "11")]
			get
			{
				return RL03DevelopmentNodeType.NONE;
			}
		}

		// Token: 0x170040DA RID: 16602
		// (get) Token: 0x0601B37C RID: 111484 RVA: 0x000A4A60 File Offset: 0x000A2C60
		[Token(Token = "0x170040DA")]
		public bool isUnlock
		{
			[Token(Token = "0x601B37C")]
			[Address(RVA = "0x1467E40", Offset = "0x1466A40", VA = "0x181467E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x0601B37D RID: 111485 RVA: 0x000A4A78 File Offset: 0x000A2C78
		[Token(Token = "0x170040DB")]
		public override bool isActive
		{
			[Token(Token = "0x601B37D")]
			[Address(RVA = "0x1467D80", Offset = "0x1466980", VA = "0x181467D80", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x0601B37E RID: 111486 RVA: 0x000A4A90 File Offset: 0x000A2C90
		[Token(Token = "0x170040DC")]
		public bool isInGame
		{
			[Token(Token = "0x601B37E")]
			[Address(RVA = "0x1467DE0", Offset = "0x14669E0", VA = "0x181467DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x0601B37F RID: 111487 RVA: 0x000A4AA8 File Offset: 0x000A2CA8
		[Token(Token = "0x170040DD")]
		public override Rl03OuterBuffViewType viewType
		{
			[Token(Token = "0x601B37F")]
			[Address(RVA = "0x1468020", Offset = "0x1466C20", VA = "0x181468020", Slot = "10")]
			get
			{
				return Rl03OuterBuffViewType.NORMAL;
			}
		}

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x0601B380 RID: 111488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040DE")]
		public List<string> nextNodeIds
		{
			[Token(Token = "0x601B380")]
			[Address(RVA = "0x1467EA0", Offset = "0x1466AA0", VA = "0x181467EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x0601B381 RID: 111489 RVA: 0x000A4AC0 File Offset: 0x000A2CC0
		[Token(Token = "0x170040DF")]
		public int tokenCost
		{
			[Token(Token = "0x601B381")]
			[Address(RVA = "0x1467F60", Offset = "0x1466B60", VA = "0x181467F60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601B382 RID: 111490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B382")]
		[Address(RVA = "0x14675B0", Offset = "0x14661B0", VA = "0x1814675B0", Slot = "12")]
		public override void LoadData(string topicId, RL03Development buffData, Dictionary<string, RL03DevDifficultyNodeInfo> diffData)
		{
		}

		// Token: 0x0601B383 RID: 111491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B383")]
		[Address(RVA = "0x1467810", Offset = "0x1466410", VA = "0x181467810", Slot = "13")]
		public override void RefreshStatus(Dictionary<string, int> playerNodeStatus)
		{
		}

		// Token: 0x0601B384 RID: 111492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B384")]
		[Address(RVA = "0x14679E0", Offset = "0x14665E0", VA = "0x1814679E0")]
		private void _AddDiffFrontNode(RL03DevDifficultyNodeInfo diffInfo)
		{
		}

		// Token: 0x0601B385 RID: 111493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B385")]
		[Address(RVA = "0x1467B00", Offset = "0x1466700", VA = "0x181467B00")]
		public Rl03OuterBuffNormalNodeViewModel()
		{
		}

		// Token: 0x04023178 RID: 143736
		[Token(Token = "0x4023178")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x04023179 RID: 143737
		[Token(Token = "0x4023179")]
		[FieldOffset(Offset = "0x18")]
		private string m_buffId;

		// Token: 0x0402317A RID: 143738
		[Token(Token = "0x402317A")]
		[FieldOffset(Offset = "0x20")]
		private string m_buffName;

		// Token: 0x0402317B RID: 143739
		[Token(Token = "0x402317B")]
		[FieldOffset(Offset = "0x28")]
		private string m_buffDesc;

		// Token: 0x0402317C RID: 143740
		[Token(Token = "0x402317C")]
		[FieldOffset(Offset = "0x30")]
		private string m_iconId;

		// Token: 0x0402317D RID: 143741
		[Token(Token = "0x402317D")]
		[FieldOffset(Offset = "0x38")]
		private string m_groupId;

		// Token: 0x0402317E RID: 143742
		[Token(Token = "0x402317E")]
		[FieldOffset(Offset = "0x40")]
		private RL03DevelopmentNodeType m_nodeType;

		// Token: 0x0402317F RID: 143743
		[Token(Token = "0x402317F")]
		[FieldOffset(Offset = "0x44")]
		private bool m_isUnlock;

		// Token: 0x04023180 RID: 143744
		[Token(Token = "0x4023180")]
		[FieldOffset(Offset = "0x45")]
		private bool m_isActive;

		// Token: 0x04023181 RID: 143745
		[Token(Token = "0x4023181")]
		[FieldOffset(Offset = "0x46")]
		private bool m_isInGame;

		// Token: 0x04023182 RID: 143746
		[Token(Token = "0x4023182")]
		[FieldOffset(Offset = "0x48")]
		private List<string> m_frontNodeIds;

		// Token: 0x04023183 RID: 143747
		[Token(Token = "0x4023183")]
		[FieldOffset(Offset = "0x50")]
		private List<string> m_nextNodeIds;

		// Token: 0x04023184 RID: 143748
		[Token(Token = "0x4023184")]
		[FieldOffset(Offset = "0x58")]
		private int m_tokenCost;

		// Token: 0x04023185 RID: 143749
		[Token(Token = "0x4023185")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04023186 RID: 143750
		[Token(Token = "0x4023186")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_buffId;

		// Token: 0x04023187 RID: 143751
		[Token(Token = "0x4023187")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_buffName;

		// Token: 0x04023188 RID: 143752
		[Token(Token = "0x4023188")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_buffDesc;

		// Token: 0x04023189 RID: 143753
		[Token(Token = "0x4023189")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_iconId;

		// Token: 0x0402318A RID: 143754
		[Token(Token = "0x402318A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x0402318B RID: 143755
		[Token(Token = "0x402318B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0402318C RID: 143756
		[Token(Token = "0x402318C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x0402318D RID: 143757
		[Token(Token = "0x402318D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isActive;

		// Token: 0x0402318E RID: 143758
		[Token(Token = "0x402318E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isInGame;

		// Token: 0x0402318F RID: 143759
		[Token(Token = "0x402318F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x04023190 RID: 143760
		[Token(Token = "0x4023190")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_nextNodeIds;

		// Token: 0x04023191 RID: 143761
		[Token(Token = "0x4023191")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_tokenCost;

		// Token: 0x04023192 RID: 143762
		[Token(Token = "0x4023192")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04023193 RID: 143763
		[Token(Token = "0x4023193")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RefreshStatus;

		// Token: 0x04023194 RID: 143764
		[Token(Token = "0x4023194")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__AddDiffFrontNode;

		// Token: 0x04023195 RID: 143765
		[Token(Token = "0x4023195")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
