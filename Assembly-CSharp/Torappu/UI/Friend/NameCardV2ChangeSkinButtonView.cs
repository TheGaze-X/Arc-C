using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E04 RID: 19972
	[Token(Token = "0x2004E04")]
	public class NameCardV2ChangeSkinButtonView : DataBinder<NameCardV2Property>
	{
		// Token: 0x0601DD8F RID: 122255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD8F")]
		[Address(RVA = "0x17737D0", Offset = "0x17723D0", VA = "0x1817737D0", Slot = "7")]
		public override void OnValueChanged(NameCardV2Property property)
		{
		}

		// Token: 0x0601DD90 RID: 122256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD90")]
		[Address(RVA = "0x1773890", Offset = "0x1772490", VA = "0x181773890")]
		public void ToNameCardSkinChange()
		{
		}

		// Token: 0x0601DD91 RID: 122257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD91")]
		[Address(RVA = "0x1773930", Offset = "0x1772530", VA = "0x181773930")]
		public NameCardV2ChangeSkinButtonView()
		{
		}

		// Token: 0x040278D4 RID: 162004
		[Token(Token = "0x40278D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _changeSkinEntryToggle;

		// Token: 0x040278D5 RID: 162005
		[Token(Token = "0x40278D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _newSkinTrackPoint;

		// Token: 0x040278D6 RID: 162006
		[Token(Token = "0x40278D6")]
		[FieldOffset(Offset = "0x30")]
		private bool m_skinChangeUnlocked;

		// Token: 0x040278D7 RID: 162007
		[Token(Token = "0x40278D7")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040278D8 RID: 162008
		[Token(Token = "0x40278D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040278D9 RID: 162009
		[Token(Token = "0x40278D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ToNameCardSkinChange;

		// Token: 0x040278DA RID: 162010
		[Token(Token = "0x40278DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
