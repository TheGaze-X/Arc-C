using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	[Serializable]
	public class ArgumentVariable
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00002BF4 File Offset: 0x00000DF4
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000053")]
		public ArgumentType ArgumentType
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return ArgumentType.None;
			}
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x4A5BF80", Offset = "0x4A5AB80", VA = "0x184A5BF80")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x17000054")]
		public bool IsNone
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x5C250E0", Offset = "0x5C23CE0", VA = "0x185C250E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x5C24E70", Offset = "0x5C23A70", VA = "0x185C24E70")]
		public object GetValue()
		{
			return null;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x5C24D30", Offset = "0x5C23930", VA = "0x185C24D30")]
		public static string GetPropertyValuePath(ArgumentType argumentType)
		{
			return null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x5C25000", Offset = "0x5C23C00", VA = "0x185C25000")]
		public ArgumentVariable()
		{
		}

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_BoolValue;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int m_IntValue;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_FloatValue;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_StringValue;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 m_Vector2Value;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 m_Vector3Value;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Color m_ColorValue;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEngine.Object m_ObjectValue;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ArgumentType m_ArgumentType;
	}
}
