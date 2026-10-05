using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039F3 RID: 14835
	[Token(Token = "0x20039F3")]
	public class UISimpleDropdownItemViewModel : ICommonDropdownModel, IHotfixable
	{
		// Token: 0x060176B5 RID: 95925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60176B5")]
		[Address(RVA = "0xFC5FF0", Offset = "0xFC4BF0", VA = "0x180FC5FF0", Slot = "4")]
		public string GetDesc()
		{
			return null;
		}

		// Token: 0x060176B6 RID: 95926 RVA: 0x000965D0 File Offset: 0x000947D0
		[Token(Token = "0x60176B6")]
		[Address(RVA = "0xFC6050", Offset = "0xFC4C50", VA = "0x180FC6050", Slot = "5")]
		public int GetIndex()
		{
			return 0;
		}

		// Token: 0x060176B7 RID: 95927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60176B7")]
		[Address(RVA = "0xFC60B0", Offset = "0xFC4CB0", VA = "0x180FC60B0")]
		public UISimpleDropdownItemViewModel()
		{
		}

		// Token: 0x0401C4AF RID: 115887
		[Token(Token = "0x401C4AF")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x0401C4B0 RID: 115888
		[Token(Token = "0x401C4B0")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		// Token: 0x0401C4B1 RID: 115889
		[Token(Token = "0x401C4B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x0401C4B2 RID: 115890
		[Token(Token = "0x401C4B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetIndex;

		// Token: 0x0401C4B3 RID: 115891
		[Token(Token = "0x401C4B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
