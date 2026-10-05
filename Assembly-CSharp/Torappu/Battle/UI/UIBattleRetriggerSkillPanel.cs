using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032FD RID: 13053
	[Token(Token = "0x20032FD")]
	public class UIBattleRetriggerSkillPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014BC2 RID: 84930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BC2")]
		[Address(RVA = "0xD21C40", Offset = "0xD20840", VA = "0x180D21C40")]
		public void SetData(Character character)
		{
		}

		// Token: 0x06014BC3 RID: 84931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BC3")]
		[Address(RVA = "0xD21A60", Offset = "0xD20660", VA = "0x180D21A60")]
		public void OnUpdate(Character character)
		{
		}

		// Token: 0x06014BC4 RID: 84932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BC4")]
		[Address(RVA = "0xD219F0", Offset = "0xD205F0", VA = "0x180D219F0")]
		public void Hide()
		{
		}

		// Token: 0x06014BC5 RID: 84933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BC5")]
		[Address(RVA = "0xD21E10", Offset = "0xD20A10", VA = "0x180D21E10")]
		public UIBattleRetriggerSkillPanel()
		{
		}

		// Token: 0x04018A56 RID: 100950
		[Token(Token = "0x4018A56")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _root;

		// Token: 0x04018A57 RID: 100951
		[Token(Token = "0x4018A57")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _retriggerIcon;

		// Token: 0x04018A58 RID: 100952
		[Token(Token = "0x4018A58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _costRetriggerSprite;

		// Token: 0x04018A59 RID: 100953
		[Token(Token = "0x4018A59")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _freeRetriggerSprite;

		// Token: 0x04018A5A RID: 100954
		[Token(Token = "0x4018A5A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIButton _retriggerButton;

		// Token: 0x04018A5B RID: 100955
		[Token(Token = "0x4018A5B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _cooldownProgressSlider;

		// Token: 0x04018A5C RID: 100956
		[Token(Token = "0x4018A5C")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isValid;

		// Token: 0x04018A5D RID: 100957
		[Token(Token = "0x4018A5D")]
		[FieldOffset(Offset = "0x50")]
		private RetriggerableCastSkillWithCost m_skill;

		// Token: 0x04018A5E RID: 100958
		[Token(Token = "0x4018A5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018A5F RID: 100959
		[Token(Token = "0x4018A5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04018A60 RID: 100960
		[Token(Token = "0x4018A60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04018A61 RID: 100961
		[Token(Token = "0x4018A61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
