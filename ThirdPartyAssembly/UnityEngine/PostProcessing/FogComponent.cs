using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x1700003E")]
		public override bool active
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x5423630", Offset = "0x5422230", VA = "0x185423630", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x5423140", Offset = "0x5421D40", VA = "0x185423140", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x5423170", Offset = "0x5421D70", VA = "0x185423170", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x54235F0", Offset = "0x54221F0", VA = "0x1854235F0")]
		public FogComponent()
		{
		}

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		private const string k_ShaderString = "Hidden/Post FX/Fog";

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		private static class Uniforms
		{
			// Token: 0x040003BD RID: 957
			[Token(Token = "0x40003BD")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _FogColor;

			// Token: 0x040003BE RID: 958
			[Token(Token = "0x40003BE")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Density;

			// Token: 0x040003BF RID: 959
			[Token(Token = "0x40003BF")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Start;

			// Token: 0x040003C0 RID: 960
			[Token(Token = "0x40003C0")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _End;

			// Token: 0x040003C1 RID: 961
			[Token(Token = "0x40003C1")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _TempRT;
		}
	}
}
