using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003558 RID: 13656
	[Token(Token = "0x2003558")]
	public class UICharacterTrackPointCountBinder : DataBinder<IntProperty>
	{
		// Token: 0x06015C3D RID: 89149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C3D")]
		[Address(RVA = "0xE5A140", Offset = "0xE58D40", VA = "0x180E5A140", Slot = "7")]
		public override void OnValueChanged(IntProperty property)
		{
		}

		// Token: 0x06015C3E RID: 89150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C3E")]
		[Address(RVA = "0xE5A300", Offset = "0xE58F00", VA = "0x180E5A300")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015C3F RID: 89151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C3F")]
		[Address(RVA = "0xE5A370", Offset = "0xE58F70", VA = "0x180E5A370")]
		public UICharacterTrackPointCountBinder()
		{
		}

		// Token: 0x0401A2C5 RID: 107205
		[Token(Token = "0x401A2C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICharacterTrackPointFilterItem _trackPointFilterItem;

		// Token: 0x0401A2C6 RID: 107206
		[Token(Token = "0x401A2C6")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401A2C7 RID: 107207
		[Token(Token = "0x401A2C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A2C8 RID: 107208
		[Token(Token = "0x401A2C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A2C9 RID: 107209
		[Token(Token = "0x401A2C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
