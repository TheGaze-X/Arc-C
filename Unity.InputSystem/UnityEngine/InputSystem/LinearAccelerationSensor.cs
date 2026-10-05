using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	[InputControlLayout(stateType = typeof(LinearAccelerationState), displayName = "Linear Acceleration")]
	public class LinearAccelerationSensor : Sensor
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000280")]
		public Vector3Control acceleration
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000281")]
		public static LinearAccelerationSensor current
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x5697780", Offset = "0x5696380", VA = "0x185697780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x56977C0", Offset = "0x56963C0", VA = "0x1856977C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x5697690", Offset = "0x5696290", VA = "0x185697690", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x56976F0", Offset = "0x56962F0", VA = "0x1856976F0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x5697620", Offset = "0x5696220", VA = "0x185697620", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public LinearAccelerationSensor()
		{
		}
	}
}
