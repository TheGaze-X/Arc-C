using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006904 RID: 26884
	[Token(Token = "0x2006904")]
	public class StageZoneDiffSelectHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026819 RID: 157721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026819")]
		[Address(RVA = "0x21A3E40", Offset = "0x21A2A40", VA = "0x1821A3E40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602681A RID: 157722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602681A")]
		[Address(RVA = "0x21A38D0", Offset = "0x21A24D0", VA = "0x1821A38D0")]
		public void Render(ZoneViewModel zoneViewModel)
		{
		}

		// Token: 0x0602681B RID: 157723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602681B")]
		[Address(RVA = "0x21A36F0", Offset = "0x21A22F0", VA = "0x1821A36F0")]
		public void OnStateChange(bool isHide)
		{
		}

		// Token: 0x0602681C RID: 157724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602681C")]
		[Address(RVA = "0x21A3680", Offset = "0x21A2280", VA = "0x1821A3680")]
		public void OnOpenDetailClick()
		{
		}

		// Token: 0x0602681D RID: 157725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602681D")]
		[Address(RVA = "0x21A3610", Offset = "0x21A2210", VA = "0x1821A3610")]
		public void OnAchieveRewardZoneAction()
		{
		}

		// Token: 0x0602681E RID: 157726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602681E")]
		[Address(RVA = "0x21A3F70", Offset = "0x21A2B70", VA = "0x1821A3F70")]
		public StageZoneDiffSelectHolder()
		{
		}

		// Token: 0x04036446 RID: 222278
		[Token(Token = "0x4036446")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageZoneDiffSelectObj _selectObj;

		// Token: 0x04036447 RID: 222279
		[Token(Token = "0x4036447")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _transList;

		// Token: 0x04036448 RID: 222280
		[Token(Token = "0x4036448")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x04036449 RID: 222281
		[Token(Token = "0x4036449")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403644A RID: 222282
		[Token(Token = "0x403644A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _addedZoneRewardBtn;

		// Token: 0x0403644B RID: 222283
		[Token(Token = "0x403644B")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public UnityEvent onAchieveRewardZoneAction;

		// Token: 0x0403644C RID: 222284
		[Token(Token = "0x403644C")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public UIDiffGroupEvent selectDiffAction;

		// Token: 0x0403644D RID: 222285
		[Token(Token = "0x403644D")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public UnityEvent onOpenDetailClick;

		// Token: 0x0403644E RID: 222286
		[Token(Token = "0x403644E")]
		private const string PARAM_ANIM = "diff_hide_anim";

		// Token: 0x0403644F RID: 222287
		[Token(Token = "0x403644F")]
		[FieldOffset(Offset = "0x58")]
		private float m_isHideState;

		// Token: 0x04036450 RID: 222288
		[Token(Token = "0x4036450")]
		[FieldOffset(Offset = "0x60")]
		private List<StageZoneDiffSelectObj> m_diffObjList;

		// Token: 0x04036451 RID: 222289
		[Token(Token = "0x4036451")]
		[FieldOffset(Offset = "0x68")]
		private StageZoneDiffSelectHolder.Adapter m_adapter;

		// Token: 0x04036452 RID: 222290
		[Token(Token = "0x4036452")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x04036453 RID: 222291
		[Token(Token = "0x4036453")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_cacheTween;

		// Token: 0x04036454 RID: 222292
		[Token(Token = "0x4036454")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036455 RID: 222293
		[Token(Token = "0x4036455")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036456 RID: 222294
		[Token(Token = "0x4036456")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateChange;

		// Token: 0x04036457 RID: 222295
		[Token(Token = "0x4036457")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnOpenDetailClick;

		// Token: 0x04036458 RID: 222296
		[Token(Token = "0x4036458")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAchieveRewardZoneAction;

		// Token: 0x04036459 RID: 222297
		[Token(Token = "0x4036459")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006905 RID: 26885
		[Token(Token = "0x2006905")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005AEB RID: 23275
			// (get) Token: 0x06026821 RID: 157729 RVA: 0x000CB610 File Offset: 0x000C9810
			[Token(Token = "0x17005AEB")]
			public override int count
			{
				[Token(Token = "0x6026821")]
				[Address(RVA = "0x21910F0", Offset = "0x218FCF0", VA = "0x1821910F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026822 RID: 157730 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026822")]
			[Address(RVA = "0x21907A0", Offset = "0x218F3A0", VA = "0x1821907A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026823 RID: 157731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026823")]
			[Address(RVA = "0x2190F10", Offset = "0x218FB10", VA = "0x182190F10")]
			public Adapter()
			{
			}

			// Token: 0x0403645A RID: 222298
			[Token(Token = "0x403645A")]
			[FieldOffset(Offset = "0x20")]
			public UIDiffGroupEvent selectDiffAction;

			// Token: 0x0403645B RID: 222299
			[Token(Token = "0x403645B")]
			[FieldOffset(Offset = "0x28")]
			public StageDiffGroup currentDiff;

			// Token: 0x0403645C RID: 222300
			[Token(Token = "0x403645C")]
			[FieldOffset(Offset = "0x30")]
			public List<ZoneViewModel.DiffInfo> diffInfoList;

			// Token: 0x0403645D RID: 222301
			[Token(Token = "0x403645D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403645E RID: 222302
			[Token(Token = "0x403645E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403645F RID: 222303
			[Token(Token = "0x403645F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
