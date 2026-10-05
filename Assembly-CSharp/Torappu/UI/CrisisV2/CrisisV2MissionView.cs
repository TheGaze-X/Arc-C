using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005998 RID: 22936
	[Token(Token = "0x2005998")]
	public class CrisisV2MissionView : DataBinder<CrisisV2MissionProperty>, IHotfixable
	{
		// Token: 0x060216E9 RID: 136937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216E9")]
		[Address(RVA = "0x1BCAF60", Offset = "0x1BC9B60", VA = "0x181BCAF60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060216EA RID: 136938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216EA")]
		[Address(RVA = "0x1BCAE30", Offset = "0x1BC9A30", VA = "0x181BCAE30", Slot = "7")]
		public override void OnValueChanged(CrisisV2MissionProperty property)
		{
		}

		// Token: 0x060216EB RID: 136939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216EB")]
		[Address(RVA = "0x1BCAD10", Offset = "0x1BC9910", VA = "0x181BCAD10")]
		public void OnClaimAllClicked()
		{
		}

		// Token: 0x060216EC RID: 136940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216EC")]
		[Address(RVA = "0x1BCADA0", Offset = "0x1BC99A0", VA = "0x181BCADA0")]
		public void OnCloseSelfClicked()
		{
		}

		// Token: 0x060216ED RID: 136941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216ED")]
		[Address(RVA = "0x1BCB1A0", Offset = "0x1BC9DA0", VA = "0x181BCB1A0")]
		public CrisisV2MissionView()
		{
		}

		// Token: 0x0402D9FA RID: 186874
		[Token(Token = "0x402D9FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _claimAllBtnGo;

		// Token: 0x0402D9FB RID: 186875
		[Token(Token = "0x402D9FB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _missionContent;

		// Token: 0x0402D9FC RID: 186876
		[Token(Token = "0x402D9FC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _missionRect;

		// Token: 0x0402D9FD RID: 186877
		[Token(Token = "0x402D9FD")]
		[FieldOffset(Offset = "0x38")]
		private CrisisV2MissionViewModel m_viewModel;

		// Token: 0x0402D9FE RID: 186878
		[Token(Token = "0x402D9FE")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402D9FF RID: 186879
		[Token(Token = "0x402D9FF")]
		[FieldOffset(Offset = "0x48")]
		private CrisisV2MissionView.Adapter m_adapter;

		// Token: 0x0402DA00 RID: 186880
		[Token(Token = "0x402DA00")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DA01 RID: 186881
		[Token(Token = "0x402DA01")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedSequenceNum;

		// Token: 0x0402DA02 RID: 186882
		[Token(Token = "0x402DA02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DA03 RID: 186883
		[Token(Token = "0x402DA03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402DA04 RID: 186884
		[Token(Token = "0x402DA04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClaimAllClicked;

		// Token: 0x0402DA05 RID: 186885
		[Token(Token = "0x402DA05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCloseSelfClicked;

		// Token: 0x0402DA06 RID: 186886
		[Token(Token = "0x402DA06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005999 RID: 22937
		[Token(Token = "0x2005999")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060216EE RID: 136942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60216EE")]
			[Address(RVA = "0x1BBB960", Offset = "0x1BBA560", VA = "0x181BBB960")]
			public Adapter(CrisisV2MissionView closure)
			{
			}

			// Token: 0x17004EA2 RID: 20130
			// (get) Token: 0x060216EF RID: 136943 RVA: 0x000BA420 File Offset: 0x000B8620
			[Token(Token = "0x17004EA2")]
			public override int count
			{
				[Token(Token = "0x60216EF")]
				[Address(RVA = "0x1BBBA50", Offset = "0x1BBA650", VA = "0x181BBBA50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060216F0 RID: 136944 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60216F0")]
			[Address(RVA = "0x1BBB540", Offset = "0x1BBA140", VA = "0x181BBB540", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402DA07 RID: 186887
			[Token(Token = "0x402DA07")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2MissionView m_closure;

			// Token: 0x0402DA08 RID: 186888
			[Token(Token = "0x402DA08")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DA09 RID: 186889
			[Token(Token = "0x402DA09")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402DA0A RID: 186890
			[Token(Token = "0x402DA0A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
