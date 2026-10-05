using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Vuplex.WebView
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[HelpURL("https://developer.vuplex.com/webview/IPointerInputDetector")]
	public class DefaultPointerInputDetector : MonoBehaviour, IPointerInputDetector, IBeginDragHandler, IEventSystemHandler, IDragHandler, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler, IPointerUpHandler, IScrollHandler
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000B")]
		public event EventHandler<EventArgs<Vector2>> BeganDrag
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x5BB4740", Offset = "0x5BB3340", VA = "0x185BB4740", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x5BB4CB0", Offset = "0x5BB38B0", VA = "0x185BB4CB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000C")]
		public event EventHandler<EventArgs<Vector2>> Dragged
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x5BB47F0", Offset = "0x5BB33F0", VA = "0x185BB47F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x5BB4D60", Offset = "0x5BB3960", VA = "0x185BB4D60", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000D")]
		public event EventHandler<PointerEventArgs> PointerDown
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x5BB48A0", Offset = "0x5BB34A0", VA = "0x185BB48A0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x5BB4E10", Offset = "0x5BB3A10", VA = "0x185BB4E10", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000E")]
		public event EventHandler PointerEntered
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x5BB4950", Offset = "0x5BB3550", VA = "0x185BB4950", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x5BB4EC0", Offset = "0x5BB3AC0", VA = "0x185BB4EC0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000F")]
		public event EventHandler<EventArgs<Vector2>> PointerExited
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x5BB49F0", Offset = "0x5BB35F0", VA = "0x185BB49F0", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x5BB4F60", Offset = "0x5BB3B60", VA = "0x185BB4F60", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000010")]
		public event EventHandler<EventArgs<Vector2>> PointerMoved
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x5BB4AA0", Offset = "0x5BB36A0", VA = "0x185BB4AA0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x5BB5010", Offset = "0x5BB3C10", VA = "0x185BB5010", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000011")]
		public event EventHandler<PointerEventArgs> PointerUp
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x5BB4B50", Offset = "0x5BB3750", VA = "0x185BB4B50", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x5BB50C0", Offset = "0x5BB3CC0", VA = "0x185BB50C0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000012")]
		public event EventHandler<ScrolledEventArgs> Scrolled
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x5BB4C00", Offset = "0x5BB3800", VA = "0x185BB4C00", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x5BB5170", Offset = "0x5BB3D70", VA = "0x185BB5170", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public bool PointerMovedEnabled
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20", Slot = "21")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x5BB3300", Offset = "0x5BB1F00", VA = "0x185BB3300", Slot = "22")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x5BB3340", Offset = "0x5BB1F40", VA = "0x185BB3340", Slot = "23")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "24")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x5BB33C0", Offset = "0x5BB1FC0", VA = "0x185BB33C0", Slot = "31")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5BB34B0", Offset = "0x5BB20B0", VA = "0x185BB34B0", Slot = "26")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5BB3530", Offset = "0x5BB2130", VA = "0x185BB3530", Slot = "27")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x5BB3830", Offset = "0x5BB2430", VA = "0x185BB3830", Slot = "28")]
		public void OnPointerMove(PointerEventData eventData)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x5BB3960", Offset = "0x5BB2560", VA = "0x185BB3960", Slot = "32")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x5BB39A0", Offset = "0x5BB25A0", VA = "0x185BB39A0", Slot = "30")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x5BB3B90", Offset = "0x5BB2790", VA = "0x185BB3B90")]
		private EventArgs<Vector2> _convertToEventArgs(Vector3 worldPosition)
		{
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5BB3AE0", Offset = "0x5BB26E0", VA = "0x185BB3AE0")]
		private EventArgs<Vector2> _convertToEventArgs(PointerEventData pointerEventData)
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x5BB3C50", Offset = "0x5BB2850", VA = "0x185BB3C50", Slot = "33")]
		protected virtual Vector2 _convertToNormalizedPoint(PointerEventData pointerEventData)
		{
			return default(Vector2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x5BB3CD0", Offset = "0x5BB28D0", VA = "0x185BB3CD0", Slot = "34")]
		protected virtual Vector2 _convertToNormalizedPoint(Vector3 worldPosition)
		{
			return default(Vector2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x5BB3F20", Offset = "0x5BB2B20", VA = "0x185BB3F20")]
		private PointerEventArgs _convertToPointerEventArgs(PointerEventData eventData)
		{
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x5BB4020", Offset = "0x5BB2C20", VA = "0x185BB4020")]
		private PointerEventData _getLastPointerEventData()
		{
			return null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x5BB44C0", Offset = "0x5BB30C0", VA = "0x185BB44C0", Slot = "35")]
		protected virtual bool _positionIsZero(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x5BB46C0", Offset = "0x5BB32C0", VA = "0x185BB46C0")]
		protected void _raiseBeganDragEvent(EventArgs<Vector2> eventArgs)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x5BB46E0", Offset = "0x5BB32E0", VA = "0x185BB46E0")]
		protected void _raiseDraggedEvent(EventArgs<Vector2> eventArgs)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x5BB4700", Offset = "0x5BB3300", VA = "0x185BB4700")]
		protected void _raisePointerDownEvent(PointerEventArgs eventArgs)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x45B3E10", Offset = "0x45B2A10", VA = "0x1845B3E10")]
		protected void _raisePointerEnteredEvent(EventArgs eventArgs)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x45B3E30", Offset = "0x45B2A30", VA = "0x1845B3E30")]
		protected void _raisePointerExitedEvent(EventArgs<Vector2> eventArgs)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x5BB4580", Offset = "0x5BB3180", VA = "0x185BB4580")]
		private void _processLegacyPointerMoveHandler()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x5BB4720", Offset = "0x5BB3320", VA = "0x185BB4720")]
		protected void _raisePointerMovedEvent(EventArgs<Vector2> eventArgs)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x51205B0", Offset = "0x511F1B0", VA = "0x1851205B0")]
		protected void _raisePointerUpEvent(PointerEventArgs eventArgs)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x51205D0", Offset = "0x511F1D0", VA = "0x1851205D0")]
		protected void _raiseScrolledEvent(ScrolledEventArgs eventArgs)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "36")]
		protected virtual void Update()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x5BB0F60", Offset = "0x5BAFB60", VA = "0x185BB0F60")]
		public DefaultPointerInputDetector()
		{
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x5C")]
		private int _clickCount;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x60")]
		private DateTime _lastPointerDownDateTime;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x68")]
		private bool _isHovering;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x6C")]
		private Vector2 _previousPointerMovedPoint;
	}
}
