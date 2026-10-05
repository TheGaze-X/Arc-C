using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073E2 RID: 29666
	[Token(Token = "0x20073E2")]
	public class Act3D0StageMapDecor : ActivityStageSingleComponent, IPlayerDataListener, IHotfixable
	{
		// Token: 0x06029E6E RID: 171630 RVA: 0x000D6F08 File Offset: 0x000D5108
		[Token(Token = "0x6029E6E")]
		[Address(RVA = "0x2591110", Offset = "0x258FD10", VA = "0x182591110", Slot = "10")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x06029E6F RID: 171631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E6F")]
		[Address(RVA = "0x25912F0", Offset = "0x258FEF0", VA = "0x1825912F0", Slot = "11")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x06029E70 RID: 171632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E70")]
		[Address(RVA = "0x2591270", Offset = "0x258FE70", VA = "0x182591270", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x06029E71 RID: 171633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E71")]
		[Address(RVA = "0x25910A0", Offset = "0x258FCA0", VA = "0x1825910A0", Slot = "5")]
		protected override void BeforeUnload()
		{
		}

		// Token: 0x06029E72 RID: 171634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E72")]
		[Address(RVA = "0x2591210", Offset = "0x258FE10", VA = "0x182591210")]
		private void OnDestroy()
		{
		}

		// Token: 0x06029E73 RID: 171635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E73")]
		[Address(RVA = "0x2591410", Offset = "0x2590010", VA = "0x182591410")]
		public Act3D0StageMapDecor()
		{
		}

		// Token: 0x06029E74 RID: 171636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E74")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x06029E75 RID: 171637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E75")]
		[Address(RVA = "0x22E9250", Offset = "0x22E7E50", VA = "0x1822E9250")]
		private void <>xLuaBaseProxy_BeforeUnload()
		{
		}

		// Token: 0x0403C0D3 RID: 245971
		[Token(Token = "0x403C0D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _coinCount;

		// Token: 0x0403C0D4 RID: 245972
		[Token(Token = "0x403C0D4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _mileStoneCount;

		// Token: 0x0403C0D5 RID: 245973
		[Token(Token = "0x403C0D5")]
		[FieldOffset(Offset = "0x30")]
		private string m_actId;

		// Token: 0x0403C0D6 RID: 245974
		[Token(Token = "0x403C0D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0403C0D7 RID: 245975
		[Token(Token = "0x403C0D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0403C0D8 RID: 245976
		[Token(Token = "0x403C0D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403C0D9 RID: 245977
		[Token(Token = "0x403C0D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x0403C0DA RID: 245978
		[Token(Token = "0x403C0DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403C0DB RID: 245979
		[Token(Token = "0x403C0DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
