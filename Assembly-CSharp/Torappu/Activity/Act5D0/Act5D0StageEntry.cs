using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071DF RID: 29151
	[Token(Token = "0x20071DF")]
	public class Act5D0StageEntry : ActivityStageSingleComponent
	{
		// Token: 0x060295C0 RID: 169408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C0")]
		[Address(RVA = "0x24ACD60", Offset = "0x24AB960", VA = "0x1824ACD60")]
		private void OnEnable()
		{
		}

		// Token: 0x060295C1 RID: 169409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C1")]
		[Address(RVA = "0x24ACC70", Offset = "0x24AB870", VA = "0x1824ACC70")]
		public void NotifyBackToFloatEmptyState()
		{
		}

		// Token: 0x060295C2 RID: 169410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C2")]
		[Address(RVA = "0x24ACCF0", Offset = "0x24AB8F0", VA = "0x1824ACCF0", Slot = "6")]
		protected override void OnBindToParent()
		{
		}

		// Token: 0x060295C3 RID: 169411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C3")]
		[Address(RVA = "0x24ACDC0", Offset = "0x24AB9C0", VA = "0x1824ACDC0", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x060295C4 RID: 169412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C4")]
		[Address(RVA = "0x24ADF40", Offset = "0x24ACB40", VA = "0x1824ADF40")]
		private void _TryPlayAni()
		{
		}

		// Token: 0x060295C5 RID: 169413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C5")]
		[Address(RVA = "0x24ADD00", Offset = "0x24AC900", VA = "0x1824ADD00")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x060295C6 RID: 169414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C6")]
		[Address(RVA = "0x24ACE40", Offset = "0x24ABA40", VA = "0x1824ACE40")]
		private void _InitData()
		{
		}

		// Token: 0x060295C7 RID: 169415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C7")]
		[Address(RVA = "0x24AE100", Offset = "0x24ACD00", VA = "0x1824AE100")]
		public Act5D0StageEntry()
		{
		}

		// Token: 0x060295C8 RID: 169416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C8")]
		[Address(RVA = "0x22DDCD0", Offset = "0x22DC8D0", VA = "0x1822DDCD0")]
		private void <>xLuaBaseProxy_OnBindToParent()
		{
		}

		// Token: 0x060295C9 RID: 169417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295C9")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0403B10D RID: 241933
		[Token(Token = "0x403B10D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIActTrackPoint _mileStoneTrackPoint;

		// Token: 0x0403B10E RID: 241934
		[Token(Token = "0x403B10E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _topMenuContainer;

		// Token: 0x0403B10F RID: 241935
		[Token(Token = "0x403B10F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _actTime;

		// Token: 0x0403B110 RID: 241936
		[Token(Token = "0x403B110")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _actDesc;

		// Token: 0x0403B111 RID: 241937
		[Token(Token = "0x403B111")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animator _brushAnim;

		// Token: 0x0403B112 RID: 241938
		[Token(Token = "0x403B112")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _actLeftTime;

		// Token: 0x0403B113 RID: 241939
		[Token(Token = "0x403B113")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _mileStoneToken;

		// Token: 0x0403B114 RID: 241940
		[Token(Token = "0x403B114")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _exBlock;

		// Token: 0x0403B115 RID: 241941
		[Token(Token = "0x403B115")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Animator _animMission;

		// Token: 0x0403B116 RID: 241942
		[Token(Token = "0x403B116")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Animator _animMilestone;

		// Token: 0x0403B117 RID: 241943
		[Token(Token = "0x403B117")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator _animBrush;

		// Token: 0x0403B118 RID: 241944
		[Token(Token = "0x403B118")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Animator _animBlink;

		// Token: 0x0403B119 RID: 241945
		[Token(Token = "0x403B119")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Animator _animToDowntown;

		// Token: 0x0403B11A RID: 241946
		[Token(Token = "0x403B11A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Animator _animToEx;

		// Token: 0x0403B11B RID: 241947
		[Token(Token = "0x403B11B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Animator _animBlockToEx;

		// Token: 0x0403B11C RID: 241948
		[Token(Token = "0x403B11C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Animator _animRetro;

		// Token: 0x0403B11D RID: 241949
		[Token(Token = "0x403B11D")]
		[FieldOffset(Offset = "0xA0")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403B11E RID: 241950
		[Token(Token = "0x403B11E")]
		private const string START_ANIM_KEY = "Start";

		// Token: 0x0403B11F RID: 241951
		[Token(Token = "0x403B11F")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isLoaded;

		// Token: 0x0403B120 RID: 241952
		[Token(Token = "0x403B120")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_isBindedToParent;

		// Token: 0x0403B121 RID: 241953
		[Token(Token = "0x403B121")]
		[FieldOffset(Offset = "0xB0")]
		private TrackPointViewProperty m_mileStoneRedPoint;

		// Token: 0x0403B122 RID: 241954
		[Token(Token = "0x403B122")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x0403B123 RID: 241955
		[Token(Token = "0x403B123")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403B124 RID: 241956
		[Token(Token = "0x403B124")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyBackToFloatEmptyState;

		// Token: 0x0403B125 RID: 241957
		[Token(Token = "0x403B125")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBindToParent;

		// Token: 0x0403B126 RID: 241958
		[Token(Token = "0x403B126")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403B127 RID: 241959
		[Token(Token = "0x403B127")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryPlayAni;

		// Token: 0x0403B128 RID: 241960
		[Token(Token = "0x403B128")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403B129 RID: 241961
		[Token(Token = "0x403B129")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0403B12A RID: 241962
		[Token(Token = "0x403B12A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
