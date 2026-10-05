using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000272 RID: 626
	[Token(Token = "0x2000272")]
	public abstract class TypedUxmlAttributeDescription<T> : UxmlAttributeDescription
	{
		// Token: 0x06001187 RID: 4487
		[Token(Token = "0x6001187")]
		public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000472")]
		public T defaultValue
		{
			[Token(Token = "0x6001188")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001189")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118A")]
		protected TypedUxmlAttributeDescription()
		{
		}
	}
}
