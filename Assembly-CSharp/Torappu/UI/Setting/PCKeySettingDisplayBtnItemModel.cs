using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FDE RID: 16350
	[Token(Token = "0x2003FDE")]
	public class PCKeySettingDisplayBtnItemModel : UISimpleRecycleLayoutItemViewModel, IHotfixable
	{
		// Token: 0x06019559 RID: 103769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019559")]
		[Address(RVA = "0x11FA500", Offset = "0x11F9100", VA = "0x1811FA500", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x0601955A RID: 103770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601955A")]
		[Address(RVA = "0x11FA570", Offset = "0x11F9170", VA = "0x1811FA570")]
		public PCKeySettingDisplayBtnItemModel()
		{
		}

		// Token: 0x0401F7FF RID: 129023
		[Token(Token = "0x401F7FF")]
		public const string VIEW_TYPE = "DISPLAY_BTN";

		// Token: 0x0401F800 RID: 129024
		[Token(Token = "0x401F800")]
		public const int SEQUENCE_DEFAULT = 0;

		// Token: 0x0401F801 RID: 129025
		[Token(Token = "0x401F801")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x0401F802 RID: 129026
		[Token(Token = "0x401F802")]
		[FieldOffset(Offset = "0x18")]
		public bool isNormalGroup;

		// Token: 0x0401F803 RID: 129027
		[Token(Token = "0x401F803")]
		[FieldOffset(Offset = "0x19")]
		public bool isEnable;

		// Token: 0x0401F804 RID: 129028
		[Token(Token = "0x401F804")]
		[FieldOffset(Offset = "0x1C")]
		public int sequenceNum;

		// Token: 0x0401F805 RID: 129029
		[Token(Token = "0x401F805")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F806 RID: 129030
		[Token(Token = "0x401F806")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
