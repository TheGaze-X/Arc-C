using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x0200021A RID: 538
	[Token(Token = "0x200021A")]
	public class QuaternionControl : InputControl<Quaternion>
	{
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000592")]
		[InputControl(displayName = "X")]
		public AxisControl x
		{
			[Token(Token = "0x600139C")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600139D")]
			[Address(RVA = "0x1692BB0", Offset = "0x16917B0", VA = "0x181692BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000593")]
		[InputControl(displayName = "Y")]
		public AxisControl y
		{
			[Token(Token = "0x600139E")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600139F")]
			[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000594")]
		[InputControl(displayName = "Z")]
		public AxisControl z
		{
			[Token(Token = "0x60013A0")]
			[Address(RVA = "0x4FA1B40", Offset = "0x4FA0740", VA = "0x184FA1B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013A1")]
			[Address(RVA = "0x55FB9E0", Offset = "0x55FA5E0", VA = "0x1855FB9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000595")]
		[InputControl(displayName = "W")]
		public AxisControl w
		{
			[Token(Token = "0x60013A2")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013A3")]
			[Address(RVA = "0x55FB9F0", Offset = "0x55FA5F0", VA = "0x1855FB9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x560C7B0", Offset = "0x560B3B0", VA = "0x18560C7B0")]
		public QuaternionControl()
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x560C3B0", Offset = "0x560AFB0", VA = "0x18560C3B0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x560C4D0", Offset = "0x560B0D0", VA = "0x18560C4D0", Slot = "17")]
		public unsafe override Quaternion ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Quaternion);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x560C630", Offset = "0x560B230", VA = "0x18560C630", Slot = "18")]
		public unsafe override void WriteValueIntoState(Quaternion value, void* statePtr)
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x560C0F0", Offset = "0x560ACF0", VA = "0x18560C0F0", Slot = "15")]
		protected override FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}
	}
}
