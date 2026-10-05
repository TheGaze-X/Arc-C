using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BB4 RID: 15284
	[Token(Token = "0x2003BB4")]
	public class VoicelangCardGridGroupBinder : DataBinder<VoicelangCardGroupViewProperty>
	{
		// Token: 0x06017F05 RID: 98053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F05")]
		[Address(RVA = "0x106A7A0", Offset = "0x10693A0", VA = "0x18106A7A0", Slot = "7")]
		public override void OnValueChanged(VoicelangCardGroupViewProperty property)
		{
		}

		// Token: 0x06017F06 RID: 98054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F06")]
		[Address(RVA = "0x106A930", Offset = "0x1069530", VA = "0x18106A930")]
		public VoicelangCardGridGroupBinder()
		{
		}

		// Token: 0x0401CF28 RID: 118568
		[Token(Token = "0x401CF28")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VoicelangCardGridAdapter _dataTarget;

		// Token: 0x0401CF29 RID: 118569
		[Token(Token = "0x401CF29")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _goEmpty;

		// Token: 0x0401CF2A RID: 118570
		[Token(Token = "0x401CF2A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _goBtnBatch;

		// Token: 0x0401CF2B RID: 118571
		[Token(Token = "0x401CF2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401CF2C RID: 118572
		[Token(Token = "0x401CF2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
