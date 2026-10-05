using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BD3 RID: 27603
	[Token(Token = "0x2006BD3")]
	public class ArchiveDynamicPicTopController : ActArchiveTopController
	{
		// Token: 0x060276BB RID: 161467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276BB")]
		[Address(RVA = "0x2290C50", Offset = "0x228F850", VA = "0x182290C50")]
		public void OnPicClicked()
		{
		}

		// Token: 0x060276BC RID: 161468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276BC")]
		[Address(RVA = "0x2290A70", Offset = "0x228F670", VA = "0x182290A70")]
		public List<DataBinder<PicProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x060276BD RID: 161469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276BD")]
		[Address(RVA = "0x2290B30", Offset = "0x228F730", VA = "0x182290B30", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060276BE RID: 161470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276BE")]
		[Address(RVA = "0x2290CC0", Offset = "0x228F8C0", VA = "0x182290CC0")]
		public void ShowAnim()
		{
		}

		// Token: 0x060276BF RID: 161471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276BF")]
		[Address(RVA = "0x22908D0", Offset = "0x228F4D0", VA = "0x1822908D0")]
		public void HideAnim()
		{
		}

		// Token: 0x060276C0 RID: 161472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276C0")]
		[Address(RVA = "0x2290F00", Offset = "0x228FB00", VA = "0x182290F00")]
		public ArchiveDynamicPicTopController()
		{
		}

		// Token: 0x060276C3 RID: 161475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276C3")]
		[Address(RVA = "0x2290EF0", Offset = "0x228FAF0", VA = "0x182290EF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x04037D9F RID: 228767
		[Token(Token = "0x4037D9F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchivePicContentDataBinder _picContentBinder;

		// Token: 0x04037DA0 RID: 228768
		[Token(Token = "0x4037DA0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _bgPanelCanvas;

		// Token: 0x04037DA1 RID: 228769
		[Token(Token = "0x4037DA1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _itemCanvas;

		// Token: 0x04037DA2 RID: 228770
		[Token(Token = "0x4037DA2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x04037DA3 RID: 228771
		[Token(Token = "0x4037DA3")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<bool> onFullscreenToggled;

		// Token: 0x04037DA4 RID: 228772
		[Token(Token = "0x4037DA4")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Sequence m_sequence;

		// Token: 0x04037DA5 RID: 228773
		[Token(Token = "0x4037DA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPicClicked;

		// Token: 0x04037DA6 RID: 228774
		[Token(Token = "0x4037DA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037DA7 RID: 228775
		[Token(Token = "0x4037DA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037DA8 RID: 228776
		[Token(Token = "0x4037DA8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowAnim;

		// Token: 0x04037DA9 RID: 228777
		[Token(Token = "0x4037DA9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideAnim;

		// Token: 0x04037DAA RID: 228778
		[Token(Token = "0x4037DAA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
