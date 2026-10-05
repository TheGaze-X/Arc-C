using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045F4 RID: 17908
	[Token(Token = "0x20045F4")]
	public class Rl03OuterBuffViewModel : IHotfixable
	{
		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x0601B397 RID: 111511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040ED")]
		public string topicId
		{
			[Token(Token = "0x601B397")]
			[Address(RVA = "0x146DA90", Offset = "0x146C690", VA = "0x18146DA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x0601B398 RID: 111512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040EE")]
		public string tokenId
		{
			[Token(Token = "0x601B398")]
			[Address(RVA = "0x146D9D0", Offset = "0x146C5D0", VA = "0x18146D9D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x0601B399 RID: 111513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040EF")]
		public string tokenName
		{
			[Token(Token = "0x601B399")]
			[Address(RVA = "0x146DA30", Offset = "0x146C630", VA = "0x18146DA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x0601B39A RID: 111514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040F0")]
		public ListDict<string, Rl03OuterBuffNodeBaseViewModel> nodes
		{
			[Token(Token = "0x601B39A")]
			[Address(RVA = "0x146D910", Offset = "0x146C510", VA = "0x18146D910")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x0601B39B RID: 111515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170040F1")]
		public Dictionary<string, Rl03OuterBuffLocationGroupViewModel> locationGroups
		{
			[Token(Token = "0x601B39B")]
			[Address(RVA = "0x146D850", Offset = "0x146C450", VA = "0x18146D850")]
			get
			{
				return null;
			}
		}

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x0601B39C RID: 111516 RVA: 0x000A4B38 File Offset: 0x000A2D38
		[Token(Token = "0x170040F2")]
		public int activeDiffCount
		{
			[Token(Token = "0x601B39C")]
			[Address(RVA = "0x146D790", Offset = "0x146C390", VA = "0x18146D790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x0601B39D RID: 111517 RVA: 0x000A4B50 File Offset: 0x000A2D50
		[Token(Token = "0x170040F3")]
		public int tokenCount
		{
			[Token(Token = "0x601B39D")]
			[Address(RVA = "0x146D970", Offset = "0x146C570", VA = "0x18146D970")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x0601B39E RID: 111518 RVA: 0x000A4B68 File Offset: 0x000A2D68
		[Token(Token = "0x170040F4")]
		public int nodeCount
		{
			[Token(Token = "0x601B39E")]
			[Address(RVA = "0x146D8B0", Offset = "0x146C4B0", VA = "0x18146D8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x0601B39F RID: 111519 RVA: 0x000A4B80 File Offset: 0x000A2D80
		[Token(Token = "0x170040F5")]
		public int activeNodeCount
		{
			[Token(Token = "0x601B39F")]
			[Address(RVA = "0x146D7F0", Offset = "0x146C3F0", VA = "0x18146D7F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601B3A0 RID: 111520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3A0")]
		[Address(RVA = "0x146C600", Offset = "0x146B200", VA = "0x18146C600")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601B3A1 RID: 111521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3A1")]
		[Address(RVA = "0x146C940", Offset = "0x146B540", VA = "0x18146C940")]
		public void UpdateNodesStatus()
		{
		}

		// Token: 0x0601B3A2 RID: 111522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3A2")]
		[Address(RVA = "0x146C7D0", Offset = "0x146B3D0", VA = "0x18146C7D0")]
		public void UpdateNodeStatus(string nodeId)
		{
		}

		// Token: 0x0601B3A3 RID: 111523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3A3")]
		[Address(RVA = "0x146CB30", Offset = "0x146B730", VA = "0x18146CB30")]
		private void _LoadNodes(PlayerRoguelikeV2.OuterData.Buff playerOuterBuff, Dictionary<string, RL03Development> developments, Dictionary<string, RL03DevDifficultyNodeInfo> difficultyInfos)
		{
		}

		// Token: 0x0601B3A4 RID: 111524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3A4")]
		[Address(RVA = "0x146D4B0", Offset = "0x146C0B0", VA = "0x18146D4B0")]
		private void _UpdateNode(string nodeId, PlayerRoguelikeV2.OuterData.Buff playerOuterBuff)
		{
		}

		// Token: 0x0601B3A5 RID: 111525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3A5")]
		[Address(RVA = "0x146D300", Offset = "0x146BF00", VA = "0x18146D300")]
		private void _UpdateDiffNode(Rl03OuterBuffDifficultyNodeViewModel diffModel, Dictionary<string, int> playerNodeStatus)
		{
		}

		// Token: 0x0601B3A6 RID: 111526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3A6")]
		[Address(RVA = "0x146CFD0", Offset = "0x146BBD0", VA = "0x18146CFD0")]
		private void _UpdateCount(PlayerRoguelikeV2.OuterData.Buff playerOuterBuff)
		{
		}

		// Token: 0x0601B3A7 RID: 111527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B3A7")]
		[Address(RVA = "0x146D730", Offset = "0x146C330", VA = "0x18146D730")]
		public Rl03OuterBuffViewModel()
		{
		}

		// Token: 0x040231B5 RID: 143797
		[Token(Token = "0x40231B5")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x040231B6 RID: 143798
		[Token(Token = "0x40231B6")]
		[FieldOffset(Offset = "0x18")]
		private string m_tokenId;

		// Token: 0x040231B7 RID: 143799
		[Token(Token = "0x40231B7")]
		[FieldOffset(Offset = "0x20")]
		private string m_tokenName;

		// Token: 0x040231B8 RID: 143800
		[Token(Token = "0x40231B8")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, Rl03OuterBuffNodeBaseViewModel> m_nodes;

		// Token: 0x040231B9 RID: 143801
		[Token(Token = "0x40231B9")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, Rl03OuterBuffLocationGroupViewModel> m_locationGroups;

		// Token: 0x040231BA RID: 143802
		[Token(Token = "0x40231BA")]
		[FieldOffset(Offset = "0x38")]
		private int m_activeDiffCount;

		// Token: 0x040231BB RID: 143803
		[Token(Token = "0x40231BB")]
		[FieldOffset(Offset = "0x3C")]
		private int m_tokenCount;

		// Token: 0x040231BC RID: 143804
		[Token(Token = "0x40231BC")]
		[FieldOffset(Offset = "0x40")]
		private int m_nodeCount;

		// Token: 0x040231BD RID: 143805
		[Token(Token = "0x40231BD")]
		[FieldOffset(Offset = "0x44")]
		private int m_activeNodeCount;

		// Token: 0x040231BE RID: 143806
		[Token(Token = "0x40231BE")]
		[FieldOffset(Offset = "0x48")]
		public string selectedBuffId;

		// Token: 0x040231BF RID: 143807
		[Token(Token = "0x40231BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040231C0 RID: 143808
		[Token(Token = "0x40231C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_tokenId;

		// Token: 0x040231C1 RID: 143809
		[Token(Token = "0x40231C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_tokenName;

		// Token: 0x040231C2 RID: 143810
		[Token(Token = "0x40231C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nodes;

		// Token: 0x040231C3 RID: 143811
		[Token(Token = "0x40231C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_locationGroups;

		// Token: 0x040231C4 RID: 143812
		[Token(Token = "0x40231C4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_activeDiffCount;

		// Token: 0x040231C5 RID: 143813
		[Token(Token = "0x40231C5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_tokenCount;

		// Token: 0x040231C6 RID: 143814
		[Token(Token = "0x40231C6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_nodeCount;

		// Token: 0x040231C7 RID: 143815
		[Token(Token = "0x40231C7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_activeNodeCount;

		// Token: 0x040231C8 RID: 143816
		[Token(Token = "0x40231C8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040231C9 RID: 143817
		[Token(Token = "0x40231C9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateNodesStatus;

		// Token: 0x040231CA RID: 143818
		[Token(Token = "0x40231CA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateNodeStatus;

		// Token: 0x040231CB RID: 143819
		[Token(Token = "0x40231CB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadNodes;

		// Token: 0x040231CC RID: 143820
		[Token(Token = "0x40231CC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateNode;

		// Token: 0x040231CD RID: 143821
		[Token(Token = "0x40231CD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateDiffNode;

		// Token: 0x040231CE RID: 143822
		[Token(Token = "0x40231CE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateCount;

		// Token: 0x040231CF RID: 143823
		[Token(Token = "0x40231CF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
