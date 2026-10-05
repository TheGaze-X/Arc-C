using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004046 RID: 16454
	[Token(Token = "0x2004046")]
	public abstract class SandboxV2AdminCharAbstractShuffleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601974E RID: 104270
		[Token(Token = "0x601974E")]
		public abstract void OnApplyShuffleViewModel(SandboxV2CharListViewModel viewModel);

		// Token: 0x0601974F RID: 104271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601974F")]
		[Address(RVA = "0x122A9A0", Offset = "0x12295A0", VA = "0x18122A9A0")]
		protected SandboxV2AdminCharAbstractShuffleView()
		{
		}

		// Token: 0x0401FB46 RID: 129862
		[Token(Token = "0x401FB46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
