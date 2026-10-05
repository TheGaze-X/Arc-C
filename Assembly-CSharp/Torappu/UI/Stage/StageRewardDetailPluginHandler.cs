using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200692B RID: 26923
	[Token(Token = "0x200692B")]
	public class StageRewardDetailPluginHandler : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B0B RID: 23307
		// (get) Token: 0x060268F8 RID: 157944 RVA: 0x000CBB50 File Offset: 0x000C9D50
		[Token(Token = "0x17005B0B")]
		public bool hasValidPlugin
		{
			[Token(Token = "0x60268F8")]
			[Address(RVA = "0x21B7060", Offset = "0x21B5C60", VA = "0x1821B7060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060268F9 RID: 157945 RVA: 0x000CBB68 File Offset: 0x000C9D68
		[Token(Token = "0x60268F9")]
		[Address(RVA = "0x21B6D30", Offset = "0x21B5930", VA = "0x1821B6D30")]
		public bool TryGetBgTint(out Color bgTint)
		{
			return default(bool);
		}

		// Token: 0x060268FA RID: 157946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268FA")]
		[Address(RVA = "0x21B67D0", Offset = "0x21B53D0", VA = "0x1821B67D0")]
		public void Init(StageData stageData, ILoadAsset assetLoader, RectTransform pluginContainer)
		{
		}

		// Token: 0x060268FB RID: 157947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268FB")]
		[Address(RVA = "0x21B6EB0", Offset = "0x21B5AB0", VA = "0x1821B6EB0")]
		private void _ReleasePluginView()
		{
		}

		// Token: 0x060268FC RID: 157948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268FC")]
		[Address(RVA = "0x21B6B20", Offset = "0x21B5720", VA = "0x1821B6B20")]
		public void RenderRewardPlugin(bool getFlag, bool completeFlag)
		{
		}

		// Token: 0x060268FD RID: 157949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268FD")]
		[Address(RVA = "0x21B6700", Offset = "0x21B5300", VA = "0x1821B6700")]
		public void ForceRebuildLayout()
		{
		}

		// Token: 0x060268FE RID: 157950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268FE")]
		[Address(RVA = "0x21B7000", Offset = "0x21B5C00", VA = "0x1821B7000")]
		public StageRewardDetailPluginHandler()
		{
		}

		// Token: 0x04036633 RID: 222771
		[Token(Token = "0x4036633")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform m_pluginContainer;

		// Token: 0x04036634 RID: 222772
		[Token(Token = "0x4036634")]
		[FieldOffset(Offset = "0x20")]
		private string m_cacheActId;

		// Token: 0x04036635 RID: 222773
		[Token(Token = "0x4036635")]
		[FieldOffset(Offset = "0x28")]
		private StageData m_stageData;

		// Token: 0x04036636 RID: 222774
		[Token(Token = "0x4036636")]
		[FieldOffset(Offset = "0x30")]
		private StagePreviewActPlugin m_plugin;

		// Token: 0x04036637 RID: 222775
		[Token(Token = "0x4036637")]
		[FieldOffset(Offset = "0x38")]
		private StageRewardDetailPluginView m_pluginView;

		// Token: 0x04036638 RID: 222776
		[Token(Token = "0x4036638")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasValidPlugin;

		// Token: 0x04036639 RID: 222777
		[Token(Token = "0x4036639")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetBgTint;

		// Token: 0x0403663A RID: 222778
		[Token(Token = "0x403663A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403663B RID: 222779
		[Token(Token = "0x403663B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ReleasePluginView;

		// Token: 0x0403663C RID: 222780
		[Token(Token = "0x403663C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderRewardPlugin;

		// Token: 0x0403663D RID: 222781
		[Token(Token = "0x403663D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ForceRebuildLayout;

		// Token: 0x0403663E RID: 222782
		[Token(Token = "0x403663E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
