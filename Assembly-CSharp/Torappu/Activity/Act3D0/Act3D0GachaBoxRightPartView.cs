using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007402 RID: 29698
	[Token(Token = "0x2007402")]
	public class Act3D0GachaBoxRightPartView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700630B RID: 25355
		// (get) Token: 0x06029F10 RID: 171792 RVA: 0x000D7070 File Offset: 0x000D5270
		[Token(Token = "0x1700630B")]
		public int gachaTimes
		{
			[Token(Token = "0x6029F10")]
			[Address(RVA = "0x258B590", Offset = "0x258A190", VA = "0x18258B590")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700630C RID: 25356
		// (get) Token: 0x06029F11 RID: 171793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700630C")]
		public Act3D0CampResHolder resHolder
		{
			[Token(Token = "0x6029F11")]
			[Address(RVA = "0x258B5F0", Offset = "0x258A1F0", VA = "0x18258B5F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029F12 RID: 171794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F12")]
		[Address(RVA = "0x258A7D0", Offset = "0x25893D0", VA = "0x18258A7D0")]
		public void OnClick()
		{
		}

		// Token: 0x06029F13 RID: 171795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F13")]
		[Address(RVA = "0x258A710", Offset = "0x2589310", VA = "0x18258A710")]
		public void OnClickTenTimes()
		{
		}

		// Token: 0x06029F14 RID: 171796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F14")]
		[Address(RVA = "0x258A2F0", Offset = "0x2588EF0", VA = "0x18258A2F0")]
		public void InitInfo(List<Act3D0GachaBoxInfo> boxInfo, string defaultBoxId)
		{
		}

		// Token: 0x06029F15 RID: 171797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F15")]
		[Address(RVA = "0x258A890", Offset = "0x2589490", VA = "0x18258A890")]
		public void OnFocus(int focusIndex)
		{
		}

		// Token: 0x06029F16 RID: 171798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F16")]
		[Address(RVA = "0x258A950", Offset = "0x2589550", VA = "0x18258A950")]
		public void OnFocus(string focusId)
		{
		}

		// Token: 0x06029F17 RID: 171799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F17")]
		[Address(RVA = "0x258AB00", Offset = "0x2589700", VA = "0x18258AB00")]
		public void Refresh()
		{
		}

		// Token: 0x06029F18 RID: 171800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F18")]
		[Address(RVA = "0x258AA70", Offset = "0x2589670", VA = "0x18258AA70")]
		public void Refresh(List<Act3D0GachaBoxInfo> boxInfo)
		{
		}

		// Token: 0x06029F19 RID: 171801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F19")]
		[Address(RVA = "0x258ADF0", Offset = "0x25899F0", VA = "0x18258ADF0")]
		private void _OnFocus()
		{
		}

		// Token: 0x06029F1A RID: 171802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F1A")]
		[Address(RVA = "0x258AB60", Offset = "0x2589760", VA = "0x18258AB60")]
		public void RenderInfo(List<Act3D0GachaBoxInfo> boxInfo)
		{
		}

		// Token: 0x06029F1B RID: 171803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F1B")]
		[Address(RVA = "0x2589D60", Offset = "0x2588960", VA = "0x182589D60")]
		private void CheckTimes()
		{
		}

		// Token: 0x06029F1C RID: 171804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F1C")]
		[Address(RVA = "0x258A650", Offset = "0x2589250", VA = "0x18258A650")]
		public void LeftOne()
		{
		}

		// Token: 0x06029F1D RID: 171805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F1D")]
		[Address(RVA = "0x258AD10", Offset = "0x2589910", VA = "0x18258AD10")]
		public void RightOne()
		{
		}

		// Token: 0x06029F1E RID: 171806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F1E")]
		[Address(RVA = "0x258B4C0", Offset = "0x258A0C0", VA = "0x18258B4C0")]
		public Act3D0GachaBoxRightPartView()
		{
		}

		// Token: 0x0403C1AF RID: 246191
		[Token(Token = "0x403C1AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act3D0GachaBoxItem _boxItem;

		// Token: 0x0403C1B0 RID: 246192
		[Token(Token = "0x403C1B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403C1B1 RID: 246193
		[Token(Token = "0x403C1B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act3D0GachaBoxSliderItem _slideItem;

		// Token: 0x0403C1B2 RID: 246194
		[Token(Token = "0x403C1B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _slideContainer;

		// Token: 0x0403C1B3 RID: 246195
		[Token(Token = "0x403C1B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act3D0GachaBoxDetailView _detailView;

		// Token: 0x0403C1B4 RID: 246196
		[Token(Token = "0x403C1B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIStringEvent _onGachaTime;

		// Token: 0x0403C1B5 RID: 246197
		[Token(Token = "0x403C1B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStringEvent _onGachaTenTimes;

		// Token: 0x0403C1B6 RID: 246198
		[Token(Token = "0x403C1B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _buttonImg;

		// Token: 0x0403C1B7 RID: 246199
		[Token(Token = "0x403C1B7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _buttonPrice;

		// Token: 0x0403C1B8 RID: 246200
		[Token(Token = "0x403C1B8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _buttonTencePrice;

		// Token: 0x0403C1B9 RID: 246201
		[Token(Token = "0x403C1B9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _buttonTenceTimes;

		// Token: 0x0403C1BA RID: 246202
		[Token(Token = "0x403C1BA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _boxIndex;

		// Token: 0x0403C1BB RID: 246203
		[Token(Token = "0x403C1BB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _leftBtn;

		// Token: 0x0403C1BC RID: 246204
		[Token(Token = "0x403C1BC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _rightBtn;

		// Token: 0x0403C1BD RID: 246205
		[Token(Token = "0x403C1BD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _oneTimeBtn;

		// Token: 0x0403C1BE RID: 246206
		[Token(Token = "0x403C1BE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _tenTimeBtn;

		// Token: 0x0403C1BF RID: 246207
		[Token(Token = "0x403C1BF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _oneTimeBan;

		// Token: 0x0403C1C0 RID: 246208
		[Token(Token = "0x403C1C0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _tenTimeBan;

		// Token: 0x0403C1C1 RID: 246209
		[Token(Token = "0x403C1C1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _oneTimeMin;

		// Token: 0x0403C1C2 RID: 246210
		[Token(Token = "0x403C1C2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _tenTimeMin;

		// Token: 0x0403C1C3 RID: 246211
		[Token(Token = "0x403C1C3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _remainPart;

		// Token: 0x0403C1C4 RID: 246212
		[Token(Token = "0x403C1C4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0403C1C5 RID: 246213
		[Token(Token = "0x403C1C5")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public Dictionary<string, Act3D0Data.InfinitePoolPercent> infinitePercent;

		// Token: 0x0403C1C6 RID: 246214
		[Token(Token = "0x403C1C6")]
		[FieldOffset(Offset = "0xD0")]
		private int m_focusIndex;

		// Token: 0x0403C1C7 RID: 246215
		[Token(Token = "0x403C1C7")]
		[FieldOffset(Offset = "0xD8")]
		private string m_focusId;

		// Token: 0x0403C1C8 RID: 246216
		[Token(Token = "0x403C1C8")]
		[FieldOffset(Offset = "0xE0")]
		private int m_gachaTimes;

		// Token: 0x0403C1C9 RID: 246217
		[Token(Token = "0x403C1C9")]
		[FieldOffset(Offset = "0xE8")]
		private List<Act3D0GachaBoxItem> m_boxItemList;

		// Token: 0x0403C1CA RID: 246218
		[Token(Token = "0x403C1CA")]
		[FieldOffset(Offset = "0xF0")]
		private List<Act3D0GachaBoxSliderItem> m_sliderItem;

		// Token: 0x0403C1CB RID: 246219
		[Token(Token = "0x403C1CB")]
		[FieldOffset(Offset = "0xF8")]
		private List<Act3D0GachaBoxInfo> m_boxInfo;

		// Token: 0x0403C1CC RID: 246220
		[Token(Token = "0x403C1CC")]
		[FieldOffset(Offset = "0x100")]
		private bool m_isInited;

		// Token: 0x0403C1CD RID: 246221
		[Token(Token = "0x403C1CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gachaTimes;

		// Token: 0x0403C1CE RID: 246222
		[Token(Token = "0x403C1CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_resHolder;

		// Token: 0x0403C1CF RID: 246223
		[Token(Token = "0x403C1CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403C1D0 RID: 246224
		[Token(Token = "0x403C1D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickTenTimes;

		// Token: 0x0403C1D1 RID: 246225
		[Token(Token = "0x403C1D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x0403C1D2 RID: 246226
		[Token(Token = "0x403C1D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnFocus;

		// Token: 0x0403C1D3 RID: 246227
		[Token(Token = "0x403C1D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_OnFocus;

		// Token: 0x0403C1D4 RID: 246228
		[Token(Token = "0x403C1D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403C1D5 RID: 246229
		[Token(Token = "0x403C1D5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_Refresh;

		// Token: 0x0403C1D6 RID: 246230
		[Token(Token = "0x403C1D6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnFocus;

		// Token: 0x0403C1D7 RID: 246231
		[Token(Token = "0x403C1D7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x0403C1D8 RID: 246232
		[Token(Token = "0x403C1D8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckTimes;

		// Token: 0x0403C1D9 RID: 246233
		[Token(Token = "0x403C1D9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LeftOne;

		// Token: 0x0403C1DA RID: 246234
		[Token(Token = "0x403C1DA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RightOne;

		// Token: 0x0403C1DB RID: 246235
		[Token(Token = "0x403C1DB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
