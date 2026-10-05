using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[InputControlLayout(stateType = typeof(GravityState), displayName = "Gravity")]
	public class GravitySensor : Sensor
	{
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027C")]
		public Vector3Control gravity
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027D")]
		public static GravitySensor current
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x5688290", Offset = "0x5686E90", VA = "0x185688290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x56882D0", Offset = "0x5686ED0", VA = "0x1856882D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x5688130", Offset = "0x5686D30", VA = "0x185688130", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x56881A0", Offset = "0x5686DA0", VA = "0x1856881A0", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x5688200", Offset = "0x5686E00", VA = "0x185688200", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public GravitySensor()
		{
		}
	}
}
