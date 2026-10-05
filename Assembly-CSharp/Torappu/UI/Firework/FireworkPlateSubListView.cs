using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E3D RID: 20029
	[Token(Token = "0x2004E3D")]
	public class FireworkPlateSubListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DEA5 RID: 122533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEA5")]
		[Address(RVA = "0x1771330", Offset = "0x176FF30", VA = "0x181771330")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DEA6 RID: 122534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEA6")]
		[Address(RVA = "0x17710F0", Offset = "0x176FCF0", VA = "0x1817710F0")]
		public void Render(FireworkPlateGroupModel groupModel, FireworkPlateGroupViewStyle style)
		{
		}

		// Token: 0x0601DEA7 RID: 122535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEA7")]
		[Address(RVA = "0x1771610", Offset = "0x1770210", VA = "0x181771610")]
		private void _TutorialOnlyRaiseAVGSignal()
		{
		}

		// Token: 0x0601DEA8 RID: 122536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEA8")]
		[Address(RVA = "0x17716B0", Offset = "0x17702B0", VA = "0x1817716B0")]
		public FireworkPlateSubListView()
		{
		}

		// Token: 0x04027B34 RID: 162612
		[Token(Token = "0x4027B34")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x04027B35 RID: 162613
		[Token(Token = "0x4027B35")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x04027B36 RID: 162614
		[Token(Token = "0x4027B36")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _plateList;

		// Token: 0x04027B37 RID: 162615
		[Token(Token = "0x4027B37")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x04027B38 RID: 162616
		[Token(Token = "0x4027B38")]
		[FieldOffset(Offset = "0x48")]
		private UISwitchTween m_showTween;

		// Token: 0x04027B39 RID: 162617
		[Token(Token = "0x4027B39")]
		[FieldOffset(Offset = "0x50")]
		private UISwitchTween m_lengthSwitchTween;

		// Token: 0x04027B3A RID: 162618
		[Token(Token = "0x4027B3A")]
		[FieldOffset(Offset = "0x58")]
		private FireworkPlateGroupModel m_cachedGroupModel;

		// Token: 0x04027B3B RID: 162619
		[Token(Token = "0x4027B3B")]
		[FieldOffset(Offset = "0x60")]
		private FireworkPlateGroupViewStyle m_cachedStyle;

		// Token: 0x04027B3C RID: 162620
		[Token(Token = "0x4027B3C")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedPlateGroupId;

		// Token: 0x04027B3D RID: 162621
		[Token(Token = "0x4027B3D")]
		[FieldOffset(Offset = "0x70")]
		private FireworkPlateSubListView.Adapter m_adapter;

		// Token: 0x04027B3E RID: 162622
		[Token(Token = "0x4027B3E")]
		[FieldOffset(Offset = "0x78")]
		private FireworkPlateSubListView.PreviewingStatus m_cachedPreviewingStatus;

		// Token: 0x04027B3F RID: 162623
		[Token(Token = "0x4027B3F")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_isNewGroup;

		// Token: 0x04027B40 RID: 162624
		[Token(Token = "0x4027B40")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027B41 RID: 162625
		[Token(Token = "0x4027B41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027B42 RID: 162626
		[Token(Token = "0x4027B42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027B43 RID: 162627
		[Token(Token = "0x4027B43")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TutorialOnlyRaiseAVGSignal;

		// Token: 0x04027B44 RID: 162628
		[Token(Token = "0x4027B44")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E3E RID: 20030
		[Token(Token = "0x2004E3E")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601DEA9 RID: 122537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEA9")]
			[Address(RVA = "0x1768C10", Offset = "0x1767810", VA = "0x181768C10")]
			public Adapter(FireworkPlateSubListView closure)
			{
			}

			// Token: 0x1700463A RID: 17978
			// (get) Token: 0x0601DEAA RID: 122538 RVA: 0x000ACDA0 File Offset: 0x000AAFA0
			[Token(Token = "0x1700463A")]
			public override int count
			{
				[Token(Token = "0x601DEAA")]
				[Address(RVA = "0x1768C90", Offset = "0x1767890", VA = "0x181768C90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601DEAB RID: 122539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DEAB")]
			[Address(RVA = "0x1768540", Offset = "0x1767140", VA = "0x181768540", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601DEAC RID: 122540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEAC")]
			[Address(RVA = "0x1768140", Offset = "0x1766D40", VA = "0x181768140")]
			public void RegisterTutorialGo()
			{
			}

			// Token: 0x04027B45 RID: 162629
			[Token(Token = "0x4027B45")]
			private const int TUTORIAL_ITEM_INDEX = 0;

			// Token: 0x04027B46 RID: 162630
			[Token(Token = "0x4027B46")]
			[FieldOffset(Offset = "0x20")]
			private FireworkPlateSubListView m_closure;

			// Token: 0x04027B47 RID: 162631
			[Token(Token = "0x4027B47")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027B48 RID: 162632
			[Token(Token = "0x4027B48")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027B49 RID: 162633
			[Token(Token = "0x4027B49")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04027B4A RID: 162634
			[Token(Token = "0x4027B4A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RegisterTutorialGo;
		}

		// Token: 0x02004E3F RID: 20031
		[Token(Token = "0x2004E3F")]
		private enum PreviewingStatus
		{
			// Token: 0x04027B4C RID: 162636
			[Token(Token = "0x4027B4C")]
			NONE,
			// Token: 0x04027B4D RID: 162637
			[Token(Token = "0x4027B4D")]
			NOT_PREVIEWING,
			// Token: 0x04027B4E RID: 162638
			[Token(Token = "0x4027B4E")]
			PREVIEWING
		}
	}
}
