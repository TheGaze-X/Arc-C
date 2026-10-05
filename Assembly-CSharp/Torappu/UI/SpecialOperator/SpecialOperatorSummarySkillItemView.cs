using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterShow;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E6A RID: 15978
	[Token(Token = "0x2003E6A")]
	public class SpecialOperatorSummarySkillItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018D7F RID: 101759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D7F")]
		[Address(RVA = "0x117CE50", Offset = "0x117BA50", VA = "0x18117CE50")]
		public void Render(CharacterShowSkillModel skillModel)
		{
		}

		// Token: 0x06018D80 RID: 101760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D80")]
		[Address(RVA = "0x117D020", Offset = "0x117BC20", VA = "0x18117D020")]
		public SpecialOperatorSummarySkillItemView()
		{
		}

		// Token: 0x0401E8F5 RID: 125173
		[Token(Token = "0x401E8F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPartGO;

		// Token: 0x0401E8F6 RID: 125174
		[Token(Token = "0x401E8F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _activePartGO;

		// Token: 0x0401E8F7 RID: 125175
		[Token(Token = "0x401E8F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _skillAlphaHandler;

		// Token: 0x0401E8F8 RID: 125176
		[Token(Token = "0x401E8F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _alphaSkillLock;

		// Token: 0x0401E8F9 RID: 125177
		[Token(Token = "0x401E8F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgSkillIcon;

		// Token: 0x0401E8FA RID: 125178
		[Token(Token = "0x401E8FA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _skillLvGO;

		// Token: 0x0401E8FB RID: 125179
		[Token(Token = "0x401E8FB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textMainLv;

		// Token: 0x0401E8FC RID: 125180
		[Token(Token = "0x401E8FC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgSpecLv;

		// Token: 0x0401E8FD RID: 125181
		[Token(Token = "0x401E8FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E8FE RID: 125182
		[Token(Token = "0x401E8FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
