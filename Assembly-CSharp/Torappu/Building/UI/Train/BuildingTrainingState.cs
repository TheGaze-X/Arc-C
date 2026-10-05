using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C0C RID: 7180
	[Token(Token = "0x2001C0C")]
	public class BuildingTrainingState : State
	{
		// Token: 0x0600B30E RID: 45838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B30E")]
		[Address(RVA = "0x32E0A20", Offset = "0x32DF620", VA = "0x1832E0A20", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B30F")]
		[Address(RVA = "0x32E0F70", Offset = "0x32DFB70", VA = "0x1832E0F70")]
		private void _InitData()
		{
		}

		// Token: 0x0600B310 RID: 45840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B310")]
		[Address(RVA = "0x32E0A90", Offset = "0x32DF690", VA = "0x1832E0A90")]
		public void OnUpgradeFinish()
		{
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B311")]
		[Address(RVA = "0x32E17A0", Offset = "0x32E03A0", VA = "0x1832E17A0")]
		private IEnumerator _TrainingSucessCoroutine(string charId, string skillId, int skillLevel)
		{
			return null;
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B312")]
		[Address(RVA = "0x32E0700", Offset = "0x32DF300", VA = "0x1832E0700", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B313")]
		[Address(RVA = "0x32E05A0", Offset = "0x32DF1A0", VA = "0x1832E05A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B314 RID: 45844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B314")]
		[Address(RVA = "0x32E08B0", Offset = "0x32DF4B0", VA = "0x1832E08B0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600B315 RID: 45845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B315")]
		[Address(RVA = "0x32E0400", Offset = "0x32DF000", VA = "0x1832E0400")]
		public void EventOnOpenSelectPage()
		{
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B316")]
		[Address(RVA = "0x32E04D0", Offset = "0x32DF0D0", VA = "0x1832E04D0")]
		public void EventOnTrainer()
		{
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B317")]
		[Address(RVA = "0x32E02E0", Offset = "0x32DEEE0", VA = "0x1832E02E0")]
		public void EventOnLvlUp(int index)
		{
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B318")]
		[Address(RVA = "0x32E0540", Offset = "0x32DF140", VA = "0x1832E0540", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B319")]
		[Address(RVA = "0x32E1880", Offset = "0x32E0480", VA = "0x1832E1880")]
		public BuildingTrainingState()
		{
		}

		// Token: 0x0600B31A RID: 45850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B31A")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B31B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B31C RID: 45852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B31C")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0400AE28 RID: 44584
		[Token(Token = "0x400AE28")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingTrainingStateBean _stateBean;

		// Token: 0x0400AE29 RID: 44585
		[Token(Token = "0x400AE29")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _traineeState;

		// Token: 0x0400AE2A RID: 44586
		[Token(Token = "0x400AE2A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _trainerState;

		// Token: 0x0400AE2B RID: 44587
		[Token(Token = "0x400AE2B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _traineeHeadIcon;

		// Token: 0x0400AE2C RID: 44588
		[Token(Token = "0x400AE2C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingTrainingTrainerStatusView _trainerStatus;

		// Token: 0x0400AE2D RID: 44589
		[Token(Token = "0x400AE2D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _trainingPart;

		// Token: 0x0400AE2E RID: 44590
		[Token(Token = "0x400AE2E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _finishTrainingPart;

		// Token: 0x0400AE2F RID: 44591
		[Token(Token = "0x400AE2F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _emptyPart;

		// Token: 0x0400AE30 RID: 44592
		[Token(Token = "0x400AE30")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TwoStateToggle _panelTraineeToggle;

		// Token: 0x0400AE31 RID: 44593
		[Token(Token = "0x400AE31")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private BuildingTrainingTrainerBonusView _bonusView;

		// Token: 0x0400AE32 RID: 44594
		[Token(Token = "0x400AE32")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_updateFlag;

		// Token: 0x0400AE33 RID: 44595
		[Token(Token = "0x400AE33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400AE34 RID: 44596
		[Token(Token = "0x400AE34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0400AE35 RID: 44597
		[Token(Token = "0x400AE35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpgradeFinish;

		// Token: 0x0400AE36 RID: 44598
		[Token(Token = "0x400AE36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TrainingSucessCoroutine;

		// Token: 0x0400AE37 RID: 44599
		[Token(Token = "0x400AE37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400AE38 RID: 44600
		[Token(Token = "0x400AE38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400AE39 RID: 44601
		[Token(Token = "0x400AE39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400AE3A RID: 44602
		[Token(Token = "0x400AE3A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnOpenSelectPage;

		// Token: 0x0400AE3B RID: 44603
		[Token(Token = "0x400AE3B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnTrainer;

		// Token: 0x0400AE3C RID: 44604
		[Token(Token = "0x400AE3C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnLvlUp;

		// Token: 0x0400AE3D RID: 44605
		[Token(Token = "0x400AE3D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400AE3E RID: 44606
		[Token(Token = "0x400AE3E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
