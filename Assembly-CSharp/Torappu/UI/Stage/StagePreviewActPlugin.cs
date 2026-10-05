using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200691F RID: 26911
	[Token(Token = "0x200691F")]
	public abstract class StagePreviewActPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005AFF RID: 23295
		// (get) Token: 0x060268BD RID: 157885 RVA: 0x000CB970 File Offset: 0x000C9B70
		[Token(Token = "0x17005AFF")]
		public bool overrideRewardPreview
		{
			[Token(Token = "0x60268BD")]
			[Address(RVA = "0x21A1E00", Offset = "0x21A0A00", VA = "0x1821A1E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B00 RID: 23296
		// (get) Token: 0x060268BE RID: 157886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B00")]
		public StageRewardPreviewPluginView rewardPreviewPlugin
		{
			[Token(Token = "0x60268BE")]
			[Address(RVA = "0x21A1EF0", Offset = "0x21A0AF0", VA = "0x1821A1EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B01 RID: 23297
		// (get) Token: 0x060268BF RID: 157887 RVA: 0x000CB988 File Offset: 0x000C9B88
		[Token(Token = "0x17005B01")]
		public bool overrideMapPreview
		{
			[Token(Token = "0x60268BF")]
			[Address(RVA = "0x21A1CE0", Offset = "0x21A08E0", VA = "0x1821A1CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B02 RID: 23298
		// (get) Token: 0x060268C0 RID: 157888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B02")]
		public StageMapPreviewPluginView mapPreviewPlugin
		{
			[Token(Token = "0x60268C0")]
			[Address(RVA = "0x21A1C80", Offset = "0x21A0880", VA = "0x1821A1C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B03 RID: 23299
		// (get) Token: 0x060268C1 RID: 157889 RVA: 0x000CB9A0 File Offset: 0x000C9BA0
		[Token(Token = "0x17005B03")]
		public bool overrideRewardDetail
		{
			[Token(Token = "0x60268C1")]
			[Address(RVA = "0x21A1D70", Offset = "0x21A0970", VA = "0x1821A1D70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B04 RID: 23300
		// (get) Token: 0x060268C2 RID: 157890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B04")]
		public StageRewardDetailPluginView rewardDetailPlugin
		{
			[Token(Token = "0x60268C2")]
			[Address(RVA = "0x21A1E90", Offset = "0x21A0A90", VA = "0x1821A1E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060268C3 RID: 157891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60268C3")]
		[Address(RVA = "0x21A1AE0", Offset = "0x21A06E0", VA = "0x1821A1AE0", Slot = "4")]
		public virtual Sprite LoadMapPreview(string actId, string stageId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060268C4 RID: 157892 RVA: 0x000CB9B8 File Offset: 0x000C9BB8
		[Token(Token = "0x60268C4")]
		[Address(RVA = "0x21A1B80", Offset = "0x21A0780", VA = "0x1821A1B80", Slot = "5")]
		public virtual bool TryGetRewardDetailBgTint(string actId, string stageId, out Color bgTint)
		{
			return default(bool);
		}

		// Token: 0x060268C5 RID: 157893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268C5")]
		[Address(RVA = "0x21A1C20", Offset = "0x21A0820", VA = "0x1821A1C20")]
		protected StagePreviewActPlugin()
		{
		}

		// Token: 0x040365D2 RID: 222674
		[Token(Token = "0x40365D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageRewardPreviewPluginView _rewardPreviewPlugin;

		// Token: 0x040365D3 RID: 222675
		[Token(Token = "0x40365D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageMapPreviewPluginView _mapPreviewPlugin;

		// Token: 0x040365D4 RID: 222676
		[Token(Token = "0x40365D4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StageRewardDetailPluginView _rewardDetailPlugin;

		// Token: 0x040365D5 RID: 222677
		[Token(Token = "0x40365D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_overrideRewardPreview;

		// Token: 0x040365D6 RID: 222678
		[Token(Token = "0x40365D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_rewardPreviewPlugin;

		// Token: 0x040365D7 RID: 222679
		[Token(Token = "0x40365D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_overrideMapPreview;

		// Token: 0x040365D8 RID: 222680
		[Token(Token = "0x40365D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_mapPreviewPlugin;

		// Token: 0x040365D9 RID: 222681
		[Token(Token = "0x40365D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_overrideRewardDetail;

		// Token: 0x040365DA RID: 222682
		[Token(Token = "0x40365DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_rewardDetailPlugin;

		// Token: 0x040365DB RID: 222683
		[Token(Token = "0x40365DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadMapPreview;

		// Token: 0x040365DC RID: 222684
		[Token(Token = "0x40365DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryGetRewardDetailBgTint;

		// Token: 0x040365DD RID: 222685
		[Token(Token = "0x40365DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
