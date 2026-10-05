using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FE0 RID: 16352
	[Token(Token = "0x2003FE0")]
	public class PCKeySettingItemModel : UISimpleRecycleLayoutItemViewModel, IComparable, IHotfixable
	{
		// Token: 0x0601955D RID: 103773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601955D")]
		[Address(RVA = "0x11FB000", Offset = "0x11F9C00", VA = "0x1811FB000", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x0601955E RID: 103774 RVA: 0x0009DBF0 File Offset: 0x0009BDF0
		[Token(Token = "0x601955E")]
		[Address(RVA = "0x11FAEE0", Offset = "0x11F9AE0", VA = "0x1811FAEE0", Slot = "6")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0601955F RID: 103775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601955F")]
		[Address(RVA = "0x11FB070", Offset = "0x11F9C70", VA = "0x1811FB070")]
		public PCKeySettingItemModel()
		{
		}

		// Token: 0x0401F80B RID: 129035
		[Token(Token = "0x401F80B")]
		public const string VIEW_TYPE = "SETTING_ITEM";

		// Token: 0x0401F80C RID: 129036
		[Token(Token = "0x401F80C")]
		[FieldOffset(Offset = "0x10")]
		public KeyBoardVirtualButtonConfig groupConfig;

		// Token: 0x0401F80D RID: 129037
		[Token(Token = "0x401F80D")]
		[FieldOffset(Offset = "0x18")]
		public string funcName;

		// Token: 0x0401F80E RID: 129038
		[Token(Token = "0x401F80E")]
		[FieldOffset(Offset = "0x20")]
		public KeyItem currKey;

		// Token: 0x0401F80F RID: 129039
		[Token(Token = "0x401F80F")]
		[FieldOffset(Offset = "0x28")]
		public bool canBeSet;

		// Token: 0x0401F810 RID: 129040
		[Token(Token = "0x401F810")]
		[FieldOffset(Offset = "0x2C")]
		public int sortId;

		// Token: 0x0401F811 RID: 129041
		[Token(Token = "0x401F811")]
		[FieldOffset(Offset = "0x30")]
		public string defaultKeyId;

		// Token: 0x0401F812 RID: 129042
		[Token(Token = "0x401F812")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F813 RID: 129043
		[Token(Token = "0x401F813")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0401F814 RID: 129044
		[Token(Token = "0x401F814")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
