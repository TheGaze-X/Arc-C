using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x02005898 RID: 22680
	[Token(Token = "0x2005898")]
	public abstract class RoguelikeAbstractCopperItemCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004DB1 RID: 19889
		// (get) Token: 0x060211B2 RID: 135602
		[Token(Token = "0x17004DB1")]
		public abstract UIColorGraphic graphic { [Token(Token = "0x60211B2")] get; }

		// Token: 0x060211B3 RID: 135603
		[Token(Token = "0x60211B3")]
		public abstract void Render(ILoadAsset assetLoader, IRoguelikeCopperItemModel model, float itemScale = 1f, bool showGildIcon = true, bool showLuckyIcon = false);

		// Token: 0x060211B4 RID: 135604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211B4")]
		[Address(RVA = "0x1B7AA70", Offset = "0x1B79670", VA = "0x181B7AA70")]
		protected RoguelikeAbstractCopperItemCard()
		{
		}

		// Token: 0x0402D137 RID: 184631
		[Token(Token = "0x402D137")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
