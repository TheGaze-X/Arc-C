using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	[DesignTimeVisible(false)]
	internal class CompensateRotationProcessor : InputProcessor<Quaternion>
	{
		// Token: 0x060011CC RID: 4556 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x56E6A30", Offset = "0x56E5630", VA = "0x1856E6A30", Slot = "7")]
		public override Quaternion Process(Quaternion value, InputControl control)
		{
			return default(Quaternion);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x56E6CE0", Offset = "0x56E58E0", VA = "0x1856E6CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x17000518")]
		public override InputProcessor.CachingPolicy cachingPolicy
		{
			[Token(Token = "0x60011CE")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
			get
			{
				return InputProcessor.CachingPolicy.CacheResult;
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x56E6D10", Offset = "0x56E5910", VA = "0x1856E6D10")]
		public CompensateRotationProcessor()
		{
		}
	}
}
