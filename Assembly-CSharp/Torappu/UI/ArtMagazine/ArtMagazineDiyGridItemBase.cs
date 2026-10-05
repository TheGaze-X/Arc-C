using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200659F RID: 26015
	[Token(Token = "0x200659F")]
	public abstract class ArtMagazineDiyGridItemBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602566F RID: 153199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602566F")]
		[Address(RVA = "0x2062EF0", Offset = "0x2061AF0", VA = "0x182062EF0")]
		public void Render(IArtMagazineDiyItemViewModel itemModel, bool isSelected)
		{
		}

		// Token: 0x06025670 RID: 153200
		[Token(Token = "0x6025670")]
		protected abstract void OnRender(IArtMagazineDiyItemViewModel itemModel, bool isSelected);

		// Token: 0x06025671 RID: 153201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025671")]
		[Address(RVA = "0x2062DC0", Offset = "0x20619C0", VA = "0x182062DC0", Slot = "5")]
		public virtual void EventItemClick()
		{
		}

		// Token: 0x06025672 RID: 153202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025672")]
		[Address(RVA = "0x2062FC0", Offset = "0x2061BC0", VA = "0x182062FC0")]
		protected ArtMagazineDiyGridItemBase()
		{
		}

		// Token: 0x040347B5 RID: 214965
		[Token(Token = "0x40347B5")]
		[FieldOffset(Offset = "0x18")]
		protected IArtMagazineDiyItemViewModel cacheItemModel;

		// Token: 0x040347B6 RID: 214966
		[Token(Token = "0x40347B6")]
		[FieldOffset(Offset = "0x20")]
		protected UIPageFinder pageFinder;

		// Token: 0x040347B7 RID: 214967
		[Token(Token = "0x40347B7")]
		[FieldOffset(Offset = "0x30")]
		protected bool cacheIsSelected;

		// Token: 0x040347B8 RID: 214968
		[Token(Token = "0x40347B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040347B9 RID: 214969
		[Token(Token = "0x40347B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventItemClick;

		// Token: 0x040347BA RID: 214970
		[Token(Token = "0x40347BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
