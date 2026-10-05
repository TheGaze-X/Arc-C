using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200375A RID: 14170
	[Token(Token = "0x200375A")]
	public class UISkillRangeDisplayDialog : UICustomDialog<UISkillRangeDisplayDialog.Options>
	{
		// Token: 0x06016813 RID: 92179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016813")]
		[Address(RVA = "0xEEEE70", Offset = "0xEEDA70", VA = "0x180EEEE70", Slot = "7")]
		protected override void OnRender(UISkillRangeDisplayDialog.Options options)
		{
		}

		// Token: 0x06016814 RID: 92180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016814")]
		[Address(RVA = "0xEEEE00", Offset = "0xEEDA00", VA = "0x180EEEE00")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x06016815 RID: 92181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016815")]
		[Address(RVA = "0xEEEFA0", Offset = "0xEEDBA0", VA = "0x180EEEFA0")]
		public UISkillRangeDisplayDialog()
		{
		}

		// Token: 0x0401B1C0 RID: 111040
		[Token(Token = "0x401B1C0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x0401B1C1 RID: 111041
		[Token(Token = "0x401B1C1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _skillName;

		// Token: 0x0401B1C2 RID: 111042
		[Token(Token = "0x401B1C2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICharacterAttackRangeWidget _attackRange;

		// Token: 0x0401B1C3 RID: 111043
		[Token(Token = "0x401B1C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401B1C4 RID: 111044
		[Token(Token = "0x401B1C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x0401B1C5 RID: 111045
		[Token(Token = "0x401B1C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200375B RID: 14171
		[Token(Token = "0x200375B")]
		public class Options
		{
			// Token: 0x06016816 RID: 92182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016816")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0401B1C6 RID: 111046
			[Token(Token = "0x401B1C6")]
			[FieldOffset(Offset = "0x10")]
			public SkillData skillData;
		}
	}
}
