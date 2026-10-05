using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm
{
	// Token: 0x02004013 RID: 16403
	[Token(Token = "0x2004013")]
	public abstract class ZoneHomeSandboxPermTodoPluginBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601967B RID: 104059
		[Token(Token = "0x601967B")]
		public abstract void Render(ZoneHomeSandboxPermToDoPluginBaseModel baseModel);

		// Token: 0x0601967C RID: 104060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601967C")]
		[Address(RVA = "0x1229D90", Offset = "0x1228990", VA = "0x181229D90")]
		protected ZoneHomeSandboxPermTodoPluginBase()
		{
		}

		// Token: 0x0401F9A4 RID: 129444
		[Token(Token = "0x401F9A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
