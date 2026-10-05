using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public class HableCurve
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00002C24 File Offset: 0x00000E24
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002A")]
		public float whitePoint
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002C3C File Offset: 0x00000E3C
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002B")]
		public float inverseWhitePoint
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x4F1EC0", Offset = "0x4F0AC0", VA = "0x1804F1EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00002C54 File Offset: 0x00000E54
		// (set) Token: 0x060001EB RID: 491 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002C")]
		internal float x0
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00002C6C File Offset: 0x00000E6C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002D")]
		internal float x1
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x168B900", Offset = "0x168A500", VA = "0x18168B900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x582F650", Offset = "0x582E250", VA = "0x18582F650")]
		public HableCurve()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x582EDC0", Offset = "0x582D9C0", VA = "0x18582EDC0")]
		public float Eval(float x)
		{
			return 0f;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x582F3B0", Offset = "0x582DFB0", VA = "0x18582F3B0")]
		public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x582EE60", Offset = "0x582DA60", VA = "0x18582EE60")]
		private void InitSegments(HableCurve.DirectParams srcParams)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x582F5E0", Offset = "0x582E1E0", VA = "0x18582F5E0")]
		private void SolveAB(out float lnA, out float B, float x0, float y0, float m)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x582ED10", Offset = "0x582D910", VA = "0x18582ED10")]
		private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x582ED70", Offset = "0x582D970", VA = "0x18582ED70")]
		private float EvalDerivativeLinearGamma(float m, float b, float g, float x)
		{
			return 0f;
		}

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x20")]
		private readonly HableCurve.Segment[] m_Segments;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x28")]
		public readonly HableCurve.Uniforms uniforms;

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x2000088")]
		private class Segment
		{
			// Token: 0x060001F5 RID: 501 RVA: 0x00002CB4 File Offset: 0x00000EB4
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x5849EF0", Offset = "0x5848AF0", VA = "0x185849EF0")]
			public float Eval(float x)
			{
				return 0f;
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Segment()
			{
			}

			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x10")]
			public float offsetX;

			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x14")]
			public float offsetY;

			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			[FieldOffset(Offset = "0x18")]
			public float scaleX;

			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			[FieldOffset(Offset = "0x1C")]
			public float scaleY;

			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			[FieldOffset(Offset = "0x20")]
			public float lnA;

			// Token: 0x040002AF RID: 687
			[Token(Token = "0x40002AF")]
			[FieldOffset(Offset = "0x24")]
			public float B;
		}

		// Token: 0x02000089 RID: 137
		[Token(Token = "0x2000089")]
		private struct DirectParams
		{
			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			[FieldOffset(Offset = "0x0")]
			internal float x0;

			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x4")]
			internal float y0;

			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			[FieldOffset(Offset = "0x8")]
			internal float x1;

			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			[FieldOffset(Offset = "0xC")]
			internal float y1;

			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			[FieldOffset(Offset = "0x10")]
			internal float W;

			// Token: 0x040002B5 RID: 693
			[Token(Token = "0x40002B5")]
			[FieldOffset(Offset = "0x14")]
			internal float overshootX;

			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			[FieldOffset(Offset = "0x18")]
			internal float overshootY;

			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			[FieldOffset(Offset = "0x1C")]
			internal float gamma;
		}

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x200008A")]
		public class Uniforms
		{
			// Token: 0x060001F7 RID: 503 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal Uniforms(HableCurve parent)
			{
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002CCC File Offset: 0x00000ECC
			[Token(Token = "0x1700002E")]
			public Vector4 curve
			{
				[Token(Token = "0x60001F8")]
				[Address(RVA = "0x584ACB0", Offset = "0x58498B0", VA = "0x18584ACB0")]
				get
				{
					return default(Vector4);
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002CE4 File Offset: 0x00000EE4
			[Token(Token = "0x1700002F")]
			public Vector4 toeSegmentA
			{
				[Token(Token = "0x60001F9")]
				[Address(RVA = "0x584AE50", Offset = "0x5849A50", VA = "0x18584AE50")]
				get
				{
					return default(Vector4);
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060001FA RID: 506 RVA: 0x00002CFC File Offset: 0x00000EFC
			[Token(Token = "0x17000030")]
			public Vector4 toeSegmentB
			{
				[Token(Token = "0x60001FA")]
				[Address(RVA = "0x584AEB0", Offset = "0x5849AB0", VA = "0x18584AEB0")]
				get
				{
					return default(Vector4);
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060001FB RID: 507 RVA: 0x00002D14 File Offset: 0x00000F14
			[Token(Token = "0x17000031")]
			public Vector4 midSegmentA
			{
				[Token(Token = "0x60001FB")]
				[Address(RVA = "0x584ACF0", Offset = "0x58498F0", VA = "0x18584ACF0")]
				get
				{
					return default(Vector4);
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060001FC RID: 508 RVA: 0x00002D2C File Offset: 0x00000F2C
			[Token(Token = "0x17000032")]
			public Vector4 midSegmentB
			{
				[Token(Token = "0x60001FC")]
				[Address(RVA = "0x584AD50", Offset = "0x5849950", VA = "0x18584AD50")]
				get
				{
					return default(Vector4);
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060001FD RID: 509 RVA: 0x00002D44 File Offset: 0x00000F44
			[Token(Token = "0x17000033")]
			public Vector4 shoSegmentA
			{
				[Token(Token = "0x60001FD")]
				[Address(RVA = "0x584ADA0", Offset = "0x58499A0", VA = "0x18584ADA0")]
				get
				{
					return default(Vector4);
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060001FE RID: 510 RVA: 0x00002D5C File Offset: 0x00000F5C
			[Token(Token = "0x17000034")]
			public Vector4 shoSegmentB
			{
				[Token(Token = "0x60001FE")]
				[Address(RVA = "0x584AE00", Offset = "0x5849A00", VA = "0x18584AE00")]
				get
				{
					return default(Vector4);
				}
			}

			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			[FieldOffset(Offset = "0x10")]
			private HableCurve parent;
		}
	}
}
