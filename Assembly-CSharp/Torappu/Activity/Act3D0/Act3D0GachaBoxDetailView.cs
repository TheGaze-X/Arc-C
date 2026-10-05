using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073F9 RID: 29689
	[Token(Token = "0x20073F9")]
	public class Act3D0GachaBoxDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029EF8 RID: 171768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF8")]
		[Address(RVA = "0x2588740", Offset = "0x2587340", VA = "0x182588740")]
		public void Render(Act3D0GachaBoxInfo info, Act3D0Data.InfinitePoolPercent percent)
		{
		}

		// Token: 0x06029EF9 RID: 171769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF9")]
		[Address(RVA = "0x2588D50", Offset = "0x2587950", VA = "0x182588D50")]
		public Act3D0GachaBoxDetailView()
		{
		}

		// Token: 0x0403C177 RID: 246135
		[Token(Token = "0x403C177")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x0403C178 RID: 246136
		[Token(Token = "0x403C178")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedObj;

		// Token: 0x0403C179 RID: 246137
		[Token(Token = "0x403C179")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _lockImg;

		// Token: 0x0403C17A RID: 246138
		[Token(Token = "0x403C17A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _requireText;

		// Token: 0x0403C17B RID: 246139
		[Token(Token = "0x403C17B")]
		[FieldOffset(Offset = "0x38")]
		private Act3D0GachaBoxDetailView.Adapter m_adapter;

		// Token: 0x0403C17C RID: 246140
		[Token(Token = "0x403C17C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C17D RID: 246141
		[Token(Token = "0x403C17D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020073FA RID: 29690
		[Token(Token = "0x20073FA")]
		public class GachaBoxGroupInfo : IComparable<Act3D0GachaBoxDetailView.GachaBoxGroupInfo>
		{
			// Token: 0x06029EFA RID: 171770 RVA: 0x000D7010 File Offset: 0x000D5210
			[Token(Token = "0x6029EFA")]
			[Address(RVA = "0x20E5CF0", Offset = "0x20E48F0", VA = "0x1820E5CF0", Slot = "4")]
			public int CompareTo(Act3D0GachaBoxDetailView.GachaBoxGroupInfo other)
			{
				return 0;
			}

			// Token: 0x06029EFB RID: 171771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029EFB")]
			[Address(RVA = "0xED4B00", Offset = "0xED3700", VA = "0x180ED4B00")]
			public GachaBoxGroupInfo()
			{
			}

			// Token: 0x0403C17E RID: 246142
			[Token(Token = "0x403C17E")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0403C17F RID: 246143
			[Token(Token = "0x403C17F")]
			[FieldOffset(Offset = "0x18")]
			public int orderId;

			// Token: 0x0403C180 RID: 246144
			[Token(Token = "0x403C180")]
			[FieldOffset(Offset = "0x20")]
			public List<Act3D0GachaBoxInfo.Act3D0GachaBoxItemInfo> itemList;

			// Token: 0x0403C181 RID: 246145
			[Token(Token = "0x403C181")]
			[FieldOffset(Offset = "0x28")]
			public int percent;
		}

		// Token: 0x020073FB RID: 29691
		[Token(Token = "0x20073FB")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17006309 RID: 25353
			// (get) Token: 0x06029EFC RID: 171772 RVA: 0x000D7028 File Offset: 0x000D5228
			[Token(Token = "0x17006309")]
			public override int count
			{
				[Token(Token = "0x6029EFC")]
				[Address(RVA = "0x2592B50", Offset = "0x2591750", VA = "0x182592B50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029EFD RID: 171773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029EFD")]
			[Address(RVA = "0x2592A70", Offset = "0x2591670", VA = "0x182592A70")]
			public Adapter()
			{
			}

			// Token: 0x06029EFE RID: 171774 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029EFE")]
			[Address(RVA = "0x2592320", Offset = "0x2590F20", VA = "0x182592320", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403C182 RID: 246146
			[Token(Token = "0x403C182")]
			[FieldOffset(Offset = "0x20")]
			public List<Act3D0GachaBoxDetailView.GachaBoxGroupInfo> infoList;

			// Token: 0x0403C183 RID: 246147
			[Token(Token = "0x403C183")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403C184 RID: 246148
			[Token(Token = "0x403C184")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403C185 RID: 246149
			[Token(Token = "0x403C185")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
