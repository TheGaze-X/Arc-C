using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073E3 RID: 29667
	[Token(Token = "0x20073E3")]
	public class Act3D0StagePreview : ActivityStageSingleComponent, IPlayerDataListener, IHotfixable
	{
		// Token: 0x06029E76 RID: 171638 RVA: 0x000D6F20 File Offset: 0x000D5120
		[Token(Token = "0x6029E76")]
		[Address(RVA = "0x25914E0", Offset = "0x25900E0", VA = "0x1825914E0", Slot = "10")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x06029E77 RID: 171639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E77")]
		[Address(RVA = "0x25916C0", Offset = "0x25902C0", VA = "0x1825916C0", Slot = "11")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x06029E78 RID: 171640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E78")]
		[Address(RVA = "0x2591640", Offset = "0x2590240", VA = "0x182591640", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x06029E79 RID: 171641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E79")]
		[Address(RVA = "0x2591470", Offset = "0x2590070", VA = "0x182591470", Slot = "5")]
		protected override void BeforeUnload()
		{
		}

		// Token: 0x06029E7A RID: 171642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E7A")]
		[Address(RVA = "0x25915E0", Offset = "0x25901E0", VA = "0x1825915E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06029E7B RID: 171643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E7B")]
		[Address(RVA = "0x25917E0", Offset = "0x25903E0", VA = "0x1825917E0")]
		public Act3D0StagePreview()
		{
		}

		// Token: 0x06029E7C RID: 171644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E7C")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x06029E7D RID: 171645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E7D")]
		[Address(RVA = "0x22E9250", Offset = "0x22E7E50", VA = "0x1822E9250")]
		private void <>xLuaBaseProxy_BeforeUnload()
		{
		}

		// Token: 0x0403C0DC RID: 245980
		[Token(Token = "0x403C0DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _coinCount;

		// Token: 0x0403C0DD RID: 245981
		[Token(Token = "0x403C0DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _mileStoneCount;

		// Token: 0x0403C0DE RID: 245982
		[Token(Token = "0x403C0DE")]
		[FieldOffset(Offset = "0x30")]
		private string m_actId;

		// Token: 0x0403C0DF RID: 245983
		[Token(Token = "0x403C0DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0403C0E0 RID: 245984
		[Token(Token = "0x403C0E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0403C0E1 RID: 245985
		[Token(Token = "0x403C0E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403C0E2 RID: 245986
		[Token(Token = "0x403C0E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x0403C0E3 RID: 245987
		[Token(Token = "0x403C0E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403C0E4 RID: 245988
		[Token(Token = "0x403C0E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
