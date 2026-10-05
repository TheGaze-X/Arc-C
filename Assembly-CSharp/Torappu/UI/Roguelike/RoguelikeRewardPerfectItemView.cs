using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053F3 RID: 21491
	[Token(Token = "0x20053F3")]
	public class RoguelikeRewardPerfectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F9F0 RID: 129520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9F0")]
		[Address(RVA = "0x195B8A0", Offset = "0x195A4A0", VA = "0x18195B8A0")]
		public void Render(int perfectChain)
		{
		}

		// Token: 0x0601F9F1 RID: 129521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9F1")]
		[Address(RVA = "0x195B970", Offset = "0x195A570", VA = "0x18195B970")]
		public RoguelikeRewardPerfectItemView()
		{
		}

		// Token: 0x0402A990 RID: 174480
		[Token(Token = "0x402A990")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtPerfectChain;

		// Token: 0x0402A991 RID: 174481
		[Token(Token = "0x402A991")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A992 RID: 174482
		[Token(Token = "0x402A992")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
