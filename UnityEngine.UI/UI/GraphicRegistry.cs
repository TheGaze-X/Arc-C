using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class GraphicRegistry
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x5A15580", Offset = "0x5A14180", VA = "0x185A15580")]
		protected GraphicRegistry()
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public static GraphicRegistry instance
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x5A15730", Offset = "0x5A14330", VA = "0x185A15730")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x5A14D60", Offset = "0x5A13960", VA = "0x185A14D60")]
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x5A14F60", Offset = "0x5A13B60", VA = "0x185A14F60")]
		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x5A15190", Offset = "0x5A13D90", VA = "0x185A15190")]
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x5A15350", Offset = "0x5A13F50", VA = "0x185A15350")]
		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x5A14730", Offset = "0x5A13330", VA = "0x185A14730")]
		public static void DisableGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x5A14A40", Offset = "0x5A13640", VA = "0x185A14A40")]
		public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x5A14BE0", Offset = "0x5A137E0", VA = "0x185A14BE0")]
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			return null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x5A14CA0", Offset = "0x5A138A0", VA = "0x185A14CA0")]
		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
		{
			return null;
		}

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x0")]
		private static GraphicRegistry s_Instance;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<Graphic> s_EmptyList;
	}
}
