using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DE5 RID: 24037
	[Token(Token = "0x2005DE5")]
	public class CharacterShowMasterModel : IHotfixable, IComparable<CharacterShowMasterModel>
	{
		// Token: 0x06022D5D RID: 142685 RVA: 0x000BF2C8 File Offset: 0x000BD4C8
		[Token(Token = "0x6022D5D")]
		[Address(RVA = "0x1D6DA60", Offset = "0x1D6C660", VA = "0x181D6DA60", Slot = "4")]
		public int CompareTo(CharacterShowMasterModel other)
		{
			return 0;
		}

		// Token: 0x06022D5E RID: 142686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D5E")]
		[Address(RVA = "0x1D6DAE0", Offset = "0x1D6C6E0", VA = "0x181D6DAE0")]
		public CharacterShowMasterModel()
		{
		}

		// Token: 0x0402FF28 RID: 196392
		[Token(Token = "0x402FF28")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0402FF29 RID: 196393
		[Token(Token = "0x402FF29")]
		[FieldOffset(Offset = "0x18")]
		public string rawDesc;

		// Token: 0x0402FF2A RID: 196394
		[Token(Token = "0x402FF2A")]
		[FieldOffset(Offset = "0x20")]
		public EvolvePhase initUnlockEvolvePhase;

		// Token: 0x0402FF2B RID: 196395
		[Token(Token = "0x402FF2B")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;

		// Token: 0x0402FF2C RID: 196396
		[Token(Token = "0x402FF2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402FF2D RID: 196397
		[Token(Token = "0x402FF2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
