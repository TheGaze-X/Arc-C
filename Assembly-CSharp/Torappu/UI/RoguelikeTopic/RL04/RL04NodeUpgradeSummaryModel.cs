using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046B6 RID: 18102
	[Token(Token = "0x20046B6")]
	public class RL04NodeUpgradeSummaryModel : IHotfixable
	{
		// Token: 0x17004157 RID: 16727
		// (get) Token: 0x0601B740 RID: 112448 RVA: 0x000A53C0 File Offset: 0x000A35C0
		// (set) Token: 0x0601B741 RID: 112449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004157")]
		public RoguelikeEventType currNodeType
		{
			[Token(Token = "0x601B740")]
			[Address(RVA = "0x14CBE90", Offset = "0x14CAA90", VA = "0x1814CBE90")]
			[CompilerGenerated]
			get
			{
				return RoguelikeEventType.NONE;
			}
			[Token(Token = "0x601B741")]
			[Address(RVA = "0x14CC070", Offset = "0x14CAC70", VA = "0x1814CC070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004158 RID: 16728
		// (get) Token: 0x0601B742 RID: 112450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004158")]
		public List<RL04NodeUpgradeModel> nodeUpgradeList
		{
			[Token(Token = "0x601B742")]
			[Address(RVA = "0x14CBFB0", Offset = "0x14CABB0", VA = "0x1814CBFB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004159 RID: 16729
		// (get) Token: 0x0601B743 RID: 112451 RVA: 0x000A53D8 File Offset: 0x000A35D8
		// (set) Token: 0x0601B744 RID: 112452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004159")]
		public int enterSeqNum
		{
			[Token(Token = "0x601B743")]
			[Address(RVA = "0x14CBEF0", Offset = "0x14CAAF0", VA = "0x1814CBEF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601B744")]
			[Address(RVA = "0x14CC0E0", Offset = "0x14CACE0", VA = "0x1814CC0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700415A RID: 16730
		// (get) Token: 0x0601B745 RID: 112453 RVA: 0x000A53F0 File Offset: 0x000A35F0
		// (set) Token: 0x0601B746 RID: 112454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700415A")]
		public int switchSeqNum
		{
			[Token(Token = "0x601B745")]
			[Address(RVA = "0x14CC010", Offset = "0x14CAC10", VA = "0x1814CC010")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601B746")]
			[Address(RVA = "0x14CC150", Offset = "0x14CAD50", VA = "0x1814CC150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700415B RID: 16731
		// (get) Token: 0x0601B747 RID: 112455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700415B")]
		public Dictionary<int, int> muralSeqDict
		{
			[Token(Token = "0x601B747")]
			[Address(RVA = "0x14CBF50", Offset = "0x14CAB50", VA = "0x1814CBF50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B748 RID: 112456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B748")]
		[Address(RVA = "0x14CB410", Offset = "0x14CA010", VA = "0x1814CB410")]
		public RL04NodeUpgradeModel GetCurrUpgradeModel()
		{
			return null;
		}

		// Token: 0x0601B749 RID: 112457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B749")]
		[Address(RVA = "0x14CBB40", Offset = "0x14CA740", VA = "0x1814CBB40")]
		public void UpdateEnterSeqNum()
		{
		}

		// Token: 0x0601B74A RID: 112458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B74A")]
		[Address(RVA = "0x14CBC40", Offset = "0x14CA840", VA = "0x1814CBC40")]
		private void _UpdateMuralSeq()
		{
		}

		// Token: 0x0601B74B RID: 112459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B74B")]
		[Address(RVA = "0x14CB590", Offset = "0x14CA190", VA = "0x1814CB590")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601B74C RID: 112460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B74C")]
		[Address(RVA = "0x14CBA00", Offset = "0x14CA600", VA = "0x1814CBA00")]
		public void SelectNodeType(RoguelikeEventType nodeType)
		{
		}

		// Token: 0x0601B74D RID: 112461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B74D")]
		[Address(RVA = "0x14CBD90", Offset = "0x14CA990", VA = "0x1814CBD90")]
		public RL04NodeUpgradeSummaryModel()
		{
		}

		// Token: 0x04023898 RID: 145560
		[Token(Token = "0x4023898")]
		[FieldOffset(Offset = "0x10")]
		private List<RL04NodeUpgradeModel> m_nodeUpgradeList;

		// Token: 0x04023899 RID: 145561
		[Token(Token = "0x4023899")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;

		// Token: 0x0402389A RID: 145562
		[Token(Token = "0x402389A")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, int> m_muralSeqDict;

		// Token: 0x0402389E RID: 145566
		[Token(Token = "0x402389E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currNodeType;

		// Token: 0x0402389F RID: 145567
		[Token(Token = "0x402389F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_currNodeType;

		// Token: 0x040238A0 RID: 145568
		[Token(Token = "0x40238A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_nodeUpgradeList;

		// Token: 0x040238A1 RID: 145569
		[Token(Token = "0x40238A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enterSeqNum;

		// Token: 0x040238A2 RID: 145570
		[Token(Token = "0x40238A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_enterSeqNum;

		// Token: 0x040238A3 RID: 145571
		[Token(Token = "0x40238A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_switchSeqNum;

		// Token: 0x040238A4 RID: 145572
		[Token(Token = "0x40238A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_switchSeqNum;

		// Token: 0x040238A5 RID: 145573
		[Token(Token = "0x40238A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_muralSeqDict;

		// Token: 0x040238A6 RID: 145574
		[Token(Token = "0x40238A6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCurrUpgradeModel;

		// Token: 0x040238A7 RID: 145575
		[Token(Token = "0x40238A7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateEnterSeqNum;

		// Token: 0x040238A8 RID: 145576
		[Token(Token = "0x40238A8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateMuralSeq;

		// Token: 0x040238A9 RID: 145577
		[Token(Token = "0x40238A9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040238AA RID: 145578
		[Token(Token = "0x40238AA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SelectNodeType;

		// Token: 0x040238AB RID: 145579
		[Token(Token = "0x40238AB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
