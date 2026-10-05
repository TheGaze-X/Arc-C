using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public enum ParticleSystemShapeType
	{
		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		Sphere,
		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[Obsolete("SphereShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", false)]
		SphereShell,
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		Hemisphere,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[Obsolete("HemisphereShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", false)]
		HemisphereShell,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		Cone,
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		Box,
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		Mesh,
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[Obsolete("ConeShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", false)]
		ConeShell,
		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		ConeVolume,
		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[Obsolete("ConeVolumeShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", false)]
		ConeVolumeShell,
		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		Circle,
		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[Obsolete("CircleEdge is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", false)]
		CircleEdge,
		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		SingleSidedEdge,
		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		MeshRenderer,
		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		SkinnedMeshRenderer,
		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		BoxShell,
		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		BoxEdge,
		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		Donut,
		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		Rectangle,
		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		Sprite,
		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		SpriteRenderer
	}
}
