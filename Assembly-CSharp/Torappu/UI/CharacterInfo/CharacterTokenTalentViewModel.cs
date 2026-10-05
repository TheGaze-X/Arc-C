using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F0C RID: 24332
	[Token(Token = "0x2005F0C")]
	public class CharacterTokenTalentViewModel : IHotfixable
	{
		// Token: 0x0602340A RID: 144394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602340A")]
		[Address(RVA = "0x1DCDBC0", Offset = "0x1DCC7C0", VA = "0x181DCDBC0")]
		public CharacterTokenTalentViewModel()
		{
		}

		// Token: 0x0403093E RID: 198974
		[Token(Token = "0x403093E")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0403093F RID: 198975
		[Token(Token = "0x403093F")]
		[FieldOffset(Offset = "0x18")]
		public string rawContent;

		// Token: 0x04030940 RID: 198976
		[Token(Token = "0x4030940")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
