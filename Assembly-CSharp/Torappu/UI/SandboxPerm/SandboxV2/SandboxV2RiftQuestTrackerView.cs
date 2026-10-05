using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004229 RID: 16937
	[Token(Token = "0x2004229")]
	public class SandboxV2RiftQuestTrackerView : DataBinder<SandboxV2RiftQuestTrackerProperty>
	{
		// Token: 0x0601A1FB RID: 107003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1FB")]
		[Address(RVA = "0x13110D0", Offset = "0x130FCD0", VA = "0x1813110D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1FC RID: 107004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1FC")]
		[Address(RVA = "0x1310BE0", Offset = "0x130F7E0", VA = "0x181310BE0", Slot = "7")]
		public override void OnValueChanged(SandboxV2RiftQuestTrackerProperty property)
		{
		}

		// Token: 0x0601A1FD RID: 107005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1FD")]
		[Address(RVA = "0x1311200", Offset = "0x130FE00", VA = "0x181311200")]
		public SandboxV2RiftQuestTrackerView()
		{
		}

		// Token: 0x04020F8F RID: 135055
		[Token(Token = "0x4020F8F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtMainTaskTitle;

		// Token: 0x04020F90 RID: 135056
		[Token(Token = "0x4020F90")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtMainTaskStoryDesc;

		// Token: 0x04020F91 RID: 135057
		[Token(Token = "0x4020F91")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objMainTaskFail;

		// Token: 0x04020F92 RID: 135058
		[Token(Token = "0x4020F92")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objMainTaskComplete;

		// Token: 0x04020F93 RID: 135059
		[Token(Token = "0x4020F93")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objMainTaskGoing;

		// Token: 0x04020F94 RID: 135060
		[Token(Token = "0x4020F94")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtMainTaskDesc;

		// Token: 0x04020F95 RID: 135061
		[Token(Token = "0x4020F95")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _mainRewardsContainer;

		// Token: 0x04020F96 RID: 135062
		[Token(Token = "0x4020F96")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objSubTargetPart;

		// Token: 0x04020F97 RID: 135063
		[Token(Token = "0x4020F97")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _txtSubTaskDesc;

		// Token: 0x04020F98 RID: 135064
		[Token(Token = "0x4020F98")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objSubTaskComplete;

		// Token: 0x04020F99 RID: 135065
		[Token(Token = "0x4020F99")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _subRewardsContainer;

		// Token: 0x04020F9A RID: 135066
		[Token(Token = "0x4020F9A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _rewardItemCardScale;

		// Token: 0x04020F9B RID: 135067
		[Token(Token = "0x4020F9B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04020F9C RID: 135068
		[Token(Token = "0x4020F9C")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04020F9D RID: 135069
		[Token(Token = "0x4020F9D")]
		[FieldOffset(Offset = "0x8C")]
		private int m_cachedEnterSeq;

		// Token: 0x04020F9E RID: 135070
		[Token(Token = "0x4020F9E")]
		[FieldOffset(Offset = "0x90")]
		private SandboxV2RiftQuestTrackerView.Adapter m_mainRewardAdapter;

		// Token: 0x04020F9F RID: 135071
		[Token(Token = "0x4020F9F")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2RiftQuestTrackerView.Adapter m_subRewardAdapter;

		// Token: 0x04020FA0 RID: 135072
		[Token(Token = "0x4020FA0")]
		private const string TITLE_FORMAT = "{0}-{1}";

		// Token: 0x04020FA1 RID: 135073
		[Token(Token = "0x4020FA1")]
		private const string TARGET_FORMAT = "{0} <color=#828282>(</color><color=#d8d769>{1}</color><color=#828282>/{2})</color>";

		// Token: 0x04020FA2 RID: 135074
		[Token(Token = "0x4020FA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020FA3 RID: 135075
		[Token(Token = "0x4020FA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020FA4 RID: 135076
		[Token(Token = "0x4020FA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200422A RID: 16938
		[Token(Token = "0x200422A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003E1B RID: 15899
			// (get) Token: 0x0601A1FE RID: 107006 RVA: 0x000A0518 File Offset: 0x0009E718
			[Token(Token = "0x17003E1B")]
			public override int count
			{
				[Token(Token = "0x601A1FE")]
				[Address(RVA = "0x12FD5E0", Offset = "0x12FC1E0", VA = "0x1812FD5E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A1FF RID: 107007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A1FF")]
			[Address(RVA = "0x12FC280", Offset = "0x12FAE80", VA = "0x1812FC280", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601A200 RID: 107008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A200")]
			[Address(RVA = "0x12FCF30", Offset = "0x12FBB30", VA = "0x1812FCF30")]
			private void _OnItemClick(int index)
			{
			}

			// Token: 0x0601A201 RID: 107009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A201")]
			[Address(RVA = "0x12FD1C0", Offset = "0x12FBDC0", VA = "0x1812FD1C0")]
			public Adapter()
			{
			}

			// Token: 0x04020FA5 RID: 135077
			[Token(Token = "0x4020FA5")]
			[FieldOffset(Offset = "0x20")]
			public List<UIItemViewModel> itemDataList;

			// Token: 0x04020FA6 RID: 135078
			[Token(Token = "0x4020FA6")]
			[FieldOffset(Offset = "0x0")]
			private static readonly SandboxV2ItemCard.Option REWARD_ITEM_CARD_OPTION;

			// Token: 0x04020FA7 RID: 135079
			[Token(Token = "0x4020FA7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020FA8 RID: 135080
			[Token(Token = "0x4020FA8")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04020FA9 RID: 135081
			[Token(Token = "0x4020FA9")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__OnItemClick;

			// Token: 0x04020FAA RID: 135082
			[Token(Token = "0x4020FAA")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
