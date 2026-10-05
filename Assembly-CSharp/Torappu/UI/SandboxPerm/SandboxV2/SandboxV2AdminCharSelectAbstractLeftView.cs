using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004042 RID: 16450
	[Token(Token = "0x2004042")]
	public abstract class SandboxV2AdminCharSelectAbstractLeftView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019745 RID: 104261
		[Token(Token = "0x6019745")]
		public abstract void RenderView(SandboxV2CharListViewModel charListViewModel, SandboxV2CharSelectTabEnum tabEnum);

		// Token: 0x06019746 RID: 104262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019746")]
		[Address(RVA = "0x122AA00", Offset = "0x1229600", VA = "0x18122AA00")]
		protected SandboxV2AdminCharSelectAbstractLeftView()
		{
		}

		// Token: 0x0401FB42 RID: 129858
		[Token(Token = "0x401FB42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
