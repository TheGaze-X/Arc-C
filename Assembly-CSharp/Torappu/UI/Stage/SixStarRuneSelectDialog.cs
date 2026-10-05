using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006838 RID: 26680
	[Token(Token = "0x2006838")]
	public class SixStarRuneSelectDialog : UICompDialog<SixStarRuneSelectDialog.Input>, IValueMsgReceiver, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x0602634B RID: 156491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602634B")]
		[Address(RVA = "0x21498E0", Offset = "0x21484E0", VA = "0x1821498E0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602634C RID: 156492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602634C")]
		[Address(RVA = "0x2149A30", Offset = "0x2148630", VA = "0x182149A30", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602634D RID: 156493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602634D")]
		[Address(RVA = "0x2149E40", Offset = "0x2148A40", VA = "0x182149E40", Slot = "18")]
		protected override void OnRender(SixStarRuneSelectDialog.Input input)
		{
		}

		// Token: 0x0602634E RID: 156494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602634E")]
		[Address(RVA = "0x2149F20", Offset = "0x2148B20", VA = "0x182149F20", Slot = "12")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602634F RID: 156495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602634F")]
		[Address(RVA = "0x2149B70", Offset = "0x2148770", VA = "0x182149B70", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06026350 RID: 156496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026350")]
		[Address(RVA = "0x2149FF0", Offset = "0x2148BF0", VA = "0x182149FF0")]
		private void _EventOnConfirmBtnClicked()
		{
		}

		// Token: 0x06026351 RID: 156497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026351")]
		[Address(RVA = "0x214A5E0", Offset = "0x21491E0", VA = "0x18214A5E0")]
		private void _EventOnRuneSelect(int level, string runeId)
		{
		}

		// Token: 0x06026352 RID: 156498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026352")]
		[Address(RVA = "0x214A3F0", Offset = "0x2148FF0", VA = "0x18214A3F0")]
		private void _EventOnMilestoneBtnClicked()
		{
		}

		// Token: 0x06026353 RID: 156499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026353")]
		[Address(RVA = "0x2149940", Offset = "0x2148540", VA = "0x182149940", Slot = "20")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06026354 RID: 156500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026354")]
		[Address(RVA = "0x214A920", Offset = "0x2149520", VA = "0x18214A920")]
		private void _HandleSelectRuneResponse(EditStageSixStarTagResponse _)
		{
		}

		// Token: 0x06026355 RID: 156501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026355")]
		[Address(RVA = "0x2149820", Offset = "0x2148420", VA = "0x182149820")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06026356 RID: 156502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026356")]
		[Address(RVA = "0x214A9F0", Offset = "0x21495F0", VA = "0x18214A9F0")]
		public SixStarRuneSelectDialog()
		{
		}

		// Token: 0x06026357 RID: 156503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026357")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06026358 RID: 156504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026358")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06026359 RID: 156505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026359")]
		[Address(RVA = "0x2149FE0", Offset = "0x2148BE0", VA = "0x182149FE0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04035D79 RID: 220537
		[Token(Token = "0x4035D79")]
		[NonSerialized]
		public const int ON_CONFIRM_BTN_CLICKED = 0;

		// Token: 0x04035D7A RID: 220538
		[Token(Token = "0x4035D7A")]
		[NonSerialized]
		public const int ON_RUNE_SELECT = 1;

		// Token: 0x04035D7B RID: 220539
		[Token(Token = "0x4035D7B")]
		[NonSerialized]
		public const int ON_MILESTONE_BTN_CLICKED = 2;

		// Token: 0x04035D7C RID: 220540
		[Token(Token = "0x4035D7C")]
		[NonSerialized]
		public const int SHOW_NEXT_REWARD_TIP_POINT = 1;

		// Token: 0x04035D7D RID: 220541
		[Token(Token = "0x4035D7D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _imgBlur;

		// Token: 0x04035D7E RID: 220542
		[Token(Token = "0x4035D7E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SixStarRuneSelectView _runeSelectView;

		// Token: 0x04035D7F RID: 220543
		[Token(Token = "0x4035D7F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x04035D80 RID: 220544
		[Token(Token = "0x4035D80")]
		[FieldOffset(Offset = "0x88")]
		private SixStarRuneSelectProperty m_property;

		// Token: 0x04035D81 RID: 220545
		[Token(Token = "0x4035D81")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035D82 RID: 220546
		[Token(Token = "0x4035D82")]
		[FieldOffset(Offset = "0xA0")]
		private int m_cachedDialogInstId;

		// Token: 0x04035D83 RID: 220547
		[Token(Token = "0x4035D83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04035D84 RID: 220548
		[Token(Token = "0x4035D84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04035D85 RID: 220549
		[Token(Token = "0x4035D85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04035D86 RID: 220550
		[Token(Token = "0x4035D86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04035D87 RID: 220551
		[Token(Token = "0x4035D87")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04035D88 RID: 220552
		[Token(Token = "0x4035D88")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnConfirmBtnClicked;

		// Token: 0x04035D89 RID: 220553
		[Token(Token = "0x4035D89")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnRuneSelect;

		// Token: 0x04035D8A RID: 220554
		[Token(Token = "0x4035D8A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnMilestoneBtnClicked;

		// Token: 0x04035D8B RID: 220555
		[Token(Token = "0x4035D8B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04035D8C RID: 220556
		[Token(Token = "0x4035D8C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleSelectRuneResponse;

		// Token: 0x04035D8D RID: 220557
		[Token(Token = "0x4035D8D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04035D8E RID: 220558
		[Token(Token = "0x4035D8E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006839 RID: 26681
		[Token(Token = "0x2006839")]
		public class Input
		{
			// Token: 0x0602635A RID: 156506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602635A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04035D8F RID: 220559
			[Token(Token = "0x4035D8F")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04035D90 RID: 220560
			[Token(Token = "0x4035D90")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;
		}
	}
}
