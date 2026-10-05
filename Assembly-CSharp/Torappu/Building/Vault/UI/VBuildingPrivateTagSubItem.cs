using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A88 RID: 6792
	[Token(Token = "0x2001A88")]
	public class VBuildingPrivateTagSubItem : AbstractVFuncTagSubItem
	{
		// Token: 0x0600AB42 RID: 43842 RVA: 0x000423A8 File Offset: 0x000405A8
		[Token(Token = "0x600AB42")]
		[Address(RVA = "0x3253450", Offset = "0x3252050", VA = "0x183253450", Slot = "4")]
		protected override bool OnMatchObject(VCharacter vChar)
		{
			return default(bool);
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB43")]
		[Address(RVA = "0x3253550", Offset = "0x3252150", VA = "0x183253550", Slot = "5")]
		public override void RenderItem(BuildingCharModel charModel, bool isIconVisible)
		{
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB44")]
		[Address(RVA = "0x3253770", Offset = "0x3252370", VA = "0x183253770")]
		public VBuildingPrivateTagSubItem()
		{
		}

		// Token: 0x0400A38A RID: 41866
		[Token(Token = "0x400A38A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _iconPrivateAlpha;

		// Token: 0x0400A38B RID: 41867
		[Token(Token = "0x400A38B")]
		[FieldOffset(Offset = "0x20")]
		private FadeSwitchTween m_privateIconSwitch;

		// Token: 0x0400A38C RID: 41868
		[Token(Token = "0x400A38C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMatchObject;

		// Token: 0x0400A38D RID: 41869
		[Token(Token = "0x400A38D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x0400A38E RID: 41870
		[Token(Token = "0x400A38E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
