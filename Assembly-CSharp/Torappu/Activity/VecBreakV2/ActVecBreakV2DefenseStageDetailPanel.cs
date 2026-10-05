using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E17 RID: 28183
	[Token(Token = "0x2006E17")]
	public class ActVecBreakV2DefenseStageDetailPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060281E8 RID: 164328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281E8")]
		[Address(RVA = "0x23651E0", Offset = "0x2363DE0", VA = "0x1823651E0")]
		public void Render(ActVecBreakV2DefenseStageSelectViewModel viewModel)
		{
		}

		// Token: 0x060281E9 RID: 164329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281E9")]
		[Address(RVA = "0x2365BD0", Offset = "0x23647D0", VA = "0x182365BD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060281EA RID: 164330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281EA")]
		[Address(RVA = "0x2365E70", Offset = "0x2364A70", VA = "0x182365E70")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x060281EB RID: 164331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281EB")]
		[Address(RVA = "0x2365AE0", Offset = "0x23646E0", VA = "0x182365AE0")]
		private void _EventOnRemoveSquadClick(string stageId)
		{
		}

		// Token: 0x060281EC RID: 164332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281EC")]
		[Address(RVA = "0x2365030", Offset = "0x2363C30", VA = "0x182365030")]
		public void EventOpenMapPreview()
		{
		}

		// Token: 0x060281ED RID: 164333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281ED")]
		[Address(RVA = "0x2364FA0", Offset = "0x2363BA0", VA = "0x182364FA0")]
		public void EventOpenEnemyHandbook()
		{
		}

		// Token: 0x060281EE RID: 164334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281EE")]
		[Address(RVA = "0x23650C0", Offset = "0x2363CC0", VA = "0x1823650C0")]
		public void EventOpenSquad()
		{
		}

		// Token: 0x060281EF RID: 164335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281EF")]
		[Address(RVA = "0x2364E30", Offset = "0x2363A30", VA = "0x182364E30")]
		public void EventActiveBuff()
		{
		}

		// Token: 0x060281F0 RID: 164336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F0")]
		[Address(RVA = "0x2364EC0", Offset = "0x2363AC0", VA = "0x182364EC0")]
		public void EventInactiveBuff()
		{
		}

		// Token: 0x060281F1 RID: 164337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F1")]
		[Address(RVA = "0x2365150", Offset = "0x2363D50", VA = "0x182365150")]
		public void NotifyBuffExceed()
		{
		}

		// Token: 0x060281F2 RID: 164338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281F2")]
		[Address(RVA = "0x2366040", Offset = "0x2364C40", VA = "0x182366040")]
		public ActVecBreakV2DefenseStageDetailPanel()
		{
		}

		// Token: 0x04038F08 RID: 233224
		[Token(Token = "0x4038F08")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Upper")]
		private Image _bossIcon;

		// Token: 0x04038F09 RID: 233225
		[Token(Token = "0x4038F09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Upper")]
		private GameObject _bossDecorHideWhenComplete;

		// Token: 0x04038F0A RID: 233226
		[Token(Token = "0x4038F0A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Upper")]
		private Text _stageName;

		// Token: 0x04038F0B RID: 233227
		[Token(Token = "0x4038F0B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Upper")]
		private Text _stageCode;

		// Token: 0x04038F0C RID: 233228
		[Token(Token = "0x4038F0C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Upper")]
		private Text _stageDesc;

		// Token: 0x04038F0D RID: 233229
		[Token(Token = "0x4038F0D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Upper")]
		private Color _bossIconComplete;

		// Token: 0x04038F0E RID: 233230
		[Token(Token = "0x4038F0E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Upper")]
		private Color _bossIconNotComplete;

		// Token: 0x04038F0F RID: 233231
		[Token(Token = "0x4038F0F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private GameObject _panelNotComplete;

		// Token: 0x04038F10 RID: 233232
		[Token(Token = "0x4038F10")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private Image _buffIconNotComplete;

		// Token: 0x04038F11 RID: 233233
		[Token(Token = "0x4038F11")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private Text _buffNameNotComplete;

		// Token: 0x04038F12 RID: 233234
		[Token(Token = "0x4038F12")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private Text _buffDescNotComplete;

		// Token: 0x04038F13 RID: 233235
		[Token(Token = "0x4038F13")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private GameObject _normalReward;

		// Token: 0x04038F14 RID: 233236
		[Token(Token = "0x4038F14")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private Text _normalRewardNum;

		// Token: 0x04038F15 RID: 233237
		[Token(Token = "0x4038F15")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private GameObject _timeLimitReward;

		// Token: 0x04038F16 RID: 233238
		[Token(Token = "0x4038F16")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private Text _timeLimitRewardNum;

		// Token: 0x04038F17 RID: 233239
		[Token(Token = "0x4038F17")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private GameObject _rewardList;

		// Token: 0x04038F18 RID: 233240
		[Token(Token = "0x4038F18")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private Text _unlockCondition;

		// Token: 0x04038F19 RID: 233241
		[Token(Token = "0x4038F19")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private Image _rewardIcon;

		// Token: 0x04038F1A RID: 233242
		[Token(Token = "0x4038F1A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private TwoStateToggle _stageLockToggle;

		// Token: 0x04038F1B RID: 233243
		[Token(Token = "0x4038F1B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private GameObject[] _lockPeopleIcon;

		// Token: 0x04038F1C RID: 233244
		[Token(Token = "0x4038F1C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private GameObject[] _startBattlePeopleIcon;

		// Token: 0x04038F1D RID: 233245
		[Token(Token = "0x4038F1D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Lower Not Complete")]
		private GameObject _useBasicStageHint;

		// Token: 0x04038F1E RID: 233246
		[Token(Token = "0x4038F1E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Lower Complete")]
		private GameObject _panelComplete;

		// Token: 0x04038F1F RID: 233247
		[Token(Token = "0x4038F1F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Lower Complete")]
		private Image _buffIconComplete;

		// Token: 0x04038F20 RID: 233248
		[Token(Token = "0x4038F20")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Lower Complete")]
		private Text _buffNameComplete;

		// Token: 0x04038F21 RID: 233249
		[Token(Token = "0x4038F21")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Lower Complete")]
		private Text _buffDescComplete;

		// Token: 0x04038F22 RID: 233250
		[Token(Token = "0x4038F22")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Lower Complete")]
		private RectTransform _charSlotListContainer;

		// Token: 0x04038F23 RID: 233251
		[Token(Token = "0x4038F23")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Lower Complete")]
		private ActVecBreakV2DefenseCharListView _charSlotListPrefab;

		// Token: 0x04038F24 RID: 233252
		[Token(Token = "0x4038F24")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Lower Complete")]
		private GameObject _buffSelected;

		// Token: 0x04038F25 RID: 233253
		[Token(Token = "0x4038F25")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Lower Complete")]
		private GameObject _buffUnselected;

		// Token: 0x04038F26 RID: 233254
		[Token(Token = "0x4038F26")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Lower Complete")]
		private GameObject _buffCannotSelect;

		// Token: 0x04038F27 RID: 233255
		[Token(Token = "0x4038F27")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _defenseBuffAreaGO;

		// Token: 0x04038F28 RID: 233256
		[Token(Token = "0x4038F28")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _defenseEnemyAreaGO;

		// Token: 0x04038F29 RID: 233257
		[Token(Token = "0x4038F29")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _defenseDetailAreaGO;

		// Token: 0x04038F2A RID: 233258
		[Token(Token = "0x4038F2A")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _defenseBtnStartGO;

		// Token: 0x04038F2B RID: 233259
		[Token(Token = "0x4038F2B")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _defenseBtnOverviewGO;

		// Token: 0x04038F2C RID: 233260
		[Token(Token = "0x4038F2C")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private UIAnimationLocation _stageSelectAnim;

		// Token: 0x04038F2D RID: 233261
		[Token(Token = "0x4038F2D")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private UIAnimationLocation _buffSelectDecorAnim;

		// Token: 0x04038F2E RID: 233262
		[Token(Token = "0x4038F2E")]
		[FieldOffset(Offset = "0x168")]
		private UISwitchTween m_stageSelectTween;

		// Token: 0x04038F2F RID: 233263
		[Token(Token = "0x4038F2F")]
		[FieldOffset(Offset = "0x170")]
		private UISwitchTween m_buffSelectTween;

		// Token: 0x04038F30 RID: 233264
		[Token(Token = "0x4038F30")]
		[FieldOffset(Offset = "0x178")]
		private bool m_hasInited;

		// Token: 0x04038F31 RID: 233265
		[Token(Token = "0x4038F31")]
		[FieldOffset(Offset = "0x180")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04038F32 RID: 233266
		[Token(Token = "0x4038F32")]
		[FieldOffset(Offset = "0x190")]
		private ActVecBreakV2DefenseCharListView m_defenseCharView;

		// Token: 0x04038F33 RID: 233267
		[Token(Token = "0x4038F33")]
		[FieldOffset(Offset = "0x198")]
		private int m_cacheSelectStageSeqNum;

		// Token: 0x04038F34 RID: 233268
		[Token(Token = "0x4038F34")]
		[FieldOffset(Offset = "0x19C")]
		private int m_cacheEnterStateSeqNum;

		// Token: 0x04038F35 RID: 233269
		[Token(Token = "0x4038F35")]
		[FieldOffset(Offset = "0x1A0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04038F36 RID: 233270
		[Token(Token = "0x4038F36")]
		[FieldOffset(Offset = "0x1B0")]
		private string m_stageBuffId;

		// Token: 0x04038F37 RID: 233271
		[Token(Token = "0x4038F37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038F38 RID: 233272
		[Token(Token = "0x4038F38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038F39 RID: 233273
		[Token(Token = "0x4038F39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x04038F3A RID: 233274
		[Token(Token = "0x4038F3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnRemoveSquadClick;

		// Token: 0x04038F3B RID: 233275
		[Token(Token = "0x4038F3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOpenMapPreview;

		// Token: 0x04038F3C RID: 233276
		[Token(Token = "0x4038F3C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOpenEnemyHandbook;

		// Token: 0x04038F3D RID: 233277
		[Token(Token = "0x4038F3D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOpenSquad;

		// Token: 0x04038F3E RID: 233278
		[Token(Token = "0x4038F3E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventActiveBuff;

		// Token: 0x04038F3F RID: 233279
		[Token(Token = "0x4038F3F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventInactiveBuff;

		// Token: 0x04038F40 RID: 233280
		[Token(Token = "0x4038F40")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_NotifyBuffExceed;

		// Token: 0x04038F41 RID: 233281
		[Token(Token = "0x4038F41")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
