using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065A1 RID: 26017
	[Token(Token = "0x20065A1")]
	public class ArtMagazineDiyGridSkinItem : ArtMagazineDiyGridItemBase
	{
		// Token: 0x06025675 RID: 153205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025675")]
		[Address(RVA = "0x20633B0", Offset = "0x2061FB0", VA = "0x1820633B0", Slot = "4")]
		protected override void OnRender(IArtMagazineDiyItemViewModel itemModel, bool isSelected)
		{
		}

		// Token: 0x06025676 RID: 153206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025676")]
		[Address(RVA = "0x2063320", Offset = "0x2061F20", VA = "0x182063320", Slot = "5")]
		public override void EventItemClick()
		{
		}

		// Token: 0x06025677 RID: 153207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025677")]
		[Address(RVA = "0x20635A0", Offset = "0x20621A0", VA = "0x1820635A0")]
		public ArtMagazineDiyGridSkinItem()
		{
		}

		// Token: 0x06025678 RID: 153208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025678")]
		[Address(RVA = "0x2063590", Offset = "0x2062190", VA = "0x182063590")]
		private void <>xLuaBaseProxy_EventItemClick()
		{
		}

		// Token: 0x040347C1 RID: 214977
		[Token(Token = "0x40347C1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _portrait;

		// Token: 0x040347C2 RID: 214978
		[Token(Token = "0x40347C2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _spSkinGo;

		// Token: 0x040347C3 RID: 214979
		[Token(Token = "0x40347C3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selectedOutlineGo;

		// Token: 0x040347C4 RID: 214980
		[Token(Token = "0x40347C4")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachePortraitId;

		// Token: 0x040347C5 RID: 214981
		[Token(Token = "0x40347C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040347C6 RID: 214982
		[Token(Token = "0x40347C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventItemClick;

		// Token: 0x040347C7 RID: 214983
		[Token(Token = "0x40347C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
