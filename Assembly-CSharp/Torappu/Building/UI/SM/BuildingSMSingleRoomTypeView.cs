using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CC5 RID: 7365
	[Token(Token = "0x2001CC5")]
	public abstract class BuildingSMSingleRoomTypeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B673 RID: 46707
		[Token(Token = "0x600B673")]
		public abstract void Render(SelectedRoomDetailViewModel roomModel);

		// Token: 0x0600B674 RID: 46708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B674")]
		[Address(RVA = "0x3307880", Offset = "0x3306480", VA = "0x183307880")]
		protected void _FormatBuffedValues(float baseBuff, float specBuff, SimpleLayoutContent layout, ref BuildingBuffedValueView.ListAdapter refAdatper, bool usePercentFormat, Color bkgBuffColor, Color textBuffColor)
		{
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B675")]
		[Address(RVA = "0x3307B80", Offset = "0x3306780", VA = "0x183307B80")]
		protected BuildingSMSingleRoomTypeView()
		{
		}

		// Token: 0x0400B388 RID: 45960
		[Token(Token = "0x400B388")]
		[FieldOffset(Offset = "0x18")]
		protected readonly Color BUFF_DEFAULT_BKG_COLOR;

		// Token: 0x0400B389 RID: 45961
		[Token(Token = "0x400B389")]
		[FieldOffset(Offset = "0x28")]
		protected readonly Color BUFF_DEFAULT_TEXT_COLOR;

		// Token: 0x0400B38A RID: 45962
		[Token(Token = "0x400B38A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__FormatBuffedValues;

		// Token: 0x0400B38B RID: 45963
		[Token(Token = "0x400B38B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
