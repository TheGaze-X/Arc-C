using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200351F RID: 13599
	[Token(Token = "0x200351F")]
	public class ProfessionFilterProfItemViewModel : IHotfixable
	{
		// Token: 0x06015ADC RID: 88796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ADC")]
		[Address(RVA = "0xE396C0", Offset = "0xE382C0", VA = "0x180E396C0")]
		public ProfessionFilterProfItemViewModel()
		{
		}

		// Token: 0x0401A06A RID: 106602
		[Token(Token = "0x401A06A")]
		[FieldOffset(Offset = "0x10")]
		public ProfessionCategory profession;

		// Token: 0x0401A06B RID: 106603
		[Token(Token = "0x401A06B")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0401A06C RID: 106604
		[Token(Token = "0x401A06C")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, ProfessionFilterSubProfItemViewModel> subProfItems;

		// Token: 0x0401A06D RID: 106605
		[Token(Token = "0x401A06D")]
		[FieldOffset(Offset = "0x28")]
		public bool isBanned;

		// Token: 0x0401A06E RID: 106606
		[Token(Token = "0x401A06E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
