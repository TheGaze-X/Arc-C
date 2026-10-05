using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Unity.XR.OpenVR
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[InputControlLayout(displayName = "Vive Tracker")]
	public class ViveTracker : TrackedDevice
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		[InputControl(noisy = true)]
		public Vector3Control deviceVelocity
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		[InputControl(noisy = true)]
		public Vector3Control deviceAngularVelocity
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x55E46F0", Offset = "0x55E32F0", VA = "0x1855E46F0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x55CDA70", Offset = "0x55CC670", VA = "0x1855CDA70")]
		public ViveTracker()
		{
		}
	}
}
