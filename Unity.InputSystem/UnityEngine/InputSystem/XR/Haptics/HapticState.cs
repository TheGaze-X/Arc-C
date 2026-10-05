using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.XR.Haptics
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	public struct HapticState
	{
		// Token: 0x06000C37 RID: 3127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public HapticState(uint samplesQueued, uint samplesAvailable)
		{
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00005DA8 File Offset: 0x00003FA8
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032B")]
		public uint samplesQueued
		{
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00005DC0 File Offset: 0x00003FC0
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032C")]
		public uint samplesAvailable
		{
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			[CompilerGenerated]
			private set
			{
			}
		}
	}
}
