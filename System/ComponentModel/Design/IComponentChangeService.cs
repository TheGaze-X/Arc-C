using System;
using Il2CppDummyDll;

namespace System.ComponentModel.Design
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	public interface IComponentChangeService
	{
		// Token: 0x06000F7A RID: 3962
		[Token(Token = "0x6000F7A")]
		void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

		// Token: 0x06000F7B RID: 3963
		[Token(Token = "0x6000F7B")]
		void OnComponentChanging(object component, MemberDescriptor member);
	}
}
