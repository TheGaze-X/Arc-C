using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x02006735 RID: 26421
	[Token(Token = "0x2006735")]
	[RequireComponent(typeof(Graphic))]
	public class DragTrigger : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
	{
		// Token: 0x06025E2F RID: 155183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E2F")]
		[Address(RVA = "0x20CDD90", Offset = "0x20CC990", VA = "0x1820CDD90", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06025E30 RID: 155184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E30")]
		[Address(RVA = "0x20CDDE0", Offset = "0x20CC9E0", VA = "0x1820CDDE0", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06025E31 RID: 155185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E31")]
		[Address(RVA = "0x20CDE70", Offset = "0x20CCA70", VA = "0x1820CDE70", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06025E32 RID: 155186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E32")]
		[Address(RVA = "0xE55980", Offset = "0xE54580", VA = "0x180E55980", Slot = "7")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06025E33 RID: 155187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E33")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DragTrigger()
		{
		}

		// Token: 0x040354B3 RID: 218291
		[Token(Token = "0x40354B3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent _beginDragCallBack;

		// Token: 0x040354B4 RID: 218292
		[Token(Token = "0x40354B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIVector2Event _dragCallBack;

		// Token: 0x040354B5 RID: 218293
		[Token(Token = "0x40354B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _endDragCallBack;

		// Token: 0x040354B6 RID: 218294
		[Token(Token = "0x40354B6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onClickCallBack;

		// Token: 0x040354B7 RID: 218295
		[Token(Token = "0x40354B7")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isDragging;

		// Token: 0x040354B8 RID: 218296
		[Token(Token = "0x40354B8")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 m_beginPos;
	}
}
