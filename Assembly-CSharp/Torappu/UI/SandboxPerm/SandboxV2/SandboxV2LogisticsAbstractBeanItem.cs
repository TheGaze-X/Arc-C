using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004339 RID: 17209
	[Token(Token = "0x2004339")]
	public abstract class SandboxV2LogisticsAbstractBeanItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A702 RID: 108290
		[Token(Token = "0x601A702")]
		public abstract void Render(bool enabledItem);

		// Token: 0x0601A703 RID: 108291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A703")]
		[Address(RVA = "0x13860D0", Offset = "0x1384CD0", VA = "0x1813860D0")]
		protected SandboxV2LogisticsAbstractBeanItem()
		{
		}

		// Token: 0x04021984 RID: 137604
		[Token(Token = "0x4021984")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
