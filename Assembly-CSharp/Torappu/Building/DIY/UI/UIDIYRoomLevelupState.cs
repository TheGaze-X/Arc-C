using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Building.UI;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019E0 RID: 6624
	[Token(Token = "0x20019E0")]
	public class UIDIYRoomLevelupState : UIPopupState
	{
		// Token: 0x0600A658 RID: 42584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A658")]
		[Address(RVA = "0x3228DD0", Offset = "0x32279D0", VA = "0x183228DD0")]
		public void SetupView(UIDIYRoomLevelupState.Argument arg, [Optional] Func<RoomSlotModel, bool> onOK)
		{
		}

		// Token: 0x0600A659 RID: 42585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A659")]
		[Address(RVA = "0x3229410", Offset = "0x3228010", VA = "0x183229410", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600A65A RID: 42586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A65A")]
		[Address(RVA = "0x3228A40", Offset = "0x3227640", VA = "0x183228A40", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0600A65B RID: 42587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65B")]
		[Address(RVA = "0x3229550", Offset = "0x3228150", VA = "0x183229550", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65C")]
		[Address(RVA = "0x3228B80", Offset = "0x3227780", VA = "0x183228B80", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0600A65D RID: 42589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A65D")]
		[Address(RVA = "0x32289E0", Offset = "0x32275E0", VA = "0x1832289E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600A65E RID: 42590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65E")]
		[Address(RVA = "0x3228D20", Offset = "0x3227920", VA = "0x183228D20")]
		public void OnLevelupButtonPressed()
		{
		}

		// Token: 0x0600A65F RID: 42591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65F")]
		[Address(RVA = "0x3228C70", Offset = "0x3227870", VA = "0x183228C70")]
		public void OnCancelButtonPressed()
		{
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x000403B0 File Offset: 0x0003E5B0
		[Token(Token = "0x600A660")]
		[Address(RVA = "0x3229640", Offset = "0x3228240", VA = "0x183229640")]
		private float _GetAlpha()
		{
			return 0f;
		}

		// Token: 0x0600A661 RID: 42593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A661")]
		[Address(RVA = "0x32296B0", Offset = "0x32282B0", VA = "0x1832296B0")]
		public UIDIYRoomLevelupState()
		{
		}

		// Token: 0x04009E4F RID: 40527
		[Token(Token = "0x4009E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04009E50 RID: 40528
		[Token(Token = "0x4009E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _infoRoot;

		// Token: 0x04009E51 RID: 40529
		[Token(Token = "0x4009E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _infoProto;

		// Token: 0x04009E52 RID: 40530
		[Token(Token = "0x4009E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _costRoot;

		// Token: 0x04009E53 RID: 40531
		[Token(Token = "0x4009E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _costProto;

		// Token: 0x04009E54 RID: 40532
		[Token(Token = "0x4009E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _furnitureRoot;

		// Token: 0x04009E55 RID: 40533
		[Token(Token = "0x4009E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _furnitureProto;

		// Token: 0x04009E56 RID: 40534
		[Token(Token = "0x4009E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _cannotLevelupPanel;

		// Token: 0x04009E57 RID: 40535
		[Token(Token = "0x4009E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x04009E58 RID: 40536
		[Token(Token = "0x4009E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIRoomThemeSpriteHub _bgSpriteHub;

		// Token: 0x04009E59 RID: 40537
		[Token(Token = "0x4009E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _conditionPanel;

		// Token: 0x04009E5A RID: 40538
		[Token(Token = "0x4009E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIComplexRoomLevelView _conditionTargetLevelView;

		// Token: 0x04009E5B RID: 40539
		[Token(Token = "0x4009E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Tweener m_showTween;

		// Token: 0x04009E5C RID: 40540
		[Token(Token = "0x4009E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Tweener m_hideTween;

		// Token: 0x04009E5D RID: 40541
		[Token(Token = "0x4009E5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RoomSlotModel m_currentRoom;

		// Token: 0x04009E5E RID: 40542
		[Token(Token = "0x4009E5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetupView;

		// Token: 0x04009E5F RID: 40543
		[Token(Token = "0x4009E5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04009E60 RID: 40544
		[Token(Token = "0x4009E60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04009E61 RID: 40545
		[Token(Token = "0x4009E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04009E62 RID: 40546
		[Token(Token = "0x4009E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04009E63 RID: 40547
		[Token(Token = "0x4009E63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04009E64 RID: 40548
		[Token(Token = "0x4009E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnLevelupButtonPressed;

		// Token: 0x04009E65 RID: 40549
		[Token(Token = "0x4009E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCancelButtonPressed;

		// Token: 0x04009E66 RID: 40550
		[Token(Token = "0x4009E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetAlpha;

		// Token: 0x04009E67 RID: 40551
		[Token(Token = "0x4009E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020019E1 RID: 6625
		[Token(Token = "0x20019E1")]
		public class Argument
		{
			// Token: 0x0600A663 RID: 42595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A663")]
			[Address(RVA = "0x3218740", Offset = "0x3217340", VA = "0x183218740")]
			public Argument()
			{
			}

			// Token: 0x04009E68 RID: 40552
			[Token(Token = "0x4009E68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoomSlotModel roomSlotModel;

			// Token: 0x04009E69 RID: 40553
			[Token(Token = "0x4009E69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool canLevelup;

			// Token: 0x04009E6A RID: 40554
			[Token(Token = "0x4009E6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string themeId;

			// Token: 0x04009E6B RID: 40555
			[Token(Token = "0x4009E6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int level;

			// Token: 0x04009E6C RID: 40556
			[Token(Token = "0x4009E6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool showConditionPanel;

			// Token: 0x04009E6D RID: 40557
			[Token(Token = "0x4009E6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int conditionLevel;

			// Token: 0x04009E6E RID: 40558
			[Token(Token = "0x4009E6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<LevelInfoItem> infoItemList;

			// Token: 0x04009E6F RID: 40559
			[Token(Token = "0x4009E6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<ArchiCostItemModel> costList;

			// Token: 0x04009E70 RID: 40560
			[Token(Token = "0x4009E70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<NewFurnitureItemModel> newFurnitureList;

			// Token: 0x04009E71 RID: 40561
			[Token(Token = "0x4009E71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Sprite backgroundSprite;
		}
	}
}
