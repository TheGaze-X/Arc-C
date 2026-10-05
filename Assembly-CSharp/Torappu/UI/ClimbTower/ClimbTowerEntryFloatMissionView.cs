using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C42 RID: 23618
	[Token(Token = "0x2005C42")]
	public class ClimbTowerEntryFloatMissionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005050 RID: 20560
		// (get) Token: 0x060223B0 RID: 140208 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223B1 RID: 140209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005050")]
		public UIPage page
		{
			[Token(Token = "0x60223B0")]
			[Address(RVA = "0x1CA4B50", Offset = "0x1CA3750", VA = "0x181CA4B50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223B1")]
			[Address(RVA = "0x1CA4C30", Offset = "0x1CA3830", VA = "0x181CA4C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005051 RID: 20561
		// (get) Token: 0x060223B2 RID: 140210 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223B3 RID: 140211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005051")]
		public Action onClicked
		{
			[Token(Token = "0x60223B2")]
			[Address(RVA = "0x1CA4AF0", Offset = "0x1CA36F0", VA = "0x181CA4AF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223B3")]
			[Address(RVA = "0x1CA4BB0", Offset = "0x1CA37B0", VA = "0x181CA4BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060223B4 RID: 140212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223B4")]
		[Address(RVA = "0x1CA47A0", Offset = "0x1CA33A0", VA = "0x181CA47A0")]
		public void Render(ClimbTowerEntryFloatPanelViewModel viewModel)
		{
		}

		// Token: 0x060223B5 RID: 140213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223B5")]
		[Address(RVA = "0x1CA4690", Offset = "0x1CA3290", VA = "0x181CA4690")]
		public void OnClick()
		{
		}

		// Token: 0x060223B6 RID: 140214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223B6")]
		[Address(RVA = "0x1CA4970", Offset = "0x1CA3570", VA = "0x181CA4970")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060223B7 RID: 140215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223B7")]
		[Address(RVA = "0x1CA4A90", Offset = "0x1CA3690", VA = "0x181CA4A90")]
		public ClimbTowerEntryFloatMissionView()
		{
		}

		// Token: 0x0402EF7A RID: 192378
		[Token(Token = "0x402EF7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402EF7B RID: 192379
		[Token(Token = "0x402EF7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelTrackPoint;

		// Token: 0x0402EF7C RID: 192380
		[Token(Token = "0x402EF7C")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0402EF7D RID: 192381
		[Token(Token = "0x402EF7D")]
		[FieldOffset(Offset = "0x2C")]
		private int m_missionSumCount;

		// Token: 0x0402EF7E RID: 192382
		[Token(Token = "0x402EF7E")]
		[FieldOffset(Offset = "0x30")]
		private int m_missionCompleteCount;

		// Token: 0x0402EF7F RID: 192383
		[Token(Token = "0x402EF7F")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerEntryFloatMissionView.Adapter m_adapter;

		// Token: 0x0402EF82 RID: 192386
		[Token(Token = "0x402EF82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402EF83 RID: 192387
		[Token(Token = "0x402EF83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402EF84 RID: 192388
		[Token(Token = "0x402EF84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0402EF85 RID: 192389
		[Token(Token = "0x402EF85")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0402EF86 RID: 192390
		[Token(Token = "0x402EF86")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EF87 RID: 192391
		[Token(Token = "0x402EF87")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402EF88 RID: 192392
		[Token(Token = "0x402EF88")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EF89 RID: 192393
		[Token(Token = "0x402EF89")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C43 RID: 23619
		[Token(Token = "0x2005C43")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060223B8 RID: 140216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60223B8")]
			[Address(RVA = "0x1CA0E30", Offset = "0x1C9FA30", VA = "0x181CA0E30")]
			public Adapter(ClimbTowerEntryFloatMissionView closure)
			{
			}

			// Token: 0x17005052 RID: 20562
			// (get) Token: 0x060223B9 RID: 140217 RVA: 0x000BCCA0 File Offset: 0x000BAEA0
			[Token(Token = "0x17005052")]
			public override int count
			{
				[Token(Token = "0x60223B9")]
				[Address(RVA = "0x1CA1120", Offset = "0x1C9FD20", VA = "0x181CA1120", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060223BA RID: 140218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60223BA")]
			[Address(RVA = "0x1CA0AA0", Offset = "0x1C9F6A0", VA = "0x181CA0AA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402EF8A RID: 192394
			[Token(Token = "0x402EF8A")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerEntryFloatMissionView m_closure;

			// Token: 0x0402EF8B RID: 192395
			[Token(Token = "0x402EF8B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402EF8C RID: 192396
			[Token(Token = "0x402EF8C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EF8D RID: 192397
			[Token(Token = "0x402EF8D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
