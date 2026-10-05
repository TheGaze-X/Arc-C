using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x020057AC RID: 22444
	[Token(Token = "0x20057AC")]
	public class RL02VariationTagView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020D41 RID: 134465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D41")]
		[Address(RVA = "0x1B2A6A0", Offset = "0x1B292A0", VA = "0x181B2A6A0")]
		public void Render(string topicId, string variationId)
		{
		}

		// Token: 0x06020D42 RID: 134466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D42")]
		[Address(RVA = "0x1B2A850", Offset = "0x1B29450", VA = "0x181B2A850")]
		public RL02VariationTagView()
		{
		}

		// Token: 0x0402C9AE RID: 182702
		[Token(Token = "0x402C9AE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgVariation;

		// Token: 0x0402C9AF RID: 182703
		[Token(Token = "0x402C9AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C9B0 RID: 182704
		[Token(Token = "0x402C9B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
