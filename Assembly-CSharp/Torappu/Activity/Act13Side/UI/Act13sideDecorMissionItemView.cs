using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side.UI
{
	// Token: 0x02007A4B RID: 31307
	[Token(Token = "0x2007A4B")]
	public class Act13sideDecorMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BDC2 RID: 179650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDC2")]
		[Address(RVA = "0x27CA6B0", Offset = "0x27C92B0", VA = "0x1827CA6B0")]
		public void Render(string actId, Act13SideData.DailyMissionData missionData, string principalChar, PlayerActivity.PlayerAct13sideActivity.DailyMissionProgress progress)
		{
		}

		// Token: 0x0602BDC3 RID: 179651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDC3")]
		[Address(RVA = "0x27CA8D0", Offset = "0x27C94D0", VA = "0x1827CA8D0")]
		public Act13sideDecorMissionItemView()
		{
		}

		// Token: 0x0403F835 RID: 260149
		[Token(Token = "0x403F835")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0403F836 RID: 260150
		[Token(Token = "0x403F836")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0403F837 RID: 260151
		[Token(Token = "0x403F837")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x0403F838 RID: 260152
		[Token(Token = "0x403F838")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgChar;

		// Token: 0x0403F839 RID: 260153
		[Token(Token = "0x403F839")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0403F83A RID: 260154
		[Token(Token = "0x403F83A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F83B RID: 260155
		[Token(Token = "0x403F83B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
