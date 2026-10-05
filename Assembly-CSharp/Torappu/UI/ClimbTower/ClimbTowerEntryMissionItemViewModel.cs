using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DBF RID: 23999
	[Token(Token = "0x2005DBF")]
	public class ClimbTowerEntryMissionItemViewModel : IHotfixable, IComparable
	{
		// Token: 0x17005230 RID: 21040
		// (get) Token: 0x06022C80 RID: 142464 RVA: 0x000BECB0 File Offset: 0x000BCEB0
		[Token(Token = "0x17005230")]
		public bool needReceive
		{
			[Token(Token = "0x6022C80")]
			[Address(RVA = "0x1D549A0", Offset = "0x1D535A0", VA = "0x181D549A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022C81 RID: 142465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022C81")]
		[Address(RVA = "0x1D544F0", Offset = "0x1D530F0", VA = "0x181D544F0")]
		public static ClimbTowerEntryMissionItemViewModel LoadData(string missionId, ClimbTowerSeasonInfoData seasonInfoData)
		{
			return null;
		}

		// Token: 0x06022C82 RID: 142466 RVA: 0x000BECC8 File Offset: 0x000BCEC8
		[Token(Token = "0x6022C82")]
		[Address(RVA = "0x1D54360", Offset = "0x1D52F60", VA = "0x181D54360", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06022C83 RID: 142467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C83")]
		[Address(RVA = "0x1D54940", Offset = "0x1D53540", VA = "0x181D54940")]
		public ClimbTowerEntryMissionItemViewModel()
		{
		}

		// Token: 0x0402FD61 RID: 195937
		[Token(Token = "0x402FD61")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0402FD62 RID: 195938
		[Token(Token = "0x402FD62")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x0402FD63 RID: 195939
		[Token(Token = "0x402FD63")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0402FD64 RID: 195940
		[Token(Token = "0x402FD64")]
		[FieldOffset(Offset = "0x28")]
		public string seasonName;

		// Token: 0x0402FD65 RID: 195941
		[Token(Token = "0x402FD65")]
		[FieldOffset(Offset = "0x30")]
		public int seasonNum;

		// Token: 0x0402FD66 RID: 195942
		[Token(Token = "0x402FD66")]
		[FieldOffset(Offset = "0x34")]
		public int progressCurr;

		// Token: 0x0402FD67 RID: 195943
		[Token(Token = "0x402FD67")]
		[FieldOffset(Offset = "0x38")]
		public int progressTarget;

		// Token: 0x0402FD68 RID: 195944
		[Token(Token = "0x402FD68")]
		[FieldOffset(Offset = "0x3C")]
		public float progress;

		// Token: 0x0402FD69 RID: 195945
		[Token(Token = "0x402FD69")]
		[FieldOffset(Offset = "0x40")]
		public string bindTowerId;

		// Token: 0x0402FD6A RID: 195946
		[Token(Token = "0x402FD6A")]
		[FieldOffset(Offset = "0x48")]
		public string bindGodCardId;

		// Token: 0x0402FD6B RID: 195947
		[Token(Token = "0x402FD6B")]
		[FieldOffset(Offset = "0x50")]
		public List<UIItemViewModel> rewards;

		// Token: 0x0402FD6C RID: 195948
		[Token(Token = "0x402FD6C")]
		[FieldOffset(Offset = "0x58")]
		public bool isReceived;

		// Token: 0x0402FD6D RID: 195949
		[Token(Token = "0x402FD6D")]
		[FieldOffset(Offset = "0x59")]
		public bool isComplete;

		// Token: 0x0402FD6E RID: 195950
		[Token(Token = "0x402FD6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needReceive;

		// Token: 0x0402FD6F RID: 195951
		[Token(Token = "0x402FD6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FD70 RID: 195952
		[Token(Token = "0x402FD70")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402FD71 RID: 195953
		[Token(Token = "0x402FD71")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
