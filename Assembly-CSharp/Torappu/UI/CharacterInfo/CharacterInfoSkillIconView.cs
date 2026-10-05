using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FB4 RID: 24500
	[Token(Token = "0x2005FB4")]
	public class CharacterInfoSkillIconView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023707 RID: 145159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023707")]
		[Address(RVA = "0x1E1FD00", Offset = "0x1E1E900", VA = "0x181E1FD00")]
		public void Render(SkillItemViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x06023708 RID: 145160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023708")]
		[Address(RVA = "0x1E1FF90", Offset = "0x1E1EB90", VA = "0x181E1FF90")]
		public CharacterInfoSkillIconView()
		{
		}

		// Token: 0x04030FD9 RID: 200665
		[Token(Token = "0x4030FD9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEnable;

		// Token: 0x04030FDA RID: 200666
		[Token(Token = "0x4030FDA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04030FDB RID: 200667
		[Token(Token = "0x4030FDB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Empty would be shown if the slot has not skill")]
		private GameObject _panelEmpty;

		// Token: 0x04030FDC RID: 200668
		[Token(Token = "0x4030FDC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectFrame;

		// Token: 0x04030FDD RID: 200669
		[Token(Token = "0x4030FDD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageSkill;

		// Token: 0x04030FDE RID: 200670
		[Token(Token = "0x4030FDE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x04030FDF RID: 200671
		[Token(Token = "0x4030FDF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textInit;

		// Token: 0x04030FE0 RID: 200672
		[Token(Token = "0x4030FE0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04030FE1 RID: 200673
		[Token(Token = "0x4030FE1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _skillCost;

		// Token: 0x04030FE2 RID: 200674
		[Token(Token = "0x4030FE2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _skillInit;

		// Token: 0x04030FE3 RID: 200675
		[Token(Token = "0x4030FE3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _skillLevelIcon;

		// Token: 0x04030FE4 RID: 200676
		[Token(Token = "0x4030FE4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Sprite[] _levelIconList;

		// Token: 0x04030FE5 RID: 200677
		[Token(Token = "0x4030FE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030FE6 RID: 200678
		[Token(Token = "0x4030FE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
