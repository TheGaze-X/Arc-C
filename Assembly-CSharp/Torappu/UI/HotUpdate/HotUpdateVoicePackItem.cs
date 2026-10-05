using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A93 RID: 19091
	[Token(Token = "0x2004A93")]
	public class HotUpdateVoicePackItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x170043AF RID: 17327
		// (get) Token: 0x0601CB0D RID: 117517 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CB0E RID: 117518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043AF")]
		public Action<int> onClicked
		{
			[Token(Token = "0x601CB0D")]
			[Address(RVA = "0x1626540", Offset = "0x1625140", VA = "0x181626540")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601CB0E")]
			[Address(RVA = "0x16265A0", Offset = "0x16251A0", VA = "0x1816265A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601CB0F RID: 117519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB0F")]
		[Address(RVA = "0x1625D00", Offset = "0x1624900", VA = "0x181625D00")]
		public void Render(HotUpdateVoicePackItem.Options options)
		{
		}

		// Token: 0x0601CB10 RID: 117520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB10")]
		[Address(RVA = "0x1626250", Offset = "0x1624E50", VA = "0x181626250")]
		private void _UpdateContent(string voiceResType, long size)
		{
		}

		// Token: 0x0601CB11 RID: 117521 RVA: 0x000A9170 File Offset: 0x000A7370
		[Token(Token = "0x601CB11")]
		[Address(RVA = "0x1625F60", Offset = "0x1624B60", VA = "0x181625F60")]
		private static HotUpdateVoicePackItem.ViewData _GetViewDataFromResType(string voiceResType)
		{
			return default(HotUpdateVoicePackItem.ViewData);
		}

		// Token: 0x0601CB12 RID: 117522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB12")]
		[Address(RVA = "0x1625C50", Offset = "0x1624850", VA = "0x181625C50")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601CB13 RID: 117523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB13")]
		[Address(RVA = "0x16264A0", Offset = "0x16250A0", VA = "0x1816264A0")]
		public HotUpdateVoicePackItem()
		{
		}

		// Token: 0x04025A8A RID: 154250
		[Token(Token = "0x4025A8A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04025A8B RID: 154251
		[Token(Token = "0x4025A8B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04025A8C RID: 154252
		[Token(Token = "0x4025A8C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04025A8D RID: 154253
		[Token(Token = "0x4025A8D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textNotice;

		// Token: 0x04025A8E RID: 154254
		[Token(Token = "0x4025A8E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ThreeStateToggle _toggle;

		// Token: 0x04025A8F RID: 154255
		[Token(Token = "0x4025A8F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objInvalid;

		// Token: 0x04025A90 RID: 154256
		[Token(Token = "0x4025A90")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorSelectableTitle;

		// Token: 0x04025A91 RID: 154257
		[Token(Token = "0x4025A91")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x04025A92 RID: 154258
		[Token(Token = "0x4025A92")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorSelectBkg;

		// Token: 0x04025A93 RID: 154259
		[Token(Token = "0x4025A93")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorUnselectBkg;

		// Token: 0x04025A94 RID: 154260
		[Token(Token = "0x4025A94")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedResType;

		// Token: 0x04025A95 RID: 154261
		[Token(Token = "0x4025A95")]
		[FieldOffset(Offset = "0x90")]
		private int m_cachedIndex;

		// Token: 0x04025A97 RID: 154263
		[Token(Token = "0x4025A97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x04025A98 RID: 154264
		[Token(Token = "0x4025A98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x04025A99 RID: 154265
		[Token(Token = "0x4025A99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025A9A RID: 154266
		[Token(Token = "0x4025A9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x04025A9B RID: 154267
		[Token(Token = "0x4025A9B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetViewDataFromResType;

		// Token: 0x04025A9C RID: 154268
		[Token(Token = "0x4025A9C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04025A9D RID: 154269
		[Token(Token = "0x4025A9D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A94 RID: 19092
		[Token(Token = "0x2004A94")]
		public struct Options
		{
			// Token: 0x04025A9E RID: 154270
			[Token(Token = "0x4025A9E")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x04025A9F RID: 154271
			[Token(Token = "0x4025A9F")]
			[FieldOffset(Offset = "0x8")]
			public HotUpdateVoicePackItemViewModel viewModel;

			// Token: 0x04025AA0 RID: 154272
			[Token(Token = "0x4025AA0")]
			[FieldOffset(Offset = "0x10")]
			public bool isInvalid;
		}

		// Token: 0x02004A95 RID: 19093
		[Token(Token = "0x2004A95")]
		private struct ViewData
		{
			// Token: 0x04025AA1 RID: 154273
			[Token(Token = "0x4025AA1")]
			[FieldOffset(Offset = "0x0")]
			public string title;

			// Token: 0x04025AA2 RID: 154274
			[Token(Token = "0x4025AA2")]
			[FieldOffset(Offset = "0x8")]
			public string desc;

			// Token: 0x04025AA3 RID: 154275
			[Token(Token = "0x4025AA3")]
			[FieldOffset(Offset = "0x10")]
			public string notice;
		}
	}
}
