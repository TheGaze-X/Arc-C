using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F0A RID: 24330
	[Token(Token = "0x2005F0A")]
	public class CharacterLvlupMaxStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023400 RID: 144384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023400")]
		[Address(RVA = "0x1DC79C0", Offset = "0x1DC65C0", VA = "0x181DC79C0")]
		public CharacterLvlupMaxStateBean()
		{
		}

		// Token: 0x04030927 RID: 198951
		[Token(Token = "0x4030927")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04030928 RID: 198952
		[Token(Token = "0x4030928")]
		[FieldOffset(Offset = "0x14")]
		public int originLevel;

		// Token: 0x04030929 RID: 198953
		[Token(Token = "0x4030929")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
