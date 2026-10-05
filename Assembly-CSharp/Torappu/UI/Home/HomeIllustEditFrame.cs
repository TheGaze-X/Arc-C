using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C26 RID: 19494
	[Token(Token = "0x2004C26")]
	[RequireComponent(typeof(RectTransform))]
	public class HomeIllustEditFrame : MonoBehaviour, IHotfixable, IPointerClickHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
	{
		// Token: 0x170044D5 RID: 17621
		// (get) Token: 0x0601D472 RID: 119922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170044D5")]
		protected RectTransform rectTrans
		{
			[Token(Token = "0x601D472")]
			[Address(RVA = "0x16CBE30", Offset = "0x16CAA30", VA = "0x1816CBE30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D473 RID: 119923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D473")]
		[Address(RVA = "0x16CBB70", Offset = "0x16CA770", VA = "0x1816CBB70")]
		private Camera _GetLocalCamera()
		{
			return null;
		}

		// Token: 0x0601D474 RID: 119924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D474")]
		[Address(RVA = "0x16CB350", Offset = "0x16C9F50", VA = "0x1816CB350")]
		public void BindDragEvent(HomeIllustEditFrame.IDragEvent dragEvent)
		{
		}

		// Token: 0x0601D475 RID: 119925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D475")]
		[Address(RVA = "0x16CB2D0", Offset = "0x16C9ED0", VA = "0x1816CB2D0")]
		public void BindClickEvent(HomeIllustEditFrame.IClickEvent clickEvent)
		{
		}

		// Token: 0x0601D476 RID: 119926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D476")]
		[Address(RVA = "0x16CB600", Offset = "0x16CA200", VA = "0x1816CB600")]
		public void SyncIllustInfo(HomeIllustView.IllustHandler handler)
		{
		}

		// Token: 0x0601D477 RID: 119927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D477")]
		[Address(RVA = "0x16CB450", Offset = "0x16CA050", VA = "0x1816CB450", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601D478 RID: 119928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D478")]
		[Address(RVA = "0x16CB3D0", Offset = "0x16C9FD0", VA = "0x1816CB3D0", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601D479 RID: 119929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D479")]
		[Address(RVA = "0x16CB4D0", Offset = "0x16CA0D0", VA = "0x1816CB4D0", Slot = "7")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601D47A RID: 119930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D47A")]
		[Address(RVA = "0x16CB540", Offset = "0x16CA140", VA = "0x1816CB540", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0601D47B RID: 119931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D47B")]
		[Address(RVA = "0x16CBC90", Offset = "0x16CA890", VA = "0x1816CBC90")]
		private void _TryBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601D47C RID: 119932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D47C")]
		[Address(RVA = "0x16CBD40", Offset = "0x16CA940", VA = "0x1816CBD40")]
		private void _TryClick(PointerEventData eventData)
		{
		}

		// Token: 0x0601D47D RID: 119933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D47D")]
		[Address(RVA = "0x16CBDD0", Offset = "0x16CA9D0", VA = "0x1816CBDD0")]
		public HomeIllustEditFrame()
		{
		}

		// Token: 0x04026823 RID: 157731
		[Token(Token = "0x4026823")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform m_rectTrans;

		// Token: 0x04026824 RID: 157732
		[Token(Token = "0x4026824")]
		[FieldOffset(Offset = "0x20")]
		private Camera m_localCamera;

		// Token: 0x04026825 RID: 157733
		[Token(Token = "0x4026825")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isDragging;

		// Token: 0x04026826 RID: 157734
		[Token(Token = "0x4026826")]
		[FieldOffset(Offset = "0x30")]
		private HomeIllustEditFrame.IDragEvent m_dragEvent;

		// Token: 0x04026827 RID: 157735
		[Token(Token = "0x4026827")]
		[FieldOffset(Offset = "0x38")]
		private HomeIllustEditFrame.IClickEvent m_clickEvent;

		// Token: 0x04026828 RID: 157736
		[Token(Token = "0x4026828")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rectTrans;

		// Token: 0x04026829 RID: 157737
		[Token(Token = "0x4026829")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetLocalCamera;

		// Token: 0x0402682A RID: 157738
		[Token(Token = "0x402682A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BindDragEvent;

		// Token: 0x0402682B RID: 157739
		[Token(Token = "0x402682B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BindClickEvent;

		// Token: 0x0402682C RID: 157740
		[Token(Token = "0x402682C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SyncIllustInfo;

		// Token: 0x0402682D RID: 157741
		[Token(Token = "0x402682D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x0402682E RID: 157742
		[Token(Token = "0x402682E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x0402682F RID: 157743
		[Token(Token = "0x402682F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x04026830 RID: 157744
		[Token(Token = "0x4026830")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPointerClick;

		// Token: 0x04026831 RID: 157745
		[Token(Token = "0x4026831")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryBeginDrag;

		// Token: 0x04026832 RID: 157746
		[Token(Token = "0x4026832")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryClick;

		// Token: 0x04026833 RID: 157747
		[Token(Token = "0x4026833")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C27 RID: 19495
		[Token(Token = "0x2004C27")]
		public interface IDragEvent
		{
			// Token: 0x0601D47E RID: 119934
			[Token(Token = "0x601D47E")]
			void BeginDragFromFrame(PointerEventData eventData);
		}

		// Token: 0x02004C28 RID: 19496
		[Token(Token = "0x2004C28")]
		public interface IClickEvent
		{
			// Token: 0x0601D47F RID: 119935
			[Token(Token = "0x601D47F")]
			void ClickFromFrame(PointerEventData eventData);
		}
	}
}
