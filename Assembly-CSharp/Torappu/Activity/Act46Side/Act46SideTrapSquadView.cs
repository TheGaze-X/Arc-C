using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Squad;
using Torappu.UI.TemplateTrap;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act46Side
{
	// Token: 0x020072AA RID: 29354
	[Token(Token = "0x20072AA")]
	public class Act46SideTrapSquadView : TemplateTrapSquadPlugin
	{
		// Token: 0x060298E9 RID: 170217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298E9")]
		[Address(RVA = "0x24FFA80", Offset = "0x24FE680", VA = "0x1824FFA80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060298EA RID: 170218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298EA")]
		[Address(RVA = "0x24FFBB0", Offset = "0x24FE7B0", VA = "0x1824FFBB0")]
		private void _LoadData()
		{
		}

		// Token: 0x060298EB RID: 170219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298EB")]
		[Address(RVA = "0x24FF920", Offset = "0x24FE520", VA = "0x1824FF920", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x060298EC RID: 170220 RVA: 0x000D5E88 File Offset: 0x000D4088
		[Token(Token = "0x60298EC")]
		[Address(RVA = "0x24FF8C0", Offset = "0x24FE4C0", VA = "0x1824FF8C0", Slot = "10")]
		public override bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x060298ED RID: 170221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298ED")]
		[Address(RVA = "0x2500190", Offset = "0x24FED90", VA = "0x182500190")]
		private void _OnItemClicked(string trapId)
		{
		}

		// Token: 0x060298EE RID: 170222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298EE")]
		[Address(RVA = "0x24FF740", Offset = "0x24FE340", VA = "0x1824FF740")]
		public void EventOnDetailBtnClicked()
		{
		}

		// Token: 0x060298EF RID: 170223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298EF")]
		[Address(RVA = "0x25005A0", Offset = "0x24FF1A0", VA = "0x1825005A0")]
		public Act46SideTrapSquadView()
		{
		}

		// Token: 0x060298F0 RID: 170224 RVA: 0x000D5EA0 File Offset: 0x000D40A0
		[Token(Token = "0x60298F0")]
		[Address(RVA = "0x1872C40", Offset = "0x1871840", VA = "0x181872C40")]
		private bool <>xLuaBaseProxy_ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0403B6B8 RID: 243384
		[Token(Token = "0x403B6B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _trapItemList;

		// Token: 0x0403B6B9 RID: 243385
		[Token(Token = "0x403B6B9")]
		[FieldOffset(Offset = "0x38")]
		private bool m_flagInfo;

		// Token: 0x0403B6BA RID: 243386
		[Token(Token = "0x403B6BA")]
		[FieldOffset(Offset = "0x40")]
		private string m_stageId;

		// Token: 0x0403B6BB RID: 243387
		[Token(Token = "0x403B6BB")]
		[FieldOffset(Offset = "0x48")]
		private string m_groupId;

		// Token: 0x0403B6BC RID: 243388
		[Token(Token = "0x403B6BC")]
		[FieldOffset(Offset = "0x50")]
		private string m_domainId;

		// Token: 0x0403B6BD RID: 243389
		[Token(Token = "0x403B6BD")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isAutoMode;

		// Token: 0x0403B6BE RID: 243390
		[Token(Token = "0x403B6BE")]
		[FieldOffset(Offset = "0x59")]
		private bool m_isRetro;

		// Token: 0x0403B6BF RID: 243391
		[Token(Token = "0x403B6BF")]
		[FieldOffset(Offset = "0x60")]
		private ListDict<string, Act46SideTrapSquadView.TrapItemViewModel> m_trapItemList;

		// Token: 0x0403B6C0 RID: 243392
		[Token(Token = "0x403B6C0")]
		[FieldOffset(Offset = "0x68")]
		private string m_selectedTrap;

		// Token: 0x0403B6C1 RID: 243393
		[Token(Token = "0x403B6C1")]
		[FieldOffset(Offset = "0x70")]
		private string m_saveSuccessToast;

		// Token: 0x0403B6C2 RID: 243394
		[Token(Token = "0x403B6C2")]
		[FieldOffset(Offset = "0x78")]
		private Act46SideTrapSquadView.Adapter m_adapter;

		// Token: 0x0403B6C3 RID: 243395
		[Token(Token = "0x403B6C3")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0403B6C4 RID: 243396
		[Token(Token = "0x403B6C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B6C5 RID: 243397
		[Token(Token = "0x403B6C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0403B6C6 RID: 243398
		[Token(Token = "0x403B6C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403B6C7 RID: 243399
		[Token(Token = "0x403B6C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x0403B6C8 RID: 243400
		[Token(Token = "0x403B6C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0403B6C9 RID: 243401
		[Token(Token = "0x403B6C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnDetailBtnClicked;

		// Token: 0x0403B6CA RID: 243402
		[Token(Token = "0x403B6CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072AB RID: 29355
		[Token(Token = "0x20072AB")]
		public class TrapItemViewModel : IHotfixable
		{
			// Token: 0x060298F1 RID: 170225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60298F1")]
			[Address(RVA = "0x2501EE0", Offset = "0x2500AE0", VA = "0x182501EE0")]
			public TrapItemViewModel()
			{
			}

			// Token: 0x0403B6CB RID: 243403
			[Token(Token = "0x403B6CB")]
			[FieldOffset(Offset = "0x10")]
			public string domainId;

			// Token: 0x0403B6CC RID: 243404
			[Token(Token = "0x403B6CC")]
			[FieldOffset(Offset = "0x18")]
			public string trapId;

			// Token: 0x0403B6CD RID: 243405
			[Token(Token = "0x403B6CD")]
			[FieldOffset(Offset = "0x20")]
			public string trapName;

			// Token: 0x0403B6CE RID: 243406
			[Token(Token = "0x403B6CE")]
			[FieldOffset(Offset = "0x28")]
			public bool isUnlocked;

			// Token: 0x0403B6CF RID: 243407
			[Token(Token = "0x403B6CF")]
			[FieldOffset(Offset = "0x2C")]
			public int sortId;

			// Token: 0x0403B6D0 RID: 243408
			[Token(Token = "0x403B6D0")]
			[FieldOffset(Offset = "0x30")]
			public string lockedToast;

			// Token: 0x0403B6D1 RID: 243409
			[Token(Token = "0x403B6D1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020072AC RID: 29356
		[Token(Token = "0x20072AC")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060298F2 RID: 170226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60298F2")]
			[Address(RVA = "0x25011C0", Offset = "0x24FFDC0", VA = "0x1825011C0")]
			public Adapter(Act46SideTrapSquadView closure)
			{
			}

			// Token: 0x17006247 RID: 25159
			// (get) Token: 0x060298F3 RID: 170227 RVA: 0x000D5EB8 File Offset: 0x000D40B8
			[Token(Token = "0x17006247")]
			public override int count
			{
				[Token(Token = "0x60298F3")]
				[Address(RVA = "0x2501310", Offset = "0x24FFF10", VA = "0x182501310", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060298F4 RID: 170228 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60298F4")]
			[Address(RVA = "0x2500C80", Offset = "0x24FF880", VA = "0x182500C80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B6D2 RID: 243410
			[Token(Token = "0x403B6D2")]
			[FieldOffset(Offset = "0x20")]
			private Act46SideTrapSquadView m_closure;

			// Token: 0x0403B6D3 RID: 243411
			[Token(Token = "0x403B6D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B6D4 RID: 243412
			[Token(Token = "0x403B6D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B6D5 RID: 243413
			[Token(Token = "0x403B6D5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
