using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006672 RID: 26226
	[Token(Token = "0x2006672")]
	public class HandBookMissionStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06025A82 RID: 154242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A82")]
		[Address(RVA = "0x209B1F0", Offset = "0x2099DF0", VA = "0x18209B1F0")]
		public void ApplyMissionData()
		{
		}

		// Token: 0x06025A83 RID: 154243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A83")]
		[Address(RVA = "0x209B450", Offset = "0x209A050", VA = "0x18209B450")]
		public void InitData()
		{
		}

		// Token: 0x06025A84 RID: 154244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A84")]
		[Address(RVA = "0x209B960", Offset = "0x209A560", VA = "0x18209B960")]
		public HandBookMissionStateBean()
		{
		}

		// Token: 0x04034E5F RID: 216671
		[Token(Token = "0x4034E5F")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<HandBookMissionViewModel> missionList;

		// Token: 0x04034E60 RID: 216672
		[Token(Token = "0x4034E60")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Dictionary<string, HandBookCardViewModel> cardList;

		// Token: 0x04034E61 RID: 216673
		[Token(Token = "0x4034E61")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Dictionary<string, HandBookCommonStateBean.HandBookTeamViewModel> friendshipTeamData;

		// Token: 0x04034E62 RID: 216674
		[Token(Token = "0x4034E62")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public bool isInited;

		// Token: 0x04034E63 RID: 216675
		[Token(Token = "0x4034E63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyMissionData;

		// Token: 0x04034E64 RID: 216676
		[Token(Token = "0x4034E64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04034E65 RID: 216677
		[Token(Token = "0x4034E65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
