using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C48 RID: 23624
	[Token(Token = "0x2005C48")]
	public class ClimbTowerEntryGodCardDetailButtonGroupView : DataBinder<ClimbTowerEntryGodCardDetailProperty>, IHotfixable
	{
		// Token: 0x17005058 RID: 20568
		// (get) Token: 0x060223CE RID: 140238 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223CF RID: 140239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005058")]
		public Action<string> onButtonClicked
		{
			[Token(Token = "0x60223CE")]
			[Address(RVA = "0x1CA6530", Offset = "0x1CA5130", VA = "0x181CA6530")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223CF")]
			[Address(RVA = "0x1CA6590", Offset = "0x1CA5190", VA = "0x181CA6590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060223D0 RID: 140240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223D0")]
		[Address(RVA = "0x1CA61B0", Offset = "0x1CA4DB0", VA = "0x181CA61B0", Slot = "7")]
		public override void OnValueChanged(ClimbTowerEntryGodCardDetailProperty property)
		{
		}

		// Token: 0x060223D1 RID: 140241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223D1")]
		[Address(RVA = "0x1CA63A0", Offset = "0x1CA4FA0", VA = "0x181CA63A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060223D2 RID: 140242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223D2")]
		[Address(RVA = "0x1CA64C0", Offset = "0x1CA50C0", VA = "0x181CA64C0")]
		public ClimbTowerEntryGodCardDetailButtonGroupView()
		{
		}

		// Token: 0x0402EFB9 RID: 192441
		[Token(Token = "0x402EFB9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _buttonContent;

		// Token: 0x0402EFBA RID: 192442
		[Token(Token = "0x402EFBA")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0402EFBB RID: 192443
		[Token(Token = "0x402EFBB")]
		[FieldOffset(Offset = "0x30")]
		private ClimbTowerEntryGodCardDetailButtonGroupView.Adapter m_adapter;

		// Token: 0x0402EFBC RID: 192444
		[Token(Token = "0x402EFBC")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, ClimbTowerEntryGodCardModel> m_cardModelMap;

		// Token: 0x0402EFBD RID: 192445
		[Token(Token = "0x402EFBD")]
		[FieldOffset(Offset = "0x40")]
		private string m_selectedCardId;

		// Token: 0x0402EFBF RID: 192447
		[Token(Token = "0x402EFBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onButtonClicked;

		// Token: 0x0402EFC0 RID: 192448
		[Token(Token = "0x402EFC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onButtonClicked;

		// Token: 0x0402EFC1 RID: 192449
		[Token(Token = "0x402EFC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402EFC2 RID: 192450
		[Token(Token = "0x402EFC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EFC3 RID: 192451
		[Token(Token = "0x402EFC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C49 RID: 23625
		[Token(Token = "0x2005C49")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060223D3 RID: 140243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60223D3")]
			[Address(RVA = "0x1CA0DB0", Offset = "0x1C9F9B0", VA = "0x181CA0DB0")]
			public Adapter(ClimbTowerEntryGodCardDetailButtonGroupView closure)
			{
			}

			// Token: 0x17005059 RID: 20569
			// (get) Token: 0x060223D4 RID: 140244 RVA: 0x000BCCD0 File Offset: 0x000BAED0
			[Token(Token = "0x17005059")]
			public override int count
			{
				[Token(Token = "0x60223D4")]
				[Address(RVA = "0x1CA1030", Offset = "0x1C9FC30", VA = "0x181CA1030", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060223D5 RID: 140245 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60223D5")]
			[Address(RVA = "0x1C9FF10", Offset = "0x1C9EB10", VA = "0x181C9FF10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402EFC4 RID: 192452
			[Token(Token = "0x402EFC4")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerEntryGodCardDetailButtonGroupView m_closure;

			// Token: 0x0402EFC5 RID: 192453
			[Token(Token = "0x402EFC5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402EFC6 RID: 192454
			[Token(Token = "0x402EFC6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EFC7 RID: 192455
			[Token(Token = "0x402EFC7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
