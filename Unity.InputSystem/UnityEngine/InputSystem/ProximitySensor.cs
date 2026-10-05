using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	[InputControlLayout(displayName = "Proximity")]
	public class ProximitySensor : Sensor
	{
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000288")]
		[InputControl(displayName = "Distance", noisy = true)]
		public AxisControl distance
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000289")]
		public static ProximitySensor current
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x5698E00", Offset = "0x5697A00", VA = "0x185698E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x5698E40", Offset = "0x5697A40", VA = "0x185698E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x5698D10", Offset = "0x5697910", VA = "0x185698D10", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x5698D70", Offset = "0x5697970", VA = "0x185698D70", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x5698CA0", Offset = "0x56978A0", VA = "0x185698CA0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public ProximitySensor()
		{
		}
	}
}
