using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005035 RID: 20533
	[Token(Token = "0x2005035")]
	public class EnemyDuelMatchView : DataBinder<EnemyDuelMatchProperty>, IHotfixable
	{
		// Token: 0x0601E748 RID: 124744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E748")]
		[Address(RVA = "0x1824AB0", Offset = "0x18236B0", VA = "0x181824AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E749 RID: 124745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E749")]
		[Address(RVA = "0x1824860", Offset = "0x1823460", VA = "0x181824860", Slot = "7")]
		public override void OnValueChanged(EnemyDuelMatchProperty property)
		{
		}

		// Token: 0x0601E74A RID: 124746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E74A")]
		[Address(RVA = "0x1824B10", Offset = "0x1823710", VA = "0x181824B10")]
		public EnemyDuelMatchView()
		{
		}

		// Token: 0x04028C20 RID: 166944
		[Token(Token = "0x4028C20")]
		private const string TIMER_FORMAT = "{0}S";

		// Token: 0x04028C21 RID: 166945
		[Token(Token = "0x4028C21")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _timerText;

		// Token: 0x04028C22 RID: 166946
		[Token(Token = "0x4028C22")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _maxPlayerText;

		// Token: 0x04028C23 RID: 166947
		[Token(Token = "0x4028C23")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _curPlayerText;

		// Token: 0x04028C24 RID: 166948
		[Token(Token = "0x4028C24")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle[] _isMatchedToggles;

		// Token: 0x04028C25 RID: 166949
		[Token(Token = "0x4028C25")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04028C26 RID: 166950
		[Token(Token = "0x4028C26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028C27 RID: 166951
		[Token(Token = "0x4028C27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028C28 RID: 166952
		[Token(Token = "0x4028C28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
