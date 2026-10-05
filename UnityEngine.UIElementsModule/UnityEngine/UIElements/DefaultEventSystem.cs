using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	internal class DefaultEventSystem
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000017")]
		private bool isAppFocused
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x56F6B20", Offset = "0x56F5720", VA = "0x1856F6B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000018")]
		internal DefaultEventSystem.IInput input
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x5A2B490", Offset = "0x5A2A090", VA = "0x185A2B490")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x5A29C60", Offset = "0x5A28860", VA = "0x185A29C60")]
		private DefaultEventSystem.IInput GetDefaultInput()
		{
			return null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x5A2AF20", Offset = "0x5A29B20", VA = "0x185A2AF20")]
		private bool ShouldIgnoreEventsOnAppNotFocused()
		{
			return default(bool);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public BaseRuntimePanel focusedPanel
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x5A2B4D0", Offset = "0x5A2A0D0", VA = "0x185A2B4D0")]
			set
			{
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x5A2B230", Offset = "0x5A29E30", VA = "0x185A2B230")]
		public void Update(DefaultEventSystem.UpdateMode updateMode = DefaultEventSystem.UpdateMode.Always)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x5A2A600", Offset = "0x5A29200", VA = "0x185A2A600")]
		private void SendIMGUIEvents()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x5A2ABB0", Offset = "0x5A297B0", VA = "0x185A2ABB0")]
		private void SendInputEvents()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		internal void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		private void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, int? targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x5A2B160", Offset = "0x5A29D60", VA = "0x185A2B160")]
		private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x5A29F50", Offset = "0x5A28B50", VA = "0x185A29F50")]
		private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers)
		{
			return null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5A2A060", Offset = "0x5A28C60", VA = "0x185A2A060")]
		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x5A29D60", Offset = "0x5A28960", VA = "0x185A29D60")]
		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x5A2AF40", Offset = "0x5A29B40", VA = "0x185A2AF40")]
		private bool ShouldSendMoveFromInput()
		{
			return default(bool);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x5A29D40", Offset = "0x5A28940", VA = "0x185A29D40")]
		private static Vector2 GetLocalScreenPosition(Event evt, out int? targetDisplay)
		{
			return default(Vector2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x5A2B370", Offset = "0x5A29F70", VA = "0x185A2B370")]
		public DefaultEventSystem()
		{
		}

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x0")]
		internal static Func<bool> IsEditorRemoteConnected;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x10")]
		private DefaultEventSystem.IInput m_Input;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x18")]
		private readonly string m_HorizontalAxis;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x20")]
		private readonly string m_VerticalAxis;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x28")]
		private readonly string m_SubmitButton;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x30")]
		private readonly string m_CancelButton;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x38")]
		private readonly float m_InputActionsPerSecond;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x3C")]
		private readonly float m_RepeatDelay;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x40")]
		private bool m_SendingTouchEvents;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x48")]
		private Event m_Event;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x50")]
		private BaseRuntimePanel m_FocusedPanel;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x58")]
		private int m_ConsecutiveMoveCount;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x5C")]
		private Vector2 m_LastMoveVector;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x64")]
		private float m_PrevActionTime;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		public enum UpdateMode
		{
			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			Always,
			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			IgnoreIfAppNotFocused
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		internal interface IInput
		{
			// Token: 0x06000092 RID: 146
			[Token(Token = "0x6000092")]
			bool GetButtonDown(string button);

			// Token: 0x06000093 RID: 147
			[Token(Token = "0x6000093")]
			float GetAxisRaw(string axis);

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000094 RID: 148
			[Token(Token = "0x1700001A")]
			int touchCount { [Token(Token = "0x6000094")] get; }

			// Token: 0x06000095 RID: 149
			[Token(Token = "0x6000095")]
			Touch GetTouch(int index);

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000096 RID: 150
			[Token(Token = "0x1700001B")]
			bool mousePresent { [Token(Token = "0x6000096")] get; }
		}

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		private class Input : DefaultEventSystem.IInput
		{
			// Token: 0x06000097 RID: 151 RVA: 0x00002388 File Offset: 0x00000588
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x5A36380", Offset = "0x5A34F80", VA = "0x185A36380", Slot = "4")]
			public bool GetButtonDown(string button)
			{
				return default(bool);
			}

			// Token: 0x06000098 RID: 152 RVA: 0x000023A0 File Offset: 0x000005A0
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x5A36370", Offset = "0x5A34F70", VA = "0x185A36370", Slot = "5")]
			public float GetAxisRaw(string axis)
			{
				return 0f;
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000099 RID: 153 RVA: 0x000023B8 File Offset: 0x000005B8
			[Token(Token = "0x1700001C")]
			public int touchCount
			{
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x5A363F0", Offset = "0x5A34FF0", VA = "0x185A363F0", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600009A RID: 154 RVA: 0x000023D0 File Offset: 0x000005D0
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x5A36390", Offset = "0x5A34F90", VA = "0x185A36390", Slot = "7")]
			public Touch GetTouch(int index)
			{
				return default(Touch);
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x0600009B RID: 155 RVA: 0x000023E8 File Offset: 0x000005E8
			[Token(Token = "0x1700001D")]
			public bool mousePresent
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x5A363E0", Offset = "0x5A34FE0", VA = "0x185A363E0", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}
		}

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200001A")]
		private class NoInput : DefaultEventSystem.IInput
		{
			// Token: 0x0600009D RID: 157 RVA: 0x00002400 File Offset: 0x00000600
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			public bool GetButtonDown(string button)
			{
				return default(bool);
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00002418 File Offset: 0x00000618
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "5")]
			public float GetAxisRaw(string axis)
			{
				return 0f;
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600009F RID: 159 RVA: 0x00002430 File Offset: 0x00000630
			[Token(Token = "0x1700001E")]
			public int touchCount
			{
				[Token(Token = "0x600009F")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00002448 File Offset: 0x00000648
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x5A37CA0", Offset = "0x5A368A0", VA = "0x185A37CA0", Slot = "7")]
			public Touch GetTouch(int index)
			{
				return default(Touch);
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002460 File Offset: 0x00000660
			[Token(Token = "0x1700001F")]
			public bool mousePresent
			{
				[Token(Token = "0x60000A1")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NoInput()
			{
			}
		}
	}
}
