using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078AA RID: 30890
	[Token(Token = "0x20078AA")]
	public class Act1LockFinalItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006555 RID: 25941
		// (get) Token: 0x0602B508 RID: 177416 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B509 RID: 177417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006555")]
		public Action<int, bool> onExpandAction
		{
			[Token(Token = "0x602B508")]
			[Address(RVA = "0x27240A0", Offset = "0x2722CA0", VA = "0x1827240A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B509")]
			[Address(RVA = "0x27241E0", Offset = "0x2722DE0", VA = "0x1827241E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006556 RID: 25942
		// (get) Token: 0x0602B50A RID: 177418 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B50B RID: 177419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006556")]
		public Action<int> onCancelAction
		{
			[Token(Token = "0x602B50A")]
			[Address(RVA = "0x2724040", Offset = "0x2722C40", VA = "0x182724040")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B50B")]
			[Address(RVA = "0x2724160", Offset = "0x2722D60", VA = "0x182724160")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006557 RID: 25943
		// (get) Token: 0x0602B50C RID: 177420 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B50D RID: 177421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006557")]
		public Action<string> onJumpAction
		{
			[Token(Token = "0x602B50C")]
			[Address(RVA = "0x2724100", Offset = "0x2722D00", VA = "0x182724100")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B50D")]
			[Address(RVA = "0x2724260", Offset = "0x2722E60", VA = "0x182724260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006558 RID: 25944
		// (get) Token: 0x0602B50E RID: 177422 RVA: 0x000DB6A8 File Offset: 0x000D98A8
		[Token(Token = "0x17006558")]
		public float itemWidth
		{
			[Token(Token = "0x602B50E")]
			[Address(RVA = "0x2723FB0", Offset = "0x2722BB0", VA = "0x182723FB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0602B50F RID: 177423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B50F")]
		[Address(RVA = "0x27237B0", Offset = "0x27223B0", VA = "0x1827237B0")]
		public void Render(int position, InterlockSquadModel interlockModel, string finalStageId)
		{
		}

		// Token: 0x0602B510 RID: 177424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B510")]
		[Address(RVA = "0x2723520", Offset = "0x2722120", VA = "0x182723520")]
		public void PlayExpandAnim(Action<int, bool> callback)
		{
		}

		// Token: 0x0602B511 RID: 177425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B511")]
		[Address(RVA = "0x2723D70", Offset = "0x2722970", VA = "0x182723D70")]
		private void _CleanAnimTween()
		{
		}

		// Token: 0x0602B512 RID: 177426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B512")]
		[Address(RVA = "0x2723E10", Offset = "0x2722A10", VA = "0x182723E10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B513 RID: 177427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B513")]
		[Address(RVA = "0x2723370", Offset = "0x2721F70", VA = "0x182723370")]
		public void OnBtnExpand()
		{
		}

		// Token: 0x0602B514 RID: 177428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B514")]
		[Address(RVA = "0x2723430", Offset = "0x2722030", VA = "0x182723430")]
		public void OnBtnJump()
		{
		}

		// Token: 0x0602B515 RID: 177429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B515")]
		[Address(RVA = "0x2723260", Offset = "0x2721E60", VA = "0x182723260")]
		public void OnBtnCancel()
		{
		}

		// Token: 0x0602B516 RID: 177430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B516")]
		[Address(RVA = "0x2723F50", Offset = "0x2722B50", VA = "0x182723F50")]
		public Act1LockFinalItemView()
		{
		}

		// Token: 0x0403E9AC RID: 256428
		[Token(Token = "0x403E9AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _commonPartCanvasGroup;

		// Token: 0x0403E9AD RID: 256429
		[Token(Token = "0x403E9AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0403E9AE RID: 256430
		[Token(Token = "0x403E9AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _activePart;

		// Token: 0x0403E9AF RID: 256431
		[Token(Token = "0x403E9AF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _activeExpandPart;

		// Token: 0x0403E9B0 RID: 256432
		[Token(Token = "0x403E9B0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _inactivePart;

		// Token: 0x0403E9B1 RID: 256433
		[Token(Token = "0x403E9B1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _charList1;

		// Token: 0x0403E9B2 RID: 256434
		[Token(Token = "0x403E9B2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _charList2;

		// Token: 0x0403E9B3 RID: 256435
		[Token(Token = "0x403E9B3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animation;

		// Token: 0x0403E9B4 RID: 256436
		[Token(Token = "0x403E9B4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgRegion;

		// Token: 0x0403E9B5 RID: 256437
		[Token(Token = "0x403E9B5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite[] _regionSpriteList;

		// Token: 0x0403E9B6 RID: 256438
		[Token(Token = "0x403E9B6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgStatus;

		// Token: 0x0403E9B7 RID: 256439
		[Token(Token = "0x403E9B7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgEnemyIcon;

		// Token: 0x0403E9B8 RID: 256440
		[Token(Token = "0x403E9B8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Sprite[] _statusSpriteList;

		// Token: 0x0403E9B9 RID: 256441
		[Token(Token = "0x403E9B9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textCaption;

		// Token: 0x0403E9BD RID: 256445
		[Token(Token = "0x403E9BD")]
		[FieldOffset(Offset = "0xA8")]
		private InterlockSquadModel m_interlockModel;

		// Token: 0x0403E9BE RID: 256446
		[Token(Token = "0x403E9BE")]
		[FieldOffset(Offset = "0xB0")]
		private int m_position;

		// Token: 0x0403E9BF RID: 256447
		[Token(Token = "0x403E9BF")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_hasInited;

		// Token: 0x0403E9C0 RID: 256448
		[Token(Token = "0x403E9C0")]
		[FieldOffset(Offset = "0xB8")]
		private Act1LockFinalItemView.InterlockCharItemAdapter m_charListAdapter1;

		// Token: 0x0403E9C1 RID: 256449
		[Token(Token = "0x403E9C1")]
		[FieldOffset(Offset = "0xC0")]
		private Act1LockFinalItemView.InterlockCharItemAdapter m_charListAdapter2;

		// Token: 0x0403E9C2 RID: 256450
		[Token(Token = "0x403E9C2")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_expandTween;

		// Token: 0x0403E9C3 RID: 256451
		[Token(Token = "0x403E9C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onExpandAction;

		// Token: 0x0403E9C4 RID: 256452
		[Token(Token = "0x403E9C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onExpandAction;

		// Token: 0x0403E9C5 RID: 256453
		[Token(Token = "0x403E9C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCancelAction;

		// Token: 0x0403E9C6 RID: 256454
		[Token(Token = "0x403E9C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCancelAction;

		// Token: 0x0403E9C7 RID: 256455
		[Token(Token = "0x403E9C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onJumpAction;

		// Token: 0x0403E9C8 RID: 256456
		[Token(Token = "0x403E9C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onJumpAction;

		// Token: 0x0403E9C9 RID: 256457
		[Token(Token = "0x403E9C9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_itemWidth;

		// Token: 0x0403E9CA RID: 256458
		[Token(Token = "0x403E9CA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E9CB RID: 256459
		[Token(Token = "0x403E9CB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PlayExpandAnim;

		// Token: 0x0403E9CC RID: 256460
		[Token(Token = "0x403E9CC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CleanAnimTween;

		// Token: 0x0403E9CD RID: 256461
		[Token(Token = "0x403E9CD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E9CE RID: 256462
		[Token(Token = "0x403E9CE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnExpand;

		// Token: 0x0403E9CF RID: 256463
		[Token(Token = "0x403E9CF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnJump;

		// Token: 0x0403E9D0 RID: 256464
		[Token(Token = "0x403E9D0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBtnCancel;

		// Token: 0x0403E9D1 RID: 256465
		[Token(Token = "0x403E9D1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020078AB RID: 30891
		[Token(Token = "0x20078AB")]
		private class InterlockCharItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602B518 RID: 177432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B518")]
			[Address(RVA = "0x2733260", Offset = "0x2731E60", VA = "0x182733260")]
			public InterlockCharItemAdapter(Act1LockFinalItemView closure, bool isPart1)
			{
			}

			// Token: 0x17006559 RID: 25945
			// (get) Token: 0x0602B519 RID: 177433 RVA: 0x000DB6C0 File Offset: 0x000D98C0
			[Token(Token = "0x17006559")]
			public override int count
			{
				[Token(Token = "0x602B519")]
				[Address(RVA = "0x27332F0", Offset = "0x2731EF0", VA = "0x1827332F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B51A RID: 177434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B51A")]
			[Address(RVA = "0x2733080", Offset = "0x2731C80", VA = "0x182733080", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403E9D2 RID: 256466
			[Token(Token = "0x403E9D2")]
			[FieldOffset(Offset = "0x20")]
			private Act1LockFinalItemView m_closure;

			// Token: 0x0403E9D3 RID: 256467
			[Token(Token = "0x403E9D3")]
			[FieldOffset(Offset = "0x28")]
			private bool m_isPart1;

			// Token: 0x0403E9D4 RID: 256468
			[Token(Token = "0x403E9D4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E9D5 RID: 256469
			[Token(Token = "0x403E9D5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E9D6 RID: 256470
			[Token(Token = "0x403E9D6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
