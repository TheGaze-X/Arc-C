using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020025F4 RID: 9716
	[Token(Token = "0x20025F4")]
	public class FootballEnemy : BounceEnemy
	{
		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x0600FD07 RID: 64775 RVA: 0x0005FAC0 File Offset: 0x0005DCC0
		[Token(Token = "0x17002208")]
		public override bool disableUIUnitHud
		{
			[Token(Token = "0x600FD07")]
			[Address(RVA = "0x7485C0", Offset = "0x7471C0", VA = "0x1807485C0", Slot = "196")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600FD08 RID: 64776 RVA: 0x0005FAD8 File Offset: 0x0005DCD8
		// (set) Token: 0x0600FD09 RID: 64777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002209")]
		public bool isSelected
		{
			[Token(Token = "0x600FD08")]
			[Address(RVA = "0x748620", Offset = "0x747220", VA = "0x180748620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600FD09")]
			[Address(RVA = "0x748680", Offset = "0x747280", VA = "0x180748680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600FD0A RID: 64778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD0A")]
		[Address(RVA = "0x7476F0", Offset = "0x7462F0", VA = "0x1807476F0", Slot = "27")]
		public override void OnTick(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FD0B RID: 64779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD0B")]
		[Address(RVA = "0x746F00", Offset = "0x745B00", VA = "0x180746F00", Slot = "127")]
		protected override void OnTakeDamage(ref Modifier modifier, bool force)
		{
		}

		// Token: 0x0600FD0C RID: 64780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD0C")]
		[Address(RVA = "0x7469D0", Offset = "0x7455D0", VA = "0x1807469D0", Slot = "212")]
		public override void KnockBack(Vector2 direction, float force, bool changeFaceByDirection)
		{
		}

		// Token: 0x0600FD0D RID: 64781 RVA: 0x0005FAF0 File Offset: 0x0005DCF0
		[Token(Token = "0x600FD0D")]
		[Address(RVA = "0x746700", Offset = "0x745300", VA = "0x180746700", Slot = "213")]
		public override bool BeginPull(BObject source, Vector2 direction, float force)
		{
			return default(bool);
		}

		// Token: 0x0600FD0E RID: 64782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD0E")]
		[Address(RVA = "0x747930", Offset = "0x746530", VA = "0x180747930", Slot = "221")]
		public override void PlayUnbalanceAnimation()
		{
		}

		// Token: 0x0600FD0F RID: 64783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD0F")]
		[Address(RVA = "0x746900", Offset = "0x745500", VA = "0x180746900")]
		public void KickByEnemy(Vector2 direction, FP forceScale)
		{
		}

		// Token: 0x0600FD10 RID: 64784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD10")]
		[Address(RVA = "0x747D40", Offset = "0x746940", VA = "0x180747D40")]
		private void _FindSurroundingTiles()
		{
		}

		// Token: 0x0600FD11 RID: 64785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD11")]
		[Address(RVA = "0x748180", Offset = "0x746D80", VA = "0x180748180")]
		private void _UpdateUnbalanceAnimation()
		{
		}

		// Token: 0x0600FD12 RID: 64786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD12")]
		[Address(RVA = "0x747BD0", Offset = "0x7467D0", VA = "0x180747BD0")]
		public void UpdateRestitutionFactor(FP value)
		{
		}

		// Token: 0x0600FD13 RID: 64787 RVA: 0x0005FB08 File Offset: 0x0005DD08
		[Token(Token = "0x600FD13")]
		[Address(RVA = "0x747AA0", Offset = "0x7466A0", VA = "0x180747AA0")]
		public bool StopBall(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600FD14 RID: 64788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD14")]
		[Address(RVA = "0x746DF0", Offset = "0x7459F0", VA = "0x180746DF0")]
		public void OnLandFootball()
		{
		}

		// Token: 0x0600FD15 RID: 64789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD15")]
		[Address(RVA = "0x746B20", Offset = "0x745720", VA = "0x180746B20")]
		public void ModifyKickValue(FP value)
		{
		}

		// Token: 0x0600FD16 RID: 64790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD16")]
		[Address(RVA = "0x746850", Offset = "0x745450", VA = "0x180746850", Slot = "174")]
		public override void GatherActionNodes(List<ActionNode> actions)
		{
		}

		// Token: 0x0600FD17 RID: 64791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD17")]
		[Address(RVA = "0x747990", Offset = "0x746590", VA = "0x180747990", Slot = "170")]
		public override void PreloadSpecialAudioSignals(string unitId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x0600FD18 RID: 64792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD18")]
		[Address(RVA = "0x746BB0", Offset = "0x7457B0", VA = "0x180746BB0")]
		private void OnCollisionEnter2D(Collision2D other)
		{
		}

		// Token: 0x0600FD19 RID: 64793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD19")]
		[Address(RVA = "0x747EF0", Offset = "0x746AF0", VA = "0x180747EF0")]
		private void _RunActionsWhenCollide(Entity target)
		{
		}

		// Token: 0x0600FD1A RID: 64794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD1A")]
		[Address(RVA = "0x746E60", Offset = "0x745A60", VA = "0x180746E60", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600FD1B RID: 64795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD1B")]
		[Address(RVA = "0x7482C0", Offset = "0x746EC0", VA = "0x1807482C0")]
		public FootballEnemy()
		{
		}

		// Token: 0x0600FD1C RID: 64796 RVA: 0x0005FB20 File Offset: 0x0005DD20
		[Token(Token = "0x600FD1C")]
		[Address(RVA = "0x747BC0", Offset = "0x7467C0", VA = "0x180747BC0")]
		private bool <>xLuaBaseProxy_get_disableUIUnitHud()
		{
			return default(bool);
		}

		// Token: 0x0600FD1D RID: 64797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD1D")]
		[Address(RVA = "0x6099E0", Offset = "0x6085E0", VA = "0x1806099E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600FD1E RID: 64798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD1E")]
		[Address(RVA = "0x6F2140", Offset = "0x6F0D40", VA = "0x1806F2140")]
		private void <>xLuaBaseProxy_OnTakeDamage(ref Modifier P0, bool P1)
		{
		}

		// Token: 0x0600FD1F RID: 64799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD1F")]
		[Address(RVA = "0x743F20", Offset = "0x742B20", VA = "0x180743F20")]
		private void <>xLuaBaseProxy_KnockBack(Vector2 P0, float P1, bool P2)
		{
		}

		// Token: 0x0600FD20 RID: 64800 RVA: 0x0005FB38 File Offset: 0x0005DD38
		[Token(Token = "0x600FD20")]
		[Address(RVA = "0x747B90", Offset = "0x746790", VA = "0x180747B90")]
		private bool <>xLuaBaseProxy_BeginPull(BObject P0, Vector2 P1, float P2)
		{
			return default(bool);
		}

		// Token: 0x0600FD21 RID: 64801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD21")]
		[Address(RVA = "0x747BB0", Offset = "0x7467B0", VA = "0x180747BB0")]
		private void <>xLuaBaseProxy_PlayUnbalanceAnimation()
		{
		}

		// Token: 0x0600FD22 RID: 64802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD22")]
		[Address(RVA = "0x747BA0", Offset = "0x7467A0", VA = "0x180747BA0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x0600FD23 RID: 64803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD23")]
		[Address(RVA = "0x6099F0", Offset = "0x6085F0", VA = "0x1806099F0")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x0600FD24 RID: 64804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD24")]
		[Address(RVA = "0x6099C0", Offset = "0x6085C0", VA = "0x1806099C0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x04011923 RID: 71971
		[Token(Token = "0x4011923")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		[Group("Football")]
		private FootBallHudPluginTalent _footBallHudPluginTalent;

		// Token: 0x04011924 RID: 71972
		[Token(Token = "0x4011924")]
		[FieldOffset(Offset = "0x538")]
		[SerializeField]
		[Group("Football")]
		private string _collideSignalId;

		// Token: 0x04011925 RID: 71973
		[Token(Token = "0x4011925")]
		[FieldOffset(Offset = "0x540")]
		[SerializeField]
		[Group("Football")]
		private string _takeDamageSignalId;

		// Token: 0x04011926 RID: 71974
		[Token(Token = "0x4011926")]
		[FieldOffset(Offset = "0x548")]
		[SerializeField]
		[Group("Football")]
		private string _unbalancedSignalId;

		// Token: 0x04011927 RID: 71975
		[Token(Token = "0x4011927")]
		[FieldOffset(Offset = "0x550")]
		[SerializeField]
		[Group("Football")]
		private bool _disableIdleAnimation;

		// Token: 0x04011928 RID: 71976
		[Token(Token = "0x4011928")]
		[FieldOffset(Offset = "0x558")]
		[SerializeField]
		[Group("Football")]
		private ActionArray _actionsWhenCollide;

		// Token: 0x04011929 RID: 71977
		[Token(Token = "0x4011929")]
		private const float UNSTOPPABLE_TIME = 0.3f;

		// Token: 0x0401192A RID: 71978
		[Token(Token = "0x401192A")]
		[FieldOffset(Offset = "0x560")]
		private readonly HashSet<Tile> m_surroundTiles;

		// Token: 0x0401192B RID: 71979
		[Token(Token = "0x401192B")]
		[FieldOffset(Offset = "0x568")]
		private FP m_attenuation;

		// Token: 0x0401192C RID: 71980
		[Token(Token = "0x401192C")]
		[FieldOffset(Offset = "0x570")]
		private bool m_isSelected;

		// Token: 0x0401192D RID: 71981
		[Token(Token = "0x401192D")]
		[FieldOffset(Offset = "0x571")]
		private bool m_isUnStoppable;

		// Token: 0x0401192E RID: 71982
		[Token(Token = "0x401192E")]
		[FieldOffset(Offset = "0x578")]
		private readonly Vector2[] m_directionVectors;

		// Token: 0x0401192F RID: 71983
		[Token(Token = "0x401192F")]
		[FieldOffset(Offset = "0x580")]
		private readonly string MOVE_LEFT_KEY;

		// Token: 0x04011930 RID: 71984
		[Token(Token = "0x4011930")]
		[FieldOffset(Offset = "0x588")]
		private readonly string MOVE_RIGHT_KEY;

		// Token: 0x04011931 RID: 71985
		[Token(Token = "0x4011931")]
		[FieldOffset(Offset = "0x590")]
		private readonly PeriodicTimer m_unstoppableTicker;

		// Token: 0x04011932 RID: 71986
		[Token(Token = "0x4011932")]
		[FieldOffset(Offset = "0x598")]
		private Tile m_cacheRootTile;

		// Token: 0x04011934 RID: 71988
		[Token(Token = "0x4011934")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_disableUIUnitHud;

		// Token: 0x04011935 RID: 71989
		[Token(Token = "0x4011935")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSelected;

		// Token: 0x04011936 RID: 71990
		[Token(Token = "0x4011936")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isSelected;

		// Token: 0x04011937 RID: 71991
		[Token(Token = "0x4011937")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011938 RID: 71992
		[Token(Token = "0x4011938")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTakeDamage;

		// Token: 0x04011939 RID: 71993
		[Token(Token = "0x4011939")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_KnockBack;

		// Token: 0x0401193A RID: 71994
		[Token(Token = "0x401193A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BeginPull;

		// Token: 0x0401193B RID: 71995
		[Token(Token = "0x401193B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayUnbalanceAnimation;

		// Token: 0x0401193C RID: 71996
		[Token(Token = "0x401193C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_KickByEnemy;

		// Token: 0x0401193D RID: 71997
		[Token(Token = "0x401193D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FindSurroundingTiles;

		// Token: 0x0401193E RID: 71998
		[Token(Token = "0x401193E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateUnbalanceAnimation;

		// Token: 0x0401193F RID: 71999
		[Token(Token = "0x401193F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateRestitutionFactor;

		// Token: 0x04011940 RID: 72000
		[Token(Token = "0x4011940")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_StopBall;

		// Token: 0x04011941 RID: 72001
		[Token(Token = "0x4011941")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnLandFootball;

		// Token: 0x04011942 RID: 72002
		[Token(Token = "0x4011942")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ModifyKickValue;

		// Token: 0x04011943 RID: 72003
		[Token(Token = "0x4011943")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x04011944 RID: 72004
		[Token(Token = "0x4011944")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04011945 RID: 72005
		[Token(Token = "0x4011945")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnCollisionEnter2D;

		// Token: 0x04011946 RID: 72006
		[Token(Token = "0x4011946")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RunActionsWhenCollide;

		// Token: 0x04011947 RID: 72007
		[Token(Token = "0x4011947")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04011948 RID: 72008
		[Token(Token = "0x4011948")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
