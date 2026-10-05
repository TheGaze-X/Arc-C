using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004528 RID: 17704
	[Token(Token = "0x2004528")]
	public class RoguelikeCommonOuterBuffViewModel : IHotfixable
	{
		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x0601AFF9 RID: 110585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004033")]
		public string topicId
		{
			[Token(Token = "0x601AFF9")]
			[Address(RVA = "0x14260D0", Offset = "0x1424CD0", VA = "0x1814260D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x0601AFFA RID: 110586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004034")]
		public string tokenId
		{
			[Token(Token = "0x601AFFA")]
			[Address(RVA = "0x1426010", Offset = "0x1424C10", VA = "0x181426010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x0601AFFB RID: 110587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004035")]
		public string tokenName
		{
			[Token(Token = "0x601AFFB")]
			[Address(RVA = "0x1426070", Offset = "0x1424C70", VA = "0x181426070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x0601AFFC RID: 110588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004036")]
		public ListDict<string, RoguelikeCommonOuterBuffNodeBaseViewModel> nodes
		{
			[Token(Token = "0x601AFFC")]
			[Address(RVA = "0x1425F50", Offset = "0x1424B50", VA = "0x181425F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x0601AFFD RID: 110589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004037")]
		public Dictionary<string, RoguelikeCommonOuterBuffLocationGroupViewModel> locationGroups
		{
			[Token(Token = "0x601AFFD")]
			[Address(RVA = "0x1425E90", Offset = "0x1424A90", VA = "0x181425E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x0601AFFE RID: 110590 RVA: 0x000A3DA0 File Offset: 0x000A1FA0
		[Token(Token = "0x17004038")]
		public int activeDiffCount
		{
			[Token(Token = "0x601AFFE")]
			[Address(RVA = "0x1425DD0", Offset = "0x14249D0", VA = "0x181425DD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x0601AFFF RID: 110591 RVA: 0x000A3DB8 File Offset: 0x000A1FB8
		[Token(Token = "0x17004039")]
		public int tokenCount
		{
			[Token(Token = "0x601AFFF")]
			[Address(RVA = "0x1425FB0", Offset = "0x1424BB0", VA = "0x181425FB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x0601B000 RID: 110592 RVA: 0x000A3DD0 File Offset: 0x000A1FD0
		[Token(Token = "0x1700403A")]
		public int nodeCount
		{
			[Token(Token = "0x601B000")]
			[Address(RVA = "0x1425EF0", Offset = "0x1424AF0", VA = "0x181425EF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x0601B001 RID: 110593 RVA: 0x000A3DE8 File Offset: 0x000A1FE8
		[Token(Token = "0x1700403B")]
		public int activeNodeCount
		{
			[Token(Token = "0x601B001")]
			[Address(RVA = "0x1425E30", Offset = "0x1424A30", VA = "0x181425E30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601B002 RID: 110594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B002")]
		[Address(RVA = "0x1424CD0", Offset = "0x14238D0", VA = "0x181424CD0")]
		public void LoadData(string topicId, RoguelikeCommonDevelopmentData developmentData)
		{
		}

		// Token: 0x0601B003 RID: 110595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B003")]
		[Address(RVA = "0x1424F90", Offset = "0x1423B90", VA = "0x181424F90")]
		public void UpdateNodesStatus()
		{
		}

		// Token: 0x0601B004 RID: 110596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B004")]
		[Address(RVA = "0x1424E60", Offset = "0x1423A60", VA = "0x181424E60")]
		public void UpdateNodeStatus(string nodeId)
		{
		}

		// Token: 0x0601B005 RID: 110597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B005")]
		[Address(RVA = "0x1425180", Offset = "0x1423D80", VA = "0x181425180")]
		private void _LoadNodes(PlayerRoguelikeV2.OuterData.Buff playerOuterBuff, Dictionary<string, RoguelikeCommonDevelopment> developments, Dictionary<string, RoguelikeCommonDevDifficultyNodeInfo> difficultyInfos)
		{
		}

		// Token: 0x0601B006 RID: 110598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B006")]
		[Address(RVA = "0x1425AF0", Offset = "0x14246F0", VA = "0x181425AF0")]
		private void _UpdateNode(string nodeId, PlayerRoguelikeV2.OuterData.Buff playerOuterBuff)
		{
		}

		// Token: 0x0601B007 RID: 110599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B007")]
		[Address(RVA = "0x1425950", Offset = "0x1424550", VA = "0x181425950")]
		private void _UpdateDiffNode(RoguelikeCommonOuterBuffDifficultyNodeViewModel diffModel, Dictionary<string, int> playerNodeStatus)
		{
		}

		// Token: 0x0601B008 RID: 110600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B008")]
		[Address(RVA = "0x1425620", Offset = "0x1424220", VA = "0x181425620")]
		private void _UpdateCount(PlayerRoguelikeV2.OuterData.Buff playerOuterBuff)
		{
		}

		// Token: 0x0601B009 RID: 110601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B009")]
		[Address(RVA = "0x1425D70", Offset = "0x1424970", VA = "0x181425D70")]
		public RoguelikeCommonOuterBuffViewModel()
		{
		}

		// Token: 0x04022AD7 RID: 142039
		[Token(Token = "0x4022AD7")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x04022AD8 RID: 142040
		[Token(Token = "0x4022AD8")]
		[FieldOffset(Offset = "0x18")]
		private string m_tokenId;

		// Token: 0x04022AD9 RID: 142041
		[Token(Token = "0x4022AD9")]
		[FieldOffset(Offset = "0x20")]
		private string m_tokenName;

		// Token: 0x04022ADA RID: 142042
		[Token(Token = "0x4022ADA")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, RoguelikeCommonOuterBuffNodeBaseViewModel> m_nodes;

		// Token: 0x04022ADB RID: 142043
		[Token(Token = "0x4022ADB")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, RoguelikeCommonOuterBuffLocationGroupViewModel> m_locationGroups;

		// Token: 0x04022ADC RID: 142044
		[Token(Token = "0x4022ADC")]
		[FieldOffset(Offset = "0x38")]
		private int m_activeDiffCount;

		// Token: 0x04022ADD RID: 142045
		[Token(Token = "0x4022ADD")]
		[FieldOffset(Offset = "0x3C")]
		private int m_tokenCount;

		// Token: 0x04022ADE RID: 142046
		[Token(Token = "0x4022ADE")]
		[FieldOffset(Offset = "0x40")]
		private int m_nodeCount;

		// Token: 0x04022ADF RID: 142047
		[Token(Token = "0x4022ADF")]
		[FieldOffset(Offset = "0x44")]
		private int m_activeNodeCount;

		// Token: 0x04022AE0 RID: 142048
		[Token(Token = "0x4022AE0")]
		[FieldOffset(Offset = "0x48")]
		public string selectedBuffId;

		// Token: 0x04022AE1 RID: 142049
		[Token(Token = "0x4022AE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04022AE2 RID: 142050
		[Token(Token = "0x4022AE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_tokenId;

		// Token: 0x04022AE3 RID: 142051
		[Token(Token = "0x4022AE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_tokenName;

		// Token: 0x04022AE4 RID: 142052
		[Token(Token = "0x4022AE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nodes;

		// Token: 0x04022AE5 RID: 142053
		[Token(Token = "0x4022AE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_locationGroups;

		// Token: 0x04022AE6 RID: 142054
		[Token(Token = "0x4022AE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_activeDiffCount;

		// Token: 0x04022AE7 RID: 142055
		[Token(Token = "0x4022AE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_tokenCount;

		// Token: 0x04022AE8 RID: 142056
		[Token(Token = "0x4022AE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_nodeCount;

		// Token: 0x04022AE9 RID: 142057
		[Token(Token = "0x4022AE9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_activeNodeCount;

		// Token: 0x04022AEA RID: 142058
		[Token(Token = "0x4022AEA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022AEB RID: 142059
		[Token(Token = "0x4022AEB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateNodesStatus;

		// Token: 0x04022AEC RID: 142060
		[Token(Token = "0x4022AEC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateNodeStatus;

		// Token: 0x04022AED RID: 142061
		[Token(Token = "0x4022AED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadNodes;

		// Token: 0x04022AEE RID: 142062
		[Token(Token = "0x4022AEE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateNode;

		// Token: 0x04022AEF RID: 142063
		[Token(Token = "0x4022AEF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateDiffNode;

		// Token: 0x04022AF0 RID: 142064
		[Token(Token = "0x4022AF0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateCount;

		// Token: 0x04022AF1 RID: 142065
		[Token(Token = "0x4022AF1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
