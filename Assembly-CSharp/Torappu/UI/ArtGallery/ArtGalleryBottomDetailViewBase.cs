using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006605 RID: 26117
	[Token(Token = "0x2006605")]
	public abstract class ArtGalleryBottomDetailViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025856 RID: 153686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025856")]
		[Address(RVA = "0x2070260", Offset = "0x206EE60", VA = "0x182070260", Slot = "4")]
		public virtual void EffectOnShow()
		{
		}

		// Token: 0x06025857 RID: 153687
		[Token(Token = "0x6025857")]
		public abstract void OnUpdate(ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam itemSelectParam);

		// Token: 0x06025858 RID: 153688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025858")]
		[Address(RVA = "0x20701F0", Offset = "0x206EDF0", VA = "0x1820701F0", Slot = "6")]
		public virtual void EffectOnHide()
		{
		}

		// Token: 0x06025859 RID: 153689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025859")]
		[Address(RVA = "0x20702D0", Offset = "0x206EED0", VA = "0x1820702D0")]
		protected ArtGalleryBottomDetailViewBase()
		{
		}

		// Token: 0x04034B23 RID: 215843
		[Token(Token = "0x4034B23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EffectOnShow;

		// Token: 0x04034B24 RID: 215844
		[Token(Token = "0x4034B24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EffectOnHide;

		// Token: 0x04034B25 RID: 215845
		[Token(Token = "0x4034B25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
