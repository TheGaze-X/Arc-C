using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006009 RID: 24585
	[Token(Token = "0x2006009")]
	public class CGGalleryCollectionStorylineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060238B4 RID: 145588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238B4")]
		[Address(RVA = "0x1E2DF30", Offset = "0x1E2CB30", VA = "0x181E2DF30")]
		public void Render(CGGalleryViewModel model)
		{
		}

		// Token: 0x060238B5 RID: 145589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238B5")]
		[Address(RVA = "0x1E2E0C0", Offset = "0x1E2CCC0", VA = "0x181E2E0C0")]
		public CGGalleryCollectionStorylineView()
		{
		}

		// Token: 0x040312E4 RID: 201444
		[Token(Token = "0x40312E4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _mainlinePanel;

		// Token: 0x040312E5 RID: 201445
		[Token(Token = "0x40312E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _otherPanel;

		// Token: 0x040312E6 RID: 201446
		[Token(Token = "0x40312E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _logoImage;

		// Token: 0x040312E7 RID: 201447
		[Token(Token = "0x40312E7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _abbrImage;

		// Token: 0x040312E8 RID: 201448
		[Token(Token = "0x40312E8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x040312E9 RID: 201449
		[Token(Token = "0x40312E9")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_finder;

		// Token: 0x040312EA RID: 201450
		[Token(Token = "0x40312EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040312EB RID: 201451
		[Token(Token = "0x40312EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
