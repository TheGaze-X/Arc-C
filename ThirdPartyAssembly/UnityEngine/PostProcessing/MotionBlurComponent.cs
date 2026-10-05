using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000041")]
		public MotionBlurComponent.ReconstructionFilter reconstructionFilter
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x5428D80", Offset = "0x5427980", VA = "0x185428D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public MotionBlurComponent.FrameBlendingFilter frameBlendingFilter
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x5428BF0", Offset = "0x54277F0", VA = "0x185428BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x17000043")]
		public override bool active
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x5428B30", Offset = "0x5427730", VA = "0x185428B30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x54282B0", Offset = "0x5426EB0", VA = "0x1854282B0", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x5428AC0", Offset = "0x54276C0", VA = "0x185428AC0")]
		public void ResetHistory()
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x4BF3FC0", Offset = "0x4BF2BC0", VA = "0x184BF3FC0", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1B023C0", Offset = "0x1B00FC0", VA = "0x181B023C0", Slot = "6")]
		public override void OnEnable()
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x5428300", Offset = "0x5426F00", VA = "0x185428300", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x54282E0", Offset = "0x5426EE0", VA = "0x1854282E0", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x5428AF0", Offset = "0x54276F0", VA = "0x185428AF0")]
		public MotionBlurComponent()
		{
		}

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x20")]
		private MotionBlurComponent.ReconstructionFilter m_ReconstructionFilter;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x28")]
		private MotionBlurComponent.FrameBlendingFilter m_FrameBlendingFilter;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x30")]
		private bool m_FirstFrame;

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		private static class Uniforms
		{
			// Token: 0x040003CC RID: 972
			[Token(Token = "0x40003CC")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _VelocityScale;

			// Token: 0x040003CD RID: 973
			[Token(Token = "0x40003CD")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _MaxBlurRadius;

			// Token: 0x040003CE RID: 974
			[Token(Token = "0x40003CE")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _RcpMaxBlurRadius;

			// Token: 0x040003CF RID: 975
			[Token(Token = "0x40003CF")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _VelocityTex;

			// Token: 0x040003D0 RID: 976
			[Token(Token = "0x40003D0")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _MainTex;

			// Token: 0x040003D1 RID: 977
			[Token(Token = "0x40003D1")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _Tile2RT;

			// Token: 0x040003D2 RID: 978
			[Token(Token = "0x40003D2")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _Tile4RT;

			// Token: 0x040003D3 RID: 979
			[Token(Token = "0x40003D3")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _Tile8RT;

			// Token: 0x040003D4 RID: 980
			[Token(Token = "0x40003D4")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _TileMaxOffs;

			// Token: 0x040003D5 RID: 981
			[Token(Token = "0x40003D5")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _TileMaxLoop;

			// Token: 0x040003D6 RID: 982
			[Token(Token = "0x40003D6")]
			[FieldOffset(Offset = "0x28")]
			internal static readonly int _TileVRT;

			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x40003D7")]
			[FieldOffset(Offset = "0x2C")]
			internal static readonly int _NeighborMaxTex;

			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			[FieldOffset(Offset = "0x30")]
			internal static readonly int _LoopCount;

			// Token: 0x040003D9 RID: 985
			[Token(Token = "0x40003D9")]
			[FieldOffset(Offset = "0x34")]
			internal static readonly int _TempRT;

			// Token: 0x040003DA RID: 986
			[Token(Token = "0x40003DA")]
			[FieldOffset(Offset = "0x38")]
			internal static readonly int _History1LumaTex;

			// Token: 0x040003DB RID: 987
			[Token(Token = "0x40003DB")]
			[FieldOffset(Offset = "0x3C")]
			internal static readonly int _History2LumaTex;

			// Token: 0x040003DC RID: 988
			[Token(Token = "0x40003DC")]
			[FieldOffset(Offset = "0x40")]
			internal static readonly int _History3LumaTex;

			// Token: 0x040003DD RID: 989
			[Token(Token = "0x40003DD")]
			[FieldOffset(Offset = "0x44")]
			internal static readonly int _History4LumaTex;

			// Token: 0x040003DE RID: 990
			[Token(Token = "0x40003DE")]
			[FieldOffset(Offset = "0x48")]
			internal static readonly int _History1ChromaTex;

			// Token: 0x040003DF RID: 991
			[Token(Token = "0x40003DF")]
			[FieldOffset(Offset = "0x4C")]
			internal static readonly int _History2ChromaTex;

			// Token: 0x040003E0 RID: 992
			[Token(Token = "0x40003E0")]
			[FieldOffset(Offset = "0x50")]
			internal static readonly int _History3ChromaTex;

			// Token: 0x040003E1 RID: 993
			[Token(Token = "0x40003E1")]
			[FieldOffset(Offset = "0x54")]
			internal static readonly int _History4ChromaTex;

			// Token: 0x040003E2 RID: 994
			[Token(Token = "0x40003E2")]
			[FieldOffset(Offset = "0x58")]
			internal static readonly int _History1Weight;

			// Token: 0x040003E3 RID: 995
			[Token(Token = "0x40003E3")]
			[FieldOffset(Offset = "0x5C")]
			internal static readonly int _History2Weight;

			// Token: 0x040003E4 RID: 996
			[Token(Token = "0x40003E4")]
			[FieldOffset(Offset = "0x60")]
			internal static readonly int _History3Weight;

			// Token: 0x040003E5 RID: 997
			[Token(Token = "0x40003E5")]
			[FieldOffset(Offset = "0x64")]
			internal static readonly int _History4Weight;
		}

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		private enum Pass
		{
			// Token: 0x040003E7 RID: 999
			[Token(Token = "0x40003E7")]
			VelocitySetup,
			// Token: 0x040003E8 RID: 1000
			[Token(Token = "0x40003E8")]
			TileMax1,
			// Token: 0x040003E9 RID: 1001
			[Token(Token = "0x40003E9")]
			TileMax2,
			// Token: 0x040003EA RID: 1002
			[Token(Token = "0x40003EA")]
			TileMaxV,
			// Token: 0x040003EB RID: 1003
			[Token(Token = "0x40003EB")]
			NeighborMax,
			// Token: 0x040003EC RID: 1004
			[Token(Token = "0x40003EC")]
			Reconstruction,
			// Token: 0x040003ED RID: 1005
			[Token(Token = "0x40003ED")]
			FrameCompression,
			// Token: 0x040003EE RID: 1006
			[Token(Token = "0x40003EE")]
			FrameBlendingChroma,
			// Token: 0x040003EF RID: 1007
			[Token(Token = "0x40003EF")]
			FrameBlendingRaw
		}

		// Token: 0x0200009D RID: 157
		[Token(Token = "0x200009D")]
		public class ReconstructionFilter
		{
			// Token: 0x06000323 RID: 803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x542EE40", Offset = "0x542DA40", VA = "0x18542EE40")]
			public ReconstructionFilter()
			{
			}

			// Token: 0x06000324 RID: 804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x542E330", Offset = "0x542CF30", VA = "0x18542E330")]
			private void CheckTextureFormatSupport()
			{
			}

			// Token: 0x06000325 RID: 805 RVA: 0x00003030 File Offset: 0x00001230
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x542E360", Offset = "0x542CF60", VA = "0x18542E360")]
			public bool IsSupported()
			{
				return default(bool);
			}

			// Token: 0x06000326 RID: 806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x542E370", Offset = "0x542CF70", VA = "0x18542E370")]
			public void ProcessImage(PostProcessingContext context, CommandBuffer cb, ref MotionBlurModel.Settings settings, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
			}

			// Token: 0x040003F0 RID: 1008
			[Token(Token = "0x40003F0")]
			[FieldOffset(Offset = "0x10")]
			private RenderTextureFormat m_VectorRTFormat;

			// Token: 0x040003F1 RID: 1009
			[Token(Token = "0x40003F1")]
			[FieldOffset(Offset = "0x14")]
			private RenderTextureFormat m_PackedRTFormat;
		}

		// Token: 0x0200009E RID: 158
		[Token(Token = "0x200009E")]
		public class FrameBlendingFilter
		{
			// Token: 0x06000327 RID: 807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x5424060", Offset = "0x5422C60", VA = "0x185424060")]
			public FrameBlendingFilter()
			{
			}

			// Token: 0x06000328 RID: 808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x5423CC0", Offset = "0x54228C0", VA = "0x185423CC0")]
			public void Dispose()
			{
			}

			// Token: 0x06000329 RID: 809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x5423F40", Offset = "0x5422B40", VA = "0x185423F40")]
			public void PushFrame(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
			{
			}

			// Token: 0x0600032A RID: 810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x54236D0", Offset = "0x54222D0", VA = "0x1854236D0")]
			public void BlendFrames(CommandBuffer cb, float strength, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
			}

			// Token: 0x0600032B RID: 811 RVA: 0x00003048 File Offset: 0x00001248
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x5423C90", Offset = "0x5422890", VA = "0x185423C90")]
			private static bool CheckSupportCompression()
			{
				return default(bool);
			}

			// Token: 0x0600032C RID: 812 RVA: 0x00003060 File Offset: 0x00001260
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x5423E80", Offset = "0x5422A80", VA = "0x185423E80")]
			private static RenderTextureFormat GetPreferredRenderTextureFormat()
			{
				return RenderTextureFormat.ARGB32;
			}

			// Token: 0x0600032D RID: 813 RVA: 0x00003078 File Offset: 0x00001278
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x5423E00", Offset = "0x5422A00", VA = "0x185423E00")]
			private MotionBlurComponent.FrameBlendingFilter.Frame GetFrameRelative(int offset)
			{
				return default(MotionBlurComponent.FrameBlendingFilter.Frame);
			}

			// Token: 0x040003F2 RID: 1010
			[Token(Token = "0x40003F2")]
			[FieldOffset(Offset = "0x10")]
			private bool m_UseCompression;

			// Token: 0x040003F3 RID: 1011
			[Token(Token = "0x40003F3")]
			[FieldOffset(Offset = "0x14")]
			private RenderTextureFormat m_RawTextureFormat;

			// Token: 0x040003F4 RID: 1012
			[Token(Token = "0x40003F4")]
			[FieldOffset(Offset = "0x18")]
			private MotionBlurComponent.FrameBlendingFilter.Frame[] m_FrameList;

			// Token: 0x040003F5 RID: 1013
			[Token(Token = "0x40003F5")]
			[FieldOffset(Offset = "0x20")]
			private int m_LastFrameCount;

			// Token: 0x0200009F RID: 159
			[Token(Token = "0x200009F")]
			private struct Frame
			{
				// Token: 0x0600032E RID: 814 RVA: 0x00003090 File Offset: 0x00001290
				[Token(Token = "0x600032E")]
				[Address(RVA = "0x5424190", Offset = "0x5422D90", VA = "0x185424190")]
				public float CalculateWeight(float strength, float currentTime)
				{
					return 0f;
				}

				// Token: 0x0600032F RID: 815 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600032F")]
				[Address(RVA = "0x5424710", Offset = "0x5423310", VA = "0x185424710")]
				public void Release()
				{
				}

				// Token: 0x06000330 RID: 816 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000330")]
				[Address(RVA = "0x5424400", Offset = "0x5423000", VA = "0x185424400")]
				public void MakeRecord(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
				{
				}

				// Token: 0x06000331 RID: 817 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000331")]
				[Address(RVA = "0x5424280", Offset = "0x5422E80", VA = "0x185424280")]
				public void MakeRecordRaw(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, RenderTextureFormat format)
				{
				}

				// Token: 0x040003F6 RID: 1014
				[Token(Token = "0x40003F6")]
				[FieldOffset(Offset = "0x0")]
				public RenderTexture lumaTexture;

				// Token: 0x040003F7 RID: 1015
				[Token(Token = "0x40003F7")]
				[FieldOffset(Offset = "0x8")]
				public RenderTexture chromaTexture;

				// Token: 0x040003F8 RID: 1016
				[Token(Token = "0x40003F8")]
				[FieldOffset(Offset = "0x10")]
				private float m_Time;

				// Token: 0x040003F9 RID: 1017
				[Token(Token = "0x40003F9")]
				[FieldOffset(Offset = "0x18")]
				private RenderTargetIdentifier[] m_MRT;
			}
		}
	}
}
