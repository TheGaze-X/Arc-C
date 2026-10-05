using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057E1 RID: 22497
	[Token(Token = "0x20057E1")]
	public class RoguelikeInitMonthTag : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020E6D RID: 134765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E6D")]
		[Address(RVA = "0x1B3CBD0", Offset = "0x1B3B7D0", VA = "0x181B3CBD0")]
		public void Render(RoguelikeTopicMonthSquad squad)
		{
		}

		// Token: 0x06020E6E RID: 134766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E6E")]
		[Address(RVA = "0x1B3CCD0", Offset = "0x1B3B8D0", VA = "0x181B3CCD0")]
		public RoguelikeInitMonthTag()
		{
		}

		// Token: 0x0402CB56 RID: 183126
		[Token(Token = "0x402CB56")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _bg;

		// Token: 0x0402CB57 RID: 183127
		[Token(Token = "0x402CB57")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _icon;

		// Token: 0x0402CB58 RID: 183128
		[Token(Token = "0x402CB58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _label;

		// Token: 0x0402CB59 RID: 183129
		[Token(Token = "0x402CB59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CB5A RID: 183130
		[Token(Token = "0x402CB5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
