using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	public abstract class PointerInputModule : BaseInputModule
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x5B90910", Offset = "0x5B8F510", VA = "0x185B90910")]
		protected bool GetPointerData(int id, out PointerEventData data, bool create)
		{
			return default(bool);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x5B91220", Offset = "0x5B8FE20", VA = "0x185B91220")]
		protected void RemovePointerData(PointerEventData data)
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x5B90A10", Offset = "0x5B8F610", VA = "0x185B90A10")]
		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			return null;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x5B8FEB0", Offset = "0x5B8EAB0", VA = "0x185B8FEB0")]
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x5B912D0", Offset = "0x5B8FED0", VA = "0x185B912D0")]
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			return PointerEventData.FramePressState.Pressed;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x5B90120", Offset = "0x5B8ED20", VA = "0x185B90120", Slot = "28")]
		protected virtual PointerInputModule.MouseState GetMousePointerEventData()
		{
			return null;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x5B90160", Offset = "0x5B8ED60", VA = "0x185B90160", Slot = "29")]
		protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id)
		{
			return null;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x5B900F0", Offset = "0x5B8ECF0", VA = "0x185B900F0")]
		protected PointerEventData GetLastPointerEventData(int id)
		{
			return null;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x5B91280", Offset = "0x5B8FE80", VA = "0x185B91280")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x5B911D0", Offset = "0x5B8FDD0", VA = "0x185B911D0", Slot = "30")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x5B90F00", Offset = "0x5B8FB00", VA = "0x185B90F00", Slot = "31")]
		protected virtual void ProcessDrag(PointerEventData pointerEvent)
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x5B90E70", Offset = "0x5B8FA70", VA = "0x185B90E70", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x5B8FD00", Offset = "0x5B8E900", VA = "0x185B8FD00")]
		protected void ClearSelection()
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x5B913B0", Offset = "0x5B8FFB0", VA = "0x185B913B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x5B90010", Offset = "0x5B8EC10", VA = "0x185B90010")]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x5B91640", Offset = "0x5B90240", VA = "0x185B91640")]
		protected PointerInputModule()
		{
		}

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		public const int kMouseLeftId = -1;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		public const int kMouseRightId = -2;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		public const int kMouseMiddleId = -3;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		public const int kFakeTouchesId = -4;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x58")]
		protected Dictionary<int, PointerEventData> m_PointerData;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x60")]
		private readonly PointerInputModule.MouseState m_MouseState;

		// Token: 0x020000CE RID: 206
		[Token(Token = "0x20000CE")]
		protected class ButtonState
		{
			// Token: 0x170001FB RID: 507
			// (get) Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600076D RID: 1901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170001FB")]
			public PointerInputModule.MouseButtonEventData eventData
			{
				[Token(Token = "0x600076C")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
				[Token(Token = "0x600076D")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				set
				{
				}
			}

			// Token: 0x170001FC RID: 508
			// (get) Token: 0x0600076E RID: 1902 RVA: 0x00004E48 File Offset: 0x00003048
			// (set) Token: 0x0600076F RID: 1903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170001FC")]
			public PointerEventData.InputButton button
			{
				[Token(Token = "0x600076E")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				get
				{
					return PointerEventData.InputButton.Left;
				}
				[Token(Token = "0x600076F")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				set
				{
				}
			}

			// Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ButtonState()
			{
			}

			// Token: 0x0400037B RID: 891
			[Token(Token = "0x400037B")]
			[FieldOffset(Offset = "0x10")]
			private PointerEventData.InputButton m_Button;

			// Token: 0x0400037C RID: 892
			[Token(Token = "0x400037C")]
			[FieldOffset(Offset = "0x18")]
			private PointerInputModule.MouseButtonEventData m_EventData;
		}

		// Token: 0x020000CF RID: 207
		[Token(Token = "0x20000CF")]
		protected class MouseState
		{
			// Token: 0x06000771 RID: 1905 RVA: 0x00004E60 File Offset: 0x00003060
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x5B8A090", Offset = "0x5B88C90", VA = "0x185B8A090")]
			public bool AnyPressesThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06000772 RID: 1906 RVA: 0x00004E78 File Offset: 0x00003078
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x5B8A150", Offset = "0x5B88D50", VA = "0x185B8A150")]
			public bool AnyReleasesThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06000773 RID: 1907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x5B8A210", Offset = "0x5B88E10", VA = "0x185B8A210")]
			public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				return null;
			}

			// Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x5B8A370", Offset = "0x5B88F70", VA = "0x185B8A370")]
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
			}

			// Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x5B8A3D0", Offset = "0x5B88FD0", VA = "0x185B8A3D0")]
			public MouseState()
			{
			}

			// Token: 0x0400037D RID: 893
			[Token(Token = "0x400037D")]
			[FieldOffset(Offset = "0x10")]
			private List<PointerInputModule.ButtonState> m_TrackedButtons;
		}

		// Token: 0x020000D0 RID: 208
		[Token(Token = "0x20000D0")]
		public class MouseButtonEventData
		{
			// Token: 0x06000776 RID: 1910 RVA: 0x00004E90 File Offset: 0x00003090
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x5B8A060", Offset = "0x5B88C60", VA = "0x185B8A060")]
			public bool PressedThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06000777 RID: 1911 RVA: 0x00004EA8 File Offset: 0x000030A8
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x5B8A080", Offset = "0x5B88C80", VA = "0x185B8A080")]
			public bool ReleasedThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MouseButtonEventData()
			{
			}

			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			[FieldOffset(Offset = "0x10")]
			public PointerEventData.FramePressState buttonState;

			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			[FieldOffset(Offset = "0x18")]
			public PointerEventData buttonData;
		}
	}
}
