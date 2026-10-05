using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200524D RID: 21069
	[Token(Token = "0x200524D")]
	public class RoguelikeDungeonCostFragmentPanel : RoguelikeDungeonCostBasePanel
	{
		// Token: 0x0601F147 RID: 127303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F147")]
		[Address(RVA = "0x18CA210", Offset = "0x18C8E10", VA = "0x1818CA210")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F148 RID: 127304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F148")]
		[Address(RVA = "0x18C9C80", Offset = "0x18C8880", VA = "0x1818C9C80", Slot = "4")]
		public override void HandleOnOpenCost(UIPage page, RoguelikeDungeonCostSingleton.Config config)
		{
		}

		// Token: 0x0601F149 RID: 127305 RVA: 0x000B0DC0 File Offset: 0x000AEFC0
		[Token(Token = "0x601F149")]
		[Address(RVA = "0x18CA2F0", Offset = "0x18C8EF0", VA = "0x1818CA2F0")]
		private int _LoadRealFragmentWeight(string fragmentId, int fragmentOriginWeight, Dictionary<string, PlayerRoguelikeV2.CurrentData.Module.InventoryFragment> fragments)
		{
			return 0;
		}

		// Token: 0x0601F14A RID: 127306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F14A")]
		[Address(RVA = "0x18CA4D0", Offset = "0x18C90D0", VA = "0x1818CA4D0")]
		private void _OpenPanel()
		{
		}

		// Token: 0x0601F14B RID: 127307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F14B")]
		[Address(RVA = "0x18CA1A0", Offset = "0x18C8DA0", VA = "0x1818CA1A0")]
		private void _ClosePanel()
		{
		}

		// Token: 0x0601F14C RID: 127308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F14C")]
		[Address(RVA = "0x18C9B60", Offset = "0x18C8760", VA = "0x1818C9B60")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x0601F14D RID: 127309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F14D")]
		[Address(RVA = "0x18CA130", Offset = "0x18C8D30", VA = "0x1818CA130")]
		public void OnCancel()
		{
		}

		// Token: 0x0601F14E RID: 127310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F14E")]
		[Address(RVA = "0x18CA540", Offset = "0x18C9140", VA = "0x1818CA540")]
		public RoguelikeDungeonCostFragmentPanel()
		{
		}

		// Token: 0x04029AF6 RID: 170742
		[Token(Token = "0x4029AF6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x04029AF7 RID: 170743
		[Token(Token = "0x4029AF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04029AF8 RID: 170744
		[Token(Token = "0x4029AF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04029AF9 RID: 170745
		[Token(Token = "0x4029AF9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _descItem;

		// Token: 0x04029AFA RID: 170746
		[Token(Token = "0x4029AFA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSafe;

		// Token: 0x04029AFB RID: 170747
		[Token(Token = "0x4029AFB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLimit;

		// Token: 0x04029AFC RID: 170748
		[Token(Token = "0x4029AFC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelOverload;

		// Token: 0x04029AFD RID: 170749
		[Token(Token = "0x4029AFD")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_showTween;

		// Token: 0x04029AFE RID: 170750
		[Token(Token = "0x4029AFE")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x04029AFF RID: 170751
		[Token(Token = "0x4029AFF")]
		[FieldOffset(Offset = "0x59")]
		private bool m_haveFragment;

		// Token: 0x04029B00 RID: 170752
		[Token(Token = "0x4029B00")]
		[FieldOffset(Offset = "0x60")]
		private string m_itemName;

		// Token: 0x04029B01 RID: 170753
		[Token(Token = "0x4029B01")]
		[FieldOffset(Offset = "0x68")]
		private FragmentBagStatus m_afterBagStatus;

		// Token: 0x04029B02 RID: 170754
		[Token(Token = "0x4029B02")]
		[FieldOffset(Offset = "0x70")]
		private Action m_onCancel;

		// Token: 0x04029B03 RID: 170755
		[Token(Token = "0x4029B03")]
		[FieldOffset(Offset = "0x78")]
		private Action m_onAccept;

		// Token: 0x04029B04 RID: 170756
		[Token(Token = "0x4029B04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029B05 RID: 170757
		[Token(Token = "0x4029B05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleOnOpenCost;

		// Token: 0x04029B06 RID: 170758
		[Token(Token = "0x4029B06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadRealFragmentWeight;

		// Token: 0x04029B07 RID: 170759
		[Token(Token = "0x4029B07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OpenPanel;

		// Token: 0x04029B08 RID: 170760
		[Token(Token = "0x4029B08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClosePanel;

		// Token: 0x04029B09 RID: 170761
		[Token(Token = "0x4029B09")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x04029B0A RID: 170762
		[Token(Token = "0x4029B0A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x04029B0B RID: 170763
		[Token(Token = "0x4029B0B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
