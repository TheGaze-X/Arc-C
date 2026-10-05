using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200435A RID: 17242
	[Token(Token = "0x200435A")]
	public class SandboxV2RacerInventoryRefreshTalentDeco : SandboxV2ConfirmDialogDecoViewBase, IHotfixable
	{
		// Token: 0x0601A76E RID: 108398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A76E")]
		[Address(RVA = "0x13901B0", Offset = "0x138EDB0", VA = "0x1813901B0", Slot = "4")]
		public override void RenderDecoView(object param)
		{
		}

		// Token: 0x0601A76F RID: 108399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A76F")]
		[Address(RVA = "0x1390380", Offset = "0x138EF80", VA = "0x181390380")]
		public SandboxV2RacerInventoryRefreshTalentDeco()
		{
		}

		// Token: 0x04021AB2 RID: 137906
		[Token(Token = "0x4021AB2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgToken;

		// Token: 0x04021AB3 RID: 137907
		[Token(Token = "0x4021AB3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textPrevCount;

		// Token: 0x04021AB4 RID: 137908
		[Token(Token = "0x4021AB4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textAfterCount;

		// Token: 0x04021AB5 RID: 137909
		[Token(Token = "0x4021AB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderDecoView;

		// Token: 0x04021AB6 RID: 137910
		[Token(Token = "0x4021AB6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200435B RID: 17243
		[Token(Token = "0x200435B")]
		public class Param
		{
			// Token: 0x0601A770 RID: 108400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A770")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04021AB7 RID: 137911
			[Token(Token = "0x4021AB7")]
			[FieldOffset(Offset = "0x10")]
			public Sprite tokenIcon;

			// Token: 0x04021AB8 RID: 137912
			[Token(Token = "0x4021AB8")]
			[FieldOffset(Offset = "0x18")]
			public Color iconColor;

			// Token: 0x04021AB9 RID: 137913
			[Token(Token = "0x4021AB9")]
			[FieldOffset(Offset = "0x28")]
			public int talentTokenPrevCount;

			// Token: 0x04021ABA RID: 137914
			[Token(Token = "0x4021ABA")]
			[FieldOffset(Offset = "0x2C")]
			public int talentTokenAfterCount;
		}
	}
}
