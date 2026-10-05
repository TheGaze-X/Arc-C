using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C15 RID: 7189
	[Token(Token = "0x2001C15")]
	public class BuildingTrainingTrainerStatusView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B33F RID: 45887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B33F")]
		[Address(RVA = "0x32E1B10", Offset = "0x32E0710", VA = "0x1832E1B10")]
		public void InitData(RoomSlotModel trainingSlot)
		{
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B340")]
		[Address(RVA = "0x32E23E0", Offset = "0x32E0FE0", VA = "0x1832E23E0")]
		private void Update()
		{
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B341")]
		[Address(RVA = "0x32E22E0", Offset = "0x32E0EE0", VA = "0x1832E22E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600B342 RID: 45890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B342")]
		[Address(RVA = "0x32E2450", Offset = "0x32E1050", VA = "0x1832E2450")]
		private void _Init()
		{
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B343")]
		[Address(RVA = "0x32E2580", Offset = "0x32E1180", VA = "0x1832E2580")]
		private void _OnManpowerChanged()
		{
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B344")]
		[Address(RVA = "0x32E2870", Offset = "0x32E1470", VA = "0x1832E2870")]
		private IEnumerator _UpdateAutoLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B345")]
		[Address(RVA = "0x32E2920", Offset = "0x32E1520", VA = "0x1832E2920")]
		public BuildingTrainingTrainerStatusView()
		{
		}

		// Token: 0x0400AE82 RID: 44674
		[Token(Token = "0x400AE82")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _trainerPortrait;

		// Token: 0x0400AE83 RID: 44675
		[Token(Token = "0x400AE83")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _mpContainer;

		// Token: 0x0400AE84 RID: 44676
		[Token(Token = "0x400AE84")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingCharMPStateBar _mpBarPrefab;

		// Token: 0x0400AE85 RID: 44677
		[Token(Token = "0x400AE85")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingBuffDescView _buffView;

		// Token: 0x0400AE86 RID: 44678
		[Token(Token = "0x400AE86")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _panelMpLayout;

		// Token: 0x0400AE87 RID: 44679
		[Token(Token = "0x400AE87")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCurAp;

		// Token: 0x0400AE88 RID: 44680
		[Token(Token = "0x400AE88")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textMaxAp;

		// Token: 0x0400AE89 RID: 44681
		[Token(Token = "0x400AE89")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorMpNormal;

		// Token: 0x0400AE8A RID: 44682
		[Token(Token = "0x400AE8A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorMpTired;

		// Token: 0x0400AE8B RID: 44683
		[Token(Token = "0x400AE8B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _bkgMp;

		// Token: 0x0400AE8C RID: 44684
		[Token(Token = "0x400AE8C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelTired;

		// Token: 0x0400AE8D RID: 44685
		[Token(Token = "0x400AE8D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0400AE8E RID: 44686
		[Token(Token = "0x400AE8E")]
		[FieldOffset(Offset = "0x88")]
		private BuildingCharModel m_cachedTrainer;

		// Token: 0x0400AE8F RID: 44687
		[Token(Token = "0x400AE8F")]
		[FieldOffset(Offset = "0x100")]
		private BuildingCharMPHelper m_mpHelper;

		// Token: 0x0400AE90 RID: 44688
		[Token(Token = "0x400AE90")]
		[FieldOffset(Offset = "0x108")]
		private BuildingCharMPStateBar m_mpBar;

		// Token: 0x0400AE91 RID: 44689
		[Token(Token = "0x400AE91")]
		[FieldOffset(Offset = "0x110")]
		private List<BuildingBuffDescStruct> m_buffs;

		// Token: 0x0400AE92 RID: 44690
		[Token(Token = "0x400AE92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0400AE93 RID: 44691
		[Token(Token = "0x400AE93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400AE94 RID: 44692
		[Token(Token = "0x400AE94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400AE95 RID: 44693
		[Token(Token = "0x400AE95")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400AE96 RID: 44694
		[Token(Token = "0x400AE96")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnManpowerChanged;

		// Token: 0x0400AE97 RID: 44695
		[Token(Token = "0x400AE97")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayoutCoroutine;

		// Token: 0x0400AE98 RID: 44696
		[Token(Token = "0x400AE98")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
