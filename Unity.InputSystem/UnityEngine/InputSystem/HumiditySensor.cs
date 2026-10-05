using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[InputControlLayout(displayName = "Humidity")]
	public class HumiditySensor : Sensor
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028A")]
		[InputControl(displayName = "Relative Humidity", noisy = true)]
		public AxisControl relativeHumidity
		{
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028B")]
		public static HumiditySensor current
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x5688690", Offset = "0x5687290", VA = "0x185688690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x56886D0", Offset = "0x56872D0", VA = "0x1856886D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x56885A0", Offset = "0x56871A0", VA = "0x1856885A0", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x5688600", Offset = "0x5687200", VA = "0x185688600", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x5688530", Offset = "0x5687130", VA = "0x185688530", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public HumiditySensor()
		{
		}
	}
}
