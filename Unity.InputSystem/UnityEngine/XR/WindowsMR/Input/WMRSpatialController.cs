using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace UnityEngine.XR.WindowsMR.Input
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[InputControlLayout(displayName = "Windows MR Controller", commonUsages = new string[]
	{
		"LeftHand",
		"RightHand"
	}, hideInUI = true)]
	public class WMRSpatialController : XRControllerWithRumble
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006E")]
		[InputControl(aliases = new string[]
		{
			"Primary2DAxis",
			"thumbstickaxes"
		})]
		public Vector2Control joystick
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006F")]
		[InputControl(aliases = new string[]
		{
			"Secondary2DAxis",
			"touchpadaxes"
		})]
		public Vector2Control touchpad
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		[InputControl(aliases = new string[]
		{
			"gripaxis"
		})]
		public AxisControl grip
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000071")]
		[InputControl(aliases = new string[]
		{
			"gripbutton"
		})]
		public ButtonControl gripPressed
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		[InputControl(aliases = new string[]
		{
			"Primary",
			"menubutton"
		})]
		public ButtonControl menu
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		[InputControl(aliases = new string[]
		{
			"triggeraxis"
		})]
		public AxisControl trigger
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		[InputControl(aliases = new string[]
		{
			"triggerbutton"
		})]
		public ButtonControl triggerPressed
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000075")]
		[InputControl(aliases = new string[]
		{
			"thumbstickpressed"
		})]
		public ButtonControl joystickClicked
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		[InputControl(aliases = new string[]
		{
			"joystickorpadpressed",
			"touchpadpressed"
		})]
		public ButtonControl touchpadClicked
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		[InputControl(aliases = new string[]
		{
			"joystickorpadtouched",
			"touchpadtouched"
		})]
		public ButtonControl touchpadTouched
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x55CD290", Offset = "0x55CBE90", VA = "0x1855CD290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000078")]
		[InputControl(noisy = true, aliases = new string[]
		{
			"gripVelocity"
		})]
		public Vector3Control deviceVelocity
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x55CD210", Offset = "0x55CBE10", VA = "0x1855CD210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x55CD280", Offset = "0x55CBE80", VA = "0x1855CD280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		[InputControl(noisy = true, aliases = new string[]
		{
			"gripAngularVelocity"
		})]
		public Vector3Control deviceAngularVelocity
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x55DCE50", Offset = "0x55DBA50", VA = "0x1855DCE50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x55DCEB0", Offset = "0x55DBAB0", VA = "0x1855DCEB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		[InputControl(noisy = true)]
		public AxisControl batteryLevel
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x55DCE60", Offset = "0x55DBA60", VA = "0x1855DCE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x55DCEC0", Offset = "0x55DBAC0", VA = "0x1855DCEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		[InputControl(noisy = true)]
		public AxisControl sourceLossRisk
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x55DCE80", Offset = "0x55DBA80", VA = "0x1855DCE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x55DCEF0", Offset = "0x55DBAF0", VA = "0x1855DCEF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007C")]
		[InputControl(noisy = true)]
		public Vector3Control sourceLossMitigationDirection
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x50B83F0", Offset = "0x50B6FF0", VA = "0x1850B83F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x55DCED0", Offset = "0x55DBAD0", VA = "0x1855DCED0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		[InputControl(noisy = true)]
		public Vector3Control pointerPosition
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x55DCE70", Offset = "0x55DBA70", VA = "0x1855DCE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x55DCEE0", Offset = "0x55DBAE0", VA = "0x1855DCEE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		[InputControl(noisy = true, aliases = new string[]
		{
			"PointerOrientation"
		})]
		public QuaternionControl pointerRotation
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x55DCE40", Offset = "0x55DBA40", VA = "0x1855DCE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x55DCEA0", Offset = "0x55DBAA0", VA = "0x1855DCEA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x55E4A70", Offset = "0x55E3670", VA = "0x1855E4A70", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public WMRSpatialController()
		{
		}
	}
}
