using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BA4 RID: 27556
	[Token(Token = "0x2006BA4")]
	public class ArchiveLogItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060275A5 RID: 161189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275A5")]
		[Address(RVA = "0x2285EE0", Offset = "0x2284AE0", VA = "0x182285EE0")]
		public void Render(ActArchiveResData.LogArchiveResItemData logItem, ArchiveLogDataBinder.LogTitleParam title)
		{
		}

		// Token: 0x060275A6 RID: 161190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275A6")]
		[Address(RVA = "0x2286070", Offset = "0x2284C70", VA = "0x182286070")]
		public ArchiveLogItemView()
		{
		}

		// Token: 0x04037C0E RID: 228366
		[Token(Token = "0x4037C0E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelChapterData;

		// Token: 0x04037C0F RID: 228367
		[Token(Token = "0x4037C0F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelItemData;

		// Token: 0x04037C10 RID: 228368
		[Token(Token = "0x4037C10")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04037C11 RID: 228369
		[Token(Token = "0x4037C11")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04037C12 RID: 228370
		[Token(Token = "0x4037C12")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDisplayId;

		// Token: 0x04037C13 RID: 228371
		[Token(Token = "0x4037C13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037C14 RID: 228372
		[Token(Token = "0x4037C14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
