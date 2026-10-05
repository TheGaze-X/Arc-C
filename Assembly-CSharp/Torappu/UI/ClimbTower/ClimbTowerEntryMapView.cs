using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C4E RID: 23630
	[Token(Token = "0x2005C4E")]
	public class ClimbTowerEntryMapView : DataBinder<ClimbTowerEntryMapProperty>
	{
		// Token: 0x1700505E RID: 20574
		// (get) Token: 0x060223E8 RID: 140264 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223E9 RID: 140265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700505E")]
		public Action<ClimbTowerTowerType, string> onTowerClicked
		{
			[Token(Token = "0x60223E8")]
			[Address(RVA = "0x1CA7BF0", Offset = "0x1CA67F0", VA = "0x181CA7BF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223E9")]
			[Address(RVA = "0x1CA7CB0", Offset = "0x1CA68B0", VA = "0x181CA7CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700505F RID: 20575
		// (get) Token: 0x060223EA RID: 140266 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223EB RID: 140267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700505F")]
		public UIPage page
		{
			[Token(Token = "0x60223EA")]
			[Address(RVA = "0x1CA7C50", Offset = "0x1CA6850", VA = "0x181CA7C50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223EB")]
			[Address(RVA = "0x1CA7D30", Offset = "0x1CA6930", VA = "0x181CA7D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060223EC RID: 140268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223EC")]
		[Address(RVA = "0x1CA76D0", Offset = "0x1CA62D0", VA = "0x181CA76D0", Slot = "7")]
		public override void OnValueChanged(ClimbTowerEntryMapProperty property)
		{
		}

		// Token: 0x060223ED RID: 140269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60223ED")]
		[Address(RVA = "0x1CA78A0", Offset = "0x1CA64A0", VA = "0x181CA78A0")]
		private IEnumerator RefreshContentPosition(bool isTrainComplete)
		{
			return null;
		}

		// Token: 0x060223EE RID: 140270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223EE")]
		[Address(RVA = "0x1CA7960", Offset = "0x1CA6560", VA = "0x181CA7960")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060223EF RID: 140271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223EF")]
		[Address(RVA = "0x1CA7B80", Offset = "0x1CA6780", VA = "0x181CA7B80")]
		public ClimbTowerEntryMapView()
		{
		}

		// Token: 0x0402EFFA RID: 192506
		[Token(Token = "0x402EFFA")]
		private const int CONTENT_X_DELTA_IF_TRAIN_COMPLETE = 185;

		// Token: 0x0402EFFB RID: 192507
		[Token(Token = "0x402EFFB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402EFFC RID: 192508
		[Token(Token = "0x402EFFC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _viewPort;

		// Token: 0x0402EFFD RID: 192509
		[Token(Token = "0x402EFFD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClimbTowerEntryMapView.SizeConfig[] _towerSizeConfigs;

		// Token: 0x0402EFFE RID: 192510
		[Token(Token = "0x402EFFE")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerEntryMapView.Adpter m_adapter;

		// Token: 0x0402EFFF RID: 192511
		[Token(Token = "0x402EFFF")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402F000 RID: 192512
		[Token(Token = "0x402F000")]
		[FieldOffset(Offset = "0x41")]
		private bool m_isContentPosInited;

		// Token: 0x0402F001 RID: 192513
		[Token(Token = "0x402F001")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<ClimbTowerTowerType, Vector2> m_itemSizeConfigMap;

		// Token: 0x0402F004 RID: 192516
		[Token(Token = "0x402F004")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTowerClicked;

		// Token: 0x0402F005 RID: 192517
		[Token(Token = "0x402F005")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTowerClicked;

		// Token: 0x0402F006 RID: 192518
		[Token(Token = "0x402F006")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F007 RID: 192519
		[Token(Token = "0x402F007")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F008 RID: 192520
		[Token(Token = "0x402F008")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F009 RID: 192521
		[Token(Token = "0x402F009")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshContentPosition;

		// Token: 0x0402F00A RID: 192522
		[Token(Token = "0x402F00A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F00B RID: 192523
		[Token(Token = "0x402F00B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C4F RID: 23631
		[Token(Token = "0x2005C4F")]
		private class Adpter : SimpleLayoutAdapter
		{
			// Token: 0x060223F0 RID: 140272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60223F0")]
			[Address(RVA = "0x1CA1570", Offset = "0x1CA0170", VA = "0x181CA1570")]
			public Adpter(ClimbTowerEntryMapView closure)
			{
			}

			// Token: 0x17005060 RID: 20576
			// (get) Token: 0x060223F1 RID: 140273 RVA: 0x000BCD00 File Offset: 0x000BAF00
			[Token(Token = "0x17005060")]
			public override int count
			{
				[Token(Token = "0x60223F1")]
				[Address(RVA = "0x1CA15F0", Offset = "0x1CA01F0", VA = "0x181CA15F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060223F2 RID: 140274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60223F2")]
			[Address(RVA = "0x1CA1210", Offset = "0x1C9FE10", VA = "0x181CA1210", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F00C RID: 192524
			[Token(Token = "0x402F00C")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerEntryMapView m_closure;

			// Token: 0x0402F00D RID: 192525
			[Token(Token = "0x402F00D")]
			[FieldOffset(Offset = "0x28")]
			public List<ClimbTowerEntryMapTowerModel> dataSet;

			// Token: 0x0402F00E RID: 192526
			[Token(Token = "0x402F00E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F00F RID: 192527
			[Token(Token = "0x402F00F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F010 RID: 192528
			[Token(Token = "0x402F010")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005C50 RID: 23632
		[Token(Token = "0x2005C50")]
		[Serializable]
		private struct SizeConfig
		{
			// Token: 0x0402F011 RID: 192529
			[Token(Token = "0x402F011")]
			[FieldOffset(Offset = "0x0")]
			public ClimbTowerTowerType type;

			// Token: 0x0402F012 RID: 192530
			[Token(Token = "0x402F012")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 size;
		}
	}
}
