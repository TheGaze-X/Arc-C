using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200441F RID: 17439
	[Token(Token = "0x200441F")]
	public abstract class SandboxV2CharRepoAbstractItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x0601AA19 RID: 109081 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA1A RID: 109082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F17")]
		public Action<int> onCharClick
		{
			[Token(Token = "0x601AA19")]
			[Address(RVA = "0x13BFBF0", Offset = "0x13BE7F0", VA = "0x1813BFBF0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601AA1A")]
			[Address(RVA = "0x13BFD30", Offset = "0x13BE930", VA = "0x1813BFD30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x0601AA1B RID: 109083 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA1C RID: 109084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F18")]
		public Action<int> onDineClick
		{
			[Token(Token = "0x601AA1B")]
			[Address(RVA = "0x13BFC50", Offset = "0x13BE850", VA = "0x1813BFC50")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601AA1C")]
			[Address(RVA = "0x13BFDB0", Offset = "0x13BE9B0", VA = "0x1813BFDB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x0601AA1D RID: 109085 RVA: 0x000A29D8 File Offset: 0x000A0BD8
		[Token(Token = "0x17003F19")]
		protected int charInstId
		{
			[Token(Token = "0x601AA1D")]
			[Address(RVA = "0x13BFB80", Offset = "0x13BE780", VA = "0x1813BFB80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x0601AA1E RID: 109086 RVA: 0x000A29F0 File Offset: 0x000A0BF0
		[Token(Token = "0x17003F1A")]
		protected UIPageFinder pageFinder
		{
			[Token(Token = "0x601AA1E")]
			[Address(RVA = "0x13BFCB0", Offset = "0x13BE8B0", VA = "0x1813BFCB0")]
			get
			{
				return default(UIPageFinder);
			}
		}

		// Token: 0x0601AA1F RID: 109087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA1F")]
		[Address(RVA = "0x13BED20", Offset = "0x13BD920", VA = "0x1813BED20")]
		public void AttachGraphic(Graphic target)
		{
		}

		// Token: 0x0601AA20 RID: 109088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA20")]
		[Address(RVA = "0x13BF750", Offset = "0x13BE350", VA = "0x1813BF750", Slot = "4")]
		public virtual void Render(int position, SandboxV2CharViewModel charModel, bool isCookClickable)
		{
		}

		// Token: 0x0601AA21 RID: 109089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA21")]
		[Address(RVA = "0x13BF130", Offset = "0x13BDD30", VA = "0x1813BF130", Slot = "5")]
		protected virtual void RenderCharBasicInfo(SandboxV2CharViewModel charModel)
		{
		}

		// Token: 0x0601AA22 RID: 109090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA22")]
		[Address(RVA = "0x13BF460", Offset = "0x13BE060", VA = "0x1813BF460", Slot = "6")]
		protected virtual void RenderCharStatusInfo(SandboxV2CharViewModel charModel)
		{
		}

		// Token: 0x0601AA23 RID: 109091 RVA: 0x000A2A08 File Offset: 0x000A0C08
		[Token(Token = "0x601AA23")]
		[Address(RVA = "0x13BEEF0", Offset = "0x13BDAF0", VA = "0x1813BEEF0", Slot = "7")]
		protected virtual bool CheckShowUsedStatusPanel(SandboxV2CharViewModel charModel)
		{
			return default(bool);
		}

		// Token: 0x0601AA24 RID: 109092 RVA: 0x000A2A20 File Offset: 0x000A0C20
		[Token(Token = "0x601AA24")]
		[Address(RVA = "0x13BEE70", Offset = "0x13BDA70", VA = "0x1813BEE70", Slot = "8")]
		protected virtual bool CheckShowSupplyStatusPanel(SandboxV2CharViewModel charModel)
		{
			return default(bool);
		}

		// Token: 0x0601AA25 RID: 109093 RVA: 0x000A2A38 File Offset: 0x000A0C38
		[Token(Token = "0x601AA25")]
		[Address(RVA = "0x13BEDF0", Offset = "0x13BD9F0", VA = "0x1813BEDF0", Slot = "9")]
		protected virtual bool CheckShowExpedStatusPanel(SandboxV2CharViewModel charModel)
		{
			return default(bool);
		}

		// Token: 0x0601AA26 RID: 109094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA26")]
		[Address(RVA = "0x13BF850", Offset = "0x13BE450", VA = "0x1813BF850")]
		private void _RenderFoodModel(SandboxV2CharViewModel charModel, bool isCookClickable)
		{
		}

		// Token: 0x0601AA27 RID: 109095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA27")]
		[Address(RVA = "0x13BEF70", Offset = "0x13BDB70", VA = "0x1813BEF70", Slot = "10")]
		public virtual void EventOnCharClick()
		{
		}

		// Token: 0x0601AA28 RID: 109096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA28")]
		[Address(RVA = "0x13BF050", Offset = "0x13BDC50", VA = "0x1813BF050", Slot = "11")]
		public virtual void EventOnDineClick()
		{
		}

		// Token: 0x0601AA29 RID: 109097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA29")]
		[Address(RVA = "0x13BFB20", Offset = "0x13BE720", VA = "0x1813BFB20")]
		protected SandboxV2CharRepoAbstractItemView()
		{
		}

		// Token: 0x04021F68 RID: 139112
		[Token(Token = "0x4021F68")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgAvatar;

		// Token: 0x04021F69 RID: 139113
		[Token(Token = "0x4021F69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x04021F6A RID: 139114
		[Token(Token = "0x4021F6A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgRarity;

		// Token: 0x04021F6B RID: 139115
		[Token(Token = "0x4021F6B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgEvolve;

		// Token: 0x04021F6C RID: 139116
		[Token(Token = "0x4021F6C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgPotential;

		// Token: 0x04021F6D RID: 139117
		[Token(Token = "0x4021F6D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x04021F6E RID: 139118
		[Token(Token = "0x4021F6E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04021F6F RID: 139119
		[Token(Token = "0x4021F6F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgRarityBanner;

		// Token: 0x04021F70 RID: 139120
		[Token(Token = "0x4021F70")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Food Circle")]
		private GameObject _haveFoodGo;

		// Token: 0x04021F71 RID: 139121
		[Token(Token = "0x4021F71")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Food Circle")]
		private GameObject _noFoodGo;

		// Token: 0x04021F72 RID: 139122
		[Token(Token = "0x4021F72")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Food Circle")]
		private GameObject _durationLastingPanel;

		// Token: 0x04021F73 RID: 139123
		[Token(Token = "0x4021F73")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Food Circle")]
		private GameObject _durationNormalPanel;

		// Token: 0x04021F74 RID: 139124
		[Token(Token = "0x4021F74")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Food Circle")]
		private UISlicedCircleBar _foodTotalCircleBar;

		// Token: 0x04021F75 RID: 139125
		[Token(Token = "0x4021F75")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Food Circle")]
		private UISlicedCircleBar _foodCurrCircleBar;

		// Token: 0x04021F76 RID: 139126
		[Token(Token = "0x4021F76")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Food Circle")]
		private Image _imgFood;

		// Token: 0x04021F77 RID: 139127
		[Token(Token = "0x4021F77")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Food Circle")]
		private GameObject _btnCookShadowGo;

		// Token: 0x04021F78 RID: 139128
		[Token(Token = "0x4021F78")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Food Circle")]
		private GameObject _btnCookGo;

		// Token: 0x04021F79 RID: 139129
		[Token(Token = "0x4021F79")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Food Circle")]
		private CanvasGroup _cookCanvasGroup;

		// Token: 0x04021F7A RID: 139130
		[Token(Token = "0x4021F7A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Food Circle")]
		private float _cookDisableAlpha;

		// Token: 0x04021F7B RID: 139131
		[Token(Token = "0x4021F7B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIColorGraphic _itemGraphic;

		// Token: 0x04021F7C RID: 139132
		[Token(Token = "0x4021F7C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Char Status")]
		private GameObject _statusUsedGo;

		// Token: 0x04021F7D RID: 139133
		[Token(Token = "0x4021F7D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Char Status")]
		private GameObject _statusSupplyGo;

		// Token: 0x04021F7E RID: 139134
		[Token(Token = "0x4021F7E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Char Status")]
		private GameObject _statusExpedGo;

		// Token: 0x04021F7F RID: 139135
		[Token(Token = "0x4021F7F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Char Status")]
		private Text _textUsedCaption;

		// Token: 0x04021F80 RID: 139136
		[Token(Token = "0x4021F80")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Char Status")]
		private Text _textSupplyCaption;

		// Token: 0x04021F81 RID: 139137
		[Token(Token = "0x4021F81")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Char Status")]
		private Text _textExpedCaption;

		// Token: 0x04021F82 RID: 139138
		[Token(Token = "0x4021F82")]
		[FieldOffset(Offset = "0xE8")]
		private SandboxV2CharViewModel m_charModel;

		// Token: 0x04021F83 RID: 139139
		[Token(Token = "0x4021F83")]
		[FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021F86 RID: 139142
		[Token(Token = "0x4021F86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCharClick;

		// Token: 0x04021F87 RID: 139143
		[Token(Token = "0x4021F87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCharClick;

		// Token: 0x04021F88 RID: 139144
		[Token(Token = "0x4021F88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onDineClick;

		// Token: 0x04021F89 RID: 139145
		[Token(Token = "0x4021F89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onDineClick;

		// Token: 0x04021F8A RID: 139146
		[Token(Token = "0x4021F8A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_charInstId;

		// Token: 0x04021F8B RID: 139147
		[Token(Token = "0x4021F8B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_pageFinder;

		// Token: 0x04021F8C RID: 139148
		[Token(Token = "0x4021F8C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AttachGraphic;

		// Token: 0x04021F8D RID: 139149
		[Token(Token = "0x4021F8D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021F8E RID: 139150
		[Token(Token = "0x4021F8E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RenderCharBasicInfo;

		// Token: 0x04021F8F RID: 139151
		[Token(Token = "0x4021F8F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RenderCharStatusInfo;

		// Token: 0x04021F90 RID: 139152
		[Token(Token = "0x4021F90")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckShowUsedStatusPanel;

		// Token: 0x04021F91 RID: 139153
		[Token(Token = "0x4021F91")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckShowSupplyStatusPanel;

		// Token: 0x04021F92 RID: 139154
		[Token(Token = "0x4021F92")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckShowExpedStatusPanel;

		// Token: 0x04021F93 RID: 139155
		[Token(Token = "0x4021F93")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderFoodModel;

		// Token: 0x04021F94 RID: 139156
		[Token(Token = "0x4021F94")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnCharClick;

		// Token: 0x04021F95 RID: 139157
		[Token(Token = "0x4021F95")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnDineClick;

		// Token: 0x04021F96 RID: 139158
		[Token(Token = "0x4021F96")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
