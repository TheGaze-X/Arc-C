using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	[InputControlLayout(stateType = typeof(AccelerometerState))]
	public class Accelerometer : Sensor
	{
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000278")]
		public Vector3Control acceleration
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000279")]
		public static Accelerometer current
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x5681280", Offset = "0x567FE80", VA = "0x185681280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x56812C0", Offset = "0x567FEC0", VA = "0x1856812C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x5681190", Offset = "0x567FD90", VA = "0x185681190", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x56811F0", Offset = "0x567FDF0", VA = "0x1856811F0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x5681120", Offset = "0x567FD20", VA = "0x185681120", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public Accelerometer()
		{
		}
	}
}
