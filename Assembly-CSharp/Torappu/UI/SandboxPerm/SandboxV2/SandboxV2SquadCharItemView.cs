using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200442A RID: 17450
	[Token(Token = "0x200442A")]
	public class SandboxV2SquadCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x0601AA67 RID: 109159 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA68 RID: 109160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F2A")]
		public Action<int, string> onSkillSelect
		{
			[Token(Token = "0x601AA67")]
			[Address(RVA = "0x13C4230", Offset = "0x13C2E30", VA = "0x1813C4230")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA68")]
			[Address(RVA = "0x13C4370", Offset = "0x13C2F70", VA = "0x1813C4370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x0601AA69 RID: 109161 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA6A RID: 109162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F2B")]
		public Action<int> onCharDineClick
		{
			[Token(Token = "0x601AA69")]
			[Address(RVA = "0x13C41D0", Offset = "0x13C2DD0", VA = "0x1813C41D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA6A")]
			[Address(RVA = "0x13C42F0", Offset = "0x13C2EF0", VA = "0x1813C42F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x0601AA6B RID: 109163 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA6C RID: 109164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F2C")]
		public Action<int> onSlotClick
		{
			[Token(Token = "0x601AA6B")]
			[Address(RVA = "0x13C4290", Offset = "0x13C2E90", VA = "0x1813C4290")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA6C")]
			[Address(RVA = "0x13C43F0", Offset = "0x13C2FF0", VA = "0x1813C43F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AA6D RID: 109165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA6D")]
		[Address(RVA = "0x13C3D10", Offset = "0x13C2910", VA = "0x1813C3D10")]
		public void RenderNextThreshold(int position, int nextCharLimit)
		{
		}

		// Token: 0x0601AA6E RID: 109166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA6E")]
		[Address(RVA = "0x13C3350", Offset = "0x13C1F50", VA = "0x1813C3350")]
		public void RenderChar(int position, int charLimit, SandboxV2SquadCharModel squadCharModel, SandboxV2CharFoodModel foodModel)
		{
		}

		// Token: 0x0601AA6F RID: 109167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA6F")]
		[Address(RVA = "0x13C3EC0", Offset = "0x13C2AC0", VA = "0x1813C3EC0")]
		private void _RenderFoodInfo(SandboxV2CharFoodModel foodModel, bool isFoodDisabled)
		{
		}

		// Token: 0x0601AA70 RID: 109168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA70")]
		[Address(RVA = "0x13C30D0", Offset = "0x13C1CD0", VA = "0x1813C30D0")]
		public void EventOnDineClick()
		{
		}

		// Token: 0x0601AA71 RID: 109169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA71")]
		[Address(RVA = "0x13C3240", Offset = "0x13C1E40", VA = "0x1813C3240")]
		public void EventOnSlotClick()
		{
		}

		// Token: 0x0601AA72 RID: 109170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA72")]
		[Address(RVA = "0x13C4170", Offset = "0x13C2D70", VA = "0x1813C4170")]
		public SandboxV2SquadCharItemView()
		{
		}

		// Token: 0x0402201A RID: 139290
		[Token(Token = "0x402201A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _charPartGo;

		// Token: 0x0402201B RID: 139291
		[Token(Token = "0x402201B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0402201C RID: 139292
		[Token(Token = "0x402201C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _thresholdPartGo;

		// Token: 0x0402201D RID: 139293
		[Token(Token = "0x402201D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textSlotIdxInEmpty;

		// Token: 0x0402201E RID: 139294
		[Token(Token = "0x402201E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCharMaxInEmpty;

		// Token: 0x0402201F RID: 139295
		[Token(Token = "0x402201F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textSlotIdxInThreshold;

		// Token: 0x04022020 RID: 139296
		[Token(Token = "0x4022020")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textCharMaxInThreshold;

		// Token: 0x04022021 RID: 139297
		[Token(Token = "0x4022021")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgAvatar;

		// Token: 0x04022022 RID: 139298
		[Token(Token = "0x4022022")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x04022023 RID: 139299
		[Token(Token = "0x4022023")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgRarity;

		// Token: 0x04022024 RID: 139300
		[Token(Token = "0x4022024")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgEvolve;

		// Token: 0x04022025 RID: 139301
		[Token(Token = "0x4022025")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgPotential;

		// Token: 0x04022026 RID: 139302
		[Token(Token = "0x4022026")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x04022027 RID: 139303
		[Token(Token = "0x4022027")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04022028 RID: 139304
		[Token(Token = "0x4022028")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _imgRarityBanner;

		// Token: 0x04022029 RID: 139305
		[Token(Token = "0x4022029")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SimpleLayoutContent _skillList;

		// Token: 0x0402202A RID: 139306
		[Token(Token = "0x402202A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _emptyEquipGo;

		// Token: 0x0402202B RID: 139307
		[Token(Token = "0x402202B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _detailEquipGo;

		// Token: 0x0402202C RID: 139308
		[Token(Token = "0x402202C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _imgEquipIcon;

		// Token: 0x0402202D RID: 139309
		[Token(Token = "0x402202D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _haveFoodGo;

		// Token: 0x0402202E RID: 139310
		[Token(Token = "0x402202E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _noFoodGo;

		// Token: 0x0402202F RID: 139311
		[Token(Token = "0x402202F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _durationLastingPanel;

		// Token: 0x04022030 RID: 139312
		[Token(Token = "0x4022030")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _durationNormalPanel;

		// Token: 0x04022031 RID: 139313
		[Token(Token = "0x4022031")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UISlicedCircleBar _foodTotalCircleBar;

		// Token: 0x04022032 RID: 139314
		[Token(Token = "0x4022032")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UISlicedCircleBar _foodCurrCircleBar;

		// Token: 0x04022033 RID: 139315
		[Token(Token = "0x4022033")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Image _imgFood;

		// Token: 0x04022034 RID: 139316
		[Token(Token = "0x4022034")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private CanvasGroup _cookCanvasGroup;

		// Token: 0x04022035 RID: 139317
		[Token(Token = "0x4022035")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _cookDisableAlpha;

		// Token: 0x04022036 RID: 139318
		[Token(Token = "0x4022036")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _statusUsedGo;

		// Token: 0x04022037 RID: 139319
		[Token(Token = "0x4022037")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _statusSupplyGo;

		// Token: 0x04022038 RID: 139320
		[Token(Token = "0x4022038")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _statusExpedGo;

		// Token: 0x04022039 RID: 139321
		[Token(Token = "0x4022039")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Text _textUsedCaption;

		// Token: 0x0402203A RID: 139322
		[Token(Token = "0x402203A")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Text _textSupplyCaption;

		// Token: 0x0402203B RID: 139323
		[Token(Token = "0x402203B")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Text _textExpedCaption;

		// Token: 0x0402203C RID: 139324
		[Token(Token = "0x402203C")]
		[FieldOffset(Offset = "0x128")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402203D RID: 139325
		[Token(Token = "0x402203D")]
		[FieldOffset(Offset = "0x138")]
		private SandboxV2SquadCharItemView.SKillListAdapter m_skillListAdapter;

		// Token: 0x0402203E RID: 139326
		[Token(Token = "0x402203E")]
		[FieldOffset(Offset = "0x140")]
		private SandboxV2SquadCharModel m_squadCharModel;

		// Token: 0x0402203F RID: 139327
		[Token(Token = "0x402203F")]
		[FieldOffset(Offset = "0x148")]
		private int m_position;

		// Token: 0x04022043 RID: 139331
		[Token(Token = "0x4022043")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSkillSelect;

		// Token: 0x04022044 RID: 139332
		[Token(Token = "0x4022044")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSkillSelect;

		// Token: 0x04022045 RID: 139333
		[Token(Token = "0x4022045")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCharDineClick;

		// Token: 0x04022046 RID: 139334
		[Token(Token = "0x4022046")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCharDineClick;

		// Token: 0x04022047 RID: 139335
		[Token(Token = "0x4022047")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onSlotClick;

		// Token: 0x04022048 RID: 139336
		[Token(Token = "0x4022048")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onSlotClick;

		// Token: 0x04022049 RID: 139337
		[Token(Token = "0x4022049")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderNextThreshold;

		// Token: 0x0402204A RID: 139338
		[Token(Token = "0x402204A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RenderChar;

		// Token: 0x0402204B RID: 139339
		[Token(Token = "0x402204B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderFoodInfo;

		// Token: 0x0402204C RID: 139340
		[Token(Token = "0x402204C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnDineClick;

		// Token: 0x0402204D RID: 139341
		[Token(Token = "0x402204D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnSlotClick;

		// Token: 0x0402204E RID: 139342
		[Token(Token = "0x402204E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200442B RID: 17451
		[Token(Token = "0x200442B")]
		private class SKillListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601AA73 RID: 109171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AA73")]
			[Address(RVA = "0x13BCFC0", Offset = "0x13BBBC0", VA = "0x1813BCFC0")]
			public SKillListAdapter(SandboxV2SquadCharItemView closure)
			{
			}

			// Token: 0x17003F2D RID: 16173
			// (get) Token: 0x0601AA74 RID: 109172 RVA: 0x000A2B28 File Offset: 0x000A0D28
			[Token(Token = "0x17003F2D")]
			public override int count
			{
				[Token(Token = "0x601AA74")]
				[Address(RVA = "0x13BD040", Offset = "0x13BBC40", VA = "0x1813BD040", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AA75 RID: 109173 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AA75")]
			[Address(RVA = "0x13BCC00", Offset = "0x13BB800", VA = "0x1813BCC00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402204F RID: 139343
			[Token(Token = "0x402204F")]
			private const int EQUIP_COUNT = 3;

			// Token: 0x04022050 RID: 139344
			[Token(Token = "0x4022050")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2SquadCharItemView m_closure;

			// Token: 0x04022051 RID: 139345
			[Token(Token = "0x4022051")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022052 RID: 139346
			[Token(Token = "0x4022052")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022053 RID: 139347
			[Token(Token = "0x4022053")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
