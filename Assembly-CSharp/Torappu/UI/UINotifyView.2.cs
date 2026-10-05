using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AE8 RID: 15080
	[Token(Token = "0x2003AE8")]
	[RequireComponent(typeof(RectTransform))]
	public class UINotifyView<ParamType> : UINotifyView where ParamType : NotifyViewParam
	{
		// Token: 0x06017C54 RID: 97364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C54")]
		public sealed override void TriggerRender(NotifyViewParam rawParam)
		{
		}

		// Token: 0x06017C55 RID: 97365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C55")]
		protected virtual void Render(ParamType param)
		{
		}

		// Token: 0x06017C56 RID: 97366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C56")]
		public UINotifyView()
		{
		}

		// Token: 0x0401CB44 RID: 117572
		[Token(Token = "0x401CB44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TriggerRender;

		// Token: 0x0401CB45 RID: 117573
		[Token(Token = "0x401CB45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CB46 RID: 117574
		[Token(Token = "0x401CB46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
