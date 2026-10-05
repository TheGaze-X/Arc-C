using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200695F RID: 26975
	[Token(Token = "0x200695F")]
	public abstract class StageFogOnButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x060269BE RID: 158142
		[Token(Token = "0x60269BE")]
		public abstract void Render(StageFogInfo stageFogInfo);

		// Token: 0x060269BF RID: 158143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269BF")]
		[Address(RVA = "0x21ABA00", Offset = "0x21AA600", VA = "0x1821ABA00")]
		protected StageFogOnButton()
		{
		}

		// Token: 0x040367A4 RID: 223140
		[Token(Token = "0x40367A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
