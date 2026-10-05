using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006086 RID: 24710
	[Token(Token = "0x2006086")]
	public class CarvingMainRoundEndState : PopupFadeState, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x06023BCA RID: 146378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023BCA")]
		[Address(RVA = "0x1E61210", Offset = "0x1E5FE10", VA = "0x181E61210", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023BCB RID: 146379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BCB")]
		[Address(RVA = "0x1E61270", Offset = "0x1E5FE70", VA = "0x181E61270", Slot = "31")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06023BCC RID: 146380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BCC")]
		[Address(RVA = "0x1E616D0", Offset = "0x1E602D0", VA = "0x181E616D0")]
		public void OnClickStartNewRoundBtn()
		{
		}

		// Token: 0x06023BCD RID: 146381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BCD")]
		[Address(RVA = "0x1E61470", Offset = "0x1E60070", VA = "0x181E61470")]
		public void OnClickEndClassBtn()
		{
		}

		// Token: 0x06023BCE RID: 146382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BCE")]
		[Address(RVA = "0x1E617C0", Offset = "0x1E603C0", VA = "0x181E617C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023BCF RID: 146383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023BCF")]
		[Address(RVA = "0x1E61320", Offset = "0x1E5FF20", VA = "0x181E61320", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06023BD0 RID: 146384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BD0")]
		[Address(RVA = "0x1E61AF0", Offset = "0x1E606F0", VA = "0x181E61AF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023BD1 RID: 146385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BD1")]
		[Address(RVA = "0x1E62130", Offset = "0x1E60D30", VA = "0x181E62130")]
		private void _ToNextRound()
		{
		}

		// Token: 0x06023BD2 RID: 146386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BD2")]
		[Address(RVA = "0x1E61E40", Offset = "0x1E60A40", VA = "0x181E61E40")]
		private void _ShowConfirmDialog()
		{
		}

		// Token: 0x06023BD3 RID: 146387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BD3")]
		[Address(RVA = "0x1E61BD0", Offset = "0x1E607D0", VA = "0x181E61BD0")]
		private void _OnSettleProceed(CarvingSettleResponse response)
		{
		}

		// Token: 0x06023BD4 RID: 146388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BD4")]
		[Address(RVA = "0x1E62410", Offset = "0x1E61010", VA = "0x181E62410")]
		public CarvingMainRoundEndState()
		{
		}

		// Token: 0x06023BD6 RID: 146390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BD6")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023BD7 RID: 146391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023BD7")]
		[Address(RVA = "0x180FDD0", Offset = "0x180E9D0", VA = "0x18180FDD0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x04031881 RID: 202881
		[Token(Token = "0x4031881")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CarvingMainRoundEndView _view;

		// Token: 0x04031882 RID: 202882
		[Token(Token = "0x4031882")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x04031883 RID: 202883
		[Token(Token = "0x4031883")]
		[FieldOffset(Offset = "0x7C")]
		private int m_confirmDialogInstId;

		// Token: 0x04031884 RID: 202884
		[Token(Token = "0x4031884")]
		[FieldOffset(Offset = "0x80")]
		private int m_settleDialogInstId;

		// Token: 0x04031885 RID: 202885
		[Token(Token = "0x4031885")]
		[FieldOffset(Offset = "0x88")]
		private string m_actId;

		// Token: 0x04031886 RID: 202886
		[Token(Token = "0x4031886")]
		[FieldOffset(Offset = "0x90")]
		private CarvingMainRoundEndStateBean m_stateBean;

		// Token: 0x04031887 RID: 202887
		[Token(Token = "0x4031887")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031888 RID: 202888
		[Token(Token = "0x4031888")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04031889 RID: 202889
		[Token(Token = "0x4031889")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickStartNewRoundBtn;

		// Token: 0x0403188A RID: 202890
		[Token(Token = "0x403188A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickEndClassBtn;

		// Token: 0x0403188B RID: 202891
		[Token(Token = "0x403188B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403188C RID: 202892
		[Token(Token = "0x403188C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403188D RID: 202893
		[Token(Token = "0x403188D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403188E RID: 202894
		[Token(Token = "0x403188E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ToNextRound;

		// Token: 0x0403188F RID: 202895
		[Token(Token = "0x403188F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowConfirmDialog;

		// Token: 0x04031890 RID: 202896
		[Token(Token = "0x4031890")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSettleProceed;

		// Token: 0x04031891 RID: 202897
		[Token(Token = "0x4031891")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
