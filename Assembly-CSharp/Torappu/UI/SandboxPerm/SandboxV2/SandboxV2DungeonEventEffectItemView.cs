using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041FB RID: 16891
	[Token(Token = "0x20041FB")]
	public class SandboxV2DungeonEventEffectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A123 RID: 106787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A123")]
		[Address(RVA = "0x12E78A0", Offset = "0x12E64A0", VA = "0x1812E78A0")]
		public void Render(SandboxV2DungeonMiscEventEffectItemViewModel viewModel)
		{
		}

		// Token: 0x0601A124 RID: 106788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A124")]
		[Address(RVA = "0x12E7A30", Offset = "0x12E6630", VA = "0x1812E7A30")]
		public SandboxV2DungeonEventEffectItemView()
		{
		}

		// Token: 0x04020D6F RID: 134511
		[Token(Token = "0x4020D6F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _remainDay;

		// Token: 0x04020D70 RID: 134512
		[Token(Token = "0x4020D70")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04020D71 RID: 134513
		[Token(Token = "0x4020D71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _normalColor;

		// Token: 0x04020D72 RID: 134514
		[Token(Token = "0x4020D72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _lastColor;

		// Token: 0x04020D73 RID: 134515
		[Token(Token = "0x4020D73")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2DungeonMiscEventEffectItemViewModel m_cachedViewModel;

		// Token: 0x04020D74 RID: 134516
		[Token(Token = "0x4020D74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020D75 RID: 134517
		[Token(Token = "0x4020D75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
