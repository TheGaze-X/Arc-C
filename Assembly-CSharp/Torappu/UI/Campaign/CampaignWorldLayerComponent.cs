using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006108 RID: 24840
	[Token(Token = "0x2006108")]
	public class CampaignWorldLayerComponent : MonoBehaviour, IHotfixable
	{
		// Token: 0x170054C9 RID: 21705
		// (get) Token: 0x06023E55 RID: 147029 RVA: 0x000C2520 File Offset: 0x000C0720
		[Token(Token = "0x170054C9")]
		public CampaignWorldLayer layer
		{
			[Token(Token = "0x6023E55")]
			[Address(RVA = "0x1E8D260", Offset = "0x1E8BE60", VA = "0x181E8D260")]
			get
			{
				return CampaignWorldLayer.DEFAULT;
			}
		}

		// Token: 0x06023E56 RID: 147030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E56")]
		[Address(RVA = "0x1E8D0B0", Offset = "0x1E8BCB0", VA = "0x181E8D0B0")]
		public void Start()
		{
		}

		// Token: 0x06023E57 RID: 147031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E57")]
		[Address(RVA = "0x1E8D200", Offset = "0x1E8BE00", VA = "0x181E8D200")]
		public CampaignWorldLayerComponent()
		{
		}

		// Token: 0x04031CEB RID: 204011
		[Token(Token = "0x4031CEB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CampaignWorldLayer _layer;

		// Token: 0x04031CEC RID: 204012
		[Token(Token = "0x4031CEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_layer;

		// Token: 0x04031CED RID: 204013
		[Token(Token = "0x4031CED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04031CEE RID: 204014
		[Token(Token = "0x4031CEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
