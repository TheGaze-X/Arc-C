using System;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Activity.Act3fun.Battle.UI
{
	// Token: 0x020073C0 RID: 29632
	[Token(Token = "0x20073C0")]
	[Serializable]
	public class Act3funTopbarStatus
	{
		// Token: 0x06029DD3 RID: 171475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DD3")]
		[Address(RVA = "0x256F180", Offset = "0x256DD80", VA = "0x18256F180")]
		public void Init(Transform parent)
		{
		}

		// Token: 0x06029DD4 RID: 171476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DD4")]
		[Address(RVA = "0x256F300", Offset = "0x256DF00", VA = "0x18256F300")]
		public void UpdateData(BattleController controller, bool force)
		{
		}

		// Token: 0x06029DD5 RID: 171477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DD5")]
		[Address(RVA = "0x256F5A0", Offset = "0x256E1A0", VA = "0x18256F5A0")]
		private void _UpdateBattleTimeInfo(BattleController controller)
		{
		}

		// Token: 0x06029DD6 RID: 171478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DD6")]
		[Address(RVA = "0x256F6F0", Offset = "0x256E2F0", VA = "0x18256F6F0")]
		private void _UpdateKillCntInfo(BattleController controller)
		{
		}

		// Token: 0x06029DD7 RID: 171479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DD7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act3funTopbarStatus()
		{
		}

		// Token: 0x0403BFE9 RID: 245737
		[Token(Token = "0x403BFE9")]
		[FieldOffset(Offset = "0x10")]
		public GameObject container;

		// Token: 0x0403BFEA RID: 245738
		[Token(Token = "0x403BFEA")]
		[FieldOffset(Offset = "0x18")]
		public Animation killCntIconAnimation;

		// Token: 0x0403BFEB RID: 245739
		[Token(Token = "0x403BFEB")]
		[FieldOffset(Offset = "0x20")]
		public Text killCntText;

		// Token: 0x0403BFEC RID: 245740
		[Token(Token = "0x403BFEC")]
		[FieldOffset(Offset = "0x28")]
		public Text battleTimeText;

		// Token: 0x0403BFED RID: 245741
		[Token(Token = "0x403BFED")]
		[FieldOffset(Offset = "0x30")]
		private int m_killCnt;

		// Token: 0x0403BFEE RID: 245742
		[Token(Token = "0x403BFEE")]
		[FieldOffset(Offset = "0x34")]
		private int m_playTime;
	}
}
