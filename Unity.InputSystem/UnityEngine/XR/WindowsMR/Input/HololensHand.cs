using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace UnityEngine.XR.WindowsMR.Input
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[InputControlLayout(displayName = "HoloLens Hand", commonUsages = new string[]
	{
		"LeftHand",
		"RightHand"
	}, hideInUI = true)]
	public class HololensHand : XRController
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		[InputControl(noisy = true, aliases = new string[]
		{
			"gripVelocity"
		})]
		public Vector3Control deviceVelocity
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		[InputControl(aliases = new string[]
		{
			"triggerbutton"
		})]
		public ButtonControl airTap
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		[InputControl(noisy = true)]
		public AxisControl sourceLossRisk
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		[InputControl(noisy = true)]
		public Vector3Control sourceLossMitigationDirection
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x55CDA80", Offset = "0x55CC680", VA = "0x1855CDA80", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public HololensHand()
		{
		}
	}
}
