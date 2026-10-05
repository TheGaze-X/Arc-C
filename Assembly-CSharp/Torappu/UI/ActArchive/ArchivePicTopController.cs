using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BE6 RID: 27622
	[Token(Token = "0x2006BE6")]
	public class ArchivePicTopController : ActArchiveTopController
	{
		// Token: 0x0602771A RID: 161562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602771A")]
		[Address(RVA = "0x229BA40", Offset = "0x229A640", VA = "0x18229BA40")]
		public void OnPicClicked()
		{
		}

		// Token: 0x0602771B RID: 161563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602771B")]
		[Address(RVA = "0x229B6F0", Offset = "0x229A2F0", VA = "0x18229B6F0")]
		public List<DataBinder<PicProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x0602771C RID: 161564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602771C")]
		[Address(RVA = "0x229B7B0", Offset = "0x229A3B0", VA = "0x18229B7B0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x0602771D RID: 161565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602771D")]
		[Address(RVA = "0x229BAB0", Offset = "0x229A6B0", VA = "0x18229BAB0")]
		public void ShowAnim()
		{
		}

		// Token: 0x0602771E RID: 161566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602771E")]
		[Address(RVA = "0x229B550", Offset = "0x229A150", VA = "0x18229B550")]
		public void HideAnim()
		{
		}

		// Token: 0x0602771F RID: 161567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602771F")]
		[Address(RVA = "0x229BCE0", Offset = "0x229A8E0", VA = "0x18229BCE0")]
		public ArchivePicTopController()
		{
		}

		// Token: 0x06027722 RID: 161570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027722")]
		[Address(RVA = "0x2290EF0", Offset = "0x228FAF0", VA = "0x182290EF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x04037E25 RID: 228901
		[Token(Token = "0x4037E25")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArchivePicContentDataBinder _picContentBinder;

		// Token: 0x04037E26 RID: 228902
		[Token(Token = "0x4037E26")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04037E27 RID: 228903
		[Token(Token = "0x4037E27")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _bgPanelCanvas;

		// Token: 0x04037E28 RID: 228904
		[Token(Token = "0x4037E28")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _itemCanvas;

		// Token: 0x04037E29 RID: 228905
		[Token(Token = "0x4037E29")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x04037E2A RID: 228906
		[Token(Token = "0x4037E2A")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<bool> onFullscreenToggled;

		// Token: 0x04037E2B RID: 228907
		[Token(Token = "0x4037E2B")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Sequence m_sequence;

		// Token: 0x04037E2C RID: 228908
		[Token(Token = "0x4037E2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPicClicked;

		// Token: 0x04037E2D RID: 228909
		[Token(Token = "0x4037E2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037E2E RID: 228910
		[Token(Token = "0x4037E2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037E2F RID: 228911
		[Token(Token = "0x4037E2F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowAnim;

		// Token: 0x04037E30 RID: 228912
		[Token(Token = "0x4037E30")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideAnim;

		// Token: 0x04037E31 RID: 228913
		[Token(Token = "0x4037E31")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
