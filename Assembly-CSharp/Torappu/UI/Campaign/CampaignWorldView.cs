using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060FF RID: 24831
	[Token(Token = "0x20060FF")]
	public class CampaignWorldView : DataBinder<CampaignWorldViewProperty>
	{
		// Token: 0x170054C3 RID: 21699
		// (get) Token: 0x06023E2D RID: 146989 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023E2E RID: 146990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054C3")]
		public Action onViewInited
		{
			[Token(Token = "0x6023E2D")]
			[Address(RVA = "0x1E91F60", Offset = "0x1E90B60", VA = "0x181E91F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023E2E")]
			[Address(RVA = "0x1E92020", Offset = "0x1E90C20", VA = "0x181E92020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170054C4 RID: 21700
		// (get) Token: 0x06023E2F RID: 146991 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023E30 RID: 146992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054C4")]
		public Action<CampaignWorldZoneViewModel> onZoneClicked
		{
			[Token(Token = "0x6023E2F")]
			[Address(RVA = "0x1E91FC0", Offset = "0x1E90BC0", VA = "0x181E91FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023E30")]
			[Address(RVA = "0x1E920A0", Offset = "0x1E90CA0", VA = "0x181E920A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170054C5 RID: 21701
		// (get) Token: 0x06023E31 RID: 146993 RVA: 0x000C24F0 File Offset: 0x000C06F0
		[Token(Token = "0x170054C5")]
		public bool inited
		{
			[Token(Token = "0x6023E31")]
			[Address(RVA = "0x1E91F00", Offset = "0x1E90B00", VA = "0x181E91F00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023E32 RID: 146994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E32")]
		[Address(RVA = "0x1E90B10", Offset = "0x1E8F710", VA = "0x181E90B10", Slot = "7")]
		public override void OnValueChanged(CampaignWorldViewProperty property)
		{
		}

		// Token: 0x06023E33 RID: 146995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E33")]
		[Address(RVA = "0x1E912E0", Offset = "0x1E8FEE0", VA = "0x181E912E0")]
		public void StopEffect()
		{
		}

		// Token: 0x06023E34 RID: 146996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E34")]
		[Address(RVA = "0x1E906F0", Offset = "0x1E8F2F0", VA = "0x181E906F0")]
		public CampaignWorldRegionView GetRegionView(string regionId)
		{
			return null;
		}

		// Token: 0x06023E35 RID: 146997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E35")]
		[Address(RVA = "0x1E909B0", Offset = "0x1E8F5B0", VA = "0x181E909B0")]
		public CampaignWorldZoneView GetZoneView(string zoneId)
		{
			return null;
		}

		// Token: 0x06023E36 RID: 146998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E36")]
		[Address(RVA = "0x1E90850", Offset = "0x1E8F450", VA = "0x181E90850")]
		public CampaignWorldStageView GetStageView(string stageId)
		{
			return null;
		}

		// Token: 0x06023E37 RID: 146999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E37")]
		[Address(RVA = "0x1E91B30", Offset = "0x1E90730", VA = "0x181E91B30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023E38 RID: 147000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E38")]
		[Address(RVA = "0x1E91620", Offset = "0x1E90220", VA = "0x181E91620")]
		private CampaignWorldRegionHolder _GetRegionHolder(string regionId)
		{
			return null;
		}

		// Token: 0x06023E39 RID: 147001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E39")]
		[Address(RVA = "0x1E91980", Offset = "0x1E90580", VA = "0x181E91980")]
		private CampaignWorldZoneHolder _GetZoneHolder(string zoneId)
		{
			return null;
		}

		// Token: 0x06023E3A RID: 147002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E3A")]
		[Address(RVA = "0x1E917D0", Offset = "0x1E903D0", VA = "0x181E917D0")]
		private CampaignWorldStageHolder _GetStageHolder(string stageId)
		{
			return null;
		}

		// Token: 0x06023E3B RID: 147003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E3B")]
		[Address(RVA = "0x1E91DA0", Offset = "0x1E909A0", VA = "0x181E91DA0")]
		public CampaignWorldView()
		{
		}

		// Token: 0x04031C83 RID: 203907
		[Token(Token = "0x4031C83")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Image> _imageMapPieces;

		// Token: 0x04031C84 RID: 203908
		[Token(Token = "0x4031C84")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x04031C85 RID: 203909
		[Token(Token = "0x4031C85")]
		[FieldOffset(Offset = "0x30")]
		private List<CampaignWorldRegionHolder> m_regionHolders;

		// Token: 0x04031C86 RID: 203910
		[Token(Token = "0x4031C86")]
		[FieldOffset(Offset = "0x38")]
		private List<CampaignWorldZoneHolder> m_zoneHolders;

		// Token: 0x04031C87 RID: 203911
		[Token(Token = "0x4031C87")]
		[FieldOffset(Offset = "0x40")]
		private List<CampaignWorldStageHolder> m_stageHolders;

		// Token: 0x04031C8A RID: 203914
		[Token(Token = "0x4031C8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onViewInited;

		// Token: 0x04031C8B RID: 203915
		[Token(Token = "0x4031C8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onViewInited;

		// Token: 0x04031C8C RID: 203916
		[Token(Token = "0x4031C8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onZoneClicked;

		// Token: 0x04031C8D RID: 203917
		[Token(Token = "0x4031C8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onZoneClicked;

		// Token: 0x04031C8E RID: 203918
		[Token(Token = "0x4031C8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_inited;

		// Token: 0x04031C8F RID: 203919
		[Token(Token = "0x4031C8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031C90 RID: 203920
		[Token(Token = "0x4031C90")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StopEffect;

		// Token: 0x04031C91 RID: 203921
		[Token(Token = "0x4031C91")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetRegionView;

		// Token: 0x04031C92 RID: 203922
		[Token(Token = "0x4031C92")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetZoneView;

		// Token: 0x04031C93 RID: 203923
		[Token(Token = "0x4031C93")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetStageView;

		// Token: 0x04031C94 RID: 203924
		[Token(Token = "0x4031C94")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031C95 RID: 203925
		[Token(Token = "0x4031C95")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetRegionHolder;

		// Token: 0x04031C96 RID: 203926
		[Token(Token = "0x4031C96")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetZoneHolder;

		// Token: 0x04031C97 RID: 203927
		[Token(Token = "0x4031C97")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetStageHolder;

		// Token: 0x04031C98 RID: 203928
		[Token(Token = "0x4031C98")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
