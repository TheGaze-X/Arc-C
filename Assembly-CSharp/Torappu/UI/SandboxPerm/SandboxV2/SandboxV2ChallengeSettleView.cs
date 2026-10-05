using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004176 RID: 16758
	[Token(Token = "0x2004176")]
	public class SandboxV2ChallengeSettleView : DataBinder<SandboxV2ChallengeSettleProperty>
	{
		// Token: 0x06019DD8 RID: 105944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DD8")]
		[Address(RVA = "0x12B8B50", Offset = "0x12B7750", VA = "0x1812B8B50", Slot = "7")]
		public override void OnValueChanged(SandboxV2ChallengeSettleProperty property)
		{
		}

		// Token: 0x06019DD9 RID: 105945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DD9")]
		[Address(RVA = "0x12B8AC0", Offset = "0x12B76C0", VA = "0x1812B8AC0")]
		public void OnBtnContinueClicked()
		{
		}

		// Token: 0x06019DDA RID: 105946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DDA")]
		[Address(RVA = "0x12B8DC0", Offset = "0x12B79C0", VA = "0x1812B8DC0")]
		public SandboxV2ChallengeSettleView()
		{
		}

		// Token: 0x040207E8 RID: 133096
		[Token(Token = "0x40207E8")]
		private const string USERNAME_PREFIX = "Dr.{0}";

		// Token: 0x040207E9 RID: 133097
		[Token(Token = "0x40207E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textUserName;

		// Token: 0x040207EA RID: 133098
		[Token(Token = "0x40207EA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlNewRecord;

		// Token: 0x040207EB RID: 133099
		[Token(Token = "0x40207EB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textChallengeDay;

		// Token: 0x040207EC RID: 133100
		[Token(Token = "0x40207EC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEnemyRushKilled;

		// Token: 0x040207ED RID: 133101
		[Token(Token = "0x40207ED")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textStartDay;

		// Token: 0x040207EE RID: 133102
		[Token(Token = "0x40207EE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textStartLoadTimes;

		// Token: 0x040207EF RID: 133103
		[Token(Token = "0x40207EF")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040207F0 RID: 133104
		[Token(Token = "0x40207F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040207F1 RID: 133105
		[Token(Token = "0x40207F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBtnContinueClicked;

		// Token: 0x040207F2 RID: 133106
		[Token(Token = "0x40207F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
