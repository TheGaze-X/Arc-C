using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Torappu
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class TorappuInputModule : PointerInputModule
	{
		// Token: 0x06000059 RID: 89 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x54F9230", Offset = "0x54F7E30", VA = "0x1854F9230")]
		protected TorappuInputModule()
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x54F6820", Offset = "0x54F5420", VA = "0x1854F6820", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x17000002")]
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public TorappuInputModule.InputMode inputMode
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return TorappuInputModule.InputMode.Mouse;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000233C File Offset: 0x0000053C
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000003")]
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnMobileDevice
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x371A210", Offset = "0x3718E10", VA = "0x18371A210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x371A3B0", Offset = "0x3718FB0", VA = "0x18371A3B0")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002354 File Offset: 0x00000554
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000004")]
		[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
		public bool forceModuleActive
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x371A210", Offset = "0x3718E10", VA = "0x18371A210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x371A3B0", Offset = "0x3718FB0", VA = "0x18371A3B0")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000236C File Offset: 0x0000056C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000005")]
		public float inputActionsPerSecond
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x27289B0", Offset = "0x27275B0", VA = "0x1827289B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x42BB050", Offset = "0x42B9C50", VA = "0x1842BB050")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002384 File Offset: 0x00000584
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000006")]
		public float repeatDelay
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x4E48950", Offset = "0x4E47550", VA = "0x184E48950")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x4E489A0", Offset = "0x4E475A0", VA = "0x184E489A0")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000007")]
		public string horizontalAxis
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x22F8A80", Offset = "0x22F7680", VA = "0x1822F8A80")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000008")]
		public string verticalAxis
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x789450", Offset = "0x788050", VA = "0x180789450")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000009")]
		public string submitButton
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700000A")]
		public string cancelButton
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x22F8A60", Offset = "0x22F7660", VA = "0x1822F8A60")]
			set
			{
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default(bool);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x54F90C0", Offset = "0x54F7CC0", VA = "0x1854F90C0", Slot = "25")]
		public override void UpdateModule()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x54F83E0", Offset = "0x54F6FE0", VA = "0x1854F83E0")]
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x54F8E30", Offset = "0x54F7A30", VA = "0x1854F8E30", Slot = "22")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x54F6330", Offset = "0x54F4F30", VA = "0x1854F6330", Slot = "24")]
		public override void ActivateModule()
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x54F6620", Offset = "0x54F5220", VA = "0x1854F6620", Slot = "23")]
		public override void DeactivateModule()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x54F8190", Offset = "0x54F6D90", VA = "0x1854F8190", Slot = "17")]
		public override void Process()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x54F71E0", Offset = "0x54F5DE0", VA = "0x1854F71E0")]
		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x54F7AA0", Offset = "0x54F66A0", VA = "0x1854F7AA0")]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x54F8A20", Offset = "0x54F7620", VA = "0x1854F8A20")]
		protected bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x54F6640", Offset = "0x54F5240", VA = "0x1854F6640")]
		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x54F87A0", Offset = "0x54F73A0", VA = "0x1854F87A0")]
		protected bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x54F68C0", Offset = "0x54F54C0", VA = "0x1854F68C0")]
		protected void ProcessMouseEvent()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "32")]
		[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
		protected virtual bool ForceAutoSelect()
		{
			return default(bool);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x54F68D0", Offset = "0x54F54D0", VA = "0x1854F68D0")]
		protected void ProcessMouseEvent(int id)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x54F64E0", Offset = "0x54F50E0", VA = "0x1854F64E0")]
		protected bool CheckIsScroll(GameObject result)
		{
			return default(bool);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x54F8CC0", Offset = "0x54F78C0", VA = "0x1854F8CC0")]
		protected bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x54F6DC0", Offset = "0x54F59C0", VA = "0x1854F6DC0")]
		protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		protected GameObject GetCurrentFocusedGameObject()
		{
			return null;
		}

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public IPCInputHelper pcInputHelper;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x70")]
		private float m_PrevActionTime;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x74")]
		private Vector2 m_LastMoveVector;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x7C")]
		private int m_ConsecutiveMoveCount;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_LastMousePosition;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x88")]
		private Vector2 m_MousePosition;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x90")]
		private GameObject m_CurrentFocusedGameObject;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x98")]
		private PointerEventData m_InputPointerEvent;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string m_HorizontalAxis;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string m_VerticalAxis;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string m_SubmitButton;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string m_CancelButton;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float m_InputActionsPerSecond;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_RepeatDelay;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		private bool m_ForceModuleActive;

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode
		{
			// Token: 0x04000064 RID: 100
			[Token(Token = "0x4000064")]
			Mouse,
			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			Buttons
		}
	}
}
