using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005928 RID: 22824
	[Token(Token = "0x2005928")]
	public class CrisisV2SettleCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021403 RID: 136195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021403")]
		[Address(RVA = "0x1B92FD0", Offset = "0x1B91BD0", VA = "0x181B92FD0")]
		public void Render(CharacterCardViewModel viewModel, bool isAssist)
		{
		}

		// Token: 0x06021404 RID: 136196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021404")]
		[Address(RVA = "0x1B92E20", Offset = "0x1B91A20", VA = "0x181B92E20")]
		public void RenderNoDetailCharacter(CrisisV2SettleViewModel.SquadSkinInfo skinInfo, bool isAssist)
		{
		}

		// Token: 0x06021405 RID: 136197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021405")]
		[Address(RVA = "0x1B93640", Offset = "0x1B92240", VA = "0x181B93640")]
		public CrisisV2SettleCardView()
		{
		}

		// Token: 0x0402D4CC RID: 185548
		[Token(Token = "0x402D4CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imagePortrait;

		// Token: 0x0402D4CD RID: 185549
		[Token(Token = "0x402D4CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelGradientNoInfo;

		// Token: 0x0402D4CE RID: 185550
		[Token(Token = "0x402D4CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelGradientNormal;

		// Token: 0x0402D4CF RID: 185551
		[Token(Token = "0x402D4CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelInfo;

		// Token: 0x0402D4D0 RID: 185552
		[Token(Token = "0x402D4D0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objAssist;

		// Token: 0x0402D4D1 RID: 185553
		[Token(Token = "0x402D4D1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelSkill;

		// Token: 0x0402D4D2 RID: 185554
		[Token(Token = "0x402D4D2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgSkill;

		// Token: 0x0402D4D3 RID: 185555
		[Token(Token = "0x402D4D3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textSkillLevel;

		// Token: 0x0402D4D4 RID: 185556
		[Token(Token = "0x402D4D4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgSkillSpecializeLv;

		// Token: 0x0402D4D5 RID: 185557
		[Token(Token = "0x402D4D5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelNoSkill;

		// Token: 0x0402D4D6 RID: 185558
		[Token(Token = "0x402D4D6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgEvolve;

		// Token: 0x0402D4D7 RID: 185559
		[Token(Token = "0x402D4D7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtLv;

		// Token: 0x0402D4D8 RID: 185560
		[Token(Token = "0x402D4D8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgPotential;

		// Token: 0x0402D4D9 RID: 185561
		[Token(Token = "0x402D4D9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelPotential;

		// Token: 0x0402D4DA RID: 185562
		[Token(Token = "0x402D4DA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelEquip;

		// Token: 0x0402D4DB RID: 185563
		[Token(Token = "0x402D4DB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelEquipEmpty;

		// Token: 0x0402D4DC RID: 185564
		[Token(Token = "0x402D4DC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imgEquip;

		// Token: 0x0402D4DD RID: 185565
		[Token(Token = "0x402D4DD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _equipLvGo;

		// Token: 0x0402D4DE RID: 185566
		[Token(Token = "0x402D4DE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textEquipLv;

		// Token: 0x0402D4DF RID: 185567
		[Token(Token = "0x402D4DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D4E0 RID: 185568
		[Token(Token = "0x402D4E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderNoDetailCharacter;

		// Token: 0x0402D4E1 RID: 185569
		[Token(Token = "0x402D4E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
