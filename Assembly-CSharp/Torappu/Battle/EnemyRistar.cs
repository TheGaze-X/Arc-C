using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025F1 RID: 9713
	[Token(Token = "0x20025F1")]
	public class EnemyRistar : Enemy
	{
		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x0600FCE7 RID: 64743 RVA: 0x0005F9A0 File Offset: 0x0005DBA0
		[Token(Token = "0x17002203")]
		private int maxHitCount
		{
			[Token(Token = "0x600FCE7")]
			[Address(RVA = "0x7443B0", Offset = "0x742FB0", VA = "0x1807443B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x0600FCE8 RID: 64744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002204")]
		private Buff hitCounter
		{
			[Token(Token = "0x600FCE8")]
			[Address(RVA = "0x744260", Offset = "0x742E60", VA = "0x180744260")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x0600FCE9 RID: 64745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002205")]
		public override string hitRangeId
		{
			[Token(Token = "0x600FCE9")]
			[Address(RVA = "0x744320", Offset = "0x742F20", VA = "0x180744320", Slot = "187")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x0600FCEA RID: 64746 RVA: 0x0005F9B8 File Offset: 0x0005DBB8
		[Token(Token = "0x17002206")]
		public override FP spShowedBuffProgress
		{
			[Token(Token = "0x600FCEA")]
			[Address(RVA = "0x744490", Offset = "0x743090", VA = "0x180744490", Slot = "165")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600FCEB RID: 64747 RVA: 0x0005F9D0 File Offset: 0x0005DBD0
		[Token(Token = "0x600FCEB")]
		[Address(RVA = "0x744070", Offset = "0x742C70", VA = "0x180744070")]
		private FP _RemainingHitRatio()
		{
			return default(FP);
		}

		// Token: 0x0600FCEC RID: 64748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCEC")]
		[Address(RVA = "0x743C70", Offset = "0x742870", VA = "0x180743C70", Slot = "182")]
		protected override void OnSwitchMode(UnitMode next, UnitMode last, bool restartFSM)
		{
		}

		// Token: 0x0600FCED RID: 64749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCED")]
		[Address(RVA = "0x743F60", Offset = "0x742B60", VA = "0x180743F60")]
		public void UpdateHitCount(bool clearCount = false)
		{
		}

		// Token: 0x0600FCEE RID: 64750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCEE")]
		[Address(RVA = "0x743D70", Offset = "0x742970", VA = "0x180743D70", Slot = "127")]
		protected override void OnTakeDamage(ref Modifier modifier, bool force)
		{
		}

		// Token: 0x0600FCEF RID: 64751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCEF")]
		[Address(RVA = "0x743B70", Offset = "0x742770", VA = "0x180743B70", Slot = "212")]
		public override void KnockBack(Vector2 dir, float force, bool changeFaceByDirection)
		{
		}

		// Token: 0x0600FCF0 RID: 64752 RVA: 0x0005F9E8 File Offset: 0x0005DBE8
		[Token(Token = "0x600FCF0")]
		[Address(RVA = "0x743AE0", Offset = "0x7426E0", VA = "0x180743AE0", Slot = "213")]
		public override bool BeginPull(BObject source, Vector2 dir, float force)
		{
			return default(bool);
		}

		// Token: 0x0600FCF1 RID: 64753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCF1")]
		[Address(RVA = "0x744120", Offset = "0x742D20", VA = "0x180744120")]
		public EnemyRistar()
		{
		}

		// Token: 0x0600FCF2 RID: 64754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FCF2")]
		[Address(RVA = "0x743F40", Offset = "0x742B40", VA = "0x180743F40")]
		private string <>xLuaBaseProxy_get_hitRangeId()
		{
			return null;
		}

		// Token: 0x0600FCF3 RID: 64755 RVA: 0x0005FA00 File Offset: 0x0005DC00
		[Token(Token = "0x600FCF3")]
		[Address(RVA = "0x743F50", Offset = "0x742B50", VA = "0x180743F50")]
		private FP <>xLuaBaseProxy_get_spShowedBuffProgress()
		{
			return default(FP);
		}

		// Token: 0x0600FCF4 RID: 64756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCF4")]
		[Address(RVA = "0x743F30", Offset = "0x742B30", VA = "0x180743F30")]
		private void <>xLuaBaseProxy_OnSwitchMode(UnitMode P0, UnitMode P1, bool P2)
		{
		}

		// Token: 0x0600FCF5 RID: 64757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCF5")]
		[Address(RVA = "0x6F2140", Offset = "0x6F0D40", VA = "0x1806F2140")]
		private void <>xLuaBaseProxy_OnTakeDamage(ref Modifier P0, bool P1)
		{
		}

		// Token: 0x0600FCF6 RID: 64758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FCF6")]
		[Address(RVA = "0x743F20", Offset = "0x742B20", VA = "0x180743F20")]
		private void <>xLuaBaseProxy_KnockBack(Vector2 P0, float P1, bool P2)
		{
		}

		// Token: 0x0600FCF7 RID: 64759 RVA: 0x0005FA18 File Offset: 0x0005DC18
		[Token(Token = "0x600FCF7")]
		[Address(RVA = "0x6F2DE0", Offset = "0x6F19E0", VA = "0x1806F2DE0")]
		private bool <>xLuaBaseProxy_BeginPull(BObject P0, Vector2 P1, float P2)
		{
			return default(bool);
		}

		// Token: 0x04011906 RID: 71942
		[Token(Token = "0x4011906")]
		[FieldOffset(Offset = "0x528")]
		[SerializeField]
		private List<int> _modeIndexToUseHitRange;

		// Token: 0x04011907 RID: 71943
		[Token(Token = "0x4011907")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		private string _hitRangeId;

		// Token: 0x04011908 RID: 71944
		[Token(Token = "0x4011908")]
		[FieldOffset(Offset = "0x538")]
		private bool m_useHitRange;

		// Token: 0x04011909 RID: 71945
		[Token(Token = "0x4011909")]
		[FieldOffset(Offset = "0x53C")]
		private int m_hitCount;

		// Token: 0x0401190A RID: 71946
		[Token(Token = "0x401190A")]
		[FieldOffset(Offset = "0x540")]
		private int m_maxHitCount;

		// Token: 0x0401190B RID: 71947
		[Token(Token = "0x401190B")]
		[FieldOffset(Offset = "0x548")]
		private Buff m_hitCounter;

		// Token: 0x0401190C RID: 71948
		[Token(Token = "0x401190C")]
		[FieldOffset(Offset = "0x550")]
		private string m_maxHitCountKey;

		// Token: 0x0401190D RID: 71949
		[Token(Token = "0x401190D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxHitCount;

		// Token: 0x0401190E RID: 71950
		[Token(Token = "0x401190E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hitCounter;

		// Token: 0x0401190F RID: 71951
		[Token(Token = "0x401190F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hitRangeId;

		// Token: 0x04011910 RID: 71952
		[Token(Token = "0x4011910")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_spShowedBuffProgress;

		// Token: 0x04011911 RID: 71953
		[Token(Token = "0x4011911")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RemainingHitRatio;

		// Token: 0x04011912 RID: 71954
		[Token(Token = "0x4011912")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSwitchMode;

		// Token: 0x04011913 RID: 71955
		[Token(Token = "0x4011913")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateHitCount;

		// Token: 0x04011914 RID: 71956
		[Token(Token = "0x4011914")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x04011915 RID: 71957
		[Token(Token = "0x4011915")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_KnockBack;

		// Token: 0x04011916 RID: 71958
		[Token(Token = "0x4011916")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_BeginPull;

		// Token: 0x04011917 RID: 71959
		[Token(Token = "0x4011917")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
