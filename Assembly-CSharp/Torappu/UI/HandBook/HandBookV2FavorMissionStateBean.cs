using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006719 RID: 26393
	[Token(Token = "0x2006719")]
	public class HandBookV2FavorMissionStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x06025DE8 RID: 155112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DE8")]
		[Address(RVA = "0x20D26D0", Offset = "0x20D12D0", VA = "0x1820D26D0")]
		public void RefreshData()
		{
		}

		// Token: 0x06025DE9 RID: 155113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DE9")]
		[Address(RVA = "0x20D2790", Offset = "0x20D1390", VA = "0x1820D2790")]
		public void RefreshRewardState()
		{
		}

		// Token: 0x06025DEA RID: 155114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DEA")]
		[Address(RVA = "0x20D2840", Offset = "0x20D1440", VA = "0x1820D2840")]
		private void _RefreshData()
		{
		}

		// Token: 0x06025DEB RID: 155115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DEB")]
		[Address(RVA = "0x20D32D0", Offset = "0x20D1ED0", VA = "0x1820D32D0")]
		public HandBookV2FavorMissionStateBean()
		{
		}

		// Token: 0x04035435 RID: 218165
		[Token(Token = "0x4035435")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2FavorMissionProperty _favorMissionProperty;

		// Token: 0x04035436 RID: 218166
		[Token(Token = "0x4035436")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, List<HandBookV2MissionListItemModel.CharacterFavorData>> m_forceId2CharDataListMap;

		// Token: 0x04035437 RID: 218167
		[Token(Token = "0x4035437")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, HandBookV2ForceFavorViewModel> m_forceId2FavorModelMap;

		// Token: 0x04035438 RID: 218168
		[Token(Token = "0x4035438")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_cachedIdList;

		// Token: 0x04035439 RID: 218169
		[Token(Token = "0x4035439")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403543A RID: 218170
		[Token(Token = "0x403543A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshRewardState;

		// Token: 0x0403543B RID: 218171
		[Token(Token = "0x403543B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x0403543C RID: 218172
		[Token(Token = "0x403543C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
