using System;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[Il2CppEagerStaticClassConstruction]
	public static class noise
	{
		// Token: 0x06001E0D RID: 7693 RVA: 0x00028D70 File Offset: 0x00026F70
		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x57F4980", Offset = "0x57F3580", VA = "0x1857F4980")]
		public static float2 cellular(float2 P)
		{
			return default(float2);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00028D88 File Offset: 0x00026F88
		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x57F3650", Offset = "0x57F2250", VA = "0x1857F3650")]
		public static float2 cellular2x2(float2 P)
		{
			return default(float2);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00028DA0 File Offset: 0x00026FA0
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x57F3AF0", Offset = "0x57F26F0", VA = "0x1857F3AF0")]
		public static float2 cellular2x2x2(float3 P)
		{
			return default(float2);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00028DB8 File Offset: 0x00026FB8
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x57F5460", Offset = "0x57F4060", VA = "0x1857F5460")]
		public static float2 cellular(float3 P)
		{
			return default(float2);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00028DD0 File Offset: 0x00026FD0
		[Token(Token = "0x6001E11")]
		[Address(RVA = "0x57FCA40", Offset = "0x57FB640", VA = "0x1857FCA40")]
		public static float cnoise(float2 P)
		{
			return 0f;
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00028DE8 File Offset: 0x00026FE8
		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x57FDE80", Offset = "0x57FCA80", VA = "0x1857FDE80")]
		public static float pnoise(float2 P, float2 rep)
		{
			return 0f;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00028E00 File Offset: 0x00027000
		[Token(Token = "0x6001E13")]
		[Address(RVA = "0x57FB4D0", Offset = "0x57FA0D0", VA = "0x1857FB4D0")]
		public static float cnoise(float3 P)
		{
			return 0f;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00028E18 File Offset: 0x00027018
		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x5801A30", Offset = "0x5800630", VA = "0x185801A30")]
		public static float pnoise(float3 P, float3 rep)
		{
			return 0f;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00028E30 File Offset: 0x00027030
		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x57F8160", Offset = "0x57F6D60", VA = "0x1857F8160")]
		public static float cnoise(float4 P)
		{
			return 0f;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00028E48 File Offset: 0x00027048
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x57FE5C0", Offset = "0x57FD1C0", VA = "0x1857FE5C0")]
		public static float pnoise(float4 P, float4 rep)
		{
			return 0f;
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00028E60 File Offset: 0x00027060
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x57FD6F0", Offset = "0x57FC2F0", VA = "0x1857FD6F0")]
		private static float mod289(float x)
		{
			return 0f;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00028E78 File Offset: 0x00027078
		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x57FD860", Offset = "0x57FC460", VA = "0x1857FD860")]
		private static float2 mod289(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00028E90 File Offset: 0x00027090
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x57FD770", Offset = "0x57FC370", VA = "0x1857FD770")]
		private static float3 mod289(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00028EA8 File Offset: 0x000270A8
		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x57FD8F0", Offset = "0x57FC4F0", VA = "0x1857FD8F0")]
		private static float4 mod289(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00028EC0 File Offset: 0x000270C0
		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x57FDAF0", Offset = "0x57FC6F0", VA = "0x1857FDAF0")]
		private static float3 mod7(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00028ED8 File Offset: 0x000270D8
		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x57FD9F0", Offset = "0x57FC5F0", VA = "0x1857FD9F0")]
		private static float4 mod7(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00028EF0 File Offset: 0x000270F0
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x57FDDE0", Offset = "0x57FC9E0", VA = "0x1857FDDE0")]
		private static float permute(float x)
		{
			return 0f;
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00028F08 File Offset: 0x00027108
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x57FDCA0", Offset = "0x57FC8A0", VA = "0x1857FDCA0")]
		private static float3 permute(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00028F20 File Offset: 0x00027120
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x57FDBE0", Offset = "0x57FC7E0", VA = "0x1857FDBE0")]
		private static float4 permute(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00028F38 File Offset: 0x00027138
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x5808030", Offset = "0x5806C30", VA = "0x185808030")]
		private static float taylorInvSqrt(float r)
		{
			return 0f;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00028F50 File Offset: 0x00027150
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x5807FA0", Offset = "0x5806BA0", VA = "0x185807FA0")]
		private static float4 taylorInvSqrt(float4 r)
		{
			return default(float4);
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00028F68 File Offset: 0x00027168
		[Token(Token = "0x6001E22")]
		[Address(RVA = "0x57FD2D0", Offset = "0x57FBED0", VA = "0x1857FD2D0")]
		private static float2 fade(float2 t)
		{
			return default(float2);
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00028F80 File Offset: 0x00027180
		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x57FD360", Offset = "0x57FBF60", VA = "0x1857FD360")]
		private static float3 fade(float3 t)
		{
			return default(float3);
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00028F98 File Offset: 0x00027198
		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x57FD150", Offset = "0x57FBD50", VA = "0x1857FD150")]
		private static float4 fade(float4 t)
		{
			return default(float4);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00028FB0 File Offset: 0x000271B0
		[Token(Token = "0x6001E25")]
		[Address(RVA = "0x57FD480", Offset = "0x57FC080", VA = "0x1857FD480")]
		private static float4 grad4(float j, float4 ip)
		{
			return default(float4);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00028FC8 File Offset: 0x000271C8
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x5803A60", Offset = "0x5802660", VA = "0x185803A60")]
		private static float2 rgrad2(float2 p, float rot)
		{
			return default(float2);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00028FE0 File Offset: 0x000271E0
		[Token(Token = "0x6001E27")]
		[Address(RVA = "0x5805F50", Offset = "0x5804B50", VA = "0x185805F50")]
		public static float snoise(float2 v)
		{
			return 0f;
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00028FF8 File Offset: 0x000271F8
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x58064D0", Offset = "0x58050D0", VA = "0x1858064D0")]
		public static float snoise(float3 v)
		{
			return 0f;
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00029010 File Offset: 0x00027210
		[Token(Token = "0x6001E29")]
		[Address(RVA = "0x5804D50", Offset = "0x5803950", VA = "0x185804D50")]
		public static float snoise(float3 v, out float3 gradient)
		{
			return 0f;
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00029028 File Offset: 0x00027228
		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0x5803C10", Offset = "0x5802810", VA = "0x185803C10")]
		public static float snoise(float4 v)
		{
			return 0f;
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00029040 File Offset: 0x00027240
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x5803040", Offset = "0x5801C40", VA = "0x185803040")]
		public static float3 psrdnoise(float2 pos, float2 per, float rot)
		{
			return default(float3);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00029058 File Offset: 0x00027258
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x5803640", Offset = "0x5802240", VA = "0x185803640")]
		public static float3 psrdnoise(float2 pos, float2 per)
		{
			return default(float3);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00029070 File Offset: 0x00027270
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x5803690", Offset = "0x5802290", VA = "0x185803690")]
		public static float psrnoise(float2 pos, float2 per, float rot)
		{
			return 0f;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00029088 File Offset: 0x00027288
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x5803680", Offset = "0x5802280", VA = "0x185803680")]
		public static float psrnoise(float2 pos, float2 per)
		{
			return 0f;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000290A0 File Offset: 0x000272A0
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x58074D0", Offset = "0x58060D0", VA = "0x1858074D0")]
		public static float3 srdnoise(float2 pos, float rot)
		{
			return default(float3);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000290B8 File Offset: 0x000272B8
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x58074A0", Offset = "0x58060A0", VA = "0x1858074A0")]
		public static float3 srdnoise(float2 pos)
		{
			return default(float3);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000290D0 File Offset: 0x000272D0
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x5807B30", Offset = "0x5806730", VA = "0x185807B30")]
		public static float srnoise(float2 pos, float rot)
		{
			return 0f;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000290E8 File Offset: 0x000272E8
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x5807B20", Offset = "0x5806720", VA = "0x185807B20")]
		public static float srnoise(float2 pos)
		{
			return 0f;
		}
	}
}
