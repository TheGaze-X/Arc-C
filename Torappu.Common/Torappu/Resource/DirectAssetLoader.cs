using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Resource
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	public class DirectAssetLoader : AbstractAssetLoader
	{
		// Token: 0x06000AAE RID: 2734 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x554E650", Offset = "0x554D250", VA = "0x18554E650", Slot = "10")]
		public override void ClearAll()
		{
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x554E780", Offset = "0x554D380", VA = "0x18554E780", Slot = "11")]
		protected override void OnAssetLoaded(string path, UnityEngine.Object asset)
		{
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x554E870", Offset = "0x554D470", VA = "0x18554E870", Slot = "12")]
		protected override void OnAssetUnloading(UnityEngine.Object asset)
		{
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x554E8E0", Offset = "0x554D4E0", VA = "0x18554E8E0")]
		public DirectAssetLoader()
		{
		}

		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		[FieldOffset(Offset = "0x10")]
		private List<int> m_instanceIds;
	}
}
