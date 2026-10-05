using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064BF RID: 25791
	[Token(Token = "0x20064BF")]
	public class AutoChessBattleSpPrepareTopTipView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025117 RID: 151831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025117")]
		[Address(RVA = "0x1FE1E30", Offset = "0x1FE0A30", VA = "0x181FE1E30")]
		public void Render(AutoChessBattleSpPrepareStepModel stepModel, AutoChessEffectChooseDataModel.AutoChessBattleEffectChooseMode mode)
		{
		}

		// Token: 0x06025118 RID: 151832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025118")]
		[Address(RVA = "0x1FE1F30", Offset = "0x1FE0B30", VA = "0x181FE1F30")]
		public AutoChessBattleSpPrepareTopTipView()
		{
		}

		// Token: 0x04033E8B RID: 212619
		[Token(Token = "0x4033E8B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlSelfSelect;

		// Token: 0x04033E8C RID: 212620
		[Token(Token = "0x4033E8C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlMateSelect;

		// Token: 0x04033E8D RID: 212621
		[Token(Token = "0x4033E8D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _mateNameText;

		// Token: 0x04033E8E RID: 212622
		[Token(Token = "0x4033E8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033E8F RID: 212623
		[Token(Token = "0x4033E8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
