using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FA5 RID: 24485
	[Token(Token = "0x2005FA5")]
	public class CharacterInfoRightProfAttributeView : CharacterInfoRightProfObj
	{
		// Token: 0x060236CA RID: 145098 RVA: 0x000C0D98 File Offset: 0x000BEF98
		[Token(Token = "0x60236CA")]
		[Address(RVA = "0x1E05590", Offset = "0x1E04190", VA = "0x181E05590", Slot = "4")]
		public override float GetAndApplyHeight()
		{
			return 0f;
		}

		// Token: 0x060236CB RID: 145099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236CB")]
		[Address(RVA = "0x1E056C0", Offset = "0x1E042C0", VA = "0x181E056C0", Slot = "6")]
		public override void Render(CharacterInfoHolderBean.CharViewModel viewModel)
		{
		}

		// Token: 0x060236CC RID: 145100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236CC")]
		[Address(RVA = "0x1E058A0", Offset = "0x1E044A0", VA = "0x181E058A0")]
		private void _RenderText(string text)
		{
		}

		// Token: 0x060236CD RID: 145101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236CD")]
		[Address(RVA = "0x1E059A0", Offset = "0x1E045A0", VA = "0x181E059A0")]
		public CharacterInfoRightProfAttributeView()
		{
		}

		// Token: 0x060236CE RID: 145102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236CE")]
		[Address(RVA = "0x1E03130", Offset = "0x1E01D30", VA = "0x181E03130")]
		private void <>xLuaBaseProxy_Render(CharacterInfoHolderBean.CharViewModel P0)
		{
		}

		// Token: 0x04030F2E RID: 200494
		[Token(Token = "0x4030F2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _attributeText;

		// Token: 0x04030F2F RID: 200495
		[Token(Token = "0x4030F2F")]
		[FieldOffset(Offset = "0x28")]
		private string m_cacheText;

		// Token: 0x04030F30 RID: 200496
		[Token(Token = "0x4030F30")]
		[FieldOffset(Offset = "0x30")]
		private TextGenerator m_textGenerate;

		// Token: 0x04030F31 RID: 200497
		[Token(Token = "0x4030F31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAndApplyHeight;

		// Token: 0x04030F32 RID: 200498
		[Token(Token = "0x4030F32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030F33 RID: 200499
		[Token(Token = "0x4030F33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderText;

		// Token: 0x04030F34 RID: 200500
		[Token(Token = "0x4030F34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
