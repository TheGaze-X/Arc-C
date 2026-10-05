using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065AA RID: 26026
	[Token(Token = "0x20065AA")]
	public class ArtMagazineDiyFilterAvatarTypeItem : ArtMagazineDiyFilterItemBase
	{
		// Token: 0x06025694 RID: 153236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025694")]
		[Address(RVA = "0x2061380", Offset = "0x205FF80", VA = "0x182061380", Slot = "4")]
		public override void Render(object activeFilterParam)
		{
		}

		// Token: 0x06025695 RID: 153237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025695")]
		[Address(RVA = "0x2061270", Offset = "0x205FE70", VA = "0x182061270")]
		public void OnClick()
		{
		}

		// Token: 0x06025696 RID: 153238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025696")]
		[Address(RVA = "0x2061510", Offset = "0x2060110", VA = "0x182061510")]
		public ArtMagazineDiyFilterAvatarTypeItem()
		{
		}

		// Token: 0x040347FB RID: 215035
		[Token(Token = "0x40347FB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AvatarGroupFilter _filter;

		// Token: 0x040347FC RID: 215036
		[Token(Token = "0x40347FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _typeName;

		// Token: 0x040347FD RID: 215037
		[Token(Token = "0x40347FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _unselectColor;

		// Token: 0x040347FE RID: 215038
		[Token(Token = "0x40347FE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _selectColor;

		// Token: 0x040347FF RID: 215039
		[Token(Token = "0x40347FF")]
		[FieldOffset(Offset = "0x48")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04034800 RID: 215040
		[Token(Token = "0x4034800")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034801 RID: 215041
		[Token(Token = "0x4034801")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04034802 RID: 215042
		[Token(Token = "0x4034802")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
