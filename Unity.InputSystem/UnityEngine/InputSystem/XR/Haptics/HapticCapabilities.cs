using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.XR.Haptics
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	public struct HapticCapabilities
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x4CD2130", Offset = "0x4CD0D30", VA = "0x184CD2130")]
		public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize)
		{
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00005E38 File Offset: 0x00004038
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000330")]
		public uint numChannels
		{
			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00005E50 File Offset: 0x00004050
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000331")]
		public uint frequencyHz
		{
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00005E68 File Offset: 0x00004068
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000332")]
		public uint maxBufferSize
		{
			[Token(Token = "0x6000C45")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			[CompilerGenerated]
			private set
			{
			}
		}
	}
}
