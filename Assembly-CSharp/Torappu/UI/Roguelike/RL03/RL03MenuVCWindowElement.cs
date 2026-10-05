using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005838 RID: 22584
	[Token(Token = "0x2005838")]
	public abstract class RL03MenuVCWindowElement : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004D72 RID: 19826
		// (get) Token: 0x06021022 RID: 135202 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021023 RID: 135203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D72")]
		private protected ILoadAsset loader
		{
			[Token(Token = "0x6021022")]
			[Address(RVA = "0x1B4BDC0", Offset = "0x1B4A9C0", VA = "0x181B4BDC0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6021023")]
			[Address(RVA = "0x1B4BE20", Offset = "0x1B4AA20", VA = "0x181B4BE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06021024 RID: 135204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021024")]
		[Address(RVA = "0x1B4BC80", Offset = "0x1B4A880", VA = "0x181B4BC80")]
		public void Bind(RL03MenuVisionAndChaosWindow win)
		{
		}

		// Token: 0x06021025 RID: 135205
		[Token(Token = "0x6021025")]
		public abstract void Render(RL03MenuVisionAndChaosViewModel.VCWindowViewModel model);

		// Token: 0x06021026 RID: 135206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021026")]
		[Address(RVA = "0x1B4BD60", Offset = "0x1B4A960", VA = "0x181B4BD60")]
		protected RL03MenuVCWindowElement()
		{
		}

		// Token: 0x0402CE3B RID: 183867
		[Token(Token = "0x402CE3B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x0402CE3C RID: 183868
		[Token(Token = "0x402CE3C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x0402CE3D RID: 183869
		[Token(Token = "0x402CE3D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x0402CE3E RID: 183870
		[Token(Token = "0x402CE3E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
