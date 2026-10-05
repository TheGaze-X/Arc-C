using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200249A RID: 9370
	[Token(Token = "0x200249A")]
	public class OnlyEffectCardTalent : CardHoldTalent
	{
		// Token: 0x0600F0F4 RID: 61684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F0F4")]
		[Address(RVA = "0x6935F0", Offset = "0x6921F0", VA = "0x1806935F0", Slot = "33")]
		public override CardHoldTalent.CardHoldDataModifier CreateHoldDataModifier(Character character)
		{
			return null;
		}

		// Token: 0x0600F0F5 RID: 61685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F0F5")]
		[Address(RVA = "0x693450", Offset = "0x692050", VA = "0x180693450", Slot = "34")]
		public override UICardEffectHolder.CardEffectPlugin CreateCardEffectPlugin(Character character, CardHoldTalent.CardHoldDataModifier modifier)
		{
			return null;
		}

		// Token: 0x0600F0F6 RID: 61686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0F6")]
		[Address(RVA = "0x6936D0", Offset = "0x6922D0", VA = "0x1806936D0")]
		public OnlyEffectCardTalent()
		{
		}

		// Token: 0x04010A94 RID: 68244
		[Token(Token = "0x4010A94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateHoldDataModifier;

		// Token: 0x04010A95 RID: 68245
		[Token(Token = "0x4010A95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateCardEffectPlugin;

		// Token: 0x04010A96 RID: 68246
		[Token(Token = "0x4010A96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200249B RID: 9371
		[Token(Token = "0x200249B")]
		public class OnlyEffectCardTalentModifier : CardHoldTalent.CardHoldDataModifier
		{
			// Token: 0x0600F0F7 RID: 61687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F0F7")]
			[Address(RVA = "0x693370", Offset = "0x691F70", VA = "0x180693370", Slot = "5")]
			public override void OnTick(Deck.Card card, FP deltaTime)
			{
			}

			// Token: 0x0600F0F8 RID: 61688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F0F8")]
			[Address(RVA = "0x6933F0", Offset = "0x691FF0", VA = "0x1806933F0")]
			public OnlyEffectCardTalentModifier()
			{
			}

			// Token: 0x04010A97 RID: 68247
			[Token(Token = "0x4010A97")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04010A98 RID: 68248
			[Token(Token = "0x4010A98")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200249C RID: 9372
		[Token(Token = "0x200249C")]
		public class OnlyEffectCardTalentEffectPlugin : UICardEffectHolder.CardEffectPlugin
		{
			// Token: 0x0600F0F9 RID: 61689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F0F9")]
			[Address(RVA = "0x693300", Offset = "0x691F00", VA = "0x180693300")]
			public OnlyEffectCardTalentEffectPlugin(RectTransform pluginPrefab)
			{
			}

			// Token: 0x04010A99 RID: 68249
			[Token(Token = "0x4010A99")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
