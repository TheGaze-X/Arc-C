using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200420D RID: 16909
	[Token(Token = "0x200420D")]
	public class SandboxV2TopBarRiftEffectsView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A16A RID: 106858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A16A")]
		[Address(RVA = "0x12F89C0", Offset = "0x12F75C0", VA = "0x1812F89C0")]
		public void Render(SandboxV2DungeonMiscRiftViewModel viewModel)
		{
		}

		// Token: 0x0601A16B RID: 106859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A16B")]
		[Address(RVA = "0x12F8B70", Offset = "0x12F7770", VA = "0x1812F8B70")]
		public SandboxV2TopBarRiftEffectsView()
		{
		}

		// Token: 0x04020E2B RID: 134699
		[Token(Token = "0x4020E2B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objGlobalEffect;

		// Token: 0x04020E2C RID: 134700
		[Token(Token = "0x4020E2C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtGlobalEffectTitle;

		// Token: 0x04020E2D RID: 134701
		[Token(Token = "0x4020E2D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objDifficulty;

		// Token: 0x04020E2E RID: 134702
		[Token(Token = "0x4020E2E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtDifficultyTitle;

		// Token: 0x04020E2F RID: 134703
		[Token(Token = "0x4020E2F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtDifficultyLv;

		// Token: 0x04020E30 RID: 134704
		[Token(Token = "0x4020E30")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objTeam;

		// Token: 0x04020E31 RID: 134705
		[Token(Token = "0x4020E31")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtTeamTitle;

		// Token: 0x04020E32 RID: 134706
		[Token(Token = "0x4020E32")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtTeamLv;

		// Token: 0x04020E33 RID: 134707
		[Token(Token = "0x4020E33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020E34 RID: 134708
		[Token(Token = "0x4020E34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
