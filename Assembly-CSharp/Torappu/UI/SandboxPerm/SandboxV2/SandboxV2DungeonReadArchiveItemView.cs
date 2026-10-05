using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041B0 RID: 16816
	[Token(Token = "0x20041B0")]
	public class SandboxV2DungeonReadArchiveItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019EEE RID: 106222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EEE")]
		[Address(RVA = "0x12E02C0", Offset = "0x12DEEC0", VA = "0x1812E02C0")]
		public void Render(SandboxV2DungeonReadArchiveItemModel model)
		{
		}

		// Token: 0x06019EEF RID: 106223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EEF")]
		[Address(RVA = "0x12E05A0", Offset = "0x12DF1A0", VA = "0x1812E05A0")]
		public void SetTweenShow(bool isShow)
		{
		}

		// Token: 0x06019EF0 RID: 106224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EF0")]
		[Address(RVA = "0x12E0630", Offset = "0x12DF230", VA = "0x1812E0630")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019EF1 RID: 106225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EF1")]
		[Address(RVA = "0x12E0180", Offset = "0x12DED80", VA = "0x1812E0180")]
		public void OnArchiveItemClick()
		{
		}

		// Token: 0x06019EF2 RID: 106226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EF2")]
		[Address(RVA = "0x12E0830", Offset = "0x12DF430", VA = "0x1812E0830")]
		public SandboxV2DungeonReadArchiveItemView()
		{
		}

		// Token: 0x04020A5C RID: 133724
		[Token(Token = "0x4020A5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animLocation;

		// Token: 0x04020A5D RID: 133725
		[Token(Token = "0x4020A5D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtDayTitle;

		// Token: 0x04020A5E RID: 133726
		[Token(Token = "0x4020A5E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtDayCount;

		// Token: 0x04020A5F RID: 133727
		[Token(Token = "0x4020A5F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _transSeasonAngle;

		// Token: 0x04020A60 RID: 133728
		[Token(Token = "0x4020A60")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _apListContent;

		// Token: 0x04020A61 RID: 133729
		[Token(Token = "0x4020A61")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04020A62 RID: 133730
		[Token(Token = "0x4020A62")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04020A63 RID: 133731
		[Token(Token = "0x4020A63")]
		[FieldOffset(Offset = "0x60")]
		private SandboxV2DungeonReadArchiveItemModel m_model;

		// Token: 0x04020A64 RID: 133732
		[Token(Token = "0x4020A64")]
		[FieldOffset(Offset = "0x68")]
		private SandboxV2DungeonReadArchiveItemView.ApItemListAdapter m_adapter;

		// Token: 0x04020A65 RID: 133733
		[Token(Token = "0x4020A65")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_tween;

		// Token: 0x04020A66 RID: 133734
		[Token(Token = "0x4020A66")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020A67 RID: 133735
		[Token(Token = "0x4020A67")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetTweenShow;

		// Token: 0x04020A68 RID: 133736
		[Token(Token = "0x4020A68")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020A69 RID: 133737
		[Token(Token = "0x4020A69")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnArchiveItemClick;

		// Token: 0x04020A6A RID: 133738
		[Token(Token = "0x4020A6A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041B1 RID: 16817
		[Token(Token = "0x20041B1")]
		private class ApItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06019EF3 RID: 106227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019EF3")]
			[Address(RVA = "0x12CC100", Offset = "0x12CAD00", VA = "0x1812CC100")]
			public ApItemListAdapter(SandboxV2DungeonReadArchiveItemView closure)
			{
			}

			// Token: 0x17003DC2 RID: 15810
			// (get) Token: 0x06019EF4 RID: 106228 RVA: 0x0009FC48 File Offset: 0x0009DE48
			[Token(Token = "0x17003DC2")]
			public override int count
			{
				[Token(Token = "0x6019EF4")]
				[Address(RVA = "0x12CC3A0", Offset = "0x12CAFA0", VA = "0x1812CC3A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019EF5 RID: 106229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019EF5")]
			[Address(RVA = "0x12CBC70", Offset = "0x12CA870", VA = "0x1812CBC70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020A6B RID: 133739
			[Token(Token = "0x4020A6B")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonReadArchiveItemView m_closure;

			// Token: 0x04020A6C RID: 133740
			[Token(Token = "0x4020A6C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020A6D RID: 133741
			[Token(Token = "0x4020A6D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020A6E RID: 133742
			[Token(Token = "0x4020A6E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
