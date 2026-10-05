using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006613 RID: 26131
	[Token(Token = "0x2006613")]
	public abstract class ArtGalleryListModeItemViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170058A8 RID: 22696
		// (get) Token: 0x06025891 RID: 153745 RVA: 0x000C8220 File Offset: 0x000C6420
		[Token(Token = "0x170058A8")]
		public Vector2 viewSize
		{
			[Token(Token = "0x6025891")]
			[Address(RVA = "0x20852C0", Offset = "0x2083EC0", VA = "0x1820852C0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170058A9 RID: 22697
		// (get) Token: 0x06025892 RID: 153746
		[Token(Token = "0x170058A9")]
		protected abstract IArtGalleryDisplayItemViewModel displayItemViewModel { [Token(Token = "0x6025892")] get; }

		// Token: 0x170058AA RID: 22698
		// (get) Token: 0x06025893 RID: 153747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170058AA")]
		protected ILoadAsset assetLoader
		{
			[Token(Token = "0x6025893")]
			[Address(RVA = "0x2085210", Offset = "0x2083E10", VA = "0x182085210")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025894 RID: 153748
		[Token(Token = "0x6025894")]
		public abstract void Render(IArtGalleryDisplayItemViewModel artGalleryDisplayItemViewModel);

		// Token: 0x06025895 RID: 153749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025895")]
		[Address(RVA = "0x2084FB0", Offset = "0x2083BB0", VA = "0x182084FB0", Slot = "6")]
		protected virtual void OnItemClick()
		{
		}

		// Token: 0x06025896 RID: 153750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025896")]
		[Address(RVA = "0x2084EC0", Offset = "0x2083AC0", VA = "0x182084EC0")]
		public void EventOnClick()
		{
		}

		// Token: 0x06025897 RID: 153751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025897")]
		[Address(RVA = "0x20851B0", Offset = "0x2083DB0", VA = "0x1820851B0")]
		protected ArtGalleryListModeItemViewBase()
		{
		}

		// Token: 0x04034BB1 RID: 215985
		[Token(Token = "0x4034BB1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04034BB2 RID: 215986
		[Token(Token = "0x4034BB2")]
		[FieldOffset(Offset = "0x20")]
		private ILoadAsset m_cachedAssetLoader;

		// Token: 0x04034BB3 RID: 215987
		[Token(Token = "0x4034BB3")]
		[FieldOffset(Offset = "0x28")]
		protected UIStateFinder stateFinder;

		// Token: 0x04034BB4 RID: 215988
		[Token(Token = "0x4034BB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewSize;

		// Token: 0x04034BB5 RID: 215989
		[Token(Token = "0x4034BB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x04034BB6 RID: 215990
		[Token(Token = "0x4034BB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04034BB7 RID: 215991
		[Token(Token = "0x4034BB7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04034BB8 RID: 215992
		[Token(Token = "0x4034BB8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
