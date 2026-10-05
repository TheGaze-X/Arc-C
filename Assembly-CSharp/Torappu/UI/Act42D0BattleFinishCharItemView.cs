using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200345A RID: 13402
	[Token(Token = "0x200345A")]
	public class Act42D0BattleFinishCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015684 RID: 87684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015684")]
		[Address(RVA = "0xDDD380", Offset = "0xDDBF80", VA = "0x180DDD380")]
		public void Render(SquadItemStruct charStruct, bool isAssist)
		{
		}

		// Token: 0x06015685 RID: 87685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015685")]
		[Address(RVA = "0xDDD890", Offset = "0xDDC490", VA = "0x180DDD890")]
		private void _RenderSkill(CharacterCardViewModel cardModel)
		{
		}

		// Token: 0x06015686 RID: 87686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015686")]
		[Address(RVA = "0xDDDAB0", Offset = "0xDDC6B0", VA = "0x180DDDAB0")]
		public Act42D0BattleFinishCharItemView()
		{
		}

		// Token: 0x040199F8 RID: 104952
		[Token(Token = "0x40199F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x040199F9 RID: 104953
		[Token(Token = "0x40199F9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _charPanel;

		// Token: 0x040199FA RID: 104954
		[Token(Token = "0x40199FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalCharBgGo;

		// Token: 0x040199FB RID: 104955
		[Token(Token = "0x40199FB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _assistCharBgGo;

		// Token: 0x040199FC RID: 104956
		[Token(Token = "0x40199FC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgPortrait;

		// Token: 0x040199FD RID: 104957
		[Token(Token = "0x40199FD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelSkill;

		// Token: 0x040199FE RID: 104958
		[Token(Token = "0x40199FE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgSkill;

		// Token: 0x040199FF RID: 104959
		[Token(Token = "0x40199FF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textSkillLevel;

		// Token: 0x04019A00 RID: 104960
		[Token(Token = "0x4019A00")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgSkillSpecializeLv;

		// Token: 0x04019A01 RID: 104961
		[Token(Token = "0x4019A01")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgEvolve;

		// Token: 0x04019A02 RID: 104962
		[Token(Token = "0x4019A02")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x04019A03 RID: 104963
		[Token(Token = "0x4019A03")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtLv;

		// Token: 0x04019A04 RID: 104964
		[Token(Token = "0x4019A04")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgPotential;

		// Token: 0x04019A05 RID: 104965
		[Token(Token = "0x4019A05")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelPotential;

		// Token: 0x04019A06 RID: 104966
		[Token(Token = "0x4019A06")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelEquip;

		// Token: 0x04019A07 RID: 104967
		[Token(Token = "0x4019A07")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelEquipEmpty;

		// Token: 0x04019A08 RID: 104968
		[Token(Token = "0x4019A08")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imgEquip;

		// Token: 0x04019A09 RID: 104969
		[Token(Token = "0x4019A09")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _equipLvGo;

		// Token: 0x04019A0A RID: 104970
		[Token(Token = "0x4019A0A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textEquipLv;

		// Token: 0x04019A0B RID: 104971
		[Token(Token = "0x4019A0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04019A0C RID: 104972
		[Token(Token = "0x4019A0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSkill;

		// Token: 0x04019A0D RID: 104973
		[Token(Token = "0x4019A0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
