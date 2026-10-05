using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	[AddComponentMenu("Event/Standalone Input Module")]
	public class StandaloneInputModule : PointerInputModule
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x5B96400", Offset = "0x5B95000", VA = "0x185B96400")]
		protected StandaloneInputModule()
		{
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x170001FD")]
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public StandaloneInputModule.InputMode inputMode
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return StandaloneInputModule.InputMode.Mouse;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00004ED8 File Offset: 0x000030D8
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001FE")]
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnMobileDevice
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x32FC480", Offset = "0x32FB080", VA = "0x1832FC480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x32FC4D0", Offset = "0x32FB0D0", VA = "0x1832FC4D0")]
			set
			{
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00004EF0 File Offset: 0x000030F0
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001FF")]
		[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
		public bool forceModuleActive
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x32FC480", Offset = "0x32FB080", VA = "0x1832FC480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x32FC4D0", Offset = "0x32FB0D0", VA = "0x1832FC4D0")]
			set
			{
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00004F08 File Offset: 0x00003108
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000200")]
		public float inputActionsPerSecond
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x150CF20", Offset = "0x150BB20", VA = "0x18150CF20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x150CF30", Offset = "0x150BB30", VA = "0x18150CF30")]
			set
			{
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00004F20 File Offset: 0x00003120
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000201")]
		public float repeatDelay
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x5B964E0", Offset = "0x5B950E0", VA = "0x185B964E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x5B964F0", Offset = "0x5B950F0", VA = "0x185B964F0")]
			set
			{
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000202")]
		public string horizontalAxis
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000784")]
			[Address(RVA = "0xF93850", Offset = "0xF92450", VA = "0x180F93850")]
			set
			{
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000203")]
		public string verticalAxis
		{
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x22F8A80", Offset = "0x22F7680", VA = "0x1822F8A80")]
			set
			{
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000204")]
		public string submitButton
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x789450", Offset = "0x788050", VA = "0x180789450")]
			set
			{
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000205")]
		public string cancelButton
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70")]
			set
			{
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default(bool);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x5B96290", Offset = "0x5B94E90", VA = "0x185B96290", Slot = "25")]
		public override void UpdateModule()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x5B95590", Offset = "0x5B94190", VA = "0x185B95590")]
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x5B95FE0", Offset = "0x5B94BE0", VA = "0x185B95FE0", Slot = "22")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x5B938D0", Offset = "0x5B924D0", VA = "0x185B938D0", Slot = "24")]
		public override void ActivateModule()
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x5B93A70", Offset = "0x5B92670", VA = "0x185B93A70", Slot = "23")]
		public override void DeactivateModule()
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x5B95380", Offset = "0x5B93F80", VA = "0x185B95380", Slot = "17")]
		public override void Process()
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x5B943B0", Offset = "0x5B92FB0", VA = "0x185B943B0")]
		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x5B94C90", Offset = "0x5B93890", VA = "0x185B94C90")]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x5B95BD0", Offset = "0x5B947D0", VA = "0x185B95BD0")]
		protected bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00004F98 File Offset: 0x00003198
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x5B93A80", Offset = "0x5B92680", VA = "0x185B93A80")]
		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x5B95950", Offset = "0x5B94550", VA = "0x185B95950")]
		protected bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x5B93F80", Offset = "0x5B92B80", VA = "0x185B93F80")]
		protected void ProcessMouseEvent()
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "32")]
		[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
		protected virtual bool ForceAutoSelect()
		{
			return default(bool);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x5B93C60", Offset = "0x5B92860", VA = "0x185B93C60")]
		protected void ProcessMouseEvent(int id)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x5B95E70", Offset = "0x5B94A70", VA = "0x185B95E70")]
		protected bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x5B93F90", Offset = "0x5B92B90", VA = "0x185B93F90")]
		protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079C")]
		[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60")]
		protected GameObject GetCurrentFocusedGameObject()
		{
			return null;
		}

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x68")]
		private float m_PrevActionTime;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x6C")]
		private Vector2 m_LastMoveVector;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x74")]
		private int m_ConsecutiveMoveCount;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_LastMousePosition;

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_MousePosition;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x88")]
		private GameObject m_CurrentFocusedGameObject;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x90")]
		private PointerEventData m_InputPointerEvent;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string m_HorizontalAxis;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string m_VerticalAxis;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string m_SubmitButton;

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string m_CancelButton;

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float m_InputActionsPerSecond;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float m_RepeatDelay;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		[SerializeField]
		private bool m_ForceModuleActive;

		// Token: 0x020000D2 RID: 210
		[Token(Token = "0x20000D2")]
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode
		{
			// Token: 0x0400038F RID: 911
			[Token(Token = "0x400038F")]
			Mouse,
			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000390")]
			Buttons
		}
	}
}
