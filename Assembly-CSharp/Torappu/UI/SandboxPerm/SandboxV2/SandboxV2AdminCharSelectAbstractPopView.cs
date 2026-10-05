using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004043 RID: 16451
	[Token(Token = "0x2004043")]
	public abstract class SandboxV2AdminCharSelectAbstractPopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019747 RID: 104263
		[Token(Token = "0x6019747")]
		public abstract SandboxV2AdminCharSelectStateMode GetStateMode();

		// Token: 0x06019748 RID: 104264
		[Token(Token = "0x6019748")]
		public abstract void Show(SandboxV2CharListViewModel charListViewModel);

		// Token: 0x06019749 RID: 104265
		[Token(Token = "0x6019749")]
		public abstract void Hide();

		// Token: 0x0601974A RID: 104266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601974A")]
		[Address(RVA = "0x122AA60", Offset = "0x1229660", VA = "0x18122AA60")]
		protected SandboxV2AdminCharSelectAbstractPopView()
		{
		}

		// Token: 0x0401FB43 RID: 129859
		[Token(Token = "0x401FB43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
