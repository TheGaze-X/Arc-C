using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005145 RID: 20805
	[Token(Token = "0x2005145")]
	public class DeepSeaRPBattleNodeModel : DeepSeaRPNodeModel
	{
		// Token: 0x0601EBF5 RID: 125941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBF5")]
		[Address(RVA = "0x1866520", Offset = "0x1865120", VA = "0x181866520", Slot = "5")]
		public override void InitData(string nodeId_, Act17sideData.NodeInfoData infoData_, Act17sideData actData)
		{
		}

		// Token: 0x170047AF RID: 18351
		// (get) Token: 0x0601EBF6 RID: 125942 RVA: 0x000AF890 File Offset: 0x000ADA90
		[Token(Token = "0x170047AF")]
		public int stageRank
		{
			[Token(Token = "0x601EBF6")]
			[Address(RVA = "0x1866D00", Offset = "0x1865900", VA = "0x181866D00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601EBF7 RID: 125943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBF7")]
		[Address(RVA = "0x1866850", Offset = "0x1865450", VA = "0x181866850")]
		private void _LoadRankNum()
		{
		}

		// Token: 0x0601EBF8 RID: 125944 RVA: 0x000AF8A8 File Offset: 0x000ADAA8
		[Token(Token = "0x601EBF8")]
		[Address(RVA = "0x1866710", Offset = "0x1865310", VA = "0x181866710", Slot = "19")]
		public override bool IsNodeComplete()
		{
			return default(bool);
		}

		// Token: 0x0601EBF9 RID: 125945 RVA: 0x000AF8C0 File Offset: 0x000ADAC0
		[Token(Token = "0x601EBF9")]
		[Address(RVA = "0x1866460", Offset = "0x1865060", VA = "0x181866460", Slot = "8")]
		public override bool HasTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x0601EBFA RID: 125946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBFA")]
		[Address(RVA = "0x1866930", Offset = "0x1865530", VA = "0x181866930")]
		private static void _LoadStageViewModel(string stageId, StageViewModel stageViewModel)
		{
		}

		// Token: 0x0601EBFB RID: 125947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBFB")]
		[Address(RVA = "0x1866BE0", Offset = "0x18657E0", VA = "0x181866BE0")]
		public DeepSeaRPBattleNodeModel()
		{
		}

		// Token: 0x0601EBFC RID: 125948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBFC")]
		[Address(RVA = "0x18667E0", Offset = "0x18653E0", VA = "0x1818667E0")]
		private void <>xLuaBaseProxy_InitData(string P0, Act17sideData.NodeInfoData P1, Act17sideData P2)
		{
		}

		// Token: 0x0601EBFD RID: 125949 RVA: 0x000AF8D8 File Offset: 0x000ADAD8
		[Token(Token = "0x601EBFD")]
		[Address(RVA = "0x18667F0", Offset = "0x18653F0", VA = "0x1818667F0")]
		private bool <>xLuaBaseProxy_IsNodeComplete()
		{
			return default(bool);
		}

		// Token: 0x0601EBFE RID: 125950 RVA: 0x000AF8F0 File Offset: 0x000ADAF0
		[Token(Token = "0x601EBFE")]
		[Address(RVA = "0x1866780", Offset = "0x1865380", VA = "0x181866780")]
		private bool <>xLuaBaseProxy_HasTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x040293CA RID: 168906
		[Token(Token = "0x40293CA")]
		[FieldOffset(Offset = "0x30")]
		public Act17sideData.BattleNodeData battleData;

		// Token: 0x040293CB RID: 168907
		[Token(Token = "0x40293CB")]
		[FieldOffset(Offset = "0x38")]
		public StageViewModel normalStage;

		// Token: 0x040293CC RID: 168908
		[Token(Token = "0x40293CC")]
		[FieldOffset(Offset = "0x40")]
		public StageViewModel hardStage;

		// Token: 0x040293CD RID: 168909
		[Token(Token = "0x40293CD")]
		[FieldOffset(Offset = "0x48")]
		private int m_rankNum;

		// Token: 0x040293CE RID: 168910
		[Token(Token = "0x40293CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040293CF RID: 168911
		[Token(Token = "0x40293CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stageRank;

		// Token: 0x040293D0 RID: 168912
		[Token(Token = "0x40293D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadRankNum;

		// Token: 0x040293D1 RID: 168913
		[Token(Token = "0x40293D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsNodeComplete;

		// Token: 0x040293D2 RID: 168914
		[Token(Token = "0x40293D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HasTrackPoint;

		// Token: 0x040293D3 RID: 168915
		[Token(Token = "0x40293D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadStageViewModel;

		// Token: 0x040293D4 RID: 168916
		[Token(Token = "0x40293D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
