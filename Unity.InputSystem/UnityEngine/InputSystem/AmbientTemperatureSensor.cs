using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	[InputControlLayout(displayName = "Ambient Temperature")]
	public class AmbientTemperatureSensor : Sensor
	{
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028C")]
		[InputControl(displayName = "Ambient Temperature", noisy = true)]
		public AxisControl ambientTemperature
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028D")]
		public static AmbientTemperatureSensor current
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x5681480", Offset = "0x5680080", VA = "0x185681480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x56814C0", Offset = "0x56800C0", VA = "0x1856814C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x5681390", Offset = "0x567FF90", VA = "0x185681390", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x56813F0", Offset = "0x567FFF0", VA = "0x1856813F0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x5681320", Offset = "0x567FF20", VA = "0x185681320", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public AmbientTemperatureSensor()
		{
		}
	}
}
