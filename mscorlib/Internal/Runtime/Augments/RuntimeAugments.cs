using System;
using Il2CppDummyDll;

namespace Internal.Runtime.Augments
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	internal class RuntimeAugments
	{
		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x4BEE100", Offset = "0x4BECD00", VA = "0x184BEE100")]
		public static void ReportUnhandledException(System.Exception exception)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700003F")]
		internal static ReflectionExecutionDomainCallbacks Callbacks
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x4BEE1B0", Offset = "0x4BECDB0", VA = "0x184BEE1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x0")]
		private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks;
	}
}
