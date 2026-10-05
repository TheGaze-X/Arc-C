using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	[InputControlLayout(displayName = "Magnetic Field")]
	public class MagneticFieldSensor : Sensor
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000282")]
		[InputControl(displayName = "Magnetic Field", noisy = true)]
		public Vector3Control magneticField
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000283")]
		public static MagneticFieldSensor current
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x5697980", Offset = "0x5696580", VA = "0x185697980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x56979C0", Offset = "0x56965C0", VA = "0x1856979C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x5697890", Offset = "0x5696490", VA = "0x185697890", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x56978F0", Offset = "0x56964F0", VA = "0x1856978F0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x5697820", Offset = "0x5696420", VA = "0x185697820", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public MagneticFieldSensor()
		{
		}
	}
}
