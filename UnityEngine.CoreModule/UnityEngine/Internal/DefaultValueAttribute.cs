using System;
using Il2CppDummyDll;

namespace UnityEngine.Internal
{
	// Token: 0x02000240 RID: 576
	[Token(Token = "0x2000240")]
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	[Serializable]
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x06000D71 RID: 3441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public DefaultValueAttribute(string value)
		{
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AA")]
		public object Value
		{
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x595A110", Offset = "0x5958D10", VA = "0x18595A110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x595A200", Offset = "0x5958E00", VA = "0x18595A200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x10")]
		private object DefaultValue;
	}
}
