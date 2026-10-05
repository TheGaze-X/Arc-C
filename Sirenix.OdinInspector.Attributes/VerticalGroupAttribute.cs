using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public class VerticalGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4E17B10", Offset = "0x4E16710", VA = "0x184E17B10")]
		public VerticalGroupAttribute(string groupId, float order = 0f)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x4E1C700", Offset = "0x4E1B300", VA = "0x184E1C700")]
		public VerticalGroupAttribute(float order = 0f)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4E1C650", Offset = "0x4E1B250", VA = "0x184E1C650", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x38")]
		public float PaddingTop;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x3C")]
		public float PaddingBottom;
	}
}
