using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C82 RID: 19586
	[Token(Token = "0x2004C82")]
	public abstract class OpenServerMainAbstractView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D5DC RID: 120284
		[Token(Token = "0x601D5DC")]
		public abstract void Render();

		// Token: 0x0601D5DD RID: 120285
		[Token(Token = "0x601D5DD")]
		public abstract void UpdateWithType(OpenServerFuncType funcType);

		// Token: 0x0601D5DE RID: 120286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5DE")]
		[Address(RVA = "0x16EB260", Offset = "0x16E9E60", VA = "0x1816EB260")]
		protected OpenServerMainAbstractView()
		{
		}

		// Token: 0x04026A5E RID: 158302
		[Token(Token = "0x4026A5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
