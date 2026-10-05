using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C89 RID: 19593
	[Token(Token = "0x2004C89")]
	public abstract class OpenServerV2FuncAbstractView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D5F3 RID: 120307
		[Token(Token = "0x601D5F3")]
		public abstract void Render(OpenServerV2MainViewModel viewModel, bool isInit);

		// Token: 0x0601D5F4 RID: 120308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5F4")]
		[Address(RVA = "0x16EF190", Offset = "0x16EDD90", VA = "0x1816EF190")]
		protected OpenServerV2FuncAbstractView()
		{
		}

		// Token: 0x04026A97 RID: 158359
		[Token(Token = "0x4026A97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
