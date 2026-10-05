using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065B0 RID: 26032
	[Token(Token = "0x20065B0")]
	public class ArtMagazineDiyFilterRarityItem : ArtMagazineDiyFilterItemBase
	{
		// Token: 0x060256A6 RID: 153254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256A6")]
		[Address(RVA = "0x2062540", Offset = "0x2061140", VA = "0x182062540", Slot = "4")]
		public override void Render(object activeFilterParam)
		{
		}

		// Token: 0x060256A7 RID: 153255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256A7")]
		[Address(RVA = "0x2062430", Offset = "0x2061030", VA = "0x182062430")]
		public void OnClick()
		{
		}

		// Token: 0x060256A8 RID: 153256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256A8")]
		[Address(RVA = "0x2062720", Offset = "0x2061320", VA = "0x182062720")]
		public ArtMagazineDiyFilterRarityItem()
		{
		}

		// Token: 0x04034824 RID: 215076
		[Token(Token = "0x4034824")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharRarityFilter _filterType;

		// Token: 0x04034825 RID: 215077
		[Token(Token = "0x4034825")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _filterTypeName;

		// Token: 0x04034826 RID: 215078
		[Token(Token = "0x4034826")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _unselectColor;

		// Token: 0x04034827 RID: 215079
		[Token(Token = "0x4034827")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _selectColor;

		// Token: 0x04034828 RID: 215080
		[Token(Token = "0x4034828")]
		[FieldOffset(Offset = "0x48")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04034829 RID: 215081
		[Token(Token = "0x4034829")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403482A RID: 215082
		[Token(Token = "0x403482A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403482B RID: 215083
		[Token(Token = "0x403482B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
