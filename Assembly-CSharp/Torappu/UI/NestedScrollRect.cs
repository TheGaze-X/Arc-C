using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003996 RID: 14742
	[Token(Token = "0x2003996")]
	public class NestedScrollRect : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		// Token: 0x060174E1 RID: 95457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174E1")]
		[Address(RVA = "0xFACD40", Offset = "0xFAB940", VA = "0x180FACD40", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060174E2 RID: 95458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174E2")]
		[Address(RVA = "0xFACDF0", Offset = "0xFAB9F0", VA = "0x180FACDF0", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060174E3 RID: 95459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174E3")]
		[Address(RVA = "0xFACEA0", Offset = "0xFABAA0", VA = "0x180FACEA0", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060174E4 RID: 95460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60174E4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public NestedScrollRect()
		{
		}

		// Token: 0x0401C21D RID: 115229
		[Token(Token = "0x401C21D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _anotherScrollRect;
	}
}
