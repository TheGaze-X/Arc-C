using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	internal class AppDomainLevelActivator : IActivator
	{
		// Token: 0x06001E03 RID: 7683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public AppDomainLevelActivator(string activationUrl, IActivator next)
		{
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000389")]
		public IActivator NextActivator
		{
			[Token(Token = "0x6001E04")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x4B6E030", Offset = "0x4B6CC30", VA = "0x184B6E030", Slot = "5")]
		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			return null;
		}

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		[FieldOffset(Offset = "0x10")]
		private string _activationUrl;

		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		[FieldOffset(Offset = "0x18")]
		private IActivator _next;
	}
}
