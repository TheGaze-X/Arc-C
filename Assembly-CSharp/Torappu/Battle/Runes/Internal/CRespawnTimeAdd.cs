using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028EE RID: 10478
	[Token(Token = "0x20028EE")]
	public class CRespawnTimeAdd : BasicCharacterRune
	{
		// Token: 0x0601168B RID: 71307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601168B")]
		[Address(RVA = "0x939380", Offset = "0x937F80", VA = "0x180939380", Slot = "17")]
		protected override void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x0601168C RID: 71308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601168C")]
		[Address(RVA = "0x9394F0", Offset = "0x9380F0", VA = "0x1809394F0")]
		public CRespawnTimeAdd()
		{
		}

		// Token: 0x0401373C RID: 79676
		[Token(Token = "0x401373C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessChar;

		// Token: 0x0401373D RID: 79677
		[Token(Token = "0x401373D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
