using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B36 RID: 11062
	[Token(Token = "0x2002B36")]
	public class DurbusAbility : AbilityStandard
	{
		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x060128AB RID: 75947 RVA: 0x00071A60 File Offset: 0x0006FC60
		[Token(Token = "0x170028DC")]
		public override Ability.Category category
		{
			[Token(Token = "0x60128AB")]
			[Address(RVA = "0xA82890", Offset = "0xA81490", VA = "0x180A82890", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x060128AC RID: 75948 RVA: 0x00071A78 File Offset: 0x0006FC78
		[Token(Token = "0x170028DD")]
		public override FP cooldown
		{
			[Token(Token = "0x60128AC")]
			[Address(RVA = "0xA828F0", Offset = "0xA814F0", VA = "0x180A828F0", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x060128AD RID: 75949 RVA: 0x00071A90 File Offset: 0x0006FC90
		[Token(Token = "0x170028DE")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x60128AD")]
			[Address(RVA = "0xA82970", Offset = "0xA81570", VA = "0x180A82970", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x060128AE RID: 75950 RVA: 0x00071AA8 File Offset: 0x0006FCA8
		[Token(Token = "0x170028DF")]
		public override AbilityStandard.SelectTargetTiming selectTargetTiming
		{
			[Token(Token = "0x60128AE")]
			[Address(RVA = "0xA829D0", Offset = "0xA815D0", VA = "0x180A829D0", Slot = "66")]
			get
			{
				return AbilityStandard.SelectTargetTiming.AT_BEGINING;
			}
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x060128AF RID: 75951 RVA: 0x00071AC0 File Offset: 0x0006FCC0
		[Token(Token = "0x170028E0")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x60128AF")]
			[Address(RVA = "0xA82830", Offset = "0xA81430", VA = "0x180A82830", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x060128B0 RID: 75952 RVA: 0x00071AD8 File Offset: 0x0006FCD8
		[Token(Token = "0x170028E1")]
		public override bool allowNoTarget
		{
			[Token(Token = "0x60128B0")]
			[Address(RVA = "0xA827D0", Offset = "0xA813D0", VA = "0x180A827D0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060128B1 RID: 75953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128B1")]
		[Address(RVA = "0xA80090", Offset = "0xA7EC90", VA = "0x180A80090", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x060128B2 RID: 75954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128B2")]
		[Address(RVA = "0xA7FFC0", Offset = "0xA7EBC0", VA = "0x180A7FFC0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x060128B3 RID: 75955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128B3")]
		[Address(RVA = "0xA80020", Offset = "0xA7EC20", VA = "0x180A80020", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x060128B4 RID: 75956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128B4")]
		[Address(RVA = "0xA800F0", Offset = "0xA7ECF0", VA = "0x180A800F0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x060128B5 RID: 75957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128B5")]
		[Address(RVA = "0xA806D0", Offset = "0xA7F2D0", VA = "0x180A806D0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x060128B6 RID: 75958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60128B6")]
		[Address(RVA = "0xA80640", Offset = "0xA7F240", VA = "0x180A80640", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x060128B7 RID: 75959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128B7")]
		[Address(RVA = "0xA82390", Offset = "0xA80F90", VA = "0x180A82390")]
		private void _UpdatePassengerEffect()
		{
		}

		// Token: 0x060128B8 RID: 75960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128B8")]
		[Address(RVA = "0xA81670", Offset = "0xA80270", VA = "0x180A81670")]
		private void _FinishPassengerEffect()
		{
		}

		// Token: 0x060128B9 RID: 75961 RVA: 0x00071AF0 File Offset: 0x0006FCF0
		[Token(Token = "0x60128B9")]
		[Address(RVA = "0xA82550", Offset = "0xA81150", VA = "0x180A82550")]
		private bool _VerifyCurrentMode(int currentMode)
		{
			return default(bool);
		}

		// Token: 0x060128BA RID: 75962 RVA: 0x00071B08 File Offset: 0x0006FD08
		[Token(Token = "0x60128BA")]
		[Address(RVA = "0xA81B60", Offset = "0xA80760", VA = "0x180A81B60")]
		private bool _SearchPassengers()
		{
			return default(bool);
		}

		// Token: 0x060128BB RID: 75963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128BB")]
		[Address(RVA = "0xA7FD00", Offset = "0xA7E900", VA = "0x180A7FD00", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060128BC RID: 75964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128BC")]
		[Address(RVA = "0xA7FA90", Offset = "0xA7E690", VA = "0x180A7FA90", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060128BD RID: 75965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128BD")]
		[Address(RVA = "0xA80440", Offset = "0xA7F040", VA = "0x180A80440", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x060128BE RID: 75966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128BE")]
		[Address(RVA = "0xA80760", Offset = "0xA7F360", VA = "0x180A80760")]
		public void ReleaseAllPassengers(bool immediately = false, [Optional] Vector2? releasePos, bool needMarked = false)
		{
		}

		// Token: 0x060128BF RID: 75967 RVA: 0x00071B20 File Offset: 0x0006FD20
		[Token(Token = "0x60128BF")]
		[Address(RVA = "0xA80DA0", Offset = "0xA7F9A0", VA = "0x180A80DA0")]
		public bool ReleaseLastPassenger(bool immediately = false, [Optional] Vector2? releasePos, bool needMarked = false)
		{
			return default(bool);
		}

		// Token: 0x060128C0 RID: 75968 RVA: 0x00071B38 File Offset: 0x0006FD38
		[Token(Token = "0x60128C0")]
		[Address(RVA = "0xA80180", Offset = "0xA7ED80", VA = "0x180A80180")]
		public bool KillLastPassenger()
		{
			return default(bool);
		}

		// Token: 0x060128C1 RID: 75969 RVA: 0x00071B50 File Offset: 0x0006FD50
		[Token(Token = "0x60128C1")]
		[Address(RVA = "0xA7FA10", Offset = "0xA7E610", VA = "0x180A7FA10")]
		public bool CheckPassengersExits()
		{
			return default(bool);
		}

		// Token: 0x060128C2 RID: 75970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128C2")]
		[Address(RVA = "0xA80380", Offset = "0xA7EF80", VA = "0x180A80380")]
		public void MarkCurrentPassengers()
		{
		}

		// Token: 0x060128C3 RID: 75971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128C3")]
		[Address(RVA = "0xA81090", Offset = "0xA7FC90", VA = "0x180A81090")]
		public void SetSearchPassengersStatus(bool status)
		{
		}

		// Token: 0x060128C4 RID: 75972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128C4")]
		[Address(RVA = "0xA817D0", Offset = "0xA803D0", VA = "0x180A817D0")]
		private void _ReleasePassenger(Enemy enemy, bool immediately = false, [Optional] Vector2? releasePos)
		{
		}

		// Token: 0x060128C5 RID: 75973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128C5")]
		[Address(RVA = "0xA81100", Offset = "0xA7FD00", VA = "0x180A81100")]
		private void _DoReleasePassengers(Enemy enemy, Vector2 pos)
		{
		}

		// Token: 0x060128C6 RID: 75974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128C6")]
		[Address(RVA = "0xA7FDF0", Offset = "0xA7E9F0", VA = "0x180A7FDF0", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x060128C7 RID: 75975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128C7")]
		[Address(RVA = "0xA7FEB0", Offset = "0xA7EAB0", VA = "0x180A7FEB0", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060128C8 RID: 75976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128C8")]
		[Address(RVA = "0xA804D0", Offset = "0xA7F0D0", VA = "0x180A804D0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060128C9 RID: 75977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128C9")]
		[Address(RVA = "0xA82610", Offset = "0xA81210", VA = "0x180A82610")]
		public DurbusAbility()
		{
		}

		// Token: 0x060128CA RID: 75978 RVA: 0x00071B68 File Offset: 0x0006FD68
		[Token(Token = "0x60128CA")]
		[Address(RVA = "0xA6E060", Offset = "0xA6CC60", VA = "0x180A6E060")]
		private AbilityStandard.SelectTargetTiming <>xLuaBaseProxy_get_selectTargetTiming()
		{
			return AbilityStandard.SelectTargetTiming.AT_BEGINING;
		}

		// Token: 0x060128CB RID: 75979 RVA: 0x00071B80 File Offset: 0x0006FD80
		[Token(Token = "0x60128CB")]
		[Address(RVA = "0xA23D10", Offset = "0xA22910", VA = "0x180A23D10")]
		private bool <>xLuaBaseProxy_get_allowNoTarget()
		{
			return default(bool);
		}

		// Token: 0x060128CC RID: 75980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128CC")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060128CD RID: 75981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128CD")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x060128CE RID: 75982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128CE")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x060128CF RID: 75983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128CF")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x060128D0 RID: 75984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128D0")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x060128D1 RID: 75985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60128D1")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04014F2F RID: 85807
		[Token(Token = "0x4014F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("DurbusAbility")]
		private float _randomOffsetBound;

		// Token: 0x04014F30 RID: 85808
		[Token(Token = "0x4014F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("DurbusAbility")]
		private string[] _passengerEffects;

		// Token: 0x04014F31 RID: 85809
		[Token(Token = "0x4014F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("DurbusAbility")]
		protected BuffData[] _passiveBuffs;

		// Token: 0x04014F32 RID: 85810
		[Token(Token = "0x4014F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("DurbusAbility")]
		private TargetValidator _targetValidator;

		// Token: 0x04014F33 RID: 85811
		[Token(Token = "0x4014F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _useHostRoute;

		// Token: 0x04014F34 RID: 85812
		[Token(Token = "0x4014F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _appearOnTileCenter;

		// Token: 0x04014F35 RID: 85813
		[Token(Token = "0x4014F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _passengerToNearestEndPoint;

		// Token: 0x04014F36 RID: 85814
		[Token(Token = "0x4014F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x133")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _passengerUseBranchRoute;

		// Token: 0x04014F37 RID: 85815
		[Token(Token = "0x4014F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[Group("DurbusAbility")]
		private float _delayToReleasePassengers;

		// Token: 0x04014F38 RID: 85816
		[Token(Token = "0x4014F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _onlySearchPassengerInSpecifiedMode;

		// Token: 0x04014F39 RID: 85817
		[Token(Token = "0x4014F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[Group("DurbusAbility")]
		private int _modeIndex;

		// Token: 0x04014F3A RID: 85818
		[Token(Token = "0x4014F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("DurbusAbility")]
		private int[] _extraModeIndex;

		// Token: 0x04014F3B RID: 85819
		[Token(Token = "0x4014F3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _disablePassengerAppearColor;

		// Token: 0x04014F3C RID: 85820
		[Token(Token = "0x4014F3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("DurbusAbility")]
		private string _effectOnPassengerWhenRelease;

		// Token: 0x04014F3D RID: 85821
		[Token(Token = "0x4014F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("DurbusAbility")]
		private string _effectWhenAddPassenger;

		// Token: 0x04014F3E RID: 85822
		[Token(Token = "0x4014F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _setToHostPosBeforeReassignRoute;

		// Token: 0x04014F3F RID: 85823
		[Token(Token = "0x4014F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _assignPassengerCountToBb;

		// Token: 0x04014F40 RID: 85824
		[Token(Token = "0x4014F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("DurbusAbility")]
		private BuffData[] _buffsWhenCarryPassenger;

		// Token: 0x04014F41 RID: 85825
		[Token(Token = "0x4014F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _passengerAsCarryBuffSource;

		// Token: 0x04014F42 RID: 85826
		[Token(Token = "0x4014F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("DurbusAbility")]
		private BuffData[] _buffsToReleasedPassenger;

		// Token: 0x04014F43 RID: 85827
		[Token(Token = "0x4014F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("DurbusAbility")]
		private bool _ignoreHost;

		// Token: 0x04014F44 RID: 85828
		[Token(Token = "0x4014F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private int m_maxCount;

		// Token: 0x04014F45 RID: 85829
		[Token(Token = "0x4014F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private readonly List<ObjectPtr<Entity>> m_passengers;

		// Token: 0x04014F46 RID: 85830
		[Token(Token = "0x4014F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private List<ObjectPtr<Entity>> m_passengersMark;

		// Token: 0x04014F47 RID: 85831
		[Token(Token = "0x4014F47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private int m_passengerEffectIndex;

		// Token: 0x04014F48 RID: 85832
		[Token(Token = "0x4014F48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private ObjectPtr<Effect> m_passengerEffect;

		// Token: 0x04014F49 RID: 85833
		[Token(Token = "0x4014F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Enemy m_host;

		// Token: 0x04014F4A RID: 85834
		[Token(Token = "0x4014F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool m_searchPassengersStatus;

		// Token: 0x04014F4B RID: 85835
		[Token(Token = "0x4014F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04014F4C RID: 85836
		[Token(Token = "0x4014F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04014F4D RID: 85837
		[Token(Token = "0x4014F4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04014F4E RID: 85838
		[Token(Token = "0x4014F4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectTargetTiming;

		// Token: 0x04014F4F RID: 85839
		[Token(Token = "0x4014F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04014F50 RID: 85840
		[Token(Token = "0x4014F50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_allowNoTarget;

		// Token: 0x04014F51 RID: 85841
		[Token(Token = "0x4014F51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04014F52 RID: 85842
		[Token(Token = "0x4014F52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04014F53 RID: 85843
		[Token(Token = "0x4014F53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014F54 RID: 85844
		[Token(Token = "0x4014F54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014F55 RID: 85845
		[Token(Token = "0x4014F55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04014F56 RID: 85846
		[Token(Token = "0x4014F56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x04014F57 RID: 85847
		[Token(Token = "0x4014F57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdatePassengerEffect;

		// Token: 0x04014F58 RID: 85848
		[Token(Token = "0x4014F58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FinishPassengerEffect;

		// Token: 0x04014F59 RID: 85849
		[Token(Token = "0x4014F59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__VerifyCurrentMode;

		// Token: 0x04014F5A RID: 85850
		[Token(Token = "0x4014F5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SearchPassengers;

		// Token: 0x04014F5B RID: 85851
		[Token(Token = "0x4014F5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014F5C RID: 85852
		[Token(Token = "0x4014F5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014F5D RID: 85853
		[Token(Token = "0x4014F5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014F5E RID: 85854
		[Token(Token = "0x4014F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ReleaseAllPassengers;

		// Token: 0x04014F5F RID: 85855
		[Token(Token = "0x4014F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ReleaseLastPassenger;

		// Token: 0x04014F60 RID: 85856
		[Token(Token = "0x4014F60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_KillLastPassenger;

		// Token: 0x04014F61 RID: 85857
		[Token(Token = "0x4014F61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CheckPassengersExits;

		// Token: 0x04014F62 RID: 85858
		[Token(Token = "0x4014F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_MarkCurrentPassengers;

		// Token: 0x04014F63 RID: 85859
		[Token(Token = "0x4014F63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SetSearchPassengersStatus;

		// Token: 0x04014F64 RID: 85860
		[Token(Token = "0x4014F64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ReleasePassenger;

		// Token: 0x04014F65 RID: 85861
		[Token(Token = "0x4014F65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__DoReleasePassengers;

		// Token: 0x04014F66 RID: 85862
		[Token(Token = "0x4014F66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014F67 RID: 85863
		[Token(Token = "0x4014F67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014F68 RID: 85864
		[Token(Token = "0x4014F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014F69 RID: 85865
		[Token(Token = "0x4014F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
