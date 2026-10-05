using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B92 RID: 11154
	[Token(Token = "0x2002B92")]
	public abstract class CharacterMenuRelativeAbility : PassiveBuffAbility
	{
		// Token: 0x06012C62 RID: 76898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C62")]
		[Address(RVA = "0xAB50F0", Offset = "0xAB3CF0", VA = "0x180AB50F0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012C63 RID: 76899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C63")]
		[Address(RVA = "0xAB4CE0", Offset = "0xAB38E0", VA = "0x180AB4CE0", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012C64 RID: 76900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C64")]
		[Address(RVA = "0xAB4EF0", Offset = "0xAB3AF0", VA = "0x180AB4EF0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012C65 RID: 76901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C65")]
		[Address(RVA = "0xAB53A0", Offset = "0xAB3FA0", VA = "0x180AB53A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06012C66 RID: 76902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C66")]
		[Address(RVA = "0xAB5400", Offset = "0xAB4000", VA = "0x180AB5400", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012C67 RID: 76903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C67")]
		[Address(RVA = "0xAABBA0", Offset = "0xAAA7A0", VA = "0x180AABBA0", Slot = "96")]
		protected virtual void FilterCandidateCards(Deck cardDeck, HashSet<Deck.Card> validCards)
		{
		}

		// Token: 0x06012C68 RID: 76904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C68")]
		[Address(RVA = "0xAB58D0", Offset = "0xAB44D0", VA = "0x180AB58D0")]
		private void _TryUpdateCardEffectPluginOfCards()
		{
		}

		// Token: 0x06012C69 RID: 76905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C69")]
		[Address(RVA = "0xAB5BB0", Offset = "0xAB47B0", VA = "0x180AB5BB0")]
		private void _UpdateCardEffectPlugin(Deck cardDeck)
		{
		}

		// Token: 0x06012C6A RID: 76906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C6A")]
		[Address(RVA = "0xAB5580", Offset = "0xAB4180", VA = "0x180AB5580")]
		private void _ClearCardEffectPlugins()
		{
		}

		// Token: 0x06012C6B RID: 76907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C6B")]
		[Address(RVA = "0xAB5730", Offset = "0xAB4330", VA = "0x180AB5730")]
		private void _RegisterEvent()
		{
		}

		// Token: 0x06012C6C RID: 76908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C6C")]
		[Address(RVA = "0xAB5A10", Offset = "0xAB4610", VA = "0x180AB5A10")]
		private void _UnregisterEvent()
		{
		}

		// Token: 0x06012C6D RID: 76909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C6D")]
		[Address(RVA = "0xAB5270", Offset = "0xAB3E70", VA = "0x180AB5270", Slot = "97")]
		protected virtual void OnCharacterMenuShow(object characterObj)
		{
		}

		// Token: 0x06012C6E RID: 76910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C6E")]
		[Address(RVA = "0xAB5200", Offset = "0xAB3E00", VA = "0x180AB5200", Slot = "98")]
		protected virtual void OnCharacterMenuHide(object paramObj)
		{
		}

		// Token: 0x06012C6F RID: 76911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C6F")]
		[Address(RVA = "0xAB5500", Offset = "0xAB4100", VA = "0x180AB5500")]
		protected void ResetContent()
		{
		}

		// Token: 0x06012C70 RID: 76912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C70")]
		[Address(RVA = "0xAB60A0", Offset = "0xAB4CA0", VA = "0x180AB60A0")]
		protected CharacterMenuRelativeAbility()
		{
		}

		// Token: 0x06012C71 RID: 76913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C71")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012C72 RID: 76914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C72")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012C73 RID: 76915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C73")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012C74 RID: 76916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C74")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015354 RID: 86868
		[Token(Token = "0x4015354")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _cardEffectPluginName;

		// Token: 0x04015355 RID: 86869
		[Token(Token = "0x4015355")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _interval;

		// Token: 0x04015356 RID: 86870
		[Token(Token = "0x4015356")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private bool _onlyWorkWhenSelectedCharacterIsOwner;

		// Token: 0x04015357 RID: 86871
		[Token(Token = "0x4015357")]
		[FieldOffset(Offset = "0x125")]
		protected bool m_isCharacterMenuShowing;

		// Token: 0x04015358 RID: 86872
		[Token(Token = "0x4015358")]
		[FieldOffset(Offset = "0x128")]
		protected HashSet<Deck.Card> m_validCards;

		// Token: 0x04015359 RID: 86873
		[Token(Token = "0x4015359")]
		[FieldOffset(Offset = "0x130")]
		protected Character m_character;

		// Token: 0x0401535A RID: 86874
		[Token(Token = "0x401535A")]
		[FieldOffset(Offset = "0x138")]
		private Dictionary<Deck.Card, RectTransform> m_cardEffectPluginsMap;

		// Token: 0x0401535B RID: 86875
		[Token(Token = "0x401535B")]
		[FieldOffset(Offset = "0x140")]
		private List<Deck.Card> m_dictionaryKeys;

		// Token: 0x0401535C RID: 86876
		[Token(Token = "0x401535C")]
		[FieldOffset(Offset = "0x148")]
		private PeriodicTimer m_intervalTimer;

		// Token: 0x0401535D RID: 86877
		[Token(Token = "0x401535D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401535E RID: 86878
		[Token(Token = "0x401535E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401535F RID: 86879
		[Token(Token = "0x401535F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04015360 RID: 86880
		[Token(Token = "0x4015360")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04015361 RID: 86881
		[Token(Token = "0x4015361")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015362 RID: 86882
		[Token(Token = "0x4015362")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FilterCandidateCards;

		// Token: 0x04015363 RID: 86883
		[Token(Token = "0x4015363")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryUpdateCardEffectPluginOfCards;

		// Token: 0x04015364 RID: 86884
		[Token(Token = "0x4015364")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateCardEffectPlugin;

		// Token: 0x04015365 RID: 86885
		[Token(Token = "0x4015365")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearCardEffectPlugins;

		// Token: 0x04015366 RID: 86886
		[Token(Token = "0x4015366")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RegisterEvent;

		// Token: 0x04015367 RID: 86887
		[Token(Token = "0x4015367")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UnregisterEvent;

		// Token: 0x04015368 RID: 86888
		[Token(Token = "0x4015368")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuShow;

		// Token: 0x04015369 RID: 86889
		[Token(Token = "0x4015369")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuHide;

		// Token: 0x0401536A RID: 86890
		[Token(Token = "0x401536A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ResetContent;

		// Token: 0x0401536B RID: 86891
		[Token(Token = "0x401536B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
