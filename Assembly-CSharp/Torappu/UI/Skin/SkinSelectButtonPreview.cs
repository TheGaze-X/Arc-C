using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EDF RID: 16095
	[Token(Token = "0x2003EDF")]
	public class SkinSelectButtonPreview : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018F81 RID: 102273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F81")]
		[Address(RVA = "0x119D8C0", Offset = "0x119C4C0", VA = "0x18119D8C0")]
		public void InitData(UIPage page)
		{
		}

		// Token: 0x06018F82 RID: 102274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F82")]
		[Address(RVA = "0x119D6F0", Offset = "0x119C2F0", VA = "0x18119D6F0")]
		public void ApplyState(SkinSelectViewModel viewModel)
		{
		}

		// Token: 0x06018F83 RID: 102275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F83")]
		[Address(RVA = "0x119D9E0", Offset = "0x119C5E0", VA = "0x18119D9E0")]
		public void OnBtnPreviewClicked()
		{
		}

		// Token: 0x06018F84 RID: 102276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018F84")]
		[Address(RVA = "0x119DBF0", Offset = "0x119C7F0", VA = "0x18119DBF0")]
		private IEnumerator _PlayDynEntranceCoroutine()
		{
			return null;
		}

		// Token: 0x06018F85 RID: 102277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F85")]
		[Address(RVA = "0x119DCA0", Offset = "0x119C8A0", VA = "0x18119DCA0")]
		public SkinSelectButtonPreview()
		{
		}

		// Token: 0x0401ED51 RID: 126289
		[Token(Token = "0x401ED51")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _btnPreview;

		// Token: 0x0401ED52 RID: 126290
		[Token(Token = "0x401ED52")]
		[FieldOffset(Offset = "0x20")]
		private UISwitchTween m_btnPreviewShowTween;

		// Token: 0x0401ED53 RID: 126291
		[Token(Token = "0x401ED53")]
		[FieldOffset(Offset = "0x28")]
		private SkinSelectViewModel m_cachedModel;

		// Token: 0x0401ED54 RID: 126292
		[Token(Token = "0x401ED54")]
		[FieldOffset(Offset = "0x30")]
		private CharUISkinStruct m_cachedSkin;

		// Token: 0x0401ED55 RID: 126293
		[Token(Token = "0x401ED55")]
		[FieldOffset(Offset = "0x48")]
		private UIPage m_page;

		// Token: 0x0401ED56 RID: 126294
		[Token(Token = "0x401ED56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401ED57 RID: 126295
		[Token(Token = "0x401ED57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyState;

		// Token: 0x0401ED58 RID: 126296
		[Token(Token = "0x401ED58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnPreviewClicked;

		// Token: 0x0401ED59 RID: 126297
		[Token(Token = "0x401ED59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayDynEntranceCoroutine;

		// Token: 0x0401ED5A RID: 126298
		[Token(Token = "0x401ED5A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
