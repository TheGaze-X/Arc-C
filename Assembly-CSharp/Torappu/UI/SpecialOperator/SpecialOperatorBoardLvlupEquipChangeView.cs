using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E78 RID: 15992
	[Token(Token = "0x2003E78")]
	public class SpecialOperatorBoardLvlupEquipChangeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018DA9 RID: 101801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DA9")]
		[Address(RVA = "0x1188F20", Offset = "0x1187B20", VA = "0x181188F20")]
		public void Render(string title, string desc)
		{
		}

		// Token: 0x06018DAA RID: 101802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DAA")]
		[Address(RVA = "0x1189060", Offset = "0x1187C60", VA = "0x181189060")]
		public SpecialOperatorBoardLvlupEquipChangeView()
		{
		}

		// Token: 0x0401E986 RID: 125318
		[Token(Token = "0x401E986")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x0401E987 RID: 125319
		[Token(Token = "0x401E987")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0401E988 RID: 125320
		[Token(Token = "0x401E988")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E989 RID: 125321
		[Token(Token = "0x401E989")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
