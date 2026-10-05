using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065A0 RID: 26016
	[Token(Token = "0x20065A0")]
	public class ArtMagazineDiyGridNameCardItem : ArtMagazineDiyGridItemBase
	{
		// Token: 0x06025673 RID: 153203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025673")]
		[Address(RVA = "0x2063020", Offset = "0x2061C20", VA = "0x182063020", Slot = "4")]
		protected override void OnRender(IArtMagazineDiyItemViewModel itemModel, bool isSelected)
		{
		}

		// Token: 0x06025674 RID: 153204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025674")]
		[Address(RVA = "0x2063280", Offset = "0x2061E80", VA = "0x182063280")]
		public ArtMagazineDiyGridNameCardItem()
		{
		}

		// Token: 0x040347BB RID: 214971
		[Token(Token = "0x40347BB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _shortBgPic;

		// Token: 0x040347BC RID: 214972
		[Token(Token = "0x40347BC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _selectGo;

		// Token: 0x040347BD RID: 214973
		[Token(Token = "0x40347BD")]
		[FieldOffset(Offset = "0x48")]
		private string m_cacheNameCardSkinId;

		// Token: 0x040347BE RID: 214974
		[Token(Token = "0x40347BE")]
		[FieldOffset(Offset = "0x50")]
		private int m_cacheImpl;

		// Token: 0x040347BF RID: 214975
		[Token(Token = "0x40347BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040347C0 RID: 214976
		[Token(Token = "0x40347C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
