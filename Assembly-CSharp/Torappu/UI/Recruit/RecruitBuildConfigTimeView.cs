using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004738 RID: 18232
	[Token(Token = "0x2004738")]
	public class RecruitBuildConfigTimeView : DataBinder<BuildConfigTimeViewProperty>
	{
		// Token: 0x0601BA1D RID: 113181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA1D")]
		[Address(RVA = "0x14F8090", Offset = "0x14F6C90", VA = "0x1814F8090", Slot = "7")]
		public override void OnValueChanged(BuildConfigTimeViewProperty property)
		{
		}

		// Token: 0x0601BA1E RID: 113182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA1E")]
		[Address(RVA = "0x14F81C0", Offset = "0x14F6DC0", VA = "0x1814F81C0")]
		public RecruitBuildConfigTimeView()
		{
		}

		// Token: 0x04023D53 RID: 146771
		[Token(Token = "0x4023D53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _hour;

		// Token: 0x04023D54 RID: 146772
		[Token(Token = "0x4023D54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _minute;

		// Token: 0x04023D55 RID: 146773
		[Token(Token = "0x4023D55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023D56 RID: 146774
		[Token(Token = "0x4023D56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
