using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200423A RID: 16954
	[Token(Token = "0x200423A")]
	public abstract class SandboxV2AbstractBackgroundView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x0601A22F RID: 107055 RVA: 0x000A0608 File Offset: 0x0009E808
		[Token(Token = "0x17003E26")]
		public SandboxV2DungeonLayerType layerType
		{
			[Token(Token = "0x601A22F")]
			[Address(RVA = "0x12FDCD0", Offset = "0x12FC8D0", VA = "0x1812FDCD0")]
			get
			{
				return SandboxV2DungeonLayerType.LAYER_BACKGROUND;
			}
		}

		// Token: 0x0601A230 RID: 107056
		[Token(Token = "0x601A230")]
		public abstract void Render(SandboxV2DungeonViewModel viewModel);

		// Token: 0x0601A231 RID: 107057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A231")]
		[Address(RVA = "0x12FDC70", Offset = "0x12FC870", VA = "0x1812FDC70")]
		protected SandboxV2AbstractBackgroundView()
		{
		}

		// Token: 0x04021011 RID: 135185
		[Token(Token = "0x4021011")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2DungeonLayerType _layerType;

		// Token: 0x04021012 RID: 135186
		[Token(Token = "0x4021012")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_layerType;

		// Token: 0x04021013 RID: 135187
		[Token(Token = "0x4021013")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
