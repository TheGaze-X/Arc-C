using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200659E RID: 26014
	[Token(Token = "0x200659E")]
	public class ArtMagazineDiyGridHomeThemeItem : ArtMagazineDiyGridItemBase
	{
		// Token: 0x0602566D RID: 153197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602566D")]
		[Address(RVA = "0x2062BC0", Offset = "0x20617C0", VA = "0x182062BC0", Slot = "4")]
		protected override void OnRender(IArtMagazineDiyItemViewModel itemModel, bool isSelected)
		{
		}

		// Token: 0x0602566E RID: 153198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602566E")]
		[Address(RVA = "0x2062D20", Offset = "0x2061920", VA = "0x182062D20")]
		public ArtMagazineDiyGridHomeThemeItem()
		{
		}

		// Token: 0x040347B0 RID: 214960
		[Token(Token = "0x40347B0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _themePic;

		// Token: 0x040347B1 RID: 214961
		[Token(Token = "0x40347B1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _selectGo;

		// Token: 0x040347B2 RID: 214962
		[Token(Token = "0x40347B2")]
		[FieldOffset(Offset = "0x48")]
		private string m_cacheThemePicId;

		// Token: 0x040347B3 RID: 214963
		[Token(Token = "0x40347B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040347B4 RID: 214964
		[Token(Token = "0x40347B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
