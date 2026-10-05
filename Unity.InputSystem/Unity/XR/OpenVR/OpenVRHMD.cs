using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.OpenVR
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[InputControlLayout(displayName = "OpenVR Headset", hideInUI = true)]
	public class OpenVRHMD : XRHMD
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		[InputControl(noisy = true)]
		public Vector3Control leftEyeVelocity
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		[InputControl(noisy = true)]
		public Vector3Control leftEyeAngularVelocity
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x55CD290", Offset = "0x55CBE90", VA = "0x1855CD290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		[InputControl(noisy = true)]
		public Vector3Control rightEyeVelocity
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x55CD210", Offset = "0x55CBE10", VA = "0x1855CD210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x55CD280", Offset = "0x55CBE80", VA = "0x1855CD280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		[InputControl(noisy = true)]
		public Vector3Control rightEyeAngularVelocity
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x55DCE50", Offset = "0x55DBA50", VA = "0x1855DCE50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x55DCEB0", Offset = "0x55DBAB0", VA = "0x1855DCEB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		[InputControl(noisy = true)]
		public Vector3Control centerEyeVelocity
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x55DCE60", Offset = "0x55DBA60", VA = "0x1855DCE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x55DCEC0", Offset = "0x55DBAC0", VA = "0x1855DCEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		[InputControl(noisy = true)]
		public Vector3Control centerEyeAngularVelocity
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x55DCE80", Offset = "0x55DBA80", VA = "0x1855DCE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x55DCEF0", Offset = "0x55DBAF0", VA = "0x1855DCEF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x55DD730", Offset = "0x55DC330", VA = "0x1855DD730", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x55CD1F0", Offset = "0x55CBDF0", VA = "0x1855CD1F0")]
		public OpenVRHMD()
		{
		}
	}
}
