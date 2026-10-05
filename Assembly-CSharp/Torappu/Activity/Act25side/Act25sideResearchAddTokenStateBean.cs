using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007506 RID: 29958
	[Token(Token = "0x2007506")]
	public class Act25sideResearchAddTokenStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602A3AC RID: 172972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3AC")]
		[Address(RVA = "0x25E0040", Offset = "0x25DEC40", VA = "0x1825E0040")]
		public Act25sideResearchAddTokenStateBean()
		{
		}

		// Token: 0x0403CAE9 RID: 248553
		[Token(Token = "0x403CAE9")]
		[FieldOffset(Offset = "0x10")]
		public int initCount;

		// Token: 0x0403CAEA RID: 248554
		[Token(Token = "0x403CAEA")]
		[FieldOffset(Offset = "0x14")]
		public int addCount;

		// Token: 0x0403CAEB RID: 248555
		[Token(Token = "0x403CAEB")]
		[FieldOffset(Offset = "0x18")]
		public int maxCount;

		// Token: 0x0403CAEC RID: 248556
		[Token(Token = "0x403CAEC")]
		[FieldOffset(Offset = "0x1C")]
		public bool showMaxOnly;

		// Token: 0x0403CAED RID: 248557
		[Token(Token = "0x403CAED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
