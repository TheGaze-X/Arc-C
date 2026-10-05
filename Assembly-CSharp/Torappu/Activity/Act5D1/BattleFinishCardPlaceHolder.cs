using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007228 RID: 29224
	[Token(Token = "0x2007228")]
	public class BattleFinishCardPlaceHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296B9 RID: 169657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296B9")]
		[Address(RVA = "0x24D3A30", Offset = "0x24D2630", VA = "0x1824D3A30")]
		public void Init(SquadItemStruct viewModel, BattleFinishCard _cellObj, bool isAssist)
		{
		}

		// Token: 0x060296BA RID: 169658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296BA")]
		[Address(RVA = "0x24D3C20", Offset = "0x24D2820", VA = "0x1824D3C20")]
		public BattleFinishCardPlaceHolder()
		{
		}

		// Token: 0x0403B288 RID: 242312
		[Token(Token = "0x403B288")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image characterBg;

		// Token: 0x0403B289 RID: 242313
		[Token(Token = "0x403B289")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _cardTrans;

		// Token: 0x0403B28A RID: 242314
		[Token(Token = "0x403B28A")]
		[FieldOffset(Offset = "0x28")]
		private BattleFinishCard m_card;

		// Token: 0x0403B28B RID: 242315
		[Token(Token = "0x403B28B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403B28C RID: 242316
		[Token(Token = "0x403B28C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
