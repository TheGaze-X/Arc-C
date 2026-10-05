using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	[UsedByNativeCode]
	public struct LightDataGI
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x597F920", Offset = "0x597E520", VA = "0x18597F920")]
		public void Init(ref DirectionalLight light, ref Cookie cookie)
		{
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x597F9A0", Offset = "0x597E5A0", VA = "0x18597F9A0")]
		public void Init(ref PointLight light, ref Cookie cookie)
		{
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x597F8A0", Offset = "0x597E4A0", VA = "0x18597F8A0")]
		public void Init(ref SpotLight light, ref Cookie cookie)
		{
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x597FA80", Offset = "0x597E680", VA = "0x18597FA80")]
		public void Init(ref RectangleLight light, ref Cookie cookie)
		{
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x597FA10", Offset = "0x597E610", VA = "0x18597FA10")]
		public void Init(ref DiscLight light, ref Cookie cookie)
		{
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x597F890", Offset = "0x597E490", VA = "0x18597F890")]
		public void InitNoBake(int lightInstanceID)
		{
		}

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x0")]
		public int instanceID;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x4")]
		public int cookieID;

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x8")]
		public float cookieScale;

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0xC")]
		public LinearColor color;

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0x1C")]
		public LinearColor indirectColor;

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x2C")]
		public Quaternion orientation;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 position;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x48")]
		public float range;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x4C")]
		public float coneAngle;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x50")]
		public float innerConeAngle;

		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		[FieldOffset(Offset = "0x54")]
		public float shape0;

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x58")]
		public float shape1;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x5C")]
		public LightType type;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x5D")]
		public LightMode mode;

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x5E")]
		public byte shadow;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x5F")]
		public FalloffType falloff;
	}
}
