using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007700 RID: 30464
	[Token(Token = "0x2007700")]
	public class Act1VHalfIdleCharSelectCustomInput : TemplateCharSelectController.TemplateCustomInput
	{
		// Token: 0x0602ACD9 RID: 175321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACD9")]
		[Address(RVA = "0x26987C0", Offset = "0x26973C0", VA = "0x1826987C0")]
		public Act1VHalfIdleCharSelectCustomInput()
		{
		}

		// Token: 0x0403DAE6 RID: 252646
		[Token(Token = "0x403DAE6")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleCharSelectCustomInput.ConfirmButtonType confirmButtonType;

		// Token: 0x0403DAE7 RID: 252647
		[Token(Token = "0x403DAE7")]
		[FieldOffset(Offset = "0x18")]
		public CharacterProfessionFilterParam filterParam;

		// Token: 0x0403DAE8 RID: 252648
		[Token(Token = "0x403DAE8")]
		[FieldOffset(Offset = "0x28")]
		public CharacterSortType sortType;

		// Token: 0x0403DAE9 RID: 252649
		[Token(Token = "0x403DAE9")]
		[FieldOffset(Offset = "0x2C")]
		public bool alwaysShowSelectedCharOnTop;

		// Token: 0x0403DAEA RID: 252650
		[Token(Token = "0x403DAEA")]
		[FieldOffset(Offset = "0x30")]
		public int customFocusIndex;

		// Token: 0x02007701 RID: 30465
		[Token(Token = "0x2007701")]
		public enum ConfirmButtonType
		{
			// Token: 0x0403DAEC RID: 252652
			[Token(Token = "0x403DAEC")]
			SQUAD,
			// Token: 0x0403DAED RID: 252653
			[Token(Token = "0x403DAED")]
			DEPOT
		}
	}
}
