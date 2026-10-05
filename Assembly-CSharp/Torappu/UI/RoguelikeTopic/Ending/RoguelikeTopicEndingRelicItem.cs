using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x0200468C RID: 18060
	[Token(Token = "0x200468C")]
	public class RoguelikeTopicEndingRelicItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B6A1 RID: 112289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6A1")]
		[Address(RVA = "0x14B5B30", Offset = "0x14B4730", VA = "0x1814B5B30")]
		public void Render(RoguelikeTopicItemModel relic, RoguelikeTopicEndingStyle style)
		{
		}

		// Token: 0x0601B6A2 RID: 112290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6A2")]
		[Address(RVA = "0x14B5DB0", Offset = "0x14B49B0", VA = "0x1814B5DB0")]
		public RoguelikeTopicEndingRelicItem()
		{
		}

		// Token: 0x04023747 RID: 145223
		[Token(Token = "0x4023747")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04023748 RID: 145224
		[Token(Token = "0x4023748")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x04023749 RID: 145225
		[Token(Token = "0x4023749")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _unlockDesc;

		// Token: 0x0402374A RID: 145226
		[Token(Token = "0x402374A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402374B RID: 145227
		[Token(Token = "0x402374B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
