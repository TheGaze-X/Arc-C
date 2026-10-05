using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E74 RID: 15988
	[Token(Token = "0x2003E74")]
	public class SpecialOperatorBoardLvlupSkillSpLevelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018D9B RID: 101787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D9B")]
		[Address(RVA = "0x118E020", Offset = "0x118CC20", VA = "0x18118E020")]
		public void Render(int spLevel)
		{
		}

		// Token: 0x06018D9C RID: 101788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D9C")]
		[Address(RVA = "0x118E0C0", Offset = "0x118CCC0", VA = "0x18118E0C0")]
		public SpecialOperatorBoardLvlupSkillSpLevelView()
		{
		}

		// Token: 0x0401E970 RID: 125296
		[Token(Token = "0x401E970")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _spLevel;

		// Token: 0x0401E971 RID: 125297
		[Token(Token = "0x401E971")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0401E972 RID: 125298
		[Token(Token = "0x401E972")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E973 RID: 125299
		[Token(Token = "0x401E973")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
