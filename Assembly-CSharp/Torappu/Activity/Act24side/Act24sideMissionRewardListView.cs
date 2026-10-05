using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075DF RID: 30175
	[Token(Token = "0x20075DF")]
	public class Act24sideMissionRewardListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A7BD RID: 174013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7BD")]
		[Address(RVA = "0x2629360", Offset = "0x2627F60", VA = "0x182629360")]
		public void Render(Act24sideMissionObjViewModel model)
		{
		}

		// Token: 0x0602A7BE RID: 174014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7BE")]
		[Address(RVA = "0x2629520", Offset = "0x2628120", VA = "0x182629520")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A7BF RID: 174015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7BF")]
		[Address(RVA = "0x2629650", Offset = "0x2628250", VA = "0x182629650")]
		public Act24sideMissionRewardListView()
		{
		}

		// Token: 0x0403D26E RID: 250478
		[Token(Token = "0x403D26E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403D26F RID: 250479
		[Token(Token = "0x403D26F")]
		[FieldOffset(Offset = "0x20")]
		private Act24sideMissionRewardListView.Adapter m_adapter;

		// Token: 0x0403D270 RID: 250480
		[Token(Token = "0x403D270")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403D271 RID: 250481
		[Token(Token = "0x403D271")]
		[FieldOffset(Offset = "0x30")]
		private Act24sideMissionObjViewModel m_cachedModel;

		// Token: 0x0403D272 RID: 250482
		[Token(Token = "0x403D272")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D273 RID: 250483
		[Token(Token = "0x403D273")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D274 RID: 250484
		[Token(Token = "0x403D274")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075E0 RID: 30176
		[Token(Token = "0x20075E0")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170063E8 RID: 25576
			// (get) Token: 0x0602A7C0 RID: 174016 RVA: 0x000D8AF8 File Offset: 0x000D6CF8
			[Token(Token = "0x170063E8")]
			public override int count
			{
				[Token(Token = "0x602A7C0")]
				[Address(RVA = "0x26338D0", Offset = "0x26324D0", VA = "0x1826338D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A7C1 RID: 174017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A7C1")]
			[Address(RVA = "0x26332D0", Offset = "0x2631ED0", VA = "0x1826332D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602A7C2 RID: 174018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A7C2")]
			[Address(RVA = "0x2633850", Offset = "0x2632450", VA = "0x182633850")]
			public Adapter(Act24sideMissionRewardListView closure)
			{
			}

			// Token: 0x0602A7C3 RID: 174019 RVA: 0x000D8B10 File Offset: 0x000D6D10
			[Token(Token = "0x602A7C3")]
			[Address(RVA = "0x2633750", Offset = "0x2632350", VA = "0x182633750")]
			private int _GetPosition(int position)
			{
				return 0;
			}

			// Token: 0x0403D275 RID: 250485
			[Token(Token = "0x403D275")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideMissionRewardListView m_closure;

			// Token: 0x0403D276 RID: 250486
			[Token(Token = "0x403D276")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D277 RID: 250487
			[Token(Token = "0x403D277")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403D278 RID: 250488
			[Token(Token = "0x403D278")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D279 RID: 250489
			[Token(Token = "0x403D279")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GetPosition;
		}
	}
}
