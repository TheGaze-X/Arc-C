using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D18 RID: 23832
	[Token(Token = "0x2005D18")]
	public class ClimbTowerEndCharacterViewModel : IHotfixable
	{
		// Token: 0x0602282E RID: 141358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602282E")]
		[Address(RVA = "0x1CFDFA0", Offset = "0x1CFCBA0", VA = "0x181CFDFA0")]
		public void LoadCharacter(TowerCurrent.GameCard card)
		{
		}

		// Token: 0x0602282F RID: 141359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602282F")]
		[Address(RVA = "0x1CFDF20", Offset = "0x1CFCB20", VA = "0x181CFDF20")]
		public void LoadCharacter(CharacterCardViewModel charCardModel)
		{
		}

		// Token: 0x06022830 RID: 141360 RVA: 0x000BDAE0 File Offset: 0x000BBCE0
		[Token(Token = "0x6022830")]
		[Address(RVA = "0x1CFDDE0", Offset = "0x1CFC9E0", VA = "0x181CFDDE0")]
		public int CompareTo(ClimbTowerEndCharacterViewModel r)
		{
			return 0;
		}

		// Token: 0x06022831 RID: 141361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022831")]
		[Address(RVA = "0x1CFE0A0", Offset = "0x1CFCCA0", VA = "0x181CFE0A0")]
		public ClimbTowerEndCharacterViewModel()
		{
		}

		// Token: 0x0402F6DF RID: 194271
		[Token(Token = "0x402F6DF")]
		[FieldOffset(Offset = "0x10")]
		public CharacterCardViewModel cardModel;

		// Token: 0x0402F6E0 RID: 194272
		[Token(Token = "0x402F6E0")]
		[FieldOffset(Offset = "0x18")]
		public bool isNpc;

		// Token: 0x0402F6E1 RID: 194273
		[Token(Token = "0x402F6E1")]
		[FieldOffset(Offset = "0x19")]
		public bool isAssist;

		// Token: 0x0402F6E2 RID: 194274
		[Token(Token = "0x402F6E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadCharacter;

		// Token: 0x0402F6E3 RID: 194275
		[Token(Token = "0x402F6E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_LoadCharacter;

		// Token: 0x0402F6E4 RID: 194276
		[Token(Token = "0x402F6E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402F6E5 RID: 194277
		[Token(Token = "0x402F6E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
