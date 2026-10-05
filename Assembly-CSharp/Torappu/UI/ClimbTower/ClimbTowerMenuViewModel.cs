using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DCC RID: 24012
	[Token(Token = "0x2005DCC")]
	public class ClimbTowerMenuViewModel : IHotfixable
	{
		// Token: 0x06022CA9 RID: 142505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CA9")]
		[Address(RVA = "0x1D577F0", Offset = "0x1D563F0", VA = "0x181D577F0")]
		public void LoadData(bool isTutorial, List<CharacterCardViewModel> predefinedCharList)
		{
		}

		// Token: 0x06022CAA RID: 142506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CAA")]
		[Address(RVA = "0x1D57E10", Offset = "0x1D56A10", VA = "0x181D57E10")]
		public ClimbTowerMenuViewModel()
		{
		}

		// Token: 0x0402FDB2 RID: 196018
		[Token(Token = "0x402FDB2")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerInnerBuffListModel buffList;

		// Token: 0x0402FDB3 RID: 196019
		[Token(Token = "0x402FDB3")]
		[FieldOffset(Offset = "0x18")]
		public int squadCount;

		// Token: 0x0402FDB4 RID: 196020
		[Token(Token = "0x402FDB4")]
		[FieldOffset(Offset = "0x1C")]
		public int trapCount;

		// Token: 0x0402FDB5 RID: 196021
		[Token(Token = "0x402FDB5")]
		[FieldOffset(Offset = "0x20")]
		public bool isHardMode;

		// Token: 0x0402FDB6 RID: 196022
		[Token(Token = "0x402FDB6")]
		[FieldOffset(Offset = "0x28")]
		public string curGodCardId;

		// Token: 0x0402FDB7 RID: 196023
		[Token(Token = "0x402FDB7")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<ProfessionCategory, int> squadProfessionCount;

		// Token: 0x0402FDB8 RID: 196024
		[Token(Token = "0x402FDB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FDB9 RID: 196025
		[Token(Token = "0x402FDB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
