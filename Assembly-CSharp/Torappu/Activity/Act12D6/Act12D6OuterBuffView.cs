using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AF7 RID: 31479
	[Token(Token = "0x2007AF7")]
	public class Act12D6OuterBuffView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C14E RID: 180558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C14E")]
		[Address(RVA = "0x27F5910", Offset = "0x27F4510", VA = "0x1827F5910")]
		public void Render(Act12D6OuterBuffStateBean stateBean)
		{
		}

		// Token: 0x0602C14F RID: 180559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C14F")]
		[Address(RVA = "0x27F59B0", Offset = "0x27F45B0", VA = "0x1827F59B0")]
		public Act12D6OuterBuffView()
		{
		}

		// Token: 0x0403FE20 RID: 261664
		[Token(Token = "0x403FE20")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act12D6OuterBuffAdapter _outerBuffAdapter;

		// Token: 0x0403FE21 RID: 261665
		[Token(Token = "0x403FE21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FE22 RID: 261666
		[Token(Token = "0x403FE22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
