using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.ToDoNotify
{
	// Token: 0x02001C57 RID: 7255
	[Token(Token = "0x2001C57")]
	public class BuildingToDoNotifyItemRestView : BuildingToDoNotifyItemBase
	{
		// Token: 0x0600B480 RID: 46208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B480")]
		[Address(RVA = "0x32F4670", Offset = "0x32F3270", VA = "0x1832F4670", Slot = "4")]
		public override void Render(BuildingToDoCategory category, BuildingToDoNotifyItemModel itemModel, bool isSelected, BuildingToDoNotifyView.ItemClickStatusData itemClickStatusData)
		{
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B481")]
		[Address(RVA = "0x32F4900", Offset = "0x32F3500", VA = "0x1832F4900")]
		public BuildingToDoNotifyItemRestView()
		{
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B482")]
		[Address(RVA = "0x32F4400", Offset = "0x32F3000", VA = "0x1832F4400")]
		private void <>xLuaBaseProxy_Render(BuildingToDoCategory P0, BuildingToDoNotifyItemModel P1, bool P2, BuildingToDoNotifyView.ItemClickStatusData P3)
		{
		}

		// Token: 0x0400B041 RID: 45121
		[Token(Token = "0x400B041")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0400B042 RID: 45122
		[Token(Token = "0x400B042")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400B043 RID: 45123
		[Token(Token = "0x400B043")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0400B044 RID: 45124
		[Token(Token = "0x400B044")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _bkgCount;

		// Token: 0x0400B045 RID: 45125
		[Token(Token = "0x400B045")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textClick;

		// Token: 0x0400B046 RID: 45126
		[Token(Token = "0x400B046")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelCount;

		// Token: 0x0400B047 RID: 45127
		[Token(Token = "0x400B047")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelClick;

		// Token: 0x0400B048 RID: 45128
		[Token(Token = "0x400B048")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B049 RID: 45129
		[Token(Token = "0x400B049")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
