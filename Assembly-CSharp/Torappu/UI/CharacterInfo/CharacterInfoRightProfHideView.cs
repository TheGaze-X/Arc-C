using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F99 RID: 24473
	[Token(Token = "0x2005F99")]
	public class CharacterInfoRightProfHideView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023686 RID: 145030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023686")]
		[Address(RVA = "0x1E06020", Offset = "0x1E04C20", VA = "0x181E06020")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023687 RID: 145031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023687")]
		[Address(RVA = "0x1E05A70", Offset = "0x1E04670", VA = "0x181E05A70")]
		public void Render(CharacterInfoHolderBean.CharViewModel viewModel)
		{
		}

		// Token: 0x06023688 RID: 145032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023688")]
		[Address(RVA = "0x1E06120", Offset = "0x1E04D20", VA = "0x181E06120")]
		public CharacterInfoRightProfHideView()
		{
		}

		// Token: 0x04030EB4 RID: 200372
		[Token(Token = "0x4030EB4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _subProfImg;

		// Token: 0x04030EB5 RID: 200373
		[Token(Token = "0x4030EB5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _subProfName;

		// Token: 0x04030EB6 RID: 200374
		[Token(Token = "0x4030EB6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _noUniequipPart;

		// Token: 0x04030EB7 RID: 200375
		[Token(Token = "0x4030EB7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _haveUniequipPart;

		// Token: 0x04030EB8 RID: 200376
		[Token(Token = "0x4030EB8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockedUniequipPart;

		// Token: 0x04030EB9 RID: 200377
		[Token(Token = "0x4030EB9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonEquipTypeIcon _commonIcon;

		// Token: 0x04030EBA RID: 200378
		[Token(Token = "0x4030EBA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _commonIconContainer;

		// Token: 0x04030EBB RID: 200379
		[Token(Token = "0x4030EBB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _uniequipLevel;

		// Token: 0x04030EBC RID: 200380
		[Token(Token = "0x4030EBC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterInfoTalentGroup _contentGroup;

		// Token: 0x04030EBD RID: 200381
		[Token(Token = "0x4030EBD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x04030EBE RID: 200382
		[Token(Token = "0x4030EBE")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_missionTrackPointProp;

		// Token: 0x04030EBF RID: 200383
		[Token(Token = "0x4030EBF")]
		[FieldOffset(Offset = "0x70")]
		private UICommonEquipTypeIcon m_icon;

		// Token: 0x04030EC0 RID: 200384
		[Token(Token = "0x4030EC0")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04030EC1 RID: 200385
		[Token(Token = "0x4030EC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030EC2 RID: 200386
		[Token(Token = "0x4030EC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030EC3 RID: 200387
		[Token(Token = "0x4030EC3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
