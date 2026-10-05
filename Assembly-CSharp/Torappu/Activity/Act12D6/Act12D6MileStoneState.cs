using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007ADE RID: 31454
	[Token(Token = "0x2007ADE")]
	public class Act12D6MileStoneState : PopupFadeState, IHotfixable
	{
		// Token: 0x0602C0D6 RID: 180438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C0D6")]
		[Address(RVA = "0x27F3230", Offset = "0x27F1E30", VA = "0x1827F3230", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C0D7 RID: 180439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0D7")]
		[Address(RVA = "0x27F3290", Offset = "0x27F1E90", VA = "0x1827F3290", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C0D8 RID: 180440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0D8")]
		[Address(RVA = "0x27F3510", Offset = "0x27F2110", VA = "0x1827F3510")]
		public void SendItemRequest(string rewardId)
		{
		}

		// Token: 0x0602C0D9 RID: 180441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0D9")]
		[Address(RVA = "0x27F3590", Offset = "0x27F2190", VA = "0x1827F3590")]
		public void SendItemTryBestRequest()
		{
		}

		// Token: 0x0602C0DA RID: 180442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0DA")]
		[Address(RVA = "0x27F3CE0", Offset = "0x27F28E0", VA = "0x1827F3CE0")]
		private void _SendItemTryBestRequest()
		{
		}

		// Token: 0x0602C0DB RID: 180443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0DB")]
		[Address(RVA = "0x27F3A60", Offset = "0x27F2660", VA = "0x1827F3A60")]
		private void _SendItemRequest(string rewardId)
		{
		}

		// Token: 0x0602C0DC RID: 180444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C0DC")]
		[Address(RVA = "0x27F3420", Offset = "0x27F2020", VA = "0x1827F3420")]
		public static IEnumerator ReceiveItemsCoroutine(List<ActivityItemModel> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602C0DD RID: 180445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0DD")]
		[Address(RVA = "0x27F3950", Offset = "0x27F2550", VA = "0x1827F3950")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602C0DE RID: 180446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0DE")]
		[Address(RVA = "0x27F3F50", Offset = "0x27F2B50", VA = "0x1827F3F50")]
		public Act12D6MileStoneState()
		{
		}

		// Token: 0x0602C0E2 RID: 180450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0E2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403FD25 RID: 261413
		[Token(Token = "0x403FD25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act12D6MileStoneStateBean _stateBean;

		// Token: 0x0403FD26 RID: 261414
		[Token(Token = "0x403FD26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act12D6MileStoneHolder _view;

		// Token: 0x0403FD27 RID: 261415
		[Token(Token = "0x403FD27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403FD28 RID: 261416
		[Token(Token = "0x403FD28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403FD29 RID: 261417
		[Token(Token = "0x403FD29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0403FD2A RID: 261418
		[Token(Token = "0x403FD2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string m_cacheTransId;

		// Token: 0x0403FD2B RID: 261419
		[Token(Token = "0x403FD2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FD2C RID: 261420
		[Token(Token = "0x403FD2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FD2D RID: 261421
		[Token(Token = "0x403FD2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendItemRequest;

		// Token: 0x0403FD2E RID: 261422
		[Token(Token = "0x403FD2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendItemTryBestRequest;

		// Token: 0x0403FD2F RID: 261423
		[Token(Token = "0x403FD2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SendItemTryBestRequest;

		// Token: 0x0403FD30 RID: 261424
		[Token(Token = "0x403FD30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendItemRequest;

		// Token: 0x0403FD31 RID: 261425
		[Token(Token = "0x403FD31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x0403FD32 RID: 261426
		[Token(Token = "0x403FD32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FD33 RID: 261427
		[Token(Token = "0x403FD33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
