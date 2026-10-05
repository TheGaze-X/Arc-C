using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Resource
{
	// Token: 0x020001D4 RID: 468
	[Token(Token = "0x20001D4")]
	public abstract class AssetInfoMemoInScene<TSingleton> : SingletonInScene<TSingleton> where TSingleton : AssetInfoMemoInScene<TSingleton>
	{
		// Token: 0x06000B13 RID: 2835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B13")]
		protected object LoadFromRes<T>(string resPath) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000B14 RID: 2836
		[Token(Token = "0x6000B14")]
		protected abstract object ReadInfoFromAsset(string resPath, UnityEngine.Object asset);

		// Token: 0x06000B15 RID: 2837 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B15")]
		protected AssetInfoMemoInScene()
		{
		}

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, object> m_memo;
	}
}
