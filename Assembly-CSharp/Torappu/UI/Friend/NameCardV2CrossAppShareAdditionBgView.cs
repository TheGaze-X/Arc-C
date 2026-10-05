using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DBC RID: 19900
	[Token(Token = "0x2004DBC")]
	public class NameCardV2CrossAppShareAdditionBgView : UIStylerApplier<NameCardV2SkinStyle>
	{
		// Token: 0x0601DC10 RID: 121872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC10")]
		[Address(RVA = "0x175A4E0", Offset = "0x17590E0", VA = "0x18175A4E0", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DC11 RID: 121873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC11")]
		[Address(RVA = "0x175A740", Offset = "0x1759340", VA = "0x18175A740")]
		public NameCardV2CrossAppShareAdditionBgView()
		{
		}

		// Token: 0x040275C5 RID: 161221
		[Token(Token = "0x40275C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bg;

		// Token: 0x040275C6 RID: 161222
		[Token(Token = "0x40275C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text[] _shareTimes;

		// Token: 0x040275C7 RID: 161223
		[Token(Token = "0x40275C7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _shareNames;

		// Token: 0x040275C8 RID: 161224
		[Token(Token = "0x40275C8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _shareUid;

		// Token: 0x040275C9 RID: 161225
		[Token(Token = "0x40275C9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _shareUidBg;

		// Token: 0x040275CA RID: 161226
		[Token(Token = "0x40275CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x040275CB RID: 161227
		[Token(Token = "0x40275CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
