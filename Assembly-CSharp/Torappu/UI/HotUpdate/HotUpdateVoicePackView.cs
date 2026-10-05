using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A96 RID: 19094
	[Token(Token = "0x2004A96")]
	public class HotUpdateVoicePackView : UICustomDialog<HotUpdateVoicePackView.Options>
	{
		// Token: 0x0601CB14 RID: 117524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB14")]
		[Address(RVA = "0x16276D0", Offset = "0x16262D0", VA = "0x1816276D0", Slot = "7")]
		protected override void OnRender(HotUpdateVoicePackView.Options options)
		{
		}

		// Token: 0x0601CB15 RID: 117525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB15")]
		[Address(RVA = "0x1627B50", Offset = "0x1626750", VA = "0x181627B50")]
		private void _GeneItemView()
		{
		}

		// Token: 0x0601CB16 RID: 117526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB16")]
		[Address(RVA = "0x1627EA0", Offset = "0x1626AA0", VA = "0x181627EA0")]
		private void _UpdateView()
		{
		}

		// Token: 0x0601CB17 RID: 117527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB17")]
		[Address(RVA = "0x1627E10", Offset = "0x1626A10", VA = "0x181627E10")]
		private void _OnItemClicked(int index)
		{
		}

		// Token: 0x0601CB18 RID: 117528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB18")]
		[Address(RVA = "0x1627A50", Offset = "0x1626650", VA = "0x181627A50")]
		private void _DoHotUpdateTrace()
		{
		}

		// Token: 0x0601CB19 RID: 117529 RVA: 0x000A9188 File Offset: 0x000A7388
		[Token(Token = "0x601CB19")]
		[Address(RVA = "0x16278D0", Offset = "0x16264D0", VA = "0x1816278D0")]
		private bool _ConfirmVoicePackChoice()
		{
			return default(bool);
		}

		// Token: 0x0601CB1A RID: 117530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB1A")]
		[Address(RVA = "0x16273A0", Offset = "0x1625FA0", VA = "0x1816273A0")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601CB1B RID: 117531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB1B")]
		[Address(RVA = "0x1627410", Offset = "0x1626010", VA = "0x181627410")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0601CB1C RID: 117532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB1C")]
		[Address(RVA = "0x1628340", Offset = "0x1626F40", VA = "0x181628340")]
		public HotUpdateVoicePackView()
		{
		}

		// Token: 0x04025AA4 RID: 154276
		[Token(Token = "0x4025AA4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objCancelBtn;

		// Token: 0x04025AA5 RID: 154277
		[Token(Token = "0x4025AA5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textConfirmBtn;

		// Token: 0x04025AA6 RID: 154278
		[Token(Token = "0x4025AA6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgNormalConfirm;

		// Token: 0x04025AA7 RID: 154279
		[Token(Token = "0x4025AA7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgNoticeConfirm;

		// Token: 0x04025AA8 RID: 154280
		[Token(Token = "0x4025AA8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x04025AA9 RID: 154281
		[Token(Token = "0x4025AA9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HotUpdateVoicePackItem _itemPrefab;

		// Token: 0x04025AAA RID: 154282
		[Token(Token = "0x4025AAA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _linePrefab;

		// Token: 0x04025AAB RID: 154283
		[Token(Token = "0x4025AAB")]
		[FieldOffset(Offset = "0x88")]
		private Action m_onNextStep;

		// Token: 0x04025AAC RID: 154284
		[Token(Token = "0x4025AAC")]
		[FieldOffset(Offset = "0x90")]
		private HotUpdateVoicePackViewModel m_viewModel;

		// Token: 0x04025AAD RID: 154285
		[Token(Token = "0x4025AAD")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04025AAE RID: 154286
		[Token(Token = "0x4025AAE")]
		[FieldOffset(Offset = "0xA0")]
		private List<HotUpdateVoicePackItem> m_cachedItems;

		// Token: 0x04025AAF RID: 154287
		[Token(Token = "0x4025AAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04025AB0 RID: 154288
		[Token(Token = "0x4025AB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GeneItemView;

		// Token: 0x04025AB1 RID: 154289
		[Token(Token = "0x4025AB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x04025AB2 RID: 154290
		[Token(Token = "0x4025AB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04025AB3 RID: 154291
		[Token(Token = "0x4025AB3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoHotUpdateTrace;

		// Token: 0x04025AB4 RID: 154292
		[Token(Token = "0x4025AB4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ConfirmVoicePackChoice;

		// Token: 0x04025AB5 RID: 154293
		[Token(Token = "0x4025AB5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04025AB6 RID: 154294
		[Token(Token = "0x4025AB6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x04025AB7 RID: 154295
		[Token(Token = "0x4025AB7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A97 RID: 19095
		[Token(Token = "0x2004A97")]
		public struct Options
		{
			// Token: 0x04025AB8 RID: 154296
			[Token(Token = "0x4025AB8")]
			[FieldOffset(Offset = "0x0")]
			public Dictionary<string, HotUpdateVoicePackItemData> voicePackItemDict;

			// Token: 0x04025AB9 RID: 154297
			[Token(Token = "0x4025AB9")]
			[FieldOffset(Offset = "0x8")]
			public DisplayType displayType;

			// Token: 0x04025ABA RID: 154298
			[Token(Token = "0x4025ABA")]
			[FieldOffset(Offset = "0x10")]
			public Action onNextStep;
		}
	}
}
