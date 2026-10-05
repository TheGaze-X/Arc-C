using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Resource
{
	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	public class AsyncComponent<TComp> : AsyncResource where TComp : UnityEngine.Object
	{
		// Token: 0x06000ABE RID: 2750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABE")]
		public override UnityEngine.Object GetAsset()
		{
			return null;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000ABF")]
		public AsyncComponent(ResourceRequest resRequest)
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AC0")]
		public AsyncComponent(AssetBundleRequest abRequest)
		{
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AC1")]
		public AsyncComponent(UnityEngine.Object asset)
		{
		}
	}
}
