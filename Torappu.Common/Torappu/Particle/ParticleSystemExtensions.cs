using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Particle
{
	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	public static class ParticleSystemExtensions
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x5573390", Offset = "0x5571F90", VA = "0x185573390")]
		public static void ValidateShape(this ParticleSystem self)
		{
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00007F34 File Offset: 0x00006134
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x5572D50", Offset = "0x5571950", VA = "0x185572D50")]
		public static bool CanBakeMesh(this ParticleSystemRenderer self)
		{
			return default(bool);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00007F4C File Offset: 0x0000614C
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x5572F40", Offset = "0x5571B40", VA = "0x185572F40")]
		public static ParticleSystemSimulationSpace GetActualSimulationSpace(this ParticleSystem self)
		{
			return ParticleSystemSimulationSpace.Local;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00007F64 File Offset: 0x00006164
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x5573250", Offset = "0x5571E50", VA = "0x185573250")]
		public static bool IsLocalSpace(this ParticleSystem self)
		{
			return default(bool);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00007F7C File Offset: 0x0000617C
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x55732F0", Offset = "0x5571EF0", VA = "0x1855732F0")]
		public static bool IsWorldSpace(this ParticleSystem self)
		{
			return default(bool);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00007F94 File Offset: 0x00006194
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x5572FE0", Offset = "0x5571BE0", VA = "0x185572FE0")]
		private static int GetIndex(IList<ParticleSystem> list, UnityEngine.Object ps)
		{
			return 0;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x5573130", Offset = "0x5571D30", VA = "0x185573130")]
		public static Texture2D GetTextureForSprite(this ParticleSystem self)
		{
			return null;
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x5572DF0", Offset = "0x55719F0", VA = "0x185572DF0")]
		public static void Exec(this List<ParticleSystem> self, Action<ParticleSystem> action)
		{
		}
	}
}
