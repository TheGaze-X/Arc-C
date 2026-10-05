using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	[InputControlLayout(stateType = typeof(AttitudeState), displayName = "Attitude")]
	public class AttitudeSensor : Sensor
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027E")]
		public QuaternionControl attitude
		{
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027F")]
		public static AttitudeSensor current
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x5681680", Offset = "0x5680280", VA = "0x185681680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x56816C0", Offset = "0x56802C0", VA = "0x1856816C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x5681590", Offset = "0x5680190", VA = "0x185681590", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x56815F0", Offset = "0x56801F0", VA = "0x1856815F0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x5681520", Offset = "0x5680120", VA = "0x185681520", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public AttitudeSensor()
		{
		}
	}
}
