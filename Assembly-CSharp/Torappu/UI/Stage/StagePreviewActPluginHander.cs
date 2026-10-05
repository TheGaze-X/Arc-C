using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006922 RID: 26914
	[Token(Token = "0x2006922")]
	public class StagePreviewActPluginHander : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B05 RID: 23301
		// (get) Token: 0x060268CA RID: 157898 RVA: 0x000CB9D0 File Offset: 0x000C9BD0
		[Token(Token = "0x17005B05")]
		public bool overrideMapPreview
		{
			[Token(Token = "0x60268CA")]
			[Address(RVA = "0x21A19E0", Offset = "0x21A05E0", VA = "0x1821A19E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B06 RID: 23302
		// (get) Token: 0x060268CB RID: 157899 RVA: 0x000CB9E8 File Offset: 0x000C9BE8
		[Token(Token = "0x17005B06")]
		public bool overrideRewardPreview
		{
			[Token(Token = "0x60268CB")]
			[Address(RVA = "0x21A1A60", Offset = "0x21A0660", VA = "0x1821A1A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B07 RID: 23303
		// (get) Token: 0x060268CC RID: 157900 RVA: 0x000CBA00 File Offset: 0x000C9C00
		[Token(Token = "0x17005B07")]
		public bool hasValidPlugin
		{
			[Token(Token = "0x60268CC")]
			[Address(RVA = "0x21A1940", Offset = "0x21A0540", VA = "0x1821A1940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060268CD RID: 157901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268CD")]
		[Address(RVA = "0x21A0D40", Offset = "0x219F940", VA = "0x1821A0D40")]
		public void Init(StageViewModel stageModel, ILoadAsset assetLoader, RectTransform mapPreviewPluginContainer)
		{
		}

		// Token: 0x060268CE RID: 157902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268CE")]
		[Address(RVA = "0x21A14C0", Offset = "0x21A00C0", VA = "0x1821A14C0")]
		public void UpdateRewardPreview(StageViewModel selectedStage, Action onRewardClick)
		{
		}

		// Token: 0x060268CF RID: 157903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268CF")]
		[Address(RVA = "0x21A11B0", Offset = "0x219FDB0", VA = "0x1821A11B0")]
		public void SetRewardPreviewVisible(bool isCustom)
		{
		}

		// Token: 0x060268D0 RID: 157904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268D0")]
		[Address(RVA = "0x21A1280", Offset = "0x219FE80", VA = "0x1821A1280")]
		public void ShowMapPreview(StageData previewStageData, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060268D1 RID: 157905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60268D1")]
		[Address(RVA = "0x21A1080", Offset = "0x219FC80", VA = "0x1821A1080")]
		public Sprite LoadMapPreview(string stageId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060268D2 RID: 157906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268D2")]
		[Address(RVA = "0x21A1700", Offset = "0x21A0300", VA = "0x1821A1700")]
		private void _ReleasePluginView()
		{
		}

		// Token: 0x060268D3 RID: 157907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268D3")]
		[Address(RVA = "0x21A18E0", Offset = "0x21A04E0", VA = "0x1821A18E0")]
		public StagePreviewActPluginHander()
		{
		}

		// Token: 0x040365E0 RID: 222688
		[Token(Token = "0x40365E0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rewardPreviewPluginContainer;

		// Token: 0x040365E1 RID: 222689
		[Token(Token = "0x40365E1")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_mapPreviewPluginContainer;

		// Token: 0x040365E2 RID: 222690
		[Token(Token = "0x40365E2")]
		[FieldOffset(Offset = "0x28")]
		private string m_cacheActId;

		// Token: 0x040365E3 RID: 222691
		[Token(Token = "0x40365E3")]
		[FieldOffset(Offset = "0x30")]
		private StagePreviewActPlugin m_plugin;

		// Token: 0x040365E4 RID: 222692
		[Token(Token = "0x40365E4")]
		[FieldOffset(Offset = "0x38")]
		private StageRewardPreviewPluginView m_rewardPreviewPlugin;

		// Token: 0x040365E5 RID: 222693
		[Token(Token = "0x40365E5")]
		[FieldOffset(Offset = "0x40")]
		private StageMapPreviewPluginView m_mapPreviewPlugin;

		// Token: 0x040365E6 RID: 222694
		[Token(Token = "0x40365E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_overrideMapPreview;

		// Token: 0x040365E7 RID: 222695
		[Token(Token = "0x40365E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_overrideRewardPreview;

		// Token: 0x040365E8 RID: 222696
		[Token(Token = "0x40365E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasValidPlugin;

		// Token: 0x040365E9 RID: 222697
		[Token(Token = "0x40365E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040365EA RID: 222698
		[Token(Token = "0x40365EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateRewardPreview;

		// Token: 0x040365EB RID: 222699
		[Token(Token = "0x40365EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetRewardPreviewVisible;

		// Token: 0x040365EC RID: 222700
		[Token(Token = "0x40365EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowMapPreview;

		// Token: 0x040365ED RID: 222701
		[Token(Token = "0x40365ED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadMapPreview;

		// Token: 0x040365EE RID: 222702
		[Token(Token = "0x40365EE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ReleasePluginView;

		// Token: 0x040365EF RID: 222703
		[Token(Token = "0x40365EF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
