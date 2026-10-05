using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.Oculus.Input
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[InputControlLayout(displayName = "Oculus Touch Controller", commonUsages = new string[]
	{
		"LeftHand",
		"RightHand"
	}, hideInUI = true)]
	public class OculusTouchController : XRControllerWithRumble
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		[InputControl(aliases = new string[]
		{
			"Primary2DAxis",
			"Joystick"
		})]
		public Vector2Control thumbstick
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003E")]
		[InputControl]
		public AxisControl trigger
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		[InputControl]
		public AxisControl grip
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		[InputControl(aliases = new string[]
		{
			"A",
			"X",
			"Alternate"
		})]
		public ButtonControl primaryButton
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		[InputControl(aliases = new string[]
		{
			"B",
			"Y",
			"Primary"
		})]
		public ButtonControl secondaryButton
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		[InputControl(aliases = new string[]
		{
			"GripButton"
		})]
		public ButtonControl gripPressed
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		[InputControl]
		public ButtonControl start
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		[InputControl(aliases = new string[]
		{
			"JoystickOrPadPressed",
			"thumbstickClick"
		})]
		public ButtonControl thumbstickClicked
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		[InputControl(aliases = new string[]
		{
			"ATouched",
			"XTouched",
			"ATouch",
			"XTouch"
		})]
		public ButtonControl primaryTouched
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		[InputControl(aliases = new string[]
		{
			"BTouched",
			"YTouched",
			"BTouch",
			"YTouch"
		})]
		public ButtonControl secondaryTouched
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x55CD290", Offset = "0x55CBE90", VA = "0x1855CD290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		[InputControl(aliases = new string[]
		{
			"indexTouch",
			"indexNearTouched"
		})]
		public AxisControl triggerTouched
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x55CD210", Offset = "0x55CBE10", VA = "0x1855CD210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x55CD280", Offset = "0x55CBE80", VA = "0x1855CD280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		[InputControl(aliases = new string[]
		{
			"indexButton",
			"indexTouched"
		})]
		public ButtonControl triggerPressed
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x55DCE50", Offset = "0x55DBA50", VA = "0x1855DCE50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x55DCEB0", Offset = "0x55DBAB0", VA = "0x1855DCEB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		[InputControl(name = "trackingState", layout = "Integer", aliases = new string[]
		{
			"controllerTrackingState"
		})]
		[InputControl(name = "isTracked", layout = "Button", aliases = new string[]
		{
			"ControllerIsTracked"
		})]
		[InputControl(name = "devicePosition", layout = "Vector3", aliases = new string[]
		{
			"controllerPosition"
		})]
		[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new string[]
		{
			"controllerRotation"
		})]
		[InputControl(aliases = new string[]
		{
			"JoystickOrPadTouched",
			"thumbstickTouch"
		})]
		public ButtonControl thumbstickTouched
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x55DCE60", Offset = "0x55DBA60", VA = "0x1855DCE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x55DCEC0", Offset = "0x55DBAC0", VA = "0x1855DCEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		[InputControl(noisy = true, aliases = new string[]
		{
			"controllerVelocity"
		})]
		public Vector3Control deviceVelocity
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x55DCE80", Offset = "0x55DBA80", VA = "0x1855DCE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x55DCEF0", Offset = "0x55DBAF0", VA = "0x1855DCEF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		[InputControl(noisy = true, aliases = new string[]
		{
			"controllerAngularVelocity"
		})]
		public Vector3Control deviceAngularVelocity
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x50B83F0", Offset = "0x50B6FF0", VA = "0x1850B83F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x55DCED0", Offset = "0x55DBAD0", VA = "0x1855DCED0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		[InputControl(noisy = true, aliases = new string[]
		{
			"controllerAcceleration"
		})]
		public Vector3Control deviceAcceleration
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x55DCE70", Offset = "0x55DBA70", VA = "0x1855DCE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x55DCEE0", Offset = "0x55DBAE0", VA = "0x1855DCEE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		[InputControl(noisy = true, aliases = new string[]
		{
			"controllerAngularAcceleration"
		})]
		public Vector3Control deviceAngularAcceleration
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x55DCE40", Offset = "0x55DBA40", VA = "0x1855DCE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x55DCEA0", Offset = "0x55DBAA0", VA = "0x1855DCEA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x55DD010", Offset = "0x55DBC10", VA = "0x1855DD010", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public OculusTouchController()
		{
		}
	}
}
