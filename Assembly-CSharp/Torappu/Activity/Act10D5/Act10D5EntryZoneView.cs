using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B2F RID: 31535
	[Token(Token = "0x2007B2F")]
	public class Act10D5EntryZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700676A RID: 26474
		// (get) Token: 0x0602C264 RID: 180836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700676A")]
		public string zoneId
		{
			[Token(Token = "0x602C264")]
			[Address(RVA = "0x28055F0", Offset = "0x28041F0", VA = "0x1828055F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C265 RID: 180837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C265")]
		[Address(RVA = "0x2804F30", Offset = "0x2803B30", VA = "0x182804F30")]
		public void Render(Act10D5ZoneDescViewModel viewModel, bool isAllTimeout)
		{
		}

		// Token: 0x0602C266 RID: 180838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C266")]
		[Address(RVA = "0x2804E90", Offset = "0x2803A90", VA = "0x182804E90")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602C267 RID: 180839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C267")]
		[Address(RVA = "0x2805590", Offset = "0x2804190", VA = "0x182805590")]
		public Act10D5EntryZoneView()
		{
		}

		// Token: 0x0403FFE5 RID: 262117
		[Token(Token = "0x403FFE5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403FFE6 RID: 262118
		[Token(Token = "0x403FFE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403FFE7 RID: 262119
		[Token(Token = "0x403FFE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x0403FFE8 RID: 262120
		[Token(Token = "0x403FFE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403FFE9 RID: 262121
		[Token(Token = "0x403FFE9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelAccessible;

		// Token: 0x0403FFEA RID: 262122
		[Token(Token = "0x403FFEA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTimeout;

		// Token: 0x0403FFEB RID: 262123
		[Token(Token = "0x403FFEB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403FFEC RID: 262124
		[Token(Token = "0x403FFEC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x0403FFED RID: 262125
		[Token(Token = "0x403FFED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403FFEE RID: 262126
		[Token(Token = "0x403FFEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FFEF RID: 262127
		[Token(Token = "0x403FFEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403FFF0 RID: 262128
		[Token(Token = "0x403FFF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
