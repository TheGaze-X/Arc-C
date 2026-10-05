using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005556 RID: 21846
	[Token(Token = "0x2005556")]
	public class RL01TransitionVariationTagView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060201F3 RID: 131571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201F3")]
		[Address(RVA = "0x1A31480", Offset = "0x1A30080", VA = "0x181A31480")]
		public void Render(string topicId, string variationId)
		{
		}

		// Token: 0x060201F4 RID: 131572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201F4")]
		[Address(RVA = "0x1A31620", Offset = "0x1A30220", VA = "0x181A31620")]
		public RL01TransitionVariationTagView()
		{
		}

		// Token: 0x0402B64F RID: 177743
		[Token(Token = "0x402B64F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textVariation;

		// Token: 0x0402B650 RID: 177744
		[Token(Token = "0x402B650")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B651 RID: 177745
		[Token(Token = "0x402B651")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
