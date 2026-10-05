using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065AF RID: 26031
	[Token(Token = "0x20065AF")]
	public class ArtMagazineDiyFilterProfessionItem : ArtMagazineDiyFilterItemBase
	{
		// Token: 0x060256A3 RID: 153251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256A3")]
		[Address(RVA = "0x20621A0", Offset = "0x2060DA0", VA = "0x1820621A0", Slot = "4")]
		public override void Render(object activeFilterParam)
		{
		}

		// Token: 0x060256A4 RID: 153252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256A4")]
		[Address(RVA = "0x2062090", Offset = "0x2060C90", VA = "0x182062090")]
		public void OnClick()
		{
		}

		// Token: 0x060256A5 RID: 153253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256A5")]
		[Address(RVA = "0x2062390", Offset = "0x2060F90", VA = "0x182062390")]
		public ArtMagazineDiyFilterProfessionItem()
		{
		}

		// Token: 0x0403481A RID: 215066
		[Token(Token = "0x403481A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharProfessionFilter _filterType;

		// Token: 0x0403481B RID: 215067
		[Token(Token = "0x403481B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ProfessionCategory _iconRelateProfession;

		// Token: 0x0403481C RID: 215068
		[Token(Token = "0x403481C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _professionIcon;

		// Token: 0x0403481D RID: 215069
		[Token(Token = "0x403481D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _allText;

		// Token: 0x0403481E RID: 215070
		[Token(Token = "0x403481E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _unselectColor;

		// Token: 0x0403481F RID: 215071
		[Token(Token = "0x403481F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _selectColor;

		// Token: 0x04034820 RID: 215072
		[Token(Token = "0x4034820")]
		[FieldOffset(Offset = "0x50")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04034821 RID: 215073
		[Token(Token = "0x4034821")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034822 RID: 215074
		[Token(Token = "0x4034822")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04034823 RID: 215075
		[Token(Token = "0x4034823")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
