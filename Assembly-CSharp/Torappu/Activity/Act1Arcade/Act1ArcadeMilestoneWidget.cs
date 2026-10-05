using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200795A RID: 31066
	[Token(Token = "0x200795A")]
	public class Act1ArcadeMilestoneWidget : TemplateActivityMilestoneWidget
	{
		// Token: 0x0602B964 RID: 178532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B964")]
		[Address(RVA = "0x277E420", Offset = "0x277D020", VA = "0x18277E420", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel tmplViewModel)
		{
		}

		// Token: 0x0602B965 RID: 178533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B965")]
		[Address(RVA = "0x277E940", Offset = "0x277D540", VA = "0x18277E940")]
		public Act1ArcadeMilestoneWidget()
		{
		}

		// Token: 0x0403F0A9 RID: 258217
		[Token(Token = "0x403F0A9")]
		private const string MAX_POINT_FORMAT = "/{0}";

		// Token: 0x0403F0AA RID: 258218
		[Token(Token = "0x403F0AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _maxToggle;

		// Token: 0x0403F0AB RID: 258219
		[Token(Token = "0x403F0AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _lvlNumText;

		// Token: 0x0403F0AC RID: 258220
		[Token(Token = "0x403F0AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _progImg;

		// Token: 0x0403F0AD RID: 258221
		[Token(Token = "0x403F0AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _curPointText;

		// Token: 0x0403F0AE RID: 258222
		[Token(Token = "0x403F0AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _maxPointText;

		// Token: 0x0403F0AF RID: 258223
		[Token(Token = "0x403F0AF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _avatarImg;

		// Token: 0x0403F0B0 RID: 258224
		[Token(Token = "0x403F0B0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _avatarNameText;

		// Token: 0x0403F0B1 RID: 258225
		[Token(Token = "0x403F0B1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _avatarLvText;

		// Token: 0x0403F0B2 RID: 258226
		[Token(Token = "0x403F0B2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _themeNameText;

		// Token: 0x0403F0B3 RID: 258227
		[Token(Token = "0x403F0B3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _themeLvText;

		// Token: 0x0403F0B4 RID: 258228
		[Token(Token = "0x403F0B4")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403F0B5 RID: 258229
		[Token(Token = "0x403F0B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F0B6 RID: 258230
		[Token(Token = "0x403F0B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
