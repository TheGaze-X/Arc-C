using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C4E RID: 15438
	[Token(Token = "0x2003C4E")]
	public class UniEquipUnlockInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018212 RID: 98834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018212")]
		[Address(RVA = "0x109E760", Offset = "0x109D360", VA = "0x18109E760")]
		public void Render(UniEquipUnlockViewModel.InfoData infoData, int level)
		{
		}

		// Token: 0x06018213 RID: 98835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018213")]
		[Address(RVA = "0x109E950", Offset = "0x109D550", VA = "0x18109E950")]
		public void ResetAnim(bool isShow)
		{
		}

		// Token: 0x06018214 RID: 98836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018214")]
		[Address(RVA = "0x109E5D0", Offset = "0x109D1D0", VA = "0x18109E5D0")]
		public void AnimRender(bool isShow)
		{
		}

		// Token: 0x06018215 RID: 98837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018215")]
		[Address(RVA = "0x109E9E0", Offset = "0x109D5E0", VA = "0x18109E9E0")]
		private void _AnimInitIfNot()
		{
		}

		// Token: 0x06018216 RID: 98838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018216")]
		[Address(RVA = "0x109EAF0", Offset = "0x109D6F0", VA = "0x18109EAF0")]
		public UniEquipUnlockInfoItemView()
		{
		}

		// Token: 0x0401D53B RID: 120123
		[Token(Token = "0x401D53B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0401D53C RID: 120124
		[Token(Token = "0x401D53C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommentedText _descText;

		// Token: 0x0401D53D RID: 120125
		[Token(Token = "0x401D53D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animLocation;

		// Token: 0x0401D53E RID: 120126
		[Token(Token = "0x401D53E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _levelImage;

		// Token: 0x0401D53F RID: 120127
		[Token(Token = "0x401D53F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<Sprite> _stageSprites;

		// Token: 0x0401D540 RID: 120128
		[Token(Token = "0x401D540")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _iniLevelImageColor;

		// Token: 0x0401D541 RID: 120129
		[Token(Token = "0x401D541")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _maxLevelImageColor;

		// Token: 0x0401D542 RID: 120130
		[Token(Token = "0x401D542")]
		[FieldOffset(Offset = "0x68")]
		private AnimationSwitchTween m_animSwitchTween;

		// Token: 0x0401D543 RID: 120131
		[Token(Token = "0x401D543")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0401D544 RID: 120132
		[Token(Token = "0x401D544")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D545 RID: 120133
		[Token(Token = "0x401D545")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetAnim;

		// Token: 0x0401D546 RID: 120134
		[Token(Token = "0x401D546")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AnimRender;

		// Token: 0x0401D547 RID: 120135
		[Token(Token = "0x401D547")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AnimInitIfNot;

		// Token: 0x0401D548 RID: 120136
		[Token(Token = "0x401D548")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
