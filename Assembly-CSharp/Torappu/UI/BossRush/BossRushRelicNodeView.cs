using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006182 RID: 24962
	[Token(Token = "0x2006182")]
	public class BossRushRelicNodeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170054FD RID: 21757
		// (get) Token: 0x06024026 RID: 147494 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024027 RID: 147495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054FD")]
		public Action<BossRushRelicNodeModel> onUpgradeClicked
		{
			[Token(Token = "0x6024026")]
			[Address(RVA = "0x1EA5800", Offset = "0x1EA4400", VA = "0x181EA5800")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024027")]
			[Address(RVA = "0x1EA58E0", Offset = "0x1EA44E0", VA = "0x181EA58E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170054FE RID: 21758
		// (get) Token: 0x06024028 RID: 147496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024029 RID: 147497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054FE")]
		public Action<BossRushRelicNodeModel> onRelicClicked
		{
			[Token(Token = "0x6024028")]
			[Address(RVA = "0x1EA57A0", Offset = "0x1EA43A0", VA = "0x181EA57A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024029")]
			[Address(RVA = "0x1EA5860", Offset = "0x1EA4460", VA = "0x181EA5860")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602402A RID: 147498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602402A")]
		[Address(RVA = "0x1EA4ED0", Offset = "0x1EA3AD0", VA = "0x181EA4ED0")]
		public void Render(string aId, BossRushRelicNodeModel model, Action<BossRushRelicNodeModel> upgrade, Action<BossRushRelicNodeModel> select, int tickNum, int position)
		{
		}

		// Token: 0x0602402B RID: 147499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602402B")]
		[Address(RVA = "0x1EA4D20", Offset = "0x1EA3920", VA = "0x181EA4D20")]
		public void RenderSelect(BossRushRelicNodeModel model)
		{
		}

		// Token: 0x0602402C RID: 147500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602402C")]
		[Address(RVA = "0x1EA5360", Offset = "0x1EA3F60", VA = "0x181EA5360")]
		private void _InitIfNot(string aId, Action<BossRushRelicNodeModel> upgrade, Action<BossRushRelicNodeModel> select)
		{
		}

		// Token: 0x0602402D RID: 147501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602402D")]
		[Address(RVA = "0x1EA4C10", Offset = "0x1EA3810", VA = "0x181EA4C10")]
		public void EventOnUpgradeClicked()
		{
		}

		// Token: 0x0602402E RID: 147502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602402E")]
		[Address(RVA = "0x1EA4B30", Offset = "0x1EA3730", VA = "0x181EA4B30")]
		public void EventOnRelicClick()
		{
		}

		// Token: 0x0602402F RID: 147503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602402F")]
		[Address(RVA = "0x1EA5730", Offset = "0x1EA4330", VA = "0x181EA5730")]
		public BossRushRelicNodeView()
		{
		}

		// Token: 0x0403206C RID: 204908
		[Token(Token = "0x403206C")]
		private const float ENTER_ANIM_DELAY = 0.083f;

		// Token: 0x0403206D RID: 204909
		[Token(Token = "0x403206D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objUpgradePart;

		// Token: 0x0403206E RID: 204910
		[Token(Token = "0x403206E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objMaxPart;

		// Token: 0x0403206F RID: 204911
		[Token(Token = "0x403206F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objUpBg;

		// Token: 0x04032070 RID: 204912
		[Token(Token = "0x4032070")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objLackBg;

		// Token: 0x04032071 RID: 204913
		[Token(Token = "0x4032071")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _sliderLevelProgress;

		// Token: 0x04032072 RID: 204914
		[Token(Token = "0x4032072")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _btnUpgrade;

		// Token: 0x04032073 RID: 204915
		[Token(Token = "0x4032073")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("unlock State")]
		private GameObject[] _unLockState;

		// Token: 0x04032074 RID: 204916
		[Token(Token = "0x4032074")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("lock State")]
		private GameObject[] _lockState;

		// Token: 0x04032075 RID: 204917
		[Token(Token = "0x4032075")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgRelicIcon;

		// Token: 0x04032076 RID: 204918
		[Token(Token = "0x4032076")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x04032077 RID: 204919
		[Token(Token = "0x4032077")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtLockName;

		// Token: 0x04032078 RID: 204920
		[Token(Token = "0x4032078")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtLevel;

		// Token: 0x04032079 RID: 204921
		[Token(Token = "0x4032079")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _txtDes;

		// Token: 0x0403207A RID: 204922
		[Token(Token = "0x403207A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _txtDesLock;

		// Token: 0x0403207B RID: 204923
		[Token(Token = "0x403207B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UICommonTrackPoint _relicTrackPoint;

		// Token: 0x0403207C RID: 204924
		[Token(Token = "0x403207C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0403207D RID: 204925
		[Token(Token = "0x403207D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04032080 RID: 204928
		[Token(Token = "0x4032080")]
		[FieldOffset(Offset = "0xC0")]
		private BossRushRelicNodeModel m_relicNodeModel;

		// Token: 0x04032081 RID: 204929
		[Token(Token = "0x4032081")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x04032082 RID: 204930
		[Token(Token = "0x4032082")]
		[FieldOffset(Offset = "0xD0")]
		private string m_actId;

		// Token: 0x04032083 RID: 204931
		[Token(Token = "0x4032083")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationSwitchTween m_relicSelectSwitchTween;

		// Token: 0x04032084 RID: 204932
		[Token(Token = "0x4032084")]
		[FieldOffset(Offset = "0xE0")]
		private TrackPointViewProperty m_trackPointProp;

		// Token: 0x04032085 RID: 204933
		[Token(Token = "0x4032085")]
		[FieldOffset(Offset = "0xE8")]
		private float m_selectTweenDuration;

		// Token: 0x04032086 RID: 204934
		[Token(Token = "0x4032086")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_enterTween;

		// Token: 0x04032087 RID: 204935
		[Token(Token = "0x4032087")]
		[FieldOffset(Offset = "0xF8")]
		private int m_cachedEnterAnimTick;

		// Token: 0x04032088 RID: 204936
		[Token(Token = "0x4032088")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onUpgradeClicked;

		// Token: 0x04032089 RID: 204937
		[Token(Token = "0x4032089")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onUpgradeClicked;

		// Token: 0x0403208A RID: 204938
		[Token(Token = "0x403208A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onRelicClicked;

		// Token: 0x0403208B RID: 204939
		[Token(Token = "0x403208B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onRelicClicked;

		// Token: 0x0403208C RID: 204940
		[Token(Token = "0x403208C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403208D RID: 204941
		[Token(Token = "0x403208D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderSelect;

		// Token: 0x0403208E RID: 204942
		[Token(Token = "0x403208E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403208F RID: 204943
		[Token(Token = "0x403208F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnUpgradeClicked;

		// Token: 0x04032090 RID: 204944
		[Token(Token = "0x4032090")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnRelicClick;

		// Token: 0x04032091 RID: 204945
		[Token(Token = "0x4032091")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006183 RID: 24963
		[Token(Token = "0x2006183")]
		private class BossRushRelicTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x170054FF RID: 21759
			// (get) Token: 0x06024030 RID: 147504 RVA: 0x000C2C58 File Offset: 0x000C0E58
			[Token(Token = "0x170054FF")]
			public bool isShow
			{
				[Token(Token = "0x6024030")]
				[Address(RVA = "0x1EA7CA0", Offset = "0x1EA68A0", VA = "0x181EA7CA0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06024031 RID: 147505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024031")]
			[Address(RVA = "0x1EA7B50", Offset = "0x1EA6750", VA = "0x181EA7B50", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x06024032 RID: 147506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024032")]
			[Address(RVA = "0x1EA7C40", Offset = "0x1EA6840", VA = "0x181EA7C40")]
			public BossRushRelicTrackPointModel()
			{
			}

			// Token: 0x04032092 RID: 204946
			[Token(Token = "0x4032092")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x04032093 RID: 204947
			[Token(Token = "0x4032093")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04032094 RID: 204948
			[Token(Token = "0x4032094")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04032095 RID: 204949
			[Token(Token = "0x4032095")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02006184 RID: 24964
			[Token(Token = "0x2006184")]
			public class Input
			{
				// Token: 0x06024033 RID: 147507 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6024033")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Input()
				{
				}

				// Token: 0x04032096 RID: 204950
				[Token(Token = "0x4032096")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x04032097 RID: 204951
				[Token(Token = "0x4032097")]
				[FieldOffset(Offset = "0x18")]
				public string relicId;
			}
		}
	}
}
