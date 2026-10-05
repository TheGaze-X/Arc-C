using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D38 RID: 19768
	[Token(Token = "0x2004D38")]
	public class MagneticDotItemViewModel : IHotfixable
	{
		// Token: 0x0601D97B RID: 121211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D97B")]
		[Address(RVA = "0x1733890", Offset = "0x1732490", VA = "0x181733890")]
		public MagneticDotItemViewModel(int itemIndex)
		{
		}

		// Token: 0x04027152 RID: 160082
		[Token(Token = "0x4027152")]
		[FieldOffset(Offset = "0x10")]
		public readonly int index;

		// Token: 0x04027153 RID: 160083
		[Token(Token = "0x4027153")]
		[FieldOffset(Offset = "0x14")]
		public int value;

		// Token: 0x04027154 RID: 160084
		[Token(Token = "0x4027154")]
		[FieldOffset(Offset = "0x18")]
		public bool isSelected;

		// Token: 0x04027155 RID: 160085
		[Token(Token = "0x4027155")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
