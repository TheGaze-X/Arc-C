using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B55 RID: 31573
	[Token(Token = "0x2007B55")]
	public class ActivityFirstMapDecro : DataBinder<ActivityFirstMapProperty>, IHotfixable
	{
		// Token: 0x0602C328 RID: 181032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C328")]
		[Address(RVA = "0x281BE50", Offset = "0x281AA50", VA = "0x18281BE50", Slot = "7")]
		public override void OnValueChanged(ActivityFirstMapProperty property)
		{
		}

		// Token: 0x0602C329 RID: 181033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C329")]
		[Address(RVA = "0x281C500", Offset = "0x281B100", VA = "0x18281C500")]
		public ActivityFirstMapDecro()
		{
		}

		// Token: 0x0404010E RID: 262414
		[Token(Token = "0x404010E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityFirstMapDecroObj _decroObj;

		// Token: 0x0404010F RID: 262415
		[Token(Token = "0x404010F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _objContainer;

		// Token: 0x04040110 RID: 262416
		[Token(Token = "0x4040110")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _leftButton;

		// Token: 0x04040111 RID: 262417
		[Token(Token = "0x4040111")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rightButton;

		// Token: 0x04040112 RID: 262418
		[Token(Token = "0x4040112")]
		[FieldOffset(Offset = "0x40")]
		private List<ActivityFirstMapDecroObj> _objList;

		// Token: 0x04040113 RID: 262419
		[Token(Token = "0x4040113")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04040114 RID: 262420
		[Token(Token = "0x4040114")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
