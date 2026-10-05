using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007120 RID: 28960
	[Token(Token = "0x2007120")]
	public class ActAutoChessHandbookEnemyDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602922A RID: 168490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602922A")]
		[Address(RVA = "0x24845D0", Offset = "0x24831D0", VA = "0x1824845D0")]
		public void Render(EnemyHandBookEverViewModel model)
		{
		}

		// Token: 0x0602922B RID: 168491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602922B")]
		[Address(RVA = "0x24846D0", Offset = "0x24832D0", VA = "0x1824846D0")]
		public ActAutoChessHandbookEnemyDetailItemView()
		{
		}

		// Token: 0x0403ABE0 RID: 240608
		[Token(Token = "0x403ABE0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403ABE1 RID: 240609
		[Token(Token = "0x403ABE1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCode;

		// Token: 0x0403ABE2 RID: 240610
		[Token(Token = "0x403ABE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ABE3 RID: 240611
		[Token(Token = "0x403ABE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
