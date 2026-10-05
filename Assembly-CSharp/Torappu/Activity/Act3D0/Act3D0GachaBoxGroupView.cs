using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073FC RID: 29692
	[Token(Token = "0x20073FC")]
	public class Act3D0GachaBoxGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029EFF RID: 171775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EFF")]
		[Address(RVA = "0x2588DB0", Offset = "0x25879B0", VA = "0x182588DB0")]
		public void Render(Act3D0GachaBoxDetailView.GachaBoxGroupInfo viewModel)
		{
		}

		// Token: 0x06029F00 RID: 171776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F00")]
		[Address(RVA = "0x2589000", Offset = "0x2587C00", VA = "0x182589000")]
		public Act3D0GachaBoxGroupView()
		{
		}

		// Token: 0x0403C186 RID: 246150
		[Token(Token = "0x403C186")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x0403C187 RID: 246151
		[Token(Token = "0x403C187")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403C188 RID: 246152
		[Token(Token = "0x403C188")]
		[FieldOffset(Offset = "0x28")]
		private Act3D0GachaBoxGroupView.Adapter m_adapter;

		// Token: 0x0403C189 RID: 246153
		[Token(Token = "0x403C189")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C18A RID: 246154
		[Token(Token = "0x403C18A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020073FD RID: 29693
		[Token(Token = "0x20073FD")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700630A RID: 25354
			// (get) Token: 0x06029F01 RID: 171777 RVA: 0x000D7040 File Offset: 0x000D5240
			[Token(Token = "0x1700630A")]
			public override int count
			{
				[Token(Token = "0x6029F01")]
				[Address(RVA = "0x2592BC0", Offset = "0x25917C0", VA = "0x182592BC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029F02 RID: 171778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029F02")]
			[Address(RVA = "0x25929B0", Offset = "0x25915B0", VA = "0x1825929B0")]
			public Adapter()
			{
			}

			// Token: 0x06029F03 RID: 171779 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029F03")]
			[Address(RVA = "0x2592810", Offset = "0x2591410", VA = "0x182592810", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403C18B RID: 246155
			[Token(Token = "0x403C18B")]
			[FieldOffset(Offset = "0x20")]
			public List<Act3D0GachaBoxInfo.Act3D0GachaBoxItemInfo> itemList;

			// Token: 0x0403C18C RID: 246156
			[Token(Token = "0x403C18C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403C18D RID: 246157
			[Token(Token = "0x403C18D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403C18E RID: 246158
			[Token(Token = "0x403C18E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
