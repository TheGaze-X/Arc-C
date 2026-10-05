using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	[InputControlLayout(displayName = "Pressure")]
	public class PressureSensor : Sensor
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000286")]
		[InputControl(displayName = "Atmospheric Pressure", noisy = true)]
		public AxisControl atmosphericPressure
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000287")]
		public static PressureSensor current
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x5698C00", Offset = "0x5697800", VA = "0x185698C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x5698C40", Offset = "0x5697840", VA = "0x185698C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x5698B10", Offset = "0x5697710", VA = "0x185698B10", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x5698B70", Offset = "0x5697770", VA = "0x185698B70", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x5698AA0", Offset = "0x56976A0", VA = "0x185698AA0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public PressureSensor()
		{
		}
	}
}
