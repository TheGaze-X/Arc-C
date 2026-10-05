using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F56 RID: 28502
	[Token(Token = "0x2006F56")]
	public class ActMultiV3ManualView : DataBinder<ActMultiV3ManualProperty>, IHotfixable
	{
		// Token: 0x060287A6 RID: 165798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287A6")]
		[Address(RVA = "0x23CA0E0", Offset = "0x23C8CE0", VA = "0x1823CA0E0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3ManualProperty property)
		{
		}

		// Token: 0x060287A7 RID: 165799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287A7")]
		[Address(RVA = "0x23CA360", Offset = "0x23C8F60", VA = "0x1823CA360")]
		public ActMultiV3ManualView()
		{
		}

		// Token: 0x04039943 RID: 235843
		[Token(Token = "0x4039943")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x04039944 RID: 235844
		[Token(Token = "0x4039944")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _seasonLogo;

		// Token: 0x04039945 RID: 235845
		[Token(Token = "0x4039945")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActMultiV3ProfileView _profileView;

		// Token: 0x04039946 RID: 235846
		[Token(Token = "0x4039946")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActMultiV3ManualTabView[] _tabViews;

		// Token: 0x04039947 RID: 235847
		[Token(Token = "0x4039947")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039948 RID: 235848
		[Token(Token = "0x4039948")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039949 RID: 235849
		[Token(Token = "0x4039949")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
