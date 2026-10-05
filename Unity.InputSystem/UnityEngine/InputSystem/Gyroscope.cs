using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	[InputControlLayout(stateType = typeof(GyroscopeState))]
	public class Gyroscope : Sensor
	{
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027A")]
		public Vector3Control angularVelocity
		{
			[Token(Token = "0x6000993")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027B")]
		public static Gyroscope current
		{
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x5688490", Offset = "0x5687090", VA = "0x185688490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x56884D0", Offset = "0x56870D0", VA = "0x1856884D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x56883A0", Offset = "0x5686FA0", VA = "0x1856883A0", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x5688400", Offset = "0x5687000", VA = "0x185688400", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x5688330", Offset = "0x5686F30", VA = "0x185688330", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public Gyroscope()
		{
		}
	}
}
