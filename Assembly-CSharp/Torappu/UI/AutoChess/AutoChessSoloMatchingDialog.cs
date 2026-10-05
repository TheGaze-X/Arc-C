using System;
using Il2CppDummyDll;
using Torappu.Network;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062C4 RID: 25284
	[Token(Token = "0x20062C4")]
	public class AutoChessSoloMatchingDialog : AutoChessMatchingDialogBase
	{
		// Token: 0x060246DB RID: 149211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246DB")]
		[Address(RVA = "0x1F4F500", Offset = "0x1F4E100", VA = "0x181F4F500")]
		private void _InitMultiSoloMatchRequests()
		{
		}

		// Token: 0x060246DC RID: 149212 RVA: 0x000C41E8 File Offset: 0x000C23E8
		[Token(Token = "0x60246DC")]
		[Address(RVA = "0x1F4F250", Offset = "0x1F4DE50", VA = "0x181F4F250")]
		private bool _CreateMultiSoloMatchStartRequest(out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x060246DD RID: 149213 RVA: 0x000C4200 File Offset: 0x000C2400
		[Token(Token = "0x60246DD")]
		[Address(RVA = "0x1F4FC20", Offset = "0x1F4E820", VA = "0x181F4FC20")]
		private bool _OnMultiSoloMatchStartMatchResponse(AutoChessStartMatchResponse response)
		{
			return default(bool);
		}

		// Token: 0x060246DE RID: 149214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246DE")]
		[Address(RVA = "0x1F4F9E0", Offset = "0x1F4E5E0", VA = "0x181F4F9E0")]
		private void _OnLoopSenderTick(float waitSec)
		{
		}

		// Token: 0x060246DF RID: 149215 RVA: 0x000C4218 File Offset: 0x000C2418
		[Token(Token = "0x60246DF")]
		[Address(RVA = "0x1F4EEF0", Offset = "0x1F4DAF0", VA = "0x181F4EEF0")]
		private bool _CreateMatchQueryRequest(bool isCancel, out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x060246E0 RID: 149216 RVA: 0x000C4230 File Offset: 0x000C2430
		[Token(Token = "0x60246E0")]
		[Address(RVA = "0x1F4FA40", Offset = "0x1F4E640", VA = "0x181F4FA40")]
		private bool _OnMultiSoloMatchQueryMatchResponse(AutoChessQueryMatchResponse response)
		{
			return default(bool);
		}

		// Token: 0x060246E1 RID: 149217 RVA: 0x000C4248 File Offset: 0x000C2448
		[Token(Token = "0x60246E1")]
		[Address(RVA = "0x1F4F1C0", Offset = "0x1F4DDC0", VA = "0x181F4F1C0")]
		private bool _CreateMultiSoloMatchQueryRequest(out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x060246E2 RID: 149218 RVA: 0x000C4260 File Offset: 0x000C2460
		[Token(Token = "0x60246E2")]
		[Address(RVA = "0x1F4F130", Offset = "0x1F4DD30", VA = "0x181F4F130")]
		private bool _CreateMultiSoloMatchCancelRequest(out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x060246E3 RID: 149219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246E3")]
		[Address(RVA = "0x1F4EE50", Offset = "0x1F4DA50", VA = "0x181F4EE50", Slot = "20")]
		protected override void OnFirstRender(AutoChessMatchingDialogBase.Option option)
		{
		}

		// Token: 0x060246E4 RID: 149220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246E4")]
		[Address(RVA = "0x1F4EDE0", Offset = "0x1F4D9E0", VA = "0x181F4EDE0", Slot = "21")]
		protected override void HandleCancelMatch()
		{
		}

		// Token: 0x060246E5 RID: 149221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246E5")]
		[Address(RVA = "0x1F4FD00", Offset = "0x1F4E900", VA = "0x181F4FD00")]
		public AutoChessSoloMatchingDialog()
		{
		}

		// Token: 0x04032B54 RID: 207700
		[Token(Token = "0x4032B54")]
		private const int QUERY_REQUEST_SHORT_INTERVAL = 1;

		// Token: 0x04032B55 RID: 207701
		[Token(Token = "0x4032B55")]
		private const int QUERY_REQUEST_SHORT_INTERVAL_COUNT = 8;

		// Token: 0x04032B56 RID: 207702
		[Token(Token = "0x4032B56")]
		private const int QUERY_REQUEST_LONG_INTERVAL = 5;

		// Token: 0x04032B57 RID: 207703
		[Token(Token = "0x4032B57")]
		private const int QUERY_REQUEST_DELAY = 1;

		// Token: 0x04032B58 RID: 207704
		[Token(Token = "0x4032B58")]
		[FieldOffset(Offset = "0xD0")]
		private LoopRequestSender m_multiSoloMatchLoopSender;

		// Token: 0x04032B59 RID: 207705
		[Token(Token = "0x4032B59")]
		[FieldOffset(Offset = "0xD8")]
		private AutoChessMatchingDialogBase.Option m_option;

		// Token: 0x04032B5A RID: 207706
		[Token(Token = "0x4032B5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitMultiSoloMatchRequests;

		// Token: 0x04032B5B RID: 207707
		[Token(Token = "0x4032B5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateMultiSoloMatchStartRequest;

		// Token: 0x04032B5C RID: 207708
		[Token(Token = "0x4032B5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnMultiSoloMatchStartMatchResponse;

		// Token: 0x04032B5D RID: 207709
		[Token(Token = "0x4032B5D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnLoopSenderTick;

		// Token: 0x04032B5E RID: 207710
		[Token(Token = "0x4032B5E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateMatchQueryRequest;

		// Token: 0x04032B5F RID: 207711
		[Token(Token = "0x4032B5F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnMultiSoloMatchQueryMatchResponse;

		// Token: 0x04032B60 RID: 207712
		[Token(Token = "0x4032B60")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateMultiSoloMatchQueryRequest;

		// Token: 0x04032B61 RID: 207713
		[Token(Token = "0x4032B61")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateMultiSoloMatchCancelRequest;

		// Token: 0x04032B62 RID: 207714
		[Token(Token = "0x4032B62")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFirstRender;

		// Token: 0x04032B63 RID: 207715
		[Token(Token = "0x4032B63")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HandleCancelMatch;

		// Token: 0x04032B64 RID: 207716
		[Token(Token = "0x4032B64")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
