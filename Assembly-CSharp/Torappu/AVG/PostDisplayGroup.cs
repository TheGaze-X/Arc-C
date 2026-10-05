using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F05 RID: 7941
	[Token(Token = "0x2001F05")]
	public class PostDisplayGroup : IHotfixable, IDisposable
	{
		// Token: 0x0600C522 RID: 50466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C522")]
		[Address(RVA = "0x3430560", Offset = "0x342F160", VA = "0x183430560")]
		public PostDisplayGroup(PostDisplayGroup.IHost host)
		{
		}

		// Token: 0x0600C523 RID: 50467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C523")]
		public T LoadAsset<T>(string resPath) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600C524 RID: 50468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C524")]
		public PostDisplayHandler Bind<TItem>(PostDisplayKey key) where TItem : PostDisplayItem, new()
		{
			return null;
		}

		// Token: 0x0600C525 RID: 50469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C525")]
		[Address(RVA = "0x3430460", Offset = "0x342F060", VA = "0x183430460")]
		public void Remove(PostDisplayItem item)
		{
		}

		// Token: 0x0600C526 RID: 50470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C526")]
		[Address(RVA = "0x3430280", Offset = "0x342EE80", VA = "0x183430280", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400C9A7 RID: 51623
		[Token(Token = "0x400C9A7")]
		[FieldOffset(Offset = "0x10")]
		private PostDisplayGroup.IHost m_host;

		// Token: 0x0400C9A8 RID: 51624
		[Token(Token = "0x400C9A8")]
		[FieldOffset(Offset = "0x18")]
		private List<PostDisplayItem> m_items;

		// Token: 0x0400C9A9 RID: 51625
		[Token(Token = "0x400C9A9")]
		[FieldOffset(Offset = "0x20")]
		private List<PostDisplayItem> m_cachedItems;

		// Token: 0x0400C9AA RID: 51626
		[Token(Token = "0x400C9AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400C9AB RID: 51627
		[Token(Token = "0x400C9AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0400C9AC RID: 51628
		[Token(Token = "0x400C9AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x0400C9AD RID: 51629
		[Token(Token = "0x400C9AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Remove;

		// Token: 0x0400C9AE RID: 51630
		[Token(Token = "0x400C9AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x02001F06 RID: 7942
		[Token(Token = "0x2001F06")]
		public interface IHost
		{
			// Token: 0x0600C527 RID: 50471
			[Token(Token = "0x600C527")]
			ILoadAsset GetAssetLoader();
		}
	}
}
