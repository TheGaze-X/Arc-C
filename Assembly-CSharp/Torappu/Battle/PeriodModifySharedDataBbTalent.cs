using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200249D RID: 9373
	[Token(Token = "0x200249D")]
	public class PeriodModifySharedDataBbTalent : CardHoldTalent
	{
		// Token: 0x0600F0FA RID: 61690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F0FA")]
		[Address(RVA = "0x693730", Offset = "0x692330", VA = "0x180693730", Slot = "34")]
		public override UICardEffectHolder.CardEffectPlugin CreateCardEffectPlugin(Character character, CardHoldTalent.CardHoldDataModifier modifier)
		{
			return null;
		}

		// Token: 0x0600F0FB RID: 61691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F0FB")]
		[Address(RVA = "0x6939E0", Offset = "0x6925E0", VA = "0x1806939E0", Slot = "33")]
		public override CardHoldTalent.CardHoldDataModifier CreateHoldDataModifier(Character character)
		{
			return null;
		}

		// Token: 0x0600F0FC RID: 61692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0FC")]
		[Address(RVA = "0x693DF0", Offset = "0x6929F0", VA = "0x180693DF0")]
		public PeriodModifySharedDataBbTalent()
		{
		}

		// Token: 0x04010A9A RID: 68250
		[Token(Token = "0x4010A9A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _period;

		// Token: 0x04010A9B RID: 68251
		[Token(Token = "0x4010A9B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _valueKey;

		// Token: 0x04010A9C RID: 68252
		[Token(Token = "0x4010A9C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _addKey;

		// Token: 0x04010A9D RID: 68253
		[Token(Token = "0x4010A9D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _maxKey;

		// Token: 0x04010A9E RID: 68254
		[Token(Token = "0x4010A9E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _initKey;

		// Token: 0x04010A9F RID: 68255
		[Token(Token = "0x4010A9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateCardEffectPlugin;

		// Token: 0x04010AA0 RID: 68256
		[Token(Token = "0x4010AA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateHoldDataModifier;

		// Token: 0x04010AA1 RID: 68257
		[Token(Token = "0x4010AA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200249E RID: 9374
		[Token(Token = "0x200249E")]
		public class SharedDataBbModifier : CardHoldTalent.CardHoldDataModifier
		{
			// Token: 0x17001F4D RID: 8013
			// (get) Token: 0x0600F0FD RID: 61693 RVA: 0x00058C38 File Offset: 0x00056E38
			// (set) Token: 0x0600F0FE RID: 61694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001F4D")]
			public float valueRatio
			{
				[Token(Token = "0x600F0FD")]
				[Address(RVA = "0x696870", Offset = "0x695470", VA = "0x180696870")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600F0FE")]
				[Address(RVA = "0x6968D0", Offset = "0x6954D0", VA = "0x1806968D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600F0FF RID: 61695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F0FF")]
			[Address(RVA = "0x696520", Offset = "0x695120", VA = "0x180696520")]
			public void SetData(Character character, PeriodModifySharedDataBbTalent.SharedDataBbModifier.SharedDataBbModifierParam param)
			{
			}

			// Token: 0x0600F100 RID: 61696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F100")]
			[Address(RVA = "0x696230", Offset = "0x694E30", VA = "0x180696230", Slot = "5")]
			public override void OnTick(Deck.Card card, FP deltaTime)
			{
			}

			// Token: 0x0600F101 RID: 61697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F101")]
			[Address(RVA = "0x6966D0", Offset = "0x6952D0", VA = "0x1806966D0")]
			private void _DoModifySharedData()
			{
			}

			// Token: 0x0600F102 RID: 61698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F102")]
			[Address(RVA = "0x6967D0", Offset = "0x6953D0", VA = "0x1806967D0")]
			public SharedDataBbModifier()
			{
			}

			// Token: 0x04010AA2 RID: 68258
			[Token(Token = "0x4010AA2")]
			[FieldOffset(Offset = "0x10")]
			private BattleCharacterData.SharedData m_sharedData;

			// Token: 0x04010AA3 RID: 68259
			[Token(Token = "0x4010AA3")]
			[FieldOffset(Offset = "0x18")]
			private PeriodicTimer m_periodTimer;

			// Token: 0x04010AA4 RID: 68260
			[Token(Token = "0x4010AA4")]
			[FieldOffset(Offset = "0x20")]
			private PeriodModifySharedDataBbTalent.SharedDataBbModifier.SharedDataBbModifierParam m_param;

			// Token: 0x04010AA6 RID: 68262
			[Token(Token = "0x4010AA6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_valueRatio;

			// Token: 0x04010AA7 RID: 68263
			[Token(Token = "0x4010AA7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_valueRatio;

			// Token: 0x04010AA8 RID: 68264
			[Token(Token = "0x4010AA8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x04010AA9 RID: 68265
			[Token(Token = "0x4010AA9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04010AAA RID: 68266
			[Token(Token = "0x4010AAA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__DoModifySharedData;

			// Token: 0x04010AAB RID: 68267
			[Token(Token = "0x4010AAB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200249F RID: 9375
			[Token(Token = "0x200249F")]
			public struct SharedDataBbModifierParam
			{
				// Token: 0x04010AAC RID: 68268
				[Token(Token = "0x4010AAC")]
				[FieldOffset(Offset = "0x0")]
				public float period;

				// Token: 0x04010AAD RID: 68269
				[Token(Token = "0x4010AAD")]
				[FieldOffset(Offset = "0x4")]
				public float initValue;

				// Token: 0x04010AAE RID: 68270
				[Token(Token = "0x4010AAE")]
				[FieldOffset(Offset = "0x8")]
				public float addValue;

				// Token: 0x04010AAF RID: 68271
				[Token(Token = "0x4010AAF")]
				[FieldOffset(Offset = "0xC")]
				public float maxValue;

				// Token: 0x04010AB0 RID: 68272
				[Token(Token = "0x4010AB0")]
				[FieldOffset(Offset = "0x10")]
				public string valueKey;
			}
		}

		// Token: 0x020024A0 RID: 9376
		[Token(Token = "0x20024A0")]
		public class SharedDataBbCardEffectPlugin : UICardEffectHolder.CardEffectPlugin
		{
			// Token: 0x0600F103 RID: 61699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F103")]
			[Address(RVA = "0x6961C0", Offset = "0x694DC0", VA = "0x1806961C0")]
			public SharedDataBbCardEffectPlugin(RectTransform pluginPrefab)
			{
			}

			// Token: 0x0600F104 RID: 61700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F104")]
			[Address(RVA = "0x695EC0", Offset = "0x694AC0", VA = "0x180695EC0")]
			public void SetData(CardHoldTalent.CardHoldDataModifier modifier)
			{
			}

			// Token: 0x0600F105 RID: 61701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F105")]
			[Address(RVA = "0x695DA0", Offset = "0x6949A0", VA = "0x180695DA0", Slot = "4")]
			protected override void OnAttach(UICardEffectHolder holder)
			{
			}

			// Token: 0x0600F106 RID: 61702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F106")]
			[Address(RVA = "0x695E50", Offset = "0x694A50", VA = "0x180695E50", Slot = "6")]
			public override void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600F107 RID: 61703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F107")]
			[Address(RVA = "0x696030", Offset = "0x694C30", VA = "0x180696030")]
			private void _UpdateEffect()
			{
			}

			// Token: 0x0600F108 RID: 61704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F108")]
			[Address(RVA = "0x696010", Offset = "0x694C10", VA = "0x180696010")]
			private void <>xLuaBaseProxy_OnAttach(UICardEffectHolder P0)
			{
			}

			// Token: 0x0600F109 RID: 61705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F109")]
			[Address(RVA = "0x696020", Offset = "0x694C20", VA = "0x180696020")]
			private void <>xLuaBaseProxy_OnTick(FP P0)
			{
			}

			// Token: 0x04010AB1 RID: 68273
			[Token(Token = "0x4010AB1")]
			[FieldOffset(Offset = "0x30")]
			private PeriodModifySharedDataBbTalent.SharedDataBbModifier m_dataModifier;

			// Token: 0x04010AB2 RID: 68274
			[Token(Token = "0x4010AB2")]
			[FieldOffset(Offset = "0x38")]
			private Animation m_cardEffectAnimation;

			// Token: 0x04010AB3 RID: 68275
			[Token(Token = "0x4010AB3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04010AB4 RID: 68276
			[Token(Token = "0x4010AB4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x04010AB5 RID: 68277
			[Token(Token = "0x4010AB5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnAttach;

			// Token: 0x04010AB6 RID: 68278
			[Token(Token = "0x4010AB6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04010AB7 RID: 68279
			[Token(Token = "0x4010AB7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__UpdateEffect;
		}
	}
}
