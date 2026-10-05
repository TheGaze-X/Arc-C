using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007371 RID: 29553
	[Token(Token = "0x2007371")]
	public class Act42D0EffectRayCastBlockerView : DataBinder<Act42D0EffectProperty>
	{
		// Token: 0x06029C94 RID: 171156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C94")]
		[Address(RVA = "0x2559890", Offset = "0x2558490", VA = "0x182559890", Slot = "7")]
		public override void OnValueChanged(Act42D0EffectProperty property)
		{
		}

		// Token: 0x06029C95 RID: 171157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C95")]
		[Address(RVA = "0x2559A30", Offset = "0x2558630", VA = "0x182559A30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029C96 RID: 171158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C96")]
		[Address(RVA = "0x2559B20", Offset = "0x2558720", VA = "0x182559B20")]
		public Act42D0EffectRayCastBlockerView()
		{
		}

		// Token: 0x0403BD3D RID: 245053
		[Token(Token = "0x403BD3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403BD3E RID: 245054
		[Token(Token = "0x403BD3E")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403BD3F RID: 245055
		[Token(Token = "0x403BD3F")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0403BD40 RID: 245056
		[Token(Token = "0x403BD40")]
		[FieldOffset(Offset = "0x38")]
		private Act42D0EffectViewModel m_cachedViewModel;

		// Token: 0x0403BD41 RID: 245057
		[Token(Token = "0x403BD41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403BD42 RID: 245058
		[Token(Token = "0x403BD42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BD43 RID: 245059
		[Token(Token = "0x403BD43")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
