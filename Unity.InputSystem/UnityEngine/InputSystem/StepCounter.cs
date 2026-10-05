using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	[InputControlLayout(displayName = "Step Counter")]
	public class StepCounter : Sensor
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028E")]
		[InputControl(displayName = "Step Counter", noisy = true)]
		public IntegerControl stepCounter
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028F")]
		public static StepCounter current
		{
			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x569A140", Offset = "0x5698D40", VA = "0x18569A140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x569A180", Offset = "0x5698D80", VA = "0x18569A180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x569A050", Offset = "0x5698C50", VA = "0x18569A050", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x569A0B0", Offset = "0x5698CB0", VA = "0x18569A0B0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x5699FE0", Offset = "0x5698BE0", VA = "0x185699FE0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public StepCounter()
		{
		}
	}
}
