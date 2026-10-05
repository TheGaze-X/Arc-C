using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006822 RID: 26658
	[Token(Token = "0x2006822")]
	public class SixStarGroupRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026301 RID: 156417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026301")]
		[Address(RVA = "0x21396D0", Offset = "0x21382D0", VA = "0x1821396D0")]
		public void Render(List<StageViewModel> modelList, string selectStageId)
		{
		}

		// Token: 0x06026302 RID: 156418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026302")]
		[Address(RVA = "0x2139650", Offset = "0x2138250", VA = "0x182139650")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06026303 RID: 156419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026303")]
		[Address(RVA = "0x21399A0", Offset = "0x21385A0", VA = "0x1821399A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026304 RID: 156420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026304")]
		[Address(RVA = "0x2139AC0", Offset = "0x21386C0", VA = "0x182139AC0")]
		public SixStarGroupRewardView()
		{
		}

		// Token: 0x04035CDB RID: 220379
		[Token(Token = "0x4035CDB")]
		private const string AP_COST_FORMAT = "-{0}";

		// Token: 0x04035CDC RID: 220380
		[Token(Token = "0x4035CDC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04035CDD RID: 220381
		[Token(Token = "0x4035CDD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _apCost;

		// Token: 0x04035CDE RID: 220382
		[Token(Token = "0x4035CDE")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04035CDF RID: 220383
		[Token(Token = "0x4035CDF")]
		[FieldOffset(Offset = "0x38")]
		private List<StageViewModel> m_cachedStageModelList;

		// Token: 0x04035CE0 RID: 220384
		[Token(Token = "0x4035CE0")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedSelectStateId;

		// Token: 0x04035CE1 RID: 220385
		[Token(Token = "0x4035CE1")]
		[FieldOffset(Offset = "0x48")]
		private SixStarGroupRewardView.Adapter m_adapter;

		// Token: 0x04035CE2 RID: 220386
		[Token(Token = "0x4035CE2")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04035CE3 RID: 220387
		[Token(Token = "0x4035CE3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035CE4 RID: 220388
		[Token(Token = "0x4035CE4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x04035CE5 RID: 220389
		[Token(Token = "0x4035CE5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035CE6 RID: 220390
		[Token(Token = "0x4035CE6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006823 RID: 26659
		[Token(Token = "0x2006823")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06026305 RID: 156421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026305")]
			[Address(RVA = "0x2130A80", Offset = "0x212F680", VA = "0x182130A80")]
			public Adapter(SixStarGroupRewardView closure)
			{
			}

			// Token: 0x17005A49 RID: 23113
			// (get) Token: 0x06026306 RID: 156422 RVA: 0x000CA4B8 File Offset: 0x000C86B8
			[Token(Token = "0x17005A49")]
			public override int count
			{
				[Token(Token = "0x6026306")]
				[Address(RVA = "0x2130BB0", Offset = "0x212F7B0", VA = "0x182130BB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026307 RID: 156423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026307")]
			[Address(RVA = "0x21308B0", Offset = "0x212F4B0", VA = "0x1821308B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04035CE7 RID: 220391
			[Token(Token = "0x4035CE7")]
			[FieldOffset(Offset = "0x20")]
			private SixStarGroupRewardView m_closure;

			// Token: 0x04035CE8 RID: 220392
			[Token(Token = "0x4035CE8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035CE9 RID: 220393
			[Token(Token = "0x4035CE9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04035CEA RID: 220394
			[Token(Token = "0x4035CEA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
