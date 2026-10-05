using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A81 RID: 19073
	[Token(Token = "0x2004A81")]
	public class HotUpdateNetErrorAlert : MonoBehaviour, IHotfixable
	{
		// Token: 0x170043A1 RID: 17313
		// (get) Token: 0x0601CAA3 RID: 117411 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CAA4 RID: 117412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043A1")]
		public Action onNetCheckClicked
		{
			[Token(Token = "0x601CAA3")]
			[Address(RVA = "0x1623460", Offset = "0x1622060", VA = "0x181623460")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601CAA4")]
			[Address(RVA = "0x16234C0", Offset = "0x16220C0", VA = "0x1816234C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601CAA5 RID: 117413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAA5")]
		[Address(RVA = "0x16232F0", Offset = "0x1621EF0", VA = "0x1816232F0")]
		public void Init(string errorMsg)
		{
		}

		// Token: 0x0601CAA6 RID: 117414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAA6")]
		[Address(RVA = "0x16231E0", Offset = "0x1621DE0", VA = "0x1816231E0")]
		public void EventOnNetCheckClicked()
		{
		}

		// Token: 0x0601CAA7 RID: 117415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAA7")]
		[Address(RVA = "0x1623400", Offset = "0x1622000", VA = "0x181623400")]
		public HotUpdateNetErrorAlert()
		{
		}

		// Token: 0x040259E4 RID: 154084
		[Token(Token = "0x40259E4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textError;

		// Token: 0x040259E5 RID: 154085
		[Token(Token = "0x40259E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040259E6 RID: 154086
		[Token(Token = "0x40259E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textButton;

		// Token: 0x040259E7 RID: 154087
		[Token(Token = "0x40259E7")]
		[FieldOffset(Offset = "0x30")]
		private NetworkErrorDisplayer m_controller;

		// Token: 0x040259E9 RID: 154089
		[Token(Token = "0x40259E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNetCheckClicked;

		// Token: 0x040259EA RID: 154090
		[Token(Token = "0x40259EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNetCheckClicked;

		// Token: 0x040259EB RID: 154091
		[Token(Token = "0x40259EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040259EC RID: 154092
		[Token(Token = "0x40259EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnNetCheckClicked;

		// Token: 0x040259ED RID: 154093
		[Token(Token = "0x40259ED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
