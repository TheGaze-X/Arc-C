using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064CE RID: 25806
	[Token(Token = "0x20064CE")]
	public class AutoChessBattleUIBondCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025161 RID: 151905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025161")]
		[Address(RVA = "0x1FE24B0", Offset = "0x1FE10B0", VA = "0x181FE24B0")]
		public void Render(AutoChessBondCharModel charModel)
		{
		}

		// Token: 0x06025162 RID: 151906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025162")]
		[Address(RVA = "0x1FE25D0", Offset = "0x1FE11D0", VA = "0x181FE25D0")]
		public AutoChessBattleUIBondCharItemView()
		{
		}

		// Token: 0x04033F16 RID: 212758
		[Token(Token = "0x4033F16")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgCharAvatar;

		// Token: 0x04033F17 RID: 212759
		[Token(Token = "0x4033F17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _inactiveMaskObj;

		// Token: 0x04033F18 RID: 212760
		[Token(Token = "0x4033F18")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _activeBorderObj;

		// Token: 0x04033F19 RID: 212761
		[Token(Token = "0x4033F19")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessComLevel _chessLevel;

		// Token: 0x04033F1A RID: 212762
		[Token(Token = "0x4033F1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _charNameText;

		// Token: 0x04033F1B RID: 212763
		[Token(Token = "0x4033F1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033F1C RID: 212764
		[Token(Token = "0x4033F1C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
