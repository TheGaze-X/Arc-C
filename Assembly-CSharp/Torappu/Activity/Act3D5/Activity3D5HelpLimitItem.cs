using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D5
{
	// Token: 0x020073C7 RID: 29639
	[Token(Token = "0x20073C7")]
	internal class Activity3D5HelpLimitItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029DF1 RID: 171505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DF1")]
		[Address(RVA = "0x257CE10", Offset = "0x257BA10", VA = "0x18257CE10")]
		public void Refresh(MissionData missionData)
		{
		}

		// Token: 0x170062D4 RID: 25300
		// (get) Token: 0x06029DF2 RID: 171506 RVA: 0x000D6DB8 File Offset: 0x000D4FB8
		[Token(Token = "0x170062D4")]
		public bool finish
		{
			[Token(Token = "0x6029DF2")]
			[Address(RVA = "0x257D7A0", Offset = "0x257C3A0", VA = "0x18257D7A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170062D5 RID: 25301
		// (get) Token: 0x06029DF3 RID: 171507 RVA: 0x000D6DD0 File Offset: 0x000D4FD0
		[Token(Token = "0x170062D5")]
		public int sortId
		{
			[Token(Token = "0x6029DF3")]
			[Address(RVA = "0x257D800", Offset = "0x257C400", VA = "0x18257D800")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06029DF4 RID: 171508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DF4")]
		[Address(RVA = "0x257D740", Offset = "0x257C340", VA = "0x18257D740")]
		public Activity3D5HelpLimitItem()
		{
		}

		// Token: 0x0403C021 RID: 245793
		[Token(Token = "0x403C021")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _complete;

		// Token: 0x0403C022 RID: 245794
		[Token(Token = "0x403C022")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _requirement;

		// Token: 0x0403C023 RID: 245795
		[Token(Token = "0x403C023")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _flagIcon;

		// Token: 0x0403C024 RID: 245796
		[Token(Token = "0x403C024")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _itemBG;

		// Token: 0x0403C025 RID: 245797
		[Token(Token = "0x403C025")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403C026 RID: 245798
		[Token(Token = "0x403C026")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _prgBG;

		// Token: 0x0403C027 RID: 245799
		[Token(Token = "0x403C027")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _prgCntLabel;

		// Token: 0x0403C028 RID: 245800
		[Token(Token = "0x403C028")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Slider _prg;

		// Token: 0x0403C029 RID: 245801
		[Token(Token = "0x403C029")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _statusLabel;

		// Token: 0x0403C02A RID: 245802
		[Token(Token = "0x403C02A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _rewardCntLabel;

		// Token: 0x0403C02B RID: 245803
		[Token(Token = "0x403C02B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _rewardIconRoot;

		// Token: 0x0403C02C RID: 245804
		[Token(Token = "0x403C02C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _gotMark;

		// Token: 0x0403C02D RID: 245805
		[Token(Token = "0x403C02D")]
		[FieldOffset(Offset = "0x78")]
		private bool m_finish;

		// Token: 0x0403C02E RID: 245806
		[Token(Token = "0x403C02E")]
		[FieldOffset(Offset = "0x7C")]
		private int m_sortId;

		// Token: 0x0403C02F RID: 245807
		[Token(Token = "0x403C02F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403C030 RID: 245808
		[Token(Token = "0x403C030")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_finish;

		// Token: 0x0403C031 RID: 245809
		[Token(Token = "0x403C031")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0403C032 RID: 245810
		[Token(Token = "0x403C032")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
