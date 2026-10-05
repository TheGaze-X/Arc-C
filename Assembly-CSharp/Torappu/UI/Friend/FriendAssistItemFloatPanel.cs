using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D9A RID: 19866
	[Token(Token = "0x2004D9A")]
	public class FriendAssistItemFloatPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170045AC RID: 17836
		// (get) Token: 0x0601DB86 RID: 121734 RVA: 0x000AC608 File Offset: 0x000AA808
		[Token(Token = "0x170045AC")]
		public bool isShow
		{
			[Token(Token = "0x601DB86")]
			[Address(RVA = "0x173D170", Offset = "0x173BD70", VA = "0x18173D170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601DB87 RID: 121735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB87")]
		[Address(RVA = "0x173C7E0", Offset = "0x173B3E0", VA = "0x18173C7E0")]
		public void Render(FriendAssistItemFloatPanel.AssistItemOptions options)
		{
		}

		// Token: 0x0601DB88 RID: 121736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB88")]
		[Address(RVA = "0x173C8C0", Offset = "0x173B4C0", VA = "0x18173C8C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DB89 RID: 121737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB89")]
		[Address(RVA = "0x173CC30", Offset = "0x173B830", VA = "0x18173CC30")]
		private void _Render(FriendAssistItemFloatPanel.AssistItemOptions options)
		{
		}

		// Token: 0x0601DB8A RID: 121738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB8A")]
		[Address(RVA = "0x173CE10", Offset = "0x173BA10", VA = "0x18173CE10")]
		private void _ResetPanelPosition()
		{
		}

		// Token: 0x0601DB8B RID: 121739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB8B")]
		[Address(RVA = "0x173CB70", Offset = "0x173B770", VA = "0x18173CB70")]
		private void _OnItemClick(string id, FriendAssistItemFloatPanel.ItemType itemType)
		{
		}

		// Token: 0x0601DB8C RID: 121740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB8C")]
		[Address(RVA = "0x173D0F0", Offset = "0x173BCF0", VA = "0x18173D0F0")]
		public FriendAssistItemFloatPanel()
		{
		}

		// Token: 0x04027495 RID: 160917
		[Token(Token = "0x4027495")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 FLOAT_PANEL_OFFSET;

		// Token: 0x04027496 RID: 160918
		[Token(Token = "0x4027496")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelFloat;

		// Token: 0x04027497 RID: 160919
		[Token(Token = "0x4027497")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _floatBg;

		// Token: 0x04027498 RID: 160920
		[Token(Token = "0x4027498")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _panelFloatCanvasGroup;

		// Token: 0x04027499 RID: 160921
		[Token(Token = "0x4027499")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _skillContainer;

		// Token: 0x0402749A RID: 160922
		[Token(Token = "0x402749A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _equipContainer;

		// Token: 0x0402749B RID: 160923
		[Token(Token = "0x402749B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _skillContent;

		// Token: 0x0402749C RID: 160924
		[Token(Token = "0x402749C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _equipContent;

		// Token: 0x0402749D RID: 160925
		[Token(Token = "0x402749D")]
		[FieldOffset(Offset = "0x50")]
		private GameObject m_cachedItemObject;

		// Token: 0x0402749E RID: 160926
		[Token(Token = "0x402749E")]
		[FieldOffset(Offset = "0x58")]
		private FriendAssistItemFloatPanel.ItemType m_cachedShowType;

		// Token: 0x0402749F RID: 160927
		[Token(Token = "0x402749F")]
		[FieldOffset(Offset = "0x5C")]
		private int m_cachedIndex;

		// Token: 0x040274A0 RID: 160928
		[Token(Token = "0x40274A0")]
		[FieldOffset(Offset = "0x60")]
		private FriendAssistItemFloatPanel.FriendAssistFloatSwitchTween m_switchTween;

		// Token: 0x040274A1 RID: 160929
		[Token(Token = "0x40274A1")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x040274A2 RID: 160930
		[Token(Token = "0x40274A2")]
		[FieldOffset(Offset = "0x70")]
		private FriendAssistItemFloatPanel.SkillAdapter m_skillAdapter;

		// Token: 0x040274A3 RID: 160931
		[Token(Token = "0x40274A3")]
		[FieldOffset(Offset = "0x78")]
		private FriendAssistItemFloatPanel.EquipAdapter m_equipAdapter;

		// Token: 0x040274A4 RID: 160932
		[Token(Token = "0x40274A4")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action<int, string, FriendAssistItemFloatPanel.ItemType> onItemClicked;

		// Token: 0x040274A5 RID: 160933
		[Token(Token = "0x40274A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040274A6 RID: 160934
		[Token(Token = "0x40274A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040274A7 RID: 160935
		[Token(Token = "0x40274A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040274A8 RID: 160936
		[Token(Token = "0x40274A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040274A9 RID: 160937
		[Token(Token = "0x40274A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetPanelPosition;

		// Token: 0x040274AA RID: 160938
		[Token(Token = "0x40274AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x040274AB RID: 160939
		[Token(Token = "0x40274AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D9B RID: 19867
		[Token(Token = "0x2004D9B")]
		public enum ItemType
		{
			// Token: 0x040274AD RID: 160941
			[Token(Token = "0x40274AD")]
			NONE,
			// Token: 0x040274AE RID: 160942
			[Token(Token = "0x40274AE")]
			SKILL,
			// Token: 0x040274AF RID: 160943
			[Token(Token = "0x40274AF")]
			EQUIP
		}

		// Token: 0x02004D9C RID: 19868
		[Token(Token = "0x2004D9C")]
		private class FriendAssistFloatSwitchTween : UISwitchTween
		{
			// Token: 0x0601DB8E RID: 121742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB8E")]
			[Address(RVA = "0x173C760", Offset = "0x173B360", VA = "0x18173C760")]
			public FriendAssistFloatSwitchTween(FriendAssistItemFloatPanel floatPanel)
			{
			}

			// Token: 0x0601DB8F RID: 121743 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DB8F")]
			[Address(RVA = "0x173C490", Offset = "0x173B090", VA = "0x18173C490", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601DB90 RID: 121744 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DB90")]
			[Address(RVA = "0x173C590", Offset = "0x173B190", VA = "0x18173C590", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601DB91 RID: 121745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB91")]
			[Address(RVA = "0x173C2E0", Offset = "0x173AEE0", VA = "0x18173C2E0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601DB92 RID: 121746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB92")]
			[Address(RVA = "0x173C370", Offset = "0x173AF70", VA = "0x18173C370", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601DB93 RID: 121747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB93")]
			[Address(RVA = "0x173C690", Offset = "0x173B290", VA = "0x18173C690", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601DB94 RID: 121748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB94")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601DB95 RID: 121749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB95")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601DB96 RID: 121750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB96")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040274B0 RID: 160944
			[Token(Token = "0x40274B0")]
			private const float ANIM_DURATION = 0.15f;

			// Token: 0x040274B1 RID: 160945
			[Token(Token = "0x40274B1")]
			[FieldOffset(Offset = "0x48")]
			private FriendAssistItemFloatPanel m_closure;

			// Token: 0x040274B2 RID: 160946
			[Token(Token = "0x40274B2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040274B3 RID: 160947
			[Token(Token = "0x40274B3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040274B4 RID: 160948
			[Token(Token = "0x40274B4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040274B5 RID: 160949
			[Token(Token = "0x40274B5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x040274B6 RID: 160950
			[Token(Token = "0x40274B6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x040274B7 RID: 160951
			[Token(Token = "0x40274B7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02004D9D RID: 19869
		[Token(Token = "0x2004D9D")]
		private class EquipAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170045AD RID: 17837
			// (get) Token: 0x0601DB97 RID: 121751 RVA: 0x000AC620 File Offset: 0x000AA820
			[Token(Token = "0x170045AD")]
			public override int count
			{
				[Token(Token = "0x601DB97")]
				[Address(RVA = "0x173B5B0", Offset = "0x173A1B0", VA = "0x18173B5B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601DB98 RID: 121752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DB98")]
			[Address(RVA = "0x173B1E0", Offset = "0x1739DE0", VA = "0x18173B1E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601DB99 RID: 121753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB99")]
			[Address(RVA = "0x173B550", Offset = "0x173A150", VA = "0x18173B550")]
			public EquipAdapter()
			{
			}

			// Token: 0x040274B8 RID: 160952
			[Token(Token = "0x40274B8")]
			private const int UNIEQUIP_SLOT_NUM = 3;

			// Token: 0x040274B9 RID: 160953
			[Token(Token = "0x40274B9")]
			[FieldOffset(Offset = "0x20")]
			public FriendAssistItemFloatPanel closure;

			// Token: 0x040274BA RID: 160954
			[Token(Token = "0x40274BA")]
			[FieldOffset(Offset = "0x28")]
			public FriendAssistItemFloatPanel.EquipAdapter.EquipData data;

			// Token: 0x040274BB RID: 160955
			[Token(Token = "0x40274BB")]
			[FieldOffset(Offset = "0x38")]
			public string selectEquipId;

			// Token: 0x040274BC RID: 160956
			[Token(Token = "0x40274BC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040274BD RID: 160957
			[Token(Token = "0x40274BD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040274BE RID: 160958
			[Token(Token = "0x40274BE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02004D9E RID: 19870
			[Token(Token = "0x2004D9E")]
			public struct EquipData
			{
				// Token: 0x040274BF RID: 160959
				[Token(Token = "0x40274BF")]
				[FieldOffset(Offset = "0x0")]
				public string charId;

				// Token: 0x040274C0 RID: 160960
				[Token(Token = "0x40274C0")]
				[FieldOffset(Offset = "0x8")]
				public List<FriendAssistCharData.CharEquipInfo> equipInfos;
			}
		}

		// Token: 0x02004D9F RID: 19871
		[Token(Token = "0x2004D9F")]
		private class SkillAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170045AE RID: 17838
			// (get) Token: 0x0601DB9A RID: 121754 RVA: 0x000AC638 File Offset: 0x000AA838
			[Token(Token = "0x170045AE")]
			public override int count
			{
				[Token(Token = "0x601DB9A")]
				[Address(RVA = "0x174FDD0", Offset = "0x174E9D0", VA = "0x18174FDD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601DB9B RID: 121755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DB9B")]
			[Address(RVA = "0x174F9D0", Offset = "0x174E5D0", VA = "0x18174F9D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601DB9C RID: 121756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB9C")]
			[Address(RVA = "0x174FD70", Offset = "0x174E970", VA = "0x18174FD70")]
			public SkillAdapter()
			{
			}

			// Token: 0x040274C1 RID: 160961
			[Token(Token = "0x40274C1")]
			[FieldOffset(Offset = "0x20")]
			public FriendAssistItemFloatPanel closure;

			// Token: 0x040274C2 RID: 160962
			[Token(Token = "0x40274C2")]
			[FieldOffset(Offset = "0x28")]
			public FriendAssistItemFloatPanel.SkillAdapter.SkillData data;

			// Token: 0x040274C3 RID: 160963
			[Token(Token = "0x40274C3")]
			[FieldOffset(Offset = "0x38")]
			public int selectSkillIndex;

			// Token: 0x040274C4 RID: 160964
			[Token(Token = "0x40274C4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040274C5 RID: 160965
			[Token(Token = "0x40274C5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040274C6 RID: 160966
			[Token(Token = "0x40274C6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02004DA0 RID: 19872
			[Token(Token = "0x2004DA0")]
			public struct SkillData
			{
				// Token: 0x040274C7 RID: 160967
				[Token(Token = "0x40274C7")]
				[FieldOffset(Offset = "0x0")]
				public PlayerCharSkill[] skills;

				// Token: 0x040274C8 RID: 160968
				[Token(Token = "0x40274C8")]
				[FieldOffset(Offset = "0x8")]
				public int mainSkillLvl;
			}
		}

		// Token: 0x02004DA1 RID: 19873
		[Token(Token = "0x2004DA1")]
		public class AssistItemOptions
		{
			// Token: 0x0601DB9D RID: 121757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DB9D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AssistItemOptions()
			{
			}

			// Token: 0x040274C9 RID: 160969
			[Token(Token = "0x40274C9")]
			[FieldOffset(Offset = "0x10")]
			public int cardIndex;

			// Token: 0x040274CA RID: 160970
			[Token(Token = "0x40274CA")]
			[FieldOffset(Offset = "0x18")]
			public FriendAssistCharData assistCharData;

			// Token: 0x040274CB RID: 160971
			[Token(Token = "0x40274CB")]
			[FieldOffset(Offset = "0x20")]
			public GameObject itemObject;

			// Token: 0x040274CC RID: 160972
			[Token(Token = "0x40274CC")]
			[FieldOffset(Offset = "0x28")]
			public FriendAssistItemFloatPanel.ItemType itemType;

			// Token: 0x040274CD RID: 160973
			[Token(Token = "0x40274CD")]
			[FieldOffset(Offset = "0x2C")]
			public int skillIndex;

			// Token: 0x040274CE RID: 160974
			[Token(Token = "0x40274CE")]
			[FieldOffset(Offset = "0x30")]
			public string equipId;

			// Token: 0x040274CF RID: 160975
			[Token(Token = "0x40274CF")]
			[FieldOffset(Offset = "0x38")]
			public bool isShow;
		}
	}
}
