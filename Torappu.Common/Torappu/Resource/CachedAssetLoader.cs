using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Resource
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	public class CachedAssetLoader : AbstractAssetLoader
	{
		// Token: 0x06000AA2 RID: 2722 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x554D110", Offset = "0x554BD10", VA = "0x18554D110", Slot = "10")]
		public override void ClearAll()
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x554D120", Offset = "0x554BD20", VA = "0x18554D120")]
		public void ClearAll(bool unloadUnusedAssets)
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0000794C File Offset: 0x00005B4C
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x554D390", Offset = "0x554BF90", VA = "0x18554D390")]
		public int GetAssetsCountByPathRule(Func<string, bool> pathChecker)
		{
			return 0;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x554D4A0", Offset = "0x554C0A0", VA = "0x18554D4A0", Slot = "11")]
		protected override void OnAssetLoaded(string path, UnityEngine.Object asset)
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x554D5A0", Offset = "0x554C1A0", VA = "0x18554D5A0", Slot = "12")]
		protected override void OnAssetUnloading(UnityEngine.Object asset)
		{
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00007964 File Offset: 0x00005B64
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x554D6B0", Offset = "0x554C2B0", VA = "0x18554D6B0", Slot = "14")]
		protected override bool TryGetAsset(string path, out UnityEngine.Object asset)
		{
			return default(bool);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0000797C File Offset: 0x00005B7C
		[Token(Token = "0x6000AA8")]
		protected override bool TryGetAsset<T>(string path, out T asset)
		{
			return default(bool);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00007994 File Offset: 0x00005B94
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x554D7D0", Offset = "0x554C3D0", VA = "0x18554D7D0", Slot = "16")]
		protected override bool TryGetAssets(string path, out UnityEngine.Object[] assets)
		{
			return default(bool);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000079AC File Offset: 0x00005BAC
		[Token(Token = "0x6000AAA")]
		protected override bool TryGetAssets<T>(string path, out T[] assets)
		{
			return default(bool);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x554D8B0", Offset = "0x554C4B0", VA = "0x18554D8B0")]
		private HashSet<UnityEngine.Object> _EnsureCachedAsset(string key)
		{
			return null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x554D990", Offset = "0x554C590", VA = "0x18554D990")]
		private string _GetKeyFromPath(string path)
		{
			return null;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x554D9B0", Offset = "0x554C5B0", VA = "0x18554D9B0")]
		public CachedAssetLoader()
		{
		}

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, HashSet<UnityEngine.Object>> m_cachedAssets;

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, string> m_instanceIdToName;
	}
}
