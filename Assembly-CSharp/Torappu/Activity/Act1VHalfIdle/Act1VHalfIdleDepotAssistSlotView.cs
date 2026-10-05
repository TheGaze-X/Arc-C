using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007784 RID: 30596
	[Token(Token = "0x2007784")]
	public class Act1VHalfIdleDepotAssistSlotView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AF80 RID: 176000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF80")]
		[Address(RVA = "0x26C39D0", Offset = "0x26C25D0", VA = "0x1826C39D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AF81 RID: 176001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF81")]
		[Address(RVA = "0x26C3540", Offset = "0x26C2140", VA = "0x1826C3540")]
		public void OnRender(int slotId, bool isAvail, Act1VHalfIdleCharViewModel charViewModel)
		{
		}

		// Token: 0x0602AF82 RID: 176002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF82")]
		[Address(RVA = "0x26C3C40", Offset = "0x26C2840", VA = "0x1826C3C40")]
		private void _RenderLocked()
		{
		}

		// Token: 0x0602AF83 RID: 176003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF83")]
		[Address(RVA = "0x26C3BD0", Offset = "0x26C27D0", VA = "0x1826C3BD0")]
		private void _RenderEmpty()
		{
		}

		// Token: 0x0602AF84 RID: 176004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF84")]
		[Address(RVA = "0x26C3AE0", Offset = "0x26C26E0", VA = "0x1826C3AE0")]
		private void _RenderCharCard(int slotId, Act1VHalfIdleCharViewModel charViewModel)
		{
		}

		// Token: 0x0602AF85 RID: 176005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF85")]
		[Address(RVA = "0x26C3440", Offset = "0x26C2040", VA = "0x1826C3440")]
		public void EventOnClickCard()
		{
		}

		// Token: 0x0602AF86 RID: 176006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF86")]
		[Address(RVA = "0x26C34C0", Offset = "0x26C20C0", VA = "0x1826C34C0")]
		public void EventOnClickRemove()
		{
		}

		// Token: 0x0602AF87 RID: 176007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF87")]
		[Address(RVA = "0x26C3CB0", Offset = "0x26C28B0", VA = "0x1826C3CB0")]
		public Act1VHalfIdleDepotAssistSlotView()
		{
		}

		// Token: 0x0403E009 RID: 253961
		[Token(Token = "0x403E009")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfIdleCharDepotCard _depotCardAsset;

		// Token: 0x0403E00A RID: 253962
		[Token(Token = "0x403E00A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _depotCardRoot;

		// Token: 0x0403E00B RID: 253963
		[Token(Token = "0x403E00B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ThreeStateToggle _threeStateToggle;

		// Token: 0x0403E00C RID: 253964
		[Token(Token = "0x403E00C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelClearSlot;

		// Token: 0x0403E00D RID: 253965
		[Token(Token = "0x403E00D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0403E00E RID: 253966
		[Token(Token = "0x403E00E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act1VHalfIdleDepotAssistSlotView.SlotIdConfig[] _slotIdConfigs;

		// Token: 0x0403E00F RID: 253967
		[Token(Token = "0x403E00F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIButton _btnSlot;

		// Token: 0x0403E010 RID: 253968
		[Token(Token = "0x403E010")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<int> onClickAssist;

		// Token: 0x0403E011 RID: 253969
		[Token(Token = "0x403E011")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<int> onClickClear;

		// Token: 0x0403E012 RID: 253970
		[Token(Token = "0x403E012")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0403E013 RID: 253971
		[Token(Token = "0x403E013")]
		[FieldOffset(Offset = "0x68")]
		private Act1VHalfIdleCharDepotCard m_cachedDepotCard;

		// Token: 0x0403E014 RID: 253972
		[Token(Token = "0x403E014")]
		[FieldOffset(Offset = "0x70")]
		private Act1VHalfIdleDepotAssistSlotView.SlotStatus m_curSlotStatus;

		// Token: 0x0403E015 RID: 253973
		[Token(Token = "0x403E015")]
		[FieldOffset(Offset = "0x74")]
		private int m_cachedSlotId;

		// Token: 0x0403E016 RID: 253974
		[Token(Token = "0x403E016")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E017 RID: 253975
		[Token(Token = "0x403E017")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E018 RID: 253976
		[Token(Token = "0x403E018")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderLocked;

		// Token: 0x0403E019 RID: 253977
		[Token(Token = "0x403E019")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderEmpty;

		// Token: 0x0403E01A RID: 253978
		[Token(Token = "0x403E01A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderCharCard;

		// Token: 0x0403E01B RID: 253979
		[Token(Token = "0x403E01B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClickCard;

		// Token: 0x0403E01C RID: 253980
		[Token(Token = "0x403E01C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClickRemove;

		// Token: 0x0403E01D RID: 253981
		[Token(Token = "0x403E01D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007785 RID: 30597
		[Token(Token = "0x2007785")]
		[Serializable]
		public class SlotIdConfig
		{
			// Token: 0x170064BC RID: 25788
			// (get) Token: 0x0602AF88 RID: 176008 RVA: 0x000DA880 File Offset: 0x000D8A80
			[Token(Token = "0x170064BC")]
			public int slotId
			{
				[Token(Token = "0x602AF88")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170064BD RID: 25789
			// (get) Token: 0x0602AF89 RID: 176009 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170064BD")]
			public GameObject slotIdPanel
			{
				[Token(Token = "0x602AF89")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x170064BE RID: 25790
			// (get) Token: 0x0602AF8A RID: 176010 RVA: 0x000DA898 File Offset: 0x000D8A98
			[Token(Token = "0x170064BE")]
			public bool isEmpty
			{
				[Token(Token = "0x602AF8A")]
				[Address(RVA = "0x26D7840", Offset = "0x26D6440", VA = "0x1826D7840")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AF8B RID: 176011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AF8B")]
			[Address(RVA = "0x173B1A0", Offset = "0x1739DA0", VA = "0x18173B1A0")]
			public SlotIdConfig()
			{
			}

			// Token: 0x0403E01E RID: 253982
			[Token(Token = "0x403E01E")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int _slotId;

			// Token: 0x0403E01F RID: 253983
			[Token(Token = "0x403E01F")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _slotIdPanel;
		}

		// Token: 0x02007786 RID: 30598
		[Token(Token = "0x2007786")]
		private enum SlotStatus
		{
			// Token: 0x0403E021 RID: 253985
			[Token(Token = "0x403E021")]
			LOCKED,
			// Token: 0x0403E022 RID: 253986
			[Token(Token = "0x403E022")]
			EMPTY,
			// Token: 0x0403E023 RID: 253987
			[Token(Token = "0x403E023")]
			HAS_CHAR
		}
	}
}
