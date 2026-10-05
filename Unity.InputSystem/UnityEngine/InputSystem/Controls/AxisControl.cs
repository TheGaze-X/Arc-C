using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x0200020E RID: 526
	[Token(Token = "0x200020E")]
	public class AxisControl : InputControl<float>
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x55F9620", Offset = "0x55F8220", VA = "0x1855F9620")]
		[MethodImpl(256)]
		protected float Preprocess(float value)
		{
			return 0f;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x6001360")]
		[Address(RVA = "0x55FA860", Offset = "0x55F9460", VA = "0x1855FA860")]
		private float Unpreprocess(float value)
		{
			return 0f;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x55FA9F0", Offset = "0x55F95F0", VA = "0x1855FA9F0")]
		public AxisControl()
		{
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001362")]
		[Address(RVA = "0x55FA6B0", Offset = "0x55F92B0", VA = "0x1855FA6B0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x55FA790", Offset = "0x55F9390", VA = "0x1855FA790", Slot = "17")]
		public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
		{
			return 0f;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x55FA8D0", Offset = "0x55F94D0", VA = "0x1855FA8D0", Slot = "18")]
		public unsafe override void WriteValueIntoState(float value, void* statePtr)
		{
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x55FA410", Offset = "0x55F9010", VA = "0x1855FA410", Slot = "12")]
		public unsafe override bool CompareValue(void* firstStatePtr, void* secondStatePtr)
		{
			return default(bool);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x6001366")]
		[Address(RVA = "0x55FA590", Offset = "0x55F9190", VA = "0x1855FA590", Slot = "6")]
		public unsafe override float EvaluateMagnitude(void* statePtr)
		{
			return 0f;
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x6001367")]
		[Address(RVA = "0x55FA4A0", Offset = "0x55F90A0", VA = "0x1855FA4A0")]
		private float EvaluateMagnitude(float value)
		{
			return 0f;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0000A368 File Offset: 0x00008568
		[Token(Token = "0x6001368")]
		[Address(RVA = "0x55FA270", Offset = "0x55F8E70", VA = "0x1855FA270", Slot = "15")]
		protected override FourCC CalculateOptimizedControlDataType()
		{
			return default(FourCC);
		}

		// Token: 0x04000B86 RID: 2950
		[Token(Token = "0x4000B86")]
		[FieldOffset(Offset = "0x108")]
		public AxisControl.Clamp clamp;

		// Token: 0x04000B87 RID: 2951
		[Token(Token = "0x4000B87")]
		[FieldOffset(Offset = "0x10C")]
		public float clampMin;

		// Token: 0x04000B88 RID: 2952
		[Token(Token = "0x4000B88")]
		[FieldOffset(Offset = "0x110")]
		public float clampMax;

		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4000B89")]
		[FieldOffset(Offset = "0x114")]
		public float clampConstant;

		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4000B8A")]
		[FieldOffset(Offset = "0x118")]
		public bool invert;

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		[FieldOffset(Offset = "0x119")]
		public bool normalize;

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x11C")]
		public float normalizeMin;

		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x120")]
		public float normalizeMax;

		// Token: 0x04000B8E RID: 2958
		[Token(Token = "0x4000B8E")]
		[FieldOffset(Offset = "0x124")]
		public float normalizeZero;

		// Token: 0x04000B8F RID: 2959
		[Token(Token = "0x4000B8F")]
		[FieldOffset(Offset = "0x128")]
		public bool scale;

		// Token: 0x04000B90 RID: 2960
		[Token(Token = "0x4000B90")]
		[FieldOffset(Offset = "0x12C")]
		public float scaleFactor;

		// Token: 0x0200020F RID: 527
		[Token(Token = "0x200020F")]
		public enum Clamp
		{
			// Token: 0x04000B92 RID: 2962
			[Token(Token = "0x4000B92")]
			None,
			// Token: 0x04000B93 RID: 2963
			[Token(Token = "0x4000B93")]
			BeforeNormalize,
			// Token: 0x04000B94 RID: 2964
			[Token(Token = "0x4000B94")]
			AfterNormalize,
			// Token: 0x04000B95 RID: 2965
			[Token(Token = "0x4000B95")]
			ToConstantBeforeNormalize
		}
	}
}
