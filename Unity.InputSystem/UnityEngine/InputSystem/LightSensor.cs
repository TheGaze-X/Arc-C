using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	[InputControlLayout(displayName = "Light")]
	public class LightSensor : Sensor
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000284")]
		[InputControl(displayName = "Light Level", noisy = true)]
		public AxisControl lightLevel
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000285")]
		public static LightSensor current
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x5697580", Offset = "0x5696180", VA = "0x185697580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x56975C0", Offset = "0x56961C0", VA = "0x1856975C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x5697490", Offset = "0x5696090", VA = "0x185697490", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x56974F0", Offset = "0x56960F0", VA = "0x1856974F0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x5697420", Offset = "0x5696020", VA = "0x185697420", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public LightSensor()
		{
		}
	}
}
