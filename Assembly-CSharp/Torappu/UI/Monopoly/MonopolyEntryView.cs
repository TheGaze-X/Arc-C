using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047EF RID: 18415
	[Token(Token = "0x20047EF")]
	public class MonopolyEntryView : DataBinder<MonopolyEntryProperty>
	{
		// Token: 0x0601BDA6 RID: 114086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDA6")]
		[Address(RVA = "0x1539820", Offset = "0x1538420", VA = "0x181539820", Slot = "7")]
		public override void OnValueChanged(MonopolyEntryProperty property)
		{
		}

		// Token: 0x0601BDA7 RID: 114087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDA7")]
		[Address(RVA = "0x1539E40", Offset = "0x1538A40", VA = "0x181539E40")]
		private void _SwitchToStage(int toIndex)
		{
		}

		// Token: 0x0601BDA8 RID: 114088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDA8")]
		[Address(RVA = "0x1539C00", Offset = "0x1538800", VA = "0x181539C00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BDA9 RID: 114089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDA9")]
		[Address(RVA = "0x1539530", Offset = "0x1538130", VA = "0x181539530")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x0601BDAA RID: 114090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDAA")]
		[Address(RVA = "0x15395C0", Offset = "0x15381C0", VA = "0x1815395C0")]
		public void OnClickLeftArrowBtn()
		{
		}

		// Token: 0x0601BDAB RID: 114091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDAB")]
		[Address(RVA = "0x1539660", Offset = "0x1538260", VA = "0x181539660")]
		public void OnClickRightArrowBtn()
		{
		}

		// Token: 0x0601BDAC RID: 114092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDAC")]
		[Address(RVA = "0x1539790", Offset = "0x1538390", VA = "0x181539790")]
		public void OnClickStartGameBtn()
		{
		}

		// Token: 0x0601BDAD RID: 114093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDAD")]
		[Address(RVA = "0x1539700", Offset = "0x1538300", VA = "0x181539700")]
		public void OnClickSettleGameBtn()
		{
		}

		// Token: 0x0601BDAE RID: 114094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDAE")]
		[Address(RVA = "0x153A2B0", Offset = "0x1538EB0", VA = "0x18153A2B0")]
		public MonopolyEntryView()
		{
		}

		// Token: 0x0402440A RID: 148490
		[Token(Token = "0x402440A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x0402440B RID: 148491
		[Token(Token = "0x402440B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageDesc;

		// Token: 0x0402440C RID: 148492
		[Token(Token = "0x402440C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _targetMissionCnt;

		// Token: 0x0402440D RID: 148493
		[Token(Token = "0x402440D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _recordPanel;

		// Token: 0x0402440E RID: 148494
		[Token(Token = "0x402440E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _highestMissionCnt;

		// Token: 0x0402440F RID: 148495
		[Token(Token = "0x402440F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x04024410 RID: 148496
		[Token(Token = "0x4024410")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _progressContent;

		// Token: 0x04024411 RID: 148497
		[Token(Token = "0x4024411")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _lockPanel;

		// Token: 0x04024412 RID: 148498
		[Token(Token = "0x4024412")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _lockDesc;

		// Token: 0x04024413 RID: 148499
		[Token(Token = "0x4024413")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _playingPanel;

		// Token: 0x04024414 RID: 148500
		[Token(Token = "0x4024414")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _playingDesc;

		// Token: 0x04024415 RID: 148501
		[Token(Token = "0x4024415")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _completePanel;

		// Token: 0x04024416 RID: 148502
		[Token(Token = "0x4024416")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _startBtnObj;

		// Token: 0x04024417 RID: 148503
		[Token(Token = "0x4024417")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _continueBtnObj;

		// Token: 0x04024418 RID: 148504
		[Token(Token = "0x4024418")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _settleBtnObj;

		// Token: 0x04024419 RID: 148505
		[Token(Token = "0x4024419")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _leftArrow;

		// Token: 0x0402441A RID: 148506
		[Token(Token = "0x402441A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _rightArrow;

		// Token: 0x0402441B RID: 148507
		[Token(Token = "0x402441B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _hasNewOnRight;

		// Token: 0x0402441C RID: 148508
		[Token(Token = "0x402441C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _sampleAnimLocation;

		// Token: 0x0402441D RID: 148509
		[Token(Token = "0x402441D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _samplePosForOneStage;

		// Token: 0x0402441E RID: 148510
		[Token(Token = "0x402441E")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float _sampleDuration;

		// Token: 0x0402441F RID: 148511
		[Token(Token = "0x402441F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _sampleDurationBack;

		// Token: 0x04024420 RID: 148512
		[Token(Token = "0x4024420")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private Ease _sampleEase;

		// Token: 0x04024421 RID: 148513
		[Token(Token = "0x4024421")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Ease _sampleEaseBack;

		// Token: 0x04024422 RID: 148514
		[Token(Token = "0x4024422")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float _canClickInterval;

		// Token: 0x04024423 RID: 148515
		[Token(Token = "0x4024423")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAnimationLocation _stageInAnimLocation;

		// Token: 0x04024424 RID: 148516
		[Token(Token = "0x4024424")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _taskNormalIcon;

		// Token: 0x04024425 RID: 148517
		[Token(Token = "0x4024425")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _taskExcellentIcon;

		// Token: 0x04024426 RID: 148518
		[Token(Token = "0x4024426")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Font _kjeragDigitFont;

		// Token: 0x04024427 RID: 148519
		[Token(Token = "0x4024427")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text[] _textUseKjeragFont;

		// Token: 0x04024428 RID: 148520
		[Token(Token = "0x4024428")]
		[FieldOffset(Offset = "0x108")]
		private MonopolyEntryModel m_cachedEntryModel;

		// Token: 0x04024429 RID: 148521
		[Token(Token = "0x4024429")]
		[FieldOffset(Offset = "0x110")]
		private bool m_isInited;

		// Token: 0x0402442A RID: 148522
		[Token(Token = "0x402442A")]
		[FieldOffset(Offset = "0x118")]
		private MonopolyEntryView.ProgressLayoutAdapter m_progressAdapter;

		// Token: 0x0402442B RID: 148523
		[Token(Token = "0x402442B")]
		[FieldOffset(Offset = "0x120")]
		private MonopolyEntryView.RewardLayoutAdapter m_rewardAdapter;

		// Token: 0x0402442C RID: 148524
		[Token(Token = "0x402442C")]
		[FieldOffset(Offset = "0x128")]
		private int m_switchStageSeqNum;

		// Token: 0x0402442D RID: 148525
		[Token(Token = "0x402442D")]
		[FieldOffset(Offset = "0x130")]
		private Tween m_switchStageTween;

		// Token: 0x0402442E RID: 148526
		[Token(Token = "0x402442E")]
		[FieldOffset(Offset = "0x138")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402442F RID: 148527
		[Token(Token = "0x402442F")]
		[FieldOffset(Offset = "0x148")]
		private int m_cachedStageIndex;

		// Token: 0x04024430 RID: 148528
		[Token(Token = "0x4024430")]
		[FieldOffset(Offset = "0x14C")]
		private bool m_canClickArrow;

		// Token: 0x04024431 RID: 148529
		[Token(Token = "0x4024431")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024432 RID: 148530
		[Token(Token = "0x4024432")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SwitchToStage;

		// Token: 0x04024433 RID: 148531
		[Token(Token = "0x4024433")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024434 RID: 148532
		[Token(Token = "0x4024434")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x04024435 RID: 148533
		[Token(Token = "0x4024435")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickLeftArrowBtn;

		// Token: 0x04024436 RID: 148534
		[Token(Token = "0x4024436")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickRightArrowBtn;

		// Token: 0x04024437 RID: 148535
		[Token(Token = "0x4024437")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickStartGameBtn;

		// Token: 0x04024438 RID: 148536
		[Token(Token = "0x4024438")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickSettleGameBtn;

		// Token: 0x04024439 RID: 148537
		[Token(Token = "0x4024439")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047F0 RID: 18416
		[Token(Token = "0x20047F0")]
		public class ProgressLayoutAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601BDAF RID: 114095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BDAF")]
			[Address(RVA = "0x1549090", Offset = "0x1547C90", VA = "0x181549090")]
			public ProgressLayoutAdapter(MonopolyEntryView closure)
			{
			}

			// Token: 0x17004239 RID: 16953
			// (get) Token: 0x0601BDB0 RID: 114096 RVA: 0x000A6740 File Offset: 0x000A4940
			[Token(Token = "0x17004239")]
			public override int count
			{
				[Token(Token = "0x601BDB0")]
				[Address(RVA = "0x1549110", Offset = "0x1547D10", VA = "0x181549110", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BDB1 RID: 114097 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BDB1")]
			[Address(RVA = "0x1548E60", Offset = "0x1547A60", VA = "0x181548E60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402443A RID: 148538
			[Token(Token = "0x402443A")]
			[FieldOffset(Offset = "0x20")]
			private MonopolyEntryView m_closure;

			// Token: 0x0402443B RID: 148539
			[Token(Token = "0x402443B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402443C RID: 148540
			[Token(Token = "0x402443C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402443D RID: 148541
			[Token(Token = "0x402443D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020047F1 RID: 18417
		[Token(Token = "0x20047F1")]
		public class RewardLayoutAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601BDB2 RID: 114098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BDB2")]
			[Address(RVA = "0x15493F0", Offset = "0x1547FF0", VA = "0x1815493F0")]
			public RewardLayoutAdapter(MonopolyEntryView closure)
			{
			}

			// Token: 0x1700423A RID: 16954
			// (get) Token: 0x0601BDB3 RID: 114099 RVA: 0x000A6758 File Offset: 0x000A4958
			[Token(Token = "0x1700423A")]
			public override int count
			{
				[Token(Token = "0x601BDB3")]
				[Address(RVA = "0x1549470", Offset = "0x1548070", VA = "0x181549470", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BDB4 RID: 114100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BDB4")]
			[Address(RVA = "0x15491F0", Offset = "0x1547DF0", VA = "0x1815491F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402443E RID: 148542
			[Token(Token = "0x402443E")]
			[FieldOffset(Offset = "0x20")]
			private MonopolyEntryView m_closure;

			// Token: 0x0402443F RID: 148543
			[Token(Token = "0x402443F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04024440 RID: 148544
			[Token(Token = "0x4024440")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04024441 RID: 148545
			[Token(Token = "0x4024441")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
