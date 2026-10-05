using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004044 RID: 16452
	[Token(Token = "0x2004044")]
	public abstract class SandboxV2AdminCharSelectAbstractRightItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601974B RID: 104267
		[Token(Token = "0x601974B")]
		public abstract void RenderView(int pos, SandboxV2CharViewModel charViewModel);

		// Token: 0x0601974C RID: 104268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601974C")]
		[Address(RVA = "0x122AAC0", Offset = "0x12296C0", VA = "0x18122AAC0")]
		protected SandboxV2AdminCharSelectAbstractRightItemView()
		{
		}

		// Token: 0x0401FB44 RID: 129860
		[Token(Token = "0x401FB44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004045 RID: 16453
		[Token(Token = "0x2004045")]
		public abstract class IVirtualView : UIRecycleLayoutAdapter.VirtualView<SandboxV2AdminCharSelectAbstractRightItemView>
		{
			// Token: 0x0601974D RID: 104269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601974D")]
			[Address(RVA = "0x122A0F0", Offset = "0x1228CF0", VA = "0x18122A0F0")]
			protected IVirtualView()
			{
			}

			// Token: 0x0401FB45 RID: 129861
			[Token(Token = "0x401FB45")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
