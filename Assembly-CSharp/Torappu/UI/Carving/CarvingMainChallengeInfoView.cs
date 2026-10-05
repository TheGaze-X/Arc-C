using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006072 RID: 24690
	[Token(Token = "0x2006072")]
	public class CarvingMainChallengeInfoView : DataBinder<CarvingMainChallengeInfoProperty>
	{
		// Token: 0x06023B37 RID: 146231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B37")]
		[Address(RVA = "0x1E5A220", Offset = "0x1E58E20", VA = "0x181E5A220", Slot = "7")]
		public override void OnValueChanged(CarvingMainChallengeInfoProperty property)
		{
		}

		// Token: 0x06023B38 RID: 146232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B38")]
		[Address(RVA = "0x1E5A490", Offset = "0x1E59090", VA = "0x181E5A490")]
		public CarvingMainChallengeInfoView()
		{
		}

		// Token: 0x0403179E RID: 202654
		[Token(Token = "0x403179E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _infoTitleTxt;

		// Token: 0x0403179F RID: 202655
		[Token(Token = "0x403179F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _infoDescTxt;

		// Token: 0x040317A0 RID: 202656
		[Token(Token = "0x40317A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bottomBackBtn;

		// Token: 0x040317A1 RID: 202657
		[Token(Token = "0x40317A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CarvingMainChallengeInfoRoundAdapter _loopAdapter;

		// Token: 0x040317A2 RID: 202658
		[Token(Token = "0x40317A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040317A3 RID: 202659
		[Token(Token = "0x40317A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
