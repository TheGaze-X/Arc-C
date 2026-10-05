using System;
using System.Threading;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	public static class AsyncOperationManager
	{
		// Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x511E3E0", Offset = "0x511CFE0", VA = "0x18511E3E0")]
		public static AsyncOperation CreateOperation(object userSuppliedState)
		{
			return null;
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B1")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static SynchronizationContext SynchronizationContext
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x511E500", Offset = "0x511D100", VA = "0x18511E500")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x511E570", Offset = "0x511D170", VA = "0x18511E570")]
			set
			{
			}
		}
	}
}
