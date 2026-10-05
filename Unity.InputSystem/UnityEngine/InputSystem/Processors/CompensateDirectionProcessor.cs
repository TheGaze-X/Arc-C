using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	[DesignTimeVisible(false)]
	internal class CompensateDirectionProcessor : InputProcessor<Vector3>
	{
		// Token: 0x060011C8 RID: 4552 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x60011C8")]
		[Address(RVA = "0x56E6830", Offset = "0x56E5430", VA = "0x1856E6830", Slot = "7")]
		public override Vector3 Process(Vector3 value, InputControl control)
		{
			return default(Vector3);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0x56E69C0", Offset = "0x56E55C0", VA = "0x1856E69C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x17000517")]
		public override InputProcessor.CachingPolicy cachingPolicy
		{
			[Token(Token = "0x60011CA")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
			get
			{
				return InputProcessor.CachingPolicy.CacheResult;
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x56E69F0", Offset = "0x56E55F0", VA = "0x1856E69F0")]
		public CompensateDirectionProcessor()
		{
		}
	}
}
