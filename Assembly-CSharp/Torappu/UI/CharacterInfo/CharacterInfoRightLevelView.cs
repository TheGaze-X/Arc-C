using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F98 RID: 24472
	[Token(Token = "0x2005F98")]
	public class CharacterInfoRightLevelView : CharacterInfoCommonObj, IHotfixable
	{
		// Token: 0x06023680 RID: 145024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023680")]
		[Address(RVA = "0x1E05110", Offset = "0x1E03D10", VA = "0x181E05110", Slot = "6")]
		public override void AllHide()
		{
		}

		// Token: 0x06023681 RID: 145025 RVA: 0x000C0BD0 File Offset: 0x000BEDD0
		[Token(Token = "0x6023681")]
		[Address(RVA = "0x1E05220", Offset = "0x1E03E20", VA = "0x181E05220", Slot = "4")]
		public override float GetHeight()
		{
			return 0f;
		}

		// Token: 0x06023682 RID: 145026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023682")]
		[Address(RVA = "0x1E051A0", Offset = "0x1E03DA0", VA = "0x181E051A0", Slot = "5")]
		public override void ApplyViewModel(CharacterInfoHolderBean.CharViewModel charViewModel)
		{
		}

		// Token: 0x06023683 RID: 145027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023683")]
		[Address(RVA = "0x1E05280", Offset = "0x1E03E80", VA = "0x181E05280")]
		public void Render(CharacterInfoHolderBean.CharViewModel charViewModel)
		{
		}

		// Token: 0x06023684 RID: 145028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023684")]
		[Address(RVA = "0x1E054F0", Offset = "0x1E040F0", VA = "0x181E054F0")]
		public CharacterInfoRightLevelView()
		{
		}

		// Token: 0x06023685 RID: 145029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023685")]
		[Address(RVA = "0x1DFEB20", Offset = "0x1DFD720", VA = "0x181DFEB20")]
		private void <>xLuaBaseProxy_AllHide()
		{
		}

		// Token: 0x04030EA7 RID: 200359
		[Token(Token = "0x4030EA7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x04030EA8 RID: 200360
		[Token(Token = "0x4030EA8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _currentLevel;

		// Token: 0x04030EA9 RID: 200361
		[Token(Token = "0x4030EA9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _maxLevel;

		// Token: 0x04030EAA RID: 200362
		[Token(Token = "0x4030EAA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _expBar;

		// Token: 0x04030EAB RID: 200363
		[Token(Token = "0x4030EAB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _expBarCurrent;

		// Token: 0x04030EAC RID: 200364
		[Token(Token = "0x4030EAC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _expBarLimit;

		// Token: 0x04030EAD RID: 200365
		[Token(Token = "0x4030EAD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image plusImg;

		// Token: 0x04030EAE RID: 200366
		[Token(Token = "0x4030EAE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image maxImg;

		// Token: 0x04030EAF RID: 200367
		[Token(Token = "0x4030EAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AllHide;

		// Token: 0x04030EB0 RID: 200368
		[Token(Token = "0x4030EB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetHeight;

		// Token: 0x04030EB1 RID: 200369
		[Token(Token = "0x4030EB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyViewModel;

		// Token: 0x04030EB2 RID: 200370
		[Token(Token = "0x4030EB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030EB3 RID: 200371
		[Token(Token = "0x4030EB3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
