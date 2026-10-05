using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DD1 RID: 24017
	[Token(Token = "0x2005DD1")]
	public class ClimbTowerLevelModel : IHotfixable
	{
		// Token: 0x06022CB2 RID: 142514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CB2")]
		[Address(RVA = "0x1D56810", Offset = "0x1D55410", VA = "0x181D56810")]
		public void LoadData(string level, bool isHardMode = false)
		{
		}

		// Token: 0x06022CB3 RID: 142515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CB3")]
		[Address(RVA = "0x1D56A30", Offset = "0x1D55630", VA = "0x181D56A30")]
		private void _LoadRewardData(ClimbTowerSingleLevelData levelData)
		{
		}

		// Token: 0x06022CB4 RID: 142516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CB4")]
		[Address(RVA = "0x1D56FF0", Offset = "0x1D55BF0", VA = "0x181D56FF0")]
		public ClimbTowerLevelModel()
		{
		}

		// Token: 0x0402FDCC RID: 196044
		[Token(Token = "0x402FDCC")]
		[FieldOffset(Offset = "0x10")]
		public string levelId;

		// Token: 0x0402FDCD RID: 196045
		[Token(Token = "0x402FDCD")]
		[FieldOffset(Offset = "0x18")]
		public string levelPath;

		// Token: 0x0402FDCE RID: 196046
		[Token(Token = "0x402FDCE")]
		[FieldOffset(Offset = "0x20")]
		public string levelName;

		// Token: 0x0402FDCF RID: 196047
		[Token(Token = "0x402FDCF")]
		[FieldOffset(Offset = "0x28")]
		public string levelCode;

		// Token: 0x0402FDD0 RID: 196048
		[Token(Token = "0x402FDD0")]
		[FieldOffset(Offset = "0x30")]
		public string levelDesc;

		// Token: 0x0402FDD1 RID: 196049
		[Token(Token = "0x402FDD1")]
		[FieldOffset(Offset = "0x38")]
		public int layerNum;

		// Token: 0x0402FDD2 RID: 196050
		[Token(Token = "0x402FDD2")]
		[FieldOffset(Offset = "0x3C")]
		public ClimbTowerLevelType levelType;

		// Token: 0x0402FDD3 RID: 196051
		[Token(Token = "0x402FDD3")]
		[FieldOffset(Offset = "0x40")]
		public string levelPreviewMapId;

		// Token: 0x0402FDD4 RID: 196052
		[Token(Token = "0x402FDD4")]
		[FieldOffset(Offset = "0x48")]
		public List<StageRewardViewModel> displayRewards;

		// Token: 0x0402FDD5 RID: 196053
		[Token(Token = "0x402FDD5")]
		[FieldOffset(Offset = "0x50")]
		public List<StageRewardDetailViewModel> displayDetailRewards;

		// Token: 0x0402FDD6 RID: 196054
		[Token(Token = "0x402FDD6")]
		[FieldOffset(Offset = "0x58")]
		public List<KeyValuePair<string, StageRewardDetailViewModel>> offerDisplayDetailRewards;

		// Token: 0x0402FDD7 RID: 196055
		[Token(Token = "0x402FDD7")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, ClimbTowerDropDisplayInfo> rewardInfos;

		// Token: 0x0402FDD8 RID: 196056
		[Token(Token = "0x402FDD8")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, ClimbTowerDropDisplayInfo> offerRewardInfos;

		// Token: 0x0402FDD9 RID: 196057
		[Token(Token = "0x402FDD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FDDA RID: 196058
		[Token(Token = "0x402FDDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadRewardData;

		// Token: 0x0402FDDB RID: 196059
		[Token(Token = "0x402FDDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
