using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AE0 RID: 10976
	[Token(Token = "0x2002AE0")]
	public abstract class CastOnTileAbility : AbstractAnimatedAbility
	{
		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x060124DE RID: 74974 RVA: 0x000701E8 File Offset: 0x0006E3E8
		[Token(Token = "0x17002820")]
		public bool needExtraStartEffects
		{
			[Token(Token = "0x60124DE")]
			[Address(RVA = "0xA53DE0", Offset = "0xA529E0", VA = "0x180A53DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x060124DF RID: 74975 RVA: 0x00070200 File Offset: 0x0006E400
		[Token(Token = "0x17002821")]
		protected override bool useDynamicAttackType
		{
			[Token(Token = "0x60124DF")]
			[Address(RVA = "0xA53E50", Offset = "0xA52A50", VA = "0x180A53E50", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x060124E0 RID: 74976 RVA: 0x00070218 File Offset: 0x0006E418
		[Token(Token = "0x17002822")]
		protected virtual bool alwaysIncludeInputTargetRootTile
		{
			[Token(Token = "0x60124E0")]
			[Address(RVA = "0xA53D20", Offset = "0xA52920", VA = "0x180A53D20", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x060124E1 RID: 74977 RVA: 0x00070230 File Offset: 0x0006E430
		[Token(Token = "0x17002823")]
		protected virtual bool finishStartEffectsOnCastEnd
		{
			[Token(Token = "0x60124E1")]
			[Address(RVA = "0xA53D80", Offset = "0xA52980", VA = "0x180A53D80", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060124E2 RID: 74978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124E2")]
		[Address(RVA = "0xA52490", Offset = "0xA51090", VA = "0x180A52490", Slot = "101")]
		protected override void DealWithFaceDirection()
		{
		}

		// Token: 0x060124E3 RID: 74979 RVA: 0x00070248 File Offset: 0x0006E448
		[Token(Token = "0x60124E3")]
		[Address(RVA = "0xA52250", Offset = "0xA50E50", VA = "0x180A52250", Slot = "106")]
		protected override bool CheckDownAttack()
		{
			return default(bool);
		}

		// Token: 0x060124E4 RID: 74980 RVA: 0x00070260 File Offset: 0x0006E460
		[Token(Token = "0x60124E4")]
		[Address(RVA = "0xA52320", Offset = "0xA50F20", VA = "0x180A52320", Slot = "107")]
		protected override bool CheckUpAttack()
		{
			return default(bool);
		}

		// Token: 0x060124E5 RID: 74981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60124E5")]
		[Address(RVA = "0xA52A00", Offset = "0xA51600", VA = "0x180A52A00", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060124E6 RID: 74982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124E6")]
		[Address(RVA = "0xA523F0", Offset = "0xA50FF0", VA = "0x180A523F0", Slot = "41")]
		protected override void CleanupForNextCast()
		{
		}

		// Token: 0x060124E7 RID: 74983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124E7")]
		[Address(RVA = "0xA52DF0", Offset = "0xA519F0", VA = "0x180A52DF0", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x060124E8 RID: 74984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124E8")]
		[Address(RVA = "0xA52C90", Offset = "0xA51890", VA = "0x180A52C90", Slot = "110")]
		protected virtual void OnCastOnTile(Tile tile, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060124E9 RID: 74985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124E9")]
		[Address(RVA = "0xA528C0", Offset = "0xA514C0", VA = "0x180A528C0", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060124EA RID: 74986 RVA: 0x00070278 File Offset: 0x0006E478
		[Token(Token = "0x60124EA")]
		[Address(RVA = "0xA525B0", Offset = "0xA511B0", VA = "0x180A525B0", Slot = "85")]
		protected sealed override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x060124EB RID: 74987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124EB")]
		[Address(RVA = "0xA53A00", Offset = "0xA52600", VA = "0x180A53A00")]
		private void _FinishTileStartEffect(Tile target)
		{
		}

		// Token: 0x060124EC RID: 74988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124EC")]
		[Address(RVA = "0xA52A90", Offset = "0xA51690", VA = "0x180A52A90", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x060124ED RID: 74989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124ED")]
		[Address(RVA = "0xA53190", Offset = "0xA51D90", VA = "0x180A53190", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x060124EE RID: 74990 RVA: 0x00070290 File Offset: 0x0006E490
		[Token(Token = "0x60124EE")]
		[Address(RVA = "0xA53390", Offset = "0xA51F90", VA = "0x180A53390", Slot = "86")]
		protected sealed override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x060124EF RID: 74991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124EF")]
		[Address(RVA = "0xA53C10", Offset = "0xA52810", VA = "0x180A53C10")]
		protected CastOnTileAbility()
		{
		}

		// Token: 0x060124F0 RID: 74992 RVA: 0x000702A8 File Offset: 0x0006E4A8
		[Token(Token = "0x60124F0")]
		[Address(RVA = "0xA1E550", Offset = "0xA1D150", VA = "0x180A1E550")]
		private bool <>xLuaBaseProxy_get_useDynamicAttackType()
		{
			return default(bool);
		}

		// Token: 0x060124F1 RID: 74993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124F1")]
		[Address(RVA = "0xA46700", Offset = "0xA45300", VA = "0x180A46700")]
		private void <>xLuaBaseProxy_DealWithFaceDirection()
		{
		}

		// Token: 0x060124F2 RID: 74994 RVA: 0x000702C0 File Offset: 0x0006E4C0
		[Token(Token = "0x60124F2")]
		[Address(RVA = "0xA53360", Offset = "0xA51F60", VA = "0x180A53360")]
		private bool <>xLuaBaseProxy_CheckDownAttack()
		{
			return default(bool);
		}

		// Token: 0x060124F3 RID: 74995 RVA: 0x000702D8 File Offset: 0x0006E4D8
		[Token(Token = "0x60124F3")]
		[Address(RVA = "0xA53370", Offset = "0xA51F70", VA = "0x180A53370")]
		private bool <>xLuaBaseProxy_CheckUpAttack()
		{
			return default(bool);
		}

		// Token: 0x060124F4 RID: 74996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124F4")]
		[Address(RVA = "0xA518F0", Offset = "0xA504F0", VA = "0x180A518F0")]
		private void <>xLuaBaseProxy_CleanupForNextCast()
		{
		}

		// Token: 0x060124F5 RID: 74997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124F5")]
		[Address(RVA = "0xA1E530", Offset = "0xA1D130", VA = "0x180A1E530")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060124F6 RID: 74998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124F6")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x060124F7 RID: 74999 RVA: 0x000702F0 File Offset: 0x0006E4F0
		[Token(Token = "0x60124F7")]
		[Address(RVA = "0xA25730", Offset = "0xA24330", VA = "0x180A25730")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x060124F8 RID: 75000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124F8")]
		[Address(RVA = "0xA1E520", Offset = "0xA1D120", VA = "0x180A1E520")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x060124F9 RID: 75001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124F9")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x060124FA RID: 75002 RVA: 0x00070308 File Offset: 0x0006E508
		[Token(Token = "0x60124FA")]
		[Address(RVA = "0xA25D30", Offset = "0xA24930", VA = "0x180A25D30")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x04014B16 RID: 84758
		[Token(Token = "0x4014B16")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("CastOnTile")]
		private string _tileEffect;

		// Token: 0x04014B17 RID: 84759
		[Token(Token = "0x4014B17")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _tileHoldEffect;

		// Token: 0x04014B18 RID: 84760
		[Token(Token = "0x4014B18")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("CastOnTile")]
		private string _startEffect;

		// Token: 0x04014B19 RID: 84761
		[Token(Token = "0x4014B19")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("CastOnTile")]
		[Inspect("needExtraStartEffects")]
		private List<string> _extraStartEffects;

		// Token: 0x04014B1A RID: 84762
		[Token(Token = "0x4014B1A")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _faceToTile;

		// Token: 0x04014B1B RID: 84763
		[Token(Token = "0x4014B1B")]
		[FieldOffset(Offset = "0x1E9")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _finishStartEffectsOnCastOnTile;

		// Token: 0x04014B1C RID: 84764
		[Token(Token = "0x4014B1C")]
		[FieldOffset(Offset = "0x1EA")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _finishTileStartEffectWhenCast;

		// Token: 0x04014B1D RID: 84765
		[Token(Token = "0x4014B1D")]
		[FieldOffset(Offset = "0x1EB")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _finishStartEffectsOnDetached;

		// Token: 0x04014B1E RID: 84766
		[Token(Token = "0x4014B1E")]
		[FieldOffset(Offset = "0x1EC")]
		[SerializeField]
		private bool _useDynamicAttackType;

		// Token: 0x04014B1F RID: 84767
		[Token(Token = "0x4014B1F")]
		[FieldOffset(Offset = "0x1ED")]
		[SerializeField]
		private bool _alwaysIncludeInputTargetRootTile;

		// Token: 0x04014B20 RID: 84768
		[Token(Token = "0x4014B20")]
		[FieldOffset(Offset = "0x1EE")]
		[SerializeField]
		[Inspect("@selectTargetSource == selectTargetSource.FROM_OWNER")]
		private bool _useOwnerRootTileAsTargetSource;

		// Token: 0x04014B21 RID: 84769
		[Token(Token = "0x4014B21")]
		[FieldOffset(Offset = "0x1F0")]
		protected List<Tile> m_castTiles;

		// Token: 0x04014B22 RID: 84770
		[Token(Token = "0x4014B22")]
		[FieldOffset(Offset = "0x1F8")]
		private ListDict<ObjectPtr<Effect>, Tile> m_startEffect;

		// Token: 0x04014B23 RID: 84771
		[Token(Token = "0x4014B23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needExtraStartEffects;

		// Token: 0x04014B24 RID: 84772
		[Token(Token = "0x4014B24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_useDynamicAttackType;

		// Token: 0x04014B25 RID: 84773
		[Token(Token = "0x4014B25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeInputTargetRootTile;

		// Token: 0x04014B26 RID: 84774
		[Token(Token = "0x4014B26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_finishStartEffectsOnCastEnd;

		// Token: 0x04014B27 RID: 84775
		[Token(Token = "0x4014B27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DealWithFaceDirection;

		// Token: 0x04014B28 RID: 84776
		[Token(Token = "0x4014B28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckDownAttack;

		// Token: 0x04014B29 RID: 84777
		[Token(Token = "0x4014B29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckUpAttack;

		// Token: 0x04014B2A RID: 84778
		[Token(Token = "0x4014B2A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014B2B RID: 84779
		[Token(Token = "0x4014B2B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CleanupForNextCast;

		// Token: 0x04014B2C RID: 84780
		[Token(Token = "0x4014B2C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014B2D RID: 84781
		[Token(Token = "0x4014B2D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCastOnTile;

		// Token: 0x04014B2E RID: 84782
		[Token(Token = "0x4014B2E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014B2F RID: 84783
		[Token(Token = "0x4014B2F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x04014B30 RID: 84784
		[Token(Token = "0x4014B30")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FinishTileStartEffect;

		// Token: 0x04014B31 RID: 84785
		[Token(Token = "0x4014B31")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04014B32 RID: 84786
		[Token(Token = "0x4014B32")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014B33 RID: 84787
		[Token(Token = "0x4014B33")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x04014B34 RID: 84788
		[Token(Token = "0x4014B34")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
