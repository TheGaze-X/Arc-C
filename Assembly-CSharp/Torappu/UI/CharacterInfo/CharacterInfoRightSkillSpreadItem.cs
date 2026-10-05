using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FAD RID: 24493
	[Token(Token = "0x2005FAD")]
	public class CharacterInfoRightSkillSpreadItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060236E7 RID: 145127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236E7")]
		[Address(RVA = "0x1E08EB0", Offset = "0x1E07AB0", VA = "0x181E08EB0")]
		public void Render(SkillItemViewModel viewModel, int index, bool isSelected, bool cacheSelect)
		{
		}

		// Token: 0x060236E8 RID: 145128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236E8")]
		[Address(RVA = "0x1E08E30", Offset = "0x1E07A30", VA = "0x181E08E30")]
		public void EventOnToggleButtonClick()
		{
		}

		// Token: 0x060236E9 RID: 145129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236E9")]
		[Address(RVA = "0x1E08FC0", Offset = "0x1E07BC0", VA = "0x181E08FC0")]
		public CharacterInfoRightSkillSpreadItem()
		{
		}

		// Token: 0x04030F75 RID: 200565
		[Token(Token = "0x4030F75")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected CharacterInfoSkillIconView _skillView;

		// Token: 0x04030F76 RID: 200566
		[Token(Token = "0x4030F76")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _alphaGroup;

		// Token: 0x04030F77 RID: 200567
		[Token(Token = "0x4030F77")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _onSelected;

		// Token: 0x04030F78 RID: 200568
		[Token(Token = "0x4030F78")]
		[FieldOffset(Offset = "0x30")]
		protected SkillItemViewModel m_cacheViewModel;

		// Token: 0x04030F79 RID: 200569
		[Token(Token = "0x4030F79")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<string> onToggleClick;

		// Token: 0x04030F7A RID: 200570
		[Token(Token = "0x4030F7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030F7B RID: 200571
		[Token(Token = "0x4030F7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnToggleButtonClick;

		// Token: 0x04030F7C RID: 200572
		[Token(Token = "0x4030F7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
