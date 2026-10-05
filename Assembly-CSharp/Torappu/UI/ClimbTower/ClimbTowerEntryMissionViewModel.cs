using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DBE RID: 23998
	[Token(Token = "0x2005DBE")]
	public class ClimbTowerEntryMissionViewModel : IHotfixable
	{
		// Token: 0x06022C7E RID: 142462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C7E")]
		[Address(RVA = "0x1D54A70", Offset = "0x1D53670", VA = "0x181D54A70")]
		public void LoadData()
		{
		}

		// Token: 0x06022C7F RID: 142463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C7F")]
		[Address(RVA = "0x1D54E40", Offset = "0x1D53A40", VA = "0x181D54E40")]
		public ClimbTowerEntryMissionViewModel()
		{
		}

		// Token: 0x0402FD54 RID: 195924
		[Token(Token = "0x402FD54")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x0402FD55 RID: 195925
		[Token(Token = "0x402FD55")]
		[FieldOffset(Offset = "0x18")]
		public List<ClimbTowerEntryMissionItemViewModel> itemModelList;

		// Token: 0x0402FD56 RID: 195926
		[Token(Token = "0x402FD56")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ClimbTowerEntryMissionItemViewModel> itemModelMap;

		// Token: 0x0402FD57 RID: 195927
		[Token(Token = "0x402FD57")]
		[FieldOffset(Offset = "0x28")]
		public int missionReceived;

		// Token: 0x0402FD58 RID: 195928
		[Token(Token = "0x402FD58")]
		[FieldOffset(Offset = "0x2C")]
		public int missionCount;

		// Token: 0x0402FD59 RID: 195929
		[Token(Token = "0x402FD59")]
		[FieldOffset(Offset = "0x30")]
		public int seasonOrderNum;

		// Token: 0x0402FD5A RID: 195930
		[Token(Token = "0x402FD5A")]
		[FieldOffset(Offset = "0x38")]
		public string seasonName;

		// Token: 0x0402FD5B RID: 195931
		[Token(Token = "0x402FD5B")]
		[FieldOffset(Offset = "0x40")]
		public int periodCurr;

		// Token: 0x0402FD5C RID: 195932
		[Token(Token = "0x402FD5C")]
		[FieldOffset(Offset = "0x44")]
		public int periodCount;

		// Token: 0x0402FD5D RID: 195933
		[Token(Token = "0x402FD5D")]
		[FieldOffset(Offset = "0x48")]
		public long endTs;

		// Token: 0x0402FD5E RID: 195934
		[Token(Token = "0x402FD5E")]
		[FieldOffset(Offset = "0x50")]
		public string remainTimeDesc;

		// Token: 0x0402FD5F RID: 195935
		[Token(Token = "0x402FD5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FD60 RID: 195936
		[Token(Token = "0x402FD60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
