using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E30 RID: 20016
	[Token(Token = "0x2004E30")]
	public class FireworkPlateListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DE74 RID: 122484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE74")]
		[Address(RVA = "0x176ED10", Offset = "0x176D910", VA = "0x18176ED10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DE75 RID: 122485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE75")]
		[Address(RVA = "0x176E9F0", Offset = "0x176D5F0", VA = "0x18176E9F0")]
		public void Render(FireworkPlateGroupModel groupModel, FireworkPlateGroupViewStyle style)
		{
		}

		// Token: 0x0601DE76 RID: 122486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE76")]
		[Address(RVA = "0x176E950", Offset = "0x176D550", VA = "0x18176E950")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0601DE77 RID: 122487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE77")]
		[Address(RVA = "0x176EE40", Offset = "0x176DA40", VA = "0x18176EE40")]
		public FireworkPlateListView()
		{
		}

		// Token: 0x04027AC6 RID: 162502
		[Token(Token = "0x4027AC6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _plateListLeft;

		// Token: 0x04027AC7 RID: 162503
		[Token(Token = "0x4027AC7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _plateListRight;

		// Token: 0x04027AC8 RID: 162504
		[Token(Token = "0x4027AC8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlPlateLocked;

		// Token: 0x04027AC9 RID: 162505
		[Token(Token = "0x4027AC9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FireworkPlateSubListView _subListView;

		// Token: 0x04027ACA RID: 162506
		[Token(Token = "0x4027ACA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _scrollHandler;

		// Token: 0x04027ACB RID: 162507
		[Token(Token = "0x4027ACB")]
		[FieldOffset(Offset = "0x40")]
		private FireworkPlateGroupModel m_cachedGroupModel;

		// Token: 0x04027ACC RID: 162508
		[Token(Token = "0x4027ACC")]
		[FieldOffset(Offset = "0x48")]
		private FireworkPlateGroupViewStyle m_cachedStyle;

		// Token: 0x04027ACD RID: 162509
		[Token(Token = "0x4027ACD")]
		[FieldOffset(Offset = "0x50")]
		private FireworkPlateListView.Adapter m_leftAdapter;

		// Token: 0x04027ACE RID: 162510
		[Token(Token = "0x4027ACE")]
		[FieldOffset(Offset = "0x58")]
		private FireworkPlateListView.Adapter m_rightAdapter;

		// Token: 0x04027ACF RID: 162511
		[Token(Token = "0x4027ACF")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x04027AD0 RID: 162512
		[Token(Token = "0x4027AD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027AD1 RID: 162513
		[Token(Token = "0x4027AD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027AD2 RID: 162514
		[Token(Token = "0x4027AD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x04027AD3 RID: 162515
		[Token(Token = "0x4027AD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E31 RID: 20017
		[Token(Token = "0x2004E31")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601DE78 RID: 122488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE78")]
			[Address(RVA = "0x1768B80", Offset = "0x1767780", VA = "0x181768B80")]
			public Adapter(FireworkPlateListView closure, bool isLeft)
			{
			}

			// Token: 0x17004636 RID: 17974
			// (get) Token: 0x0601DE79 RID: 122489 RVA: 0x000ACCB0 File Offset: 0x000AAEB0
			[Token(Token = "0x17004636")]
			public override int count
			{
				[Token(Token = "0x601DE79")]
				[Address(RVA = "0x1768E40", Offset = "0x1767A40", VA = "0x181768E40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601DE7A RID: 122490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DE7A")]
			[Address(RVA = "0x1768900", Offset = "0x1767500", VA = "0x181768900", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601DE7B RID: 122491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE7B")]
			[Address(RVA = "0x1768340", Offset = "0x1766F40", VA = "0x181768340")]
			public void RegisterTutorialGo()
			{
			}

			// Token: 0x04027AD4 RID: 162516
			[Token(Token = "0x4027AD4")]
			private const int TUTORIAL_ITEM_INDEX = 0;

			// Token: 0x04027AD5 RID: 162517
			[Token(Token = "0x4027AD5")]
			[FieldOffset(Offset = "0x20")]
			private FireworkPlateListView m_closure;

			// Token: 0x04027AD6 RID: 162518
			[Token(Token = "0x4027AD6")]
			[FieldOffset(Offset = "0x28")]
			private bool m_isLeft;

			// Token: 0x04027AD7 RID: 162519
			[Token(Token = "0x4027AD7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027AD8 RID: 162520
			[Token(Token = "0x4027AD8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027AD9 RID: 162521
			[Token(Token = "0x4027AD9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04027ADA RID: 162522
			[Token(Token = "0x4027ADA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RegisterTutorialGo;
		}
	}
}
