using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	public class WebTextureLoader : SingletonMonoBehaviour<WebTextureLoader>
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x55629B0", Offset = "0x55615B0", VA = "0x1855629B0")]
		public void LoadImageAsync(WebTextureLoader.KeyOption keyOption, string url, Action<Texture2D> onLoaded)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x5562C50", Offset = "0x5561850", VA = "0x185562C50")]
		public void Release(WebTextureLoader.KeyOption keyOption)
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0000746C File Offset: 0x0000566C
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x55628D0", Offset = "0x55614D0", VA = "0x1855628D0")]
		public bool CheckTextureAvail(WebTextureLoader.KeyOption keyOption)
		{
			return default(bool);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x55632E0", Offset = "0x5561EE0", VA = "0x1855632E0")]
		private static string _GetUid()
		{
			return null;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x55631C0", Offset = "0x5561DC0", VA = "0x1855631C0")]
		private static string _GetKeyFromOption(WebTextureLoader.KeyOption option)
		{
			return null;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x55630A0", Offset = "0x5561CA0", VA = "0x1855630A0")]
		private IEnumerator _DownloadCoroutine(string fullKey, string url, Action<Texture2D> onLoaded)
		{
			return null;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x5562D30", Offset = "0x5561930", VA = "0x185562D30")]
		private void _CleanupIfNeeded()
		{
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x5563370", Offset = "0x5561F70", VA = "0x185563370")]
		public WebTextureLoader()
		{
		}

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		private const string PERSONAL_KEY_FORMAT = "{0}#{1}";

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, WebTextureLoader.CachedTexture> m_cacheTexture;

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _maxCacheCount;

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate207 __Hotfix0_LoadImageAsync;

		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate208 __Hotfix0_Release;

		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate209 __Hotfix0_CheckTextureAvail;

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate210 __Hotfix0__GetUid;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate211 __Hotfix0__GetKeyFromOption;

		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate212 __Hotfix0__DownloadCoroutine;

		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 __Hotfix0__CleanupIfNeeded;

		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x0200018E RID: 398
		[Token(Token = "0x200018E")]
		public enum CacheType
		{
			// Token: 0x040008F5 RID: 2293
			[Token(Token = "0x40008F5")]
			COMMON,
			// Token: 0x040008F6 RID: 2294
			[Token(Token = "0x40008F6")]
			PERSONAL
		}

		// Token: 0x0200018F RID: 399
		[Token(Token = "0x200018F")]
		public struct KeyOption
		{
			// Token: 0x06000983 RID: 2435 RVA: 0x00007484 File Offset: 0x00005684
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040008F7 RID: 2295
			[Token(Token = "0x40008F7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly WebTextureLoader.KeyOption EMPTY;

			// Token: 0x040008F8 RID: 2296
			[Token(Token = "0x40008F8")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x040008F9 RID: 2297
			[Token(Token = "0x40008F9")]
			[FieldOffset(Offset = "0x8")]
			public WebTextureLoader.CacheType type;
		}

		// Token: 0x02000190 RID: 400
		[Token(Token = "0x2000190")]
		private class CachedTexture
		{
			// Token: 0x06000985 RID: 2437 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CachedTexture()
			{
			}

			// Token: 0x040008FA RID: 2298
			[Token(Token = "0x40008FA")]
			[FieldOffset(Offset = "0x10")]
			public Texture2D texture;

			// Token: 0x040008FB RID: 2299
			[Token(Token = "0x40008FB")]
			[FieldOffset(Offset = "0x18")]
			public int refCount;

			// Token: 0x040008FC RID: 2300
			[Token(Token = "0x40008FC")]
			[FieldOffset(Offset = "0x1C")]
			public bool isAvail;

			// Token: 0x040008FD RID: 2301
			[Token(Token = "0x40008FD")]
			[FieldOffset(Offset = "0x20")]
			public Action<Texture2D> onLoadedCached;
		}
	}
}
