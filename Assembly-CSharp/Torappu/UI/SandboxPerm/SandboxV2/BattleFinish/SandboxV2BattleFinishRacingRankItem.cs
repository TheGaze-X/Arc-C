using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2.BattleFinish
{
	// Token: 0x02004458 RID: 17496
	[Token(Token = "0x2004458")]
	public class SandboxV2BattleFinishRacingRankItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601ABBD RID: 109501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABBD")]
		[Address(RVA = "0x13DA1D0", Offset = "0x13D8DD0", VA = "0x1813DA1D0")]
		public void Render(SandboxV2RacerInfoModel racerModel, bool isSelf)
		{
		}

		// Token: 0x0601ABBE RID: 109502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABBE")]
		[Address(RVA = "0x13DA5F0", Offset = "0x13D91F0", VA = "0x1813DA5F0")]
		public SandboxV2BattleFinishRacingRankItem()
		{
		}

		// Token: 0x04022269 RID: 139881
		[Token(Token = "0x4022269")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textPosEmpty;

		// Token: 0x0402226A RID: 139882
		[Token(Token = "0x402226A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textPos;

		// Token: 0x0402226B RID: 139883
		[Token(Token = "0x402226B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402226C RID: 139884
		[Token(Token = "0x402226C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textType;

		// Token: 0x0402226D RID: 139885
		[Token(Token = "0x402226D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x0402226E RID: 139886
		[Token(Token = "0x402226E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _otherPartGo;

		// Token: 0x0402226F RID: 139887
		[Token(Token = "0x402226F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selfPartGo;

		// Token: 0x04022270 RID: 139888
		[Token(Token = "0x4022270")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorOther;

		// Token: 0x04022271 RID: 139889
		[Token(Token = "0x4022271")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorSelf;

		// Token: 0x04022272 RID: 139890
		[Token(Token = "0x4022272")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorSelfPos;

		// Token: 0x04022273 RID: 139891
		[Token(Token = "0x4022273")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022274 RID: 139892
		[Token(Token = "0x4022274")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
