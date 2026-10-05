using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005309 RID: 21257
	[Token(Token = "0x2005309")]
	public class RoguelikeMenuSquadSlotView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700498B RID: 18827
		// (get) Token: 0x0601F5C3 RID: 128451 RVA: 0x000B1A50 File Offset: 0x000AFC50
		[Token(Token = "0x1700498B")]
		private SpriteRenderData spriteLocked
		{
			[Token(Token = "0x601F5C3")]
			[Address(RVA = "0x1917170", Offset = "0x1915D70", VA = "0x181917170")]
			get
			{
				return default(SpriteRenderData);
			}
		}

		// Token: 0x1700498C RID: 18828
		// (get) Token: 0x0601F5C4 RID: 128452 RVA: 0x000B1A68 File Offset: 0x000AFC68
		[Token(Token = "0x1700498C")]
		private SpriteRenderData spriteUnlocked
		{
			[Token(Token = "0x601F5C4")]
			[Address(RVA = "0x19172C0", Offset = "0x1915EC0", VA = "0x1819172C0")]
			get
			{
				return default(SpriteRenderData);
			}
		}

		// Token: 0x0601F5C5 RID: 128453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5C5")]
		[Address(RVA = "0x1916BD0", Offset = "0x19157D0", VA = "0x181916BD0")]
		public void Render(RoguelikeMenuSquadSlotViewModel model, Color colorUpgraded)
		{
		}

		// Token: 0x0601F5C6 RID: 128454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F5C6")]
		[Address(RVA = "0x1917060", Offset = "0x1915C60", VA = "0x181917060")]
		public RoguelikeMenuSquadSlotView()
		{
		}

		// Token: 0x0402A245 RID: 172613
		[Token(Token = "0x402A245")]
		[FieldOffset(Offset = "0x0")]
		private static Color _colorLocked;

		// Token: 0x0402A246 RID: 172614
		[Token(Token = "0x402A246")]
		[FieldOffset(Offset = "0x10")]
		private static Color _colorEmpty;

		// Token: 0x0402A247 RID: 172615
		[Token(Token = "0x402A247")]
		[FieldOffset(Offset = "0x20")]
		private static Color _colorNonUpgraded;

		// Token: 0x0402A248 RID: 172616
		[Token(Token = "0x402A248")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _slot;

		// Token: 0x0402A249 RID: 172617
		[Token(Token = "0x402A249")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _spriteObject;

		// Token: 0x0402A24A RID: 172618
		[Token(Token = "0x402A24A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _spriteLockedName;

		// Token: 0x0402A24B RID: 172619
		[Token(Token = "0x402A24B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _spriteUnlockedName;

		// Token: 0x0402A24C RID: 172620
		[Token(Token = "0x402A24C")]
		[FieldOffset(Offset = "0x38")]
		private SpriteRenderData m_spriteLocked;

		// Token: 0x0402A24D RID: 172621
		[Token(Token = "0x402A24D")]
		[FieldOffset(Offset = "0x78")]
		private SpriteRenderData m_spriteUnlocked;

		// Token: 0x0402A24E RID: 172622
		[Token(Token = "0x402A24E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_spriteLocked;

		// Token: 0x0402A24F RID: 172623
		[Token(Token = "0x402A24F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_spriteUnlocked;

		// Token: 0x0402A250 RID: 172624
		[Token(Token = "0x402A250")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A251 RID: 172625
		[Token(Token = "0x402A251")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
