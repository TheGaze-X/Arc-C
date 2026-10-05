using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[NativeHeader("Modules/Wind/Public/Wind.h")]
	public class WindZone : Component
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		// (set) Token: 0x06000002 RID: 2
		[Token(Token = "0x17000001")]
		public extern WindZoneMode mode { [Token(Token = "0x6000001")] [Address(RVA = "0x5BA1D60", Offset = "0x5BA0960", VA = "0x185BA1D60")] [MethodImpl(4096)] get; [Token(Token = "0x6000002")] [Address(RVA = "0x5BA1EE0", Offset = "0x5BA0AE0", VA = "0x185BA1EE0")] [MethodImpl(4096)] set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3
		// (set) Token: 0x06000004 RID: 4
		[Token(Token = "0x17000002")]
		public extern float radius { [Token(Token = "0x6000003")] [Address(RVA = "0x5BA1DA0", Offset = "0x5BA09A0", VA = "0x185BA1DA0")] [MethodImpl(4096)] get; [Token(Token = "0x6000004")] [Address(RVA = "0x5BA1F20", Offset = "0x5BA0B20", VA = "0x185BA1F20")] [MethodImpl(4096)] set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5
		// (set) Token: 0x06000006 RID: 6
		[Token(Token = "0x17000003")]
		public extern float windMain { [Token(Token = "0x6000005")] [Address(RVA = "0x5BA1DE0", Offset = "0x5BA09E0", VA = "0x185BA1DE0")] [MethodImpl(4096)] get; [Token(Token = "0x6000006")] [Address(RVA = "0x5BA1F70", Offset = "0x5BA0B70", VA = "0x185BA1F70")] [MethodImpl(4096)] set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7
		// (set) Token: 0x06000008 RID: 8
		[Token(Token = "0x17000004")]
		public extern float windTurbulence { [Token(Token = "0x6000007")] [Address(RVA = "0x5BA1EA0", Offset = "0x5BA0AA0", VA = "0x185BA1EA0")] [MethodImpl(4096)] get; [Token(Token = "0x6000008")] [Address(RVA = "0x5BA2060", Offset = "0x5BA0C60", VA = "0x185BA2060")] [MethodImpl(4096)] set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9
		// (set) Token: 0x0600000A RID: 10
		[Token(Token = "0x17000005")]
		public extern float windPulseMagnitude { [Token(Token = "0x6000009")] [Address(RVA = "0x5BA1E60", Offset = "0x5BA0A60", VA = "0x185BA1E60")] [MethodImpl(4096)] get; [Token(Token = "0x600000A")] [Address(RVA = "0x5BA2010", Offset = "0x5BA0C10", VA = "0x185BA2010")] [MethodImpl(4096)] set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11
		// (set) Token: 0x0600000C RID: 12
		[Token(Token = "0x17000006")]
		public extern float windPulseFrequency { [Token(Token = "0x600000B")] [Address(RVA = "0x5BA1E20", Offset = "0x5BA0A20", VA = "0x185BA1E20")] [MethodImpl(4096)] get; [Token(Token = "0x600000C")] [Address(RVA = "0x5BA1FC0", Offset = "0x5BA0BC0", VA = "0x185BA1FC0")] [MethodImpl(4096)] set; }

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public WindZone()
		{
		}
	}
}
