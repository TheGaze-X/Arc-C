using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200610C RID: 24844
	[Token(Token = "0x200610C")]
	public class CampaignWorldObjectHolder<ViewType, ConfigType> : MonoBehaviour, IHotfixable where ViewType : MonoBehaviour
	{
		// Token: 0x170054CA RID: 21706
		// (get) Token: 0x06023E5D RID: 147037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054CA")]
		public string id
		{
			[Token(Token = "0x6023E5D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054CB RID: 21707
		// (get) Token: 0x06023E5E RID: 147038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054CB")]
		public ViewType viewPrefab
		{
			[Token(Token = "0x6023E5E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170054CC RID: 21708
		// (get) Token: 0x06023E5F RID: 147039 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023E60 RID: 147040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054CC")]
		public ConfigType config
		{
			[Token(Token = "0x6023E5F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6023E60")]
			set
			{
			}
		}

		// Token: 0x170054CD RID: 21709
		// (get) Token: 0x06023E61 RID: 147041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170054CD")]
		public ViewType view
		{
			[Token(Token = "0x6023E61")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023E62 RID: 147042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E62")]
		public ViewType TryCreateView()
		{
			return null;
		}

		// Token: 0x06023E63 RID: 147043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E63")]
		public CampaignWorldObjectHolder()
		{
		}

		// Token: 0x04031CFE RID: 204030
		[Token(Token = "0x4031CFE")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string _id;

		// Token: 0x04031CFF RID: 204031
		[Token(Token = "0x4031CFF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ViewType _viewPrefab;

		// Token: 0x04031D00 RID: 204032
		[Token(Token = "0x4031D00")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ConfigType _config;

		// Token: 0x04031D01 RID: 204033
		[Token(Token = "0x4031D01")]
		[FieldOffset(Offset = "0x0")]
		private ViewType m_view;

		// Token: 0x04031D02 RID: 204034
		[Token(Token = "0x4031D02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x04031D03 RID: 204035
		[Token(Token = "0x4031D03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewPrefab;

		// Token: 0x04031D04 RID: 204036
		[Token(Token = "0x4031D04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_config;

		// Token: 0x04031D05 RID: 204037
		[Token(Token = "0x4031D05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_config;

		// Token: 0x04031D06 RID: 204038
		[Token(Token = "0x4031D06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_view;

		// Token: 0x04031D07 RID: 204039
		[Token(Token = "0x4031D07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryCreateView;

		// Token: 0x04031D08 RID: 204040
		[Token(Token = "0x4031D08")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
