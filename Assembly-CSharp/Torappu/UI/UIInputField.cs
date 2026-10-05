using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003851 RID: 14417
	[Token(Token = "0x2003851")]
	public class UIInputField : InputField, IHotfixable
	{
		// Token: 0x06016D6F RID: 93551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D6F")]
		[Address(RVA = "0xF42000", Offset = "0xF40C00", VA = "0x180F42000", Slot = "34")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06016D70 RID: 93552 RVA: 0x00093318 File Offset: 0x00091518
		[Token(Token = "0x6016D70")]
		[Address(RVA = "0xF42350", Offset = "0xF40F50", VA = "0x180F42350")]
		private bool _MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x06016D71 RID: 93553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D71")]
		[Address(RVA = "0xF42470", Offset = "0xF41070", VA = "0x180F42470")]
		public UIInputField()
		{
		}

		// Token: 0x06016D72 RID: 93554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D72")]
		[Address(RVA = "0xF42340", Offset = "0xF40F40", VA = "0x180F42340")]
		private void <>xLuaBaseProxy_OnPointerDown(PointerEventData P0)
		{
		}

		// Token: 0x0401B8B6 RID: 112822
		[Token(Token = "0x401B8B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x0401B8B7 RID: 112823
		[Token(Token = "0x401B8B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__MayDrag;

		// Token: 0x0401B8B8 RID: 112824
		[Token(Token = "0x401B8B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
