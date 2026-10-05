using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040FD RID: 16637
	[Token(Token = "0x20040FD")]
	public class SandboxV2WorkbenchView : DataBinder<SandboxV2AdminMainWorkbenchPanelModelProperty>
	{
		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x06019BA3 RID: 105379 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019BA4 RID: 105380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D5B")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x6019BA3")]
			[Address(RVA = "0x129FB50", Offset = "0x129E750", VA = "0x18129FB50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019BA4")]
			[Address(RVA = "0x129FC70", Offset = "0x129E870", VA = "0x18129FC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x06019BA5 RID: 105381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019BA6 RID: 105382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D5C")]
		public Action setFilterCanMakeEvent
		{
			[Token(Token = "0x6019BA5")]
			[Address(RVA = "0x129FBB0", Offset = "0x129E7B0", VA = "0x18129FBB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019BA6")]
			[Address(RVA = "0x129FCF0", Offset = "0x129E8F0", VA = "0x18129FCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019BA7 RID: 105383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BA7")]
		[Address(RVA = "0x129E860", Offset = "0x129D460", VA = "0x18129E860")]
		public void OnSetFilterCanMakeEvent()
		{
		}

		// Token: 0x06019BA8 RID: 105384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BA8")]
		[Address(RVA = "0x129E970", Offset = "0x129D570", VA = "0x18129E970", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainWorkbenchPanelModelProperty property)
		{
		}

		// Token: 0x06019BA9 RID: 105385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BA9")]
		[Address(RVA = "0x129F0A0", Offset = "0x129DCA0", VA = "0x18129F0A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019BAA RID: 105386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BAA")]
		[Address(RVA = "0x129F5C0", Offset = "0x129E1C0", VA = "0x18129F5C0")]
		private void _SwitchContent()
		{
		}

		// Token: 0x06019BAB RID: 105387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019BAB")]
		[Address(RVA = "0x129F290", Offset = "0x129DE90", VA = "0x18129F290")]
		private Sequence _SequenceOfSwitchContent()
		{
			return null;
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x06019BAC RID: 105388 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019BAD RID: 105389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D5D")]
		public SandboxV2AdminMainState tutorialOnly_mainState
		{
			[Token(Token = "0x6019BAC")]
			[Address(RVA = "0x129FC10", Offset = "0x129E810", VA = "0x18129FC10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019BAD")]
			[Address(RVA = "0x129FD70", Offset = "0x129E970", VA = "0x18129FD70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019BAE RID: 105390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BAE")]
		[Address(RVA = "0x129F730", Offset = "0x129E330", VA = "0x18129F730")]
		private void _TutorialOnly_CheckSignalToRaise()
		{
		}

		// Token: 0x06019BAF RID: 105391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019BAF")]
		[Address(RVA = "0x129FA00", Offset = "0x129E600", VA = "0x18129FA00")]
		private IEnumerator _TutorialOnly_RaiseSignalWhenFinishTransiting(Action signalAction)
		{
			return null;
		}

		// Token: 0x06019BB0 RID: 105392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BB0")]
		[Address(RVA = "0x129F420", Offset = "0x129E020", VA = "0x18129F420")]
		private void _StopCoroutineIfNeed()
		{
		}

		// Token: 0x06019BB1 RID: 105393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BB1")]
		[Address(RVA = "0x129E800", Offset = "0x129D400", VA = "0x18129E800")]
		private void OnDestroy()
		{
		}

		// Token: 0x06019BB2 RID: 105394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BB2")]
		[Address(RVA = "0x129FAD0", Offset = "0x129E6D0", VA = "0x18129FAD0")]
		public SandboxV2WorkbenchView()
		{
		}

		// Token: 0x0402035D RID: 131933
		[Token(Token = "0x402035D")]
		[FieldOffset(Offset = "0x20")]
		private float SWITCH_MID_INTERVAL;

		// Token: 0x0402035E RID: 131934
		[Token(Token = "0x402035E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _materialContent;

		// Token: 0x0402035F RID: 131935
		[Token(Token = "0x402035F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _itemsGroup;

		// Token: 0x04020360 RID: 131936
		[Token(Token = "0x4020360")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2WorkbenchLoopAdapter _itemLoopAdapter;

		// Token: 0x04020361 RID: 131937
		[Token(Token = "0x4020361")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LoopVerticalScrollRect _itemScrollRect;

		// Token: 0x04020362 RID: 131938
		[Token(Token = "0x4020362")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _itemsPanel;

		// Token: 0x04020363 RID: 131939
		[Token(Token = "0x4020363")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x04020364 RID: 131940
		[Token(Token = "0x4020364")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _filterPanel;

		// Token: 0x04020365 RID: 131941
		[Token(Token = "0x4020365")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _filterActivePanel;

		// Token: 0x04020366 RID: 131942
		[Token(Token = "0x4020366")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _filterInactivePanel;

		// Token: 0x04020367 RID: 131943
		[Token(Token = "0x4020367")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _goldPanel;

		// Token: 0x04020368 RID: 131944
		[Token(Token = "0x4020368")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _goldText;

		// Token: 0x04020369 RID: 131945
		[Token(Token = "0x4020369")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _typeSwitchHalfDuration;

		// Token: 0x0402036A RID: 131946
		[Token(Token = "0x402036A")]
		[FieldOffset(Offset = "0x84")]
		private bool m_hasInited;

		// Token: 0x0402036B RID: 131947
		[Token(Token = "0x402036B")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2WorkbenchView.Adapter m_materialAdapter;

		// Token: 0x0402036C RID: 131948
		[Token(Token = "0x402036C")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_typeSwitchTween;

		// Token: 0x0402036D RID: 131949
		[Token(Token = "0x402036D")]
		[FieldOffset(Offset = "0x98")]
		private bool m_blockingItemsUpdate;

		// Token: 0x0402036E RID: 131950
		[Token(Token = "0x402036E")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedTopicId;

		// Token: 0x0402036F RID: 131951
		[Token(Token = "0x402036F")]
		[FieldOffset(Offset = "0xA8")]
		private List<SandboxV2AdminMainMaterialModel> m_cachedMaterials;

		// Token: 0x04020370 RID: 131952
		[Token(Token = "0x4020370")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2AdminMainWorkbenchType m_cachedType;

		// Token: 0x04020371 RID: 131953
		[Token(Token = "0x4020371")]
		[FieldOffset(Offset = "0xB8")]
		private List<SandboxV2WorkbenchItemModel> m_cachedItems;

		// Token: 0x04020372 RID: 131954
		[Token(Token = "0x4020372")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_cachedFilter;

		// Token: 0x04020376 RID: 131958
		[Token(Token = "0x4020376")]
		[FieldOffset(Offset = "0xE0")]
		private Coroutine m_tutorialRaisingCoroutine;

		// Token: 0x04020377 RID: 131959
		[Token(Token = "0x4020377")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x04020378 RID: 131960
		[Token(Token = "0x4020378")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x04020379 RID: 131961
		[Token(Token = "0x4020379")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_setFilterCanMakeEvent;

		// Token: 0x0402037A RID: 131962
		[Token(Token = "0x402037A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_setFilterCanMakeEvent;

		// Token: 0x0402037B RID: 131963
		[Token(Token = "0x402037B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSetFilterCanMakeEvent;

		// Token: 0x0402037C RID: 131964
		[Token(Token = "0x402037C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402037D RID: 131965
		[Token(Token = "0x402037D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402037E RID: 131966
		[Token(Token = "0x402037E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SwitchContent;

		// Token: 0x0402037F RID: 131967
		[Token(Token = "0x402037F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SequenceOfSwitchContent;

		// Token: 0x04020380 RID: 131968
		[Token(Token = "0x4020380")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_tutorialOnly_mainState;

		// Token: 0x04020381 RID: 131969
		[Token(Token = "0x4020381")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_tutorialOnly_mainState;

		// Token: 0x04020382 RID: 131970
		[Token(Token = "0x4020382")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TutorialOnly_CheckSignalToRaise;

		// Token: 0x04020383 RID: 131971
		[Token(Token = "0x4020383")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RaiseSignalWhenFinishTransiting;

		// Token: 0x04020384 RID: 131972
		[Token(Token = "0x4020384")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__StopCoroutineIfNeed;

		// Token: 0x04020385 RID: 131973
		[Token(Token = "0x4020385")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04020386 RID: 131974
		[Token(Token = "0x4020386")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020040FE RID: 16638
		[Token(Token = "0x20040FE")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D5E RID: 15710
			// (get) Token: 0x06019BB3 RID: 105395 RVA: 0x0009F3C0 File Offset: 0x0009D5C0
			[Token(Token = "0x17003D5E")]
			public override int count
			{
				[Token(Token = "0x6019BB3")]
				[Address(RVA = "0x128BE10", Offset = "0x128AA10", VA = "0x18128BE10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019BB4 RID: 105396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019BB4")]
			[Address(RVA = "0x128BD90", Offset = "0x128A990", VA = "0x18128BD90")]
			public Adapter(SandboxV2WorkbenchView closure)
			{
			}

			// Token: 0x06019BB5 RID: 105397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019BB5")]
			[Address(RVA = "0x128BAE0", Offset = "0x128A6E0", VA = "0x18128BAE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020387 RID: 131975
			[Token(Token = "0x4020387")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2WorkbenchView m_closure;

			// Token: 0x04020388 RID: 131976
			[Token(Token = "0x4020388")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020389 RID: 131977
			[Token(Token = "0x4020389")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402038A RID: 131978
			[Token(Token = "0x402038A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
