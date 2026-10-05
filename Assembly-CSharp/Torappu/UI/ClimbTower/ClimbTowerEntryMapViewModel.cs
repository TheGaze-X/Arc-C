using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DBB RID: 23995
	[Token(Token = "0x2005DBB")]
	public class ClimbTowerEntryMapViewModel : IHotfixable
	{
		// Token: 0x06022C77 RID: 142455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C77")]
		[Address(RVA = "0x1D538F0", Offset = "0x1D524F0", VA = "0x181D538F0")]
		public void LoadData()
		{
		}

		// Token: 0x06022C78 RID: 142456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022C78")]
		[Address(RVA = "0x1D537E0", Offset = "0x1D523E0", VA = "0x181D537E0")]
		public ClimbTowerEntryMapTowerModel GetTowerModel(string towerId)
		{
			return null;
		}

		// Token: 0x06022C79 RID: 142457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C79")]
		[Address(RVA = "0x1D542B0", Offset = "0x1D52EB0", VA = "0x181D542B0")]
		public ClimbTowerEntryMapViewModel()
		{
		}

		// Token: 0x0402FD4D RID: 195917
		[Token(Token = "0x402FD4D")]
		[FieldOffset(Offset = "0x10")]
		public List<ClimbTowerEntryMapTowerModel> towerList;

		// Token: 0x0402FD4E RID: 195918
		[Token(Token = "0x402FD4E")]
		[FieldOffset(Offset = "0x18")]
		public bool isTrainComplete;

		// Token: 0x0402FD4F RID: 195919
		[Token(Token = "0x402FD4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FD50 RID: 195920
		[Token(Token = "0x402FD50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTowerModel;

		// Token: 0x0402FD51 RID: 195921
		[Token(Token = "0x402FD51")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
