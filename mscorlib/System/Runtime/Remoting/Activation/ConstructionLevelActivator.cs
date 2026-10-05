using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	[System.Serializable]
	internal class ConstructionLevelActivator : IActivator
	{
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700038A")]
		public IActivator NextActivator
		{
			[Token(Token = "0x6001E06")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x4B781F0", Offset = "0x4B76DF0", VA = "0x184B781F0", Slot = "5")]
		public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			return null;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ConstructionLevelActivator()
		{
		}
	}
}
