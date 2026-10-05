using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007680 RID: 30336
	[Token(Token = "0x2007680")]
	public class Act20sideCollectionItemAdapter : RecycleLoopScrollAdapter<Act20sideCollectionItemAdapter.ViewHolder, Act20sideCollectionItemViewModel>
	{
		// Token: 0x17006440 RID: 25664
		// (get) Token: 0x0602AAB7 RID: 174775 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AAB8 RID: 174776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006440")]
		public string selectedItemId
		{
			[Token(Token = "0x602AAB7")]
			[Address(RVA = "0x2670350", Offset = "0x266EF50", VA = "0x182670350")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AAB8")]
			[Address(RVA = "0x2670430", Offset = "0x266F030", VA = "0x182670430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006441 RID: 25665
		// (get) Token: 0x0602AAB9 RID: 174777 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AABA RID: 174778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006441")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x602AAB9")]
			[Address(RVA = "0x26702F0", Offset = "0x266EEF0", VA = "0x1826702F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AABA")]
			[Address(RVA = "0x26703B0", Offset = "0x266EFB0", VA = "0x1826703B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AABB RID: 174779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AABB")]
		[Address(RVA = "0x266FF50", Offset = "0x266EB50", VA = "0x18266FF50", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act20sideCollectionItemAdapter.ViewHolder holder, Act20sideCollectionItemViewModel data)
		{
		}

		// Token: 0x0602AABC RID: 174780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AABC")]
		[Address(RVA = "0x26700F0", Offset = "0x266ECF0", VA = "0x1826700F0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602AABD RID: 174781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AABD")]
		[Address(RVA = "0x2670280", Offset = "0x266EE80", VA = "0x182670280")]
		public Act20sideCollectionItemAdapter()
		{
		}

		// Token: 0x0403D768 RID: 251752
		[Token(Token = "0x403D768")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act20sideCommonCarCompItemView _itemPrefab;

		// Token: 0x0403D76B RID: 251755
		[Token(Token = "0x403D76B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedItemId;

		// Token: 0x0403D76C RID: 251756
		[Token(Token = "0x403D76C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedItemId;

		// Token: 0x0403D76D RID: 251757
		[Token(Token = "0x403D76D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0403D76E RID: 251758
		[Token(Token = "0x403D76E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0403D76F RID: 251759
		[Token(Token = "0x403D76F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403D770 RID: 251760
		[Token(Token = "0x403D770")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403D771 RID: 251761
		[Token(Token = "0x403D771")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007681 RID: 30337
		[Token(Token = "0x2007681")]
		public class ViewHolder
		{
			// Token: 0x0602AABE RID: 174782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AABE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403D772 RID: 251762
			[Token(Token = "0x403D772")]
			[FieldOffset(Offset = "0x10")]
			public Act20sideCommonCarCompItemView compItem;
		}
	}
}
