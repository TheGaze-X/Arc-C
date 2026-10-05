using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BB0 RID: 11184
	[Token(Token = "0x2002BB0")]
	public class RandomlyRebuildDeckCardsAbility : AnimatedActionToTargetAbility
	{
		// Token: 0x06012DD3 RID: 77267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DD3")]
		[Address(RVA = "0xACA530", Offset = "0xAC9130", VA = "0x180ACA530", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012DD4 RID: 77268 RVA: 0x00073890 File Offset: 0x00071A90
		[Token(Token = "0x6012DD4")]
		[Address(RVA = "0xACA800", Offset = "0xAC9400", VA = "0x180ACA800", Slot = "78")]
		protected override bool OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012DD5 RID: 77269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DD5")]
		[Address(RVA = "0xACA870", Offset = "0xAC9470", VA = "0x180ACA870", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012DD6 RID: 77270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DD6")]
		[Address(RVA = "0xACA630", Offset = "0xAC9230", VA = "0x180ACA630", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012DD7 RID: 77271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DD7")]
		[Address(RVA = "0xACA720", Offset = "0xAC9320", VA = "0x180ACA720", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012DD8 RID: 77272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DD8")]
		[Address(RVA = "0xACA960", Offset = "0xAC9560", VA = "0x180ACA960")]
		private void _CollectDeckCards()
		{
		}

		// Token: 0x06012DD9 RID: 77273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DD9")]
		[Address(RVA = "0xACAB90", Offset = "0xAC9790", VA = "0x180ACAB90")]
		private void _RebuildDeckCards()
		{
		}

		// Token: 0x06012DDA RID: 77274 RVA: 0x000738A8 File Offset: 0x00071AA8
		[Token(Token = "0x6012DDA")]
		[Address(RVA = "0xACAE60", Offset = "0xAC9A60", VA = "0x180ACAE60")]
		private bool _TryBuildCard(Deck.Card card, Deck deck)
		{
			return default(bool);
		}

		// Token: 0x06012DDB RID: 77275 RVA: 0x000738C0 File Offset: 0x00071AC0
		[Token(Token = "0x6012DDB")]
		[Address(RVA = "0xACB1B0", Offset = "0xAC9DB0", VA = "0x180ACB1B0")]
		private bool _TryGetValidBuildTile(Deck.Card card, out Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06012DDC RID: 77276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DDC")]
		[Address(RVA = "0xACB380", Offset = "0xAC9F80", VA = "0x180ACB380")]
		public RandomlyRebuildDeckCardsAbility()
		{
		}

		// Token: 0x06012DDD RID: 77277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DDD")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012DDE RID: 77278 RVA: 0x000738D8 File Offset: 0x00071AD8
		[Token(Token = "0x6012DDE")]
		[Address(RVA = "0xA1EDF0", Offset = "0xA1D9F0", VA = "0x180A1EDF0")]
		private bool <>xLuaBaseProxy_OnSpellStart()
		{
			return default(bool);
		}

		// Token: 0x06012DDF RID: 77279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DDF")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012DE0 RID: 77280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DE0")]
		[Address(RVA = "0xA1E520", Offset = "0xA1D120", VA = "0x180A1E520")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012DE1 RID: 77281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DE1")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x040154A2 RID: 87202
		[Token(Token = "0x40154A2")]
		[FieldOffset(Offset = "0x1D8")]
		private List<Deck.Card> m_characters;

		// Token: 0x040154A3 RID: 87203
		[Token(Token = "0x40154A3")]
		[FieldOffset(Offset = "0x1E0")]
		private ListDict<Deck.Card, int> m_traps;

		// Token: 0x040154A4 RID: 87204
		[Token(Token = "0x40154A4")]
		[FieldOffset(Offset = "0x1E8")]
		private PeriodicTimer m_rebuildTimer;

		// Token: 0x040154A5 RID: 87205
		[Token(Token = "0x40154A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040154A6 RID: 87206
		[Token(Token = "0x40154A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSpellStart;

		// Token: 0x040154A7 RID: 87207
		[Token(Token = "0x40154A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040154A8 RID: 87208
		[Token(Token = "0x40154A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x040154A9 RID: 87209
		[Token(Token = "0x40154A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040154AA RID: 87210
		[Token(Token = "0x40154AA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CollectDeckCards;

		// Token: 0x040154AB RID: 87211
		[Token(Token = "0x40154AB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RebuildDeckCards;

		// Token: 0x040154AC RID: 87212
		[Token(Token = "0x40154AC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryBuildCard;

		// Token: 0x040154AD RID: 87213
		[Token(Token = "0x40154AD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryGetValidBuildTile;

		// Token: 0x040154AE RID: 87214
		[Token(Token = "0x40154AE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
