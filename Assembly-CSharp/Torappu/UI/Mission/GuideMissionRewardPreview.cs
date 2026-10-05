using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004862 RID: 18530
	[Token(Token = "0x2004862")]
	public class GuideMissionRewardPreview : DataBinder<GuideMissionRewardPreviewProp>
	{
		// Token: 0x0601BFD4 RID: 114644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFD4")]
		[Address(RVA = "0x154CE20", Offset = "0x154BA20", VA = "0x18154CE20", Slot = "7")]
		public override void OnValueChanged(GuideMissionRewardPreviewProp property)
		{
		}

		// Token: 0x0601BFD5 RID: 114645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFD5")]
		[Address(RVA = "0x154CFF0", Offset = "0x154BBF0", VA = "0x18154CFF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BFD6 RID: 114646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFD6")]
		[Address(RVA = "0x154D110", Offset = "0x154BD10", VA = "0x18154D110")]
		public GuideMissionRewardPreview()
		{
		}

		// Token: 0x04024821 RID: 149537
		[Token(Token = "0x4024821")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _groupList;

		// Token: 0x04024822 RID: 149538
		[Token(Token = "0x4024822")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalRewardPrefab;

		// Token: 0x04024823 RID: 149539
		[Token(Token = "0x4024823")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _charRewardPrefab;

		// Token: 0x04024824 RID: 149540
		[Token(Token = "0x4024824")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04024825 RID: 149541
		[Token(Token = "0x4024825")]
		[FieldOffset(Offset = "0x40")]
		private GuideMissionRewardPreview.RewardListAdapter m_rewardListAdapter;

		// Token: 0x04024826 RID: 149542
		[Token(Token = "0x4024826")]
		[FieldOffset(Offset = "0x48")]
		private GuideMissionRewardPreviewModel m_rewardModel;

		// Token: 0x04024827 RID: 149543
		[Token(Token = "0x4024827")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024828 RID: 149544
		[Token(Token = "0x4024828")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024829 RID: 149545
		[Token(Token = "0x4024829")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004863 RID: 18531
		[Token(Token = "0x2004863")]
		private class RewardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601BFD7 RID: 114647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BFD7")]
			[Address(RVA = "0x15604E0", Offset = "0x155F0E0", VA = "0x1815604E0")]
			public RewardListAdapter(GuideMissionRewardPreview closure)
			{
			}

			// Token: 0x17004284 RID: 17028
			// (get) Token: 0x0601BFD8 RID: 114648 RVA: 0x000A6CF8 File Offset: 0x000A4EF8
			[Token(Token = "0x17004284")]
			public override int count
			{
				[Token(Token = "0x601BFD8")]
				[Address(RVA = "0x1560560", Offset = "0x155F160", VA = "0x181560560", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BFD9 RID: 114649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BFD9")]
			[Address(RVA = "0x155FF50", Offset = "0x155EB50", VA = "0x18155FF50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402482A RID: 149546
			[Token(Token = "0x402482A")]
			[FieldOffset(Offset = "0x20")]
			private GuideMissionRewardPreview m_closure;

			// Token: 0x0402482B RID: 149547
			[Token(Token = "0x402482B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402482C RID: 149548
			[Token(Token = "0x402482C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402482D RID: 149549
			[Token(Token = "0x402482D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
