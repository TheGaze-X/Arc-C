using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public static class GraphicsUtils
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x17000080")]
		public static bool isLinearColorSpace
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x2879A50", Offset = "0x2878650", VA = "0x182879A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x17000081")]
		public static bool supportsDX11
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x5427250", Offset = "0x5425E50", VA = "0x185427250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		public static Texture2D whiteTexture
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x5427280", Offset = "0x5425E80", VA = "0x185427280")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		public static Mesh quad
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x5426F20", Offset = "0x5425B20", VA = "0x185426F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x5426BD0", Offset = "0x54257D0", VA = "0x185426BD0")]
		public static void Blit(Material material, int pass)
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x5426CD0", Offset = "0x54258D0", VA = "0x185426CD0")]
		public static void ClearAndBlit(Texture source, RenderTexture destination, Material material, int pass, bool clearColor = true, bool clearDepth = false)
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x5426E60", Offset = "0x5425A60", VA = "0x185426E60")]
		public static void Destroy(Object obj)
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x5426EE0", Offset = "0x5425AE0", VA = "0x185426EE0")]
		public static void Dispose()
		{
		}

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0x0")]
		private static Texture2D s_WhiteTexture;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x8")]
		private static Mesh s_Quad;
	}
}
