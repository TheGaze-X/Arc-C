using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F66 RID: 28518
	[Token(Token = "0x2006F66")]
	public class ActMultiV3PhotoAvatarItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287D9 RID: 165849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D9")]
		[Address(RVA = "0x23CD0F0", Offset = "0x23CBCF0", VA = "0x1823CD0F0")]
		public void Render(ActMultiV3PhotoDetailViewModel model, int idx, int selectedIdx)
		{
		}

		// Token: 0x060287DA RID: 165850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287DA")]
		[Address(RVA = "0x23CD010", Offset = "0x23CBC10", VA = "0x1823CD010")]
		public void OnSelectPhoto()
		{
		}

		// Token: 0x060287DB RID: 165851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287DB")]
		[Address(RVA = "0x23CD3E0", Offset = "0x23CBFE0", VA = "0x1823CD3E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287DC RID: 165852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287DC")]
		[Address(RVA = "0x23CD580", Offset = "0x23CC180", VA = "0x1823CD580")]
		public ActMultiV3PhotoAvatarItem()
		{
		}

		// Token: 0x040399E7 RID: 236007
		[Token(Token = "0x40399E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x040399E8 RID: 236008
		[Token(Token = "0x40399E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _comittedPart;

		// Token: 0x040399E9 RID: 236009
		[Token(Token = "0x40399E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedPart;

		// Token: 0x040399EA RID: 236010
		[Token(Token = "0x40399EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _newTrackContainer;

		// Token: 0x040399EB RID: 236011
		[Token(Token = "0x40399EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _newTrackObject;

		// Token: 0x040399EC RID: 236012
		[Token(Token = "0x40399EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _selectHotspotGo;

		// Token: 0x040399ED RID: 236013
		[Token(Token = "0x40399ED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _selectTargetGraphic;

		// Token: 0x040399EE RID: 236014
		[Token(Token = "0x40399EE")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x040399EF RID: 236015
		[Token(Token = "0x40399EF")]
		[FieldOffset(Offset = "0x54")]
		private int m_cachedPhotoIdx;

		// Token: 0x040399F0 RID: 236016
		[Token(Token = "0x40399F0")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040399F1 RID: 236017
		[Token(Token = "0x40399F1")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_newTrackObject;

		// Token: 0x040399F2 RID: 236018
		[Token(Token = "0x40399F2")]
		[FieldOffset(Offset = "0x70")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x040399F3 RID: 236019
		[Token(Token = "0x40399F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040399F4 RID: 236020
		[Token(Token = "0x40399F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelectPhoto;

		// Token: 0x040399F5 RID: 236021
		[Token(Token = "0x40399F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040399F6 RID: 236022
		[Token(Token = "0x40399F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
