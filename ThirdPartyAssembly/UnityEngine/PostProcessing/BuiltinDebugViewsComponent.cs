using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x17000035")]
		public override bool active
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x52F39D0", Offset = "0x52F25D0", VA = "0x1852F39D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x52F2CE0", Offset = "0x52F18E0", VA = "0x1852F2CE0", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x52F2C80", Offset = "0x52F1880", VA = "0x1852F2C80", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x52F2D50", Offset = "0x52F1950", VA = "0x1852F2D50", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x52F35A0", Offset = "0x52F21A0", VA = "0x1852F35A0", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x52F2B30", Offset = "0x52F1730", VA = "0x1852F2B30")]
		private void DepthPass(CommandBuffer cb)
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x52F2A60", Offset = "0x52F1660", VA = "0x1852F2A60")]
		private void DepthNormalsPass(CommandBuffer cb)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x52F2D80", Offset = "0x52F1980", VA = "0x1852F2D80")]
		private void MotionVectorsPass(CommandBuffer cb)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x52F3870", Offset = "0x52F2470", VA = "0x1852F3870")]
		private void PrepareArrows()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x52F3550", Offset = "0x52F2150", VA = "0x1852F3550", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x52F3990", Offset = "0x52F2590", VA = "0x1852F3990")]
		public BuiltinDebugViewsComponent()
		{
		}

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x20")]
		private BuiltinDebugViewsComponent.ArrowArray m_Arrows;

		// Token: 0x02000087 RID: 135
		[Token(Token = "0x2000087")]
		private static class Uniforms
		{
			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _DepthScale;

			// Token: 0x0400036E RID: 878
			[Token(Token = "0x400036E")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _TempRT;

			// Token: 0x0400036F RID: 879
			[Token(Token = "0x400036F")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Opacity;

			// Token: 0x04000370 RID: 880
			[Token(Token = "0x4000370")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _MainTex;

			// Token: 0x04000371 RID: 881
			[Token(Token = "0x4000371")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _TempRT2;

			// Token: 0x04000372 RID: 882
			[Token(Token = "0x4000372")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _Amplitude;

			// Token: 0x04000373 RID: 883
			[Token(Token = "0x4000373")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _Scale;
		}

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x2000088")]
		private enum Pass
		{
			// Token: 0x04000375 RID: 885
			[Token(Token = "0x4000375")]
			Depth,
			// Token: 0x04000376 RID: 886
			[Token(Token = "0x4000376")]
			Normals,
			// Token: 0x04000377 RID: 887
			[Token(Token = "0x4000377")]
			MovecOpacity,
			// Token: 0x04000378 RID: 888
			[Token(Token = "0x4000378")]
			MovecImaging,
			// Token: 0x04000379 RID: 889
			[Token(Token = "0x4000379")]
			MovecArrows
		}

		// Token: 0x02000089 RID: 137
		[Token(Token = "0x2000089")]
		private class ArrowArray
		{
			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060002CD RID: 717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000036")]
			public Mesh mesh
			{
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60002CD")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060002CE RID: 718 RVA: 0x00002D48 File Offset: 0x00000F48
			// (set) Token: 0x060002CF RID: 719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000037")]
			public int columnCount
			{
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60002CF")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x00002D60 File Offset: 0x00000F60
			// (set) Token: 0x060002D1 RID: 721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000038")]
			public int rowCount
			{
				[Token(Token = "0x60002D0")]
				[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60002D1")]
				[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x52F1960", Offset = "0x52F0560", VA = "0x1852F1960")]
			public void BuildMesh(int columns, int rows)
			{
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x52F1DC0", Offset = "0x52F09C0", VA = "0x1852F1DC0")]
			public void Release()
			{
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArrowArray()
			{
			}
		}
	}
}
