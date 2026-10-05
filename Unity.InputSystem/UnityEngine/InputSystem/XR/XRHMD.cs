using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[InputControlLayout(isGenericTypeOfDevice = true, displayName = "XR HMD", canRunInBackground = true)]
	public class XRHMD : TrackedDevice
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000305")]
		[InputControl(noisy = true)]
		public Vector3Control leftEyePosition
		{
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000306")]
		[InputControl(noisy = true)]
		public QuaternionControl leftEyeRotation
		{
			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000307")]
		[InputControl(noisy = true)]
		public Vector3Control rightEyePosition
		{
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000308")]
		[InputControl(noisy = true)]
		public QuaternionControl rightEyeRotation
		{
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000309")]
		[InputControl(noisy = true)]
		public Vector3Control centerEyePosition
		{
			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030A")]
		[InputControl(noisy = true)]
		public QuaternionControl centerEyeRotation
		{
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x56B5710", Offset = "0x56B4310", VA = "0x1856B5710", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x55CDA70", Offset = "0x55CC670", VA = "0x1855CDA70")]
		public XRHMD()
		{
		}
	}
}
