using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004208 RID: 16904
	[Token(Token = "0x2004208")]
	public class SandboxV2DungeonRiftEffectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A14C RID: 106828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A14C")]
		[Address(RVA = "0x12F2910", Offset = "0x12F1510", VA = "0x1812F2910")]
		public void Render(SandboxV2DungeonMiscRiftViewModel viewModel)
		{
		}

		// Token: 0x0601A14D RID: 106829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A14D")]
		[Address(RVA = "0x12F2B90", Offset = "0x12F1790", VA = "0x1812F2B90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A14E RID: 106830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A14E")]
		[Address(RVA = "0x12F2CB0", Offset = "0x12F18B0", VA = "0x1812F2CB0")]
		public SandboxV2DungeonRiftEffectView()
		{
		}

		// Token: 0x04020DDD RID: 134621
		[Token(Token = "0x4020DDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objGlobalEffects;

		// Token: 0x04020DDE RID: 134622
		[Token(Token = "0x4020DDE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtGlobalEffectTitle;

		// Token: 0x04020DDF RID: 134623
		[Token(Token = "0x4020DDF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtGlobalEffectDesc;

		// Token: 0x04020DE0 RID: 134624
		[Token(Token = "0x4020DE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objDifficulty;

		// Token: 0x04020DE1 RID: 134625
		[Token(Token = "0x4020DE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtDifficultyTitle;

		// Token: 0x04020DE2 RID: 134626
		[Token(Token = "0x4020DE2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtDifficultyLv;

		// Token: 0x04020DE3 RID: 134627
		[Token(Token = "0x4020DE3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtDifficultyDesc;

		// Token: 0x04020DE4 RID: 134628
		[Token(Token = "0x4020DE4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objTeam;

		// Token: 0x04020DE5 RID: 134629
		[Token(Token = "0x4020DE5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtTeamTitle;

		// Token: 0x04020DE6 RID: 134630
		[Token(Token = "0x4020DE6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _txtTeamLv;

		// Token: 0x04020DE7 RID: 134631
		[Token(Token = "0x4020DE7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtTeamDesc;

		// Token: 0x04020DE8 RID: 134632
		[Token(Token = "0x4020DE8")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x04020DE9 RID: 134633
		[Token(Token = "0x4020DE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020DEA RID: 134634
		[Token(Token = "0x4020DEA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020DEB RID: 134635
		[Token(Token = "0x4020DEB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
