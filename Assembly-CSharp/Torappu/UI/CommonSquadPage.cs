using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035C3 RID: 13763
	[Token(Token = "0x20035C3")]
	public class CommonSquadPage : StateEnginePage, ICommonSquadPage, IHotfixable, IDialogMgrHolder
	{
		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x06015E64 RID: 89700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700348E")]
		public UICompDialogMgr dlgMgr
		{
			[Token(Token = "0x6015E64")]
			[Address(RVA = "0xE66200", Offset = "0xE64E00", VA = "0x180E66200", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015E65 RID: 89701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E65")]
		[Address(RVA = "0xE65F90", Offset = "0xE64B90", VA = "0x180E65F90", Slot = "31")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x06015E66 RID: 89702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E66")]
		[Address(RVA = "0xE660A0", Offset = "0xE64CA0", VA = "0x180E660A0", Slot = "8")]
		protected override void OnCreate(DataBundle dataBundle)
		{
		}

		// Token: 0x06015E67 RID: 89703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E67")]
		[Address(RVA = "0xE65FF0", Offset = "0xE64BF0", VA = "0x180E65FF0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x06015E68 RID: 89704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700348F")]
		public ICommonSquadPage.ISquadInputs squadInput
		{
			[Token(Token = "0x6015E68")]
			[Address(RVA = "0xE66260", Offset = "0xE64E60", VA = "0x180E66260", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015E69 RID: 89705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E69")]
		[Address(RVA = "0xE661A0", Offset = "0xE64DA0", VA = "0x180E661A0")]
		public CommonSquadPage()
		{
		}

		// Token: 0x06015E6B RID: 89707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E6B")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06015E6C RID: 89708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E6C")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0401A558 RID: 107864
		[Token(Token = "0x401A558")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dlgContainer;

		// Token: 0x0401A559 RID: 107865
		[Token(Token = "0x401A559")]
		[FieldOffset(Offset = "0xF8")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x0401A55A RID: 107866
		[Token(Token = "0x401A55A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dlgMgr;

		// Token: 0x0401A55B RID: 107867
		[Token(Token = "0x401A55B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0401A55C RID: 107868
		[Token(Token = "0x401A55C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401A55D RID: 107869
		[Token(Token = "0x401A55D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0401A55E RID: 107870
		[Token(Token = "0x401A55E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_squadInput;

		// Token: 0x0401A55F RID: 107871
		[Token(Token = "0x401A55F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035C4 RID: 13764
		[Token(Token = "0x20035C4")]
		public class Inputs : ICommonSquadPage.ISquadInputs, IHotfixable
		{
			// Token: 0x17003490 RID: 13456
			// (get) Token: 0x06015E6D RID: 89709 RVA: 0x0008E998 File Offset: 0x0008CB98
			// (set) Token: 0x06015E6E RID: 89710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003490")]
			public StageId stageId
			{
				[Token(Token = "0x6015E6D")]
				[Address(RVA = "0xE73100", Offset = "0xE71D00", VA = "0x180E73100", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(StageId);
				}
				[Token(Token = "0x6015E6E")]
				[Address(RVA = "0xE735F0", Offset = "0xE721F0", VA = "0x180E735F0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003491 RID: 13457
			// (get) Token: 0x06015E6F RID: 89711 RVA: 0x0008E9B0 File Offset: 0x0008CBB0
			// (set) Token: 0x06015E70 RID: 89712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003491")]
			public BattleStageInfo overrideStageInfo
			{
				[Token(Token = "0x6015E6F")]
				[Address(RVA = "0xE72F60", Offset = "0xE71B60", VA = "0x180E72F60", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(BattleStageInfo);
				}
				[Token(Token = "0x6015E70")]
				[Address(RVA = "0xE733F0", Offset = "0xE71FF0", VA = "0x180E733F0", Slot = "7")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003492 RID: 13458
			// (get) Token: 0x06015E71 RID: 89713 RVA: 0x0008E9C8 File Offset: 0x0008CBC8
			// (set) Token: 0x06015E72 RID: 89714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003492")]
			public BattleActivityMeta actMeta
			{
				[Token(Token = "0x6015E71")]
				[Address(RVA = "0xE72CD0", Offset = "0xE718D0", VA = "0x180E72CD0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(BattleActivityMeta);
				}
				[Token(Token = "0x6015E72")]
				[Address(RVA = "0xE731E0", Offset = "0xE71DE0", VA = "0x180E731E0", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003493 RID: 13459
			// (get) Token: 0x06015E73 RID: 89715 RVA: 0x0008E9E0 File Offset: 0x0008CBE0
			// (set) Token: 0x06015E74 RID: 89716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003493")]
			public BattleStageMeta stageMeta
			{
				[Token(Token = "0x6015E73")]
				[Address(RVA = "0xE73180", Offset = "0xE71D80", VA = "0x180E73180", Slot = "10")]
				[CompilerGenerated]
				get
				{
					return default(BattleStageMeta);
				}
				[Token(Token = "0x6015E74")]
				[Address(RVA = "0xE73680", Offset = "0xE72280", VA = "0x180E73680", Slot = "11")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003494 RID: 13460
			// (get) Token: 0x06015E75 RID: 89717 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06015E76 RID: 89718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003494")]
			public DataBundle battleBundleToJumpBack
			{
				[Token(Token = "0x6015E75")]
				[Address(RVA = "0xE72D50", Offset = "0xE71950", VA = "0x180E72D50", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6015E76")]
				[Address(RVA = "0xE73270", Offset = "0xE71E70", VA = "0x180E73270", Slot = "13")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003495 RID: 13461
			// (get) Token: 0x06015E77 RID: 89719 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06015E78 RID: 89720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003495")]
			public CommonSquadResHolder commonSquadResHolder
			{
				[Token(Token = "0x6015E77")]
				[Address(RVA = "0xE72E10", Offset = "0xE71A10", VA = "0x180E72E10", Slot = "14")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6015E78")]
				[Address(RVA = "0xE73370", Offset = "0xE71F70", VA = "0x180E73370", Slot = "15")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003496 RID: 13462
			// (get) Token: 0x06015E79 RID: 89721 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06015E7A RID: 89722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003496")]
			public CommonCharSelectResHolder charSelectResHolder
			{
				[Token(Token = "0x6015E79")]
				[Address(RVA = "0xE72DB0", Offset = "0xE719B0", VA = "0x180E72DB0", Slot = "16")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6015E7A")]
				[Address(RVA = "0xE732F0", Offset = "0xE71EF0", VA = "0x180E732F0", Slot = "17")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003497 RID: 13463
			// (get) Token: 0x06015E7B RID: 89723 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06015E7C RID: 89724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003497")]
			public List<RuneTable.PackedRuneData> runeList
			{
				[Token(Token = "0x6015E7B")]
				[Address(RVA = "0xE73040", Offset = "0xE71C40", VA = "0x180E73040", Slot = "18")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6015E7C")]
				[Address(RVA = "0xE734F0", Offset = "0xE720F0", VA = "0x180E734F0", Slot = "19")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003498 RID: 13464
			// (get) Token: 0x06015E7D RID: 89725 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06015E7E RID: 89726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003498")]
			public Type squadPluginType
			{
				[Token(Token = "0x6015E7D")]
				[Address(RVA = "0xE730A0", Offset = "0xE71CA0", VA = "0x180E730A0", Slot = "20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6015E7E")]
				[Address(RVA = "0xE73570", Offset = "0xE72170", VA = "0x180E73570")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17003499 RID: 13465
			// (get) Token: 0x06015E7F RID: 89727 RVA: 0x0008E9F8 File Offset: 0x0008CBF8
			[Token(Token = "0x17003499")]
			public bool isEmpty
			{
				[Token(Token = "0x6015E7F")]
				[Address(RVA = "0xE72E70", Offset = "0xE71A70", VA = "0x180E72E70", Slot = "21")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06015E80 RID: 89728 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015E80")]
			public ICommonSquadPage.ISquadInputs SetPlugin<TPlugin>() where TPlugin : ICommonSquadPlugin, new()
			{
				return null;
			}

			// Token: 0x06015E81 RID: 89729 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015E81")]
			[Address(RVA = "0xE72C70", Offset = "0xE71870", VA = "0x180E72C70")]
			public Inputs()
			{
			}

			// Token: 0x0401A569 RID: 107881
			[Token(Token = "0x401A569")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_stageId;

			// Token: 0x0401A56A RID: 107882
			[Token(Token = "0x401A56A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_stageId;

			// Token: 0x0401A56B RID: 107883
			[Token(Token = "0x401A56B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_overrideStageInfo;

			// Token: 0x0401A56C RID: 107884
			[Token(Token = "0x401A56C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_overrideStageInfo;

			// Token: 0x0401A56D RID: 107885
			[Token(Token = "0x401A56D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_actMeta;

			// Token: 0x0401A56E RID: 107886
			[Token(Token = "0x401A56E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_actMeta;

			// Token: 0x0401A56F RID: 107887
			[Token(Token = "0x401A56F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_stageMeta;

			// Token: 0x0401A570 RID: 107888
			[Token(Token = "0x401A570")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_stageMeta;

			// Token: 0x0401A571 RID: 107889
			[Token(Token = "0x401A571")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_battleBundleToJumpBack;

			// Token: 0x0401A572 RID: 107890
			[Token(Token = "0x401A572")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_set_battleBundleToJumpBack;

			// Token: 0x0401A573 RID: 107891
			[Token(Token = "0x401A573")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_commonSquadResHolder;

			// Token: 0x0401A574 RID: 107892
			[Token(Token = "0x401A574")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_set_commonSquadResHolder;

			// Token: 0x0401A575 RID: 107893
			[Token(Token = "0x401A575")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_charSelectResHolder;

			// Token: 0x0401A576 RID: 107894
			[Token(Token = "0x401A576")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_set_charSelectResHolder;

			// Token: 0x0401A577 RID: 107895
			[Token(Token = "0x401A577")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_runeList;

			// Token: 0x0401A578 RID: 107896
			[Token(Token = "0x401A578")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_set_runeList;

			// Token: 0x0401A579 RID: 107897
			[Token(Token = "0x401A579")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_squadPluginType;

			// Token: 0x0401A57A RID: 107898
			[Token(Token = "0x401A57A")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_set_squadPluginType;

			// Token: 0x0401A57B RID: 107899
			[Token(Token = "0x401A57B")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0401A57C RID: 107900
			[Token(Token = "0x401A57C")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_SetPlugin;

			// Token: 0x0401A57D RID: 107901
			[Token(Token = "0x401A57D")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
