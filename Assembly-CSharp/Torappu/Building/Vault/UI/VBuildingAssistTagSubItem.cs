using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A86 RID: 6790
	[Token(Token = "0x2001A86")]
	public class VBuildingAssistTagSubItem : AbstractVFuncTagSubItem
	{
		// Token: 0x0600AB37 RID: 43831 RVA: 0x00042348 File Offset: 0x00040548
		[Token(Token = "0x600AB37")]
		[Address(RVA = "0x3252550", Offset = "0x3251150", VA = "0x183252550", Slot = "4")]
		protected override bool OnMatchObject(VCharacter vChar)
		{
			return default(bool);
		}

		// Token: 0x0600AB38 RID: 43832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB38")]
		[Address(RVA = "0x32526F0", Offset = "0x32512F0", VA = "0x1832526F0", Slot = "5")]
		public override void RenderItem(BuildingCharModel charModel, bool isIconVisible)
		{
		}

		// Token: 0x0600AB39 RID: 43833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB39")]
		[Address(RVA = "0x32529B0", Offset = "0x32515B0", VA = "0x1832529B0")]
		public VBuildingAssistTagSubItem()
		{
		}

		// Token: 0x0400A381 RID: 41857
		[Token(Token = "0x400A381")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _iconAssistAlpha;

		// Token: 0x0400A382 RID: 41858
		[Token(Token = "0x400A382")]
		[FieldOffset(Offset = "0x20")]
		private FadeSwitchTween m_assistIconSwitch;

		// Token: 0x0400A383 RID: 41859
		[Token(Token = "0x400A383")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMatchObject;

		// Token: 0x0400A384 RID: 41860
		[Token(Token = "0x400A384")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x0400A385 RID: 41861
		[Token(Token = "0x400A385")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
