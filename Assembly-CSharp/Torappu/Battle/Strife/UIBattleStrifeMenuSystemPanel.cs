using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Strife
{
	// Token: 0x02002684 RID: 9860
	[Token(Token = "0x2002684")]
	public class UIBattleStrifeMenuSystemPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060101A6 RID: 65958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A6")]
		[Address(RVA = "0x7D3DA0", Offset = "0x7D29A0", VA = "0x1807D3DA0")]
		public void Show(UIBattleStrifeSystemMenuState state, int finishWave, int totalWave)
		{
		}

		// Token: 0x060101A7 RID: 65959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A7")]
		[Address(RVA = "0x7D3D30", Offset = "0x7D2930", VA = "0x1807D3D30")]
		public void Hide()
		{
		}

		// Token: 0x060101A8 RID: 65960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A8")]
		[Address(RVA = "0x7D3A60", Offset = "0x7D2660", VA = "0x1807D3A60")]
		public void CloseSystemMenuPanel()
		{
		}

		// Token: 0x060101A9 RID: 65961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A9")]
		[Address(RVA = "0x7D3BA0", Offset = "0x7D27A0", VA = "0x1807D3BA0")]
		public void FinishGameDirectly()
		{
		}

		// Token: 0x060101AA RID: 65962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101AA")]
		[Address(RVA = "0x7D3F30", Offset = "0x7D2B30", VA = "0x1807D3F30")]
		public UIBattleStrifeMenuSystemPanel()
		{
		}

		// Token: 0x04011EEB RID: 73451
		[Token(Token = "0x4011EEB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _curWave;

		// Token: 0x04011EEC RID: 73452
		[Token(Token = "0x4011EEC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _maxWave;

		// Token: 0x04011EED RID: 73453
		[Token(Token = "0x4011EED")]
		[FieldOffset(Offset = "0x28")]
		private UIBattleStrifeSystemMenuState m_state;

		// Token: 0x04011EEE RID: 73454
		[Token(Token = "0x4011EEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04011EEF RID: 73455
		[Token(Token = "0x4011EEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04011EF0 RID: 73456
		[Token(Token = "0x4011EF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CloseSystemMenuPanel;

		// Token: 0x04011EF1 RID: 73457
		[Token(Token = "0x4011EF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FinishGameDirectly;

		// Token: 0x04011EF2 RID: 73458
		[Token(Token = "0x4011EF2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
