using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FDF RID: 16351
	[Token(Token = "0x2003FDF")]
	public class PCKeySettingTitleItemModel : UISimpleRecycleLayoutItemViewModel, IHotfixable
	{
		// Token: 0x0601955B RID: 103771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601955B")]
		[Address(RVA = "0x11FCAC0", Offset = "0x11FB6C0", VA = "0x1811FCAC0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x0601955C RID: 103772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601955C")]
		[Address(RVA = "0x11FCB30", Offset = "0x11FB730", VA = "0x1811FCB30")]
		public PCKeySettingTitleItemModel()
		{
		}

		// Token: 0x0401F807 RID: 129031
		[Token(Token = "0x401F807")]
		public const string VIEW_TYPE = "GROUP_TITLE";

		// Token: 0x0401F808 RID: 129032
		[Token(Token = "0x401F808")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x0401F809 RID: 129033
		[Token(Token = "0x401F809")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F80A RID: 129034
		[Token(Token = "0x401F80A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
