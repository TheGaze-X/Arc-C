using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006566 RID: 25958
	[Token(Token = "0x2006566")]
	public class ArtMagazineDiyDecorCommonDialog : UICompDialog<ArtMagazineDiyDecorDialogCommonInput>
	{
		// Token: 0x0602553B RID: 152891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602553B")]
		[Address(RVA = "0x2043570", Offset = "0x2042170", VA = "0x182043570", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602553C RID: 152892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602553C")]
		[Address(RVA = "0x2043650", Offset = "0x2042250", VA = "0x182043650", Slot = "18")]
		protected override void OnRender(ArtMagazineDiyDecorDialogCommonInput input)
		{
		}

		// Token: 0x0602553D RID: 152893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602553D")]
		[Address(RVA = "0x2043920", Offset = "0x2042520", VA = "0x182043920")]
		public ArtMagazineDiyDecorCommonDialog()
		{
		}

		// Token: 0x0602553E RID: 152894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602553E")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x040345E9 RID: 214505
		[Token(Token = "0x40345E9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ArtMagazineDiyLoopScrollAdapter _adapter;

		// Token: 0x040345EA RID: 214506
		[Token(Token = "0x40345EA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ArtMagazineDiySorterItemView[] _sorterList;

		// Token: 0x040345EB RID: 214507
		[Token(Token = "0x40345EB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ArtMagazineDiyFilterGroupView[] _filterList;

		// Token: 0x040345EC RID: 214508
		[Token(Token = "0x40345EC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _emptyIcon;

		// Token: 0x040345ED RID: 214509
		[Token(Token = "0x40345ED")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ArtMagazineDiyDecorSelectNumPanel _selectNumPanelPrefab;

		// Token: 0x040345EE RID: 214510
		[Token(Token = "0x40345EE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _selectNumPanelContainer;

		// Token: 0x040345EF RID: 214511
		[Token(Token = "0x40345EF")]
		[FieldOffset(Offset = "0xA0")]
		private ArtMagazineDiyDecorSelectNumPanel m_selectNumPanel;

		// Token: 0x040345F0 RID: 214512
		[Token(Token = "0x40345F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040345F1 RID: 214513
		[Token(Token = "0x40345F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040345F2 RID: 214514
		[Token(Token = "0x40345F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
