using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200423B RID: 16955
	[Token(Token = "0x200423B")]
	public class SandboxV2BackgroundViewCloud : SandboxV2AbstractBackgroundView
	{
		// Token: 0x0601A232 RID: 107058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A232")]
		[Address(RVA = "0x12FE270", Offset = "0x12FCE70", VA = "0x1812FE270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A233 RID: 107059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A233")]
		[Address(RVA = "0x12FDD30", Offset = "0x12FC930", VA = "0x1812FDD30")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601A234 RID: 107060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A234")]
		[Address(RVA = "0x12FDE50", Offset = "0x12FCA50", VA = "0x1812FDE50", Slot = "4")]
		public override void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A235 RID: 107061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A235")]
		[Address(RVA = "0x12FE070", Offset = "0x12FCC70", VA = "0x1812FE070")]
		private HashSet<string> _GetUnlockedZone(SandboxV2DungeonViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0601A236 RID: 107062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A236")]
		[Address(RVA = "0x12FE3B0", Offset = "0x12FCFB0", VA = "0x1812FE3B0")]
		private void _RenderZoneMaskTexture(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A237 RID: 107063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A237")]
		[Address(RVA = "0x12FEA40", Offset = "0x12FD640", VA = "0x1812FEA40")]
		public SandboxV2BackgroundViewCloud()
		{
		}

		// Token: 0x04021014 RID: 135188
		[Token(Token = "0x4021014")]
		private const int RT_WIDTH = 256;

		// Token: 0x04021015 RID: 135189
		[Token(Token = "0x4021015")]
		private const int RT_HEIGHT = 256;

		// Token: 0x04021016 RID: 135190
		[Token(Token = "0x4021016")]
		private const string SHADER_NAME = "Torappu/Unlit/TextureBG";

		// Token: 0x04021017 RID: 135191
		[Token(Token = "0x4021017")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage _imageCloud;

		// Token: 0x04021018 RID: 135192
		[Token(Token = "0x4021018")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _imageSize;

		// Token: 0x04021019 RID: 135193
		[Token(Token = "0x4021019")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_inited;

		// Token: 0x0402101A RID: 135194
		[Token(Token = "0x402101A")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonConstructChecker;

		// Token: 0x0402101B RID: 135195
		[Token(Token = "0x402101B")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<string> m_cachedUnlockedZone;

		// Token: 0x0402101C RID: 135196
		[Token(Token = "0x402101C")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_cloudMaskRT;

		// Token: 0x0402101D RID: 135197
		[Token(Token = "0x402101D")]
		[FieldOffset(Offset = "0x50")]
		private Material m_renderMat;

		// Token: 0x0402101E RID: 135198
		[Token(Token = "0x402101E")]
		[FieldOffset(Offset = "0x58")]
		private Material m_blurMat;

		// Token: 0x0402101F RID: 135199
		[Token(Token = "0x402101F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021020 RID: 135200
		[Token(Token = "0x4021020")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04021021 RID: 135201
		[Token(Token = "0x4021021")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021022 RID: 135202
		[Token(Token = "0x4021022")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetUnlockedZone;

		// Token: 0x04021023 RID: 135203
		[Token(Token = "0x4021023")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderZoneMaskTexture;

		// Token: 0x04021024 RID: 135204
		[Token(Token = "0x4021024")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
