using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004047 RID: 16455
	[Token(Token = "0x2004047")]
	public abstract class SandboxV2AdminCharAbstractEnsureView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019750 RID: 104272
		[Token(Token = "0x6019750")]
		public abstract void OnUpdateData(SandboxV2CharListViewModel viewModel);

		// Token: 0x06019751 RID: 104273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019751")]
		[Address(RVA = "0x122A940", Offset = "0x1229540", VA = "0x18122A940")]
		protected SandboxV2AdminCharAbstractEnsureView()
		{
		}

		// Token: 0x0401FB47 RID: 129863
		[Token(Token = "0x401FB47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
