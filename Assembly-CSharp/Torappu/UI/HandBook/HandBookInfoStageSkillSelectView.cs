using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006697 RID: 26263
	[Token(Token = "0x2006697")]
	public class HandBookInfoStageSkillSelectView : DataBinder<HandBookInfoStageProperty>
	{
		// Token: 0x06025BA0 RID: 154528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BA0")]
		[Address(RVA = "0x20A6F30", Offset = "0x20A5B30", VA = "0x1820A6F30", Slot = "7")]
		public override void OnValueChanged(HandBookInfoStageProperty property)
		{
		}

		// Token: 0x06025BA1 RID: 154529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BA1")]
		[Address(RVA = "0x20A70F0", Offset = "0x20A5CF0", VA = "0x1820A70F0")]
		public HandBookInfoStageSkillSelectView()
		{
		}

		// Token: 0x04035028 RID: 217128
		[Token(Token = "0x4035028")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<HandBookInfoStageSkillItemView> _skillViewList;

		// Token: 0x04035029 RID: 217129
		[Token(Token = "0x4035029")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403502A RID: 217130
		[Token(Token = "0x403502A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
