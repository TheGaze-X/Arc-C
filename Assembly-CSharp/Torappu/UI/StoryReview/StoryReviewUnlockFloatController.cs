using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004918 RID: 18712
	[Token(Token = "0x2004918")]
	public class StoryReviewUnlockFloatController : PageSingleComponent, IHotfixable
	{
		// Token: 0x0601C35D RID: 115549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C35D")]
		[Address(RVA = "0x15B5DD0", Offset = "0x15B49D0", VA = "0x1815B5DD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x0601C35E RID: 115550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C35E")]
		[Address(RVA = "0x15B5EF0", Offset = "0x15B4AF0", VA = "0x1815B5EF0")]
		private void OnDisable()
		{
		}

		// Token: 0x0601C35F RID: 115551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C35F")]
		[Address(RVA = "0x15B62B0", Offset = "0x15B4EB0", VA = "0x1815B62B0")]
		private void _Init()
		{
		}

		// Token: 0x0601C360 RID: 115552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C360")]
		[Address(RVA = "0x15B65C0", Offset = "0x15B51C0", VA = "0x1815B65C0")]
		private static StoryReviewUnlockFloatController _Inst(UIPageFinder.Interface pageInterface)
		{
			return null;
		}

		// Token: 0x0601C361 RID: 115553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C361")]
		[Address(RVA = "0x15B5F70", Offset = "0x15B4B70", VA = "0x1815B5F70")]
		public static void RenderLockedPart(UIPageFinder.Interface pageInterface, int count, string itemId, ItemType itemType, string iconId, Action onClick)
		{
		}

		// Token: 0x0601C362 RID: 115554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C362")]
		[Address(RVA = "0x15B5C80", Offset = "0x15B4880", VA = "0x1815B5C80")]
		public void OnClick()
		{
		}

		// Token: 0x0601C363 RID: 115555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C363")]
		[Address(RVA = "0x15B5AD0", Offset = "0x15B46D0", VA = "0x1815B5AD0")]
		public void ClosePage()
		{
		}

		// Token: 0x0601C364 RID: 115556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C364")]
		[Address(RVA = "0x15B66C0", Offset = "0x15B52C0", VA = "0x1815B66C0")]
		private void _RenderBackImage()
		{
		}

		// Token: 0x0601C365 RID: 115557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C365")]
		[Address(RVA = "0x15B6880", Offset = "0x15B5480", VA = "0x1815B6880")]
		private void _RenderLockedPart(int count, string itemId, ItemType itemType, string iconId, Action onClick)
		{
		}

		// Token: 0x0601C366 RID: 115558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C366")]
		[Address(RVA = "0x15B6160", Offset = "0x15B4D60", VA = "0x1815B6160")]
		private IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0601C367 RID: 115559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C367")]
		[Address(RVA = "0x15B5BD0", Offset = "0x15B47D0", VA = "0x1815B5BD0")]
		private IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x0601C368 RID: 115560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C368")]
		[Address(RVA = "0x15B6B80", Offset = "0x15B5780", VA = "0x1815B6B80")]
		public StoryReviewUnlockFloatController()
		{
		}

		// Token: 0x0601C36B RID: 115563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C36B")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x04024E44 RID: 151108
		[Token(Token = "0x4024E44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFullScreenImage _fullScreenImage;

		// Token: 0x04024E45 RID: 151109
		[Token(Token = "0x4024E45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unlockPart;

		// Token: 0x04024E46 RID: 151110
		[Token(Token = "0x4024E46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _container;

		// Token: 0x04024E47 RID: 151111
		[Token(Token = "0x4024E47")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _rootView;

		// Token: 0x04024E48 RID: 151112
		[Token(Token = "0x4024E48")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x04024E49 RID: 151113
		[Token(Token = "0x4024E49")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _soldText;

		// Token: 0x04024E4A RID: 151114
		[Token(Token = "0x4024E4A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x04024E4B RID: 151115
		[Token(Token = "0x4024E4B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _itemContainer1;

		// Token: 0x04024E4C RID: 151116
		[Token(Token = "0x4024E4C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _itemContainer2;

		// Token: 0x04024E4D RID: 151117
		[Token(Token = "0x4024E4D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04024E4E RID: 151118
		[Token(Token = "0x4024E4E")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_isInited;

		// Token: 0x04024E4F RID: 151119
		[Token(Token = "0x4024E4F")]
		[FieldOffset(Offset = "0x70")]
		private Action m_onClick;

		// Token: 0x04024E50 RID: 151120
		[Token(Token = "0x4024E50")]
		[FieldOffset(Offset = "0x78")]
		private UIItemCard m_costItem;

		// Token: 0x04024E51 RID: 151121
		[Token(Token = "0x4024E51")]
		[FieldOffset(Offset = "0x80")]
		private UIItemCard m_targetItem;

		// Token: 0x04024E52 RID: 151122
		[Token(Token = "0x4024E52")]
		[FieldOffset(Offset = "0x88")]
		private UIItemViewModel m_costModel;

		// Token: 0x04024E53 RID: 151123
		[Token(Token = "0x4024E53")]
		[FieldOffset(Offset = "0x90")]
		private UIItemViewModel m_targetModel;

		// Token: 0x04024E54 RID: 151124
		[Token(Token = "0x4024E54")]
		[FieldOffset(Offset = "0x98")]
		private UIPopupWindow.UIBlocker m_blocker;

		// Token: 0x04024E55 RID: 151125
		[Token(Token = "0x4024E55")]
		protected const float FADE_DURATION = 0.23f;

		// Token: 0x04024E56 RID: 151126
		[Token(Token = "0x4024E56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04024E57 RID: 151127
		[Token(Token = "0x4024E57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04024E58 RID: 151128
		[Token(Token = "0x4024E58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04024E59 RID: 151129
		[Token(Token = "0x4024E59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Inst;

		// Token: 0x04024E5A RID: 151130
		[Token(Token = "0x4024E5A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderLockedPart;

		// Token: 0x04024E5B RID: 151131
		[Token(Token = "0x4024E5B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04024E5C RID: 151132
		[Token(Token = "0x4024E5C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x04024E5D RID: 151133
		[Token(Token = "0x4024E5D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderBackImage;

		// Token: 0x04024E5E RID: 151134
		[Token(Token = "0x4024E5E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderLockedPart;

		// Token: 0x04024E5F RID: 151135
		[Token(Token = "0x4024E5F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04024E60 RID: 151136
		[Token(Token = "0x4024E60")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04024E61 RID: 151137
		[Token(Token = "0x4024E61")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
