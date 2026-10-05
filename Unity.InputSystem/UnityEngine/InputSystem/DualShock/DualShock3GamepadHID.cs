using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock.LowLevel;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.DualShock
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	[InputControlLayout(stateType = typeof(DualShock3HIDInputReport), hideInUI = true, displayName = "PS3 Controller")]
	public class DualShock3GamepadHID : DualShockGamepad
	{
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000401")]
		public ButtonControl leftTriggerButton
		{
			[Token(Token = "0x6000EF6")]
			[Address(RVA = "0x56D0E50", Offset = "0x56CFA50", VA = "0x1856D0E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EF7")]
			[Address(RVA = "0x56D0E80", Offset = "0x56CFA80", VA = "0x1856D0E80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000402")]
		public ButtonControl rightTriggerButton
		{
			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x56D0E70", Offset = "0x56CFA70", VA = "0x1856D0E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0x56D0EA0", Offset = "0x56CFAA0", VA = "0x1856D0EA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000403")]
		public ButtonControl playStationButton
		{
			[Token(Token = "0x6000EFA")]
			[Address(RVA = "0x56D0E60", Offset = "0x56CFA60", VA = "0x1856D0E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EFB")]
			[Address(RVA = "0x56D0E90", Offset = "0x56CFA90", VA = "0x1856D0E90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x56D1230", Offset = "0x56CFE30", VA = "0x1856D1230", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public DualShock3GamepadHID()
		{
		}
	}
}
