using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005465 RID: 21605
	[Token(Token = "0x2005465")]
	public class RoguelikeSacrificeViewScrollAdapter : RecycleLoopScrollAdapter<RoguelikeSacrificeViewScrollAdapter.ViewHolder, IRoguelikeSacrifice>
	{
		// Token: 0x17004A95 RID: 19093
		// (get) Token: 0x0601FCD8 RID: 130264 RVA: 0x000B33B8 File Offset: 0x000B15B8
		// (set) Token: 0x0601FCD9 RID: 130265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A95")]
		public bool isInit
		{
			[Token(Token = "0x601FCD8")]
			[Address(RVA = "0x19FB520", Offset = "0x19FA120", VA = "0x1819FB520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601FCD9")]
			[Address(RVA = "0x19FB640", Offset = "0x19FA240", VA = "0x1819FB640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A96 RID: 19094
		// (get) Token: 0x0601FCDA RID: 130266 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FCDB RID: 130267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A96")]
		public string selectedItem
		{
			[Token(Token = "0x601FCDA")]
			[Address(RVA = "0x19FB5E0", Offset = "0x19FA1E0", VA = "0x1819FB5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601FCDB")]
			[Address(RVA = "0x19FB730", Offset = "0x19FA330", VA = "0x1819FB730")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A97 RID: 19095
		// (get) Token: 0x0601FCDC RID: 130268 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FCDD RID: 130269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A97")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x601FCDC")]
			[Address(RVA = "0x19FB580", Offset = "0x19FA180", VA = "0x1819FB580")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601FCDD")]
			[Address(RVA = "0x19FB6B0", Offset = "0x19FA2B0", VA = "0x1819FB6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601FCDE RID: 130270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FCDE")]
		[Address(RVA = "0x19FB400", Offset = "0x19FA000", VA = "0x1819FB400", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601FCDF RID: 130271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCDF")]
		[Address(RVA = "0x19FB1D0", Offset = "0x19F9DD0", VA = "0x1819FB1D0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, RoguelikeSacrificeViewScrollAdapter.ViewHolder holder, IRoguelikeSacrifice data)
		{
		}

		// Token: 0x0601FCE0 RID: 130272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCE0")]
		[Address(RVA = "0x19FB4B0", Offset = "0x19FA0B0", VA = "0x1819FB4B0")]
		public RoguelikeSacrificeViewScrollAdapter()
		{
		}

		// Token: 0x0402ADA4 RID: 175524
		[Token(Token = "0x402ADA4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x0402ADA8 RID: 175528
		[Token(Token = "0x402ADA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInit;

		// Token: 0x0402ADA9 RID: 175529
		[Token(Token = "0x402ADA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isInit;

		// Token: 0x0402ADAA RID: 175530
		[Token(Token = "0x402ADAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedItem;

		// Token: 0x0402ADAB RID: 175531
		[Token(Token = "0x402ADAB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectedItem;

		// Token: 0x0402ADAC RID: 175532
		[Token(Token = "0x402ADAC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0402ADAD RID: 175533
		[Token(Token = "0x402ADAD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0402ADAE RID: 175534
		[Token(Token = "0x402ADAE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402ADAF RID: 175535
		[Token(Token = "0x402ADAF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402ADB0 RID: 175536
		[Token(Token = "0x402ADB0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005466 RID: 21606
		[Token(Token = "0x2005466")]
		public class ViewHolder
		{
			// Token: 0x0601FCE1 RID: 130273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FCE1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402ADB1 RID: 175537
			[Token(Token = "0x402ADB1")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeSacrificeListItem item;
		}
	}
}
