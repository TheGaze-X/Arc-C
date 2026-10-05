using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060FE RID: 24830
	[Token(Token = "0x20060FE")]
	public class CampaignWorldStageView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023E2B RID: 146987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E2B")]
		[Address(RVA = "0x1E8EC00", Offset = "0x1E8D800", VA = "0x181E8EC00")]
		public void Render(CampaignWorldStageViewModel viewModel)
		{
		}

		// Token: 0x06023E2C RID: 146988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E2C")]
		[Address(RVA = "0x1E8EE70", Offset = "0x1E8DA70", VA = "0x181E8EE70")]
		public CampaignWorldStageView()
		{
		}

		// Token: 0x04031C77 RID: 203895
		[Token(Token = "0x4031C77")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Settings")]
		private Sprite _spriteBkgPermanent;

		// Token: 0x04031C78 RID: 203896
		[Token(Token = "0x4031C78")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Settings")]
		private Sprite _spriteBkgRotate;

		// Token: 0x04031C79 RID: 203897
		[Token(Token = "0x4031C79")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Settings")]
		private Sprite _spriteBkgTraining;

		// Token: 0x04031C7A RID: 203898
		[Token(Token = "0x4031C7A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Settings")]
		private Sprite _spriteBkgClosed;

		// Token: 0x04031C7B RID: 203899
		[Token(Token = "0x4031C7B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Settings")]
		private Sprite _spriteBkgLocked;

		// Token: 0x04031C7C RID: 203900
		[Token(Token = "0x4031C7C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x04031C7D RID: 203901
		[Token(Token = "0x4031C7D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x04031C7E RID: 203902
		[Token(Token = "0x4031C7E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imageRotate;

		// Token: 0x04031C7F RID: 203903
		[Token(Token = "0x4031C7F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imageBattle;

		// Token: 0x04031C80 RID: 203904
		[Token(Token = "0x4031C80")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imageBattleInactive;

		// Token: 0x04031C81 RID: 203905
		[Token(Token = "0x4031C81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031C82 RID: 203906
		[Token(Token = "0x4031C82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
