using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006378 RID: 25464
	[Token(Token = "0x2006378")]
	public class AutoChessCharCardSkillSelectItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056BC RID: 22204
		// (get) Token: 0x06024BCA RID: 150474 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024BCB RID: 150475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056BC")]
		public Action<string, int, string> onSkillSelect
		{
			[Token(Token = "0x6024BCA")]
			[Address(RVA = "0x1F97A80", Offset = "0x1F96680", VA = "0x181F97A80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024BCB")]
			[Address(RVA = "0x1F97AE0", Offset = "0x1F966E0", VA = "0x181F97AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024BCC RID: 150476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BCC")]
		[Address(RVA = "0x1F977C0", Offset = "0x1F963C0", VA = "0x181F977C0")]
		public void Render(string chessId, int chessLv, bool isSelect, SkillItemViewModel skillModel)
		{
		}

		// Token: 0x06024BCD RID: 150477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BCD")]
		[Address(RVA = "0x1F97690", Offset = "0x1F96290", VA = "0x181F97690")]
		public void OnSkillSelect()
		{
		}

		// Token: 0x06024BCE RID: 150478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BCE")]
		[Address(RVA = "0x1F97A10", Offset = "0x1F96610", VA = "0x181F97A10")]
		public AutoChessCharCardSkillSelectItem()
		{
		}

		// Token: 0x040334F7 RID: 210167
		[Token(Token = "0x40334F7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectBgGo;

		// Token: 0x040334F8 RID: 210168
		[Token(Token = "0x40334F8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _iconSelectGo;

		// Token: 0x040334F9 RID: 210169
		[Token(Token = "0x40334F9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x040334FA RID: 210170
		[Token(Token = "0x40334FA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x040334FB RID: 210171
		[Token(Token = "0x40334FB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockPartGo;

		// Token: 0x040334FC RID: 210172
		[Token(Token = "0x40334FC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgSkill;

		// Token: 0x040334FD RID: 210173
		[Token(Token = "0x40334FD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textSkillLv;

		// Token: 0x040334FE RID: 210174
		[Token(Token = "0x40334FE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgSpecializeLv;

		// Token: 0x040334FF RID: 210175
		[Token(Token = "0x40334FF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Sprite[] _skillLevelImages;

		// Token: 0x04033500 RID: 210176
		[Token(Token = "0x4033500")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04033501 RID: 210177
		[Token(Token = "0x4033501")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _unselectAlpha;

		// Token: 0x04033502 RID: 210178
		[Token(Token = "0x4033502")]
		[FieldOffset(Offset = "0x70")]
		private string m_chessId;

		// Token: 0x04033503 RID: 210179
		[Token(Token = "0x4033503")]
		[FieldOffset(Offset = "0x78")]
		private int m_chessLv;

		// Token: 0x04033504 RID: 210180
		[Token(Token = "0x4033504")]
		[FieldOffset(Offset = "0x80")]
		private SkillItemViewModel m_skillModel;

		// Token: 0x04033506 RID: 210182
		[Token(Token = "0x4033506")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSkillSelect;

		// Token: 0x04033507 RID: 210183
		[Token(Token = "0x4033507")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSkillSelect;

		// Token: 0x04033508 RID: 210184
		[Token(Token = "0x4033508")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033509 RID: 210185
		[Token(Token = "0x4033509")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSkillSelect;

		// Token: 0x0403350A RID: 210186
		[Token(Token = "0x403350A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
