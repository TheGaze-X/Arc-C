using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F0B RID: 16139
	[Token(Token = "0x2003F0B")]
	public class SiracusaCharCardView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x060190F3 RID: 102643 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060190F4 RID: 102644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BF3")]
		public Action onBubbleShow
		{
			[Token(Token = "0x60190F3")]
			[Address(RVA = "0x11B11B0", Offset = "0x11AFDB0", VA = "0x1811B11B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60190F4")]
			[Address(RVA = "0x11B13B0", Offset = "0x11AFFB0", VA = "0x1811B13B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x060190F5 RID: 102645 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060190F6 RID: 102646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BF4")]
		public Action<int> onSelectRing
		{
			[Token(Token = "0x60190F5")]
			[Address(RVA = "0x11B1270", Offset = "0x11AFE70", VA = "0x1811B1270")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60190F6")]
			[Address(RVA = "0x11B14B0", Offset = "0x11B00B0", VA = "0x1811B14B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x060190F7 RID: 102647 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060190F8 RID: 102648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BF5")]
		public Action<string, string> onTaskClick
		{
			[Token(Token = "0x60190F7")]
			[Address(RVA = "0x11B12D0", Offset = "0x11AFED0", VA = "0x1811B12D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60190F8")]
			[Address(RVA = "0x11B1530", Offset = "0x11B0130", VA = "0x1811B1530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x060190F9 RID: 102649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060190FA RID: 102650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BF6")]
		public Action onBagClick
		{
			[Token(Token = "0x60190F9")]
			[Address(RVA = "0x11B1150", Offset = "0x11AFD50", VA = "0x1811B1150")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60190FA")]
			[Address(RVA = "0x11B1330", Offset = "0x11AFF30", VA = "0x1811B1330")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x060190FB RID: 102651 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060190FC RID: 102652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BF7")]
		public Action onChangeChar
		{
			[Token(Token = "0x60190FB")]
			[Address(RVA = "0x11B1210", Offset = "0x11AFE10", VA = "0x1811B1210")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60190FC")]
			[Address(RVA = "0x11B1430", Offset = "0x11B0030", VA = "0x1811B1430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060190FD RID: 102653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190FD")]
		[Address(RVA = "0x11AFE50", Offset = "0x11AEA50", VA = "0x1811AFE50", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x060190FE RID: 102654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190FE")]
		[Address(RVA = "0x11B0F30", Offset = "0x11AFB30", VA = "0x1811B0F30")]
		private void _ShowBubbleOfNewTaskRing(bool isInSmallMap)
		{
		}

		// Token: 0x060190FF RID: 102655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190FF")]
		[Address(RVA = "0x11B0D60", Offset = "0x11AF960", VA = "0x1811B0D60")]
		private void _SetCharCardVisible(bool isVisible)
		{
		}

		// Token: 0x06019100 RID: 102656 RVA: 0x0009CE40 File Offset: 0x0009B040
		[Token(Token = "0x6019100")]
		[Address(RVA = "0x11B0390", Offset = "0x11AEF90", VA = "0x1811B0390")]
		public bool TryShowBubble()
		{
			return default(bool);
		}

		// Token: 0x06019101 RID: 102657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019101")]
		[Address(RVA = "0x11AFD20", Offset = "0x11AE920", VA = "0x1811AFD20")]
		public IEnumerator HideBubbleAfterDelay()
		{
			return null;
		}

		// Token: 0x06019102 RID: 102658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019102")]
		[Address(RVA = "0x11B0520", Offset = "0x11AF120", VA = "0x1811B0520")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019103 RID: 102659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019103")]
		[Address(RVA = "0x11B07B0", Offset = "0x11AF3B0", VA = "0x1811B07B0")]
		private void _RenderEquipView(SiracusaCharCardModel charCardModel, bool isInSmallMapState)
		{
		}

		// Token: 0x06019104 RID: 102660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019104")]
		[Address(RVA = "0x11B0420", Offset = "0x11AF020", VA = "0x1811B0420")]
		private string _GetItemIconPath(SiracusaData.ItemInfoData bagItemInfoData)
		{
			return null;
		}

		// Token: 0x06019105 RID: 102661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019105")]
		[Address(RVA = "0x11B0DF0", Offset = "0x11AF9F0", VA = "0x1811B0DF0")]
		private void _SetThemeColor(Color themeColor)
		{
		}

		// Token: 0x06019106 RID: 102662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019106")]
		[Address(RVA = "0x11AFDD0", Offset = "0x11AE9D0", VA = "0x1811AFDD0")]
		public void Init(AutoPackSpriteHub itemSpriteHub)
		{
		}

		// Token: 0x06019107 RID: 102663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019107")]
		[Address(RVA = "0x11AFC10", Offset = "0x11AE810", VA = "0x1811AFC10")]
		public void EventOnShowBubble()
		{
		}

		// Token: 0x06019108 RID: 102664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019108")]
		[Address(RVA = "0x11AFB00", Offset = "0x11AE700", VA = "0x1811AFB00")]
		public void EventOnOpenBag()
		{
		}

		// Token: 0x06019109 RID: 102665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019109")]
		[Address(RVA = "0x11AF9F0", Offset = "0x11AE5F0", VA = "0x1811AF9F0")]
		public void EventOnChangeChar()
		{
		}

		// Token: 0x0601910A RID: 102666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601910A")]
		[Address(RVA = "0x11B10D0", Offset = "0x11AFCD0", VA = "0x1811B10D0")]
		public SiracusaCharCardView()
		{
		}

		// Token: 0x0401EFE1 RID: 126945
		[Token(Token = "0x401EFE1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyView;

		// Token: 0x0401EFE2 RID: 126946
		[Token(Token = "0x401EFE2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _equipView;

		// Token: 0x0401EFE3 RID: 126947
		[Token(Token = "0x401EFE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _completeView;

		// Token: 0x0401EFE4 RID: 126948
		[Token(Token = "0x401EFE4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _btnInventToggle;

		// Token: 0x0401EFE5 RID: 126949
		[Token(Token = "0x401EFE5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage[] _imgThemeList;

		// Token: 0x0401EFE6 RID: 126950
		[Token(Token = "0x401EFE6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _btnSwitchGo;

		// Token: 0x0401EFE7 RID: 126951
		[Token(Token = "0x401EFE7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgChar;

		// Token: 0x0401EFE8 RID: 126952
		[Token(Token = "0x401EFE8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIDynImage _imgItem;

		// Token: 0x0401EFE9 RID: 126953
		[Token(Token = "0x401EFE9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _taskRingList;

		// Token: 0x0401EFEA RID: 126954
		[Token(Token = "0x401EFEA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasObject _charCardAtlas;

		// Token: 0x0401EFEB RID: 126955
		[Token(Token = "0x401EFEB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("DialogBubble")]
		private Text _textCurrentTask;

		// Token: 0x0401EFEC RID: 126956
		[Token(Token = "0x401EFEC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("DialogBubble")]
		private float _bubbleDuration;

		// Token: 0x0401EFED RID: 126957
		[Token(Token = "0x401EFED")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("DialogBubble")]
		private CanvasGroup _bubbleCanvasGroup;

		// Token: 0x0401EFEE RID: 126958
		[Token(Token = "0x401EFEE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _taskDialogCanvasGroup;

		// Token: 0x0401EFEF RID: 126959
		[Token(Token = "0x401EFEF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _cardViewCanvasGroup;

		// Token: 0x0401EFF0 RID: 126960
		[Token(Token = "0x401EFF0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject[] _newCharCardTrackPoints;

		// Token: 0x0401EFF1 RID: 126961
		[Token(Token = "0x401EFF1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _newBagItemTrackPoint;

		// Token: 0x0401EFF2 RID: 126962
		[Token(Token = "0x401EFF2")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x0401EFF3 RID: 126963
		[Token(Token = "0x401EFF3")]
		[FieldOffset(Offset = "0xB0")]
		private SiracusaCharCardModel m_charCardModel;

		// Token: 0x0401EFF4 RID: 126964
		[Token(Token = "0x401EFF4")]
		[FieldOffset(Offset = "0xB8")]
		private FadeSwitchTween m_cardViewTween;

		// Token: 0x0401EFF5 RID: 126965
		[Token(Token = "0x401EFF5")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_bubbleTween;

		// Token: 0x0401EFF6 RID: 126966
		[Token(Token = "0x401EFF6")]
		[FieldOffset(Offset = "0xC8")]
		private FadeSwitchTween m_taskDialogTween;

		// Token: 0x0401EFF7 RID: 126967
		[Token(Token = "0x401EFF7")]
		[FieldOffset(Offset = "0xD0")]
		private SiracusaCharCardView.Adapter m_adapter;

		// Token: 0x0401EFF8 RID: 126968
		[Token(Token = "0x401EFF8")]
		[FieldOffset(Offset = "0xD8")]
		private AutoPackSpriteHub m_itemSpriteHub;

		// Token: 0x0401EFF9 RID: 126969
		[Token(Token = "0x401EFF9")]
		[FieldOffset(Offset = "0xE0")]
		private string m_cachedRingId;

		// Token: 0x0401EFFF RID: 126975
		[Token(Token = "0x401EFFF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBubbleShow;

		// Token: 0x0401F000 RID: 126976
		[Token(Token = "0x401F000")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBubbleShow;

		// Token: 0x0401F001 RID: 126977
		[Token(Token = "0x401F001")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onSelectRing;

		// Token: 0x0401F002 RID: 126978
		[Token(Token = "0x401F002")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onSelectRing;

		// Token: 0x0401F003 RID: 126979
		[Token(Token = "0x401F003")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onTaskClick;

		// Token: 0x0401F004 RID: 126980
		[Token(Token = "0x401F004")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onTaskClick;

		// Token: 0x0401F005 RID: 126981
		[Token(Token = "0x401F005")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onBagClick;

		// Token: 0x0401F006 RID: 126982
		[Token(Token = "0x401F006")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onBagClick;

		// Token: 0x0401F007 RID: 126983
		[Token(Token = "0x401F007")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onChangeChar;

		// Token: 0x0401F008 RID: 126984
		[Token(Token = "0x401F008")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onChangeChar;

		// Token: 0x0401F009 RID: 126985
		[Token(Token = "0x401F009")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F00A RID: 126986
		[Token(Token = "0x401F00A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowBubbleOfNewTaskRing;

		// Token: 0x0401F00B RID: 126987
		[Token(Token = "0x401F00B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetCharCardVisible;

		// Token: 0x0401F00C RID: 126988
		[Token(Token = "0x401F00C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryShowBubble;

		// Token: 0x0401F00D RID: 126989
		[Token(Token = "0x401F00D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HideBubbleAfterDelay;

		// Token: 0x0401F00E RID: 126990
		[Token(Token = "0x401F00E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F00F RID: 126991
		[Token(Token = "0x401F00F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderEquipView;

		// Token: 0x0401F010 RID: 126992
		[Token(Token = "0x401F010")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetItemIconPath;

		// Token: 0x0401F011 RID: 126993
		[Token(Token = "0x401F011")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SetThemeColor;

		// Token: 0x0401F012 RID: 126994
		[Token(Token = "0x401F012")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F013 RID: 126995
		[Token(Token = "0x401F013")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnShowBubble;

		// Token: 0x0401F014 RID: 126996
		[Token(Token = "0x401F014")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnOpenBag;

		// Token: 0x0401F015 RID: 126997
		[Token(Token = "0x401F015")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnChangeChar;

		// Token: 0x0401F016 RID: 126998
		[Token(Token = "0x401F016")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F0C RID: 16140
		[Token(Token = "0x2003F0C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601910B RID: 102667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601910B")]
			[Address(RVA = "0x11AC8F0", Offset = "0x11AB4F0", VA = "0x1811AC8F0")]
			public Adapter(SiracusaCharCardView closure)
			{
			}

			// Token: 0x17003BF8 RID: 15352
			// (get) Token: 0x0601910C RID: 102668 RVA: 0x0009CE58 File Offset: 0x0009B058
			[Token(Token = "0x17003BF8")]
			public override int count
			{
				[Token(Token = "0x601910C")]
				[Address(RVA = "0x11ACAE0", Offset = "0x11AB6E0", VA = "0x1811ACAE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601910D RID: 102669 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601910D")]
			[Address(RVA = "0x11AC4D0", Offset = "0x11AB0D0", VA = "0x1811AC4D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401F017 RID: 126999
			[Token(Token = "0x401F017")]
			[FieldOffset(Offset = "0x20")]
			private SiracusaCharCardView m_closure;

			// Token: 0x0401F018 RID: 127000
			[Token(Token = "0x401F018")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401F019 RID: 127001
			[Token(Token = "0x401F019")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F01A RID: 127002
			[Token(Token = "0x401F01A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
