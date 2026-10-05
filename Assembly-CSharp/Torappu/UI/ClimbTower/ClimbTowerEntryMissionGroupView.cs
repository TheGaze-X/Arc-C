using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C57 RID: 23639
	[Token(Token = "0x2005C57")]
	public class ClimbTowerEntryMissionGroupView : DataBinder<ClimbTowerEntryMissionProperty>, IHotfixable
	{
		// Token: 0x17005067 RID: 20583
		// (get) Token: 0x0602240E RID: 140302 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602240F RID: 140303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005067")]
		public UIPage page
		{
			[Token(Token = "0x602240E")]
			[Address(RVA = "0x1CBA140", Offset = "0x1CB8D40", VA = "0x181CBA140")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602240F")]
			[Address(RVA = "0x1CBA220", Offset = "0x1CB8E20", VA = "0x181CBA220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005068 RID: 20584
		// (get) Token: 0x06022410 RID: 140304 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022411 RID: 140305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005068")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x6022410")]
			[Address(RVA = "0x1CBA0E0", Offset = "0x1CB8CE0", VA = "0x181CBA0E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022411")]
			[Address(RVA = "0x1CBA1A0", Offset = "0x1CB8DA0", VA = "0x181CBA1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022412 RID: 140306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022412")]
		[Address(RVA = "0x1CB9810", Offset = "0x1CB8410", VA = "0x181CB9810", Slot = "7")]
		public override void OnValueChanged(ClimbTowerEntryMissionProperty property)
		{
		}

		// Token: 0x06022413 RID: 140307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022413")]
		[Address(RVA = "0x1CB9F50", Offset = "0x1CB8B50", VA = "0x181CB9F50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022414 RID: 140308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022414")]
		[Address(RVA = "0x1CBA070", Offset = "0x1CB8C70", VA = "0x181CBA070")]
		public ClimbTowerEntryMissionGroupView()
		{
		}

		// Token: 0x0402F053 RID: 192595
		[Token(Token = "0x402F053")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClimbTowerEntryMissionGridAdapter _adapter;

		// Token: 0x0402F054 RID: 192596
		[Token(Token = "0x402F054")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _seasonNum;

		// Token: 0x0402F055 RID: 192597
		[Token(Token = "0x402F055")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _seasonName;

		// Token: 0x0402F056 RID: 192598
		[Token(Token = "0x402F056")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _progressContent;

		// Token: 0x0402F057 RID: 192599
		[Token(Token = "0x402F057")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _seasonEndTime;

		// Token: 0x0402F058 RID: 192600
		[Token(Token = "0x402F058")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _seasonRemainTime;

		// Token: 0x0402F05B RID: 192603
		[Token(Token = "0x402F05B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0402F05C RID: 192604
		[Token(Token = "0x402F05C")]
		[FieldOffset(Offset = "0x64")]
		private int m_periodSum;

		// Token: 0x0402F05D RID: 192605
		[Token(Token = "0x402F05D")]
		[FieldOffset(Offset = "0x68")]
		private int m_periodCurr;

		// Token: 0x0402F05E RID: 192606
		[Token(Token = "0x402F05E")]
		[FieldOffset(Offset = "0x70")]
		private ClimbTowerEntryMissionGroupView.SeasonProgressAdapter m_progressAdapter;

		// Token: 0x0402F05F RID: 192607
		[Token(Token = "0x402F05F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F060 RID: 192608
		[Token(Token = "0x402F060")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F061 RID: 192609
		[Token(Token = "0x402F061")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0402F062 RID: 192610
		[Token(Token = "0x402F062")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0402F063 RID: 192611
		[Token(Token = "0x402F063")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F064 RID: 192612
		[Token(Token = "0x402F064")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F065 RID: 192613
		[Token(Token = "0x402F065")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C58 RID: 23640
		[Token(Token = "0x2005C58")]
		private class SeasonProgressAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06022415 RID: 140309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022415")]
			[Address(RVA = "0x1CC8980", Offset = "0x1CC7580", VA = "0x181CC8980")]
			public SeasonProgressAdapter(ClimbTowerEntryMissionGroupView closure)
			{
			}

			// Token: 0x17005069 RID: 20585
			// (get) Token: 0x06022416 RID: 140310 RVA: 0x000BCD30 File Offset: 0x000BAF30
			[Token(Token = "0x17005069")]
			public override int count
			{
				[Token(Token = "0x6022416")]
				[Address(RVA = "0x1CC8A00", Offset = "0x1CC7600", VA = "0x181CC8A00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022417 RID: 140311 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022417")]
			[Address(RVA = "0x1CC87F0", Offset = "0x1CC73F0", VA = "0x181CC87F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F066 RID: 192614
			[Token(Token = "0x402F066")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerEntryMissionGroupView m_closure;

			// Token: 0x0402F067 RID: 192615
			[Token(Token = "0x402F067")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F068 RID: 192616
			[Token(Token = "0x402F068")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F069 RID: 192617
			[Token(Token = "0x402F069")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
