using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200654E RID: 25934
	[Token(Token = "0x200654E")]
	public class ArtMagazineDiyLeafDragAndPinchController : PageSingleComponent, ITimeWatcher
	{
		// Token: 0x17005811 RID: 22545
		// (get) Token: 0x06025491 RID: 152721 RVA: 0x000C7560 File Offset: 0x000C5760
		[Token(Token = "0x17005811")]
		public bool isInteracting
		{
			[Token(Token = "0x6025491")]
			[Address(RVA = "0x204C680", Offset = "0x204B280", VA = "0x18204C680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025492 RID: 152722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025492")]
		[Address(RVA = "0x204C470", Offset = "0x204B070", VA = "0x18204C470")]
		private void _SetTargetTouchStatus()
		{
		}

		// Token: 0x06025493 RID: 152723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025493")]
		[Address(RVA = "0x204B810", Offset = "0x204A410", VA = "0x18204B810", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06025494 RID: 152724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025494")]
		[Address(RVA = "0x204BD10", Offset = "0x204A910", VA = "0x18204BD10")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06025495 RID: 152725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025495")]
		[Address(RVA = "0x204B6B0", Offset = "0x204A2B0", VA = "0x18204B6B0")]
		public void OnBeginDrag(PointerEventData eventData, [Optional] string itemId)
		{
		}

		// Token: 0x06025496 RID: 152726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025496")]
		[Address(RVA = "0x204BE40", Offset = "0x204AA40", VA = "0x18204BE40")]
		public void OnScroll(Vector2 scrollDelta)
		{
		}

		// Token: 0x06025497 RID: 152727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025497")]
		[Address(RVA = "0x204C0B0", Offset = "0x204ACB0", VA = "0x18204C0B0")]
		public void SetTarget(ArtMagazineDiyLeafElementViewHolder target, float maxScale = 0f, float minScale = 0f, bool isEditingDuringTouch = false)
		{
		}

		// Token: 0x06025498 RID: 152728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025498")]
		[Address(RVA = "0x204BF70", Offset = "0x204AB70", VA = "0x18204BF70")]
		public void SetSkinTarget(ArtMagazineDiyLeafCharIllustHolder.LeafCharSkinWrapper target, float maxScale = 0f, float minScale = 0f)
		{
		}

		// Token: 0x06025499 RID: 152729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025499")]
		[Address(RVA = "0x204C3E0", Offset = "0x204AFE0", VA = "0x18204C3E0", Slot = "12")]
		public void UpdateTime(float timeDelta)
		{
		}

		// Token: 0x0602549A RID: 152730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602549A")]
		[Address(RVA = "0x204C330", Offset = "0x204AF30", VA = "0x18204C330")]
		public void UpdateLeafViewDisplayOptions(ArtMagazineDiyPage.LeafViewDisplayOptions displayOptions)
		{
		}

		// Token: 0x0602549B RID: 152731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602549B")]
		[Address(RVA = "0x204C2D0", Offset = "0x204AED0", VA = "0x18204C2D0")]
		protected void Start()
		{
		}

		// Token: 0x0602549C RID: 152732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602549C")]
		[Address(RVA = "0x204BCB0", Offset = "0x204A8B0", VA = "0x18204BCB0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0602549D RID: 152733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602549D")]
		[Address(RVA = "0x204C610", Offset = "0x204B210", VA = "0x18204C610")]
		public ArtMagazineDiyLeafDragAndPinchController()
		{
		}

		// Token: 0x0602549E RID: 152734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602549E")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0602549F RID: 152735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602549F")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04034504 RID: 214276
		[Token(Token = "0x4034504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _eventRectTrans;

		// Token: 0x04034505 RID: 214277
		[Token(Token = "0x4034505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _boundingRect;

		// Token: 0x04034506 RID: 214278
		[Token(Token = "0x4034506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _containerRect;

		// Token: 0x04034507 RID: 214279
		[Token(Token = "0x4034507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArtMagazineDiyPage _diyPage;

		// Token: 0x04034508 RID: 214280
		[Token(Token = "0x4034508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _scrollSensitivity;

		// Token: 0x04034509 RID: 214281
		[Token(Token = "0x4034509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ArtMagazineDiyLeafDragAndPinchController.ArtMagazineDragAndPinchContext m_context;

		// Token: 0x0403450A RID: 214282
		[Token(Token = "0x403450A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TouchHandler<DragAndPinchContext> m_touchHandler;

		// Token: 0x0403450B RID: 214283
		[Token(Token = "0x403450B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ArtMagazineDiyLeafDragAndPinchController.ArtMagazineDragContext m_charSkinContext;

		// Token: 0x0403450C RID: 214284
		[Token(Token = "0x403450C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TouchHandler<DragAndPinchContext> m_charSkinTouchHandler;

		// Token: 0x0403450D RID: 214285
		[Token(Token = "0x403450D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ArtMagazineDiyLeafElementViewHolder m_target;

		// Token: 0x0403450E RID: 214286
		[Token(Token = "0x403450E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_tabChangeSeqNum;

		// Token: 0x0403450F RID: 214287
		[Token(Token = "0x403450F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInteracting;

		// Token: 0x04034510 RID: 214288
		[Token(Token = "0x4034510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetTargetTouchStatus;

		// Token: 0x04034511 RID: 214289
		[Token(Token = "0x4034511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04034512 RID: 214290
		[Token(Token = "0x4034512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x04034513 RID: 214291
		[Token(Token = "0x4034513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x04034514 RID: 214292
		[Token(Token = "0x4034514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x04034515 RID: 214293
		[Token(Token = "0x4034515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetTarget;

		// Token: 0x04034516 RID: 214294
		[Token(Token = "0x4034516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetSkinTarget;

		// Token: 0x04034517 RID: 214295
		[Token(Token = "0x4034517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x04034518 RID: 214296
		[Token(Token = "0x4034518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateLeafViewDisplayOptions;

		// Token: 0x04034519 RID: 214297
		[Token(Token = "0x4034519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0403451A RID: 214298
		[Token(Token = "0x403451A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403451B RID: 214299
		[Token(Token = "0x403451B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200654F RID: 25935
		[Token(Token = "0x200654F")]
		public class ArtMagazineDragAndPinchContext : DragAndPinchWithTargetContext
		{
			// Token: 0x17005812 RID: 22546
			// (get) Token: 0x060254A0 RID: 152736 RVA: 0x000C7578 File Offset: 0x000C5778
			// (set) Token: 0x060254A1 RID: 152737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005812")]
			public bool isEditingDuringTouch
			{
				[Token(Token = "0x60254A0")]
				[Address(RVA = "0x2053E80", Offset = "0x2052A80", VA = "0x182053E80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60254A1")]
				[Address(RVA = "0x2053EE0", Offset = "0x2052AE0", VA = "0x182053EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060254A2 RID: 152738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60254A2")]
			[Address(RVA = "0x2053E00", Offset = "0x2052A00", VA = "0x182053E00")]
			public ArtMagazineDragAndPinchContext(ArtMagazineDiyLeafDragAndPinchController closure)
			{
			}

			// Token: 0x060254A3 RID: 152739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60254A3")]
			[Address(RVA = "0x2053B90", Offset = "0x2052790", VA = "0x182053B90", Slot = "24")]
			protected override void OnFirstDragOrPinchStarted()
			{
			}

			// Token: 0x060254A4 RID: 152740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60254A4")]
			[Address(RVA = "0x2053C00", Offset = "0x2052800", VA = "0x182053C00", Slot = "25")]
			protected override void OnLastDragOrPinchStopped()
			{
			}

			// Token: 0x060254A5 RID: 152741 RVA: 0x000C7590 File Offset: 0x000C5790
			[Token(Token = "0x60254A5")]
			[Address(RVA = "0x2053CE0", Offset = "0x20528E0", VA = "0x182053CE0", Slot = "26")]
			protected override bool OnTouchSessionCreate()
			{
				return default(bool);
			}

			// Token: 0x060254A6 RID: 152742 RVA: 0x000C75A8 File Offset: 0x000C57A8
			[Token(Token = "0x60254A6")]
			[Address(RVA = "0x2053D50", Offset = "0x2052950", VA = "0x182053D50", Slot = "27")]
			protected override bool OnTouchSessionUpdate()
			{
				return default(bool);
			}

			// Token: 0x060254A7 RID: 152743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60254A7")]
			[Address(RVA = "0x2053DC0", Offset = "0x20529C0", VA = "0x182053DC0")]
			private void <>xLuaBaseProxy_OnFirstDragOrPinchStarted()
			{
			}

			// Token: 0x060254A8 RID: 152744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60254A8")]
			[Address(RVA = "0x2053DD0", Offset = "0x20529D0", VA = "0x182053DD0")]
			private void <>xLuaBaseProxy_OnLastDragOrPinchStopped()
			{
			}

			// Token: 0x060254A9 RID: 152745 RVA: 0x000C75C0 File Offset: 0x000C57C0
			[Token(Token = "0x60254A9")]
			[Address(RVA = "0x2053DE0", Offset = "0x20529E0", VA = "0x182053DE0")]
			private bool <>xLuaBaseProxy_OnTouchSessionCreate()
			{
				return default(bool);
			}

			// Token: 0x060254AA RID: 152746 RVA: 0x000C75D8 File Offset: 0x000C57D8
			[Token(Token = "0x60254AA")]
			[Address(RVA = "0x2053DF0", Offset = "0x20529F0", VA = "0x182053DF0")]
			private bool <>xLuaBaseProxy_OnTouchSessionUpdate()
			{
				return default(bool);
			}

			// Token: 0x0403451C RID: 214300
			[Token(Token = "0x403451C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private ArtMagazineDiyLeafDragAndPinchController m_closure;

			// Token: 0x0403451D RID: 214301
			[Token(Token = "0x403451D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private int m_cachedTabChangeSeqNum;

			// Token: 0x0403451F RID: 214303
			[Token(Token = "0x403451F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isEditingDuringTouch;

			// Token: 0x04034520 RID: 214304
			[Token(Token = "0x4034520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isEditingDuringTouch;

			// Token: 0x04034521 RID: 214305
			[Token(Token = "0x4034521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034522 RID: 214306
			[Token(Token = "0x4034522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnFirstDragOrPinchStarted;

			// Token: 0x04034523 RID: 214307
			[Token(Token = "0x4034523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnLastDragOrPinchStopped;

			// Token: 0x04034524 RID: 214308
			[Token(Token = "0x4034524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnTouchSessionCreate;

			// Token: 0x04034525 RID: 214309
			[Token(Token = "0x4034525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnTouchSessionUpdate;
		}

		// Token: 0x02006550 RID: 25936
		[Token(Token = "0x2006550")]
		public class ArtMagazineDragContext : DragWithTargetContext
		{
			// Token: 0x060254AB RID: 152747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60254AB")]
			[Address(RVA = "0x2054030", Offset = "0x2052C30", VA = "0x182054030")]
			public ArtMagazineDragContext(ArtMagazineDiyLeafDragAndPinchController closure)
			{
			}

			// Token: 0x060254AC RID: 152748 RVA: 0x000C75F0 File Offset: 0x000C57F0
			[Token(Token = "0x60254AC")]
			[Address(RVA = "0x2053F50", Offset = "0x2052B50", VA = "0x182053F50", Slot = "26")]
			protected override bool OnTouchSessionCreate()
			{
				return default(bool);
			}

			// Token: 0x060254AD RID: 152749 RVA: 0x000C7608 File Offset: 0x000C5808
			[Token(Token = "0x60254AD")]
			[Address(RVA = "0x2053FC0", Offset = "0x2052BC0", VA = "0x182053FC0", Slot = "27")]
			protected override bool OnTouchSessionUpdate()
			{
				return default(bool);
			}

			// Token: 0x060254AE RID: 152750 RVA: 0x000C7620 File Offset: 0x000C5820
			[Token(Token = "0x60254AE")]
			[Address(RVA = "0x2053DE0", Offset = "0x20529E0", VA = "0x182053DE0")]
			private bool <>xLuaBaseProxy_OnTouchSessionCreate()
			{
				return default(bool);
			}

			// Token: 0x060254AF RID: 152751 RVA: 0x000C7638 File Offset: 0x000C5838
			[Token(Token = "0x60254AF")]
			[Address(RVA = "0x2053DF0", Offset = "0x20529F0", VA = "0x182053DF0")]
			private bool <>xLuaBaseProxy_OnTouchSessionUpdate()
			{
				return default(bool);
			}

			// Token: 0x04034526 RID: 214310
			[Token(Token = "0x4034526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private ArtMagazineDiyLeafDragAndPinchController m_closure;

			// Token: 0x04034527 RID: 214311
			[Token(Token = "0x4034527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private int m_cachedTabChangeSeqNum;

			// Token: 0x04034528 RID: 214312
			[Token(Token = "0x4034528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034529 RID: 214313
			[Token(Token = "0x4034529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnTouchSessionCreate;

			// Token: 0x0403452A RID: 214314
			[Token(Token = "0x403452A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnTouchSessionUpdate;
		}
	}
}
