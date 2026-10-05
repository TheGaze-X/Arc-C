using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
	public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000188")]
		public IPanel panel
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x5B8C710", Offset = "0x5B8B310", VA = "0x185B8C710", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		private GameObject selectableGameObject
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x5B8C6F0", Offset = "0x5B8B2F0", VA = "0x185B8C6F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018A")]
		private EventSystem eventSystem
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x5B8C5E0", Offset = "0x5B8B1E0", VA = "0x185B8C5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x5B8A9D0", Offset = "0x5B895D0", VA = "0x185B8A9D0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x5B8A910", Offset = "0x5B89510", VA = "0x185B8A910", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x5B8BC10", Offset = "0x5B8A810", VA = "0x185B8BC10")]
		private void RegisterCallbacks()
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x5B8C260", Offset = "0x5B8AE60", VA = "0x185B8C260")]
		private void UnregisterCallbacks()
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x5B8AB30", Offset = "0x5B89730", VA = "0x185B8AB30")]
		private void OnPanelDestroyed()
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x5B8A920", Offset = "0x5B89520", VA = "0x185B8A920")]
		private void OnElementFocus(FocusEvent e)
		{
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void OnElementBlur(BlurEvent e)
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x5B8B570", Offset = "0x5B8A170", VA = "0x185B8B570", Slot = "24")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x5B8A8F0", Offset = "0x5B894F0", VA = "0x185B8A8F0", Slot = "25")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x5B8B0B0", Offset = "0x5B89CB0", VA = "0x185B8B0B0", Slot = "17")]
		public void OnPointerMove(PointerEventData eventData)
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x5B8B210", Offset = "0x5B89E10", VA = "0x185B8B210", Slot = "18")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x5B8AB40", Offset = "0x5B89740", VA = "0x185B8AB40", Slot = "19")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x5B8ADF0", Offset = "0x5B899F0", VA = "0x185B8ADF0", Slot = "26")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x5B8AD70", Offset = "0x5B89970", VA = "0x185B8AD70", Slot = "27")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x5B8B5E0", Offset = "0x5B8A1E0", VA = "0x185B8B5E0", Slot = "20")]
		public void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x5B8A780", Offset = "0x5B89380", VA = "0x185B8A780", Slot = "21")]
		public void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x5B8A9E0", Offset = "0x5B895E0", VA = "0x185B8A9E0", Slot = "22")]
		public void OnMove(AxisEventData eventData)
		{
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x5B8B3D0", Offset = "0x5B89FD0", VA = "0x185B8B3D0", Slot = "23")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x5B8BE00", Offset = "0x5B8AA00", VA = "0x185B8BE00")]
		private void SendEvent(EventBase e, BaseEventData sourceEventData)
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x5B8BE80", Offset = "0x5B8AA80", VA = "0x185B8BE80")]
		private void SendEvent(EventBase e, Event sourceEvent)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x5B8C450", Offset = "0x5B8B050", VA = "0x185B8C450")]
		private void Update()
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x5B8A770", Offset = "0x5B89370", VA = "0x185B8A770")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x5B8B750", Offset = "0x5B8A350", VA = "0x185B8B750")]
		private void ProcessImguiEvents(bool isSelected)
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x5B8B950", Offset = "0x5B8A550", VA = "0x185B8B950")]
		private void ProcessKeyboardEvent(Event e)
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x5B8B9C0", Offset = "0x5B8A5C0", VA = "0x185B8B9C0")]
		private void ProcessTabEvent(Event e)
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x5B8C160", Offset = "0x5B8AD60", VA = "0x185B8C160")]
		private void SendTabEvent(Event e, int direction)
		{
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x5B8C030", Offset = "0x5B8AC30", VA = "0x185B8C030")]
		private void SendKeyUpEvent(Event e)
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x5B8BEE0", Offset = "0x5B8AAE0", VA = "0x185B8BEE0")]
		private void SendKeyDownEvent(Event e)
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x5B8BA40", Offset = "0x5B8A640", VA = "0x185B8BA40")]
		private bool ReadPointerData(PanelEventHandler.PointerEvent pe, PointerEventData eventData, PanelEventHandler.PointerEventType eventType = PanelEventHandler.PointerEventType.Default)
		{
			return default(bool);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x5B8C530", Offset = "0x5B8B130", VA = "0x185B8C530")]
		public PanelEventHandler()
		{
		}

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x18")]
		private BaseRuntimePanel m_Panel;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x20")]
		private readonly PanelEventHandler.PointerEvent m_PointerEvent;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x28")]
		private bool m_Selecting;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x30")]
		private Event m_Event;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x0")]
		private static EventModifiers s_Modifiers;

		// Token: 0x020000A4 RID: 164
		[Token(Token = "0x20000A4")]
		private enum PointerEventType
		{
			// Token: 0x040002EC RID: 748
			[Token(Token = "0x40002EC")]
			Default,
			// Token: 0x040002ED RID: 749
			[Token(Token = "0x40002ED")]
			Down,
			// Token: 0x040002EE RID: 750
			[Token(Token = "0x40002EE")]
			Up
		}

		// Token: 0x020000A5 RID: 165
		[Token(Token = "0x20000A5")]
		private class PointerEvent : IPointerEvent
		{
			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000624 RID: 1572 RVA: 0x00004560 File Offset: 0x00002760
			// (set) Token: 0x06000625 RID: 1573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700018B")]
			public int pointerId
			{
				[Token(Token = "0x6000624")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000625")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000627 RID: 1575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700018C")]
			public string pointerType
			{
				[Token(Token = "0x6000626")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06000628 RID: 1576 RVA: 0x00004578 File Offset: 0x00002778
			// (set) Token: 0x06000629 RID: 1577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700018D")]
			public bool isPrimary
			{
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000629")]
				[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x0600062A RID: 1578 RVA: 0x00004590 File Offset: 0x00002790
			// (set) Token: 0x0600062B RID: 1579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700018E")]
			public int button
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600062B")]
				[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x0600062C RID: 1580 RVA: 0x000045A8 File Offset: 0x000027A8
			// (set) Token: 0x0600062D RID: 1581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700018F")]
			public int pressedButtons
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600062D")]
				[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x0600062E RID: 1582 RVA: 0x000045C0 File Offset: 0x000027C0
			// (set) Token: 0x0600062F RID: 1583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000190")]
			public Vector3 position
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x58DDEA0", Offset = "0x58DCAA0", VA = "0x1858DDEA0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600062F")]
				[Address(RVA = "0x58DE130", Offset = "0x58DCD30", VA = "0x1858DE130")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06000630 RID: 1584 RVA: 0x000045D8 File Offset: 0x000027D8
			// (set) Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000191")]
			public Vector3 localPosition
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x32FB1B0", Offset = "0x32F9DB0", VA = "0x1832FB1B0", Slot = "10")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x5531CB0", Offset = "0x55308B0", VA = "0x185531CB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x06000632 RID: 1586 RVA: 0x000045F0 File Offset: 0x000027F0
			// (set) Token: 0x06000633 RID: 1587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000192")]
			public Vector3 deltaPosition
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x5B8FC60", Offset = "0x5B8E860", VA = "0x185B8FC60", Slot = "11")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x5B8FCD0", Offset = "0x5B8E8D0", VA = "0x185B8FCD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x06000634 RID: 1588 RVA: 0x00004608 File Offset: 0x00002808
			// (set) Token: 0x06000635 RID: 1589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000193")]
			public float deltaTime
			{
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x1251100", Offset = "0x124FD00", VA = "0x181251100", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x1692870", Offset = "0x1691470", VA = "0x181692870")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x06000636 RID: 1590 RVA: 0x00004620 File Offset: 0x00002820
			// (set) Token: 0x06000637 RID: 1591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000194")]
			public int clickCount
			{
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x4FA5A00", Offset = "0x4FA4600", VA = "0x184FA5A00", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000637")]
				[Address(RVA = "0x53DA830", Offset = "0x53D9430", VA = "0x1853DA830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x06000638 RID: 1592 RVA: 0x00004638 File Offset: 0x00002838
			// (set) Token: 0x06000639 RID: 1593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000195")]
			public float pressure
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x1692360", Offset = "0x1690F60", VA = "0x181692360", Slot = "14")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x1692840", Offset = "0x1691440", VA = "0x181692840")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000196 RID: 406
			// (get) Token: 0x0600063A RID: 1594 RVA: 0x00004650 File Offset: 0x00002850
			// (set) Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000196")]
			public float tangentialPressure
			{
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x4E4DA40", Offset = "0x4E4C640", VA = "0x184E4DA40", Slot = "15")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600063B")]
				[Address(RVA = "0x4E4DF20", Offset = "0x4E4CB20", VA = "0x184E4DF20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x0600063C RID: 1596 RVA: 0x00004668 File Offset: 0x00002868
			// (set) Token: 0x0600063D RID: 1597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000197")]
			public float altitudeAngle
			{
				[Token(Token = "0x600063C")]
				[Address(RVA = "0x4E4DA50", Offset = "0x4E4C650", VA = "0x184E4DA50", Slot = "16")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x4E4DF30", Offset = "0x4E4CB30", VA = "0x184E4DF30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x0600063E RID: 1598 RVA: 0x00004680 File Offset: 0x00002880
			// (set) Token: 0x0600063F RID: 1599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000198")]
			public float azimuthAngle
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x4E4DA60", Offset = "0x4E4C660", VA = "0x184E4DA60", Slot = "17")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x4E4DF40", Offset = "0x4E4CB40", VA = "0x184E4DF40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x06000640 RID: 1600 RVA: 0x00004698 File Offset: 0x00002898
			// (set) Token: 0x06000641 RID: 1601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000199")]
			public float twist
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x1692630", Offset = "0x1691230", VA = "0x181692630", Slot = "18")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000641")]
				[Address(RVA = "0x1692B20", Offset = "0x1691720", VA = "0x181692B20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x06000642 RID: 1602 RVA: 0x000046B0 File Offset: 0x000028B0
			// (set) Token: 0x06000643 RID: 1603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700019A")]
			public Vector2 radius
			{
				[Token(Token = "0x6000642")]
				[Address(RVA = "0x5B8FCA0", Offset = "0x5B8E8A0", VA = "0x185B8FCA0", Slot = "19")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000643")]
				[Address(RVA = "0x5B8FCF0", Offset = "0x5B8E8F0", VA = "0x185B8FCF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x06000644 RID: 1604 RVA: 0x000046C8 File Offset: 0x000028C8
			// (set) Token: 0x06000645 RID: 1605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700019B")]
			public Vector2 radiusVariance
			{
				[Token(Token = "0x6000644")]
				[Address(RVA = "0x5B8FC80", Offset = "0x5B8E880", VA = "0x185B8FC80", Slot = "20")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x5B8FCE0", Offset = "0x5B8E8E0", VA = "0x185B8FCE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000646 RID: 1606 RVA: 0x000046E0 File Offset: 0x000028E0
			// (set) Token: 0x06000647 RID: 1607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700019C")]
			public EventModifiers modifiers
			{
				[Token(Token = "0x6000646")]
				[Address(RVA = "0x557C480", Offset = "0x557B080", VA = "0x18557C480", Slot = "21")]
				[CompilerGenerated]
				get
				{
					return EventModifiers.None;
				}
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x557C490", Offset = "0x557B090", VA = "0x18557C490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x06000648 RID: 1608 RVA: 0x000046F8 File Offset: 0x000028F8
			[Token(Token = "0x1700019D")]
			public bool shiftKey
			{
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x5B8FCC0", Offset = "0x5B8E8C0", VA = "0x185B8FCC0", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x06000649 RID: 1609 RVA: 0x00004710 File Offset: 0x00002910
			[Token(Token = "0x1700019E")]
			public bool ctrlKey
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x5B8FC50", Offset = "0x5B8E850", VA = "0x185B8FC50", Slot = "23")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x0600064A RID: 1610 RVA: 0x00004728 File Offset: 0x00002928
			[Token(Token = "0x1700019F")]
			public bool commandKey
			{
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x5B8FC40", Offset = "0x5B8E840", VA = "0x185B8FC40", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x0600064B RID: 1611 RVA: 0x00004740 File Offset: 0x00002940
			[Token(Token = "0x170001A0")]
			public bool altKey
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x5B8FC30", Offset = "0x5B8E830", VA = "0x185B8FC30", Slot = "25")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x0600064C RID: 1612 RVA: 0x00004758 File Offset: 0x00002958
			[Token(Token = "0x170001A1")]
			public bool actionKey
			{
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x5B8FBF0", Offset = "0x5B8E7F0", VA = "0x185B8FBF0", Slot = "26")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x5B8F5E0", Offset = "0x5B8E1E0", VA = "0x185B8F5E0")]
			public void Read(PanelEventHandler self, PointerEventData eventData, PanelEventHandler.PointerEventType eventType)
			{
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x5B8FBA0", Offset = "0x5B8E7A0", VA = "0x185B8FBA0")]
			public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride)
			{
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PointerEvent()
			{
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x00004770 File Offset: 0x00002970
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x5B8FBD0", Offset = "0x5B8E7D0", VA = "0x185B8FBD0")]
			[CompilerGenerated]
			internal static bool <Read>g__InRange|82_0(int i, int start, int count)
			{
				return default(bool);
			}
		}
	}
}
