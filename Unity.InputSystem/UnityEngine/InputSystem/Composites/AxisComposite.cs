using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	[DisplayStringFormat("{negative}/{positive}")]
	[DisplayName("Positive/Negative Binding")]
	public class AxisComposite : InputBindingComposite<float>
	{
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x170005EC")]
		public float midPoint
		{
			[Token(Token = "0x6001624")]
			[Address(RVA = "0x560EE70", Offset = "0x560DA70", VA = "0x18560EE70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x560ECD0", Offset = "0x560D8D0", VA = "0x18560ECD0", Slot = "10")]
		public override float ReadValue(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x560EC20", Offset = "0x560D820", VA = "0x18560EC20", Slot = "8")]
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x560EE20", Offset = "0x560DA20", VA = "0x18560EE20")]
		public AxisComposite()
		{
		}

		// Token: 0x04000C80 RID: 3200
		[Token(Token = "0x4000C80")]
		[FieldOffset(Offset = "0x10")]
		[InputControl(layout = "Axis")]
		public int negative;

		// Token: 0x04000C81 RID: 3201
		[Token(Token = "0x4000C81")]
		[FieldOffset(Offset = "0x14")]
		[InputControl(layout = "Axis")]
		public int positive;

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Value to return when the negative side is fully actuated.")]
		public float minValue;

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("Value to return when the positive side is fully actuated.")]
		public float maxValue;

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("If both the positive and negative side are actuated, decides what value to return. 'Neither' (default) means that the resulting value is the midpoint between min and max. 'Positive' means that max will be returned. 'Negative' means that min will be returned.")]
		public AxisComposite.WhichSideWins whichSideWins;

		// Token: 0x02000266 RID: 614
		[Token(Token = "0x2000266")]
		public enum WhichSideWins
		{
			// Token: 0x04000C86 RID: 3206
			[Token(Token = "0x4000C86")]
			Neither,
			// Token: 0x04000C87 RID: 3207
			[Token(Token = "0x4000C87")]
			Positive,
			// Token: 0x04000C88 RID: 3208
			[Token(Token = "0x4000C88")]
			Negative
		}
	}
}
