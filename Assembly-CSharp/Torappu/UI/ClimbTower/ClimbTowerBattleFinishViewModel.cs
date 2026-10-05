using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DAF RID: 23983
	[Token(Token = "0x2005DAF")]
	public class ClimbTowerBattleFinishViewModel : IHotfixable
	{
		// Token: 0x1700522F RID: 21039
		// (get) Token: 0x06022C5C RID: 142428 RVA: 0x000BEC20 File Offset: 0x000BCE20
		[Token(Token = "0x1700522F")]
		public int UnitCount
		{
			[Token(Token = "0x6022C5C")]
			[Address(RVA = "0x1D50400", Offset = "0x1D4F000", VA = "0x181D50400")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06022C5D RID: 142429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C5D")]
		[Address(RVA = "0x1D4FBF0", Offset = "0x1D4E7F0", VA = "0x181D4FBF0")]
		public void LoadData(ClimbTowerBattleFinishViewModel.Param param)
		{
		}

		// Token: 0x06022C5E RID: 142430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C5E")]
		[Address(RVA = "0x1D50070", Offset = "0x1D4EC70", VA = "0x181D50070")]
		private void _LoadDropItemData(ClimbTowerBattleFinishResponse response)
		{
		}

		// Token: 0x06022C5F RID: 142431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C5F")]
		[Address(RVA = "0x1D50340", Offset = "0x1D4EF40", VA = "0x181D50340")]
		public ClimbTowerBattleFinishViewModel()
		{
		}

		// Token: 0x0402FCE6 RID: 195814
		[Token(Token = "0x402FCE6")]
		[FieldOffset(Offset = "0x10")]
		public BattleStageInfo stageInfo;

		// Token: 0x0402FCE7 RID: 195815
		[Token(Token = "0x402FCE7")]
		[FieldOffset(Offset = "0x80")]
		public string illustInstId;

		// Token: 0x0402FCE8 RID: 195816
		[Token(Token = "0x402FCE8")]
		[FieldOffset(Offset = "0x88")]
		public string towerId;

		// Token: 0x0402FCE9 RID: 195817
		[Token(Token = "0x402FCE9")]
		[FieldOffset(Offset = "0x90")]
		public bool isHardMode;

		// Token: 0x0402FCEA RID: 195818
		[Token(Token = "0x402FCEA")]
		[FieldOffset(Offset = "0x98")]
		public string towerName;

		// Token: 0x0402FCEB RID: 195819
		[Token(Token = "0x402FCEB")]
		[FieldOffset(Offset = "0xA0")]
		public string towerSubName;

		// Token: 0x0402FCEC RID: 195820
		[Token(Token = "0x402FCEC")]
		[FieldOffset(Offset = "0xA8")]
		public int totalLayerCount;

		// Token: 0x0402FCED RID: 195821
		[Token(Token = "0x402FCED")]
		[FieldOffset(Offset = "0xAC")]
		public int currentLayoutCount;

		// Token: 0x0402FCEE RID: 195822
		[Token(Token = "0x402FCEE")]
		[FieldOffset(Offset = "0xB0")]
		public bool isNewRecord;

		// Token: 0x0402FCEF RID: 195823
		[Token(Token = "0x402FCEF")]
		[FieldOffset(Offset = "0xB8")]
		public List<string> gainUnitIds;

		// Token: 0x0402FCF0 RID: 195824
		[Token(Token = "0x402FCF0")]
		[FieldOffset(Offset = "0xC0")]
		public bool isHardStage;

		// Token: 0x0402FCF1 RID: 195825
		[Token(Token = "0x402FCF1")]
		[FieldOffset(Offset = "0xC8")]
		public string lowerItemName;

		// Token: 0x0402FCF2 RID: 195826
		[Token(Token = "0x402FCF2")]
		[FieldOffset(Offset = "0xD0")]
		public string higherItemName;

		// Token: 0x0402FCF3 RID: 195827
		[Token(Token = "0x402FCF3")]
		[FieldOffset(Offset = "0xD8")]
		public Sprite lowerItemIcon;

		// Token: 0x0402FCF4 RID: 195828
		[Token(Token = "0x402FCF4")]
		[FieldOffset(Offset = "0xE0")]
		public Sprite higherItemIcon;

		// Token: 0x0402FCF5 RID: 195829
		[Token(Token = "0x402FCF5")]
		[FieldOffset(Offset = "0xE8")]
		public int lowerItemStartFee;

		// Token: 0x0402FCF6 RID: 195830
		[Token(Token = "0x402FCF6")]
		[FieldOffset(Offset = "0xEC")]
		public int lowerItemEndFee;

		// Token: 0x0402FCF7 RID: 195831
		[Token(Token = "0x402FCF7")]
		[FieldOffset(Offset = "0xF0")]
		public int lowerItemTotalFee;

		// Token: 0x0402FCF8 RID: 195832
		[Token(Token = "0x402FCF8")]
		[FieldOffset(Offset = "0xF4")]
		public int lowerItemGain;

		// Token: 0x0402FCF9 RID: 195833
		[Token(Token = "0x402FCF9")]
		[FieldOffset(Offset = "0xF8")]
		public int higherItemStartFee;

		// Token: 0x0402FCFA RID: 195834
		[Token(Token = "0x402FCFA")]
		[FieldOffset(Offset = "0xFC")]
		public int higherItemEndFee;

		// Token: 0x0402FCFB RID: 195835
		[Token(Token = "0x402FCFB")]
		[FieldOffset(Offset = "0x100")]
		public int higherItemGain;

		// Token: 0x0402FCFC RID: 195836
		[Token(Token = "0x402FCFC")]
		[FieldOffset(Offset = "0x104")]
		public int higherItemTotalFee;

		// Token: 0x0402FCFD RID: 195837
		[Token(Token = "0x402FCFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_UnitCount;

		// Token: 0x0402FCFE RID: 195838
		[Token(Token = "0x402FCFE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FCFF RID: 195839
		[Token(Token = "0x402FCFF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadDropItemData;

		// Token: 0x0402FD00 RID: 195840
		[Token(Token = "0x402FD00")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DB0 RID: 23984
		[Token(Token = "0x2005DB0")]
		public struct Param
		{
			// Token: 0x0402FD01 RID: 195841
			[Token(Token = "0x402FD01")]
			[FieldOffset(Offset = "0x0")]
			public BattleStageInfo stageInfo;

			// Token: 0x0402FD02 RID: 195842
			[Token(Token = "0x402FD02")]
			[FieldOffset(Offset = "0x70")]
			public string towerId;

			// Token: 0x0402FD03 RID: 195843
			[Token(Token = "0x402FD03")]
			[FieldOffset(Offset = "0x78")]
			public int coord;

			// Token: 0x0402FD04 RID: 195844
			[Token(Token = "0x402FD04")]
			[FieldOffset(Offset = "0x80")]
			public CommonFinishBattleResponse battleResponse;
		}
	}
}
