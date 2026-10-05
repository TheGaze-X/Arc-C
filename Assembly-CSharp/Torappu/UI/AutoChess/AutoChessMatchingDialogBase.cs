using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062C1 RID: 25281
	[Token(Token = "0x20062C1")]
	public abstract class AutoChessMatchingDialogBase : UISimpleCompDialog, IValueMsgReceiver
	{
		// Token: 0x060246CB RID: 149195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246CB")]
		[Address(RVA = "0x1F3D7A0", Offset = "0x1F3C3A0", VA = "0x181F3D7A0")]
		private void _InitIfNot(AutoChessMatchingDialogBase.Option option)
		{
		}

		// Token: 0x060246CC RID: 149196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60246CC")]
		[Address(RVA = "0x1F3DE60", Offset = "0x1F3CA60", VA = "0x181F3DE60")]
		private string _InitRandomTipData()
		{
			return null;
		}

		// Token: 0x060246CD RID: 149197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60246CD")]
		[Address(RVA = "0x1F3E000", Offset = "0x1F3CC00", VA = "0x181F3E000")]
		private string _PopNextRandomGameTip()
		{
			return null;
		}

		// Token: 0x060246CE RID: 149198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246CE")]
		[Address(RVA = "0x1F3D3B0", Offset = "0x1F3BFB0", VA = "0x181F3D3B0", Slot = "18")]
		protected sealed override void OnRender(object input)
		{
		}

		// Token: 0x060246CF RID: 149199
		[Token(Token = "0x60246CF")]
		protected abstract void OnFirstRender(AutoChessMatchingDialogBase.Option option);

		// Token: 0x060246D0 RID: 149200
		[Token(Token = "0x60246D0")]
		protected abstract void HandleCancelMatch();

		// Token: 0x060246D1 RID: 149201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246D1")]
		[Address(RVA = "0x1F3CFE0", Offset = "0x1F3BBE0", VA = "0x181F3CFE0")]
		protected void OnMatchResultRet(AutoChessMultiMatchResult result)
		{
		}

		// Token: 0x060246D2 RID: 149202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246D2")]
		[Address(RVA = "0x1F3D6E0", Offset = "0x1F3C2E0", VA = "0x181F3D6E0")]
		private void _CloseDlg()
		{
		}

		// Token: 0x060246D3 RID: 149203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246D3")]
		[Address(RVA = "0x1F3D240", Offset = "0x1F3BE40", VA = "0x181F3D240", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060246D4 RID: 149204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246D4")]
		[Address(RVA = "0x1F3D480", Offset = "0x1F3C080", VA = "0x181F3D480", Slot = "22")]
		protected virtual void OnTick(float timeDelta)
		{
		}

		// Token: 0x060246D5 RID: 149205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246D5")]
		[Address(RVA = "0x1F3E180", Offset = "0x1F3CD80", VA = "0x181F3E180")]
		protected AutoChessMatchingDialogBase()
		{
		}

		// Token: 0x04032B36 RID: 207670
		[Token(Token = "0x4032B36")]
		[NonSerialized]
		public const int MSG_CANCEL_MATCH = 1;

		// Token: 0x04032B37 RID: 207671
		[Token(Token = "0x4032B37")]
		private const float CLOSE_DELAY = 2f;

		// Token: 0x04032B38 RID: 207672
		[Token(Token = "0x4032B38")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected AutoChessMatchingView _matchingViewPrefab;

		// Token: 0x04032B39 RID: 207673
		[Token(Token = "0x4032B39")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04032B3A RID: 207674
		[Token(Token = "0x4032B3A")]
		[FieldOffset(Offset = "0x80")]
		protected UIPageFinder pageFinder;

		// Token: 0x04032B3B RID: 207675
		[Token(Token = "0x4032B3B")]
		[FieldOffset(Offset = "0x90")]
		protected AutoChessMultiMatchViewModel matchViewModel;

		// Token: 0x04032B3C RID: 207676
		[Token(Token = "0x4032B3C")]
		[FieldOffset(Offset = "0x98")]
		private float m_tipRotateInterval;

		// Token: 0x04032B3D RID: 207677
		[Token(Token = "0x4032B3D")]
		[FieldOffset(Offset = "0xA0")]
		private List<AutoChessData.AutoChessGameTipData> m_remainGameTipDatas;

		// Token: 0x04032B3E RID: 207678
		[Token(Token = "0x4032B3E")]
		[FieldOffset(Offset = "0xA8")]
		private List<AutoChessData.AutoChessGameTipData> m_gameTipDatas;

		// Token: 0x04032B3F RID: 207679
		[Token(Token = "0x4032B3F")]
		[FieldOffset(Offset = "0xB0")]
		private AutoChessMatchingView m_matchingView;

		// Token: 0x04032B40 RID: 207680
		[Token(Token = "0x4032B40")]
		[FieldOffset(Offset = "0xB8")]
		private float m_tipRotateCountDown;

		// Token: 0x04032B41 RID: 207681
		[Token(Token = "0x4032B41")]
		[FieldOffset(Offset = "0xBC")]
		private float m_delayCloseCountDown;

		// Token: 0x04032B42 RID: 207682
		[Token(Token = "0x4032B42")]
		[FieldOffset(Offset = "0xC0")]
		private ScaledStopwatch tickInteravalTimer;

		// Token: 0x04032B43 RID: 207683
		[Token(Token = "0x4032B43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032B44 RID: 207684
		[Token(Token = "0x4032B44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitRandomTipData;

		// Token: 0x04032B45 RID: 207685
		[Token(Token = "0x4032B45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PopNextRandomGameTip;

		// Token: 0x04032B46 RID: 207686
		[Token(Token = "0x4032B46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04032B47 RID: 207687
		[Token(Token = "0x4032B47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMatchResultRet;

		// Token: 0x04032B48 RID: 207688
		[Token(Token = "0x4032B48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CloseDlg;

		// Token: 0x04032B49 RID: 207689
		[Token(Token = "0x4032B49")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04032B4A RID: 207690
		[Token(Token = "0x4032B4A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04032B4B RID: 207691
		[Token(Token = "0x4032B4B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062C2 RID: 25282
		[Token(Token = "0x20062C2")]
		public class Option
		{
			// Token: 0x060246D6 RID: 149206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60246D6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04032B4C RID: 207692
			[Token(Token = "0x4032B4C")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04032B4D RID: 207693
			[Token(Token = "0x4032B4D")]
			[FieldOffset(Offset = "0x18")]
			public bool isPrecise;

			// Token: 0x04032B4E RID: 207694
			[Token(Token = "0x4032B4E")]
			[FieldOffset(Offset = "0x20")]
			public string modeId;

			// Token: 0x04032B4F RID: 207695
			[Token(Token = "0x4032B4F")]
			[FieldOffset(Offset = "0x28")]
			public bool canCancel;
		}
	}
}
