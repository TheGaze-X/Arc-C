using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace BestHTTP.Examples
{
	// Token: 0x02000562 RID: 1378
	[Token(Token = "0x2000562")]
	public sealed class AssetBundleSample : MonoBehaviour
	{
		// Token: 0x06002DA4 RID: 11684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA4")]
		[Address(RVA = "0x53E1D00", Offset = "0x53E0900", VA = "0x1853E1D00")]
		private void OnGUI()
		{
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0x53E1CF0", Offset = "0x53E08F0", VA = "0x1853E1CF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0x53E1C70", Offset = "0x53E0870", VA = "0x1853E1C70")]
		private IEnumerator DownloadAssetBundle()
		{
			return null;
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x53E1E70", Offset = "0x53E0A70", VA = "0x1853E1E70")]
		private IEnumerator ProcessAssetBundle(AssetBundle bundle)
		{
			return null;
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0x53E2100", Offset = "0x53E0D00", VA = "0x1853E2100")]
		private void UnloadBundle()
		{
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0x53E2190", Offset = "0x53E0D90", VA = "0x1853E2190")]
		public AssetBundleSample()
		{
		}

		// Token: 0x0400199D RID: 6557
		[Token(Token = "0x400199D")]
		private const string URL = "https://besthttp.azurewebsites.net/Content/AssetBundle.html";

		// Token: 0x0400199E RID: 6558
		[Token(Token = "0x400199E")]
		[FieldOffset(Offset = "0x18")]
		private string status;

		// Token: 0x0400199F RID: 6559
		[Token(Token = "0x400199F")]
		[FieldOffset(Offset = "0x20")]
		private AssetBundle cachedBundle;

		// Token: 0x040019A0 RID: 6560
		[Token(Token = "0x40019A0")]
		[FieldOffset(Offset = "0x28")]
		private Texture2D texture;

		// Token: 0x040019A1 RID: 6561
		[Token(Token = "0x40019A1")]
		[FieldOffset(Offset = "0x30")]
		private bool downloading;
	}
}
