using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E28 RID: 20008
	[Token(Token = "0x2004E28")]
	public class FireworkPlateFilledListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DE3F RID: 122431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE3F")]
		[Address(RVA = "0x176B4B0", Offset = "0x176A0B0", VA = "0x18176B4B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DE40 RID: 122432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE40")]
		[Address(RVA = "0x176B090", Offset = "0x1769C90", VA = "0x18176B090")]
		public void Render(FireworkPlateGroupModel groupModel, FireworkPlateGroupViewStyle style)
		{
		}

		// Token: 0x0601DE41 RID: 122433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE41")]
		[Address(RVA = "0x176AFD0", Offset = "0x1769BD0", VA = "0x18176AFD0")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0601DE42 RID: 122434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE42")]
		[Address(RVA = "0x176AF30", Offset = "0x1769B30", VA = "0x18176AF30")]
		public void OnBtnClearAllClicked()
		{
		}

		// Token: 0x0601DE43 RID: 122435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE43")]
		[Address(RVA = "0x176B680", Offset = "0x176A280", VA = "0x18176B680")]
		public FireworkPlateFilledListView()
		{
		}

		// Token: 0x04027A43 RID: 162371
		[Token(Token = "0x4027A43")]
		private const string FILLED_NUM_FORMAT = "{0}/{1}";

		// Token: 0x04027A44 RID: 162372
		[Token(Token = "0x4027A44")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _filledPlateList;

		// Token: 0x04027A45 RID: 162373
		[Token(Token = "0x4027A45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _clearAllShowAnim;

		// Token: 0x04027A46 RID: 162374
		[Token(Token = "0x4027A46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textFilledNum;

		// Token: 0x04027A47 RID: 162375
		[Token(Token = "0x4027A47")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _tutorialGo;

		// Token: 0x04027A48 RID: 162376
		[Token(Token = "0x4027A48")]
		[FieldOffset(Offset = "0x40")]
		private FireworkPlateFilledListView.Adapter m_adapter;

		// Token: 0x04027A49 RID: 162377
		[Token(Token = "0x4027A49")]
		[FieldOffset(Offset = "0x48")]
		private FireworkPlateGroupViewStyle m_cachedStyle;

		// Token: 0x04027A4A RID: 162378
		[Token(Token = "0x4027A4A")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x04027A4B RID: 162379
		[Token(Token = "0x4027A4B")]
		[FieldOffset(Offset = "0x58")]
		private UISwitchTween m_clearAllShowTween;

		// Token: 0x04027A4C RID: 162380
		[Token(Token = "0x4027A4C")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027A4D RID: 162381
		[Token(Token = "0x4027A4D")]
		[FieldOffset(Offset = "0x70")]
		private FireworkPlateGroupModel m_cachedGroupModel;

		// Token: 0x04027A4E RID: 162382
		[Token(Token = "0x4027A4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027A4F RID: 162383
		[Token(Token = "0x4027A4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027A50 RID: 162384
		[Token(Token = "0x4027A50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x04027A51 RID: 162385
		[Token(Token = "0x4027A51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnClearAllClicked;

		// Token: 0x04027A52 RID: 162386
		[Token(Token = "0x4027A52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E29 RID: 20009
		[Token(Token = "0x2004E29")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601DE44 RID: 122436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE44")]
			[Address(RVA = "0x1768B00", Offset = "0x1767700", VA = "0x181768B00")]
			public Adapter(FireworkPlateFilledListView closure)
			{
			}

			// Token: 0x17004627 RID: 17959
			// (get) Token: 0x0601DE45 RID: 122437 RVA: 0x000ACA70 File Offset: 0x000AAC70
			[Token(Token = "0x17004627")]
			public override int count
			{
				[Token(Token = "0x601DE45")]
				[Address(RVA = "0x1768DA0", Offset = "0x17679A0", VA = "0x181768DA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601DE46 RID: 122438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DE46")]
			[Address(RVA = "0x1768750", Offset = "0x1767350", VA = "0x181768750", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04027A53 RID: 162387
			[Token(Token = "0x4027A53")]
			[FieldOffset(Offset = "0x20")]
			private FireworkPlateFilledListView m_closure;

			// Token: 0x04027A54 RID: 162388
			[Token(Token = "0x4027A54")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027A55 RID: 162389
			[Token(Token = "0x4027A55")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027A56 RID: 162390
			[Token(Token = "0x4027A56")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
