using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005495 RID: 21653
	[Token(Token = "0x2005495")]
	public class RoguelikeCharCommonSkillItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FDDF RID: 130527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDDF")]
		[Address(RVA = "0x19EF2B0", Offset = "0x19EDEB0", VA = "0x1819EF2B0")]
		public void RenderSkill(RoguelikeCharSelectSkillItemViewModel skillViewModel, bool isSelected, bool iconHighlight, bool enableClick, bool unselectShine = false, bool unlockShine = false)
		{
		}

		// Token: 0x0601FDE0 RID: 130528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDE0")]
		[Address(RVA = "0x19EF910", Offset = "0x19EE510", VA = "0x1819EF910")]
		private void _PlayUnlockedAnim()
		{
		}

		// Token: 0x0601FDE1 RID: 130529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDE1")]
		[Address(RVA = "0x19EFAA0", Offset = "0x19EE6A0", VA = "0x1819EFAA0")]
		private void _PlayUnselectedAnim()
		{
		}

		// Token: 0x0601FDE2 RID: 130530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDE2")]
		[Address(RVA = "0x19EF230", Offset = "0x19EDE30", VA = "0x1819EF230")]
		public void OnClick()
		{
		}

		// Token: 0x0601FDE3 RID: 130531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FDE3")]
		[Address(RVA = "0x19EFC30", Offset = "0x19EE830", VA = "0x1819EFC30")]
		public RoguelikeCharCommonSkillItem()
		{
		}

		// Token: 0x0402AF0B RID: 175883
		[Token(Token = "0x402AF0B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _spriteIcon;

		// Token: 0x0402AF0C RID: 175884
		[Token(Token = "0x402AF0C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x0402AF0D RID: 175885
		[Token(Token = "0x402AF0D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _skillLevelPart;

		// Token: 0x0402AF0E RID: 175886
		[Token(Token = "0x402AF0E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _skillSpecPart;

		// Token: 0x0402AF0F RID: 175887
		[Token(Token = "0x402AF0F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _skillLevel;

		// Token: 0x0402AF10 RID: 175888
		[Token(Token = "0x402AF10")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _skillSpec;

		// Token: 0x0402AF11 RID: 175889
		[Token(Token = "0x402AF11")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _rayCast;

		// Token: 0x0402AF12 RID: 175890
		[Token(Token = "0x402AF12")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _selectedObj;

		// Token: 0x0402AF13 RID: 175891
		[Token(Token = "0x402AF13")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationWrapper _unlockShining;

		// Token: 0x0402AF14 RID: 175892
		[Token(Token = "0x402AF14")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationWrapper _unselectedShining;

		// Token: 0x0402AF15 RID: 175893
		[Token(Token = "0x402AF15")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> onClickSkill;

		// Token: 0x0402AF16 RID: 175894
		[Token(Token = "0x402AF16")]
		[FieldOffset(Offset = "0x70")]
		private string m_cacheSkillId;

		// Token: 0x0402AF17 RID: 175895
		[Token(Token = "0x402AF17")]
		private const string SKILL_SHINE_ANIM_NAME = "skill_shine";

		// Token: 0x0402AF18 RID: 175896
		[Token(Token = "0x402AF18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderSkill;

		// Token: 0x0402AF19 RID: 175897
		[Token(Token = "0x402AF19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayUnlockedAnim;

		// Token: 0x0402AF1A RID: 175898
		[Token(Token = "0x402AF1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayUnselectedAnim;

		// Token: 0x0402AF1B RID: 175899
		[Token(Token = "0x402AF1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402AF1C RID: 175900
		[Token(Token = "0x402AF1C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
