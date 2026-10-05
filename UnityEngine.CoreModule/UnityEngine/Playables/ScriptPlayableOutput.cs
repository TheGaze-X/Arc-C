using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	[RequiredByNativeCode]
	public struct ScriptPlayableOutput : IPlayableOutput
	{
		// Token: 0x06000F69 RID: 3945 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x5986850", Offset = "0x5985450", VA = "0x185986850")]
		public static ScriptPlayableOutput Create(PlayableGraph graph, string name)
		{
			return default(ScriptPlayableOutput);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x5986970", Offset = "0x5985570", VA = "0x185986970")]
		internal ScriptPlayableOutput(PlayableOutputHandle handle)
		{
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x170002FF")]
		public static ScriptPlayableOutput Null
		{
			[Token(Token = "0x6000F6B")]
			[Address(RVA = "0x5986AA0", Offset = "0x59856A0", VA = "0x185986AA0")]
			get
			{
				return default(ScriptPlayableOutput);
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00007B00 File Offset: 0x00005D00
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x43DAF30", Offset = "0x43D9B30", VA = "0x1843DAF30", Slot = "4")]
		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x5986B60", Offset = "0x5985760", VA = "0x185986B60")]
		public static implicit operator PlayableOutput(ScriptPlayableOutput output)
		{
			return default(PlayableOutput);
		}

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x0")]
		private PlayableOutputHandle m_Handle;
	}
}
