using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BA5 RID: 11173
	[Token(Token = "0x2002BA5")]
	[Obsolete]
	public class MhwrbgSkill_1 : AbstractAnimatedAbility
	{
		// Token: 0x06012D77 RID: 77175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D77")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012D78 RID: 77176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D78")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012D79 RID: 77177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D79")]
		[Address(RVA = "0xAC49A0", Offset = "0xAC35A0", VA = "0x180AC49A0", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012D7A RID: 77178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D7A")]
		[Address(RVA = "0xAC4F60", Offset = "0xAC3B60", VA = "0x180AC4F60", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012D7B RID: 77179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D7B")]
		[Address(RVA = "0xAC4A40", Offset = "0xAC3640", VA = "0x180AC4A40", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012D7C RID: 77180 RVA: 0x00073650 File Offset: 0x00071850
		[Token(Token = "0x6012D7C")]
		[Address(RVA = "0xAC5000", Offset = "0xAC3C00", VA = "0x180AC5000")]
		private bool _TryDrawCardToHand(Deck deck, out Deck.Card target)
		{
			return default(bool);
		}

		// Token: 0x06012D7D RID: 77181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D7D")]
		[Address(RVA = "0xAC5190", Offset = "0xAC3D90", VA = "0x180AC5190")]
		public MhwrbgSkill_1()
		{
		}

		// Token: 0x0401542F RID: 87087
		[Token(Token = "0x401542F")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("Special")]
		private string _cardId;

		// Token: 0x04015430 RID: 87088
		[Token(Token = "0x4015430")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("Special")]
		private string _cardBuffKey;

		// Token: 0x04015431 RID: 87089
		[Token(Token = "0x4015431")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("Special")]
		private Deck.Card.CardBuff.LifeType _lifeType;

		// Token: 0x04015432 RID: 87090
		[Token(Token = "0x4015432")]
		[FieldOffset(Offset = "0x1E0")]
		private Deck.Card m_targetCard;

		// Token: 0x04015433 RID: 87091
		[Token(Token = "0x4015433")]
		[FieldOffset(Offset = "0x1E8")]
		private Deck m_deck;
	}
}
