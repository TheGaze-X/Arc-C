using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EF8 RID: 20216
	[Token(Token = "0x2004EF8")]
	public class FifthAnnivExploreMissionDialog : UICompDialog<FifthAnnivExploreMissionDialog.Option>
	{
		// Token: 0x0601E255 RID: 123477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E255")]
		[Address(RVA = "0x17D4870", Offset = "0x17D3470", VA = "0x1817D4870", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601E256 RID: 123478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E256")]
		[Address(RVA = "0x17D4A40", Offset = "0x17D3640", VA = "0x1817D4A40", Slot = "18")]
		protected override void OnRender(FifthAnnivExploreMissionDialog.Option input)
		{
		}

		// Token: 0x0601E257 RID: 123479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E257")]
		[Address(RVA = "0x17D4410", Offset = "0x17D3010", VA = "0x1817D4410")]
		public void EventOnMissionObjClicked(string missionId)
		{
		}

		// Token: 0x0601E258 RID: 123480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E258")]
		[Address(RVA = "0x17D4120", Offset = "0x17D2D20", VA = "0x1817D4120")]
		public void EventOnCollectAll()
		{
		}

		// Token: 0x0601E259 RID: 123481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E259")]
		[Address(RVA = "0x17D4B00", Offset = "0x17D3700", VA = "0x1817D4B00")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0601E25A RID: 123482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E25A")]
		[Address(RVA = "0x17D47B0", Offset = "0x17D33B0", VA = "0x1817D47B0")]
		public void OnBackEvent()
		{
		}

		// Token: 0x0601E25B RID: 123483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E25B")]
		[Address(RVA = "0x17D4BB0", Offset = "0x17D37B0", VA = "0x1817D4BB0")]
		public FifthAnnivExploreMissionDialog()
		{
		}

		// Token: 0x0601E25C RID: 123484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E25C")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402821B RID: 164379
		[Token(Token = "0x402821B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FifthAnnivExploreMissionView _view;

		// Token: 0x0402821C RID: 164380
		[Token(Token = "0x402821C")]
		[FieldOffset(Offset = "0x78")]
		private FifthAnnivExploreMissionProperty m_cachedProperty;

		// Token: 0x0402821D RID: 164381
		[Token(Token = "0x402821D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402821E RID: 164382
		[Token(Token = "0x402821E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402821F RID: 164383
		[Token(Token = "0x402821F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnMissionObjClicked;

		// Token: 0x04028220 RID: 164384
		[Token(Token = "0x4028220")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCollectAll;

		// Token: 0x04028221 RID: 164385
		[Token(Token = "0x4028221")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04028222 RID: 164386
		[Token(Token = "0x4028222")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x04028223 RID: 164387
		[Token(Token = "0x4028223")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EF9 RID: 20217
		[Token(Token = "0x2004EF9")]
		public class Option
		{
			// Token: 0x0601E25D RID: 123485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E25D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}
		}
	}
}
