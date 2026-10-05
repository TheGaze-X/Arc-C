using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Info
{
	// Token: 0x02004A4B RID: 19019
	[Token(Token = "0x2004A4B")]
	public class InfoDefaultState : State
	{
		// Token: 0x0601C96E RID: 117102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C96E")]
		[Address(RVA = "0x1611A90", Offset = "0x1610690", VA = "0x181611A90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C96F RID: 117103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C96F")]
		[Address(RVA = "0x1611570", Offset = "0x1610170", VA = "0x181611570", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C970 RID: 117104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C970")]
		[Address(RVA = "0x1611210", Offset = "0x160FE10", VA = "0x181611210")]
		public void OnClickHandbook()
		{
		}

		// Token: 0x0601C971 RID: 117105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C971")]
		[Address(RVA = "0x16110D0", Offset = "0x160FCD0", VA = "0x1816110D0")]
		public void OnClickEnemy()
		{
		}

		// Token: 0x0601C972 RID: 117106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C972")]
		[Address(RVA = "0x1611030", Offset = "0x160FC30", VA = "0x181611030")]
		public void OnClickArtGallery()
		{
		}

		// Token: 0x0601C973 RID: 117107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C973")]
		[Address(RVA = "0x1611340", Offset = "0x160FF40", VA = "0x181611340")]
		public void OnClickMedal()
		{
		}

		// Token: 0x0601C974 RID: 117108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C974")]
		[Address(RVA = "0x16113B0", Offset = "0x160FFB0", VA = "0x1816113B0")]
		public void OnClickStory()
		{
		}

		// Token: 0x0601C975 RID: 117109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C975")]
		[Address(RVA = "0x1611420", Offset = "0x1610020", VA = "0x181611420")]
		public void OnClickTrainingCamp()
		{
		}

		// Token: 0x0601C976 RID: 117110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C976")]
		[Address(RVA = "0x1611500", Offset = "0x1610100", VA = "0x181611500")]
		public void OnClickUniEquipArchive()
		{
		}

		// Token: 0x0601C977 RID: 117111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C977")]
		[Address(RVA = "0x1611280", Offset = "0x160FE80", VA = "0x181611280")]
		public void OnClickLockedArtGallery()
		{
		}

		// Token: 0x0601C978 RID: 117112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C978")]
		[Address(RVA = "0x16112E0", Offset = "0x160FEE0", VA = "0x1816112E0")]
		public void OnClickLockedTrainingCamp()
		{
		}

		// Token: 0x0601C979 RID: 117113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C979")]
		[Address(RVA = "0x1610FD0", Offset = "0x160FBD0", VA = "0x181610FD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C97A RID: 117114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C97A")]
		[Address(RVA = "0x1611930", Offset = "0x1610530", VA = "0x181611930", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C97B RID: 117115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C97B")]
		[Address(RVA = "0x1611BE0", Offset = "0x16107E0", VA = "0x181611BE0")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x0601C97C RID: 117116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C97C")]
		[Address(RVA = "0x1612050", Offset = "0x1610C50", VA = "0x181612050")]
		public InfoDefaultState()
		{
		}

		// Token: 0x0601C97D RID: 117117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C97D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601C97E RID: 117118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C97E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04025892 RID: 153746
		[Token(Token = "0x4025892")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonTrackPoint _handbookTrackPoint;

		// Token: 0x04025893 RID: 153747
		[Token(Token = "0x4025893")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _medalTrackPoint;

		// Token: 0x04025894 RID: 153748
		[Token(Token = "0x4025894")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _storyReviewTrackPoint;

		// Token: 0x04025895 RID: 153749
		[Token(Token = "0x4025895")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICommonTrackPoint _handbookUpdatedTrackPoint;

		// Token: 0x04025896 RID: 153750
		[Token(Token = "0x4025896")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UICommonTrackPoint _trainingCampTrackPoint;

		// Token: 0x04025897 RID: 153751
		[Token(Token = "0x4025897")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UICommonTrackPoint _uniEquipArchiveTrackPoint;

		// Token: 0x04025898 RID: 153752
		[Token(Token = "0x4025898")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UICommonTrackPoint _artGalleryEntryTrackPoint;

		// Token: 0x04025899 RID: 153753
		[Token(Token = "0x4025899")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TwoStateToggle _artGalleryEntryBtn;

		// Token: 0x0402589A RID: 153754
		[Token(Token = "0x402589A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TwoStateToggle _trainingCampBtn;

		// Token: 0x0402589B RID: 153755
		[Token(Token = "0x402589B")]
		[FieldOffset(Offset = "0x98")]
		private TrackPointViewProperty m_handbooktrackModel;

		// Token: 0x0402589C RID: 153756
		[Token(Token = "0x402589C")]
		[FieldOffset(Offset = "0xA0")]
		private TrackPointViewProperty m_medalTrackModel;

		// Token: 0x0402589D RID: 153757
		[Token(Token = "0x402589D")]
		[FieldOffset(Offset = "0xA8")]
		private TrackPointViewProperty m_storyReviewTrackModel;

		// Token: 0x0402589E RID: 153758
		[Token(Token = "0x402589E")]
		[FieldOffset(Offset = "0xB0")]
		private TrackPointViewProperty m_handbookupdatedModel;

		// Token: 0x0402589F RID: 153759
		[Token(Token = "0x402589F")]
		[FieldOffset(Offset = "0xB8")]
		private TrackPointViewProperty m_trainingCampModel;

		// Token: 0x040258A0 RID: 153760
		[Token(Token = "0x40258A0")]
		[FieldOffset(Offset = "0xC0")]
		private TrackPointViewProperty m_uniEquipArchiveModel;

		// Token: 0x040258A1 RID: 153761
		[Token(Token = "0x40258A1")]
		[FieldOffset(Offset = "0xC8")]
		private TrackPointViewProperty m_artGalleryModel;

		// Token: 0x040258A2 RID: 153762
		[Token(Token = "0x40258A2")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x040258A3 RID: 153763
		[Token(Token = "0x40258A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040258A4 RID: 153764
		[Token(Token = "0x40258A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040258A5 RID: 153765
		[Token(Token = "0x40258A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickHandbook;

		// Token: 0x040258A6 RID: 153766
		[Token(Token = "0x40258A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickEnemy;

		// Token: 0x040258A7 RID: 153767
		[Token(Token = "0x40258A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickArtGallery;

		// Token: 0x040258A8 RID: 153768
		[Token(Token = "0x40258A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickMedal;

		// Token: 0x040258A9 RID: 153769
		[Token(Token = "0x40258A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickStory;

		// Token: 0x040258AA RID: 153770
		[Token(Token = "0x40258AA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickTrainingCamp;

		// Token: 0x040258AB RID: 153771
		[Token(Token = "0x40258AB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClickUniEquipArchive;

		// Token: 0x040258AC RID: 153772
		[Token(Token = "0x40258AC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClickLockedArtGallery;

		// Token: 0x040258AD RID: 153773
		[Token(Token = "0x40258AD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClickLockedTrainingCamp;

		// Token: 0x040258AE RID: 153774
		[Token(Token = "0x40258AE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040258AF RID: 153775
		[Token(Token = "0x40258AF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040258B0 RID: 153776
		[Token(Token = "0x40258B0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x040258B1 RID: 153777
		[Token(Token = "0x40258B1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
