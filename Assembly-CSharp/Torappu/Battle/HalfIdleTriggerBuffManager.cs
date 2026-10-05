using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002329 RID: 9001
	[Token(Token = "0x2002329")]
	public class HalfIdleTriggerBuffManager : GlobalEnvSystem.EnvManager, IHotfixable
	{
		// Token: 0x0600E364 RID: 58212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E364")]
		[Address(RVA = "0x5784F0", Offset = "0x5770F0", VA = "0x1805784F0", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E365 RID: 58213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E365")]
		[Address(RVA = "0x5787C0", Offset = "0x5773C0", VA = "0x1805787C0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E366 RID: 58214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E366")]
		[Address(RVA = "0x578860", Offset = "0x577460", VA = "0x180578860")]
		private void _OnGameStart()
		{
		}

		// Token: 0x0600E367 RID: 58215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E367")]
		[Address(RVA = "0x5789B0", Offset = "0x5775B0", VA = "0x1805789B0")]
		private void _OnHalfIdleGainEquip()
		{
		}

		// Token: 0x0600E368 RID: 58216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E368")]
		[Address(RVA = "0x578700", Offset = "0x577300", VA = "0x180578700")]
		public void OnDestroy()
		{
		}

		// Token: 0x0600E369 RID: 58217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E369")]
		[Address(RVA = "0x578B00", Offset = "0x577700", VA = "0x180578B00")]
		public HalfIdleTriggerBuffManager()
		{
		}

		// Token: 0x0600E36C RID: 58220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E36C")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E36D RID: 58221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E36D")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F9D5 RID: 63957
		[Token(Token = "0x400F9D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<HalfIdleTriggerBuffManager.ActionsToTrigger> _actionsToTrigger;

		// Token: 0x0400F9D6 RID: 63958
		[Token(Token = "0x400F9D6")]
		[FieldOffset(Offset = "0x30")]
		private bool m_firstTicked;

		// Token: 0x0400F9D7 RID: 63959
		[Token(Token = "0x400F9D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F9D8 RID: 63960
		[Token(Token = "0x400F9D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F9D9 RID: 63961
		[Token(Token = "0x400F9D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0400F9DA RID: 63962
		[Token(Token = "0x400F9DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnHalfIdleGainEquip;

		// Token: 0x0400F9DB RID: 63963
		[Token(Token = "0x400F9DB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F9DC RID: 63964
		[Token(Token = "0x400F9DC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200232A RID: 9002
		[Token(Token = "0x200232A")]
		[Serializable]
		public class ActionsToTrigger
		{
			// Token: 0x17001C84 RID: 7300
			// (get) Token: 0x0600E36E RID: 58222 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001C84")]
			public string activeBlackboardKey
			{
				[Token(Token = "0x600E36E")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001C85 RID: 7301
			// (get) Token: 0x0600E36F RID: 58223 RVA: 0x00052560 File Offset: 0x00050760
			[Token(Token = "0x17001C85")]
			public HalfIdleTriggerBuffManager.ActionsToTrigger.TriggerTimeslot triggerTimeslot
			{
				[Token(Token = "0x600E36F")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return HalfIdleTriggerBuffManager.ActionsToTrigger.TriggerTimeslot.NONE;
				}
			}

			// Token: 0x17001C86 RID: 7302
			// (get) Token: 0x0600E370 RID: 58224 RVA: 0x00052578 File Offset: 0x00050778
			[Token(Token = "0x17001C86")]
			public bool active
			{
				[Token(Token = "0x600E370")]
				[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600E371 RID: 58225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E371")]
			[Address(RVA = "0x5663F0", Offset = "0x564FF0", VA = "0x1805663F0")]
			public void SetDataFromGlobalBlackboard(BattleGlobalBlackboard gblackboard)
			{
			}

			// Token: 0x0600E372 RID: 58226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E372")]
			[Address(RVA = "0x566220", Offset = "0x564E20", VA = "0x180566220")]
			public void RunActions()
			{
			}

			// Token: 0x0600E373 RID: 58227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E373")]
			[Address(RVA = "0x566600", Offset = "0x565200", VA = "0x180566600")]
			public ActionsToTrigger()
			{
			}

			// Token: 0x0400F9DD RID: 63965
			[Token(Token = "0x400F9DD")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _activeBlackboardKey;

			// Token: 0x0400F9DE RID: 63966
			[Token(Token = "0x400F9DE")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private HalfIdleTriggerBuffManager.ActionsToTrigger.TriggerTimeslot _triggerTimeslot;

			// Token: 0x0400F9DF RID: 63967
			[Token(Token = "0x400F9DF")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private BattleGlobalBlackboard.BlackboardChannel _gbbChanel;

			// Token: 0x0400F9E0 RID: 63968
			[Token(Token = "0x400F9E0")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private List<string> _blackboardKeys;

			// Token: 0x0400F9E1 RID: 63969
			[Token(Token = "0x400F9E1")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private ActionArray _actions;

			// Token: 0x0400F9E2 RID: 63970
			[Token(Token = "0x400F9E2")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public Blackboard actionBlackboard;

			// Token: 0x0400F9E3 RID: 63971
			[Token(Token = "0x400F9E3")]
			[FieldOffset(Offset = "0x38")]
			private bool m_active;

			// Token: 0x0200232B RID: 9003
			[Token(Token = "0x200232B")]
			public enum TriggerTimeslot
			{
				// Token: 0x0400F9E5 RID: 63973
				[Token(Token = "0x400F9E5")]
				NONE,
				// Token: 0x0400F9E6 RID: 63974
				[Token(Token = "0x400F9E6")]
				GAMESTART,
				// Token: 0x0400F9E7 RID: 63975
				[Token(Token = "0x400F9E7")]
				GAINEQUIP
			}
		}
	}
}
