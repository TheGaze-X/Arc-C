using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.Oculus.Input
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[InputControlLayout(displayName = "GearVR Controller", commonUsages = new string[]
	{
		"LeftHand",
		"RightHand"
	}, hideInUI = true)]
	public class GearVRTrackedController : XRController
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		[InputControl]
		public Vector2Control touchpad
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		[InputControl]
		public AxisControl trigger
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		[InputControl]
		public ButtonControl back
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		[InputControl]
		public ButtonControl triggerPressed
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		[InputControl]
		public ButtonControl touchpadClicked
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		[InputControl]
		public ButtonControl touchpadTouched
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAcceleration
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularAcceleration
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x55CD670", Offset = "0x55CC270", VA = "0x1855CD670", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public GearVRTrackedController()
		{
		}
	}
}
