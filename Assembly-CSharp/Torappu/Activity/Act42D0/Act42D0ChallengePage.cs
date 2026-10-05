using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007333 RID: 29491
	[Token(Token = "0x2007333")]
	public class Act42D0ChallengePage : StateEnginePage, IValueMsgReceiver
	{
		// Token: 0x06029B45 RID: 170821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B45")]
		[Address(RVA = "0x2504830", Offset = "0x2503430", VA = "0x182504830")]
		private DataBundle _CreateRecoverDataBundleForBattle()
		{
			return null;
		}

		// Token: 0x06029B46 RID: 170822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B46")]
		[Address(RVA = "0x25047C0", Offset = "0x25033C0", VA = "0x1825047C0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06029B47 RID: 170823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B47")]
		[Address(RVA = "0x2505710", Offset = "0x2504310", VA = "0x182505710")]
		private void _TriggerTutorialAVG()
		{
		}

		// Token: 0x06029B48 RID: 170824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B48")]
		[Address(RVA = "0x25042B0", Offset = "0x2502EB0", VA = "0x1825042B0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06029B49 RID: 170825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B49")]
		[Address(RVA = "0x25049F0", Offset = "0x25035F0", VA = "0x1825049F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029B4A RID: 170826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B4A")]
		[Address(RVA = "0x2504CE0", Offset = "0x25038E0", VA = "0x182504CE0")]
		private void _OnBackClick()
		{
		}

		// Token: 0x06029B4B RID: 170827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B4B")]
		[Address(RVA = "0x2504370", Offset = "0x2502F70", VA = "0x182504370")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x06029B4C RID: 170828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B4C")]
		[Address(RVA = "0x2504400", Offset = "0x2503000", VA = "0x182504400", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06029B4D RID: 170829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B4D")]
		[Address(RVA = "0x2504E60", Offset = "0x2503A60", VA = "0x182504E60")]
		private void _OnClickMap(string stageId)
		{
		}

		// Token: 0x06029B4E RID: 170830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B4E")]
		[Address(RVA = "0x2504D40", Offset = "0x2503940", VA = "0x182504D40")]
		private void _OnClickEnemy(string levelId)
		{
		}

		// Token: 0x06029B4F RID: 170831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B4F")]
		[Address(RVA = "0x25050C0", Offset = "0x2503CC0", VA = "0x1825050C0")]
		private void _OnStartBattle()
		{
		}

		// Token: 0x06029B50 RID: 170832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B50")]
		[Address(RVA = "0x2504F90", Offset = "0x2503B90", VA = "0x182504F90")]
		private void _OnStageClick(string stageId)
		{
		}

		// Token: 0x06029B51 RID: 170833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B51")]
		[Address(RVA = "0x2505770", Offset = "0x2504370", VA = "0x182505770")]
		public Act42D0ChallengePage()
		{
		}

		// Token: 0x06029B53 RID: 170835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B53")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06029B54 RID: 170836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B54")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0403BB10 RID: 244496
		[Token(Token = "0x403BB10")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Act42D0ChallengeStageDetailView _stageDetailView;

		// Token: 0x0403BB11 RID: 244497
		[Token(Token = "0x403BB11")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _stageDetailRect;

		// Token: 0x0403BB12 RID: 244498
		[Token(Token = "0x403BB12")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform _rectMapPreview;

		// Token: 0x0403BB13 RID: 244499
		[Token(Token = "0x403BB13")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ActivityStageMapPreviewView _mapPreview;

		// Token: 0x0403BB14 RID: 244500
		[Token(Token = "0x403BB14")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private RectTransform _rectChallengeMapRect;

		// Token: 0x0403BB15 RID: 244501
		[Token(Token = "0x403BB15")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Act42d0ChallengeAreaGroupView _challengeViewPrefab;

		// Token: 0x0403BB16 RID: 244502
		[Token(Token = "0x403BB16")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Transform _topBarContainer;

		// Token: 0x0403BB17 RID: 244503
		[Token(Token = "0x403BB17")]
		public const string KEY_PARAM_BUNDLE = "key_act42d0_challenge_param";

		// Token: 0x0403BB18 RID: 244504
		[Token(Token = "0x403BB18")]
		[FieldOffset(Offset = "0x128")]
		private bool m_hasInited;

		// Token: 0x0403BB19 RID: 244505
		[Token(Token = "0x403BB19")]
		[FieldOffset(Offset = "0x130")]
		private string m_actId;

		// Token: 0x0403BB1A RID: 244506
		[Token(Token = "0x403BB1A")]
		[FieldOffset(Offset = "0x138")]
		private Act42D0ChallengeStageGroupProperty m_prop;

		// Token: 0x0403BB1B RID: 244507
		[Token(Token = "0x403BB1B")]
		[FieldOffset(Offset = "0x140")]
		private Act42D0ChallengeStageDetailView m_stageDetailView;

		// Token: 0x0403BB1C RID: 244508
		[Token(Token = "0x403BB1C")]
		[FieldOffset(Offset = "0x148")]
		private ActivityStageMapPreviewView m_stageMapPreviewView;

		// Token: 0x0403BB1D RID: 244509
		[Token(Token = "0x403BB1D")]
		[FieldOffset(Offset = "0x150")]
		private Act42d0ChallengeAreaGroupView m_stageMapView;

		// Token: 0x0403BB1E RID: 244510
		[Token(Token = "0x403BB1E")]
		[NonSerialized]
		public const int MSG_CLICK_MAP = 0;

		// Token: 0x0403BB1F RID: 244511
		[Token(Token = "0x403BB1F")]
		[NonSerialized]
		public const int MSG_CLICK_ENEMY = 1;

		// Token: 0x0403BB20 RID: 244512
		[Token(Token = "0x403BB20")]
		[NonSerialized]
		public const int MSG_CLICK_START_BATTLE = 2;

		// Token: 0x0403BB21 RID: 244513
		[Token(Token = "0x403BB21")]
		[NonSerialized]
		public const int MSG_CLICK_STAGE = 3;

		// Token: 0x0403BB22 RID: 244514
		[Token(Token = "0x403BB22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CreateRecoverDataBundleForBattle;

		// Token: 0x0403BB23 RID: 244515
		[Token(Token = "0x403BB23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403BB24 RID: 244516
		[Token(Token = "0x403BB24")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x0403BB25 RID: 244517
		[Token(Token = "0x403BB25")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0403BB26 RID: 244518
		[Token(Token = "0x403BB26")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BB27 RID: 244519
		[Token(Token = "0x403BB27")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x0403BB28 RID: 244520
		[Token(Token = "0x403BB28")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x0403BB29 RID: 244521
		[Token(Token = "0x403BB29")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403BB2A RID: 244522
		[Token(Token = "0x403BB2A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnClickMap;

		// Token: 0x0403BB2B RID: 244523
		[Token(Token = "0x403BB2B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnClickEnemy;

		// Token: 0x0403BB2C RID: 244524
		[Token(Token = "0x403BB2C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnStartBattle;

		// Token: 0x0403BB2D RID: 244525
		[Token(Token = "0x403BB2D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStageClick;

		// Token: 0x0403BB2E RID: 244526
		[Token(Token = "0x403BB2E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007334 RID: 29492
		[Token(Token = "0x2007334")]
		public class Param : ICustomPageParam, IHotfixable
		{
			// Token: 0x06029B55 RID: 170837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029B55")]
			[Address(RVA = "0x251BAF0", Offset = "0x251A6F0", VA = "0x18251BAF0")]
			public string Serialize()
			{
				return null;
			}

			// Token: 0x06029B56 RID: 170838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029B56")]
			[Address(RVA = "0x251B9A0", Offset = "0x251A5A0", VA = "0x18251B9A0")]
			public static Act42D0ChallengePage.Param Deserialize(string str)
			{
				return null;
			}

			// Token: 0x06029B57 RID: 170839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029B57")]
			[Address(RVA = "0x251BB70", Offset = "0x251A770", VA = "0x18251BB70")]
			public Param()
			{
			}

			// Token: 0x0403BB2F RID: 244527
			[Token(Token = "0x403BB2F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403BB30 RID: 244528
			[Token(Token = "0x403BB30")]
			[FieldOffset(Offset = "0x18")]
			public string selectStageId;

			// Token: 0x0403BB31 RID: 244529
			[Token(Token = "0x403BB31")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Serialize;

			// Token: 0x0403BB32 RID: 244530
			[Token(Token = "0x403BB32")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Deserialize;

			// Token: 0x0403BB33 RID: 244531
			[Token(Token = "0x403BB33")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
