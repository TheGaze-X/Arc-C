using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AFC RID: 27388
	[Token(Token = "0x2006AFC")]
	public abstract class ArchiveEntryButtonBasePlugin : MonoBehaviour, ActArchivePlugin.IActArchiveButtonViewPlugin, IHotfixable
	{
		// Token: 0x0602729B RID: 160411
		[Token(Token = "0x602729B")]
		public abstract void ApplyData(ActArchiveCompInfo data);

		// Token: 0x0602729C RID: 160412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602729C")]
		[Address(RVA = "0x2257650", Offset = "0x2256250", VA = "0x182257650")]
		protected ArchiveEntryButtonBasePlugin()
		{
		}

		// Token: 0x04037667 RID: 226919
		[Token(Token = "0x4037667")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
