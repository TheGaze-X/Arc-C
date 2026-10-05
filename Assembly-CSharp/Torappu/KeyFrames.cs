using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FA0 RID: 4000
	[Token(Token = "0x2000FA0")]
	public abstract class KeyFrames<TInput, TOutput> : List<KeyFrames<TInput, TOutput>.KeyFrame> where TInput : TOutput
	{
		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06006CE0 RID: 27872 RVA: 0x00031A70 File Offset: 0x0002FC70
		[Token(Token = "0x17000D12")]
		public int frameCnt
		{
			[Token(Token = "0x6006CE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06006CE1 RID: 27873 RVA: 0x00031A88 File Offset: 0x0002FC88
		[Token(Token = "0x17000D13")]
		public int minLevel
		{
			[Token(Token = "0x6006CE1")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06006CE2 RID: 27874 RVA: 0x00031AA0 File Offset: 0x0002FCA0
		[Token(Token = "0x17000D14")]
		public int maxLevel
		{
			[Token(Token = "0x6006CE2")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x00031AB8 File Offset: 0x0002FCB8
		[Token(Token = "0x6006CE3")]
		public bool CheckRange(int level)
		{
			return default(bool);
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x00031AD0 File Offset: 0x0002FCD0
		[Token(Token = "0x6006CE4")]
		public bool TryGetData(int level, out TOutput data)
		{
			return default(bool);
		}

		// Token: 0x06006CE5 RID: 27877
		[Token(Token = "0x6006CE5")]
		protected abstract TOutput LerpData(KeyFrames<TInput, TOutput>.KeyFrame from, KeyFrames<TInput, TOutput>.KeyFrame to, int level);

		// Token: 0x06006CE6 RID: 27878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE6")]
		protected KeyFrames()
		{
		}

		// Token: 0x02000FA1 RID: 4001
		[Token(Token = "0x2000FA1")]
		[Serializable]
		public class KeyFrame
		{
			// Token: 0x06006CE7 RID: 27879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CE7")]
			public KeyFrame()
			{
			}

			// Token: 0x04005510 RID: 21776
			[Token(Token = "0x4005510")]
			[FieldOffset(Offset = "0x0")]
			public int level;

			// Token: 0x04005511 RID: 21777
			[Token(Token = "0x4005511")]
			[FieldOffset(Offset = "0x0")]
			public TInput data;
		}
	}
}
