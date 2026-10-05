using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200610A RID: 24842
	[Token(Token = "0x200610A")]
	public class CampaignWorldLayerManager : SingletonMonoBehaviour<CampaignWorldLayerManager>, IHotfixable
	{
		// Token: 0x06023E58 RID: 147032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E58")]
		[Address(RVA = "0x1E8D2C0", Offset = "0x1E8BEC0", VA = "0x181E8D2C0")]
		public static void SetComponentLayer(CampaignWorldLayerComponent comp)
		{
		}

		// Token: 0x06023E59 RID: 147033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E59")]
		[Address(RVA = "0x1E8D4D0", Offset = "0x1E8C0D0", VA = "0x181E8D4D0")]
		private void _SetComponentLayer(CampaignWorldLayerComponent comp)
		{
		}

		// Token: 0x06023E5A RID: 147034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E5A")]
		[Address(RVA = "0x1E8D3D0", Offset = "0x1E8BFD0", VA = "0x181E8D3D0")]
		private RectTransform _GetLayerTrans(CampaignWorldLayer layer)
		{
			return null;
		}

		// Token: 0x06023E5B RID: 147035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E5B")]
		[Address(RVA = "0x1E8D710", Offset = "0x1E8C310", VA = "0x181E8D710")]
		public CampaignWorldLayerManager()
		{
		}

		// Token: 0x04031CF7 RID: 204023
		[Token(Token = "0x4031CF7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CampaignWorldLayerManager.Layer> _layers;

		// Token: 0x04031CF8 RID: 204024
		[Token(Token = "0x4031CF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetComponentLayer;

		// Token: 0x04031CF9 RID: 204025
		[Token(Token = "0x4031CF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetComponentLayer;

		// Token: 0x04031CFA RID: 204026
		[Token(Token = "0x4031CFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetLayerTrans;

		// Token: 0x04031CFB RID: 204027
		[Token(Token = "0x4031CFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200610B RID: 24843
		[Token(Token = "0x200610B")]
		[Serializable]
		public class Layer
		{
			// Token: 0x06023E5C RID: 147036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023E5C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Layer()
			{
			}

			// Token: 0x04031CFC RID: 204028
			[Token(Token = "0x4031CFC")]
			[FieldOffset(Offset = "0x10")]
			public CampaignWorldLayer layer;

			// Token: 0x04031CFD RID: 204029
			[Token(Token = "0x4031CFD")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform trans;
		}
	}
}
