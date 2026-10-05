using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B3E RID: 27454
	[Token(Token = "0x2006B3E")]
	public class ArchiveChatDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060273EF RID: 160751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273EF")]
		[Address(RVA = "0x226B860", Offset = "0x226A460", VA = "0x18226B860")]
		public void Render(ChatItemModel item, bool showButton)
		{
		}

		// Token: 0x060273F0 RID: 160752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273F0")]
		[Address(RVA = "0x226BC20", Offset = "0x226A820", VA = "0x18226BC20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060273F1 RID: 160753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273F1")]
		[Address(RVA = "0x226BD40", Offset = "0x226A940", VA = "0x18226BD40")]
		public ArchiveChatDetailItemView()
		{
		}

		// Token: 0x04037881 RID: 227457
		[Token(Token = "0x4037881")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _unlockStatus;

		// Token: 0x04037882 RID: 227458
		[Token(Token = "0x4037882")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textYear;

		// Token: 0x04037883 RID: 227459
		[Token(Token = "0x4037883")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textMonth;

		// Token: 0x04037884 RID: 227460
		[Token(Token = "0x4037884")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04037885 RID: 227461
		[Token(Token = "0x4037885")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04037886 RID: 227462
		[Token(Token = "0x4037886")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _unlockProgressContent;

		// Token: 0x04037887 RID: 227463
		[Token(Token = "0x4037887")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelBtn;

		// Token: 0x04037888 RID: 227464
		[Token(Token = "0x4037888")]
		[FieldOffset(Offset = "0x50")]
		private ArchiveChatDetailItemView.Adapter m_adapter;

		// Token: 0x04037889 RID: 227465
		[Token(Token = "0x4037889")]
		[FieldOffset(Offset = "0x58")]
		private int m_chatSum;

		// Token: 0x0403788A RID: 227466
		[Token(Token = "0x403788A")]
		[FieldOffset(Offset = "0x5C")]
		private int m_chatUnlockNum;

		// Token: 0x0403788B RID: 227467
		[Token(Token = "0x403788B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInit;

		// Token: 0x0403788C RID: 227468
		[Token(Token = "0x403788C")]
		[FieldOffset(Offset = "0x64")]
		private Color m_teamColor;

		// Token: 0x0403788D RID: 227469
		[Token(Token = "0x403788D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403788E RID: 227470
		[Token(Token = "0x403788E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403788F RID: 227471
		[Token(Token = "0x403788F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B3F RID: 27455
		[Token(Token = "0x2006B3F")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060273F2 RID: 160754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60273F2")]
			[Address(RVA = "0x2262570", Offset = "0x2261170", VA = "0x182262570")]
			public Adapter(ArchiveChatDetailItemView closure)
			{
			}

			// Token: 0x17005CBF RID: 23743
			// (get) Token: 0x060273F3 RID: 160755 RVA: 0x000CDCE0 File Offset: 0x000CBEE0
			[Token(Token = "0x17005CBF")]
			public override int count
			{
				[Token(Token = "0x60273F3")]
				[Address(RVA = "0x2262670", Offset = "0x2261270", VA = "0x182262670", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060273F4 RID: 160756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60273F4")]
			[Address(RVA = "0x2261DA0", Offset = "0x22609A0", VA = "0x182261DA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037890 RID: 227472
			[Token(Token = "0x4037890")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveChatDetailItemView m_closure;

			// Token: 0x04037891 RID: 227473
			[Token(Token = "0x4037891")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037892 RID: 227474
			[Token(Token = "0x4037892")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037893 RID: 227475
			[Token(Token = "0x4037893")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
