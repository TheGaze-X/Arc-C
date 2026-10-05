using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.OpenVR
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[InputControlLayout(displayName = "Oculus Touch Controller (OpenVR)", commonUsages = new string[]
	{
		"LeftHand",
		"RightHand"
	}, hideInUI = true)]
	public class OpenVROculusTouchController : XRControllerWithRumble
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		[InputControl]
		public Vector2Control thumbstick
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		[InputControl]
		public AxisControl trigger
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		[InputControl]
		public AxisControl grip
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		[InputControl(aliases = new string[]
		{
			"Alternate"
		})]
		public ButtonControl primaryButton
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		[InputControl(aliases = new string[]
		{
			"Primary"
		})]
		public ButtonControl secondaryButton
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		[InputControl]
		public ButtonControl gripPressed
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		[InputControl]
		public ButtonControl triggerPressed
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		[InputControl(aliases = new string[]
		{
			"primary2DAxisClicked"
		})]
		public ButtonControl thumbstickClicked
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		[InputControl(aliases = new string[]
		{
			"primary2DAxisTouch"
		})]
		public ButtonControl thumbstickTouched
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x55CD290", Offset = "0x55CBE90", VA = "0x1855CD290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x55CD210", Offset = "0x55CBE10", VA = "0x1855CD210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x55CD280", Offset = "0x55CBE80", VA = "0x1855CD280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x55DD910", Offset = "0x55DC510", VA = "0x1855DD910", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public OpenVROculusTouchController()
		{
		}
	}
}
