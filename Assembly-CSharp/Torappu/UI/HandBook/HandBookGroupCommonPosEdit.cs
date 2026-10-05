using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066E2 RID: 26338
	[Token(Token = "0x20066E2")]
	public class HandBookGroupCommonPosEdit : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler, IBeginDragHandler
	{
		// Token: 0x06025CAF RID: 154799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CAF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void ApplyPos(Vector3 vect)
		{
		}

		// Token: 0x06025CB0 RID: 154800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CB0")]
		[Address(RVA = "0x20B8700", Offset = "0x20B7300", VA = "0x1820B8700", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06025CB1 RID: 154801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CB1")]
		[Address(RVA = "0x20B8770", Offset = "0x20B7370", VA = "0x1820B8770", Slot = "8")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06025CB2 RID: 154802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CB2")]
		[Address(RVA = "0x20B86F0", Offset = "0x20B72F0", VA = "0x1820B86F0", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06025CB3 RID: 154803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CB3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookGroupCommonPosEdit()
		{
		}

		// Token: 0x04035232 RID: 217650
		[Token(Token = "0x4035232")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public int x;

		// Token: 0x04035233 RID: 217651
		[Token(Token = "0x4035233")]
		[FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		public int y;

		// Token: 0x04035234 RID: 217652
		[Token(Token = "0x4035234")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public bool isInited;

		// Token: 0x04035235 RID: 217653
		[Token(Token = "0x4035235")]
		[FieldOffset(Offset = "0x21")]
		protected bool m_dragLock;
	}
}
