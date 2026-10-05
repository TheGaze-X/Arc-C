using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x0200021F RID: 543
	[Token(Token = "0x200021F")]
	public class Vector2Control : InputControl<Vector2>
	{
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A8")]
		[InputControl(offset = 0U, displayName = "X")]
		public AxisControl x
		{
			[Token(Token = "0x60013D9")]
			[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013DA")]
			[Address(RVA = "0x22F8A30", Offset = "0x22F7630", VA = "0x1822F8A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A9")]
		[InputControl(offset = 4U, displayName = "Y")]
		public AxisControl y
		{
			[Token(Token = "0x60013DB")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013DC")]
			[Address(RVA = "0x4FAD760", Offset = "0x4FAC360", VA = "0x184FAD760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x560E3B0", Offset = "0x560CFB0", VA = "0x18560E3B0")]
		public Vector2Control()
		{
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DE")]
		[Address(RVA = "0x560E110", Offset = "0x560CD10", VA = "0x18560E110", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x560E1C0", Offset = "0x560CDC0", VA = "0x18560E1C0", Slot = "17")]
		public unsafe override Vector2 ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Vector2);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x560E2A0", Offset = "0x560CEA0", VA = "0x18560E2A0", Slot = "18")]
		public unsafe override void WriteValueIntoState(Vector2 value, void* statePtr)
		{
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x560E040", Offset = "0x560CC40", VA = "0x18560E040", Slot = "6")]
		public unsafe override float EvaluateMagnitude(void* statePtr)
		{
			return 0f;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x560DEC0", Offset = "0x560CAC0", VA = "0x18560DEC0", Slot = "15")]
		protected override FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}
	}
}
