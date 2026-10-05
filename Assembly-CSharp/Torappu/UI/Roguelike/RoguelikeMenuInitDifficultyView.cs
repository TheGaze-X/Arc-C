using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005321 RID: 21281
	[Token(Token = "0x2005321")]
	public class RoguelikeMenuInitDifficultyView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F658 RID: 128600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F658")]
		[Address(RVA = "0x1911020", Offset = "0x190FC20", VA = "0x181911020")]
		public void Render(RoguelikeMenuRelicViewModel model)
		{
		}

		// Token: 0x0601F659 RID: 128601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F659")]
		[Address(RVA = "0x19111C0", Offset = "0x190FDC0", VA = "0x1819111C0")]
		public RoguelikeMenuInitDifficultyView()
		{
		}

		// Token: 0x0402A35B RID: 172891
		[Token(Token = "0x402A35B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _diffName;

		// Token: 0x0402A35C RID: 172892
		[Token(Token = "0x402A35C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _diffLevel;

		// Token: 0x0402A35D RID: 172893
		[Token(Token = "0x402A35D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A35E RID: 172894
		[Token(Token = "0x402A35E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
