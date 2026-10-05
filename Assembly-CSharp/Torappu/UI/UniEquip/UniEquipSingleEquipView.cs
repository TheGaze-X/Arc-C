using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C33 RID: 15411
	[Token(Token = "0x2003C33")]
	public class UniEquipSingleEquipView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018194 RID: 98708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018194")]
		[Address(RVA = "0x109D6E0", Offset = "0x109C2E0", VA = "0x18109D6E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018195 RID: 98709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018195")]
		[Address(RVA = "0x109C9E0", Offset = "0x109B5E0", VA = "0x18109C9E0")]
		public void OnSelectUniEquip()
		{
		}

		// Token: 0x06018196 RID: 98710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018196")]
		[Address(RVA = "0x109C8C0", Offset = "0x109B4C0", VA = "0x18109C8C0")]
		public void OnCheckDetail()
		{
		}

		// Token: 0x06018197 RID: 98711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018197")]
		[Address(RVA = "0x109CA70", Offset = "0x109B670", VA = "0x18109CA70")]
		public void OnUnlockUniEquip()
		{
		}

		// Token: 0x06018198 RID: 98712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018198")]
		[Address(RVA = "0x109C830", Offset = "0x109B430", VA = "0x18109C830")]
		public void OnChangeUniEquip()
		{
		}

		// Token: 0x06018199 RID: 98713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018199")]
		[Address(RVA = "0x109C950", Offset = "0x109B550", VA = "0x18109C950")]
		public void OnLevelUpUniEquip()
		{
		}

		// Token: 0x0601819A RID: 98714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601819A")]
		[Address(RVA = "0x109D390", Offset = "0x109BF90", VA = "0x18109D390")]
		private void _ApplyAnimation(bool isSelect, bool needShining)
		{
		}

		// Token: 0x0601819B RID: 98715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601819B")]
		[Address(RVA = "0x109D8F0", Offset = "0x109C4F0", VA = "0x18109D8F0")]
		private void _RenderTags(UniEquipSelectViewModel viewModel)
		{
		}

		// Token: 0x0601819C RID: 98716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601819C")]
		[Address(RVA = "0x109CB00", Offset = "0x109B700", VA = "0x18109CB00")]
		public void Render(UniEquipSelectViewModel viewModel, bool needShining = false)
		{
		}

		// Token: 0x0601819D RID: 98717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601819D")]
		[Address(RVA = "0x109DB30", Offset = "0x109C730", VA = "0x18109DB30")]
		private void _TryRaiseEquipSelectSignal()
		{
		}

		// Token: 0x0601819E RID: 98718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601819E")]
		[Address(RVA = "0x109D890", Offset = "0x109C490", VA = "0x18109D890")]
		private void _RaiseEquipSelectSignal()
		{
		}

		// Token: 0x0601819F RID: 98719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601819F")]
		[Address(RVA = "0x109C7A0", Offset = "0x109B3A0", VA = "0x18109C7A0")]
		public void InvokeUnlockAvgAction(Action<GameObject, GameObject> traceUnlockAvgAction)
		{
		}

		// Token: 0x060181A0 RID: 98720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181A0")]
		[Address(RVA = "0x109C710", Offset = "0x109B310", VA = "0x18109C710")]
		public void InvokeLevelupAvgAction(Action<GameObject> traceLevelupAvgAction)
		{
		}

		// Token: 0x060181A1 RID: 98721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181A1")]
		[Address(RVA = "0x109DC60", Offset = "0x109C860", VA = "0x18109DC60")]
		public UniEquipSingleEquipView()
		{
		}

		// Token: 0x0401D40C RID: 119820
		[Token(Token = "0x401D40C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _uniEquipName;

		// Token: 0x0401D40D RID: 119821
		[Token(Token = "0x401D40D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UniEquipImgHolder _imgHolder;

		// Token: 0x0401D40E RID: 119822
		[Token(Token = "0x401D40E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _imgContainer;

		// Token: 0x0401D40F RID: 119823
		[Token(Token = "0x401D40F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scaler;

		// Token: 0x0401D410 RID: 119824
		[Token(Token = "0x401D410")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _havePart;

		// Token: 0x0401D411 RID: 119825
		[Token(Token = "0x401D411")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _dontHavePart;

		// Token: 0x0401D412 RID: 119826
		[Token(Token = "0x401D412")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0401D413 RID: 119827
		[Token(Token = "0x401D413")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _changeBtn;

		// Token: 0x0401D414 RID: 119828
		[Token(Token = "0x401D414")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _commonCharEquipText;

		// Token: 0x0401D415 RID: 119829
		[Token(Token = "0x401D415")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _equipChangeAttributeText;

		// Token: 0x0401D416 RID: 119830
		[Token(Token = "0x401D416")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _equipChangeSubProfessionDescText;

		// Token: 0x0401D417 RID: 119831
		[Token(Token = "0x401D417")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _equipChangeTalentDescText;

		// Token: 0x0401D418 RID: 119832
		[Token(Token = "0x401D418")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _equipSpecialDescText;

		// Token: 0x0401D419 RID: 119833
		[Token(Token = "0x401D419")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _levelPart;

		// Token: 0x0401D41A RID: 119834
		[Token(Token = "0x401D41A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _focusPart;

		// Token: 0x0401D41B RID: 119835
		[Token(Token = "0x401D41B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _focusPart2;

		// Token: 0x0401D41C RID: 119836
		[Token(Token = "0x401D41C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _unlockObj;

		// Token: 0x0401D41D RID: 119837
		[Token(Token = "0x401D41D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _unlockAvailablePart;

		// Token: 0x0401D41E RID: 119838
		[Token(Token = "0x401D41E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401D41F RID: 119839
		[Token(Token = "0x401D41F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _typeContainer;

		// Token: 0x0401D420 RID: 119840
		[Token(Token = "0x401D420")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _typeCanvasGroup;

		// Token: 0x0401D421 RID: 119841
		[Token(Token = "0x401D421")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _typeValidAlpha;

		// Token: 0x0401D422 RID: 119842
		[Token(Token = "0x401D422")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float _typeInvalidAlpha;

		// Token: 0x0401D423 RID: 119843
		[Token(Token = "0x401D423")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UICommonEquipTypeIcon _typeIcon;

		// Token: 0x0401D424 RID: 119844
		[Token(Token = "0x401D424")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _levelUpPart;

		// Token: 0x0401D425 RID: 119845
		[Token(Token = "0x401D425")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _levelMaxPart;

		// Token: 0x0401D426 RID: 119846
		[Token(Token = "0x401D426")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Sprite[] _levelSprites;

		// Token: 0x0401D427 RID: 119847
		[Token(Token = "0x401D427")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _selectedDetailBtn;

		// Token: 0x0401D428 RID: 119848
		[Token(Token = "0x401D428")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _hotSpotPart;

		// Token: 0x0401D429 RID: 119849
		[Token(Token = "0x401D429")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _selectHotspotPart;

		// Token: 0x0401D42A RID: 119850
		[Token(Token = "0x401D42A")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _unlockHotspotPart;

		// Token: 0x0401D42B RID: 119851
		[Token(Token = "0x401D42B")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _levelUpEnoughPart;

		// Token: 0x0401D42C RID: 119852
		[Token(Token = "0x401D42C")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _levelUpDisablePart;

		// Token: 0x0401D42D RID: 119853
		[Token(Token = "0x401D42D")]
		[FieldOffset(Offset = "0x118")]
		[NonSerialized]
		public UIStringEvent onUnlockAction;

		// Token: 0x0401D42E RID: 119854
		[Token(Token = "0x401D42E")]
		[FieldOffset(Offset = "0x120")]
		[NonSerialized]
		public UIStringEvent onLevelUpAction;

		// Token: 0x0401D42F RID: 119855
		[Token(Token = "0x401D42F")]
		[FieldOffset(Offset = "0x128")]
		[NonSerialized]
		public UIStringEvent onDetailAction;

		// Token: 0x0401D430 RID: 119856
		[Token(Token = "0x401D430")]
		[FieldOffset(Offset = "0x130")]
		[NonSerialized]
		public UIStringEvent onSelectAction;

		// Token: 0x0401D431 RID: 119857
		[Token(Token = "0x401D431")]
		[FieldOffset(Offset = "0x138")]
		[NonSerialized]
		public UIStringEvent onChangeAction;

		// Token: 0x0401D432 RID: 119858
		[Token(Token = "0x401D432")]
		[FieldOffset(Offset = "0x140")]
		private UniEquipImgHolder m_imgHolder;

		// Token: 0x0401D433 RID: 119859
		[Token(Token = "0x401D433")]
		[FieldOffset(Offset = "0x148")]
		private bool m_initIfNot;

		// Token: 0x0401D434 RID: 119860
		[Token(Token = "0x401D434")]
		[FieldOffset(Offset = "0x150")]
		private UniEquipSingleEquipView.MissionAdapter m_adatper;

		// Token: 0x0401D435 RID: 119861
		[Token(Token = "0x401D435")]
		[FieldOffset(Offset = "0x158")]
		private UICommonEquipTypeIcon m_typeIcon;

		// Token: 0x0401D436 RID: 119862
		[Token(Token = "0x401D436")]
		[FieldOffset(Offset = "0x160")]
		private UniEquipSelectViewModel m_cacheViewModel;

		// Token: 0x0401D437 RID: 119863
		[Token(Token = "0x401D437")]
		[FieldOffset(Offset = "0x168")]
		private float m_selectAnimParam;

		// Token: 0x0401D438 RID: 119864
		[Token(Token = "0x401D438")]
		[FieldOffset(Offset = "0x16C")]
		private bool m_isInited;

		// Token: 0x0401D439 RID: 119865
		[Token(Token = "0x401D439")]
		[FieldOffset(Offset = "0x170")]
		private string ANIM_PARAM;

		// Token: 0x0401D43A RID: 119866
		[Token(Token = "0x401D43A")]
		[FieldOffset(Offset = "0x178")]
		private Tween m_animTween;

		// Token: 0x0401D43B RID: 119867
		[Token(Token = "0x401D43B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D43C RID: 119868
		[Token(Token = "0x401D43C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelectUniEquip;

		// Token: 0x0401D43D RID: 119869
		[Token(Token = "0x401D43D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCheckDetail;

		// Token: 0x0401D43E RID: 119870
		[Token(Token = "0x401D43E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUnlockUniEquip;

		// Token: 0x0401D43F RID: 119871
		[Token(Token = "0x401D43F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnChangeUniEquip;

		// Token: 0x0401D440 RID: 119872
		[Token(Token = "0x401D440")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnLevelUpUniEquip;

		// Token: 0x0401D441 RID: 119873
		[Token(Token = "0x401D441")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ApplyAnimation;

		// Token: 0x0401D442 RID: 119874
		[Token(Token = "0x401D442")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderTags;

		// Token: 0x0401D443 RID: 119875
		[Token(Token = "0x401D443")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D444 RID: 119876
		[Token(Token = "0x401D444")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryRaiseEquipSelectSignal;

		// Token: 0x0401D445 RID: 119877
		[Token(Token = "0x401D445")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RaiseEquipSelectSignal;

		// Token: 0x0401D446 RID: 119878
		[Token(Token = "0x401D446")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_InvokeUnlockAvgAction;

		// Token: 0x0401D447 RID: 119879
		[Token(Token = "0x401D447")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_InvokeLevelupAvgAction;

		// Token: 0x0401D448 RID: 119880
		[Token(Token = "0x401D448")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C34 RID: 15412
		[Token(Token = "0x2003C34")]
		private class MissionAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003990 RID: 14736
			// (get) Token: 0x060181A4 RID: 98724 RVA: 0x00099588 File Offset: 0x00097788
			[Token(Token = "0x17003990")]
			public override int count
			{
				[Token(Token = "0x60181A4")]
				[Address(RVA = "0x108EFD0", Offset = "0x108DBD0", VA = "0x18108EFD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060181A5 RID: 98725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60181A5")]
			[Address(RVA = "0x108ED80", Offset = "0x108D980", VA = "0x18108ED80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060181A6 RID: 98726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60181A6")]
			[Address(RVA = "0x108EF70", Offset = "0x108DB70", VA = "0x18108EF70")]
			public MissionAdapter()
			{
			}

			// Token: 0x0401D449 RID: 119881
			[Token(Token = "0x401D449")]
			[FieldOffset(Offset = "0x20")]
			public List<bool> missionList;

			// Token: 0x0401D44A RID: 119882
			[Token(Token = "0x401D44A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D44B RID: 119883
			[Token(Token = "0x401D44B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401D44C RID: 119884
			[Token(Token = "0x401D44C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
