using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006527 RID: 25895
	[Token(Token = "0x2006527")]
	public class ArtMagazineCoverDetailPage : UIPage, IValueMsgReceiver
	{
		// Token: 0x0602537D RID: 152445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602537D")]
		[Address(RVA = "0x2027090", Offset = "0x2025C90", VA = "0x182027090", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x0602537E RID: 152446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602537E")]
		[Address(RVA = "0x2027610", Offset = "0x2026210", VA = "0x182027610", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602537F RID: 152447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602537F")]
		[Address(RVA = "0x2027250", Offset = "0x2025E50", VA = "0x182027250", Slot = "24")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06025380 RID: 152448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025380")]
		[Address(RVA = "0x2027D90", Offset = "0x2026990", VA = "0x182027D90")]
		private void _TransToLeft()
		{
		}

		// Token: 0x06025381 RID: 152449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025381")]
		[Address(RVA = "0x2027FF0", Offset = "0x2026BF0", VA = "0x182027FF0")]
		private void _TransToRight()
		{
		}

		// Token: 0x06025382 RID: 152450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025382")]
		[Address(RVA = "0x2027980", Offset = "0x2026580", VA = "0x182027980")]
		private void _ClickEditBtn()
		{
		}

		// Token: 0x06025383 RID: 152451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025383")]
		[Address(RVA = "0x2027B30", Offset = "0x2026730", VA = "0x182027B30")]
		private void _ClickInditBtn()
		{
		}

		// Token: 0x06025384 RID: 152452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025384")]
		[Address(RVA = "0x20276E0", Offset = "0x20262E0", VA = "0x1820276E0")]
		private void _ChangeMagazineSquad()
		{
		}

		// Token: 0x06025385 RID: 152453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025385")]
		[Address(RVA = "0x2027C70", Offset = "0x2026870", VA = "0x182027C70")]
		private void _OnChangeMagazineSquadSuc(bool isAdd)
		{
		}

		// Token: 0x06025386 RID: 152454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025386")]
		[Address(RVA = "0x2027030", Offset = "0x2025C30", VA = "0x182027030")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x06025387 RID: 152455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025387")]
		[Address(RVA = "0x2028260", Offset = "0x2026E60", VA = "0x182028260")]
		public ArtMagazineCoverDetailPage()
		{
		}

		// Token: 0x06025388 RID: 152456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025388")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06025389 RID: 152457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025389")]
		[Address(RVA = "0xE98780", Offset = "0xE97380", VA = "0x180E98780")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x04034349 RID: 213833
		[Token(Token = "0x4034349")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ArtMagazineCoverDetailView _view;

		// Token: 0x0403434A RID: 213834
		[Token(Token = "0x403434A")]
		[FieldOffset(Offset = "0xE0")]
		private ArtMagazineCoverDetailViewModelProperty m_property;

		// Token: 0x0403434B RID: 213835
		[Token(Token = "0x403434B")]
		[NonSerialized]
		public const int EVENT_ON_LEFT_ARROW_CLICK = 0;

		// Token: 0x0403434C RID: 213836
		[Token(Token = "0x403434C")]
		[NonSerialized]
		public const int EVENT_ON_RIGHT_ARROW_CLICK = 1;

		// Token: 0x0403434D RID: 213837
		[Token(Token = "0x403434D")]
		[NonSerialized]
		public const int EVENT_ON_INDIT_BTN_CLICK = 2;

		// Token: 0x0403434E RID: 213838
		[Token(Token = "0x403434E")]
		[NonSerialized]
		public const int EVENT_ON_EDIT_BTN_CLICK = 3;

		// Token: 0x0403434F RID: 213839
		[Token(Token = "0x403434F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04034350 RID: 213840
		[Token(Token = "0x4034350")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04034351 RID: 213841
		[Token(Token = "0x4034351")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04034352 RID: 213842
		[Token(Token = "0x4034352")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TransToLeft;

		// Token: 0x04034353 RID: 213843
		[Token(Token = "0x4034353")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TransToRight;

		// Token: 0x04034354 RID: 213844
		[Token(Token = "0x4034354")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClickEditBtn;

		// Token: 0x04034355 RID: 213845
		[Token(Token = "0x4034355")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClickInditBtn;

		// Token: 0x04034356 RID: 213846
		[Token(Token = "0x4034356")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ChangeMagazineSquad;

		// Token: 0x04034357 RID: 213847
		[Token(Token = "0x4034357")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnChangeMagazineSquadSuc;

		// Token: 0x04034358 RID: 213848
		[Token(Token = "0x4034358")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x04034359 RID: 213849
		[Token(Token = "0x4034359")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006528 RID: 25896
		[Token(Token = "0x2006528")]
		public class Param
		{
			// Token: 0x0602538A RID: 152458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602538A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403435A RID: 213850
			[Token(Token = "0x403435A")]
			[FieldOffset(Offset = "0x10")]
			public ArtMagazineCoverDetailShowType showType;

			// Token: 0x0403435B RID: 213851
			[Token(Token = "0x403435B")]
			[FieldOffset(Offset = "0x14")]
			public int initFocusIndex;

			// Token: 0x0403435C RID: 213852
			[Token(Token = "0x403435C")]
			[FieldOffset(Offset = "0x18")]
			public List<string> leafIdList;
		}
	}
}
