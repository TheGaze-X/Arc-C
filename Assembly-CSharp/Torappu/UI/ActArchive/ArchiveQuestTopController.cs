using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C02 RID: 27650
	[Token(Token = "0x2006C02")]
	public class ArchiveQuestTopController : ActArchiveTopController
	{
		// Token: 0x060277B2 RID: 161714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277B2")]
		[Address(RVA = "0x22ACF00", Offset = "0x22ABB00", VA = "0x1822ACF00")]
		public void OnCgClicked()
		{
		}

		// Token: 0x17005D2C RID: 23852
		// (get) Token: 0x060277B3 RID: 161715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D2C")]
		public DataBinder<ArchiveQuestProperty> dataBinder
		{
			[Token(Token = "0x60277B3")]
			[Address(RVA = "0x22AD1A0", Offset = "0x22ABDA0", VA = "0x1822AD1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060277B4 RID: 161716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277B4")]
		[Address(RVA = "0x22ACDE0", Offset = "0x22AB9E0", VA = "0x1822ACDE0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060277B5 RID: 161717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277B5")]
		[Address(RVA = "0x22ACF70", Offset = "0x22ABB70", VA = "0x1822ACF70")]
		public void ShowAnim()
		{
		}

		// Token: 0x060277B6 RID: 161718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277B6")]
		[Address(RVA = "0x22ACC40", Offset = "0x22AB840", VA = "0x1822ACC40")]
		public void HideAnim()
		{
		}

		// Token: 0x060277B7 RID: 161719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277B7")]
		[Address(RVA = "0x22AD140", Offset = "0x22ABD40", VA = "0x1822AD140")]
		public ArchiveQuestTopController()
		{
		}

		// Token: 0x060277BA RID: 161722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277BA")]
		[Address(RVA = "0x2290EF0", Offset = "0x228FAF0", VA = "0x182290EF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x04037F4D RID: 229197
		[Token(Token = "0x4037F4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchiveQuestCgContentDataBinder _cgContentBinder;

		// Token: 0x04037F4E RID: 229198
		[Token(Token = "0x4037F4E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _bgPanelCanvas;

		// Token: 0x04037F4F RID: 229199
		[Token(Token = "0x4037F4F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _itemCanvas;

		// Token: 0x04037F50 RID: 229200
		[Token(Token = "0x4037F50")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x04037F51 RID: 229201
		[Token(Token = "0x4037F51")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<bool> onFullscreenToggled;

		// Token: 0x04037F52 RID: 229202
		[Token(Token = "0x4037F52")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Sequence m_sequence;

		// Token: 0x04037F53 RID: 229203
		[Token(Token = "0x4037F53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCgClicked;

		// Token: 0x04037F54 RID: 229204
		[Token(Token = "0x4037F54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dataBinder;

		// Token: 0x04037F55 RID: 229205
		[Token(Token = "0x4037F55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037F56 RID: 229206
		[Token(Token = "0x4037F56")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowAnim;

		// Token: 0x04037F57 RID: 229207
		[Token(Token = "0x4037F57")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideAnim;

		// Token: 0x04037F58 RID: 229208
		[Token(Token = "0x4037F58")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
