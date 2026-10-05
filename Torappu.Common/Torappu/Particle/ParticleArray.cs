using System;
using System.Runtime.CompilerServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Particle
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	public class ParticleArray
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00007F04 File Offset: 0x00006104
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000115")]
		public int count
		{
			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000116")]
		public ParticleSystem.Particle[] particles
		{
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00007F1C File Offset: 0x0000611C
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x5572690", Offset = "0x5571290", VA = "0x185572690")]
		public static GenericPool<ParticleArray>.Ref ReadParticles(ParticleSystem ps)
		{
			return default(GenericPool<ParticleArray>.Ref);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ParticleArray()
		{
		}

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		private const int DEFAULT_CAPACITY = 128;
	}
}
