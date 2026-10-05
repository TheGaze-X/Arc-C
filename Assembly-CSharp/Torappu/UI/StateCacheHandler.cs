using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200365C RID: 13916
	[Token(Token = "0x200365C")]
	public class StateCacheHandler<BundleType> : IStateCacheHandler
	{
		// Token: 0x06016243 RID: 90691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016243")]
		public object Save()
		{
			return null;
		}

		// Token: 0x06016244 RID: 90692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016244")]
		public void Load(object bundle)
		{
		}

		// Token: 0x06016245 RID: 90693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016245")]
		public StateCacheHandler()
		{
		}

		// Token: 0x0401A9DB RID: 109019
		[Token(Token = "0x401A9DB")]
		[FieldOffset(Offset = "0x0")]
		public Func<BundleType> onSave;

		// Token: 0x0401A9DC RID: 109020
		[Token(Token = "0x401A9DC")]
		[FieldOffset(Offset = "0x0")]
		public Action<BundleType> onLoad;
	}
}
