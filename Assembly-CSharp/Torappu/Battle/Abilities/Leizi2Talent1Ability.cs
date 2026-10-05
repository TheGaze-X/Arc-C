using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AE1 RID: 10977
	[Token(Token = "0x2002AE1")]
	public class Leizi2Talent1Ability : AbstractBasicAttack, BattleAttackRangeController.IRangeListener
	{
		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x060124FB RID: 75003 RVA: 0x00070320 File Offset: 0x0006E520
		[Token(Token = "0x17002824")]
		protected override DamageType damageType
		{
			[Token(Token = "0x60124FB")]
			[Address(RVA = "0xA578A0", Offset = "0xA564A0", VA = "0x180A578A0", Slot = "108")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x060124FC RID: 75004 RVA: 0x00070338 File Offset: 0x0006E538
		[Token(Token = "0x17002825")]
		protected override DamageType extraDamageType
		{
			[Token(Token = "0x60124FC")]
			[Address(RVA = "0xA57900", Offset = "0xA56500", VA = "0x180A57900", Slot = "109")]
			get
			{
				return DamageType.NONE;
			}
		}

		// Token: 0x060124FD RID: 75005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124FD")]
		[Address(RVA = "0xA56010", Offset = "0xA54C10", VA = "0x180A56010", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x060124FE RID: 75006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60124FE")]
		[Address(RVA = "0xA561B0", Offset = "0xA54DB0", VA = "0x180A561B0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060124FF RID: 75007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60124FF")]
		[Address(RVA = "0xA55F70", Offset = "0xA54B70", VA = "0x180A55F70", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012500 RID: 75008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012500")]
		[Address(RVA = "0xA56780", Offset = "0xA55380", VA = "0x180A56780", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012501 RID: 75009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012501")]
		[Address(RVA = "0xA560E0", Offset = "0xA54CE0", VA = "0x180A560E0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012502 RID: 75010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012502")]
		[Address(RVA = "0xA56150", Offset = "0xA54D50", VA = "0x180A56150", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012503 RID: 75011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012503")]
		[Address(RVA = "0xA56280", Offset = "0xA54E80", VA = "0x180A56280", Slot = "103")]
		protected override Nodes.ApplyDamage NewDamageNode(DamageType type, FP scale)
		{
			return null;
		}

		// Token: 0x06012504 RID: 75012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012504")]
		[Address(RVA = "0xA55E10", Offset = "0xA54A10", VA = "0x180A55E10", Slot = "26")]
		protected override void DoSetData(Entity entity, Ability.Options ops)
		{
		}

		// Token: 0x06012505 RID: 75013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012505")]
		[Address(RVA = "0xA55B90", Offset = "0xA54790", VA = "0x180A55B90", Slot = "29")]
		protected override void DoAttach(Entity entity)
		{
		}

		// Token: 0x06012506 RID: 75014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012506")]
		[Address(RVA = "0xA55CB0", Offset = "0xA548B0", VA = "0x180A55CB0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012507 RID: 75015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012507")]
		[Address(RVA = "0xA568D0", Offset = "0xA554D0", VA = "0x180A568D0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012508 RID: 75016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012508")]
		[Address(RVA = "0xA563F0", Offset = "0xA54FF0", VA = "0x180A563F0", Slot = "110")]
		public void OnCharacterAttackRangeUpdate(Character character, Dictionary<Character, List<Tile>> allRangeTiles)
		{
		}

		// Token: 0x06012509 RID: 75017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012509")]
		[Address(RVA = "0xA55630", Offset = "0xA54230", VA = "0x180A55630")]
		public void CastToAttackRangeTiles(int times, float specialRangeCastDelay)
		{
		}

		// Token: 0x0601250A RID: 75018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601250A")]
		[Address(RVA = "0xA557B0", Offset = "0xA543B0", VA = "0x180A557B0")]
		public void CastToTile(int projectileIndex, Tile tile, bool force = false)
		{
		}

		// Token: 0x0601250B RID: 75019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601250B")]
		[Address(RVA = "0xA55A90", Offset = "0xA54690", VA = "0x180A55A90")]
		public void CastToTile(Tile tile, bool force = false)
		{
		}

		// Token: 0x0601250C RID: 75020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601250C")]
		[Address(RVA = "0xA56710", Offset = "0xA55310", VA = "0x180A56710")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601250D RID: 75021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601250D")]
		[Address(RVA = "0xA56F60", Offset = "0xA55B60", VA = "0x180A56F60")]
		private void _OnPassivelyCast()
		{
		}

		// Token: 0x0601250E RID: 75022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601250E")]
		[Address(RVA = "0xA56980", Offset = "0xA55580", VA = "0x180A56980")]
		private void _CalculateManhattanDistance(List<GridPosition> list)
		{
		}

		// Token: 0x0601250F RID: 75023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601250F")]
		[Address(RVA = "0xA56D80", Offset = "0xA55980", VA = "0x180A56D80")]
		private IEnumerator _DoCastOnAttackRangeTiles(int times, float specialRangeCastDelay)
		{
			return null;
		}

		// Token: 0x06012510 RID: 75024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012510")]
		[Address(RVA = "0xA56E60", Offset = "0xA55A60", VA = "0x180A56E60")]
		private IEnumerator _DoCastOnTile(int times, int projectileIndex, Tile tile)
		{
			return null;
		}

		// Token: 0x06012511 RID: 75025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012511")]
		[Address(RVA = "0xA56CF0", Offset = "0xA558F0", VA = "0x180A56CF0")]
		private void _ClearCoroutine()
		{
		}

		// Token: 0x06012512 RID: 75026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012512")]
		[Address(RVA = "0xA57520", Offset = "0xA56120", VA = "0x180A57520")]
		public Leizi2Talent1Ability()
		{
		}

		// Token: 0x06012513 RID: 75027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012513")]
		[Address(RVA = "0xA4B080", Offset = "0xA49C80", VA = "0x180A4B080")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x06012514 RID: 75028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012514")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x06012515 RID: 75029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012515")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012516 RID: 75030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012516")]
		[Address(RVA = "0xA56970", Offset = "0xA55570", VA = "0x180A56970")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012517 RID: 75031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012517")]
		[Address(RVA = "0xA4B090", Offset = "0xA49C90", VA = "0x180A4B090")]
		private Nodes.ApplyDamage <>xLuaBaseProxy_NewDamageNode(DamageType P0, FP P1)
		{
			return null;
		}

		// Token: 0x06012518 RID: 75032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012518")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012519 RID: 75033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012519")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x0601251A RID: 75034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601251A")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0601251B RID: 75035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601251B")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x04014B35 RID: 84789
		[Token(Token = "0x4014B35")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private List<string> _projectileKeyList;

		// Token: 0x04014B36 RID: 84790
		[Token(Token = "0x4014B36")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private string _maxCountKey;

		// Token: 0x04014B37 RID: 84791
		[Token(Token = "0x4014B37")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private int _maxCount;

		// Token: 0x04014B38 RID: 84792
		[Token(Token = "0x4014B38")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private string _maxCountKeySpecial;

		// Token: 0x04014B39 RID: 84793
		[Token(Token = "0x4014B39")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private string _useSpecialMaxCountKey;

		// Token: 0x04014B3A RID: 84794
		[Token(Token = "0x4014B3A")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private int _maxCountSpecial;

		// Token: 0x04014B3B RID: 84795
		[Token(Token = "0x4014B3B")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private List<int> _resetCountList;

		// Token: 0x04014B3C RID: 84796
		[Token(Token = "0x4014B3C")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private List<int> _resetCountListSpecial;

		// Token: 0x04014B3D RID: 84797
		[Token(Token = "0x4014B3D")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		private string _useSpecialResetListKey;

		// Token: 0x04014B3E RID: 84798
		[Token(Token = "0x4014B3E")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		private string _intervalKey;

		// Token: 0x04014B3F RID: 84799
		[Token(Token = "0x4014B3F")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		private float _interval;

		// Token: 0x04014B40 RID: 84800
		[Token(Token = "0x4014B40")]
		[FieldOffset(Offset = "0x25C")]
		[SerializeField]
		private float _rangeCastDelay;

		// Token: 0x04014B41 RID: 84801
		[Token(Token = "0x4014B41")]
		[FieldOffset(Offset = "0x260")]
		[SerializeField]
		private float _tileCastDelay;

		// Token: 0x04014B42 RID: 84802
		[Token(Token = "0x4014B42")]
		[FieldOffset(Offset = "0x264")]
		[SerializeField]
		private DamageType _damageType;

		// Token: 0x04014B43 RID: 84803
		[Token(Token = "0x4014B43")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		private DamageType _extraDamageType;

		// Token: 0x04014B44 RID: 84804
		[Token(Token = "0x4014B44")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		private string _forceBuffMarkKey;

		// Token: 0x04014B45 RID: 84805
		[Token(Token = "0x4014B45")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		private string _projectileIndexKey;

		// Token: 0x04014B46 RID: 84806
		[Token(Token = "0x4014B46")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		private BuffData[] _passiveBuffsToOwner;

		// Token: 0x04014B47 RID: 84807
		[Token(Token = "0x4014B47")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		private BuffData[] _buffsToOwnerOnCast;

		// Token: 0x04014B48 RID: 84808
		[Token(Token = "0x4014B48")]
		[FieldOffset(Offset = "0x290")]
		private int m_maxCount;

		// Token: 0x04014B49 RID: 84809
		[Token(Token = "0x4014B49")]
		[FieldOffset(Offset = "0x294")]
		private int m_maxCountSpecial;

		// Token: 0x04014B4A RID: 84810
		[Token(Token = "0x4014B4A")]
		[FieldOffset(Offset = "0x298")]
		private float m_interval;

		// Token: 0x04014B4B RID: 84811
		[Token(Token = "0x4014B4B")]
		[FieldOffset(Offset = "0x2A0")]
		private readonly Dictionary<GridPosition, int> m_tileCountMap;

		// Token: 0x04014B4C RID: 84812
		[Token(Token = "0x4014B4C")]
		[FieldOffset(Offset = "0x2A8")]
		private readonly List<GridPosition> m_curAttackRange;

		// Token: 0x04014B4D RID: 84813
		[Token(Token = "0x4014B4D")]
		[FieldOffset(Offset = "0x2B0")]
		private readonly Dictionary<int, HashSet<GridPosition>> m_distanceMap;

		// Token: 0x04014B4E RID: 84814
		[Token(Token = "0x4014B4E")]
		[FieldOffset(Offset = "0x2B8")]
		private PeriodicTimer m_intervalTicker;

		// Token: 0x04014B4F RID: 84815
		[Token(Token = "0x4014B4F")]
		private const string CUSTOM_MODIFIER_KEY = "leizi2";

		// Token: 0x04014B50 RID: 84816
		[Token(Token = "0x4014B50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_damageType;

		// Token: 0x04014B51 RID: 84817
		[Token(Token = "0x4014B51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_extraDamageType;

		// Token: 0x04014B52 RID: 84818
		[Token(Token = "0x4014B52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04014B53 RID: 84819
		[Token(Token = "0x4014B53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014B54 RID: 84820
		[Token(Token = "0x4014B54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014B55 RID: 84821
		[Token(Token = "0x4014B55")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014B56 RID: 84822
		[Token(Token = "0x4014B56")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014B57 RID: 84823
		[Token(Token = "0x4014B57")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014B58 RID: 84824
		[Token(Token = "0x4014B58")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_NewDamageNode;

		// Token: 0x04014B59 RID: 84825
		[Token(Token = "0x4014B59")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014B5A RID: 84826
		[Token(Token = "0x4014B5A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014B5B RID: 84827
		[Token(Token = "0x4014B5B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014B5C RID: 84828
		[Token(Token = "0x4014B5C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014B5D RID: 84829
		[Token(Token = "0x4014B5D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCharacterAttackRangeUpdate;

		// Token: 0x04014B5E RID: 84830
		[Token(Token = "0x4014B5E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CastToAttackRangeTiles;

		// Token: 0x04014B5F RID: 84831
		[Token(Token = "0x4014B5F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CastToTile;

		// Token: 0x04014B60 RID: 84832
		[Token(Token = "0x4014B60")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1_CastToTile;

		// Token: 0x04014B61 RID: 84833
		[Token(Token = "0x4014B61")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04014B62 RID: 84834
		[Token(Token = "0x4014B62")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnPassivelyCast;

		// Token: 0x04014B63 RID: 84835
		[Token(Token = "0x4014B63")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CalculateManhattanDistance;

		// Token: 0x04014B64 RID: 84836
		[Token(Token = "0x4014B64")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DoCastOnAttackRangeTiles;

		// Token: 0x04014B65 RID: 84837
		[Token(Token = "0x4014B65")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__DoCastOnTile;

		// Token: 0x04014B66 RID: 84838
		[Token(Token = "0x4014B66")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ClearCoroutine;

		// Token: 0x04014B67 RID: 84839
		[Token(Token = "0x4014B67")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
