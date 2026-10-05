using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025F5 RID: 9717
	[Token(Token = "0x20025F5")]
	public class FootballPlayerEnemy : Enemy
	{
		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x0600FD25 RID: 64805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700220A")]
		public FootballEnemy adjacentFootball
		{
			[Token(Token = "0x600FD25")]
			[Address(RVA = "0x756350", Offset = "0x754F50", VA = "0x180756350")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600FD26 RID: 64806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD26")]
		[Address(RVA = "0x754E40", Offset = "0x753A40", VA = "0x180754E40", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FD27 RID: 64807 RVA: 0x0005FB50 File Offset: 0x0005DD50
		[Token(Token = "0x600FD27")]
		[Address(RVA = "0x755730", Offset = "0x754330", VA = "0x180755730", Slot = "217")]
		protected override Vector2 _MoveByRoute(float deltaTime, out bool isHanging)
		{
			return default(Vector2);
		}

		// Token: 0x0600FD28 RID: 64808 RVA: 0x0005FB68 File Offset: 0x0005DD68
		[Token(Token = "0x600FD28")]
		[Address(RVA = "0x755BB0", Offset = "0x7547B0", VA = "0x180755BB0")]
		private Vector2 _MoveToTarget(float deltaTime, out bool isHanging, Unit footballEnemy)
		{
			return default(Vector2);
		}

		// Token: 0x0600FD29 RID: 64809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FD29")]
		[Address(RVA = "0x755420", Offset = "0x754020", VA = "0x180755420")]
		private Tile _FindNoTrapAroundTile()
		{
			return null;
		}

		// Token: 0x0600FD2A RID: 64810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FD2A")]
		[Address(RVA = "0x7560F0", Offset = "0x754CF0", VA = "0x1807560F0")]
		private Tile _SlapShotSelectGoalTile()
		{
			return null;
		}

		// Token: 0x0600FD2B RID: 64811 RVA: 0x0005FB80 File Offset: 0x0005DD80
		[Token(Token = "0x600FD2B")]
		[Address(RVA = "0x755200", Offset = "0x753E00", VA = "0x180755200")]
		private Vector2 _ClearanceGetPos()
		{
			return default(Vector2);
		}

		// Token: 0x0600FD2C RID: 64812 RVA: 0x0005FB98 File Offset: 0x0005DD98
		[Token(Token = "0x600FD2C")]
		[Address(RVA = "0x754B80", Offset = "0x753780", VA = "0x180754B80")]
		public bool IsCloseToFootball(bool ignoreIsSelected = false)
		{
			return default(bool);
		}

		// Token: 0x0600FD2D RID: 64813 RVA: 0x0005FBB0 File Offset: 0x0005DDB0
		[Token(Token = "0x600FD2D")]
		[Address(RVA = "0x754870", Offset = "0x753470", VA = "0x180754870")]
		public bool HasTeammate()
		{
			return default(bool);
		}

		// Token: 0x0600FD2E RID: 64814 RVA: 0x0005FBC8 File Offset: 0x0005DDC8
		[Token(Token = "0x600FD2E")]
		[Address(RVA = "0x753C00", Offset = "0x752800", VA = "0x180753C00")]
		public bool DiceSlapShot()
		{
			return default(bool);
		}

		// Token: 0x0600FD2F RID: 64815 RVA: 0x0005FBE0 File Offset: 0x0005DDE0
		[Token(Token = "0x600FD2F")]
		[Address(RVA = "0x754370", Offset = "0x752F70", VA = "0x180754370")]
		public bool DoSlapShot()
		{
			return default(bool);
		}

		// Token: 0x0600FD30 RID: 64816 RVA: 0x0005FBF8 File Offset: 0x0005DDF8
		[Token(Token = "0x600FD30")]
		[Address(RVA = "0x753EF0", Offset = "0x752AF0", VA = "0x180753EF0")]
		public bool DoClearance()
		{
			return default(bool);
		}

		// Token: 0x0600FD31 RID: 64817 RVA: 0x0005FC10 File Offset: 0x0005DE10
		[Token(Token = "0x600FD31")]
		[Address(RVA = "0x7541F0", Offset = "0x752DF0", VA = "0x1807541F0")]
		public bool DoPassTheBall()
		{
			return default(bool);
		}

		// Token: 0x0600FD32 RID: 64818 RVA: 0x0005FC28 File Offset: 0x0005DE28
		[Token(Token = "0x600FD32")]
		[Address(RVA = "0x754050", Offset = "0x752C50", VA = "0x180754050")]
		public bool DoDribble()
		{
			return default(bool);
		}

		// Token: 0x0600FD33 RID: 64819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD33")]
		[Address(RVA = "0x755190", Offset = "0x753D90", VA = "0x180755190")]
		public void SetForceSearchTarget(bool isActive)
		{
		}

		// Token: 0x0600FD34 RID: 64820 RVA: 0x0005FC40 File Offset: 0x0005DE40
		[Token(Token = "0x600FD34")]
		[Address(RVA = "0x754620", Offset = "0x753220", VA = "0x180754620")]
		public FP GetMinimumDistanceToGoal()
		{
			return default(FP);
		}

		// Token: 0x0600FD35 RID: 64821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD35")]
		[Address(RVA = "0x754AE0", Offset = "0x7536E0", VA = "0x180754AE0")]
		public void InitForces(FP passBallForce, FP slapShotForce, FP clearanceForce)
		{
		}

		// Token: 0x0600FD36 RID: 64822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD36")]
		[Address(RVA = "0x7550C0", Offset = "0x753CC0", VA = "0x1807550C0", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600FD37 RID: 64823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD37")]
		[Address(RVA = "0x756230", Offset = "0x754E30", VA = "0x180756230")]
		public FootballPlayerEnemy()
		{
		}

		// Token: 0x0600FD38 RID: 64824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD38")]
		[Address(RVA = "0x6099B0", Offset = "0x6085B0", VA = "0x1806099B0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600FD39 RID: 64825 RVA: 0x0005FC58 File Offset: 0x0005DE58
		[Token(Token = "0x600FD39")]
		[Address(RVA = "0x6F0050", Offset = "0x6EEC50", VA = "0x1806F0050")]
		private Vector2 <>xLuaBaseProxy__MoveByRoute(float P0, out bool P1)
		{
			return default(Vector2);
		}

		// Token: 0x0600FD3A RID: 64826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD3A")]
		[Address(RVA = "0x6099C0", Offset = "0x6085C0", VA = "0x1806099C0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x04011949 RID: 72009
		[Token(Token = "0x4011949")]
		[FieldOffset(Offset = "0x528")]
		[SerializeField]
		[Group("FootballPlayer")]
		private Ability _searchBallAbility;

		// Token: 0x0401194A RID: 72010
		[Token(Token = "0x401194A")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		[Group("FootballPlayer")]
		private Ability _searchTeammateAbility;

		// Token: 0x0401194B RID: 72011
		[Token(Token = "0x401194B")]
		[FieldOffset(Offset = "0x538")]
		[SerializeField]
		[Group("FootballPlayer")]
		private Ability _closeToBallAbility;

		// Token: 0x0401194C RID: 72012
		[Token(Token = "0x401194C")]
		[FieldOffset(Offset = "0x540")]
		[SerializeField]
		[Group("FootballPlayer")]
		private Ability _searchTargetAbility;

		// Token: 0x0401194D RID: 72013
		[Token(Token = "0x401194D")]
		[FieldOffset(Offset = "0x548")]
		[SerializeField]
		[Group("FootballPlayer")]
		private FootballPlayerEnemy.SlapShotType _slapShotType;

		// Token: 0x0401194E RID: 72014
		[Token(Token = "0x401194E")]
		[FieldOffset(Offset = "0x54C")]
		[SerializeField]
		[Group("FootballPlayer")]
		private FootballPlayerEnemy.ClearanceType _clearancePosType;

		// Token: 0x0401194F RID: 72015
		[Token(Token = "0x401194F")]
		[FieldOffset(Offset = "0x550")]
		private FootballEnemy m_adjacentFootball;

		// Token: 0x04011950 RID: 72016
		[Token(Token = "0x4011950")]
		[FieldOffset(Offset = "0x558")]
		private FootballPlayerEnemy m_adjacentPlayer;

		// Token: 0x04011951 RID: 72017
		[Token(Token = "0x4011951")]
		[FieldOffset(Offset = "0x560")]
		private List<Tile> m_allyGoalTiles;

		// Token: 0x04011952 RID: 72018
		[Token(Token = "0x4011952")]
		[FieldOffset(Offset = "0x568")]
		private FP m_passBallForce;

		// Token: 0x04011953 RID: 72019
		[Token(Token = "0x4011953")]
		[FieldOffset(Offset = "0x570")]
		private FP m_slapshotForce;

		// Token: 0x04011954 RID: 72020
		[Token(Token = "0x4011954")]
		[FieldOffset(Offset = "0x578")]
		private FP m_clearanceForce;

		// Token: 0x04011955 RID: 72021
		[Token(Token = "0x4011955")]
		[FieldOffset(Offset = "0x580")]
		private Vector2 m_defaultClearancePos;

		// Token: 0x04011956 RID: 72022
		[Token(Token = "0x4011956")]
		[FieldOffset(Offset = "0x588")]
		private bool m_forceSearchTarget;

		// Token: 0x04011957 RID: 72023
		[Token(Token = "0x4011957")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_adjacentFootball;

		// Token: 0x04011958 RID: 72024
		[Token(Token = "0x4011958")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04011959 RID: 72025
		[Token(Token = "0x4011959")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MoveByRoute;

		// Token: 0x0401195A RID: 72026
		[Token(Token = "0x401195A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__MoveToTarget;

		// Token: 0x0401195B RID: 72027
		[Token(Token = "0x401195B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FindNoTrapAroundTile;

		// Token: 0x0401195C RID: 72028
		[Token(Token = "0x401195C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SlapShotSelectGoalTile;

		// Token: 0x0401195D RID: 72029
		[Token(Token = "0x401195D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearanceGetPos;

		// Token: 0x0401195E RID: 72030
		[Token(Token = "0x401195E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsCloseToFootball;

		// Token: 0x0401195F RID: 72031
		[Token(Token = "0x401195F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HasTeammate;

		// Token: 0x04011960 RID: 72032
		[Token(Token = "0x4011960")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DiceSlapShot;

		// Token: 0x04011961 RID: 72033
		[Token(Token = "0x4011961")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoSlapShot;

		// Token: 0x04011962 RID: 72034
		[Token(Token = "0x4011962")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoClearance;

		// Token: 0x04011963 RID: 72035
		[Token(Token = "0x4011963")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoPassTheBall;

		// Token: 0x04011964 RID: 72036
		[Token(Token = "0x4011964")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoDribble;

		// Token: 0x04011965 RID: 72037
		[Token(Token = "0x4011965")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetForceSearchTarget;

		// Token: 0x04011966 RID: 72038
		[Token(Token = "0x4011966")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetMinimumDistanceToGoal;

		// Token: 0x04011967 RID: 72039
		[Token(Token = "0x4011967")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_InitForces;

		// Token: 0x04011968 RID: 72040
		[Token(Token = "0x4011968")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04011969 RID: 72041
		[Token(Token = "0x4011969")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020025F6 RID: 9718
		[Token(Token = "0x20025F6")]
		private enum SlapShotType
		{
			// Token: 0x0401196B RID: 72043
			[Token(Token = "0x401196B")]
			RANDOM,
			// Token: 0x0401196C RID: 72044
			[Token(Token = "0x401196C")]
			NO_TRAP_AROUND
		}

		// Token: 0x020025F7 RID: 9719
		[Token(Token = "0x20025F7")]
		private enum ClearanceType
		{
			// Token: 0x0401196E RID: 72046
			[Token(Token = "0x401196E")]
			MIDCOURT,
			// Token: 0x0401196F RID: 72047
			[Token(Token = "0x401196F")]
			GOAL_NO_TRAP_AROUND,
			// Token: 0x04011970 RID: 72048
			[Token(Token = "0x4011970")]
			PLAYER_FORWARD
		}
	}
}
