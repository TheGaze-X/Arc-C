using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200659D RID: 26013
	[Token(Token = "0x200659D")]
	public class ArtMagazineDiyGridHomeBgItem : ArtMagazineDiyGridItemBase
	{
		// Token: 0x0602566B RID: 153195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602566B")]
		[Address(RVA = "0x20629C0", Offset = "0x20615C0", VA = "0x1820629C0", Slot = "4")]
		protected override void OnRender(IArtMagazineDiyItemViewModel itemModel, bool isSelected)
		{
		}

		// Token: 0x0602566C RID: 153196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602566C")]
		[Address(RVA = "0x2062B20", Offset = "0x2061720", VA = "0x182062B20")]
		public ArtMagazineDiyGridHomeBgItem()
		{
		}

		// Token: 0x040347AB RID: 214955
		[Token(Token = "0x40347AB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _bgPic;

		// Token: 0x040347AC RID: 214956
		[Token(Token = "0x40347AC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _selectGo;

		// Token: 0x040347AD RID: 214957
		[Token(Token = "0x40347AD")]
		[FieldOffset(Offset = "0x48")]
		private string m_cacheBgPicId;

		// Token: 0x040347AE RID: 214958
		[Token(Token = "0x40347AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040347AF RID: 214959
		[Token(Token = "0x40347AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
