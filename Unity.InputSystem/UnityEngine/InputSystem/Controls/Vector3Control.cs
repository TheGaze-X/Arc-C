using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x02000220 RID: 544
	[Token(Token = "0x2000220")]
	public class Vector3Control : InputControl<Vector3>
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AA")]
		[InputControl(offset = 0U, displayName = "X")]
		public AxisControl x
		{
			[Token(Token = "0x60013E3")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013E4")]
			[Address(RVA = "0x4FAD760", Offset = "0x4FAC360", VA = "0x184FAD760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AB")]
		[InputControl(offset = 4U, displayName = "Y")]
		public AxisControl y
		{
			[Token(Token = "0x60013E5")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013E6")]
			[Address(RVA = "0x1692BB0", Offset = "0x16917B0", VA = "0x181692BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005AC")]
		[InputControl(offset = 8U, displayName = "Z")]
		public AxisControl z
		{
			[Token(Token = "0x60013E7")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013E8")]
			[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x560EAD0", Offset = "0x560D6D0", VA = "0x18560EAD0")]
		public Vector3Control()
		{
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x560E760", Offset = "0x560D360", VA = "0x18560E760", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x560E850", Offset = "0x560D450", VA = "0x18560E850", Slot = "17")]
		public unsafe override Vector3 ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Vector3);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x560E980", Offset = "0x560D580", VA = "0x18560E980", Slot = "18")]
		public unsafe override void WriteValueIntoState(Vector3 value, void* statePtr)
		{
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x560E690", Offset = "0x560D290", VA = "0x18560E690", Slot = "6")]
		public unsafe override float EvaluateMagnitude(void* statePtr)
		{
			return 0f;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x560E490", Offset = "0x560D090", VA = "0x18560E490", Slot = "15")]
		protected override FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}
	}
}
