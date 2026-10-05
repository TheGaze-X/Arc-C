using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044F3 RID: 17651
	[Token(Token = "0x20044F3")]
	public class RoguelikeCommonOuterBuffBottomDescItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF1B RID: 110363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF1B")]
		[Address(RVA = "0x1418860", Offset = "0x1417460", VA = "0x181418860")]
		public void Render(string desc)
		{
		}

		// Token: 0x0601AF1C RID: 110364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF1C")]
		[Address(RVA = "0x1418940", Offset = "0x1417540", VA = "0x181418940")]
		public RoguelikeCommonOuterBuffBottomDescItemView()
		{
		}

		// Token: 0x04022909 RID: 141577
		[Token(Token = "0x4022909")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402290A RID: 141578
		[Token(Token = "0x402290A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402290B RID: 141579
		[Token(Token = "0x402290B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
