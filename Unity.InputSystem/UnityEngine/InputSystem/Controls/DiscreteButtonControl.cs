using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Controls
{
	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	public class DiscreteButtonControl : ButtonControl
	{
		// Token: 0x06001379 RID: 4985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x55FBA00", Offset = "0x55FA600", VA = "0x1855FBA00", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x55FBB30", Offset = "0x55FA730", VA = "0x1855FBB30", Slot = "17")]
		public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
		{
			return 0f;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137B")]
		[Address(RVA = "0x55FBBF0", Offset = "0x55FA7F0", VA = "0x1855FBBF0", Slot = "18")]
		public unsafe override void WriteValueIntoState(float value, void* statePtr)
		{
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137C")]
		[Address(RVA = "0x55FBD40", Offset = "0x55FA940", VA = "0x1855FBD40")]
		public DiscreteButtonControl()
		{
		}

		// Token: 0x04000B9E RID: 2974
		[Token(Token = "0x4000B9E")]
		[FieldOffset(Offset = "0x138")]
		public int minValue;

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0x13C")]
		public int maxValue;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x140")]
		public int wrapAtValue;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x144")]
		public int nullValue;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x148")]
		public DiscreteButtonControl.WriteMode writeMode;

		// Token: 0x02000213 RID: 531
		[Token(Token = "0x2000213")]
		public enum WriteMode
		{
			// Token: 0x04000BA4 RID: 2980
			[Token(Token = "0x4000BA4")]
			WriteDisabled,
			// Token: 0x04000BA5 RID: 2981
			[Token(Token = "0x4000BA5")]
			WriteNullAndMaxValue
		}
	}
}
