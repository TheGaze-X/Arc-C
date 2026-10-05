using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028AF RID: 10415
	[Token(Token = "0x20028AF")]
	public class CardBuffWithSkill : BasicSkill.Behaviour
	{
		// Token: 0x0601151E RID: 70942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601151E")]
		[Address(RVA = "0x91E3C0", Offset = "0x91CFC0", VA = "0x18091E3C0", Slot = "13")]
		public override void DealAttachInDummy(Deck deck, Deck.Card card)
		{
		}

		// Token: 0x0601151F RID: 70943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601151F")]
		[Address(RVA = "0x91E5E0", Offset = "0x91D1E0", VA = "0x18091E5E0")]
		public CardBuffWithSkill()
		{
		}

		// Token: 0x06011520 RID: 70944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011520")]
		[Address(RVA = "0x91E5D0", Offset = "0x91D1D0", VA = "0x18091E5D0")]
		private void <>xLuaBaseProxy_DealAttachInDummy(Deck P0, Deck.Card P1)
		{
		}

		// Token: 0x0401359C RID: 79260
		[Token(Token = "0x401359C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _cardBuffKey;

		// Token: 0x0401359D RID: 79261
		[Token(Token = "0x401359D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Deck.Card.CardBuff.LifeType _lifeType;

		// Token: 0x0401359E RID: 79262
		[Token(Token = "0x401359E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _dontOccupyDeployCnt;

		// Token: 0x0401359F RID: 79263
		[Token(Token = "0x401359F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildableType _additionBuildableType;

		// Token: 0x040135A0 RID: 79264
		[Token(Token = "0x40135A0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private AdvancedBuildableMask _additionalBuildableMask;

		// Token: 0x040135A1 RID: 79265
		[Token(Token = "0x40135A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DealAttachInDummy;

		// Token: 0x040135A2 RID: 79266
		[Token(Token = "0x40135A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
