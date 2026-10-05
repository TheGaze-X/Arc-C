using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200595B RID: 22875
	[Token(Token = "0x200595B")]
	public class CrisisV2MapNormalNodeModel : CrisisV2MapNodeModel
	{
		// Token: 0x17004E46 RID: 20038
		// (get) Token: 0x0602158B RID: 136587 RVA: 0x000B9910 File Offset: 0x000B7B10
		[Token(Token = "0x17004E46")]
		public bool isCompleted
		{
			[Token(Token = "0x602158B")]
			[Address(RVA = "0x1BB0880", Offset = "0x1BAF480", VA = "0x181BB0880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E47 RID: 20039
		// (get) Token: 0x0602158C RID: 136588 RVA: 0x000B9928 File Offset: 0x000B7B28
		[Token(Token = "0x17004E47")]
		public bool isUnknown
		{
			[Token(Token = "0x602158C")]
			[Address(RVA = "0x1BB08E0", Offset = "0x1BAF4E0", VA = "0x181BB08E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E48 RID: 20040
		// (get) Token: 0x0602158D RID: 136589 RVA: 0x000B9940 File Offset: 0x000B7B40
		[Token(Token = "0x17004E48")]
		public override CrisisV2MapNodeModel.Connectivity connectivity
		{
			[Token(Token = "0x602158D")]
			[Address(RVA = "0x1BB07B0", Offset = "0x1BAF3B0", VA = "0x181BB07B0", Slot = "5")]
			get
			{
				return CrisisV2MapNodeModel.Connectivity.CLOSE;
			}
		}

		// Token: 0x17004E49 RID: 20041
		// (get) Token: 0x0602158E RID: 136590 RVA: 0x000B9958 File Offset: 0x000B7B58
		[Token(Token = "0x17004E49")]
		public override bool canCoverRoad
		{
			[Token(Token = "0x602158E")]
			[Address(RVA = "0x1BB0750", Offset = "0x1BAF350", VA = "0x181BB0750", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E4A RID: 20042
		// (get) Token: 0x0602158F RID: 136591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E4A")]
		public string name
		{
			[Token(Token = "0x602158F")]
			[Address(RVA = "0x1BB0940", Offset = "0x1BAF540", VA = "0x181BB0940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E4B RID: 20043
		// (get) Token: 0x06021590 RID: 136592 RVA: 0x000B9970 File Offset: 0x000B7B70
		[Token(Token = "0x17004E4B")]
		public int score
		{
			[Token(Token = "0x6021590")]
			[Address(RVA = "0x1BB0AD0", Offset = "0x1BAF6D0", VA = "0x181BB0AD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E4C RID: 20044
		// (get) Token: 0x06021591 RID: 136593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E4C")]
		public string runeIconId
		{
			[Token(Token = "0x6021591")]
			[Address(RVA = "0x1BB0A60", Offset = "0x1BAF660", VA = "0x181BB0A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E4D RID: 20045
		// (get) Token: 0x06021592 RID: 136594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E4D")]
		public string runeDesc
		{
			[Token(Token = "0x6021592")]
			[Address(RVA = "0x1BB09D0", Offset = "0x1BAF5D0", VA = "0x181BB09D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E4E RID: 20046
		// (get) Token: 0x06021593 RID: 136595 RVA: 0x000B9988 File Offset: 0x000B7B88
		[Token(Token = "0x17004E4E")]
		public int dimension
		{
			[Token(Token = "0x6021593")]
			[Address(RVA = "0x1BB0810", Offset = "0x1BAF410", VA = "0x181BB0810")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021594 RID: 136596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021594")]
		[Address(RVA = "0x1BB0570", Offset = "0x1BAF170", VA = "0x181BB0570", Slot = "18")]
		public override void UpdatePlayerData(PlayerCrisisV2Season.BasicMapInfo playerMapInfo)
		{
		}

		// Token: 0x06021595 RID: 136597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021595")]
		[Address(RVA = "0x1BB03E0", Offset = "0x1BAEFE0", VA = "0x181BB03E0", Slot = "19")]
		protected override void OnLoadData()
		{
		}

		// Token: 0x06021596 RID: 136598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021596")]
		[Address(RVA = "0x1BB06B0", Offset = "0x1BAF2B0", VA = "0x181BB06B0")]
		public CrisisV2MapNormalNodeModel()
		{
		}

		// Token: 0x06021597 RID: 136599 RVA: 0x000B99A0 File Offset: 0x000B7BA0
		[Token(Token = "0x6021597")]
		[Address(RVA = "0x1BB0160", Offset = "0x1BAED60", VA = "0x181BB0160")]
		private CrisisV2MapNodeModel.Connectivity <>xLuaBaseProxy_get_connectivity()
		{
			return CrisisV2MapNodeModel.Connectivity.CLOSE;
		}

		// Token: 0x06021598 RID: 136600 RVA: 0x000B99B8 File Offset: 0x000B7BB8
		[Token(Token = "0x6021598")]
		[Address(RVA = "0x1BA4F80", Offset = "0x1BA3B80", VA = "0x181BA4F80")]
		private bool <>xLuaBaseProxy_get_canCoverRoad()
		{
			return default(bool);
		}

		// Token: 0x06021599 RID: 136601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021599")]
		[Address(RVA = "0x1BA4F20", Offset = "0x1BA3B20", VA = "0x181BA4F20")]
		private void <>xLuaBaseProxy_UpdatePlayerData(PlayerCrisisV2Season.BasicMapInfo P0)
		{
		}

		// Token: 0x0602159A RID: 136602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602159A")]
		[Address(RVA = "0x1BA4EC0", Offset = "0x1BA3AC0", VA = "0x181BA4EC0")]
		private void <>xLuaBaseProxy_OnLoadData()
		{
		}

		// Token: 0x0402D781 RID: 186241
		[Token(Token = "0x402D781")]
		[FieldOffset(Offset = "0x30")]
		private CrisisV2RuneData m_runeData;

		// Token: 0x0402D782 RID: 186242
		[Token(Token = "0x402D782")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isUnknown;

		// Token: 0x0402D783 RID: 186243
		[Token(Token = "0x402D783")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isLockableNode;

		// Token: 0x0402D784 RID: 186244
		[Token(Token = "0x402D784")]
		[FieldOffset(Offset = "0x40")]
		private string m_runeDesc;

		// Token: 0x0402D785 RID: 186245
		[Token(Token = "0x402D785")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isCompleted;

		// Token: 0x0402D786 RID: 186246
		[Token(Token = "0x402D786")]
		[FieldOffset(Offset = "0x4C")]
		private CrisisV2MapNodeModel.Connectivity m_connectivity;

		// Token: 0x0402D787 RID: 186247
		[Token(Token = "0x402D787")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCompleted;

		// Token: 0x0402D788 RID: 186248
		[Token(Token = "0x402D788")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isUnknown;

		// Token: 0x0402D789 RID: 186249
		[Token(Token = "0x402D789")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_connectivity;

		// Token: 0x0402D78A RID: 186250
		[Token(Token = "0x402D78A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_canCoverRoad;

		// Token: 0x0402D78B RID: 186251
		[Token(Token = "0x402D78B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402D78C RID: 186252
		[Token(Token = "0x402D78C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_score;

		// Token: 0x0402D78D RID: 186253
		[Token(Token = "0x402D78D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_runeIconId;

		// Token: 0x0402D78E RID: 186254
		[Token(Token = "0x402D78E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_runeDesc;

		// Token: 0x0402D78F RID: 186255
		[Token(Token = "0x402D78F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_dimension;

		// Token: 0x0402D790 RID: 186256
		[Token(Token = "0x402D790")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0402D791 RID: 186257
		[Token(Token = "0x402D791")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnLoadData;

		// Token: 0x0402D792 RID: 186258
		[Token(Token = "0x402D792")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
