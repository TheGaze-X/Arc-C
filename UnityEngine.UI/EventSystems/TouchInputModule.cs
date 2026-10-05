using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[AddComponentMenu("Event/Touch Input Module")]
	[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
	public class TouchInputModule : PointerInputModule
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x5B97D20", Offset = "0x5B96920", VA = "0x185B97D20")]
		protected TouchInputModule()
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000206")]
		[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnStandalone
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x1B5F4F0", Offset = "0x1B5E0F0", VA = "0x181B5F4F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x332AEF0", Offset = "0x3329AF0", VA = "0x18332AEF0")]
			set
			{
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00005010 File Offset: 0x00003210
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000207")]
		public bool forceModuleActive
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1B5F4F0", Offset = "0x1B5E0F0", VA = "0x181B5F4F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x332AEF0", Offset = "0x3329AF0", VA = "0x18332AEF0")]
			set
			{
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x5B97B50", Offset = "0x5B96750", VA = "0x185B97B50", Slot = "25")]
		public override void UpdateModule()
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x5B966C0", Offset = "0x5B952C0", VA = "0x185B966C0", Slot = "26")]
		public override bool IsModuleSupported()
		{
			return default(bool);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x5B97720", Offset = "0x5B96320", VA = "0x185B97720", Slot = "22")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x5B97CD0", Offset = "0x5B968D0", VA = "0x185B97CD0")]
		private bool UseFakeInput()
		{
			return default(bool);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x5B976A0", Offset = "0x5B962A0", VA = "0x185B976A0", Slot = "17")]
		public override void Process()
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x5B96500", Offset = "0x5B95100", VA = "0x185B96500")]
		private void FakeTouches()
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x5B96720", Offset = "0x5B95320", VA = "0x185B96720")]
		private void ProcessTouchEvents()
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x5B96FC0", Offset = "0x5B95BC0", VA = "0x185B96FC0")]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x5B93A70", Offset = "0x5B92670", VA = "0x185B93A70", Slot = "23")]
		public override void DeactivateModule()
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x5B97860", Offset = "0x5B96460", VA = "0x185B97860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_LastMousePosition;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 m_MousePosition;

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x78")]
		private PointerEventData m_InputPointerEvent;

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x80")]
		[FormerlySerializedAs("m_AllowActivationOnStandalone")]
		[SerializeField]
		private bool m_ForceModuleActive;
	}
}
