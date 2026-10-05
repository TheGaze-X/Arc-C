using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020003AC RID: 940
	[Token(Token = "0x20003AC")]
	[System.Serializable]
	internal class ContextLevelActivator : IActivator
	{
		// Token: 0x06001E09 RID: 7689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public ContextLevelActivator(IActivator next)
		{
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700038B")]
		public IActivator NextActivator
		{
			[Token(Token = "0x6001E0A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0x4B78310", Offset = "0x4B76F10", VA = "0x184B78310", Slot = "5")]
		public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			return null;
		}

		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0x10")]
		private IActivator m_NextActivator;
	}
}
