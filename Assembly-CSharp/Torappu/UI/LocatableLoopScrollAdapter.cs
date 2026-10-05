using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003951 RID: 14673
	[Token(Token = "0x2003951")]
	public abstract class LocatableLoopScrollAdapter<ViewHolder, DataType> : LoopScrollAdapter<ViewHolder, DataType>, IUIIntegerLocatable, IUILocatable, IHotfixable where ViewHolder : new()
	{
		// Token: 0x060172F8 RID: 94968 RVA: 0x00095328 File Offset: 0x00093528
		[Token(Token = "0x60172F8")]
		public bool IsLocatable(int identity)
		{
			return default(bool);
		}

		// Token: 0x060172F9 RID: 94969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172F9")]
		public void LocateTo(int identity, bool immediate = false, [Optional] Action onComplete)
		{
		}

		// Token: 0x060172FA RID: 94970
		[Token(Token = "0x60172FA")]
		public abstract void OnLocatingStateChange(bool locating);

		// Token: 0x060172FB RID: 94971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60172FB")]
		public virtual object GetLocationMeta(int identity)
		{
			return null;
		}

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x060172FC RID: 94972 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060172FD RID: 94973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400007D")]
		public event Action metaChange
		{
			[Token(Token = "0x60172FC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60172FD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x060172FE RID: 94974 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060172FF RID: 94975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400007E")]
		public event Action<int> locatedChange
		{
			[Token(Token = "0x60172FE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60172FF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06017300 RID: 94976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017300")]
		protected override void OnCellsUpdate()
		{
		}

		// Token: 0x06017301 RID: 94977
		[Token(Token = "0x6017301")]
		protected abstract Vector2 GetItemPivot();

		// Token: 0x06017302 RID: 94978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017302")]
		public override void OnContentPositionChange()
		{
		}

		// Token: 0x06017303 RID: 94979 RVA: 0x00095340 File Offset: 0x00093540
		[Token(Token = "0x6017303")]
		private float _GetLocateTargetPosition(LocatableLoopScrollAdapter<ViewHolder, DataType>.ItemMeta targetMeta)
		{
			return 0f;
		}

		// Token: 0x06017304 RID: 94980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017304")]
		private Tween _GenerateLocatingTween(float targetPosition, float currentPosition)
		{
			return null;
		}

		// Token: 0x06017305 RID: 94981 RVA: 0x00095358 File Offset: 0x00093558
		[Token(Token = "0x6017305")]
		private float _FixStartScrollPosition(float targetPosition, float currentPosition)
		{
			return 0f;
		}

		// Token: 0x06017306 RID: 94982 RVA: 0x00095370 File Offset: 0x00093570
		[Token(Token = "0x6017306")]
		private Vector2 _GetPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06017307 RID: 94983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017307")]
		private void _SetPosition(Vector2 position)
		{
		}

		// Token: 0x06017308 RID: 94984 RVA: 0x00095388 File Offset: 0x00093588
		[Token(Token = "0x6017308")]
		private Bounds _GetFocusFixedBoundsInContent()
		{
			return default(Bounds);
		}

		// Token: 0x06017309 RID: 94985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017309")]
		protected LocatableLoopScrollAdapter()
		{
		}

		// Token: 0x0401BFA7 RID: 114599
		[Token(Token = "0x401BFA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Tooltip("定位标，定位逻辑依赖其pivot位置")]
		private RectTransform _locateRect;

		// Token: 0x0401BFA8 RID: 114600
		[Token(Token = "0x401BFA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Ease _locateEase;

		// Token: 0x0401BFA9 RID: 114601
		[Token(Token = "0x401BFA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _locateDuration;

		// Token: 0x0401BFAA RID: 114602
		[Token(Token = "0x401BFAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Tooltip("定位动画最大滚动距离，小于等于0时始终执行完整的滚动，距离较远且页面复杂时可能导致卡顿")]
		private int _locateMaxDistance;

		// Token: 0x0401BFAB RID: 114603
		[Token(Token = "0x401BFAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<LocatableLoopScrollAdapter<ViewHolder, DataType>.ItemMeta> m_itemMetas;

		// Token: 0x0401BFAC RID: 114604
		[Token(Token = "0x401BFAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector2 m_contentSize;

		// Token: 0x0401BFAD RID: 114605
		[Token(Token = "0x401BFAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_located;

		// Token: 0x0401BFAE RID: 114606
		[Token(Token = "0x401BFAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Tween m_locatingTween;

		// Token: 0x0401BFB1 RID: 114609
		[Token(Token = "0x401BFB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsLocatable;

		// Token: 0x0401BFB2 RID: 114610
		[Token(Token = "0x401BFB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LocateTo;

		// Token: 0x0401BFB3 RID: 114611
		[Token(Token = "0x401BFB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetLocationMeta;

		// Token: 0x0401BFB4 RID: 114612
		[Token(Token = "0x401BFB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_metaChange;

		// Token: 0x0401BFB5 RID: 114613
		[Token(Token = "0x401BFB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_remove_metaChange;

		// Token: 0x0401BFB6 RID: 114614
		[Token(Token = "0x401BFB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_locatedChange;

		// Token: 0x0401BFB7 RID: 114615
		[Token(Token = "0x401BFB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_remove_locatedChange;

		// Token: 0x0401BFB8 RID: 114616
		[Token(Token = "0x401BFB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCellsUpdate;

		// Token: 0x0401BFB9 RID: 114617
		[Token(Token = "0x401BFB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnContentPositionChange;

		// Token: 0x0401BFBA RID: 114618
		[Token(Token = "0x401BFBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetLocateTargetPosition;

		// Token: 0x0401BFBB RID: 114619
		[Token(Token = "0x401BFBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GenerateLocatingTween;

		// Token: 0x0401BFBC RID: 114620
		[Token(Token = "0x401BFBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__FixStartScrollPosition;

		// Token: 0x0401BFBD RID: 114621
		[Token(Token = "0x401BFBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x0401BFBE RID: 114622
		[Token(Token = "0x401BFBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x0401BFBF RID: 114623
		[Token(Token = "0x401BFBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetFocusFixedBoundsInContent;

		// Token: 0x0401BFC0 RID: 114624
		[Token(Token = "0x401BFC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003952 RID: 14674
		[Token(Token = "0x2003952")]
		public struct ItemMeta
		{
			// Token: 0x0401BFC1 RID: 114625
			[Token(Token = "0x401BFC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bounds bounds;

			// Token: 0x0401BFC2 RID: 114626
			[Token(Token = "0x401BFC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float distance;
		}
	}
}
