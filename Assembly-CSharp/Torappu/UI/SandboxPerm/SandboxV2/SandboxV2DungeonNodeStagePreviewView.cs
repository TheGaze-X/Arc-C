using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004267 RID: 16999
	[Token(Token = "0x2004267")]
	public class SandboxV2DungeonNodeStagePreviewView : DataBinder<SandboxV2DungeonNodeStagePreviewProperty>
	{
		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x0601A32D RID: 107309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A32E RID: 107310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E37")]
		public ILoadAsset assetLoader
		{
			[Token(Token = "0x601A32D")]
			[Address(RVA = "0x1319F40", Offset = "0x1318B40", VA = "0x181319F40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A32E")]
			[Address(RVA = "0x131A000", Offset = "0x1318C00", VA = "0x18131A000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x0601A32F RID: 107311 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A330 RID: 107312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E38")]
		public Action backEvent
		{
			[Token(Token = "0x601A32F")]
			[Address(RVA = "0x1319FA0", Offset = "0x1318BA0", VA = "0x181319FA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A330")]
			[Address(RVA = "0x131A080", Offset = "0x1318C80", VA = "0x18131A080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A331 RID: 107313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A331")]
		[Address(RVA = "0x1319970", Offset = "0x1318570", VA = "0x181319970")]
		public void OnBackEvent()
		{
		}

		// Token: 0x0601A332 RID: 107314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A332")]
		[Address(RVA = "0x1319A80", Offset = "0x1318680", VA = "0x181319A80", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonNodeStagePreviewProperty property)
		{
		}

		// Token: 0x0601A333 RID: 107315 RVA: 0x000A0788 File Offset: 0x0009E988
		[Token(Token = "0x601A333")]
		[Address(RVA = "0x1319DB0", Offset = "0x13189B0", VA = "0x181319DB0")]
		private static Vector2 _FitSizeRetainRatio(Vector2 raw, Vector2 max)
		{
			return default(Vector2);
		}

		// Token: 0x0601A334 RID: 107316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A334")]
		[Address(RVA = "0x1319ED0", Offset = "0x1318AD0", VA = "0x181319ED0")]
		public SandboxV2DungeonNodeStagePreviewView()
		{
		}

		// Token: 0x0402121C RID: 135708
		[Token(Token = "0x402121C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _stageImage;

		// Token: 0x0402121D RID: 135709
		[Token(Token = "0x402121D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _stageRect;

		// Token: 0x0402121E RID: 135710
		[Token(Token = "0x402121E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _maxSize;

		// Token: 0x0402121F RID: 135711
		[Token(Token = "0x402121F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _frameWidth;

		// Token: 0x04021220 RID: 135712
		[Token(Token = "0x4021220")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedTopicId;

		// Token: 0x04021221 RID: 135713
		[Token(Token = "0x4021221")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedStageId;

		// Token: 0x04021224 RID: 135716
		[Token(Token = "0x4021224")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x04021225 RID: 135717
		[Token(Token = "0x4021225")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_assetLoader;

		// Token: 0x04021226 RID: 135718
		[Token(Token = "0x4021226")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_backEvent;

		// Token: 0x04021227 RID: 135719
		[Token(Token = "0x4021227")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_backEvent;

		// Token: 0x04021228 RID: 135720
		[Token(Token = "0x4021228")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x04021229 RID: 135721
		[Token(Token = "0x4021229")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402122A RID: 135722
		[Token(Token = "0x402122A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FitSizeRetainRatio;

		// Token: 0x0402122B RID: 135723
		[Token(Token = "0x402122B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
