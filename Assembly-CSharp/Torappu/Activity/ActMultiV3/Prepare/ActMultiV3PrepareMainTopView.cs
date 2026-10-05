using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007050 RID: 28752
	[Token(Token = "0x2007050")]
	public class ActMultiV3PrepareMainTopView : ActMultiV3PrepareMainAnimViewBase, IPingListener
	{
		// Token: 0x06028D1C RID: 167196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D1C")]
		[Address(RVA = "0x2446670", Offset = "0x2445270", VA = "0x182446670", Slot = "7")]
		public override void OnValueChanged(ActMultiV3PrepareMainViewModelProperty property)
		{
		}

		// Token: 0x06028D1D RID: 167197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D1D")]
		[Address(RVA = "0x2446A40", Offset = "0x2445640", VA = "0x182446A40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028D1E RID: 167198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D1E")]
		[Address(RVA = "0x2446930", Offset = "0x2445530", VA = "0x182446930", Slot = "8")]
		public void UpdatePing(int ping)
		{
		}

		// Token: 0x06028D1F RID: 167199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D1F")]
		[Address(RVA = "0x2446E80", Offset = "0x2445A80", VA = "0x182446E80")]
		private void _UpdateCD()
		{
		}

		// Token: 0x06028D20 RID: 167200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D20")]
		[Address(RVA = "0x2446B70", Offset = "0x2445770", VA = "0x182446B70")]
		private void _SetCDNum(int num)
		{
		}

		// Token: 0x06028D21 RID: 167201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D21")]
		[Address(RVA = "0x2446D50", Offset = "0x2445950", VA = "0x182446D50")]
		private void _SetCDPrg(float prgValue)
		{
		}

		// Token: 0x06028D22 RID: 167202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D22")]
		[Address(RVA = "0x24464C0", Offset = "0x24450C0", VA = "0x1824464C0")]
		public void EventOnExit()
		{
		}

		// Token: 0x06028D23 RID: 167203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D23")]
		[Address(RVA = "0x2446550", Offset = "0x2445150", VA = "0x182446550")]
		public void EventOnReturn()
		{
		}

		// Token: 0x06028D24 RID: 167204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D24")]
		[Address(RVA = "0x24465E0", Offset = "0x24451E0", VA = "0x1824465E0")]
		public void EventOnStageDetail()
		{
		}

		// Token: 0x06028D25 RID: 167205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D25")]
		[Address(RVA = "0x24471B0", Offset = "0x2445DB0", VA = "0x1824471B0")]
		public ActMultiV3PrepareMainTopView()
		{
		}

		// Token: 0x0403A382 RID: 238466
		[Token(Token = "0x403A382")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _btnReturn;

		// Token: 0x0403A383 RID: 238467
		[Token(Token = "0x403A383")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _space;

		// Token: 0x0403A384 RID: 238468
		[Token(Token = "0x403A384")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _invertTipObj;

		// Token: 0x0403A385 RID: 238469
		[Token(Token = "0x403A385")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _pingLabel;

		// Token: 0x0403A386 RID: 238470
		[Token(Token = "0x403A386")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("CountDown")]
		private TwoStateFadeSwitcher _cdState;

		// Token: 0x0403A387 RID: 238471
		[Token(Token = "0x403A387")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("CountDown")]
		private Image[] _cdPrgs;

		// Token: 0x0403A388 RID: 238472
		[Token(Token = "0x403A388")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("CountDown")]
		private Text[] _cdNums;

		// Token: 0x0403A389 RID: 238473
		[Token(Token = "0x403A389")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("CountDown")]
		private int _oneDigitFontSize;

		// Token: 0x0403A38A RID: 238474
		[Token(Token = "0x403A38A")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Group("CountDown")]
		private int _otherFontSize;

		// Token: 0x0403A38B RID: 238475
		[Token(Token = "0x403A38B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("CountDown")]
		private UIAnimationLocation _emergencyAnim;

		// Token: 0x0403A38C RID: 238476
		[Token(Token = "0x403A38C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("StageInfo")]
		private Text _stageCode;

		// Token: 0x0403A38D RID: 238477
		[Token(Token = "0x403A38D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("StageInfo")]
		private Text _stageName;

		// Token: 0x0403A38E RID: 238478
		[Token(Token = "0x403A38E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("StageInfo")]
		private Transform _diffIconContainer;

		// Token: 0x0403A38F RID: 238479
		[Token(Token = "0x403A38F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("StageInfo")]
		private ActMultiV3DifficultyIconView _diffIconPrefab;

		// Token: 0x0403A390 RID: 238480
		[Token(Token = "0x403A390")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("StageInfo")]
		private float _diffIconScale;

		// Token: 0x0403A391 RID: 238481
		[Token(Token = "0x403A391")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObjectClusterActive _hideInEntrance;

		// Token: 0x0403A392 RID: 238482
		[Token(Token = "0x403A392")]
		[FieldOffset(Offset = "0xB8")]
		private ActMultiV3DifficultyIconView m_diffIcon;

		// Token: 0x0403A393 RID: 238483
		[Token(Token = "0x403A393")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_finder;

		// Token: 0x0403A394 RID: 238484
		[Token(Token = "0x403A394")]
		[FieldOffset(Offset = "0xD0")]
		private ActMultiV3PrepareMainViewModelProperty m_cachedProp;

		// Token: 0x0403A395 RID: 238485
		[Token(Token = "0x403A395")]
		[FieldOffset(Offset = "0xD8")]
		private ActMultiV3PrepareMainViewModel.StepCDInfo m_cdParam;

		// Token: 0x0403A396 RID: 238486
		[Token(Token = "0x403A396")]
		[FieldOffset(Offset = "0xE8")]
		private int m_curSecNum;

		// Token: 0x0403A397 RID: 238487
		[Token(Token = "0x403A397")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A398 RID: 238488
		[Token(Token = "0x403A398")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A399 RID: 238489
		[Token(Token = "0x403A399")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdatePing;

		// Token: 0x0403A39A RID: 238490
		[Token(Token = "0x403A39A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateCD;

		// Token: 0x0403A39B RID: 238491
		[Token(Token = "0x403A39B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetCDNum;

		// Token: 0x0403A39C RID: 238492
		[Token(Token = "0x403A39C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetCDPrg;

		// Token: 0x0403A39D RID: 238493
		[Token(Token = "0x403A39D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnExit;

		// Token: 0x0403A39E RID: 238494
		[Token(Token = "0x403A39E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnReturn;

		// Token: 0x0403A39F RID: 238495
		[Token(Token = "0x403A39F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnStageDetail;

		// Token: 0x0403A3A0 RID: 238496
		[Token(Token = "0x403A3A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
