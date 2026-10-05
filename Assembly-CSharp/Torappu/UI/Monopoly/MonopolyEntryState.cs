using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047E7 RID: 18407
	[Token(Token = "0x20047E7")]
	public class MonopolyEntryState : PopupFadeState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0601BD7E RID: 114046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BD7E")]
		[Address(RVA = "0x15253A0", Offset = "0x1523FA0", VA = "0x1815253A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601BD7F RID: 114047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD7F")]
		[Address(RVA = "0x15255A0", Offset = "0x15241A0", VA = "0x1815255A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601BD80 RID: 114048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD80")]
		[Address(RVA = "0x1525C30", Offset = "0x1524830", VA = "0x181525C30", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0601BD81 RID: 114049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD81")]
		[Address(RVA = "0x1525D60", Offset = "0x1524960", VA = "0x181525D60", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601BD82 RID: 114050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD82")]
		[Address(RVA = "0x1525E10", Offset = "0x1524A10", VA = "0x181525E10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BD83 RID: 114051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD83")]
		[Address(RVA = "0x1525800", Offset = "0x1524400", VA = "0x181525800", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601BD84 RID: 114052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD84")]
		[Address(RVA = "0x1525400", Offset = "0x1524000", VA = "0x181525400", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601BD85 RID: 114053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD85")]
		[Address(RVA = "0x15270A0", Offset = "0x1525CA0", VA = "0x1815270A0")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x0601BD86 RID: 114054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD86")]
		[Address(RVA = "0x1526C60", Offset = "0x1525860", VA = "0x181526C60")]
		private void _PlayEntryTween()
		{
		}

		// Token: 0x0601BD87 RID: 114055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD87")]
		[Address(RVA = "0x1525F00", Offset = "0x1524B00", VA = "0x181525F00")]
		private void _OnClickBackBtn()
		{
		}

		// Token: 0x0601BD88 RID: 114056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD88")]
		[Address(RVA = "0x1525FC0", Offset = "0x1524BC0", VA = "0x181525FC0")]
		private void _OnClickLeftArrowBtn()
		{
		}

		// Token: 0x0601BD89 RID: 114057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD89")]
		[Address(RVA = "0x1526140", Offset = "0x1524D40", VA = "0x181526140")]
		private void _OnClickRightArrowBtn()
		{
		}

		// Token: 0x0601BD8A RID: 114058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD8A")]
		[Address(RVA = "0x1526570", Offset = "0x1525170", VA = "0x181526570")]
		private void _OnClickStartGameBtn()
		{
		}

		// Token: 0x0601BD8B RID: 114059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD8B")]
		[Address(RVA = "0x1526960", Offset = "0x1525560", VA = "0x181526960")]
		private void _OpenMonopolyPage(bool shouldOpenBuffDialog = false)
		{
		}

		// Token: 0x0601BD8C RID: 114060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD8C")]
		[Address(RVA = "0x15262E0", Offset = "0x1524EE0", VA = "0x1815262E0")]
		private void _OnClickSettleGameBtn()
		{
		}

		// Token: 0x0601BD8D RID: 114061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD8D")]
		[Address(RVA = "0x1526D80", Offset = "0x1525980", VA = "0x181526D80")]
		private void _SendSettleRequest()
		{
		}

		// Token: 0x0601BD8E RID: 114062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD8E")]
		[Address(RVA = "0x1526A80", Offset = "0x1525680", VA = "0x181526A80")]
		private void _OpenSettleDialog(MonopolySettleGameResponse response)
		{
		}

		// Token: 0x0601BD8F RID: 114063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD8F")]
		[Address(RVA = "0x1527120", Offset = "0x1525D20", VA = "0x181527120")]
		public MonopolyEntryState()
		{
		}

		// Token: 0x0601BD90 RID: 114064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD90")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601BD91 RID: 114065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD91")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0601BD92 RID: 114066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD92")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040243BF RID: 148415
		[Token(Token = "0x40243BF")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "monopoly_entry";

		// Token: 0x040243C0 RID: 148416
		[Token(Token = "0x40243C0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MonopolyEntryView _view;

		// Token: 0x040243C1 RID: 148417
		[Token(Token = "0x40243C1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _entryAnimLocation;

		// Token: 0x040243C2 RID: 148418
		[Token(Token = "0x40243C2")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x040243C3 RID: 148419
		[Token(Token = "0x40243C3")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_entryTween;

		// Token: 0x040243C4 RID: 148420
		[Token(Token = "0x40243C4")]
		[FieldOffset(Offset = "0x98")]
		private MonopolyEntryStateBean m_stateBean;

		// Token: 0x040243C5 RID: 148421
		[Token(Token = "0x40243C5")]
		[FieldOffset(Offset = "0xA0")]
		private int m_settleDialogInstId;

		// Token: 0x040243C6 RID: 148422
		[Token(Token = "0x40243C6")]
		[FieldOffset(Offset = "0xA4")]
		private int m_settleConfirmDialogInstId;

		// Token: 0x040243C7 RID: 148423
		[Token(Token = "0x40243C7")]
		[FieldOffset(Offset = "0xA8")]
		private string m_actId;

		// Token: 0x040243C8 RID: 148424
		[Token(Token = "0x40243C8")]
		[NonSerialized]
		public const int ON_CLICK_BACK_BTN = 1;

		// Token: 0x040243C9 RID: 148425
		[Token(Token = "0x40243C9")]
		[NonSerialized]
		public const int ON_CLICK_LEFT_ARROW_BTN = 2;

		// Token: 0x040243CA RID: 148426
		[Token(Token = "0x40243CA")]
		[NonSerialized]
		public const int ON_CLICK_RIGHT_ARROW_BTN = 3;

		// Token: 0x040243CB RID: 148427
		[Token(Token = "0x40243CB")]
		[NonSerialized]
		public const int ON_CLICK_START_GAME_BTN = 4;

		// Token: 0x040243CC RID: 148428
		[Token(Token = "0x40243CC")]
		[NonSerialized]
		public const int ON_CLICK_SETTLE_GAME_BTN = 5;

		// Token: 0x040243CD RID: 148429
		[Token(Token = "0x40243CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040243CE RID: 148430
		[Token(Token = "0x40243CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040243CF RID: 148431
		[Token(Token = "0x40243CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040243D0 RID: 148432
		[Token(Token = "0x40243D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040243D1 RID: 148433
		[Token(Token = "0x40243D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040243D2 RID: 148434
		[Token(Token = "0x40243D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040243D3 RID: 148435
		[Token(Token = "0x40243D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040243D4 RID: 148436
		[Token(Token = "0x40243D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x040243D5 RID: 148437
		[Token(Token = "0x40243D5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayEntryTween;

		// Token: 0x040243D6 RID: 148438
		[Token(Token = "0x40243D6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnClickBackBtn;

		// Token: 0x040243D7 RID: 148439
		[Token(Token = "0x40243D7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnClickLeftArrowBtn;

		// Token: 0x040243D8 RID: 148440
		[Token(Token = "0x40243D8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnClickRightArrowBtn;

		// Token: 0x040243D9 RID: 148441
		[Token(Token = "0x40243D9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnClickStartGameBtn;

		// Token: 0x040243DA RID: 148442
		[Token(Token = "0x40243DA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OpenMonopolyPage;

		// Token: 0x040243DB RID: 148443
		[Token(Token = "0x40243DB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnClickSettleGameBtn;

		// Token: 0x040243DC RID: 148444
		[Token(Token = "0x40243DC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SendSettleRequest;

		// Token: 0x040243DD RID: 148445
		[Token(Token = "0x40243DD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OpenSettleDialog;

		// Token: 0x040243DE RID: 148446
		[Token(Token = "0x40243DE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
