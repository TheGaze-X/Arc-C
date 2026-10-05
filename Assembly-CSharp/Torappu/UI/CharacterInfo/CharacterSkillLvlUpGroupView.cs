using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FBB RID: 24507
	[Token(Token = "0x2005FBB")]
	public class CharacterSkillLvlUpGroupView : DataBinder<SkillGroupViewProperty>
	{
		// Token: 0x0602371D RID: 145181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602371D")]
		[Address(RVA = "0x1E23C50", Offset = "0x1E22850", VA = "0x181E23C50")]
		public void ChangeState(bool upFlag)
		{
		}

		// Token: 0x0602371E RID: 145182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602371E")]
		[Address(RVA = "0x1E241D0", Offset = "0x1E22DD0", VA = "0x181E241D0")]
		public void SetAsFirstSibling()
		{
		}

		// Token: 0x0602371F RID: 145183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602371F")]
		[Address(RVA = "0x1E24240", Offset = "0x1E22E40", VA = "0x181E24240")]
		public void SetAsLastSibling()
		{
		}

		// Token: 0x06023720 RID: 145184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023720")]
		[Address(RVA = "0x1E24340", Offset = "0x1E22F40", VA = "0x181E24340")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023721 RID: 145185 RVA: 0x000C0E70 File Offset: 0x000BF070
		[Token(Token = "0x6023721")]
		[Address(RVA = "0x1E24490", Offset = "0x1E23090", VA = "0x181E24490")]
		private bool _TrySwitchAnimator(bool upFlag)
		{
			return default(bool);
		}

		// Token: 0x06023722 RID: 145186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023722")]
		[Address(RVA = "0x1E23D70", Offset = "0x1E22970", VA = "0x181E23D70", Slot = "7")]
		public override void OnValueChanged(SkillGroupViewProperty property)
		{
		}

		// Token: 0x06023723 RID: 145187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023723")]
		[Address(RVA = "0x1E243C0", Offset = "0x1E22FC0", VA = "0x181E243C0")]
		private void _RenderSkillViewCommentText(bool isDownState)
		{
		}

		// Token: 0x06023724 RID: 145188 RVA: 0x000C0E88 File Offset: 0x000BF088
		[Token(Token = "0x6023724")]
		[Address(RVA = "0x1E242B0", Offset = "0x1E22EB0", VA = "0x181E242B0")]
		private int _GetSkillOffset(bool isSpOp)
		{
			return 0;
		}

		// Token: 0x06023725 RID: 145189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023725")]
		[Address(RVA = "0x1E245A0", Offset = "0x1E231A0", VA = "0x181E245A0")]
		public CharacterSkillLvlUpGroupView()
		{
		}

		// Token: 0x0403102E RID: 200750
		[Token(Token = "0x403102E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0403102F RID: 200751
		[Token(Token = "0x403102F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool up;

		// Token: 0x04031030 RID: 200752
		[Token(Token = "0x4031030")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterInfoSkillView[] _skillViews;

		// Token: 0x04031031 RID: 200753
		[Token(Token = "0x4031031")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _skillLvlBack;

		// Token: 0x04031032 RID: 200754
		[Token(Token = "0x4031032")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _skillLvl20;

		// Token: 0x04031033 RID: 200755
		[Token(Token = "0x4031033")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _skillLvl80;

		// Token: 0x04031034 RID: 200756
		[Token(Token = "0x4031034")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image[] _skillLvlBackAlpha;

		// Token: 0x04031035 RID: 200757
		[Token(Token = "0x4031035")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isTrasiting;

		// Token: 0x04031036 RID: 200758
		[Token(Token = "0x4031036")]
		[FieldOffset(Offset = "0x59")]
		private bool m_cachedDownFlag;

		// Token: 0x04031037 RID: 200759
		[Token(Token = "0x4031037")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_inited;

		// Token: 0x04031038 RID: 200760
		[Token(Token = "0x4031038")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ChangeState;

		// Token: 0x04031039 RID: 200761
		[Token(Token = "0x4031039")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetAsFirstSibling;

		// Token: 0x0403103A RID: 200762
		[Token(Token = "0x403103A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetAsLastSibling;

		// Token: 0x0403103B RID: 200763
		[Token(Token = "0x403103B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403103C RID: 200764
		[Token(Token = "0x403103C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TrySwitchAnimator;

		// Token: 0x0403103D RID: 200765
		[Token(Token = "0x403103D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403103E RID: 200766
		[Token(Token = "0x403103E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderSkillViewCommentText;

		// Token: 0x0403103F RID: 200767
		[Token(Token = "0x403103F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetSkillOffset;

		// Token: 0x04031040 RID: 200768
		[Token(Token = "0x4031040")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
