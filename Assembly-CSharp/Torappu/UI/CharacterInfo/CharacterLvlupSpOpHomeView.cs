using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F67 RID: 24423
	[Token(Token = "0x2005F67")]
	public class CharacterLvlupSpOpHomeView : DataBinder<SpecialOperatorInfoViewProperty>
	{
		// Token: 0x060235C0 RID: 144832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235C0")]
		[Address(RVA = "0x1E0CED0", Offset = "0x1E0BAD0", VA = "0x181E0CED0", Slot = "7")]
		public override void OnValueChanged(SpecialOperatorInfoViewProperty property)
		{
		}

		// Token: 0x060235C1 RID: 144833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235C1")]
		[Address(RVA = "0x1E0CE40", Offset = "0x1E0BA40", VA = "0x181E0CE40")]
		public void OnTargetModeClicked()
		{
		}

		// Token: 0x060235C2 RID: 144834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235C2")]
		[Address(RVA = "0x1E0CDB0", Offset = "0x1E0B9B0", VA = "0x181E0CDB0")]
		public void OnSpOpMissionClicked()
		{
		}

		// Token: 0x060235C3 RID: 144835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235C3")]
		[Address(RVA = "0x1E0D120", Offset = "0x1E0BD20", VA = "0x181E0D120")]
		private void _RenderCampLogo(string powerId)
		{
		}

		// Token: 0x060235C4 RID: 144836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235C4")]
		[Address(RVA = "0x1E0D310", Offset = "0x1E0BF10", VA = "0x181E0D310")]
		public CharacterLvlupSpOpHomeView()
		{
		}

		// Token: 0x04030D1D RID: 199965
		[Token(Token = "0x4030D1D")]
		private const string MAX_LVL_FORMAT = "/{0}";

		// Token: 0x04030D1E RID: 199966
		[Token(Token = "0x4030D1E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgCampLogo;

		// Token: 0x04030D1F RID: 199967
		[Token(Token = "0x4030D1F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgCurProgress;

		// Token: 0x04030D20 RID: 199968
		[Token(Token = "0x4030D20")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _curLvlText;

		// Token: 0x04030D21 RID: 199969
		[Token(Token = "0x4030D21")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _maxLvlText;

		// Token: 0x04030D22 RID: 199970
		[Token(Token = "0x4030D22")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgTargetTypeIcon;

		// Token: 0x04030D23 RID: 199971
		[Token(Token = "0x4030D23")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _targetBtnText;

		// Token: 0x04030D24 RID: 199972
		[Token(Token = "0x4030D24")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedTypeIcon;

		// Token: 0x04030D25 RID: 199973
		[Token(Token = "0x4030D25")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04030D26 RID: 199974
		[Token(Token = "0x4030D26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030D27 RID: 199975
		[Token(Token = "0x4030D27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTargetModeClicked;

		// Token: 0x04030D28 RID: 199976
		[Token(Token = "0x4030D28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSpOpMissionClicked;

		// Token: 0x04030D29 RID: 199977
		[Token(Token = "0x4030D29")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCampLogo;

		// Token: 0x04030D2A RID: 199978
		[Token(Token = "0x4030D2A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
