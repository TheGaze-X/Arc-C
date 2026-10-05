using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x020074A2 RID: 29858
	[Token(Token = "0x20074A2")]
	public class Act29signCheckinItemAdapter : RecycleLoopScrollAdapter<Act29signCheckinItemAdapter.ViewHolder, Act29signSpecialCheckinItemViewModel>
	{
		// Token: 0x1700634F RID: 25423
		// (get) Token: 0x0602A1C4 RID: 172484 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A1C5 RID: 172485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700634F")]
		public UnityAction<int> onNormalItemClicked
		{
			[Token(Token = "0x602A1C4")]
			[Address(RVA = "0x25B1C00", Offset = "0x25B0800", VA = "0x1825B1C00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A1C5")]
			[Address(RVA = "0x25B1CC0", Offset = "0x25B08C0", VA = "0x1825B1CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006350 RID: 25424
		// (get) Token: 0x0602A1C6 RID: 172486 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A1C7 RID: 172487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006350")]
		public UnityAction onSpecialItemClicked
		{
			[Token(Token = "0x602A1C6")]
			[Address(RVA = "0x25B1C60", Offset = "0x25B0860", VA = "0x1825B1C60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A1C7")]
			[Address(RVA = "0x25B1D40", Offset = "0x25B0940", VA = "0x1825B1D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602A1C8 RID: 172488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1C8")]
		[Address(RVA = "0x25B18D0", Offset = "0x25B04D0", VA = "0x1825B18D0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act29signCheckinItemAdapter.ViewHolder holder, Act29signSpecialCheckinItemViewModel data)
		{
		}

		// Token: 0x0602A1C9 RID: 172489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A1C9")]
		[Address(RVA = "0x25B1AC0", Offset = "0x25B06C0", VA = "0x1825B1AC0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602A1CA RID: 172490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1CA")]
		[Address(RVA = "0x25B1B90", Offset = "0x25B0790", VA = "0x1825B1B90")]
		public Act29signCheckinItemAdapter()
		{
		}

		// Token: 0x0403C771 RID: 247665
		[Token(Token = "0x403C771")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act29signCheckinItemViewHolder _viewHolderPrefab;

		// Token: 0x0403C774 RID: 247668
		[Token(Token = "0x403C774")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNormalItemClicked;

		// Token: 0x0403C775 RID: 247669
		[Token(Token = "0x403C775")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNormalItemClicked;

		// Token: 0x0403C776 RID: 247670
		[Token(Token = "0x403C776")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onSpecialItemClicked;

		// Token: 0x0403C777 RID: 247671
		[Token(Token = "0x403C777")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onSpecialItemClicked;

		// Token: 0x0403C778 RID: 247672
		[Token(Token = "0x403C778")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403C779 RID: 247673
		[Token(Token = "0x403C779")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403C77A RID: 247674
		[Token(Token = "0x403C77A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074A3 RID: 29859
		[Token(Token = "0x20074A3")]
		public class ViewHolder
		{
			// Token: 0x0602A1CB RID: 172491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A1CB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403C77B RID: 247675
			[Token(Token = "0x403C77B")]
			[FieldOffset(Offset = "0x10")]
			public Act29signCheckinItemViewHolder checkinItemViewHolder;
		}
	}
}
