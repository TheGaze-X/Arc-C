using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	[InputControlLayout(displayName = "Tracked Device", isGenericTypeOfDevice = true)]
	public class TrackedDevice : InputDevice
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000294")]
		[InputControl(synthetic = true)]
		public IntegerControl trackingState
		{
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000295")]
		[InputControl(synthetic = true)]
		public ButtonControl isTracked
		{
			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x1692AD0", Offset = "0x16916D0", VA = "0x181692AD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000296")]
		[InputControl(noisy = true, dontReset = true)]
		public Vector3Control devicePosition
		{
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x55DCFF0", Offset = "0x55DBBF0", VA = "0x1855DCFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x4E84950", Offset = "0x4E83550", VA = "0x184E84950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000297")]
		[InputControl(noisy = true, dontReset = true)]
		public QuaternionControl deviceRotation
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x560D480", Offset = "0x560C080", VA = "0x18560D480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x560D490", Offset = "0x560C090", VA = "0x18560D490")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x569BCE0", Offset = "0x569A8E0", VA = "0x18569BCE0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public TrackedDevice()
		{
		}
	}
}
