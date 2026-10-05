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
	// Token: 0x02003954 RID: 14676
	[Token(Token = "0x2003954")]
	public abstract class LocatableRecycleLayoutHelper : IUIIntegerLocatable, IUILocatable, IHotfixable
	{
		// Token: 0x0601730C RID: 94988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601730C")]
		[Address(RVA = "0xF88F30", Offset = "0xF87B30", VA = "0x180F88F30")]
		public void Initialize(UIRecycleLayoutGroup.IViewHandler viewHandler, LocatableRecycleLayoutHelper.LocateParam locateParam)
		{
		}

		// Token: 0x0601730D RID: 94989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601730D")]
		[Address(RVA = "0xF88CC0", Offset = "0xF878C0", VA = "0x180F88CC0")]
		public void Dispose()
		{
		}

		// Token: 0x0601730E RID: 94990 RVA: 0x000953A0 File Offset: 0x000935A0
		[Token(Token = "0x601730E")]
		[Address(RVA = "0xF89140", Offset = "0xF87D40", VA = "0x180F89140", Slot = "4")]
		public bool IsLocatable(int identity)
		{
			return default(bool);
		}

		// Token: 0x0601730F RID: 94991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601730F")]
		[Address(RVA = "0xF891E0", Offset = "0xF87DE0", VA = "0x180F891E0", Slot = "5")]
		public void LocateTo(int identity, bool immediate = false, [Optional] Action onComplete)
		{
		}

		// Token: 0x06017310 RID: 94992
		[Token(Token = "0x6017310")]
		public abstract void OnLocatingStateChange(bool locating);

		// Token: 0x06017311 RID: 94993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017311")]
		[Address(RVA = "0xF88E20", Offset = "0xF87A20", VA = "0x180F88E20", Slot = "13")]
		public virtual object GetLocationMeta(int identity)
		{
			return null;
		}

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x06017312 RID: 94994 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06017313 RID: 94995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400007F")]
		public event Action metaChange
		{
			[Token(Token = "0x6017312")]
			[Address(RVA = "0xF8AAE0", Offset = "0xF896E0", VA = "0x180F8AAE0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6017313")]
			[Address(RVA = "0xF8ACC0", Offset = "0xF898C0", VA = "0x180F8ACC0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000080 RID: 128
		// (add) Token: 0x06017314 RID: 94996 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06017315 RID: 94997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000080")]
		public event Action<int> locatedChange
		{
			[Token(Token = "0x6017314")]
			[Address(RVA = "0xF8A9E0", Offset = "0xF895E0", VA = "0x180F8A9E0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6017315")]
			[Address(RVA = "0xF8ABC0", Offset = "0xF897C0", VA = "0x180F8ABC0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06017316 RID: 94998
		[Token(Token = "0x6017316")]
		protected abstract Vector2 GetItemPivot(int index);

		// Token: 0x06017317 RID: 94999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017317")]
		[Address(RVA = "0xF8A060", Offset = "0xF88C60", VA = "0x180F8A060")]
		private void _OnPostLayout()
		{
		}

		// Token: 0x06017318 RID: 95000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017318")]
		[Address(RVA = "0xF8A400", Offset = "0xF89000", VA = "0x180F8A400")]
		private void _OnValueChanged(Vector2 _)
		{
		}

		// Token: 0x06017319 RID: 95001 RVA: 0x000953B8 File Offset: 0x000935B8
		[Token(Token = "0x6017319")]
		[Address(RVA = "0xF89B80", Offset = "0xF88780", VA = "0x180F89B80")]
		private float _GetLocateTargetPosition(LocatableRecycleLayoutHelper.ItemMeta targetMeta)
		{
			return 0f;
		}

		// Token: 0x0601731A RID: 95002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601731A")]
		[Address(RVA = "0xF897A0", Offset = "0xF883A0", VA = "0x180F897A0")]
		private Tween _GenerateLocatingTween(float targetPosition, float currentPosition)
		{
			return null;
		}

		// Token: 0x0601731B RID: 95003 RVA: 0x000953D0 File Offset: 0x000935D0
		[Token(Token = "0x601731B")]
		[Address(RVA = "0xF895F0", Offset = "0xF881F0", VA = "0x180F895F0")]
		private float _FixStartScrollPosition(float targetPosition, float currentPosition)
		{
			return 0f;
		}

		// Token: 0x0601731C RID: 95004 RVA: 0x000953E8 File Offset: 0x000935E8
		[Token(Token = "0x601731C")]
		[Address(RVA = "0xF89FD0", Offset = "0xF88BD0", VA = "0x180F89FD0")]
		private Vector2 _GetPosition()
		{
			return default(Vector2);
		}

		// Token: 0x0601731D RID: 95005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601731D")]
		[Address(RVA = "0xF8A870", Offset = "0xF89470", VA = "0x180F8A870")]
		private void _SetPosition(Vector2 position)
		{
		}

		// Token: 0x0601731E RID: 95006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601731E")]
		[Address(RVA = "0xF8A920", Offset = "0xF89520", VA = "0x180F8A920")]
		protected LocatableRecycleLayoutHelper()
		{
		}

		// Token: 0x0401BFC4 RID: 114628
		[Token(Token = "0x401BFC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UIRecycleLayoutGroup.IViewHandler m_handler;

		// Token: 0x0401BFC5 RID: 114629
		[Token(Token = "0x401BFC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UIWrappedScrollRect.Wrapper m_wrapper;

		// Token: 0x0401BFC6 RID: 114630
		[Token(Token = "0x401BFC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform m_locateRect;

		// Token: 0x0401BFC7 RID: 114631
		[Token(Token = "0x401BFC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Ease m_locateEase;

		// Token: 0x0401BFC8 RID: 114632
		[Token(Token = "0x401BFC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_locateDuration;

		// Token: 0x0401BFC9 RID: 114633
		[Token(Token = "0x401BFC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_locateMaxDistance;

		// Token: 0x0401BFCA RID: 114634
		[Token(Token = "0x401BFCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<LocatableRecycleLayoutHelper.ItemMeta> m_itemMetas;

		// Token: 0x0401BFCB RID: 114635
		[Token(Token = "0x401BFCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 m_contentSize;

		// Token: 0x0401BFCC RID: 114636
		[Token(Token = "0x401BFCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_located;

		// Token: 0x0401BFCD RID: 114637
		[Token(Token = "0x401BFCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Tween m_locatingTween;

		// Token: 0x0401BFD0 RID: 114640
		[Token(Token = "0x401BFD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Initialize;

		// Token: 0x0401BFD1 RID: 114641
		[Token(Token = "0x401BFD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0401BFD2 RID: 114642
		[Token(Token = "0x401BFD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsLocatable;

		// Token: 0x0401BFD3 RID: 114643
		[Token(Token = "0x401BFD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LocateTo;

		// Token: 0x0401BFD4 RID: 114644
		[Token(Token = "0x401BFD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetLocationMeta;

		// Token: 0x0401BFD5 RID: 114645
		[Token(Token = "0x401BFD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_add_metaChange;

		// Token: 0x0401BFD6 RID: 114646
		[Token(Token = "0x401BFD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_remove_metaChange;

		// Token: 0x0401BFD7 RID: 114647
		[Token(Token = "0x401BFD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_add_locatedChange;

		// Token: 0x0401BFD8 RID: 114648
		[Token(Token = "0x401BFD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_remove_locatedChange;

		// Token: 0x0401BFD9 RID: 114649
		[Token(Token = "0x401BFD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnPostLayout;

		// Token: 0x0401BFDA RID: 114650
		[Token(Token = "0x401BFDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnValueChanged;

		// Token: 0x0401BFDB RID: 114651
		[Token(Token = "0x401BFDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetLocateTargetPosition;

		// Token: 0x0401BFDC RID: 114652
		[Token(Token = "0x401BFDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenerateLocatingTween;

		// Token: 0x0401BFDD RID: 114653
		[Token(Token = "0x401BFDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FixStartScrollPosition;

		// Token: 0x0401BFDE RID: 114654
		[Token(Token = "0x401BFDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x0401BFDF RID: 114655
		[Token(Token = "0x401BFDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x0401BFE0 RID: 114656
		[Token(Token = "0x401BFE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003955 RID: 14677
		[Token(Token = "0x2003955")]
		public struct ItemMeta
		{
			// Token: 0x0401BFE1 RID: 114657
			[Token(Token = "0x401BFE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bounds bounds;

			// Token: 0x0401BFE2 RID: 114658
			[Token(Token = "0x401BFE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector2 pivot;

			// Token: 0x0401BFE3 RID: 114659
			[Token(Token = "0x401BFE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float distance;
		}

		// Token: 0x02003956 RID: 14678
		[Token(Token = "0x2003956")]
		public struct LocateParam
		{
			// Token: 0x0601731F RID: 95007 RVA: 0x00095400 File Offset: 0x00093600
			[Token(Token = "0x601731F")]
			[Address(RVA = "0xF8ADA0", Offset = "0xF899A0", VA = "0x180F8ADA0")]
			public static LocatableRecycleLayoutHelper.LocateParam GenerateDefault(UIWrappedScrollRect.Wrapper scrollRectWrapper, RectTransform locateRect)
			{
				return default(LocatableRecycleLayoutHelper.LocateParam);
			}

			// Token: 0x0401BFE4 RID: 114660
			[Token(Token = "0x401BFE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UIWrappedScrollRect.Wrapper scrollRectWrapper;

			// Token: 0x0401BFE5 RID: 114661
			[Token(Token = "0x401BFE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public RectTransform locateRect;

			// Token: 0x0401BFE6 RID: 114662
			[Token(Token = "0x401BFE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Ease locateEase;

			// Token: 0x0401BFE7 RID: 114663
			[Token(Token = "0x401BFE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float locateDuration;

			// Token: 0x0401BFE8 RID: 114664
			[Token(Token = "0x401BFE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int locateMaxDistance;
		}
	}
}
