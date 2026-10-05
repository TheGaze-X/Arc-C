using System;
using Il2CppDummyDll;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	public static class LightmapperUtils
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x5980560", Offset = "0x597F160", VA = "0x185980560")]
		public static LightMode Extract(LightmapBakeType baketype)
		{
			return LightMode.Realtime;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x597FBD0", Offset = "0x597E7D0", VA = "0x18597FBD0")]
		public static LinearColor ExtractIndirect(Light l)
		{
			return default(LinearColor);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x597FC60", Offset = "0x597E860", VA = "0x18597FC60")]
		public static float ExtractInnerCone(Light l)
		{
			return 0f;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x597FB50", Offset = "0x597E750", VA = "0x18597FB50")]
		private static Color ExtractColorTemperature(Light l)
		{
			return default(Color);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x597FAF0", Offset = "0x597E6F0", VA = "0x18597FAF0")]
		private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor)
		{
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x597FFA0", Offset = "0x597EBA0", VA = "0x18597FFA0")]
		public static void Extract(Light l, ref DirectionalLight dir)
		{
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x5980270", Offset = "0x597EE70", VA = "0x185980270")]
		public static void Extract(Light l, ref PointLight point)
		{
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x5980580", Offset = "0x597F180", VA = "0x185980580")]
		public static void Extract(Light l, ref SpotLight spot)
		{
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x597FCB0", Offset = "0x597E8B0", VA = "0x18597FCB0")]
		public static void Extract(Light l, ref RectangleLight rect)
		{
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x5980270", Offset = "0x597EE70", VA = "0x185980270")]
		public static void Extract(Light l, ref DiscLight disc)
		{
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x59808C0", Offset = "0x597F4C0", VA = "0x1859808C0")]
		public static void Extract(Light l, out Cookie cookie)
		{
		}
	}
}
