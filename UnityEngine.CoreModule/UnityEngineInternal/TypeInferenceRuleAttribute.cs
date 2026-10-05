using System;
using Il2CppDummyDll;

namespace UnityEngineInternal
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Method)]
	[Serializable]
	public class TypeInferenceRuleAttribute : Attribute
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5946A50", Offset = "0x5945650", VA = "0x185946A50")]
		public TypeInferenceRuleAttribute(TypeInferenceRules rule)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public TypeInferenceRuleAttribute(string rule)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _rule;
	}
}
