using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200594F RID: 22863
	[Token(Token = "0x200594F")]
	public class CrisisV2AchievementViewModel : IHotfixable
	{
		// Token: 0x17004E19 RID: 19993
		// (get) Token: 0x0602152C RID: 136492 RVA: 0x000B9520 File Offset: 0x000B7720
		[Token(Token = "0x17004E19")]
		public bool showSwitchBtn
		{
			[Token(Token = "0x602152C")]
			[Address(RVA = "0x1BA25A0", Offset = "0x1BA11A0", VA = "0x181BA25A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E1A RID: 19994
		// (get) Token: 0x0602152D RID: 136493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E1A")]
		public CrisisV2AchievementSeasonViewModel currentSeasonModel
		{
			[Token(Token = "0x602152D")]
			[Address(RVA = "0x1BA2530", Offset = "0x1BA1130", VA = "0x181BA2530")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602152E RID: 136494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602152E")]
		[Address(RVA = "0x1BA1650", Offset = "0x1BA0250", VA = "0x181BA1650")]
		public void LoadData()
		{
		}

		// Token: 0x0602152F RID: 136495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602152F")]
		[Address(RVA = "0x1BA23F0", Offset = "0x1BA0FF0", VA = "0x181BA23F0")]
		public void SetSelectIndex(int index = -1)
		{
		}

		// Token: 0x06021530 RID: 136496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021530")]
		[Address(RVA = "0x1BA2480", Offset = "0x1BA1080", VA = "0x181BA2480")]
		public CrisisV2AchievementViewModel()
		{
		}

		// Token: 0x0402D70E RID: 186126
		[Token(Token = "0x402D70E")]
		[FieldOffset(Offset = "0x10")]
		public int seasonCount;

		// Token: 0x0402D70F RID: 186127
		[Token(Token = "0x402D70F")]
		[FieldOffset(Offset = "0x14")]
		public int selectIndex;

		// Token: 0x0402D710 RID: 186128
		[Token(Token = "0x402D710")]
		[FieldOffset(Offset = "0x18")]
		public List<CrisisV2AchievementSeasonViewModel> seasonList;

		// Token: 0x0402D711 RID: 186129
		[Token(Token = "0x402D711")]
		[FieldOffset(Offset = "0x20")]
		public bool isFastMode;

		// Token: 0x0402D712 RID: 186130
		[Token(Token = "0x402D712")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showSwitchBtn;

		// Token: 0x0402D713 RID: 186131
		[Token(Token = "0x402D713")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentSeasonModel;

		// Token: 0x0402D714 RID: 186132
		[Token(Token = "0x402D714")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D715 RID: 186133
		[Token(Token = "0x402D715")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelectIndex;

		// Token: 0x0402D716 RID: 186134
		[Token(Token = "0x402D716")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
