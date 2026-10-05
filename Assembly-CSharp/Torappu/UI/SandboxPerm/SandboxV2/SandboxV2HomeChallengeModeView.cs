using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200432A RID: 17194
	[Token(Token = "0x200432A")]
	public class SandboxV2HomeChallengeModeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A6C7 RID: 108231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6C7")]
		[Address(RVA = "0x13852E0", Offset = "0x1383EE0", VA = "0x1813852E0")]
		public void Render(SandboxV2HomeModel model)
		{
		}

		// Token: 0x0601A6C8 RID: 108232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6C8")]
		[Address(RVA = "0x13854C0", Offset = "0x13840C0", VA = "0x1813854C0")]
		public SandboxV2HomeChallengeModeView()
		{
		}

		// Token: 0x0402190D RID: 137485
		[Token(Token = "0x402190D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2HomeChallengeModeView.LockedView _lockedView;

		// Token: 0x0402190E RID: 137486
		[Token(Token = "0x402190E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2HomeChallengeModeView.UnlockedView _unlockedView;

		// Token: 0x0402190F RID: 137487
		[Token(Token = "0x402190F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _btnBack;

		// Token: 0x04021910 RID: 137488
		[Token(Token = "0x4021910")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04021911 RID: 137489
		[Token(Token = "0x4021911")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021912 RID: 137490
		[Token(Token = "0x4021912")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200432B RID: 17195
		[Token(Token = "0x200432B")]
		[Serializable]
		private class UnlockCondView : IHotfixable
		{
			// Token: 0x0601A6C9 RID: 108233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6C9")]
			[Address(RVA = "0x13A65E0", Offset = "0x13A51E0", VA = "0x1813A65E0")]
			public void Render(SandboxV2ChallengeModeUnlockCondViewModel condViewModel)
			{
			}

			// Token: 0x0601A6CA RID: 108234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6CA")]
			[Address(RVA = "0x13A67C0", Offset = "0x13A53C0", VA = "0x1813A67C0")]
			public UnlockCondView()
			{
			}

			// Token: 0x04021913 RID: 137491
			[Token(Token = "0x4021913")]
			private const string TOTAL_PROGRESS_FORMAT = "/{0}";

			// Token: 0x04021914 RID: 137492
			[Token(Token = "0x4021914")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _condDesc;

			// Token: 0x04021915 RID: 137493
			[Token(Token = "0x4021915")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textCurrProgress;

			// Token: 0x04021916 RID: 137494
			[Token(Token = "0x4021916")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textTotalProgress;

			// Token: 0x04021917 RID: 137495
			[Token(Token = "0x4021917")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private CanvasGroup _canvasIncomplete;

			// Token: 0x04021918 RID: 137496
			[Token(Token = "0x4021918")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private float _alphaCompleted;

			// Token: 0x04021919 RID: 137497
			[Token(Token = "0x4021919")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private GameObject _pnlCompleted;

			// Token: 0x0402191A RID: 137498
			[Token(Token = "0x402191A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402191B RID: 137499
			[Token(Token = "0x402191B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200432C RID: 17196
		[Token(Token = "0x200432C")]
		[Serializable]
		private class LockedView : IHotfixable
		{
			// Token: 0x0601A6CB RID: 108235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6CB")]
			[Address(RVA = "0x1384C60", Offset = "0x1383860", VA = "0x181384C60")]
			public void Render(SandboxV2ChallengeModeViewModel viewModel)
			{
			}

			// Token: 0x0601A6CC RID: 108236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6CC")]
			[Address(RVA = "0x1384D60", Offset = "0x1383960", VA = "0x181384D60")]
			public LockedView()
			{
			}

			// Token: 0x0402191C RID: 137500
			[Token(Token = "0x402191C")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x0402191D RID: 137501
			[Token(Token = "0x402191D")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private SandboxV2HomeChallengeModeView.UnlockCondView _condView1;

			// Token: 0x0402191E RID: 137502
			[Token(Token = "0x402191E")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private SandboxV2HomeChallengeModeView.UnlockCondView _condView2;

			// Token: 0x0402191F RID: 137503
			[Token(Token = "0x402191F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04021920 RID: 137504
			[Token(Token = "0x4021920")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200432D RID: 17197
		[Token(Token = "0x200432D")]
		[Serializable]
		private class HistoryView : IHotfixable
		{
			// Token: 0x0601A6CD RID: 108237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6CD")]
			[Address(RVA = "0x13844E0", Offset = "0x13830E0", VA = "0x1813844E0")]
			public void Render(SandboxV2ChallengeModeHistoryViewModel viewModel)
			{
			}

			// Token: 0x0601A6CE RID: 108238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6CE")]
			[Address(RVA = "0x1384A10", Offset = "0x1383610", VA = "0x181384A10")]
			public HistoryView()
			{
			}

			// Token: 0x04021921 RID: 137505
			[Token(Token = "0x4021921")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _textTs;

			// Token: 0x04021922 RID: 137506
			[Token(Token = "0x4021922")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _pnlNoRecord;

			// Token: 0x04021923 RID: 137507
			[Token(Token = "0x4021923")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _pnlRecord;

			// Token: 0x04021924 RID: 137508
			[Token(Token = "0x4021924")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textChallengeDay;

			// Token: 0x04021925 RID: 137509
			[Token(Token = "0x4021925")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textStartDay;

			// Token: 0x04021926 RID: 137510
			[Token(Token = "0x4021926")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Text _textStartLoadTimes;

			// Token: 0x04021927 RID: 137511
			[Token(Token = "0x4021927")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04021928 RID: 137512
			[Token(Token = "0x4021928")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200432E RID: 17198
		[Token(Token = "0x200432E")]
		[Serializable]
		private class CurrView : IHotfixable
		{
			// Token: 0x0601A6CF RID: 108239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6CF")]
			[Address(RVA = "0x1384230", Offset = "0x1382E30", VA = "0x181384230")]
			public void Render(SandboxV2ChallengeModeCurrentViewModel viewModel)
			{
			}

			// Token: 0x0601A6D0 RID: 108240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6D0")]
			[Address(RVA = "0x1384480", Offset = "0x1383080", VA = "0x181384480")]
			public CurrView()
			{
			}

			// Token: 0x04021929 RID: 137513
			[Token(Token = "0x4021929")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlInChallenge;

			// Token: 0x0402192A RID: 137514
			[Token(Token = "0x402192A")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textStatus;

			// Token: 0x0402192B RID: 137515
			[Token(Token = "0x402192B")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _pnlNoRecord;

			// Token: 0x0402192C RID: 137516
			[Token(Token = "0x402192C")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textNoRecordStartDay;

			// Token: 0x0402192D RID: 137517
			[Token(Token = "0x402192D")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private GameObject _pnlRecord;

			// Token: 0x0402192E RID: 137518
			[Token(Token = "0x402192E")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Text _textChallengeDay;

			// Token: 0x0402192F RID: 137519
			[Token(Token = "0x402192F")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Text _textStartDay;

			// Token: 0x04021930 RID: 137520
			[Token(Token = "0x4021930")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Text _textStartLoadTimes;

			// Token: 0x04021931 RID: 137521
			[Token(Token = "0x4021931")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04021932 RID: 137522
			[Token(Token = "0x4021932")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200432F RID: 17199
		[Token(Token = "0x200432F")]
		[Serializable]
		private class UnlockedView : IHotfixable
		{
			// Token: 0x0601A6D1 RID: 108241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6D1")]
			[Address(RVA = "0x13A6830", Offset = "0x13A5430", VA = "0x1813A6830")]
			public void Render(SandboxV2ChallengeModeViewModel viewModel)
			{
			}

			// Token: 0x0601A6D2 RID: 108242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6D2")]
			[Address(RVA = "0x13A69F0", Offset = "0x13A55F0", VA = "0x1813A69F0")]
			public UnlockedView()
			{
			}

			// Token: 0x04021933 RID: 137523
			[Token(Token = "0x4021933")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x04021934 RID: 137524
			[Token(Token = "0x4021934")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private SandboxV2HomeChallengeModeView.HistoryView _historyBest;

			// Token: 0x04021935 RID: 137525
			[Token(Token = "0x4021935")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private SandboxV2HomeChallengeModeView.HistoryView _historyLast;

			// Token: 0x04021936 RID: 137526
			[Token(Token = "0x4021936")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private SandboxV2HomeChallengeModeView.CurrView _currRecord;

			// Token: 0x04021937 RID: 137527
			[Token(Token = "0x4021937")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private GameObject _pnlEnter;

			// Token: 0x04021938 RID: 137528
			[Token(Token = "0x4021938")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private GameObject _pnlSettle;

			// Token: 0x04021939 RID: 137529
			[Token(Token = "0x4021939")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private GameObject _pnlInRift;

			// Token: 0x0402193A RID: 137530
			[Token(Token = "0x402193A")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Text _textStart;

			// Token: 0x0402193B RID: 137531
			[Token(Token = "0x402193B")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private GameObject _trackPointReward;

			// Token: 0x0402193C RID: 137532
			[Token(Token = "0x402193C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402193D RID: 137533
			[Token(Token = "0x402193D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
