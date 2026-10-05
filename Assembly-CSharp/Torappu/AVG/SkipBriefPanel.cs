using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001ED9 RID: 7897
	[Token(Token = "0x2001ED9")]
	public class SkipBriefPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C3F4 RID: 50164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F4")]
		[Address(RVA = "0x3431EB0", Offset = "0x3430AB0", VA = "0x183431EB0")]
		public void Reset()
		{
		}

		// Token: 0x0600C3F5 RID: 50165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F5")]
		[Address(RVA = "0x3431B80", Offset = "0x3430780", VA = "0x183431B80")]
		public void RenderBriefSkip(string chapterName, string title, string avgTag, string content)
		{
		}

		// Token: 0x0600C3F6 RID: 50166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F6")]
		[Address(RVA = "0x3431E30", Offset = "0x3430A30", VA = "0x183431E30")]
		public void RenderNonBriefSkip()
		{
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x0600C3F7 RID: 50167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001769")]
		private CanvasGroup canvasGroup
		{
			[Token(Token = "0x600C3F7")]
			[Address(RVA = "0x34322B0", Offset = "0x3430EB0", VA = "0x1834322B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x0600C3F8 RID: 50168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700176A")]
		private FadeSwitchTween fadeSwitchTween
		{
			[Token(Token = "0x600C3F8")]
			[Address(RVA = "0x3432380", Offset = "0x3430F80", VA = "0x183432380")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C3F9 RID: 50169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F9")]
		[Address(RVA = "0x3432100", Offset = "0x3430D00", VA = "0x183432100")]
		private void _UpdateShown(bool value, bool force)
		{
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x0600C3FA RID: 50170 RVA: 0x00047F10 File Offset: 0x00046110
		// (set) Token: 0x0600C3FB RID: 50171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700176B")]
		public bool isShown
		{
			[Token(Token = "0x600C3FA")]
			[Address(RVA = "0x3432500", Offset = "0x3431100", VA = "0x183432500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C3FB")]
			[Address(RVA = "0x3432570", Offset = "0x3431170", VA = "0x183432570")]
			set
			{
			}
		}

		// Token: 0x0600C3FC RID: 50172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3FC")]
		[Address(RVA = "0x3431A60", Offset = "0x3430660", VA = "0x183431A60")]
		public void OnCloseBtnClicked()
		{
		}

		// Token: 0x0600C3FD RID: 50173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3FD")]
		[Address(RVA = "0x3431AE0", Offset = "0x34306E0", VA = "0x183431AE0")]
		public void OnConfirmBtnClicked()
		{
		}

		// Token: 0x0600C3FE RID: 50174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3FE")]
		[Address(RVA = "0x3431F10", Offset = "0x3430B10", VA = "0x183431F10")]
		private void _ResumeAvgAutoIfNeeded()
		{
		}

		// Token: 0x0600C3FF RID: 50175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3FF")]
		[Address(RVA = "0x3431FD0", Offset = "0x3430BD0", VA = "0x183431FD0")]
		private void _ResumeReaderAutoIfNeeded()
		{
		}

		// Token: 0x0600C400 RID: 50176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C400")]
		[Address(RVA = "0x3432250", Offset = "0x3430E50", VA = "0x183432250")]
		public SkipBriefPanel()
		{
		}

		// Token: 0x0400C654 RID: 50772
		[Token(Token = "0x400C654")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _chapterName;

		// Token: 0x0400C655 RID: 50773
		[Token(Token = "0x400C655")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _title;

		// Token: 0x0400C656 RID: 50774
		[Token(Token = "0x400C656")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _avgTag;

		// Token: 0x0400C657 RID: 50775
		[Token(Token = "0x400C657")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _content;

		// Token: 0x0400C658 RID: 50776
		[Token(Token = "0x400C658")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _nonBriefPanel;

		// Token: 0x0400C659 RID: 50777
		[Token(Token = "0x400C659")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _briefPanel;

		// Token: 0x0400C65A RID: 50778
		[Token(Token = "0x400C65A")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action _onConfirm;

		// Token: 0x0400C65B RID: 50779
		[Token(Token = "0x400C65B")]
		[FieldOffset(Offset = "0x50")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0400C65C RID: 50780
		[Token(Token = "0x400C65C")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_skipBriefTween;

		// Token: 0x0400C65D RID: 50781
		[Token(Token = "0x400C65D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400C65E RID: 50782
		[Token(Token = "0x400C65E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderBriefSkip;

		// Token: 0x0400C65F RID: 50783
		[Token(Token = "0x400C65F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderNonBriefSkip;

		// Token: 0x0400C660 RID: 50784
		[Token(Token = "0x400C660")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_canvasGroup;

		// Token: 0x0400C661 RID: 50785
		[Token(Token = "0x400C661")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_fadeSwitchTween;

		// Token: 0x0400C662 RID: 50786
		[Token(Token = "0x400C662")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateShown;

		// Token: 0x0400C663 RID: 50787
		[Token(Token = "0x400C663")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isShown;

		// Token: 0x0400C664 RID: 50788
		[Token(Token = "0x400C664")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isShown;

		// Token: 0x0400C665 RID: 50789
		[Token(Token = "0x400C665")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCloseBtnClicked;

		// Token: 0x0400C666 RID: 50790
		[Token(Token = "0x400C666")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClicked;

		// Token: 0x0400C667 RID: 50791
		[Token(Token = "0x400C667")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResumeAvgAutoIfNeeded;

		// Token: 0x0400C668 RID: 50792
		[Token(Token = "0x400C668")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ResumeReaderAutoIfNeeded;

		// Token: 0x0400C669 RID: 50793
		[Token(Token = "0x400C669")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
