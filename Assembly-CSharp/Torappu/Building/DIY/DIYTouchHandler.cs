using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x020018E7 RID: 6375
	[Token(Token = "0x20018E7")]
	public class DIYTouchHandler : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler, IDragHandler, IHotfixable
	{
		// Token: 0x1400003B RID: 59
		// (add) Token: 0x0600A0B9 RID: 41145 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A0BA RID: 41146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003B")]
		public event Action targetPointEmpty
		{
			[Token(Token = "0x600A0B9")]
			[Address(RVA = "0x31AFE40", Offset = "0x31AEA40", VA = "0x1831AFE40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A0BA")]
			[Address(RVA = "0x31B0520", Offset = "0x31AF120", VA = "0x1831B0520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600A0BB RID: 41147 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A0BC RID: 41148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003C")]
		public event Action<Vector2> targetDragEmpty
		{
			[Token(Token = "0x600A0BB")]
			[Address(RVA = "0x31AFB40", Offset = "0x31AE740", VA = "0x1831AFB40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A0BC")]
			[Address(RVA = "0x31B0220", Offset = "0x31AEE20", VA = "0x1831B0220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x0600A0BD RID: 41149 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A0BE RID: 41150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003D")]
		public event Action<DIYRoom.IFurnitureController, bool> targetBeginDrag
		{
			[Token(Token = "0x600A0BD")]
			[Address(RVA = "0x31AFA40", Offset = "0x31AE640", VA = "0x1831AFA40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A0BE")]
			[Address(RVA = "0x31B0120", Offset = "0x31AED20", VA = "0x1831B0120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x0600A0BF RID: 41151 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A0C0 RID: 41152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003E")]
		public event Action<DIYRoom.IFurnitureController> targetStartDrag
		{
			[Token(Token = "0x600A0BF")]
			[Address(RVA = "0x31AFF20", Offset = "0x31AEB20", VA = "0x1831AFF20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A0C0")]
			[Address(RVA = "0x31B0600", Offset = "0x31AF200", VA = "0x1831B0600")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x0600A0C1 RID: 41153 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A0C2 RID: 41154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003F")]
		public event Action<DIYRoom.IFurnitureController> targetEndDrag
		{
			[Token(Token = "0x600A0C1")]
			[Address(RVA = "0x31AFD40", Offset = "0x31AE940", VA = "0x1831AFD40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A0C2")]
			[Address(RVA = "0x31B0420", Offset = "0x31AF020", VA = "0x1831B0420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x0600A0C3 RID: 41155 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A0C4 RID: 41156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000040")]
		public event Action<DIYRoom.IFurnitureController, int, int> targetDragged
		{
			[Token(Token = "0x600A0C3")]
			[Address(RVA = "0x31AFC40", Offset = "0x31AE840", VA = "0x1831AFC40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A0C4")]
			[Address(RVA = "0x31B0320", Offset = "0x31AEF20", VA = "0x1831B0320")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x0600A0C5 RID: 41157 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A0C6 RID: 41158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000041")]
		public event Action<DIYRoomIndicatorButton> indicatorButtonPressed
		{
			[Token(Token = "0x600A0C5")]
			[Address(RVA = "0x31AF940", Offset = "0x31AE540", VA = "0x1831AF940")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A0C6")]
			[Address(RVA = "0x31B0020", Offset = "0x31AEC20", VA = "0x1831B0020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C7")]
		[Address(RVA = "0x31AECA0", Offset = "0x31AD8A0", VA = "0x1831AECA0", Slot = "4")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C8")]
		[Address(RVA = "0x31AE230", Offset = "0x31ACE30", VA = "0x1831AE230", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C9")]
		[Address(RVA = "0x31AEFD0", Offset = "0x31ADBD0", VA = "0x1831AEFD0")]
		private void Update()
		{
		}

		// Token: 0x0600A0CA RID: 41162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CA")]
		[Address(RVA = "0x31AF3E0", Offset = "0x31ADFE0", VA = "0x1831AF3E0")]
		private void _TargetBeginDrag()
		{
		}

		// Token: 0x0600A0CB RID: 41163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CB")]
		[Address(RVA = "0x31AEED0", Offset = "0x31ADAD0", VA = "0x1831AEED0")]
		public void RegisterControllerManually(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CC")]
		[Address(RVA = "0x31AEF50", Offset = "0x31ADB50", VA = "0x1831AEF50")]
		public void UnRegisterControllerManually()
		{
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CD")]
		[Address(RVA = "0x31AF4E0", Offset = "0x31AE0E0", VA = "0x1831AF4E0")]
		private void _TargetDragImmediately(PointerEventData eventData)
		{
		}

		// Token: 0x0600A0CE RID: 41166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CE")]
		[Address(RVA = "0x31AF700", Offset = "0x31AE300", VA = "0x1831AF700")]
		private void _TargetStartDrag()
		{
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0CF")]
		[Address(RVA = "0x31AF670", Offset = "0x31AE270", VA = "0x1831AF670")]
		private void _TargetEndDrag()
		{
		}

		// Token: 0x0600A0D0 RID: 41168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D0")]
		[Address(RVA = "0x31AF790", Offset = "0x31AE390", VA = "0x1831AF790")]
		private void _TargetStopDrag()
		{
		}

		// Token: 0x0600A0D1 RID: 41169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D1")]
		[Address(RVA = "0x31AF0A0", Offset = "0x31ADCA0", VA = "0x1831AF0A0")]
		private void _RefreshCurrentHolderController()
		{
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D2")]
		[Address(RVA = "0x31AF1A0", Offset = "0x31ADDA0", VA = "0x1831AF1A0")]
		private void _RefreshMoveFactor()
		{
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x0003EA60 File Offset: 0x0003CC60
		[Token(Token = "0x600A0D3")]
		[Address(RVA = "0x31ADA90", Offset = "0x31AC690", VA = "0x1831ADA90")]
		private bool DragFurniture(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D4")]
		[Address(RVA = "0x31ADF40", Offset = "0x31ACB40", VA = "0x1831ADF40", Slot = "6")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0D5")]
		[Address(RVA = "0x31AF830", Offset = "0x31AE430", VA = "0x1831AF830")]
		public DIYTouchHandler()
		{
		}

		// Token: 0x040096EF RID: 38639
		[Token(Token = "0x40096EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BaseRaycaster _raycaster;

		// Token: 0x040096F0 RID: 38640
		[Token(Token = "0x40096F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _targetCamera;

		// Token: 0x040096F1 RID: 38641
		[Token(Token = "0x40096F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _dragThreshold;

		// Token: 0x040096F2 RID: 38642
		[Token(Token = "0x40096F2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _advancedLayer;

		// Token: 0x040096F3 RID: 38643
		[Token(Token = "0x40096F3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useHolderAxis;

		// Token: 0x040096F4 RID: 38644
		[Token(Token = "0x40096F4")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _useFixedThreshold;

		// Token: 0x040096F5 RID: 38645
		[Token(Token = "0x40096F5")]
		[FieldOffset(Offset = "0x40")]
		private DIYRoom.IFurnitureController m_currentHolderController;

		// Token: 0x040096F6 RID: 38646
		[Token(Token = "0x40096F6")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 m_dragOriginPosition;

		// Token: 0x040096F7 RID: 38647
		[Token(Token = "0x40096F7")]
		[FieldOffset(Offset = "0x54")]
		private Vector2 m_dragOriginPosition2Screen;

		// Token: 0x040096F8 RID: 38648
		[Token(Token = "0x40096F8")]
		[FieldOffset(Offset = "0x60")]
		private GameObject m_currentDragOrigin;

		// Token: 0x040096F9 RID: 38649
		[Token(Token = "0x40096F9")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_moveFactor;

		// Token: 0x040096FA RID: 38650
		[Token(Token = "0x40096FA")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 m_moveDragThreshold;

		// Token: 0x040096FB RID: 38651
		[Token(Token = "0x40096FB")]
		[FieldOffset(Offset = "0x78")]
		private DIYTouchHandler.DragState m_dragState;

		// Token: 0x040096FC RID: 38652
		[Token(Token = "0x40096FC")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_dragging;

		// Token: 0x040096FD RID: 38653
		[Token(Token = "0x40096FD")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_emptyDragOrigin;

		// Token: 0x040096FE RID: 38654
		[Token(Token = "0x40096FE")]
		[FieldOffset(Offset = "0x88")]
		private List<RaycastResult> m_pointResult;

		// Token: 0x040096FF RID: 38655
		[Token(Token = "0x40096FF")]
		[FieldOffset(Offset = "0x90")]
		private RaycastResult m_CurrentPointResult;

		// Token: 0x04009700 RID: 38656
		[Token(Token = "0x4009700")]
		[FieldOffset(Offset = "0xE0")]
		private float m_CurrentPointWaitTime;

		// Token: 0x04009701 RID: 38657
		[Token(Token = "0x4009701")]
		[FieldOffset(Offset = "0xE4")]
		private Vector2 m_CurrentPointOriginOffset;

		// Token: 0x04009702 RID: 38658
		[Token(Token = "0x4009702")]
		[FieldOffset(Offset = "0xEC")]
		private bool m_CurrentPointHasBegin;

		// Token: 0x04009703 RID: 38659
		[Token(Token = "0x4009703")]
		[FieldOffset(Offset = "0xED")]
		private bool m_CurrentPointHasInterrupt;

		// Token: 0x04009704 RID: 38660
		[Token(Token = "0x4009704")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float pointWaitBeginTime;

		// Token: 0x04009705 RID: 38661
		[Token(Token = "0x4009705")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private float pointWaitStartTime;

		// Token: 0x04009706 RID: 38662
		[Token(Token = "0x4009706")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool selectImmediatelyWhenSelected;

		// Token: 0x04009707 RID: 38663
		[Token(Token = "0x4009707")]
		[FieldOffset(Offset = "0xF9")]
		[SerializeField]
		private bool canDragOutsideWhenWait;

		// Token: 0x0400970F RID: 38671
		[Token(Token = "0x400970F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_targetPointEmpty;

		// Token: 0x04009710 RID: 38672
		[Token(Token = "0x4009710")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_targetPointEmpty;

		// Token: 0x04009711 RID: 38673
		[Token(Token = "0x4009711")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_add_targetDragEmpty;

		// Token: 0x04009712 RID: 38674
		[Token(Token = "0x4009712")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_remove_targetDragEmpty;

		// Token: 0x04009713 RID: 38675
		[Token(Token = "0x4009713")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_add_targetBeginDrag;

		// Token: 0x04009714 RID: 38676
		[Token(Token = "0x4009714")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_remove_targetBeginDrag;

		// Token: 0x04009715 RID: 38677
		[Token(Token = "0x4009715")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_add_targetStartDrag;

		// Token: 0x04009716 RID: 38678
		[Token(Token = "0x4009716")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_remove_targetStartDrag;

		// Token: 0x04009717 RID: 38679
		[Token(Token = "0x4009717")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_add_targetEndDrag;

		// Token: 0x04009718 RID: 38680
		[Token(Token = "0x4009718")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_remove_targetEndDrag;

		// Token: 0x04009719 RID: 38681
		[Token(Token = "0x4009719")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_add_targetDragged;

		// Token: 0x0400971A RID: 38682
		[Token(Token = "0x400971A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_remove_targetDragged;

		// Token: 0x0400971B RID: 38683
		[Token(Token = "0x400971B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_add_indicatorButtonPressed;

		// Token: 0x0400971C RID: 38684
		[Token(Token = "0x400971C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_remove_indicatorButtonPressed;

		// Token: 0x0400971D RID: 38685
		[Token(Token = "0x400971D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnPointerUp;

		// Token: 0x0400971E RID: 38686
		[Token(Token = "0x400971E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x0400971F RID: 38687
		[Token(Token = "0x400971F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04009720 RID: 38688
		[Token(Token = "0x4009720")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TargetBeginDrag;

		// Token: 0x04009721 RID: 38689
		[Token(Token = "0x4009721")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_RegisterControllerManually;

		// Token: 0x04009722 RID: 38690
		[Token(Token = "0x4009722")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UnRegisterControllerManually;

		// Token: 0x04009723 RID: 38691
		[Token(Token = "0x4009723")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TargetDragImmediately;

		// Token: 0x04009724 RID: 38692
		[Token(Token = "0x4009724")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TargetStartDrag;

		// Token: 0x04009725 RID: 38693
		[Token(Token = "0x4009725")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TargetEndDrag;

		// Token: 0x04009726 RID: 38694
		[Token(Token = "0x4009726")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__TargetStopDrag;

		// Token: 0x04009727 RID: 38695
		[Token(Token = "0x4009727")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RefreshCurrentHolderController;

		// Token: 0x04009728 RID: 38696
		[Token(Token = "0x4009728")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RefreshMoveFactor;

		// Token: 0x04009729 RID: 38697
		[Token(Token = "0x4009729")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_DragFurniture;

		// Token: 0x0400972A RID: 38698
		[Token(Token = "0x400972A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0400972B RID: 38699
		[Token(Token = "0x400972B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020018E8 RID: 6376
		[Token(Token = "0x20018E8")]
		private enum DragState
		{
			// Token: 0x0400972D RID: 38701
			[Token(Token = "0x400972D")]
			NONE,
			// Token: 0x0400972E RID: 38702
			[Token(Token = "0x400972E")]
			WAIT,
			// Token: 0x0400972F RID: 38703
			[Token(Token = "0x400972F")]
			FURNITURE,
			// Token: 0x04009730 RID: 38704
			[Token(Token = "0x4009730")]
			EMPTY,
			// Token: 0x04009731 RID: 38705
			[Token(Token = "0x4009731")]
			BUTTON
		}
	}
}
