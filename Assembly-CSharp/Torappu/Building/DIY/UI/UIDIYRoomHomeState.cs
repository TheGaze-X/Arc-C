using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Building.UI;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019DB RID: 6619
	[Token(Token = "0x20019DB")]
	public class UIDIYRoomHomeState : UIPopupState
	{
		// Token: 0x0600A63E RID: 42558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A63E")]
		[Address(RVA = "0x32283B0", Offset = "0x3226FB0", VA = "0x1832283B0")]
		public void SetupView(UIDIYRoomHomeState.Argument arg)
		{
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A63F")]
		[Address(RVA = "0x3227F30", Offset = "0x3226B30", VA = "0x183227F30")]
		public void ActuallyShow()
		{
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A640")]
		[Address(RVA = "0x3228750", Offset = "0x3227350", VA = "0x183228750", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A641")]
		[Address(RVA = "0x3228020", Offset = "0x3226C20", VA = "0x183228020", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A642")]
		[Address(RVA = "0x3228890", Offset = "0x3227490", VA = "0x183228890", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600A643 RID: 42563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A643")]
		[Address(RVA = "0x3228160", Offset = "0x3226D60", VA = "0x183228160", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A644")]
		[Address(RVA = "0x3227FC0", Offset = "0x3226BC0", VA = "0x183227FC0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A645")]
		[Address(RVA = "0x3228300", Offset = "0x3226F00", VA = "0x183228300")]
		public void OnLevelupButtonPressed()
		{
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A646")]
		[Address(RVA = "0x3228250", Offset = "0x3226E50", VA = "0x183228250")]
		public void OnCancelButtonPressed()
		{
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A647")]
		[Address(RVA = "0x3228980", Offset = "0x3227580", VA = "0x183228980")]
		public UIDIYRoomHomeState()
		{
		}

		// Token: 0x04009E2E RID: 40494
		[Token(Token = "0x4009E2E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04009E2F RID: 40495
		[Token(Token = "0x4009E2F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIRoomThemeSpriteHub _themeSpriteHub;

		// Token: 0x04009E30 RID: 40496
		[Token(Token = "0x4009E30")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRoomThemeIconSpriteHub _themeIconSpriteHub;

		// Token: 0x04009E31 RID: 40497
		[Token(Token = "0x4009E31")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x04009E32 RID: 40498
		[Token(Token = "0x4009E32")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _themeImage;

		// Token: 0x04009E33 RID: 40499
		[Token(Token = "0x4009E33")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _nameLabel;

		// Token: 0x04009E34 RID: 40500
		[Token(Token = "0x4009E34")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _descLabel;

		// Token: 0x04009E35 RID: 40501
		[Token(Token = "0x4009E35")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _levelupHint;

		// Token: 0x04009E36 RID: 40502
		[Token(Token = "0x4009E36")]
		[FieldOffset(Offset = "0xA0")]
		private RoomSlotModel m_currentRoom;

		// Token: 0x04009E37 RID: 40503
		[Token(Token = "0x4009E37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetupView;

		// Token: 0x04009E38 RID: 40504
		[Token(Token = "0x4009E38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ActuallyShow;

		// Token: 0x04009E39 RID: 40505
		[Token(Token = "0x4009E39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04009E3A RID: 40506
		[Token(Token = "0x4009E3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04009E3B RID: 40507
		[Token(Token = "0x4009E3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04009E3C RID: 40508
		[Token(Token = "0x4009E3C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04009E3D RID: 40509
		[Token(Token = "0x4009E3D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04009E3E RID: 40510
		[Token(Token = "0x4009E3E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnLevelupButtonPressed;

		// Token: 0x04009E3F RID: 40511
		[Token(Token = "0x4009E3F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCancelButtonPressed;

		// Token: 0x04009E40 RID: 40512
		[Token(Token = "0x4009E40")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020019DC RID: 6620
		[Token(Token = "0x20019DC")]
		public class Argument
		{
			// Token: 0x0600A649 RID: 42569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A649")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Argument()
			{
			}

			// Token: 0x04009E41 RID: 40513
			[Token(Token = "0x4009E41")]
			[FieldOffset(Offset = "0x10")]
			public RoomSlotModel roomSlotModel;

			// Token: 0x04009E42 RID: 40514
			[Token(Token = "0x4009E42")]
			[FieldOffset(Offset = "0x18")]
			public string themeId;

			// Token: 0x04009E43 RID: 40515
			[Token(Token = "0x4009E43")]
			[FieldOffset(Offset = "0x20")]
			public int level;

			// Token: 0x04009E44 RID: 40516
			[Token(Token = "0x4009E44")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x04009E45 RID: 40517
			[Token(Token = "0x4009E45")]
			[FieldOffset(Offset = "0x30")]
			public string desc;

			// Token: 0x04009E46 RID: 40518
			[Token(Token = "0x4009E46")]
			[FieldOffset(Offset = "0x38")]
			public bool canLevelup;

			// Token: 0x04009E47 RID: 40519
			[Token(Token = "0x4009E47")]
			[FieldOffset(Offset = "0x40")]
			public Sprite backgroundSprite;
		}
	}
}
