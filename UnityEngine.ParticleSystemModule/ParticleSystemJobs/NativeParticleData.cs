using System;
using Il2CppDummyDll;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	internal struct NativeParticleData
	{
		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x0")]
		internal int count;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x8")]
		internal NativeParticleData.Array3 positions;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x20")]
		internal NativeParticleData.Array3 velocities;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x38")]
		internal NativeParticleData.Array3 axisOfRotations;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x50")]
		internal NativeParticleData.Array3 rotations;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x68")]
		internal NativeParticleData.Array3 rotationalSpeeds;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x80")]
		internal NativeParticleData.Array3 sizes;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x98")]
		internal unsafe void* startColors;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0xA0")]
		internal unsafe void* aliveTimePercent;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0xA8")]
		internal unsafe void* inverseStartLifetimes;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0xB0")]
		internal unsafe void* randomSeeds;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0xB8")]
		internal NativeParticleData.Array4 customData1;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0xD8")]
		internal NativeParticleData.Array4 customData2;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0xF8")]
		internal unsafe void* meshIndices;

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		internal struct Array3
		{
			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			[FieldOffset(Offset = "0x0")]
			internal unsafe float* x;

			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			[FieldOffset(Offset = "0x8")]
			internal unsafe float* y;

			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			[FieldOffset(Offset = "0x10")]
			internal unsafe float* z;
		}

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		internal struct Array4
		{
			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			[FieldOffset(Offset = "0x0")]
			internal unsafe float* x;

			// Token: 0x04000123 RID: 291
			[Token(Token = "0x4000123")]
			[FieldOffset(Offset = "0x8")]
			internal unsafe float* y;

			// Token: 0x04000124 RID: 292
			[Token(Token = "0x4000124")]
			[FieldOffset(Offset = "0x10")]
			internal unsafe float* z;

			// Token: 0x04000125 RID: 293
			[Token(Token = "0x4000125")]
			[FieldOffset(Offset = "0x18")]
			internal unsafe float* w;
		}
	}
}
