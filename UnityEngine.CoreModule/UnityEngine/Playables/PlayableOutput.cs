using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000294 RID: 660
	[Token(Token = "0x2000294")]
	[RequiredByNativeCode]
	public struct PlayableOutput : IPlayableOutput, IEquatable<PlayableOutput>
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x170002FC")]
		public static PlayableOutput Null
		{
			[Token(Token = "0x6000F2E")]
			[Address(RVA = "0x5984AF0", Offset = "0x59836F0", VA = "0x185984AF0")]
			get
			{
				return default(PlayableOutput);
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x453ADB0", Offset = "0x45399B0", VA = "0x18453ADB0")]
		[VisibleToOtherModules]
		internal PlayableOutput(PlayableOutputHandle handle)
		{
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x6000F31")]
		public bool IsPlayableOutputOfType<T>() where T : struct, IPlayableOutput
		{
			return default(bool);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x5984970", Offset = "0x5983570", VA = "0x185984970", Slot = "5")]
		public bool Equals(PlayableOutput other)
		{
			return default(bool);
		}

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x0")]
		private static readonly PlayableOutput m_NullPlayableOutput;
	}
}
