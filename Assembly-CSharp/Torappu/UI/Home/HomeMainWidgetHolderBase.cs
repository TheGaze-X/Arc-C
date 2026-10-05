using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C4C RID: 19532
	[Token(Token = "0x2004C4C")]
	public class HomeMainWidgetHolderBase<WidgetType> : HomeMainWidgetHolder where WidgetType : HomeMainWidgetBase
	{
		// Token: 0x0601D50D RID: 120077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D50D")]
		public override void ChangeWidget(GameObject widgetGO)
		{
		}

		// Token: 0x0601D50E RID: 120078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D50E")]
		public void ChangeWidget(WidgetType widget)
		{
		}

		// Token: 0x170044DF RID: 17631
		// (get) Token: 0x0601D50F RID: 120079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170044DF")]
		public WidgetType currWidget
		{
			[Token(Token = "0x601D50F")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D510 RID: 120080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D510")]
		private void _CheckIfDefault()
		{
		}

		// Token: 0x0601D511 RID: 120081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D511")]
		protected virtual void OnWidgetChanged(WidgetType newWidget)
		{
		}

		// Token: 0x0601D512 RID: 120082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D512")]
		public HomeMainWidgetHolderBase()
		{
		}

		// Token: 0x04026920 RID: 157984
		[Token(Token = "0x4026920")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private WidgetType _defaultWidget;

		// Token: 0x04026921 RID: 157985
		[Token(Token = "0x4026921")]
		[FieldOffset(Offset = "0x0")]
		private WidgetType m_currWidget;

		// Token: 0x04026922 RID: 157986
		[Token(Token = "0x4026922")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ChangeWidget;

		// Token: 0x04026923 RID: 157987
		[Token(Token = "0x4026923")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_ChangeWidget;

		// Token: 0x04026924 RID: 157988
		[Token(Token = "0x4026924")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currWidget;

		// Token: 0x04026925 RID: 157989
		[Token(Token = "0x4026925")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckIfDefault;

		// Token: 0x04026926 RID: 157990
		[Token(Token = "0x4026926")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnWidgetChanged;

		// Token: 0x04026927 RID: 157991
		[Token(Token = "0x4026927")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
