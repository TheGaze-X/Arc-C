using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act35side
{
	// Token: 0x0200747C RID: 29820
	[Token(Token = "0x200747C")]
	public class Act35sideMilestoneItemView : TemplateActivityCommonMileStoneItemView
	{
		// Token: 0x0602A0EE RID: 172270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0EE")]
		[Address(RVA = "0x25C2100", Offset = "0x25C0D00", VA = "0x1825C2100", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x0602A0EF RID: 172271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0EF")]
		[Address(RVA = "0x25C23C0", Offset = "0x25C0FC0", VA = "0x1825C23C0")]
		public Act35sideMilestoneItemView()
		{
		}

		// Token: 0x0602A0F0 RID: 172272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0F0")]
		[Address(RVA = "0x15FF010", Offset = "0x15FDC10", VA = "0x1815FF010")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0403C58F RID: 247183
		[Token(Token = "0x403C58F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggle _displayToggle;

		// Token: 0x0403C590 RID: 247184
		[Token(Token = "0x403C590")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textLevelNum;

		// Token: 0x0403C591 RID: 247185
		[Token(Token = "0x403C591")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textLevelConstText1;

		// Token: 0x0403C592 RID: 247186
		[Token(Token = "0x403C592")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textLevelConstText2;

		// Token: 0x0403C593 RID: 247187
		[Token(Token = "0x403C593")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _objMaskFinished;

		// Token: 0x0403C594 RID: 247188
		[Token(Token = "0x403C594")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _colorDiff1;

		// Token: 0x0403C595 RID: 247189
		[Token(Token = "0x403C595")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _colorDiff2;

		// Token: 0x0403C596 RID: 247190
		[Token(Token = "0x403C596")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Color _colorDiff3;

		// Token: 0x0403C597 RID: 247191
		[Token(Token = "0x403C597")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Color _colorDiff4;

		// Token: 0x0403C598 RID: 247192
		[Token(Token = "0x403C598")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403C599 RID: 247193
		[Token(Token = "0x403C599")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
