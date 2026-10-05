using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F33 RID: 16179
	[Token(Token = "0x2003F33")]
	public class SiracusaOperaCommentColumnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x06019212 RID: 102930 RVA: 0x0009D0F8 File Offset: 0x0009B2F8
		[Token(Token = "0x17003C1F")]
		public float columnHeight
		{
			[Token(Token = "0x6019212")]
			[Address(RVA = "0x11D8640", Offset = "0x11D7240", VA = "0x1811D8640")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06019213 RID: 102931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019213")]
		[Address(RVA = "0x11D8000", Offset = "0x11D6C00", VA = "0x1811D8000")]
		public void Render(List<SiracusaOperaCommentItemViewModel> items, string selectedCommentId, bool isInit = false)
		{
		}

		// Token: 0x06019214 RID: 102932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019214")]
		[Address(RVA = "0x11D8350", Offset = "0x11D6F50", VA = "0x1811D8350")]
		public void SetBottomHeight(float bottomHeight)
		{
		}

		// Token: 0x06019215 RID: 102933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019215")]
		[Address(RVA = "0x11D84B0", Offset = "0x11D70B0", VA = "0x1811D84B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019216 RID: 102934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019216")]
		[Address(RVA = "0x11D85E0", Offset = "0x11D71E0", VA = "0x1811D85E0")]
		public SiracusaOperaCommentColumnView()
		{
		}

		// Token: 0x0401F1E7 RID: 127463
		[Token(Token = "0x401F1E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401F1E8 RID: 127464
		[Token(Token = "0x401F1E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VerticalLayoutGroup _layoutGroup;

		// Token: 0x0401F1E9 RID: 127465
		[Token(Token = "0x401F1E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _bottom;

		// Token: 0x0401F1EA RID: 127466
		[Token(Token = "0x401F1EA")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<string> onCommentClicked;

		// Token: 0x0401F1EB RID: 127467
		[Token(Token = "0x401F1EB")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401F1EC RID: 127468
		[Token(Token = "0x401F1EC")]
		[FieldOffset(Offset = "0x40")]
		private SiracusaOperaCommentColumnView.Adapter m_adapter;

		// Token: 0x0401F1ED RID: 127469
		[Token(Token = "0x401F1ED")]
		[FieldOffset(Offset = "0x48")]
		private float m_columnHeight;

		// Token: 0x0401F1EE RID: 127470
		[Token(Token = "0x401F1EE")]
		private const float BOTTOM_FILL_THRESHOLD_HEIGHT = 180f;

		// Token: 0x0401F1EF RID: 127471
		[Token(Token = "0x401F1EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_columnHeight;

		// Token: 0x0401F1F0 RID: 127472
		[Token(Token = "0x401F1F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F1F1 RID: 127473
		[Token(Token = "0x401F1F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetBottomHeight;

		// Token: 0x0401F1F2 RID: 127474
		[Token(Token = "0x401F1F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F1F3 RID: 127475
		[Token(Token = "0x401F1F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F34 RID: 16180
		[Token(Token = "0x2003F34")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003C20 RID: 15392
			// (set) Token: 0x06019217 RID: 102935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003C20")]
			public List<SiracusaOperaCommentItemViewModel> items
			{
				[Token(Token = "0x6019217")]
				[Address(RVA = "0x11C5530", Offset = "0x11C4130", VA = "0x1811C5530")]
				set
				{
				}
			}

			// Token: 0x17003C21 RID: 15393
			// (get) Token: 0x06019218 RID: 102936 RVA: 0x0009D110 File Offset: 0x0009B310
			[Token(Token = "0x17003C21")]
			public float columnHeight
			{
				[Token(Token = "0x6019218")]
				[Address(RVA = "0x11C5140", Offset = "0x11C3D40", VA = "0x1811C5140")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17003C22 RID: 15394
			// (get) Token: 0x06019219 RID: 102937 RVA: 0x0009D128 File Offset: 0x0009B328
			[Token(Token = "0x17003C22")]
			public override int count
			{
				[Token(Token = "0x6019219")]
				[Address(RVA = "0x11C52A0", Offset = "0x11C3EA0", VA = "0x1811C52A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601921A RID: 102938 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601921A")]
			[Address(RVA = "0x11C4590", Offset = "0x11C3190", VA = "0x1811C4590", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601921B RID: 102939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601921B")]
			[Address(RVA = "0x11C50E0", Offset = "0x11C3CE0", VA = "0x1811C50E0")]
			public Adapter()
			{
			}

			// Token: 0x0401F1F4 RID: 127476
			[Token(Token = "0x401F1F4")]
			[FieldOffset(Offset = "0x20")]
			public List<SiracusaOperaCommentItemViewModel> m_items;

			// Token: 0x0401F1F5 RID: 127477
			[Token(Token = "0x401F1F5")]
			[FieldOffset(Offset = "0x28")]
			public string selectedCommentId;

			// Token: 0x0401F1F6 RID: 127478
			[Token(Token = "0x401F1F6")]
			[FieldOffset(Offset = "0x30")]
			public SiracusaOperaCommentColumnView closure;

			// Token: 0x0401F1F7 RID: 127479
			[Token(Token = "0x401F1F7")]
			[FieldOffset(Offset = "0x38")]
			public bool isInit;

			// Token: 0x0401F1F8 RID: 127480
			[Token(Token = "0x401F1F8")]
			[FieldOffset(Offset = "0x3C")]
			private float m_columnHeight;

			// Token: 0x0401F1F9 RID: 127481
			[Token(Token = "0x401F1F9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_items;

			// Token: 0x0401F1FA RID: 127482
			[Token(Token = "0x401F1FA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_columnHeight;

			// Token: 0x0401F1FB RID: 127483
			[Token(Token = "0x401F1FB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F1FC RID: 127484
			[Token(Token = "0x401F1FC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401F1FD RID: 127485
			[Token(Token = "0x401F1FD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
