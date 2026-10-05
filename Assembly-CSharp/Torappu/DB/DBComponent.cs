using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DB
{
	// Token: 0x02001693 RID: 5779
	[Token(Token = "0x2001693")]
	public abstract class DBComponent<T1, T2> : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06009275 RID: 37493
		[Token(Token = "0x17000F8D")]
		protected abstract string dataURL { [Token(Token = "0x6009275")] get; }

		// Token: 0x06009276 RID: 37494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009276")]
		public Dictionary<T1, T2> GetData()
		{
			return null;
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009277")]
		private Dictionary<T1, T2> _InitData()
		{
			return null;
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009278")]
		protected DBComponent()
		{
		}

		// Token: 0x0400882B RID: 34859
		[Token(Token = "0x400882B")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T1, T2> cacheData;

		// Token: 0x0400882C RID: 34860
		[Token(Token = "0x400882C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x0400882D RID: 34861
		[Token(Token = "0x400882D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0400882E RID: 34862
		[Token(Token = "0x400882E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
