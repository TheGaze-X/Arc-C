using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003520 RID: 13600
	[Token(Token = "0x2003520")]
	public class ProfessionFilterSubProfItemViewModel : IHotfixable
	{
		// Token: 0x06015ADD RID: 88797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015ADD")]
		[Address(RVA = "0xE39770", Offset = "0xE38370", VA = "0x180E39770")]
		public ProfessionFilterSubProfItemViewModel()
		{
		}

		// Token: 0x0401A06F RID: 106607
		[Token(Token = "0x401A06F")]
		[FieldOffset(Offset = "0x10")]
		public string subProfId;

		// Token: 0x0401A070 RID: 106608
		[Token(Token = "0x401A070")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0401A071 RID: 106609
		[Token(Token = "0x401A071")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0401A072 RID: 106610
		[Token(Token = "0x401A072")]
		[FieldOffset(Offset = "0x24")]
		public bool isInvalid;

		// Token: 0x0401A073 RID: 106611
		[Token(Token = "0x401A073")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
