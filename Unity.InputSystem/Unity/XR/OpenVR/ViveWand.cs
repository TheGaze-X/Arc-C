using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.OpenVR
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[InputControlLayout(displayName = "Vive Wand", commonUsages = new string[]
	{
		"LeftHand",
		"RightHand"
	}, hideInUI = true)]
	public class ViveWand : XRControllerWithRumble
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		[InputControl]
		public AxisControl grip
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		[InputControl]
		public ButtonControl gripPressed
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		[InputControl]
		public ButtonControl primary
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		[InputControl(aliases = new string[]
		{
			"primary2DAxisClick",
			"joystickOrPadPressed"
		})]
		public ButtonControl trackpadPressed
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		[InputControl(aliases = new string[]
		{
			"primary2DAxisTouch",
			"joystickOrPadTouched"
		})]
		public ButtonControl trackpadTouched
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		[InputControl(aliases = new string[]
		{
			"Primary2DAxis"
		})]
		public Vector2Control trackpad
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		[InputControl]
		public AxisControl trigger
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		[InputControl]
		public ButtonControl triggerPressed
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x55CD290", Offset = "0x55CBE90", VA = "0x1855CD290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x55E4790", Offset = "0x55E3390", VA = "0x1855E4790", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public ViveWand()
		{
		}
	}
}
